using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ZedGraph;
using System.IO.Ports;
using biomedical_signals_hardware_emulator_winforms.DataConnections;
using WfdbToZedGraph;
using WfdbToZedGraph.LocalFilesManager;

namespace biomedical_signals_hardware_emulator_winforms
{
    public partial class MainWindow : Form
    {
        #region Data fields
        ConverterConfigurator converterConfigurator;

        private string timeScale = "s";
        private int timeScaleValue = 100;
        private int currentScaleMaxValue = 100;
        private int currentScaleMinValue = -100;

        BezierCurve bezier;
        PointPairList pointPairList = new PointPairList();

        private DataConnection dataConnections;
        private WfdbToZedGraphBinder binder;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            this.bezier = new BezierCurve(zedGraphControlSetWave);
            this.converterConfigurator = new ConverterConfigurator();

            this.dataConnections = new DataConnection();

            // binder settings
            this.binder = new WfdbToZedGraphBinder();
            this.binder.AutomaticSetTempLocation(); // Update, when make constructors update in binder

            this.wfdbToZedGraphControl1.ZedGraphControl = this.zedGraphControlSetWave;
            this.wfdbToZedGraphControl1.WfdbBinder = this.binder;
            this.wfdbToZedGraphControl1.AddNewSignal += wfdbToZedGraphControl1_AddNewSignal;
        }

        void wfdbToZedGraphControl1_AddNewSignal(object sender, TreeViewEventArgs e)
        {
            WfdbSignalWraper sig = 
                new WfdbSignalWraper(this.bezier.UserPoints, "test", 0);
            this.wfdbToZedGraphControl1.AddNewSignalMethod(sig, e.Node);
        }

        private void setPinoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converterConfigurator.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            setup_zedGraph();
            mainWindowStatusLabel.Text = "hello!";
        }

        #region ZedGraph setup_zedGraph() - Chart startup setup
        /// <summary>
        /// ZedGraph chart startup setup
        /// </summary>
        private void setup_zedGraph()
        {
            zedGraphControlSetWave.IsShowPointValues = true;
            zedGraphControlSetWave.PointValueFormat = "0.000";
            
            zedGraphControlSetWave.GraphPane.Title.Text = "User's chart";

            zedGraphControlSetWave.GraphPane.XAxis.Title.Text = "Time [" + timeScale + "]";
            zedGraphControlSetWave.GraphPane.XAxis.Scale.Min = 0;
            zedGraphControlSetWave.GraphPane.XAxis.Scale.Max = timeScaleValue;

            zedGraphControlSetWave.GraphPane.YAxis.Title.Text = "Current [nA]";
            zedGraphControlSetWave.GraphPane.YAxis.Scale.Min = currentScaleMinValue;
            zedGraphControlSetWave.GraphPane.YAxis.Scale.Max = currentScaleMaxValue;

            zedGraphControlSetWave.AxisChange();
            zedGraphControlSetWave.Refresh();
        }
        #endregion
        private void zedGraphControlSetWave_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void zedGraphControlSetWave_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PointF pF = new PointF(e.X, e.Y);
            object nearestObj;
            int index;
            this.zedGraphControlSetWave.GraphPane.FindNearestObject(pF, this.CreateGraphics(), out nearestObj, out index);
            bezier.AddPoint(pF);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            bezier.Clear();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            bezier.Reverse();
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.FileName;
                try 
                {
                    this.zedGraphControlSetWave.AutoSize = true;
                    WfdbRecordWraper rec = this.binder.OpendRecordFromFile(path);
                    //this.zedGraphControlSetWave.OpenRecord(path);
                    this.wfdbToZedGraphControl1.TreeNodes.Add(new WfdbToZedGraph.WinformControl.RecordTreeNode(rec));
                    // this.pointPairList = this.zedGraphControlSetWave.Points[0];
                    // this.pointPairList = rec.Signals[0].GetSamples();

                    // this.zedGraphControlSetWave.GraphPane.YAxis.Scale.Min = 0;
                    // this.zedGraphControlSetWave.GraphPane.YAxis.Scale.Max = 1500;
                    //LineItem curve = this.zedGraphControlSetWave.GraphPane.AddCurve(
                    //    "Test", this.zedGraphControlSetWave.Points[0], Color.Red, SymbolType.Circle);
                    //LineItem curve = this.zedGraphControlSetWave.GraphPane.AddCurve(
                    //    "test", rec.Signals[0].GetSamples(), Color.Black, SymbolType.None);
                    //this.zedGraphControlSetWave.AxisChange();
                    //this.zedGraphControlSetWave.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + " path: " + path);
                }
            }
            
            // pointPairList.Reverse();
            // zedGraphControlSetWave.Refresh();
        }

        private void button_connectBoard_Click(object sender, EventArgs e)
        {
            if (this.dataConnections.Port.IsOpen)
            {
                this.dataConnections.ClosePort();
                button_connectBoard.Text = "Connect";
                comboBox_ComPort.SelectedIndex = -1;
            }
            else
            {

                this.dataConnections.OpenPort(this.comboBox_ComPort.Text);
                button_connectBoard.Text = "Disconnect";
            }
        }

        private void comboBox_ComPort_Click(object sender, EventArgs e)
        {
            comboBox_ComPort.Items.Clear();
            // Fast read all available COM ports
            string[] ports = this.dataConnections.GetSerialPorts();
            if (ports.Length == 0)
                button_connectBoard.Enabled = false;
            // Include all COM ports to combox
            foreach (string port in ports)
            {
                comboBox_ComPort.Items.Add(port);
            }
        }

        private void comboBox_ComPort_SelectedValueChanged(object sender, EventArgs e)
        {
            if (-1 < comboBox_ComPort.SelectedIndex)
            {
                button_connectBoard.Enabled = true;
            }
            else button_connectBoard.Enabled = false;
        }

        private void button_serialTest_Click(object sender, EventArgs e)
        {
            dataConnections.WriteLine("abca");
        }

        private string zedGraphControlSetWave_PointEditEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            if (pane.CurveList.ElementAt(0).Label.Text == curve.Label.Text)
                bezier.EditPoint(curve[iPt], iPt);
            return "ok";
        }
    }
}
            
