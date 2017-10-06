namespace biomedical_signals_hardware_emulator_winforms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStripMainWindow = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveformToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveformToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPinoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipMainWindow = new System.Windows.Forms.ToolTip(this.components);
            this.button_connectBoard = new System.Windows.Forms.Button();
            this.comboBox_ComPort = new System.Windows.Forms.ComboBox();
            this.toolStripMainWindow = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.statusStripMainWindow = new System.Windows.Forms.StatusStrip();
            this.mainWindowStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMainWindowWaveforms = new System.Windows.Forms.TabControl();
            this.tabPageWaveform = new System.Windows.Forms.TabPage();
            this.zedGraphControlSetWave = new ZedGraph.ZedGraphControl();
            this.tabControlMainWindowSettings = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxTimeScaleValue = new System.Windows.Forms.TextBox();
            this.textBoxCurrentScaleMaxValue = new System.Windows.Forms.TextBox();
            this.textBoxCurrentScaleMinValue = new System.Windows.Forms.TextBox();
            this.lbl_currentScaleMaxValue = new System.Windows.Forms.Label();
            this.comboBoxTimeScale = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrentScale = new System.Windows.Forms.ComboBox();
            this.lbl_currentScaleMinValue = new System.Windows.Forms.Label();
            this.lbl_timeScaleValue = new System.Windows.Forms.Label();
            this.lbl_currentScale = new System.Windows.Forms.Label();
            this.lbl_timeScale = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_serialTest = new System.Windows.Forms.Button();
            this.lbl_boardConnection = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wfdbToZedGraphControl1 = new WfdbToZedGraph.WinformControl.WfdbToZedGraphControl();
            this.menuStripMainWindow.SuspendLayout();
            this.toolStripMainWindow.SuspendLayout();
            this.statusStripMainWindow.SuspendLayout();
            this.tabControlMainWindowWaveforms.SuspendLayout();
            this.tabPageWaveform.SuspendLayout();
            this.tabControlMainWindowSettings.SuspendLayout();
            this.tabPage0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainWindow
            // 
            this.menuStripMainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStripMainWindow, "menuStripMainWindow");
            this.menuStripMainWindow.Name = "menuStripMainWindow";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waveformToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            // 
            // waveformToolStripMenuItem
            // 
            this.waveformToolStripMenuItem.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.VSO_NewFile_40x;
            this.waveformToolStripMenuItem.Name = "waveformToolStripMenuItem";
            resources.ApplyResources(this.waveformToolStripMenuItem, "waveformToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waveformToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // waveformToolStripMenuItem1
            // 
            this.waveformToolStripMenuItem1.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.OpenFolder_32x;
            this.waveformToolStripMenuItem1.Name = "waveformToolStripMenuItem1";
            resources.ApplyResources(this.waveformToolStripMenuItem1, "waveformToolStripMenuItem1");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waveformToolStripMenuItem2});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // waveformToolStripMenuItem2
            // 
            this.waveformToolStripMenuItem2.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.VSO_SaveAs_16x;
            this.waveformToolStripMenuItem2.Name = "waveformToolStripMenuItem2";
            resources.ApplyResources(this.waveformToolStripMenuItem2, "waveformToolStripMenuItem2");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.CloseSolution_32x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPinoutToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // setPinoutToolStripMenuItem
            // 
            this.setPinoutToolStripMenuItem.Name = "setPinoutToolStripMenuItem";
            resources.ApplyResources(this.setPinoutToolStripMenuItem, "setPinoutToolStripMenuItem");
            this.setPinoutToolStripMenuItem.Click += new System.EventHandler(this.setPinoutToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            resources.ApplyResources(this.polishToolStripMenuItem, "polishToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            resources.ApplyResources(this.documentationToolStripMenuItem, "documentationToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // button_connectBoard
            // 
            resources.ApplyResources(this.button_connectBoard, "button_connectBoard");
            this.button_connectBoard.Name = "button_connectBoard";
            this.toolTipMainWindow.SetToolTip(this.button_connectBoard, resources.GetString("button_connectBoard.ToolTip"));
            this.button_connectBoard.UseVisualStyleBackColor = true;
            this.button_connectBoard.Click += new System.EventHandler(this.button_connectBoard_Click);
            // 
            // comboBox_ComPort
            // 
            this.comboBox_ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ComPort.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_ComPort, "comboBox_ComPort");
            this.comboBox_ComPort.Name = "comboBox_ComPort";
            this.toolTipMainWindow.SetToolTip(this.comboBox_ComPort, resources.GetString("comboBox_ComPort.ToolTip"));
            this.comboBox_ComPort.SelectedValueChanged += new System.EventHandler(this.comboBox_ComPort_SelectedValueChanged);
            this.comboBox_ComPort.Click += new System.EventHandler(this.comboBox_ComPort_Click);
            // 
            // toolStripMainWindow
            // 
            this.toolStripMainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave});
            resources.ApplyResources(this.toolStripMainWindow, "toolStripMainWindow");
            this.toolStripMainWindow.Name = "toolStripMainWindow";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.VSO_NewFile_40x;
            resources.ApplyResources(this.toolStripButtonNew, "toolStripButtonNew");
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.OpenFolder_32x;
            resources.ApplyResources(this.toolStripButtonOpen, "toolStripButtonOpen");
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::biomedical_signals_hardware_emulator_winforms.Properties.Resources.Save_32x;
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            // 
            // statusStripMainWindow
            // 
            this.statusStripMainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWindowStatusLabel});
            resources.ApplyResources(this.statusStripMainWindow, "statusStripMainWindow");
            this.statusStripMainWindow.Name = "statusStripMainWindow";
            // 
            // mainWindowStatusLabel
            // 
            this.mainWindowStatusLabel.Name = "mainWindowStatusLabel";
            resources.ApplyResources(this.mainWindowStatusLabel, "mainWindowStatusLabel");
            // 
            // tabControlMainWindowWaveforms
            // 
            resources.ApplyResources(this.tabControlMainWindowWaveforms, "tabControlMainWindowWaveforms");
            this.tabControlMainWindowWaveforms.Controls.Add(this.tabPageWaveform);
            this.tabControlMainWindowWaveforms.Name = "tabControlMainWindowWaveforms";
            this.tabControlMainWindowWaveforms.SelectedIndex = 0;
            // 
            // tabPageWaveform
            // 
            this.tabPageWaveform.Controls.Add(this.zedGraphControlSetWave);
            resources.ApplyResources(this.tabPageWaveform, "tabPageWaveform");
            this.tabPageWaveform.Name = "tabPageWaveform";
            this.tabPageWaveform.UseVisualStyleBackColor = true;
            // 
            // zedGraphControlSetWave
            // 
            resources.ApplyResources(this.zedGraphControlSetWave, "zedGraphControlSetWave");
            this.zedGraphControlSetWave.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zedGraphControlSetWave.IsAntiAlias = true;
            this.zedGraphControlSetWave.IsEnableHEdit = true;
            this.zedGraphControlSetWave.IsEnableSelection = true;
            this.zedGraphControlSetWave.IsEnableVEdit = true;
            this.zedGraphControlSetWave.Name = "zedGraphControlSetWave";
            this.zedGraphControlSetWave.ScrollGrace = 0D;
            this.zedGraphControlSetWave.ScrollMaxX = 0D;
            this.zedGraphControlSetWave.ScrollMaxY = 0D;
            this.zedGraphControlSetWave.ScrollMaxY2 = 0D;
            this.zedGraphControlSetWave.ScrollMinX = 0D;
            this.zedGraphControlSetWave.ScrollMinY = 0D;
            this.zedGraphControlSetWave.ScrollMinY2 = 0D;
            this.zedGraphControlSetWave.UseExtendedPrintDialog = true;
            this.zedGraphControlSetWave.PointEditEvent += new ZedGraph.ZedGraphControl.PointEditHandler(this.zedGraphControlSetWave_PointEditEvent);
            this.zedGraphControlSetWave.Paint += new System.Windows.Forms.PaintEventHandler(this.zedGraphControlSetWave_Paint);
            this.zedGraphControlSetWave.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlSetWave_MouseDoubleClick);
            // 
            // tabControlMainWindowSettings
            // 
            resources.ApplyResources(this.tabControlMainWindowSettings, "tabControlMainWindowSettings");
            this.tabControlMainWindowSettings.Controls.Add(this.tabPage0);
            this.tabControlMainWindowSettings.Controls.Add(this.tabPage1);
            this.tabControlMainWindowSettings.Controls.Add(this.tabPage2);
            this.tabControlMainWindowSettings.Name = "tabControlMainWindowSettings";
            this.tabControlMainWindowSettings.SelectedIndex = 0;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.numericUpDown1);
            this.tabPage0.Controls.Add(this.textBoxTimeScaleValue);
            this.tabPage0.Controls.Add(this.textBoxCurrentScaleMaxValue);
            this.tabPage0.Controls.Add(this.textBoxCurrentScaleMinValue);
            this.tabPage0.Controls.Add(this.lbl_currentScaleMaxValue);
            this.tabPage0.Controls.Add(this.comboBoxTimeScale);
            this.tabPage0.Controls.Add(this.comboBoxCurrentScale);
            this.tabPage0.Controls.Add(this.lbl_currentScaleMinValue);
            this.tabPage0.Controls.Add(this.lbl_timeScaleValue);
            this.tabPage0.Controls.Add(this.lbl_currentScale);
            this.tabPage0.Controls.Add(this.lbl_timeScale);
            resources.ApplyResources(this.tabPage0, "tabPage0");
            this.tabPage0.Name = "tabPage0";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // textBoxTimeScaleValue
            // 
            resources.ApplyResources(this.textBoxTimeScaleValue, "textBoxTimeScaleValue");
            this.textBoxTimeScaleValue.Name = "textBoxTimeScaleValue";
            // 
            // textBoxCurrentScaleMaxValue
            // 
            resources.ApplyResources(this.textBoxCurrentScaleMaxValue, "textBoxCurrentScaleMaxValue");
            this.textBoxCurrentScaleMaxValue.Name = "textBoxCurrentScaleMaxValue";
            // 
            // textBoxCurrentScaleMinValue
            // 
            resources.ApplyResources(this.textBoxCurrentScaleMinValue, "textBoxCurrentScaleMinValue");
            this.textBoxCurrentScaleMinValue.Name = "textBoxCurrentScaleMinValue";
            // 
            // lbl_currentScaleMaxValue
            // 
            resources.ApplyResources(this.lbl_currentScaleMaxValue, "lbl_currentScaleMaxValue");
            this.lbl_currentScaleMaxValue.Name = "lbl_currentScaleMaxValue";
            // 
            // comboBoxTimeScale
            // 
            this.comboBoxTimeScale.FormattingEnabled = true;
            this.comboBoxTimeScale.Items.AddRange(new object[] {
            resources.GetString("comboBoxTimeScale.Items"),
            resources.GetString("comboBoxTimeScale.Items1"),
            resources.GetString("comboBoxTimeScale.Items2"),
            resources.GetString("comboBoxTimeScale.Items3")});
            resources.ApplyResources(this.comboBoxTimeScale, "comboBoxTimeScale");
            this.comboBoxTimeScale.Name = "comboBoxTimeScale";
            // 
            // comboBoxCurrentScale
            // 
            this.comboBoxCurrentScale.FormattingEnabled = true;
            this.comboBoxCurrentScale.Items.AddRange(new object[] {
            resources.GetString("comboBoxCurrentScale.Items"),
            resources.GetString("comboBoxCurrentScale.Items1")});
            resources.ApplyResources(this.comboBoxCurrentScale, "comboBoxCurrentScale");
            this.comboBoxCurrentScale.Name = "comboBoxCurrentScale";
            // 
            // lbl_currentScaleMinValue
            // 
            resources.ApplyResources(this.lbl_currentScaleMinValue, "lbl_currentScaleMinValue");
            this.lbl_currentScaleMinValue.Name = "lbl_currentScaleMinValue";
            // 
            // lbl_timeScaleValue
            // 
            resources.ApplyResources(this.lbl_timeScaleValue, "lbl_timeScaleValue");
            this.lbl_timeScaleValue.Name = "lbl_timeScaleValue";
            // 
            // lbl_currentScale
            // 
            resources.ApplyResources(this.lbl_currentScale, "lbl_currentScale");
            this.lbl_currentScale.Name = "lbl_currentScale";
            // 
            // lbl_timeScale
            // 
            resources.ApplyResources(this.lbl_timeScale, "lbl_timeScale");
            this.lbl_timeScale.Name = "lbl_timeScale";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_serialTest);
            this.tabPage1.Controls.Add(this.comboBox_ComPort);
            this.tabPage1.Controls.Add(this.lbl_boardConnection);
            this.tabPage1.Controls.Add(this.button_connectBoard);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // button_serialTest
            // 
            resources.ApplyResources(this.button_serialTest, "button_serialTest");
            this.button_serialTest.Name = "button_serialTest";
            this.button_serialTest.UseVisualStyleBackColor = true;
            this.button_serialTest.Click += new System.EventHandler(this.button_serialTest_Click);
            // 
            // lbl_boardConnection
            // 
            resources.ApplyResources(this.lbl_boardConnection, "lbl_boardConnection");
            this.lbl_boardConnection.Name = "lbl_boardConnection";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.wfdbToZedGraphControl1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wfdbToZedGraphControl1
            // 
            resources.ApplyResources(this.wfdbToZedGraphControl1, "wfdbToZedGraphControl1");
            this.wfdbToZedGraphControl1.Name = "wfdbToZedGraphControl1";
            this.wfdbToZedGraphControl1.WfdbBinder = null;
            this.wfdbToZedGraphControl1.ZedGraphControl = null;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMainWindowSettings);
            this.Controls.Add(this.tabControlMainWindowWaveforms);
            this.Controls.Add(this.statusStripMainWindow);
            this.Controls.Add(this.toolStripMainWindow);
            this.Controls.Add(this.menuStripMainWindow);
            this.MainMenuStrip = this.menuStripMainWindow;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStripMainWindow.ResumeLayout(false);
            this.menuStripMainWindow.PerformLayout();
            this.toolStripMainWindow.ResumeLayout(false);
            this.toolStripMainWindow.PerformLayout();
            this.statusStripMainWindow.ResumeLayout(false);
            this.statusStripMainWindow.PerformLayout();
            this.tabControlMainWindowWaveforms.ResumeLayout(false);
            this.tabPageWaveform.ResumeLayout(false);
            this.tabControlMainWindowSettings.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainWindow;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipMainWindow;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPinoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveformToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMainWindow;
        private System.Windows.Forms.ToolStripMenuItem waveformToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMainWindow;
        private System.Windows.Forms.TabControl tabControlMainWindowWaveforms;
        private System.Windows.Forms.TabPage tabPageWaveform;
        private System.Windows.Forms.TabControl tabControlMainWindowSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        //private ZedGraphForWfdb.ZedGraphForWfdbiControl zedGraphControlSetWave;
        private ZedGraph.ZedGraphControl zedGraphControlSetWave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Label lbl_currentScaleMinValue;
        private System.Windows.Forms.Label lbl_timeScaleValue;
        private System.Windows.Forms.Label lbl_currentScale;
        private System.Windows.Forms.Label lbl_timeScale;
        private System.Windows.Forms.ComboBox comboBoxTimeScale;
        private System.Windows.Forms.ComboBox comboBoxCurrentScale;
        private System.Windows.Forms.TextBox textBoxTimeScaleValue;
        private System.Windows.Forms.TextBox textBoxCurrentScaleMaxValue;
        private System.Windows.Forms.TextBox textBoxCurrentScaleMinValue;
        private System.Windows.Forms.Label lbl_currentScaleMaxValue;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripStatusLabel mainWindowStatusLabel;
        private System.Windows.Forms.Label lbl_boardConnection;
        private System.Windows.Forms.Button button_connectBoard;
        private System.Windows.Forms.ComboBox comboBox_ComPort;
        private System.Windows.Forms.Button button_serialTest;
        private System.Windows.Forms.TabPage tabPage2;
        private WfdbToZedGraph.WinformControl.WfdbToZedGraphControl wfdbToZedGraphControl1;
    }
}

