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
using Excel = Microsoft.Office.Interop.Excel;

namespace ALL
{
    public partial class Form9 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        NpgsqlConnection con;

        public Form9(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }

        void updateCon()
        {

            //String sql = "Select* from price_list";
            String sql = "Select price_list.id, name_product,price " +
                "FROM products JOIN price_list ON products.id = price_list.id_products";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            GV1.DataSource = dt;
            GV1.Columns[0].HeaderText = "АЙДИ";
            GV1.Columns[1].HeaderText = "Products(id)";
            GV1.Columns[2].HeaderText = "Price";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            GV1.Height = hid;
            GV1.Width = wid;
        }


        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            for (int i = 0; i <= GV1.RowCount - 2; i++)
            {
                for (int j = 0; j <= GV1.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = GV1.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = GV1[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
