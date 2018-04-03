namespace EngineeringCompetitionTest
{
    partial class GaugeSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaugeSimulator));
            GaugeControl.GaugeLabel gaugeLabel1 = new GaugeControl.GaugeLabel();
            GaugeControl.GaugeLabel gaugeLabel2 = new GaugeControl.GaugeLabel();
            GaugeControl.GaugeTickMarker gaugeTickMarker1 = new GaugeControl.GaugeTickMarker();
            GaugeControl.GaugeLabel gaugeLabel3 = new GaugeControl.GaugeLabel();
            GaugeControl.GaugeTickMarker gaugeTickMarker2 = new GaugeControl.GaugeTickMarker();
            GaugeControl.GaugeLabel gaugeLabel4 = new GaugeControl.GaugeLabel();
            GaugeControl.GaugeTickMarker gaugeTickMarker3 = new GaugeControl.GaugeTickMarker();
            GaugeControl.GaugeTickMarker gaugeTickMarker4 = new GaugeControl.GaugeTickMarker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxPSPPortSelect = new System.Windows.Forms.ComboBox();
            this.buttonOpenPSPPort = new System.Windows.Forms.Button();
            this.buttonClosePSPPort = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCloseMSSIMPort = new System.Windows.Forms.Button();
            this.comboBoxMSSIM2Port = new System.Windows.Forms.ComboBox();
            this.buttonOpenMSSIMPort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonRunScript = new System.Windows.Forms.Button();
            this.buttonLoadScriptFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDownVoltage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRPM = new System.Windows.Forms.NumericUpDown();
            this.gaugeRPM = new GaugeControl.Gauge();
            this.gaugeVoltage = new GaugeControl.Gauge();
            this.gaugeFrequency = new GaugeControl.Gauge();
            this.gaugeSpeed = new GaugeControl.Gauge();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRPM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM ports";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxPSPPortSelect);
            this.groupBox4.Controls.Add(this.buttonOpenPSPPort);
            this.groupBox4.Controls.Add(this.buttonClosePSPPort);
            this.groupBox4.Location = new System.Drawing.Point(6, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 92);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PSP port";
            // 
            // comboBoxPSPPortSelect
            // 
            this.comboBoxPSPPortSelect.FormattingEnabled = true;
            this.comboBoxPSPPortSelect.Location = new System.Drawing.Point(89, 23);
            this.comboBoxPSPPortSelect.Name = "comboBoxPSPPortSelect";
            this.comboBoxPSPPortSelect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPSPPortSelect.TabIndex = 2;
            // 
            // buttonOpenPSPPort
            // 
            this.buttonOpenPSPPort.Location = new System.Drawing.Point(4, 19);
            this.buttonOpenPSPPort.Name = "buttonOpenPSPPort";
            this.buttonOpenPSPPort.Size = new System.Drawing.Size(79, 30);
            this.buttonOpenPSPPort.TabIndex = 3;
            this.buttonOpenPSPPort.Text = "Open";
            this.buttonOpenPSPPort.UseVisualStyleBackColor = true;
            this.buttonOpenPSPPort.Click += new System.EventHandler(this.buttonOpenPSPPort_Click);
            // 
            // buttonClosePSPPort
            // 
            this.buttonClosePSPPort.Location = new System.Drawing.Point(4, 55);
            this.buttonClosePSPPort.Name = "buttonClosePSPPort";
            this.buttonClosePSPPort.Size = new System.Drawing.Size(79, 30);
            this.buttonClosePSPPort.TabIndex = 4;
            this.buttonClosePSPPort.Text = "Close";
            this.buttonClosePSPPort.UseVisualStyleBackColor = true;
            this.buttonClosePSPPort.Click += new System.EventHandler(this.buttonClosePSPPort_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCloseMSSIMPort);
            this.groupBox3.Controls.Add(this.comboBoxMSSIM2Port);
            this.groupBox3.Controls.Add(this.buttonOpenMSSIMPort);
            this.groupBox3.Location = new System.Drawing.Point(761, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 92);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MSSIM2 port";
            // 
            // buttonCloseMSSIMPort
            // 
            this.buttonCloseMSSIMPort.Location = new System.Drawing.Point(39, 50);
            this.buttonCloseMSSIMPort.Name = "buttonCloseMSSIMPort";
            this.buttonCloseMSSIMPort.Size = new System.Drawing.Size(79, 30);
            this.buttonCloseMSSIMPort.TabIndex = 7;
            this.buttonCloseMSSIMPort.Text = "Close";
            this.buttonCloseMSSIMPort.UseVisualStyleBackColor = true;
            this.buttonCloseMSSIMPort.Click += new System.EventHandler(this.buttonCloseMSSIMPort_Click);
            // 
            // comboBoxMSSIM2Port
            // 
            this.comboBoxMSSIM2Port.FormattingEnabled = true;
            this.comboBoxMSSIM2Port.Location = new System.Drawing.Point(124, 23);
            this.comboBoxMSSIM2Port.Name = "comboBoxMSSIM2Port";
            this.comboBoxMSSIM2Port.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMSSIM2Port.TabIndex = 5;
            // 
            // buttonOpenMSSIMPort
            // 
            this.buttonOpenMSSIMPort.Location = new System.Drawing.Point(39, 19);
            this.buttonOpenMSSIMPort.Name = "buttonOpenMSSIMPort";
            this.buttonOpenMSSIMPort.Size = new System.Drawing.Size(79, 30);
            this.buttonOpenMSSIMPort.TabIndex = 6;
            this.buttonOpenMSSIMPort.Text = "Open";
            this.buttonOpenMSSIMPort.UseVisualStyleBackColor = true;
            this.buttonOpenMSSIMPort.Click += new System.EventHandler(this.buttonOpenMSSIMPort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFileName);
            this.groupBox2.Controls.Add(this.buttonRunScript);
            this.groupBox2.Controls.Add(this.buttonLoadScriptFile);
            this.groupBox2.Location = new System.Drawing.Point(314, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 92);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Script";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(64, 16);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(242, 22);
            this.textBoxFileName.TabIndex = 17;
            // 
            // buttonRunScript
            // 
            this.buttonRunScript.Location = new System.Drawing.Point(312, 49);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(120, 33);
            this.buttonRunScript.TabIndex = 16;
            this.buttonRunScript.Text = "Run Script";
            this.buttonRunScript.UseVisualStyleBackColor = true;
            this.buttonRunScript.Click += new System.EventHandler(this.buttonRunScript_Click);
            // 
            // buttonLoadScriptFile
            // 
            this.buttonLoadScriptFile.Location = new System.Drawing.Point(312, 12);
            this.buttonLoadScriptFile.Name = "buttonLoadScriptFile";
            this.buttonLoadScriptFile.Size = new System.Drawing.Size(120, 31);
            this.buttonLoadScriptFile.TabIndex = 18;
            this.buttonLoadScriptFile.Text = "Load Script";
            this.buttonLoadScriptFile.UseVisualStyleBackColor = true;
            this.buttonLoadScriptFile.Click += new System.EventHandler(this.buttonLoadScriptFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 581);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1075, 136);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // numericUpDownVoltage
            // 
            this.numericUpDownVoltage.DecimalPlaces = 2;
            this.numericUpDownVoltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownVoltage.Location = new System.Drawing.Point(299, 392);
            this.numericUpDownVoltage.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownVoltage.Name = "numericUpDownVoltage";
            this.numericUpDownVoltage.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownVoltage.TabIndex = 5;
            this.numericUpDownVoltage.ValueChanged += new System.EventHandler(this.numericUpDownVoltage_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(180, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voltage";
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(799, 397);
            this.numericUpDownFrequency.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFrequency.TabIndex = 11;
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.numericUpDownFrequency_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(644, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Frequency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(884, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Speed";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.numericUpDownSpeed);
            this.groupBox5.Controls.Add(this.numericUpDownRPM);
            this.groupBox5.Controls.Add(this.gaugeRPM);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.gaugeVoltage);
            this.groupBox5.Controls.Add(this.gaugeFrequency);
            this.groupBox5.Controls.Add(this.numericUpDownVoltage);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.numericUpDownFrequency);
            this.groupBox5.Controls.Add(this.gaugeSpeed);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(9, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1069, 439);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gauges";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Auto Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(837, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(14, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "RPM";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(941, 303);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 16;
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // numericUpDownRPM
            // 
            this.numericUpDownRPM.Location = new System.Drawing.Point(95, 287);
            this.numericUpDownRPM.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.numericUpDownRPM.Name = "numericUpDownRPM";
            this.numericUpDownRPM.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRPM.TabIndex = 15;
            this.numericUpDownRPM.ValueChanged += new System.EventHandler(this.numericUpDownRPM_ValueChanged);
            // 
            // gaugeRPM
            // 
            this.gaugeRPM.ArcColor = System.Drawing.Color.White;
            this.gaugeRPM.ArcEndAngle = 390F;
            this.gaugeRPM.ArcRadius = 110F;
            this.gaugeRPM.ArcStartAngle = 150F;
            this.gaugeRPM.ArcWidth = 3F;
            this.gaugeRPM.BackColor = System.Drawing.Color.Transparent;
            this.gaugeRPM.BackGroundEllipseColor = System.Drawing.Color.Black;
            this.gaugeRPM.BorderColor = System.Drawing.Color.Black;
            this.gaugeRPM.BorderEnabled = true;
            this.gaugeRPM.BorderWidth = 7F;
            this.gaugeRPM.isArcEnabled = true;
            this.gaugeRPM.isCustomNeedleEnabled = false;
            gaugeLabel1.Name = "GaugeLabel 0";
            gaugeLabel1.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeLabel1.OffsetY = new decimal(new int[] {
            24,
            0,
            0,
            0});
            gaugeLabel1.Text = "RPM";
            gaugeLabel1.TextColor = System.Drawing.Color.White;
            gaugeLabel1.TextFont = new System.Drawing.Font("Arial", 12F);
            this.gaugeRPM.Labels.Add(gaugeLabel1);
            this.gaugeRPM.Location = new System.Drawing.Point(20, 21);
            this.gaugeRPM.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaugeRPM.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeRPM.Name = "gaugeRPM";
            this.gaugeRPM.NeedleCenterColor = System.Drawing.Color.Gray;
            this.gaugeRPM.NeedleCenterRadius = 15F;
            this.gaugeRPM.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeRPM.NeedleImage = null;
            this.gaugeRPM.NeedleSize = new System.Drawing.Size(6, 85);
            this.gaugeRPM.NumberMarkerAngleBegin = 150F;
            this.gaugeRPM.NumberMarkerAngleEnd = 390F;
            this.gaugeRPM.NumberMarkerAngleInterval = 34F;
            this.gaugeRPM.NumberMarkerColor = System.Drawing.Color.White;
            this.gaugeRPM.NumberMarkerFont = new System.Drawing.Font("Tahoma", 8F);
            this.gaugeRPM.NumberMarkerHeight = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gaugeRPM.NumberMarkerOffset = -18;
            this.gaugeRPM.NumberMarkerValueBegin = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeRPM.NumberMarkerValueInterval = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.gaugeRPM.NumberMarkerWidth = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.gaugeRPM.Size = new System.Drawing.Size(265, 260);
            this.gaugeRPM.TabIndex = 7;
            this.gaugeRPM.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // gaugeVoltage
            // 
            this.gaugeVoltage.ArcColor = System.Drawing.Color.White;
            this.gaugeVoltage.ArcEndAngle = 430F;
            this.gaugeVoltage.ArcRadius = 85F;
            this.gaugeVoltage.ArcStartAngle = 110F;
            this.gaugeVoltage.ArcWidth = 3F;
            this.gaugeVoltage.BackColor = System.Drawing.Color.Transparent;
            this.gaugeVoltage.BackGroundEllipseColor = System.Drawing.Color.Black;
            this.gaugeVoltage.BorderColor = System.Drawing.Color.Black;
            this.gaugeVoltage.BorderEnabled = true;
            this.gaugeVoltage.BorderWidth = 8F;
            this.gaugeVoltage.isArcEnabled = true;
            this.gaugeVoltage.isCustomNeedleEnabled = false;
            gaugeLabel2.Name = "GaugeElement";
            gaugeLabel2.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeLabel2.OffsetY = new decimal(new int[] {
            18,
            0,
            0,
            0});
            gaugeLabel2.Text = "V-DC";
            gaugeLabel2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            gaugeLabel2.TextFont = new System.Drawing.Font("Arial", 10F);
            this.gaugeVoltage.Labels.Add(gaugeLabel2);
            this.gaugeVoltage.Location = new System.Drawing.Point(250, 180);
            this.gaugeVoltage.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaugeVoltage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeVoltage.Name = "gaugeVoltage";
            this.gaugeVoltage.NeedleCenterColor = System.Drawing.Color.Chocolate;
            this.gaugeVoltage.NeedleCenterRadius = 14F;
            this.gaugeVoltage.NeedleColor = System.Drawing.Color.Red;
            this.gaugeVoltage.NeedleImage = null;
            this.gaugeVoltage.NeedleSize = new System.Drawing.Size(4, 75);
            this.gaugeVoltage.NumberMarkerAngleBegin = 110F;
            this.gaugeVoltage.NumberMarkerAngleEnd = 430F;
            this.gaugeVoltage.NumberMarkerAngleInterval = 32F;
            this.gaugeVoltage.NumberMarkerColor = System.Drawing.Color.LemonChiffon;
            this.gaugeVoltage.NumberMarkerFont = new System.Drawing.Font("Tahoma", 8F);
            this.gaugeVoltage.NumberMarkerHeight = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gaugeVoltage.NumberMarkerOffset = -16;
            this.gaugeVoltage.NumberMarkerValueBegin = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.gaugeVoltage.NumberMarkerValueInterval = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.gaugeVoltage.NumberMarkerWidth = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.gaugeVoltage.Size = new System.Drawing.Size(208, 206);
            this.gaugeVoltage.TabIndex = 6;
            gaugeTickMarker1.BeginAngle = 110F;
            gaugeTickMarker1.EndAngle = 430F;
            gaugeTickMarker1.Height = 7F;
            gaugeTickMarker1.IntervalAngle = 16F;
            gaugeTickMarker1.markerColor = System.Drawing.Color.White;
            gaugeTickMarker1.Name = "GaugeElement";
            gaugeTickMarker1.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker1.OffsetY = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker1.Radius = 82F;
            gaugeTickMarker1.Width = 2F;
            this.gaugeVoltage.TickMarkers.Add(gaugeTickMarker1);
            this.gaugeVoltage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeVoltage.Load += new System.EventHandler(this.gaugeVoltage_Load);
            // 
            // gaugeFrequency
            // 
            this.gaugeFrequency.ArcColor = System.Drawing.Color.White;
            this.gaugeFrequency.ArcEndAngle = 420F;
            this.gaugeFrequency.ArcRadius = 85F;
            this.gaugeFrequency.ArcStartAngle = 120F;
            this.gaugeFrequency.ArcWidth = 3F;
            this.gaugeFrequency.BackColor = System.Drawing.Color.Transparent;
            this.gaugeFrequency.BackGroundEllipseColor = System.Drawing.Color.Black;
            this.gaugeFrequency.BorderColor = System.Drawing.Color.Black;
            this.gaugeFrequency.BorderEnabled = true;
            this.gaugeFrequency.BorderWidth = 8F;
            this.gaugeFrequency.isArcEnabled = true;
            this.gaugeFrequency.isCustomNeedleEnabled = false;
            gaugeLabel3.Name = "GaugeElement";
            gaugeLabel3.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeLabel3.OffsetY = new decimal(new int[] {
            16,
            0,
            0,
            0});
            gaugeLabel3.Text = "Hz";
            gaugeLabel3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            gaugeLabel3.TextFont = new System.Drawing.Font("Arial", 10F);
            this.gaugeFrequency.Labels.Add(gaugeLabel3);
            this.gaugeFrequency.Location = new System.Drawing.Point(610, 180);
            this.gaugeFrequency.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaugeFrequency.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeFrequency.Name = "gaugeFrequency";
            this.gaugeFrequency.NeedleCenterColor = System.Drawing.Color.Chocolate;
            this.gaugeFrequency.NeedleCenterRadius = 14F;
            this.gaugeFrequency.NeedleColor = System.Drawing.Color.Red;
            this.gaugeFrequency.NeedleImage = null;
            this.gaugeFrequency.NeedleSize = new System.Drawing.Size(4, 75);
            this.gaugeFrequency.NumberMarkerAngleBegin = 120F;
            this.gaugeFrequency.NumberMarkerAngleEnd = 420F;
            this.gaugeFrequency.NumberMarkerAngleInterval = 30F;
            this.gaugeFrequency.NumberMarkerColor = System.Drawing.Color.LemonChiffon;
            this.gaugeFrequency.NumberMarkerFont = new System.Drawing.Font("Tahoma", 8F);
            this.gaugeFrequency.NumberMarkerHeight = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gaugeFrequency.NumberMarkerOffset = -14;
            this.gaugeFrequency.NumberMarkerValueBegin = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeFrequency.NumberMarkerValueInterval = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.gaugeFrequency.NumberMarkerWidth = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.gaugeFrequency.Size = new System.Drawing.Size(208, 206);
            this.gaugeFrequency.TabIndex = 10;
            gaugeTickMarker2.BeginAngle = 120F;
            gaugeTickMarker2.EndAngle = 420F;
            gaugeTickMarker2.Height = 7F;
            gaugeTickMarker2.IntervalAngle = 15F;
            gaugeTickMarker2.markerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            gaugeTickMarker2.Name = "GaugeTickMarker 0";
            gaugeTickMarker2.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker2.OffsetY = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker2.Radius = 59F;
            gaugeTickMarker2.Width = 2F;
            this.gaugeFrequency.TickMarkers.Add(gaugeTickMarker2);
            this.gaugeFrequency.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // gaugeSpeed
            // 
            this.gaugeSpeed.ArcColor = System.Drawing.Color.White;
            this.gaugeSpeed.ArcEndAngle = 400F;
            this.gaugeSpeed.ArcRadius = 110F;
            this.gaugeSpeed.ArcStartAngle = 140F;
            this.gaugeSpeed.ArcWidth = 3F;
            this.gaugeSpeed.BackColor = System.Drawing.Color.Transparent;
            this.gaugeSpeed.BackGroundEllipseColor = System.Drawing.Color.Black;
            this.gaugeSpeed.BorderColor = System.Drawing.Color.Black;
            this.gaugeSpeed.BorderEnabled = true;
            this.gaugeSpeed.BorderWidth = 7F;
            this.gaugeSpeed.isArcEnabled = true;
            this.gaugeSpeed.isCustomNeedleEnabled = false;
            gaugeLabel4.Name = "GaugeLabel 0";
            gaugeLabel4.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeLabel4.OffsetY = new decimal(new int[] {
            25,
            0,
            0,
            0});
            gaugeLabel4.Text = "km/h";
            gaugeLabel4.TextColor = System.Drawing.Color.White;
            gaugeLabel4.TextFont = new System.Drawing.Font("Arial", 12F);
            this.gaugeSpeed.Labels.Add(gaugeLabel4);
            this.gaugeSpeed.Location = new System.Drawing.Point(784, 21);
            this.gaugeSpeed.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaugeSpeed.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeSpeed.Name = "gaugeSpeed";
            this.gaugeSpeed.NeedleCenterColor = System.Drawing.Color.Gray;
            this.gaugeSpeed.NeedleCenterRadius = 15F;
            this.gaugeSpeed.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeSpeed.NeedleImage = null;
            this.gaugeSpeed.NeedleSize = new System.Drawing.Size(6, 85);
            this.gaugeSpeed.NumberMarkerAngleBegin = 140F;
            this.gaugeSpeed.NumberMarkerAngleEnd = 400F;
            this.gaugeSpeed.NumberMarkerAngleInterval = 18F;
            this.gaugeSpeed.NumberMarkerColor = System.Drawing.Color.White;
            this.gaugeSpeed.NumberMarkerFont = new System.Drawing.Font("Tahoma", 8F);
            this.gaugeSpeed.NumberMarkerHeight = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gaugeSpeed.NumberMarkerOffset = -21;
            this.gaugeSpeed.NumberMarkerValueBegin = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gaugeSpeed.NumberMarkerValueInterval = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.gaugeSpeed.NumberMarkerWidth = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.gaugeSpeed.Size = new System.Drawing.Size(264, 260);
            this.gaugeSpeed.TabIndex = 14;
            gaugeTickMarker3.BeginAngle = 140F;
            gaugeTickMarker3.EndAngle = 400F;
            gaugeTickMarker3.Height = 6F;
            gaugeTickMarker3.IntervalAngle = 3.6F;
            gaugeTickMarker3.markerColor = System.Drawing.Color.White;
            gaugeTickMarker3.Name = "MinorTickMarker";
            gaugeTickMarker3.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker3.OffsetY = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker3.Radius = 107F;
            gaugeTickMarker3.Width = 2F;
            gaugeTickMarker4.BeginAngle = 140F;
            gaugeTickMarker4.EndAngle = 400F;
            gaugeTickMarker4.Height = 8F;
            gaugeTickMarker4.IntervalAngle = 18F;
            gaugeTickMarker4.markerColor = System.Drawing.Color.White;
            gaugeTickMarker4.Name = "MajorTickMarker";
            gaugeTickMarker4.OffsetX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker4.OffsetY = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gaugeTickMarker4.Radius = 107F;
            gaugeTickMarker4.Width = 3F;
            this.gaugeSpeed.TickMarkers.Add(gaugeTickMarker3);
            this.gaugeSpeed.TickMarkers.Add(gaugeTickMarker4);
            this.gaugeSpeed.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // GaugeSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 720);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GaugeSimulator";
            this.Text = "GaugeSimulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.GaugeSimulator_Load);
            this.Shown += new System.EventHandler(this.GaugeSimulator_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClosePSPPort;
        private System.Windows.Forms.Button buttonOpenPSPPort;
        private System.Windows.Forms.ComboBox comboBoxPSPPortSelect;
        private System.Windows.Forms.Button buttonCloseMSSIMPort;
        private System.Windows.Forms.Button buttonOpenMSSIMPort;
        private System.Windows.Forms.ComboBox comboBoxMSSIM2Port;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownVoltage;
        private GaugeControl.Gauge gaugeVoltage;
        private GaugeControl.Gauge gaugeRPM;
        private System.Windows.Forms.Label label5;
        private GaugeControl.Gauge gaugeFrequency;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.Label label7;
        private GaugeControl.Gauge gaugeSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRunScript;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonLoadScriptFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownRPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

