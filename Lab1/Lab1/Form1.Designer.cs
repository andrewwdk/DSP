namespace Lab1
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
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.task1aButton = new System.Windows.Forms.Button();
            this.task1bButton = new System.Windows.Forms.Button();
            this.task1cButton = new System.Windows.Forms.Button();
            this.task2Button = new System.Windows.Forms.Button();
            this.task2bButton = new System.Windows.Forms.Button();
            this.task4Button = new System.Windows.Forms.Button();
            this.part2Task1Button = new System.Windows.Forms.Button();
            this.part2Task2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackColor = System.Drawing.Color.White;
            this.backgroundPictureBox.Location = new System.Drawing.Point(12, 40);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(1384, 688);
            this.backgroundPictureBox.TabIndex = 0;
            this.backgroundPictureBox.TabStop = false;
            // 
            // task1aButton
            // 
            this.task1aButton.Location = new System.Drawing.Point(1422, 12);
            this.task1aButton.Name = "task1aButton";
            this.task1aButton.Size = new System.Drawing.Size(103, 84);
            this.task1aButton.TabIndex = 1;
            this.task1aButton.Text = "Task 1a (A=7, f=5, fi=(pi, 0, pi/3, pi/6, pi/2) )";
            this.task1aButton.UseVisualStyleBackColor = true;
            this.task1aButton.Click += new System.EventHandler(this.Task1aButton_Click);
            // 
            // task1bButton
            // 
            this.task1bButton.Location = new System.Drawing.Point(1422, 102);
            this.task1bButton.Name = "task1bButton";
            this.task1bButton.Size = new System.Drawing.Size(103, 84);
            this.task1bButton.TabIndex = 2;
            this.task1bButton.Text = "Task 1b (A=5, fi=3pi/4, f=(1, 5, 11, 6, 3) )";
            this.task1bButton.UseVisualStyleBackColor = true;
            this.task1bButton.Click += new System.EventHandler(this.Task1bButton_Click);
            // 
            // task1cButton
            // 
            this.task1cButton.Location = new System.Drawing.Point(1422, 192);
            this.task1cButton.Name = "task1cButton";
            this.task1cButton.Size = new System.Drawing.Size(103, 84);
            this.task1cButton.TabIndex = 3;
            this.task1cButton.Text = "Task 1c (f=3, fi=3pi/4, A=(1, 2, 11, 4, 2) )";
            this.task1cButton.UseVisualStyleBackColor = true;
            this.task1cButton.Click += new System.EventHandler(this.Task1cButton_Click);
            // 
            // task2Button
            // 
            this.task2Button.Location = new System.Drawing.Point(1422, 282);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(103, 84);
            this.task2Button.TabIndex = 4;
            this.task2Button.Text = "Task 2";
            this.task2Button.UseVisualStyleBackColor = true;
            this.task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // task2bButton
            // 
            this.task2bButton.Location = new System.Drawing.Point(1422, 372);
            this.task2bButton.Name = "task2bButton";
            this.task2bButton.Size = new System.Drawing.Size(103, 84);
            this.task2bButton.TabIndex = 5;
            this.task2bButton.Text = "Task 2 (A, f - const, fi += pi10)";
            this.task2bButton.UseVisualStyleBackColor = true;
            this.task2bButton.Click += new System.EventHandler(this.Task2bButton_Click);
            // 
            // task4Button
            // 
            this.task4Button.Location = new System.Drawing.Point(1422, 462);
            this.task4Button.Name = "task4Button";
            this.task4Button.Size = new System.Drawing.Size(103, 84);
            this.task4Button.TabIndex = 6;
            this.task4Button.Text = "Task 4";
            this.task4Button.UseVisualStyleBackColor = true;
            this.task4Button.Click += new System.EventHandler(this.Task4Button_Click);
            // 
            // part2Task1Button
            // 
            this.part2Task1Button.Location = new System.Drawing.Point(1422, 552);
            this.part2Task1Button.Name = "part2Task1Button";
            this.part2Task1Button.Size = new System.Drawing.Size(103, 84);
            this.part2Task1Button.TabIndex = 7;
            this.part2Task1Button.Text = "Part 2 Task 1";
            this.part2Task1Button.UseVisualStyleBackColor = true;
            this.part2Task1Button.Click += new System.EventHandler(this.Part2Task1Button_Click);
            // 
            // part2Task2Button
            // 
            this.part2Task2Button.Location = new System.Drawing.Point(1422, 644);
            this.part2Task2Button.Name = "part2Task2Button";
            this.part2Task2Button.Size = new System.Drawing.Size(103, 84);
            this.part2Task2Button.TabIndex = 8;
            this.part2Task2Button.Text = "Part 2 Task 2";
            this.part2Task2Button.UseVisualStyleBackColor = true;
            this.part2Task2Button.Click += new System.EventHandler(this.Part2Task2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 754);
            this.Controls.Add(this.part2Task2Button);
            this.Controls.Add(this.part2Task1Button);
            this.Controls.Add(this.task4Button);
            this.Controls.Add(this.task2bButton);
            this.Controls.Add(this.task2Button);
            this.Controls.Add(this.task1cButton);
            this.Controls.Add(this.task1bButton);
            this.Controls.Add(this.task1aButton);
            this.Controls.Add(this.backgroundPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Button task1aButton;
        private System.Windows.Forms.Button task1bButton;
        private System.Windows.Forms.Button task1cButton;
        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.Button task2bButton;
        private System.Windows.Forms.Button task4Button;
        private System.Windows.Forms.Button part2Task1Button;
        private System.Windows.Forms.Button part2Task2Button;
    }
}

