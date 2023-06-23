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
using System.Data;

namespace ALL
{
    public partial class Form4 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;

        public Form4(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }

        void updateCon()
        {

            String sql = "Select* from client";//UPDATE COn
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            GV1.DataSource = dt;
            GV1.Columns[0].HeaderText = "АЙДИ";
            GV1.Columns[1].HeaderText = "ИМЯ";
            GV1.Columns[2].HeaderText = "AДРЕС";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            GV1.Height = hid;
            GV1.Width = wid;
        }

        private void Delete(int id)
        {
            NpgsqlCommand command = new NpgsqlCommand("Delete from client where ID=:id", con);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)GV1.CurrentRow.Cells["ID"].Value;
            Delete(id);
            updateCon();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form5(con);
            f1.ShowDialog();
            updateCon();
        }

        private void ищменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("UPDATE client SET name_client=:name WHERE ID=:id", this.con);
            int id = (int)GV1.CurrentRow.Cells["ID"].Value;
            string name = (string)GV1.CurrentRow.Cells["name_client"].Value;
            string weight = (string)(GV1.CurrentRow.Cells["adress"].Value);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name_client", name);
            command.Parameters.AddWithValue("adress", weight);
            Form f = new Form5(this.con, id, name, weight);
            f.ShowDialog();
            updateCon();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
