﻿namespace EngineeringCompetitionTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCloseMSSIMPort = new System.Windows.Forms.Button();
            this.buttonOpenMSSIMPort = new System.Windows.Forms.Button();
            this.comboBoxMSSIM2Port = new System.Windows.Forms.ComboBox();
            this.buttonClosePSPPort = new System.Windows.Forms.Button();
            this.buttonOpenPSPPort = new System.Windows.Forms.Button();
            this.comboBoxPSPPortSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDownVoltage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gaugeSpeed = new GaugeControl.Gauge();
            this.gaugeFrequency = new GaugeControl.Gauge();
            this.gaugeRPM = new GaugeControl.Gauge();
            this.gaugeVoltage = new GaugeControl.Gauge();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCloseMSSIMPort);
            this.groupBox1.Controls.Add(this.buttonOpenMSSIMPort);
            this.groupBox1.Controls.Add(this.comboBoxMSSIM2Port);
            this.groupBox1.Controls.Add(this.buttonClosePSPPort);
            this.groupBox1.Controls.Add(this.buttonOpenPSPPort);
            this.groupBox1.Controls.Add(this.comboBoxPSPPortSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM ports";
            // 
            // buttonCloseMSSIMPort
            // 
            this.buttonCloseMSSIMPort.Location = new System.Drawing.Point(859, 80);
            this.buttonCloseMSSIMPort.Name = "buttonCloseMSSIMPort";
            this.buttonCloseMSSIMPort.Size = new System.Drawing.Size(79, 30);
            this.buttonCloseMSSIMPort.TabIndex = 7;
            this.buttonCloseMSSIMPort.Text = "Close";
            this.buttonCloseMSSIMPort.UseVisualStyleBackColor = true;
            this.buttonCloseMSSIMPort.Click += new System.EventHandler(this.buttonCloseMSSIMPort_Click);
            // 
            // buttonOpenMSSIMPort
            // 
            this.buttonOpenMSSIMPort.Location = new System.Drawing.Point(859, 44);
            this.buttonOpenMSSIMPort.Name = "buttonOpenMSSIMPort";
            this.buttonOpenMSSIMPort.Size = new System.Drawing.Size(79, 30);
            this.buttonOpenMSSIMPort.TabIndex = 6;
            this.buttonOpenMSSIMPort.Text = "Open";
            this.buttonOpenMSSIMPort.UseVisualStyleBackColor = true;
            this.buttonOpenMSSIMPort.Click += new System.EventHandler(this.buttonOpenMSSIMPort_Click);
            // 
            // comboBoxMSSIM2Port
            // 
            this.comboBoxMSSIM2Port.FormattingEnabled = true;
            this.comboBoxMSSIM2Port.Location = new System.Drawing.Point(956, 48);
            this.comboBoxMSSIM2Port.Name = "comboBoxMSSIM2Port";
            this.comboBoxMSSIM2Port.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMSSIM2Port.TabIndex = 5;
            // 
            // buttonClosePSPPort
            // 
            this.buttonClosePSPPort.Location = new System.Drawing.Point(10, 84);
            this.buttonClosePSPPort.Name = "buttonClosePSPPort";
            this.buttonClosePSPPort.Size = new System.Drawing.Size(79, 30);
            this.buttonClosePSPPort.TabIndex = 4;
            this.buttonClosePSPPort.Text = "Close";
            this.buttonClosePSPPort.UseVisualStyleBackColor = true;
            this.buttonClosePSPPort.Click += new System.EventHandler(this.buttonClosePSPPort_Click);
            // 
            // buttonOpenPSPPort
            // 
            this.buttonOpenPSPPort.Location = new System.Drawing.Point(10, 48);
            this.buttonOpenPSPPort.Name = "buttonOpenPSPPort";
            this.buttonOpenPSPPort.Size = new System.Drawing.Size(79, 30);
            this.buttonOpenPSPPort.TabIndex = 3;
            this.buttonOpenPSPPort.Text = "Open";
            this.buttonOpenPSPPort.UseVisualStyleBackColor = true;
            this.buttonOpenPSPPort.Click += new System.EventHandler(this.buttonOpenPSPPort_Click);
            // 
            // comboBoxPSPPortSelect
            // 
            this.comboBoxPSPPortSelect.FormattingEnabled = true;
            this.comboBoxPSPPortSelect.Location = new System.Drawing.Point(107, 52);
            this.comboBoxPSPPortSelect.Name = "comboBoxPSPPortSelect";
            this.comboBoxPSPPortSelect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPSPPortSelect.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSIM2 port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PSP port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voltage:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 642);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1104, 87);
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
            this.numericUpDownVoltage.Location = new System.Drawing.Point(107, 602);
            this.numericUpDownVoltage.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownVoltage.Name = "numericUpDownVoltage";
            this.numericUpDownVoltage.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownVoltage.TabIndex = 5;
            this.numericUpDownVoltage.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(124, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(278, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voltage";
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(953, 602);
            this.numericUpDownFrequency.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFrequency.TabIndex = 11;
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.numericUpDownFrequency_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(872, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Frequency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(654, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Frequency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(849, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Speed";
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
            this.gaugeSpeed.Location = new System.Drawing.Point(754, 141);
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
            this.gaugeSpeed.NumberMarkerHeight = 12;
            this.gaugeSpeed.NumberMarkerOffset = -18;
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
            this.gaugeSpeed.NumberMarkerWidth = 40;
            this.gaugeSpeed.Size = new System.Drawing.Size(289, 260);
            this.gaugeSpeed.TabIndex = 14;
            this.gaugeSpeed.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // gaugeFrequency
            // 
            this.gaugeFrequency.ArcColor = System.Drawing.Color.White;
            this.gaugeFrequency.ArcEndAngle = 420F;
            this.gaugeFrequency.ArcRadius = 80F;
            this.gaugeFrequency.ArcStartAngle = 120F;
            this.gaugeFrequency.ArcWidth = 3F;
            this.gaugeFrequency.BackColor = System.Drawing.Color.Transparent;
            this.gaugeFrequency.BackGroundEllipseColor = System.Drawing.Color.Black;
            this.gaugeFrequency.BorderColor = System.Drawing.Color.Black;
            this.gaugeFrequency.BorderEnabled = true;
            this.gaugeFrequency.BorderWidth = 8F;
            this.gaugeFrequency.isArcEnabled = true;
            this.gaugeFrequency.isCustomNeedleEnabled = false;
            this.gaugeFrequency.Location = new System.Drawing.Point(611, 377);
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
            this.gaugeFrequency.NumberMarkerHeight = 12;
            this.gaugeFrequency.NumberMarkerOffset = -18;
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
            this.gaugeFrequency.NumberMarkerWidth = 40;
            this.gaugeFrequency.Size = new System.Drawing.Size(208, 206);
            this.gaugeFrequency.TabIndex = 10;
            this.gaugeFrequency.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.gaugeRPM.Location = new System.Drawing.Point(12, 141);
            this.gaugeRPM.Name = "gaugeRPM";
            this.gaugeRPM.NeedleCenterColor = System.Drawing.Color.Gray;
            this.gaugeRPM.NeedleCenterRadius = 15F;
            this.gaugeRPM.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeRPM.NeedleImage = null;
            this.gaugeRPM.NeedleSize = new System.Drawing.Size(6, 85);
            this.gaugeRPM.NumberMarkerAngleBegin = 150F;
            this.gaugeRPM.NumberMarkerAngleEnd = 390F;
            this.gaugeRPM.NumberMarkerAngleInterval = 40F;
            this.gaugeRPM.NumberMarkerColor = System.Drawing.Color.White;
            this.gaugeRPM.NumberMarkerFont = new System.Drawing.Font("Tahoma", 8F);
            this.gaugeRPM.NumberMarkerHeight = 12;
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
            this.gaugeRPM.NumberMarkerWidth = 40;
            this.gaugeRPM.Size = new System.Drawing.Size(321, 260);
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
            this.gaugeVoltage.Location = new System.Drawing.Point(225, 377);
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
            this.gaugeVoltage.NumberMarkerHeight = 12;
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
            this.gaugeVoltage.NumberMarkerWidth = 40;
            this.gaugeVoltage.Size = new System.Drawing.Size(208, 206);
            this.gaugeVoltage.TabIndex = 6;
            this.gaugeVoltage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 731);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gaugeSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownFrequency);
            this.Controls.Add(this.gaugeFrequency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gaugeRPM);
            this.Controls.Add(this.gaugeVoltage);
            this.Controls.Add(this.numericUpDownVoltage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClosePSPPort;
        private System.Windows.Forms.Button buttonOpenPSPPort;
        private System.Windows.Forms.ComboBox comboBoxPSPPortSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseMSSIMPort;
        private System.Windows.Forms.Button buttonOpenMSSIMPort;
        private System.Windows.Forms.ComboBox comboBoxMSSIM2Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownVoltage;
        private GaugeControl.Gauge gaugeVoltage;
        private GaugeControl.Gauge gaugeRPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private GaugeControl.Gauge gaugeFrequency;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private GaugeControl.Gauge gaugeSpeed;
        private System.Windows.Forms.Label label8;
    }
}
