namespace HomeWork_1
{
    partial class HomeWork_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWork_1));
            this.Close = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Lab_work_1 = new System.Windows.Forms.Label();
            this.LabFromStudent = new System.Windows.Forms.Label();
            this.First_Laste_NAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(412, 311);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 44);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Pink
            // 
            this.Pink.Location = new System.Drawing.Point(140, 311);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(76, 44);
            this.Pink.TabIndex = 1;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = true;
            this.Pink.Click += new System.EventHandler(this.Pink_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.White;
            this.Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Blue.Location = new System.Drawing.Point(26, 311);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(80, 44);
            this.Blue.TabIndex = 2;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Lab_work_1
            // 
            this.Lab_work_1.AutoSize = true;
            this.Lab_work_1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_work_1.Location = new System.Drawing.Point(87, 43);
            this.Lab_work_1.Name = "Lab_work_1";
            this.Lab_work_1.Size = new System.Drawing.Size(411, 40);
            this.Lab_work_1.TabIndex = 3;
            this.Lab_work_1.Text = "Лабораторна робота №1";
            // 
            // LabFromStudent
            // 
            this.LabFromStudent.AutoSize = true;
            this.LabFromStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabFromStudent.Location = new System.Drawing.Point(111, 102);
            this.LabFromStudent.Name = "LabFromStudent";
            this.LabFromStudent.Size = new System.Drawing.Size(275, 25);
            this.LabFromStudent.TabIndex = 4;
            this.LabFromStudent.Text = "Виконав студент групи ІТ-52";
            // 
            // First_Laste_NAME
            // 
            this.First_Laste_NAME.AutoSize = true;
            this.First_Laste_NAME.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First_Laste_NAME.Location = new System.Drawing.Point(12, 155);
            this.First_Laste_NAME.Name = "First_Laste_NAME";
            this.First_Laste_NAME.Size = new System.Drawing.Size(515, 29);
            this.First_Laste_NAME.TabIndex = 5;
            this.First_Laste_NAME.Text = "Войчишин Олександр Олександрович";
            // 
            // HomeWork_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 416);
            this.Controls.Add(this.First_Laste_NAME);
            this.Controls.Add(this.LabFromStudent);
            this.Controls.Add(this.Lab_work_1);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 463);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(597, 463);
            this.Name = "HomeWork_1";
            this.Text = "HomeWork_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Label Lab_work_1;
        private System.Windows.Forms.Label LabFromStudent;
        private System.Windows.Forms.Label First_Laste_NAME;
    }
}

