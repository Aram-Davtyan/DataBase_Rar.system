namespace ALL
{
    partial class Form6
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
            GV1.TabIndex = 4;
            GV1.CellContentClick += GV1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(916, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 430);
            Controls.Add(GV1);
            Controls.Add(menuStrip1);
            Name = "Form6";
            Text = "Future";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)GV1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GV1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}