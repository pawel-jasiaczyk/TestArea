using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using WfdbToZedGraph;
using WfdbToZedGraph.LocalFilesManager;
using WfdbToZedGraph.WinformControl;
using biomedical_signals_hardware_emulator_winforms;
using WfdbToZedGraph.SamplesConversion;

namespace WinFormsTestField
{
    public partial class Form1 : Form
    {
        private WfdbToZedGraphBinder binder;
        private WfdbRecordWraper record;
        private BezierCurve bezier;
        public Form1()
        {
            InitializeComponent();
            binder = new WfdbToZedGraphBinder();
            binder.AutomaticSetTempLocation();
            SetZedGraph();
            this.wfdbToZedGraphControl1.ZedGraphControl = this.zedGraphControl1;
            this.wfdbToZedGraphControl1.WfdbBinder = binder;
            this.wfdbToZedGraphControl1.AddNewSignal += wfdbToZedGraphControl1_AddNewSignal;
            this.bezier = new BezierCurve(this.zedGraphControl1);
        }

        void wfdbToZedGraphControl1_AddNewSignal(object sender, TreeViewEventArgs e)
        {
            try
            {
                this.wfdbToZedGraphControl1.AddNewSignalMethod(new WfdbSignalWraper(this.bezier.BezierPoinds, "bezier", 0), e.Node);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetZedGraph()
        {
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.PointDateFormat = "0.000";
            this.zedGraphControl1.GraphPane.XAxis.Scale.Min = 0;
            this.zedGraphControl1.GraphPane.XAxis.Scale.Max = 1000;
            this.zedGraphControl1.AutoSize = true;
            this.zedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
            this.zedGraphControl1.GraphPane.YAxis.Scale.Max = 1500;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    record = binder.OpendRecordFromFile(dlg.FileName);
//                    WfdbSignalWraper signal = record.Signals[0];
//                    this.zedGraphControl1.GraphPane.AddCurve("test", signal.GetSamples(), Color.Red, SymbolType.None);
//                    this.zedGraphControl1.AxisChange();
//                    this.zedGraphControl1.Refresh();

                    this.wfdbToZedGraphControl1.TreeNodes.Add(new RecordTreeNode(record));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonTestTree_Click(object sender, EventArgs e)
        {
            RecordTreeNode rec1 = new RecordTreeNode("record 1");
            RecordTreeNode rec2 = new RecordTreeNode("Record 2");

            List<SignalTreeNode> sigs = new List<SignalTreeNode>();
            for (int i = 0; i < 10; i++)
            {
                SignalTreeNode s = new SignalTreeNode(String.Format("Signal {0}", i));
                if(i < 5)
                    rec1.Nodes.Add(s);
                else
                    rec2.Nodes.Add(s);
            }

            this.wfdbToZedGraphControl1.TreeNodes.Add(rec1);
            this.wfdbToZedGraphControl1.TreeNodes.Add(rec2);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //this.signalsTreeView1.LoadToGraph();
        }

        private void zedGraphControlSetWave_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PointF pF = new PointF(e.X, e.Y);
            object nearestObj;
            int index;
            this.zedGraphControl1.GraphPane.FindNearestObject(pF, this.CreateGraphics(), out nearestObj, out index);
            bezier.AddPoint(pF);
        }

        private void buttonTestSave_Click(object sender, EventArgs e)
        {
            SamplesConvertor conv = new SamplesConvertor();
            conv.SamplingFrequency = 100;
            conv.SamplingMode = 0;
            conv.BitResolution = 3;
            try 
            {
                double[] samples = 
                    conv.Sampling(this.bezier.BezierPoinds);
                ConversionWindow convWind = new ConversionWindow();
                convWind.ZedGraphSource.GraphPane.AddCurve("Source", this.bezier.BezierPoinds, Color.Black, SymbolType.Circle);
                convWind.Show();
                convWind.ZedGraphSource.PerformAutoScale();
                convWind.ZedGraphSource.Refresh();
                PointPairList s = new PointPairList();
                for(int i = 0; i < samples.Length; i++)
                    s.Add(new PointPair(i, samples[i]));
                convWind.ZedGraphSamples.GraphPane.AddCurve("Samples", s, Color.Black, SymbolType.Circle);
                convWind.ZedGraphSamples.PerformAutoScale();
                convWind.ZedGraphSamples.Refresh();

            }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
    }
}
