namespace WinFormsTestField
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonTestTree = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.wfdbToZedGraphControl1 = new WfdbToZedGraph.WinformControl.WfdbToZedGraphControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.buttonTestSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.zedGraphControl1);
            this.splitContainer1.Size = new System.Drawing.Size(657, 734);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonTestSave);
            this.splitContainer2.Panel1.Controls.Add(this.buttonLoad);
            this.splitContainer2.Panel1.Controls.Add(this.buttonTestTree);
            this.splitContainer2.Panel1.Controls.Add(this.buttonOpenFile);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.wfdbToZedGraphControl1);
            this.splitContainer2.Size = new System.Drawing.Size(182, 734);
            this.splitContainer2.SplitterDistance = 286;
            this.splitContainer2.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(3, 84);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(175, 35);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load To Graph";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonTestTree
            // 
            this.buttonTestTree.Location = new System.Drawing.Point(0, 43);
            this.buttonTestTree.Name = "buttonTestTree";
            this.buttonTestTree.Size = new System.Drawing.Size(178, 35);
            this.buttonTestTree.TabIndex = 1;
            this.buttonTestTree.Text = "Test Tree";
            this.buttonTestTree.UseVisualStyleBackColor = true;
            this.buttonTestTree.Click += new System.EventHandler(this.buttonTestTree_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(0, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(178, 34);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "OpenFile";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // wfdbToZedGraphControl1
            // 
            this.wfdbToZedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfdbToZedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.wfdbToZedGraphControl1.Name = "wfdbToZedGraphControl1";
            this.wfdbToZedGraphControl1.Size = new System.Drawing.Size(182, 444);
            this.wfdbToZedGraphControl1.TabIndex = 0;
            this.wfdbToZedGraphControl1.WfdbBinder = null;
            this.wfdbToZedGraphControl1.ZedGraphControl = null;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(471, 734);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlSetWave_MouseDoubleClick);
            // 
            // buttonTestSave
            // 
            this.buttonTestSave.Location = new System.Drawing.Point(3, 125);
            this.buttonTestSave.Name = "buttonTestSave";
            this.buttonTestSave.Size = new System.Drawing.Size(175, 39);
            this.buttonTestSave.TabIndex = 3;
            this.buttonTestSave.Text = "TestSave";
            this.buttonTestSave.UseVisualStyleBackColor = true;
            this.buttonTestSave.Click += new System.EventHandler(this.buttonTestSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 734);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonTestTree;
        private System.Windows.Forms.Button buttonLoad;
        private WfdbToZedGraph.WinformControl.WfdbToZedGraphControl wfdbToZedGraphControl1;
        private System.Windows.Forms.Button buttonTestSave;
    }
}

