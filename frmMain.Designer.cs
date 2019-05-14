namespace Keithley2461
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblIDN = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnReDoAnalysis = new System.Windows.Forms.Button();
            this.btnRunSweep = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblBiasLimit = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblRshEstimate = new System.Windows.Forms.Label();
            this.lblRsEstimate = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRsCalculateHigh = new System.Windows.Forms.TextBox();
            this.txtRshCalculateLow = new System.Windows.Forms.TextBox();
            this.txtRshCalculateHigh = new System.Windows.Forms.TextBox();
            this.txtRsCalculateLow = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBiasLimit = new System.Windows.Forms.TextBox();
            this.txtLimitValue = new System.Windows.Forms.TextBox();
            this.txtStartValue = new System.Windows.Forms.TextBox();
            this.txtStopValue = new System.Windows.Forms.TextBox();
            this.txtNumberPulses = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtPulseWidth = new System.Windows.Forms.TextBox();
            this.txtOffTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBiasLevel = new System.Windows.Forms.Label();
            this.txtBiasVoltage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drpSweepType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radVoltageSweep = new System.Windows.Forms.RadioButton();
            this.radCurrentSweep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radBypassDiode = new System.Windows.Forms.RadioButton();
            this.radFullModule = new System.Windows.Forms.RadioButton();
            this.radSixStrip = new System.Windows.Forms.RadioButton();
            this.radSingleStrip = new System.Windows.Forms.RadioButton();
            this.radFullCell = new System.Windows.Forms.RadioButton();
            this.chtIVCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSampleName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtIVCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDN
            // 
            this.lblIDN.AutoSize = true;
            this.lblIDN.Location = new System.Drawing.Point(281, 522);
            this.lblIDN.Name = "lblIDN";
            this.lblIDN.Size = new System.Drawing.Size(43, 17);
            this.lblIDN.TabIndex = 115;
            this.lblIDN.Text = "Blank";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(281, 500);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 17);
            this.label32.TabIndex = 114;
            this.label32.Text = "Tool Identification";
            // 
            // btnReDoAnalysis
            // 
            this.btnReDoAnalysis.Location = new System.Drawing.Point(824, 77);
            this.btnReDoAnalysis.Name = "btnReDoAnalysis";
            this.btnReDoAnalysis.Size = new System.Drawing.Size(203, 58);
            this.btnReDoAnalysis.TabIndex = 113;
            this.btnReDoAnalysis.Text = " Re-Do Analysis";
            this.btnReDoAnalysis.UseVisualStyleBackColor = true;
            // 
            // btnRunSweep
            // 
            this.btnRunSweep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRunSweep.Location = new System.Drawing.Point(571, 77);
            this.btnRunSweep.Name = "btnRunSweep";
            this.btnRunSweep.Size = new System.Drawing.Size(233, 58);
            this.btnRunSweep.TabIndex = 112;
            this.btnRunSweep.Text = "Run Sweep";
            this.btnRunSweep.UseVisualStyleBackColor = true;
            this.btnRunSweep.Click += new System.EventHandler(this.btnRunSweep_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(179, 394);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 17);
            this.label34.TabIndex = 111;
            this.label34.Text = "s";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(198, 369);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 17);
            this.label33.TabIndex = 110;
            this.label33.Text = "s";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(177, 341);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 17);
            this.label31.TabIndex = 109;
            this.label31.Text = "s";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Best Fixed",
            "Automatic"});
            this.comboBox1.Location = new System.Drawing.Point(134, 422);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 108;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(177, 481);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(17, 17);
            this.lblLimit.TabIndex = 107;
            this.lblLimit.Text = "V";
            // 
            // lblBiasLimit
            // 
            this.lblBiasLimit.AutoSize = true;
            this.lblBiasLimit.Location = new System.Drawing.Point(177, 453);
            this.lblBiasLimit.Name = "lblBiasLimit";
            this.lblBiasLimit.Size = new System.Drawing.Size(17, 17);
            this.lblBiasLimit.TabIndex = 106;
            this.lblBiasLimit.Text = "V";
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(177, 291);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(17, 17);
            this.lblStop.TabIndex = 105;
            this.lblStop.Text = "A";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(177, 262);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(17, 17);
            this.lblStart.TabIndex = 104;
            this.lblStart.Text = "A";
            // 
            // lblRshEstimate
            // 
            this.lblRshEstimate.AutoSize = true;
            this.lblRshEstimate.Location = new System.Drawing.Point(417, 472);
            this.lblRshEstimate.Name = "lblRshEstimate";
            this.lblRshEstimate.Size = new System.Drawing.Size(83, 17);
            this.lblRshEstimate.TabIndex = 103;
            this.lblRshEstimate.Text = "No estimate";
            // 
            // lblRsEstimate
            // 
            this.lblRsEstimate.AutoSize = true;
            this.lblRsEstimate.Location = new System.Drawing.Point(417, 360);
            this.lblRsEstimate.Name = "lblRsEstimate";
            this.lblRsEstimate.Size = new System.Drawing.Size(83, 17);
            this.lblRsEstimate.TabIndex = 102;
            this.lblRsEstimate.Text = "No estimate";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(316, 472);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 17);
            this.label26.TabIndex = 101;
            this.label26.Text = "Rsh Estimate:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(324, 358);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 17);
            this.label25.TabIndex = 100;
            this.label25.Text = "Rs Estimate:";
            // 
            // txtRsCalculateHigh
            // 
            this.txtRsCalculateHigh.Location = new System.Drawing.Point(420, 325);
            this.txtRsCalculateHigh.Name = "txtRsCalculateHigh";
            this.txtRsCalculateHigh.Size = new System.Drawing.Size(37, 22);
            this.txtRsCalculateHigh.TabIndex = 99;
            this.txtRsCalculateHigh.Text = "0";
            // 
            // txtRshCalculateLow
            // 
            this.txtRshCalculateLow.Location = new System.Drawing.Point(419, 417);
            this.txtRshCalculateLow.Name = "txtRshCalculateLow";
            this.txtRshCalculateLow.Size = new System.Drawing.Size(37, 22);
            this.txtRshCalculateLow.TabIndex = 98;
            this.txtRshCalculateLow.Text = "0";
            // 
            // txtRshCalculateHigh
            // 
            this.txtRshCalculateHigh.Location = new System.Drawing.Point(419, 439);
            this.txtRshCalculateHigh.Name = "txtRshCalculateHigh";
            this.txtRshCalculateHigh.Size = new System.Drawing.Size(37, 22);
            this.txtRshCalculateHigh.TabIndex = 97;
            this.txtRshCalculateHigh.Text = "0";
            // 
            // txtRsCalculateLow
            // 
            this.txtRsCalculateLow.Location = new System.Drawing.Point(420, 303);
            this.txtRsCalculateLow.Name = "txtRsCalculateLow";
            this.txtRsCalculateLow.Size = new System.Drawing.Size(37, 22);
            this.txtRsCalculateLow.TabIndex = 96;
            this.txtRsCalculateLow.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(280, 444);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 17);
            this.label22.TabIndex = 95;
            this.label22.Text = "Voltage Range High";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(280, 422);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 17);
            this.label23.TabIndex = 94;
            this.label23.Text = "Voltage Range Low";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(273, 394);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 17);
            this.label24.TabIndex = 93;
            this.label24.Text = "Rsh Measurement";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(281, 330);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 17);
            this.label21.TabIndex = 92;
            this.label21.Text = "Current Range High";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(281, 308);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 17);
            this.label20.TabIndex = 91;
            this.label20.Text = "Current Range Low";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(274, 280);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 17);
            this.label19.TabIndex = 90;
            this.label19.Text = "Rs Measurement";
            // 
            // txtBiasLimit
            // 
            this.txtBiasLimit.Location = new System.Drawing.Point(134, 450);
            this.txtBiasLimit.Name = "txtBiasLimit";
            this.txtBiasLimit.Size = new System.Drawing.Size(37, 22);
            this.txtBiasLimit.TabIndex = 89;
            this.txtBiasLimit.Text = "2";
            // 
            // txtLimitValue
            // 
            this.txtLimitValue.Location = new System.Drawing.Point(134, 478);
            this.txtLimitValue.Name = "txtLimitValue";
            this.txtLimitValue.Size = new System.Drawing.Size(37, 22);
            this.txtLimitValue.TabIndex = 88;
            this.txtLimitValue.Text = "100";
            // 
            // txtStartValue
            // 
            this.txtStartValue.Location = new System.Drawing.Point(134, 257);
            this.txtStartValue.Name = "txtStartValue";
            this.txtStartValue.Size = new System.Drawing.Size(37, 22);
            this.txtStartValue.TabIndex = 87;
            this.txtStartValue.Text = "0";
            // 
            // txtStopValue
            // 
            this.txtStopValue.Location = new System.Drawing.Point(134, 283);
            this.txtStopValue.Name = "txtStopValue";
            this.txtStopValue.Size = new System.Drawing.Size(37, 22);
            this.txtStopValue.TabIndex = 86;
            this.txtStopValue.Text = "5";
            // 
            // txtNumberPulses
            // 
            this.txtNumberPulses.Location = new System.Drawing.Point(134, 311);
            this.txtNumberPulses.Name = "txtNumberPulses";
            this.txtNumberPulses.Size = new System.Drawing.Size(37, 22);
            this.txtNumberPulses.TabIndex = 85;
            this.txtNumberPulses.Text = "21";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(134, 338);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(37, 22);
            this.txtDelay.TabIndex = 84;
            this.txtDelay.Text = "0";
            // 
            // txtPulseWidth
            // 
            this.txtPulseWidth.Location = new System.Drawing.Point(134, 366);
            this.txtPulseWidth.Name = "txtPulseWidth";
            this.txtPulseWidth.Size = new System.Drawing.Size(58, 22);
            this.txtPulseWidth.TabIndex = 83;
            this.txtPulseWidth.Text = ".001";
            // 
            // txtOffTime
            // 
            this.txtOffTime.Location = new System.Drawing.Point(134, 394);
            this.txtOffTime.Name = "txtOffTime";
            this.txtOffTime.Size = new System.Drawing.Size(37, 22);
            this.txtOffTime.TabIndex = 82;
            this.txtOffTime.Text = "0.1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(249, 17);
            this.label18.TabIndex = 81;
            this.label18.Text = "High Capacitance: Off (OK for <20 nF)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 17);
            this.label17.TabIndex = 80;
            this.label17.Text = "Output Off: Normal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 79;
            this.label16.Text = "Sense: 4-wire";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 17);
            this.label15.TabIndex = 78;
            this.label15.Text = "Input Terminals: Front";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(269, 17);
            this.label14.TabIndex = 77;
            this.label14.Text = "Measurement Position: Top of Pulse Only";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 17);
            this.label13.TabIndex = 76;
            this.label13.Text = "Voltage Readback: Range: 100V";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 17);
            this.label12.TabIndex = 75;
            this.label12.Text = "Digitize Current: Enabled";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 74;
            this.label11.Text = "Limit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 73;
            this.label10.Text = "Off Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Voltage Range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Bias Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Number of Pulses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Stop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Start";
            // 
            // lblBiasLevel
            // 
            this.lblBiasLevel.AutoSize = true;
            this.lblBiasLevel.Location = new System.Drawing.Point(177, 234);
            this.lblBiasLevel.Name = "lblBiasLevel";
            this.lblBiasLevel.Size = new System.Drawing.Size(17, 17);
            this.lblBiasLevel.TabIndex = 65;
            this.lblBiasLevel.Text = "A";
            // 
            // txtBiasVoltage
            // 
            this.txtBiasVoltage.Location = new System.Drawing.Point(134, 231);
            this.txtBiasVoltage.Name = "txtBiasVoltage";
            this.txtBiasVoltage.Size = new System.Drawing.Size(37, 22);
            this.txtBiasVoltage.TabIndex = 64;
            this.txtBiasVoltage.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Bias Level";
            // 
            // drpSweepType
            // 
            this.drpSweepType.AllowDrop = true;
            this.drpSweepType.FormattingEnabled = true;
            this.drpSweepType.Items.AddRange(new object[] {
            "Linear",
            "Logarithmic"});
            this.drpSweepType.Location = new System.Drawing.Point(11, 201);
            this.drpSweepType.Name = "drpSweepType";
            this.drpSweepType.Size = new System.Drawing.Size(161, 24);
            this.drpSweepType.TabIndex = 62;
            this.drpSweepType.Text = "Sweep Discretization";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radVoltageSweep);
            this.groupBox2.Controls.Add(this.radCurrentSweep);
            this.groupBox2.Location = new System.Drawing.Point(283, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 76);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sweep Type";
            // 
            // radVoltageSweep
            // 
            this.radVoltageSweep.AutoSize = true;
            this.radVoltageSweep.Location = new System.Drawing.Point(20, 40);
            this.radVoltageSweep.Name = "radVoltageSweep";
            this.radVoltageSweep.Size = new System.Drawing.Size(123, 21);
            this.radVoltageSweep.TabIndex = 1;
            this.radVoltageSweep.Text = "Voltage Sweep";
            this.radVoltageSweep.UseVisualStyleBackColor = true;
            // 
            // radCurrentSweep
            // 
            this.radCurrentSweep.AutoSize = true;
            this.radCurrentSweep.Checked = true;
            this.radCurrentSweep.Location = new System.Drawing.Point(20, 18);
            this.radCurrentSweep.Name = "radCurrentSweep";
            this.radCurrentSweep.Size = new System.Drawing.Size(122, 21);
            this.radCurrentSweep.TabIndex = 0;
            this.radCurrentSweep.TabStop = true;
            this.radCurrentSweep.Text = "Current Sweep";
            this.radCurrentSweep.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radBypassDiode);
            this.groupBox1.Controls.Add(this.radFullModule);
            this.groupBox1.Controls.Add(this.radSixStrip);
            this.groupBox1.Controls.Add(this.radSingleStrip);
            this.groupBox1.Controls.Add(this.radFullCell);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 187);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Other";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radBypassDiode
            // 
            this.radBypassDiode.AutoSize = true;
            this.radBypassDiode.Location = new System.Drawing.Point(19, 146);
            this.radBypassDiode.Name = "radBypassDiode";
            this.radBypassDiode.Size = new System.Drawing.Size(116, 21);
            this.radBypassDiode.TabIndex = 5;
            this.radBypassDiode.TabStop = true;
            this.radBypassDiode.Text = "Bypass Diode";
            this.radBypassDiode.UseVisualStyleBackColor = true;
            // 
            // radFullModule
            // 
            this.radFullModule.AutoSize = true;
            this.radFullModule.Location = new System.Drawing.Point(19, 119);
            this.radFullModule.Name = "radFullModule";
            this.radFullModule.Size = new System.Drawing.Size(101, 21);
            this.radFullModule.TabIndex = 4;
            this.radFullModule.TabStop = true;
            this.radFullModule.Text = "Full Module";
            this.radFullModule.UseVisualStyleBackColor = true;
            // 
            // radSixStrip
            // 
            this.radSixStrip.AutoSize = true;
            this.radSixStrip.Location = new System.Drawing.Point(19, 93);
            this.radSixStrip.Name = "radSixStrip";
            this.radSixStrip.Size = new System.Drawing.Size(77, 21);
            this.radSixStrip.TabIndex = 3;
            this.radSixStrip.TabStop = true;
            this.radSixStrip.Text = "6 Strips";
            this.radSixStrip.UseVisualStyleBackColor = true;
            // 
            // radSingleStrip
            // 
            this.radSingleStrip.AutoSize = true;
            this.radSingleStrip.Location = new System.Drawing.Point(19, 69);
            this.radSingleStrip.Name = "radSingleStrip";
            this.radSingleStrip.Size = new System.Drawing.Size(70, 21);
            this.radSingleStrip.TabIndex = 2;
            this.radSingleStrip.TabStop = true;
            this.radSingleStrip.Text = "1 Strip";
            this.radSingleStrip.UseVisualStyleBackColor = true;
            // 
            // radFullCell
            // 
            this.radFullCell.AutoSize = true;
            this.radFullCell.Location = new System.Drawing.Point(19, 45);
            this.radFullCell.Name = "radFullCell";
            this.radFullCell.Size = new System.Drawing.Size(78, 21);
            this.radFullCell.TabIndex = 1;
            this.radFullCell.TabStop = true;
            this.radFullCell.Text = "Full Cell";
            this.radFullCell.UseVisualStyleBackColor = true;
            // 
            // chtIVCurve
            // 
            chartArea1.Name = "chtIVCurve";
            this.chtIVCurve.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtIVCurve.Legends.Add(legend1);
            this.chtIVCurve.Location = new System.Drawing.Point(571, 160);
            this.chtIVCurve.Name = "chtIVCurve";
            series1.ChartArea = "chtIVCurve";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "serIV";
            this.chtIVCurve.Series.Add(series1);
            this.chtIVCurve.Size = new System.Drawing.Size(610, 397);
            this.chtIVCurve.TabIndex = 116;
            this.chtIVCurve.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 117;
            this.label2.Text = "Unique sample name:";
            // 
            // txtSampleName
            // 
            this.txtSampleName.Location = new System.Drawing.Point(719, 17);
            this.txtSampleName.Name = "txtSampleName";
            this.txtSampleName.Size = new System.Drawing.Size(346, 22);
            this.txtSampleName.TabIndex = 118;
            this.txtSampleName.Text = "Sample";
            this.txtSampleName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(568, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 17);
            this.label27.TabIndex = 119;
            this.label27.Text = "File path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(640, 49);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(425, 22);
            this.txtFilePath.TabIndex = 120;
            this.txtFilePath.Text = "C:\\temp\\";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(67, 506);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 17);
            this.label28.TabIndex = 121;
            this.label28.Text = "Timeout";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(134, 506);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(58, 22);
            this.txtTimeOut.TabIndex = 122;
            this.txtTimeOut.Text = "4000";
            this.txtTimeOut.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(198, 509);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 17);
            this.label29.TabIndex = 123;
            this.label29.Text = "ms";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 569);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtSampleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chtIVCurve);
            this.Controls.Add(this.lblIDN);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnReDoAnalysis);
            this.Controls.Add(this.btnRunSweep);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblBiasLimit);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblRshEstimate);
            this.Controls.Add(this.lblRsEstimate);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtRsCalculateHigh);
            this.Controls.Add(this.txtRshCalculateLow);
            this.Controls.Add(this.txtRshCalculateHigh);
            this.Controls.Add(this.txtRsCalculateLow);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtBiasLimit);
            this.Controls.Add(this.txtLimitValue);
            this.Controls.Add(this.txtStartValue);
            this.Controls.Add(this.txtStopValue);
            this.Controls.Add(this.txtNumberPulses);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.txtPulseWidth);
            this.Controls.Add(this.txtOffTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBiasLevel);
            this.Controls.Add(this.txtBiasVoltage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpSweepType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Keithley 2461";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtIVCurve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDN;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnReDoAnalysis;
        private System.Windows.Forms.Button btnRunSweep;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblBiasLimit;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblRshEstimate;
        private System.Windows.Forms.Label lblRsEstimate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtRsCalculateHigh;
        private System.Windows.Forms.TextBox txtRshCalculateLow;
        private System.Windows.Forms.TextBox txtRshCalculateHigh;
        private System.Windows.Forms.TextBox txtRsCalculateLow;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBiasLimit;
        private System.Windows.Forms.TextBox txtLimitValue;
        private System.Windows.Forms.TextBox txtStartValue;
        private System.Windows.Forms.TextBox txtStopValue;
        private System.Windows.Forms.TextBox txtNumberPulses;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.TextBox txtPulseWidth;
        private System.Windows.Forms.TextBox txtOffTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBiasLevel;
        private System.Windows.Forms.TextBox txtBiasVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpSweepType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radVoltageSweep;
        private System.Windows.Forms.RadioButton radCurrentSweep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radBypassDiode;
        private System.Windows.Forms.RadioButton radFullModule;
        private System.Windows.Forms.RadioButton radSixStrip;
        private System.Windows.Forms.RadioButton radSingleStrip;
        private System.Windows.Forms.RadioButton radFullCell;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtIVCurve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSampleName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label label29;
    }
}

