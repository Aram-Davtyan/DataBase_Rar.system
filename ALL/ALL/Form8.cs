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
    public partial class Form8 : Form
    {

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        NpgsqlConnection con;

        public Form8(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }

        void updateCon()
        {

            //String sql = "Select* from futureinfo";
            //String sql = "Select futureinfo.id, futureinfo.id_future, price_list.price, futureinfo.kol FROM price_list JOIN futureinfo ON price_list.id = futureinfo.id_price_list";
            String sql = "Select futureinfo.id, client.name_client, price_list.price * futureinfo.kol, future.data_otp,future.data_dos, products.name_product, price_list.price, futureinfo.kol " +
                "FROM price_list JOIN futureinfo ON price_list.id = futureinfo.id_price_list JOIN future ON future.id = futureinfo.id_future " +
                "JOIN client ON client.id = future.id_client JOIN products ON products.id = price_list.id_products";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            GV1.DataSource = dt;
            GV1.Columns[0].HeaderText = "АЙДИ";
            GV1.Columns[1].HeaderText = "Имя Клиента";
            GV1.Columns[2].HeaderText = "Общая сумма";
            GV1.Columns[3].HeaderText = "Дата отправки";
            GV1.Columns[4].HeaderText = "Дата доставки";
            GV1.Columns[5].HeaderText = "Продукт";
            GV1.Columns[6].HeaderText = "Цена";
            GV1.Columns[7].HeaderText = "Колличество";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            GV1.Height = hid;
            GV1.Width = wid;
        }


        private void GV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
