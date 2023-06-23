namespace ALL
{
    partial class Form3
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(132, 27);
            button2.Name = "button2";
            button2.Size = new Size(124, 30);
            button2.TabIndex = 1;
            button2.Text = "Товары";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(132, 63);
            button1.Name = "button1";
            button1.Size = new Size(124, 30);
            button1.TabIndex = 2;
            button1.Text = "Клиенты";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(132, 207);
            button3.Name = "button3";
            button3.Size = new Size(124, 30);
            button3.TabIndex = 3;
            button3.Text = "Отчет";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(132, 99);
            button4.Name = "button4";
            button4.Size = new Size(124, 30);
            button4.TabIndex = 4;
            button4.Text = "Future";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(132, 135);
            button5.Name = "button5";
            button5.Size = new Size(124, 30);
            button5.TabIndex = 6;
            button5.Text = "FutureInfo";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(132, 171);
            button6.Name = "button6";
            button6.Size = new Size(124, 30);
            button6.TabIndex = 7;
            button6.Text = "Price List ";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(374, 311);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form3";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}