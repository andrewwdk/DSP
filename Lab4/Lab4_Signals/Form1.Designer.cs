namespace Lab4_Signals
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noiseRadioButton = new System.Windows.Forms.RadioButton();
            this.sawtoothedRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.dutyCycleRadioButton = new System.Windows.Forms.RadioButton();
            this.sinusoidRadioButton = new System.Windows.Forms.RadioButton();
            this.signalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.generateHarmonicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.fiTextBox = new System.Windows.Forms.TextBox();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.dutyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.poliharmonicButton = new System.Windows.Forms.Button();
            this.dutyModulationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fModulationTextBox = new System.Windows.Forms.TextBox();
            this.fiModulationTextBox = new System.Windows.Forms.TextBox();
            this.AModulationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noiseModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.sawtoothedModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.DutyCycleModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.SinusoidModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FrequencyModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.AmplitudeModulationRadioButton = new System.Windows.Forms.RadioButton();
            this.modulationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noiseRadioButton);
            this.groupBox1.Controls.Add(this.sawtoothedRadioButton);
            this.groupBox1.Controls.Add(this.triangleRadioButton);
            this.groupBox1.Controls.Add(this.dutyCycleRadioButton);
            this.groupBox1.Controls.Add(this.sinusoidRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(255, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal types";
            // 
            // noiseRadioButton
            // 
            this.noiseRadioButton.AutoSize = true;
            this.noiseRadioButton.Location = new System.Drawing.Point(6, 181);
            this.noiseRadioButton.Name = "noiseRadioButton";
            this.noiseRadioButton.Size = new System.Drawing.Size(98, 33);
            this.noiseRadioButton.TabIndex = 4;
            this.noiseRadioButton.TabStop = true;
            this.noiseRadioButton.Text = "Noise";
            this.noiseRadioButton.UseVisualStyleBackColor = true;
            // 
            // sawtoothedRadioButton
            // 
            this.sawtoothedRadioButton.AutoSize = true;
            this.sawtoothedRadioButton.Location = new System.Drawing.Point(6, 146);
            this.sawtoothedRadioButton.Name = "sawtoothedRadioButton";
            this.sawtoothedRadioButton.Size = new System.Drawing.Size(162, 33);
            this.sawtoothedRadioButton.TabIndex = 3;
            this.sawtoothedRadioButton.TabStop = true;
            this.sawtoothedRadioButton.Text = "Sawtoothed";
            this.sawtoothedRadioButton.UseVisualStyleBackColor = true;
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.Location = new System.Drawing.Point(6, 109);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(124, 33);
            this.triangleRadioButton.TabIndex = 2;
            this.triangleRadioButton.TabStop = true;
            this.triangleRadioButton.Text = "Triangle";
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dutyCycleRadioButton
            // 
            this.dutyCycleRadioButton.AutoSize = true;
            this.dutyCycleRadioButton.Location = new System.Drawing.Point(6, 69);
            this.dutyCycleRadioButton.Name = "dutyCycleRadioButton";
            this.dutyCycleRadioButton.Size = new System.Drawing.Size(142, 33);
            this.dutyCycleRadioButton.TabIndex = 1;
            this.dutyCycleRadioButton.TabStop = true;
            this.dutyCycleRadioButton.Text = "Duty cycle";
            this.dutyCycleRadioButton.UseVisualStyleBackColor = true;
            // 
            // sinusoidRadioButton
            // 
            this.sinusoidRadioButton.AutoSize = true;
            this.sinusoidRadioButton.Location = new System.Drawing.Point(6, 30);
            this.sinusoidRadioButton.Name = "sinusoidRadioButton";
            this.sinusoidRadioButton.Size = new System.Drawing.Size(128, 33);
            this.sinusoidRadioButton.TabIndex = 0;
            this.sinusoidRadioButton.TabStop = true;
            this.sinusoidRadioButton.Text = "Sinusoid";
            this.sinusoidRadioButton.UseVisualStyleBackColor = true;
            // 
            // signalChart
            // 
            chartArea1.Name = "ChartArea1";
            this.signalChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.signalChart.Legends.Add(legend1);
            this.signalChart.Location = new System.Drawing.Point(12, 258);
            this.signalChart.Name = "signalChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            this.signalChart.Series.Add(series1);
            this.signalChart.Size = new System.Drawing.Size(1414, 424);
            this.signalChart.TabIndex = 1;
            this.signalChart.Text = "chart1";
            // 
            // generateHarmonicButton
            // 
            this.generateHarmonicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateHarmonicButton.Location = new System.Drawing.Point(476, 51);
            this.generateHarmonicButton.Name = "generateHarmonicButton";
            this.generateHarmonicButton.Size = new System.Drawing.Size(189, 57);
            this.generateHarmonicButton.TabIndex = 2;
            this.generateHarmonicButton.Text = "Generate and sound harmonic signal";
            this.generateHarmonicButton.UseVisualStyleBackColor = true;
            this.generateHarmonicButton.Click += new System.EventHandler(this.GenerateHarmonicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "f";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "fi";
            // 
            // ATextBox
            // 
            this.ATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATextBox.Location = new System.Drawing.Point(112, 18);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 34);
            this.ATextBox.TabIndex = 6;
            this.ATextBox.Text = "10";
            // 
            // fiTextBox
            // 
            this.fiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiTextBox.Location = new System.Drawing.Point(112, 134);
            this.fiTextBox.Name = "fiTextBox";
            this.fiTextBox.Size = new System.Drawing.Size(100, 34);
            this.fiTextBox.TabIndex = 7;
            this.fiTextBox.Text = "0";
            // 
            // fTextBox
            // 
            this.fTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fTextBox.Location = new System.Drawing.Point(112, 74);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(100, 34);
            this.fTextBox.TabIndex = 8;
            this.fTextBox.Text = "20";
            // 
            // dutyTextBox
            // 
            this.dutyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dutyTextBox.Location = new System.Drawing.Point(112, 189);
            this.dutyTextBox.Name = "dutyTextBox";
            this.dutyTextBox.Size = new System.Drawing.Size(100, 34);
            this.dutyTextBox.TabIndex = 10;
            this.dutyTextBox.Text = "0,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Duty";
            // 
            // poliharmonicButton
            // 
            this.poliharmonicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poliharmonicButton.Location = new System.Drawing.Point(476, 126);
            this.poliharmonicButton.Name = "poliharmonicButton";
            this.poliharmonicButton.Size = new System.Drawing.Size(189, 57);
            this.poliharmonicButton.TabIndex = 11;
            this.poliharmonicButton.Text = "Generate and sound poliharmonic signal";
            this.poliharmonicButton.UseVisualStyleBackColor = true;
            this.poliharmonicButton.Click += new System.EventHandler(this.PoliharmonicButton_Click);
            // 
            // dutyModulationTextBox
            // 
            this.dutyModulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dutyModulationTextBox.Location = new System.Drawing.Point(787, 189);
            this.dutyModulationTextBox.Name = "dutyModulationTextBox";
            this.dutyModulationTextBox.Size = new System.Drawing.Size(100, 34);
            this.dutyModulationTextBox.TabIndex = 20;
            this.dutyModulationTextBox.Text = "0,5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(702, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Duty";
            // 
            // fModulationTextBox
            // 
            this.fModulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fModulationTextBox.Location = new System.Drawing.Point(787, 74);
            this.fModulationTextBox.Name = "fModulationTextBox";
            this.fModulationTextBox.Size = new System.Drawing.Size(100, 34);
            this.fModulationTextBox.TabIndex = 18;
            this.fModulationTextBox.Text = "20";
            // 
            // fiModulationTextBox
            // 
            this.fiModulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiModulationTextBox.Location = new System.Drawing.Point(787, 134);
            this.fiModulationTextBox.Name = "fiModulationTextBox";
            this.fiModulationTextBox.Size = new System.Drawing.Size(100, 34);
            this.fiModulationTextBox.TabIndex = 17;
            this.fiModulationTextBox.Text = "0";
            // 
            // AModulationTextBox
            // 
            this.AModulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AModulationTextBox.Location = new System.Drawing.Point(787, 18);
            this.AModulationTextBox.Name = "AModulationTextBox";
            this.AModulationTextBox.Size = new System.Drawing.Size(100, 34);
            this.AModulationTextBox.TabIndex = 16;
            this.AModulationTextBox.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(702, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "fi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(702, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "f";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(702, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noiseModulationRadioButton);
            this.groupBox2.Controls.Add(this.sawtoothedModulationRadioButton);
            this.groupBox2.Controls.Add(this.triangleModulationRadioButton);
            this.groupBox2.Controls.Add(this.DutyCycleModulationRadioButton);
            this.groupBox2.Controls.Add(this.SinusoidModulationRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(916, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 220);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modulation Signal";
            // 
            // noiseModulationRadioButton
            // 
            this.noiseModulationRadioButton.AutoSize = true;
            this.noiseModulationRadioButton.Location = new System.Drawing.Point(6, 181);
            this.noiseModulationRadioButton.Name = "noiseModulationRadioButton";
            this.noiseModulationRadioButton.Size = new System.Drawing.Size(98, 33);
            this.noiseModulationRadioButton.TabIndex = 4;
            this.noiseModulationRadioButton.TabStop = true;
            this.noiseModulationRadioButton.Text = "Noise";
            this.noiseModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // sawtoothedModulationRadioButton
            // 
            this.sawtoothedModulationRadioButton.AutoSize = true;
            this.sawtoothedModulationRadioButton.Location = new System.Drawing.Point(6, 146);
            this.sawtoothedModulationRadioButton.Name = "sawtoothedModulationRadioButton";
            this.sawtoothedModulationRadioButton.Size = new System.Drawing.Size(162, 33);
            this.sawtoothedModulationRadioButton.TabIndex = 3;
            this.sawtoothedModulationRadioButton.TabStop = true;
            this.sawtoothedModulationRadioButton.Text = "Sawtoothed";
            this.sawtoothedModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // triangleModulationRadioButton
            // 
            this.triangleModulationRadioButton.AutoSize = true;
            this.triangleModulationRadioButton.Location = new System.Drawing.Point(6, 109);
            this.triangleModulationRadioButton.Name = "triangleModulationRadioButton";
            this.triangleModulationRadioButton.Size = new System.Drawing.Size(124, 33);
            this.triangleModulationRadioButton.TabIndex = 2;
            this.triangleModulationRadioButton.TabStop = true;
            this.triangleModulationRadioButton.Text = "Triangle";
            this.triangleModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // DutyCycleModulationRadioButton
            // 
            this.DutyCycleModulationRadioButton.AutoSize = true;
            this.DutyCycleModulationRadioButton.Location = new System.Drawing.Point(6, 69);
            this.DutyCycleModulationRadioButton.Name = "DutyCycleModulationRadioButton";
            this.DutyCycleModulationRadioButton.Size = new System.Drawing.Size(142, 33);
            this.DutyCycleModulationRadioButton.TabIndex = 1;
            this.DutyCycleModulationRadioButton.TabStop = true;
            this.DutyCycleModulationRadioButton.Text = "Duty cycle";
            this.DutyCycleModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // SinusoidModulationRadioButton
            // 
            this.SinusoidModulationRadioButton.AutoSize = true;
            this.SinusoidModulationRadioButton.Location = new System.Drawing.Point(6, 30);
            this.SinusoidModulationRadioButton.Name = "SinusoidModulationRadioButton";
            this.SinusoidModulationRadioButton.Size = new System.Drawing.Size(128, 33);
            this.SinusoidModulationRadioButton.TabIndex = 0;
            this.SinusoidModulationRadioButton.TabStop = true;
            this.SinusoidModulationRadioButton.Text = "Sinusoid";
            this.SinusoidModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FrequencyModulationRadioButton);
            this.groupBox3.Controls.Add(this.AmplitudeModulationRadioButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1176, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modulation";
            // 
            // FrequencyModulationRadioButton
            // 
            this.FrequencyModulationRadioButton.AutoSize = true;
            this.FrequencyModulationRadioButton.Location = new System.Drawing.Point(6, 67);
            this.FrequencyModulationRadioButton.Name = "FrequencyModulationRadioButton";
            this.FrequencyModulationRadioButton.Size = new System.Drawing.Size(148, 33);
            this.FrequencyModulationRadioButton.TabIndex = 6;
            this.FrequencyModulationRadioButton.TabStop = true;
            this.FrequencyModulationRadioButton.Text = "Frequency";
            this.FrequencyModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // AmplitudeModulationRadioButton
            // 
            this.AmplitudeModulationRadioButton.AutoSize = true;
            this.AmplitudeModulationRadioButton.Location = new System.Drawing.Point(6, 28);
            this.AmplitudeModulationRadioButton.Name = "AmplitudeModulationRadioButton";
            this.AmplitudeModulationRadioButton.Size = new System.Drawing.Size(142, 33);
            this.AmplitudeModulationRadioButton.TabIndex = 5;
            this.AmplitudeModulationRadioButton.TabStop = true;
            this.AmplitudeModulationRadioButton.Text = "Amplitude";
            this.AmplitudeModulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // modulationButton
            // 
            this.modulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modulationButton.Location = new System.Drawing.Point(1182, 158);
            this.modulationButton.Name = "modulationButton";
            this.modulationButton.Size = new System.Drawing.Size(189, 57);
            this.modulationButton.TabIndex = 22;
            this.modulationButton.Text = "Generate and sound modulated signal";
            this.modulationButton.UseVisualStyleBackColor = true;
            this.modulationButton.Click += new System.EventHandler(this.ModulationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 694);
            this.Controls.Add(this.modulationButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dutyModulationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fModulationTextBox);
            this.Controls.Add(this.fiModulationTextBox);
            this.Controls.Add(this.AModulationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.poliharmonicButton);
            this.Controls.Add(this.dutyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.fiTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateHarmonicButton);
            this.Controls.Add(this.signalChart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noiseRadioButton;
        private System.Windows.Forms.RadioButton sawtoothedRadioButton;
        private System.Windows.Forms.RadioButton triangleRadioButton;
        private System.Windows.Forms.RadioButton dutyCycleRadioButton;
        private System.Windows.Forms.RadioButton sinusoidRadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalChart;
        private System.Windows.Forms.Button generateHarmonicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox fiTextBox;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox dutyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button poliharmonicButton;
        private System.Windows.Forms.TextBox dutyModulationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fModulationTextBox;
        private System.Windows.Forms.TextBox fiModulationTextBox;
        private System.Windows.Forms.TextBox AModulationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton noiseModulationRadioButton;
        private System.Windows.Forms.RadioButton sawtoothedModulationRadioButton;
        private System.Windows.Forms.RadioButton triangleModulationRadioButton;
        private System.Windows.Forms.RadioButton DutyCycleModulationRadioButton;
        private System.Windows.Forms.RadioButton SinusoidModulationRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton FrequencyModulationRadioButton;
        private System.Windows.Forms.RadioButton AmplitudeModulationRadioButton;
        private System.Windows.Forms.Button modulationButton;
    }
}

