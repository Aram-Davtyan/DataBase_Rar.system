using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ALL
{

    public partial class Form3 : Form
    {
        NpgsqlConnection con;

        public Form3()
        {
            con = new NpgsqlConnection("Server=localhost;Port=5432;User ID=postgres;Password=3dAb4dFs;Database=db_ARM");
            con.Open();
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1(con);
            f1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form4(con);
            f1.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form f1 = new Form6(con);
            f1.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form f1 = new Form7(con);
            f1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f1 = new Form8(con);
            f1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f1 = new Form9(con);
            f1.ShowDialog();
        }
    }
}
