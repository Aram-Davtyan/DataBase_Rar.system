using Npgsql;
using System.Data;
namespace ALL
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        NpgsqlConnection con;

        public Form1(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            updateCon();
        }

        void updateCon()
        {

            String sql = "Select* from products";//UPDATE COn
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            GV1.DataSource = dt;
            GV1.Columns[0].HeaderText = "¿…ƒ»";
            GV1.Columns[1].HeaderText = "»Ãﬂ";
            GV1.Columns[2].HeaderText = "≈‰. ËÁÏ.";
            int wid = this.Size.Width;
            int hid = this.Size.Height;
            Console.WriteLine(wid + " " + hid);
            GV1.Height = hid;
            GV1.Width = wid;
        }

        private void Delete(int id)
        {
            NpgsqlCommand command = new NpgsqlCommand("Delete from products where ID=:id", con);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form2(con);
            f1.ShowDialog();
            updateCon();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)GV1.CurrentRow.Cells["ID"].Value;
            Delete(id);
            updateCon();
        }

        private void Ë˘ÏÂÌËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NpgsqlCommand command = new NpgsqlCommand("UPDATE prodcuts SET name_product=:name WHERE ID=:id", this.con);
            int id = (int)GV1.CurrentRow.Cells["ID"].Value;
            string name = (string)GV1.CurrentRow.Cells["name_product"].Value;
            string weight = (string)(GV1.CurrentRow.Cells["edis_product"].Value);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name_product", name);
            command.Parameters.AddWithValue("weight_product", weight);
            Form f = new Form2(this.con, id, name, weight);
            f.ShowDialog();
            updateCon();
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}