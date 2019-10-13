namespace Lab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.signalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.amplitudeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.phaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.B1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B2TextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.drawSignalButton = new System.Windows.Forms.Button();
            this.slidingWindowButton = new System.Windows.Forms.Button();
            this.parabolaButton = new System.Windows.Forms.Button();
            this.medianFilteringButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // signalChart
            // 
            chartArea4.Name = "ChartArea1";
            this.signalChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.signalChart.Legends.Add(legend4);
            this.signalChart.Location = new System.Drawing.Point(12, 12);
            this.signalChart.Name = "signalChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Signal";
            this.signalChart.Series.Add(series4);
            this.signalChart.Size = new System.Drawing.Size(893, 239);
            this.signalChart.TabIndex = 0;
            this.signalChart.Text = "chart1";
            // 
            // amplitudeChart
            // 
            chartArea5.Name = "ChartArea1";
            this.amplitudeChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.amplitudeChart.Legends.Add(legend5);
            this.amplitudeChart.Location = new System.Drawing.Point(12, 257);
            this.amplitudeChart.Name = "amplitudeChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Amplitude";
            series5.YValuesPerPoint = 4;
            this.amplitudeChart.Series.Add(series5);
            this.amplitudeChart.Size = new System.Drawing.Size(893, 239);
            this.amplitudeChart.TabIndex = 1;
            this.amplitudeChart.Text = "chart2";
            // 
            // phaseChart
            // 
            chartArea6.Name = "ChartArea1";
            this.phaseChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.phaseChart.Legends.Add(legend6);
            this.phaseChart.Location = new System.Drawing.Point(12, 502);
            this.phaseChart.Name = "phaseChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Phase";
            series6.YValuesPerPoint = 4;
            this.phaseChart.Series.Add(series6);
            this.phaseChart.Size = new System.Drawing.Size(893, 239);
            this.phaseChart.TabIndex = 2;
            this.phaseChart.Text = "chart3";
            // 
            // B1TextBox
            // 
            this.B1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1TextBox.ForeColor = System.Drawing.Color.Green;
            this.B1TextBox.Location = new System.Drawing.Point(1061, 124);
            this.B1TextBox.Name = "B1TextBox";
            this.B1TextBox.Size = new System.Drawing.Size(100, 38);
            this.B1TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(989, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "В1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(989, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "В2";
            // 
            // B2TextBox
            // 
            this.B2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2TextBox.ForeColor = System.Drawing.Color.Green;
            this.B2TextBox.Location = new System.Drawing.Point(1061, 194);
            this.B2TextBox.Name = "B2TextBox";
            this.B2TextBox.Size = new System.Drawing.Size(100, 38);
            this.B2TextBox.TabIndex = 5;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.Green;
            this.enterButton.Location = new System.Drawing.Point(1232, 154);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(131, 51);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // drawSignalButton
            // 
            this.drawSignalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.drawSignalButton.Enabled = false;
            this.drawSignalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawSignalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawSignalButton.ForeColor = System.Drawing.Color.Green;
            this.drawSignalButton.Location = new System.Drawing.Point(927, 326);
            this.drawSignalButton.Name = "drawSignalButton";
            this.drawSignalButton.Size = new System.Drawing.Size(481, 48);
            this.drawSignalButton.TabIndex = 8;
            this.drawSignalButton.Text = "Draw signal";
            this.drawSignalButton.UseVisualStyleBackColor = false;
            this.drawSignalButton.Click += new System.EventHandler(this.DrawSignalButton_Click);
            // 
            // slidingWindowButton
            // 
            this.slidingWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.slidingWindowButton.Enabled = false;
            this.slidingWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slidingWindowButton.ForeColor = System.Drawing.Color.Green;
            this.slidingWindowButton.Location = new System.Drawing.Point(927, 391);
            this.slidingWindowButton.Name = "slidingWindowButton";
            this.slidingWindowButton.Size = new System.Drawing.Size(481, 48);
            this.slidingWindowButton.TabIndex = 9;
            this.slidingWindowButton.Text = "Sliding window";
            this.slidingWindowButton.UseVisualStyleBackColor = false;
            this.slidingWindowButton.Click += new System.EventHandler(this.SlidingWindowButton_Click);
            // 
            // parabolaButton
            // 
            this.parabolaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.parabolaButton.Enabled = false;
            this.parabolaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parabolaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parabolaButton.ForeColor = System.Drawing.Color.Green;
            this.parabolaButton.Location = new System.Drawing.Point(927, 455);
            this.parabolaButton.Name = "parabolaButton";
            this.parabolaButton.Size = new System.Drawing.Size(481, 48);
            this.parabolaButton.TabIndex = 10;
            this.parabolaButton.Text = "4th degree parabola";
            this.parabolaButton.UseVisualStyleBackColor = false;
            this.parabolaButton.Click += new System.EventHandler(this.ParabolaButton_Click);
            // 
            // medianFilteringButton
            // 
            this.medianFilteringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.medianFilteringButton.Enabled = false;
            this.medianFilteringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medianFilteringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medianFilteringButton.ForeColor = System.Drawing.Color.Green;
            this.medianFilteringButton.Location = new System.Drawing.Point(927, 518);
            this.medianFilteringButton.Name = "medianFilteringButton";
            this.medianFilteringButton.Size = new System.Drawing.Size(481, 48);
            this.medianFilteringButton.TabIndex = 11;
            this.medianFilteringButton.Text = "Median filtering";
            this.medianFilteringButton.UseVisualStyleBackColor = false;
            this.medianFilteringButton.Click += new System.EventHandler(this.MedianFilteringButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1431, 750);
            this.Controls.Add(this.medianFilteringButton);
            this.Controls.Add(this.parabolaButton);
            this.Controls.Add(this.slidingWindowButton);
            this.Controls.Add(this.drawSignalButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B2TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B1TextBox);
            this.Controls.Add(this.phaseChart);
            this.Controls.Add(this.amplitudeChart);
            this.Controls.Add(this.signalChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart signalChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart amplitudeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart phaseChart;
        private System.Windows.Forms.TextBox B1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox B2TextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button drawSignalButton;
        private System.Windows.Forms.Button slidingWindowButton;
        private System.Windows.Forms.Button parabolaButton;
        private System.Windows.Forms.Button medianFilteringButton;
    }
}

