using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL
{
    public partial class Form6 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;

        public Form6(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }

        void updateCon()
        {

            //String sql = "Select* from future";
            String sql = "Select future.id, client.name_client, future.total_sum, future.data_otp,future.data_dos" +
                " FROM client JOIN future ON client.id = future.id_client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            GV1.DataSource = dt;
            GV1.Columns[0].HeaderText = "АЙДИ";
            GV1.Columns[1].HeaderText = "Клиент(id)";
            GV1.Columns[2].HeaderText = "TotalSum";
            GV1.Columns[3].HeaderText = "Дата отправки";
            GV1.Columns[4].HeaderText = "Дата доставки";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            GV1.Height = hid;
            GV1.Width = wid;
        }

        private void Delete(int id)
        {
            NpgsqlCommand command = new NpgsqlCommand("Delete from future where ID=:id", con);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ищменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)GV1.CurrentRow.Cells["ID"].Value;
            Delete(id);
            updateCon();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int id = (int)GV1.CurrentRow.Cells["ID"].Value;
            Delete(id);
            updateCon();
        }

        private void GV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
