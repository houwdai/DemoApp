using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-3EQ7S2P;Initial Catalog=SuratPerjalananDinass;Integrated Security=True");

            ;
            string nama = namaPegawai.Text;
            string nip = NIP.Text;
            string jabatan = Jabatan.Text;
            string golongan = Golongan.Text;
            string id = Inputid.Text;
            string query = "INSERT INTO PEGAWAI values ('" + id + "','" + nama + "','" + nip + "','"  + jabatan + "','" + golongan + "')";
            SqlCommand sda = new SqlCommand(query, sqlConnection);
            MySqlDataReader MyReader2;
            sqlConnection.Open();
            sda.ExecuteNonQuery();     // Here our query will be executed and data saved into the database.
            MessageBox.Show("Save Data");

          


        }
    }
}
