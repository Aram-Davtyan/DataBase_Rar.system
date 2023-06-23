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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace ALL
{
    public partial class Form7 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private DataSet ds1 = new DataSet();
        private DataTable dt1 = new DataTable();
        public string name1;

        NpgsqlConnection con;

        public Form7(NpgsqlConnection con)
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

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            for (int i = 0; i <= GV2.RowCount - 2; i++)
            {
                for (int j = 0; j <= GV2.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = GV2.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = GV2[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;
        }


        private void tic(int idd)
        {
            DateTime dateTime1 = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;
            //NpgsqlCommand command = new NpgsqlCommand("INSERT INTO oth (name_client, adress) SELECT name_client, adress FROM client WHERE id = :idd", con);
            NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO oth (name_client, adress) SELECT products.name_product, futureinfo.kol * price_list.price " +
                $"FROM price_list JOIN futureinfo ON price_list.id = futureinfo.id_price_list JOIN future ON future.id = futureinfo.id_future " +
                $"JOIN client ON client.id = future.id_client JOIN products ON products.id = price_list.id_products " +
                $"WHERE client.id = :idd AND future.data_otp > '{dateTime1}' AND future.data_otp < '{dateTime2}' AND future.data_dos > '{dateTime2}'", con);
            command.Parameters.AddWithValue("idd", idd);
            command.ExecuteNonQuery();

        }

        private void tac()
        {

            String sql1 = "Select* from oth";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql1, con);
            ds1.Reset();
            da1.Fill(ds1);
            dt1 = ds1.Tables[0];
            GV2.DataSource = dt1;
            GV2.Columns[0].HeaderText = "АЙДИ";
            GV2.Columns[1].HeaderText = "Товар";
            GV2.Columns[2].HeaderText = "Сумма заказа";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idd = (int)GV1.CurrentRow.Cells["ID"].Value;
            tic(idd);
            tac();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("DELETE from oth", con);
            command.ExecuteNonQuery();
            updateCon();
            tac();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
