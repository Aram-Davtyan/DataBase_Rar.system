namespace ALL
{
    partial class Form4
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
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            ищменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)GV1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GV1
            // 
            GV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV1.Location = new Point(0, 27);
            GV1.Name = "GV1";
            GV1.RowTemplate.Height = 25;
            GV1.Size = new Size(913, 400);
            GV1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, ищменитьToolStripMenuItem, удалитьToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(915, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(71, 20);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // ищменитьToolStripMenuItem
            // 
            ищменитьToolStripMenuItem.Name = "ищменитьToolStripMenuItem";
            ищменитьToolStripMenuItem.Size = new Size(73, 20);
            ищменитьToolStripMenuItem.Text = "Изменить";
            ищменитьToolStripMenuItem.Click += ищменитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(63, 20);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(915, 428);
            Controls.Add(GV1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form4";
            Text = "Клиенты";
            TransparencyKey = Color.IndianRed;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)GV1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GV1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem ищменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}