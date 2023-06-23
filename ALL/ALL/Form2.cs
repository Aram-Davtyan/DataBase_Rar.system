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
    public partial class Form2 : Form
    {
        NpgsqlConnection con;
        int id;
        public Form2(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            this.id = 0;
        }
        public Form2(NpgsqlConnection con, int id, string name, string ed)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = ed;
            this.con = con;
            this.id = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                try
                {

                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO products(name_product,edis_product) VALUES (:name,:ed)", con);
                    command.Parameters.AddWithValue("name", textBox1.Text);
                    command.Parameters.AddWithValue("ed", textBox2.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка записи в БД");
                }
            }
            else
            {
                try
                {

                    NpgsqlCommand command = new NpgsqlCommand("UPDATE products SET name_product=:name,edis_product=:ed WHERE ID=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name", textBox1.Text);
                    command.Parameters.AddWithValue("ed", textBox2.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch
                {

                }

            }
        }
    }
}
