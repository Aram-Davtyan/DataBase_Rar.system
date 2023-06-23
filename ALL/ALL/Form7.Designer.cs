namespace ALL
{
    partial class Form7
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
            GV1 = new DataGridView();
            GV2 = new DataGridView();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)GV1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GV2).BeginInit();
            SuspendLayout();
            // 
            // GV1
            // 
            GV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV1.Location = new Point(12, 12);
            GV1.Name = "GV1";
            GV1.RowTemplate.Height = 25;
            GV1.Size = new Size(550, 246);
            GV1.TabIndex = 5;
            // 
            // GV2
            // 
            GV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV2.Location = new Point(12, 325);
            GV2.Name = "GV2";
            GV2.RowTemplate.Height = 25;
            GV2.Size = new Size(1000, 261);
            GV2.TabIndex = 6;
            // 
            // label3
            // 
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(795, 177);
            label3.Name = "label3";
            label3.Size = new Size(18, 23);
            label3.TabIndex = 17;
            label3.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(818, 174);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(143, 23);
            dateTimePicker2.TabIndex = 16;
            dateTimePicker2.Value = new DateTime(2022, 1, 20, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(647, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 297);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 18;
            label1.Text = "OTЧЁТ";
            // 
            // button1
            // 
            button1.Location = new Point(879, 71);
            button1.Name = "button1";
            button1.Size = new Size(88, 32);
            button1.TabIndex = 19;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(609, 72);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(786, 592);
            button2.Name = "button2";
            button2.Size = new Size(98, 40);
            button2.TabIndex = 21;
            button2.Text = "Экспорт в Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(335, 270);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(667, 141);
            label5.Name = "label5";
            label5.Size = new Size(266, 21);
            label5.TabIndex = 23;
            label5.Text = "Виберите промежуток времени ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(657, 76);
            label6.Name = "label6";
            label6.Size = new Size(216, 21);
            label6.TabIndex = 24;
            label6.Text = "Добавить Клиента в отчет";
            // 
            // button3
            // 
            button3.Location = new Point(682, 592);
            button3.Name = "button3";
            button3.Size = new Size(98, 40);
            button3.TabIndex = 25;
            button3.Text = "Очистить отчёт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(899, 592);
            button4.Name = "button4";
            button4.Size = new Size(98, 40);
            button4.TabIndex = 26;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 640);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(GV2);
            Controls.Add(GV1);
            Name = "Form7";
            Text = "Отчёт";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)GV1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GV2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GV1;
        private DataGridView GV2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
    }
}