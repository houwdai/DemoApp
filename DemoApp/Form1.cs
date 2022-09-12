using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-3EQ7S2P;Initial Catalog=SuratPerjalananDinass;Integrated Security=True");
            /*string query = "select * from admins where = '" + input_username.Text.Trim() +
                "' and password = '" + input_password.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }*/
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            string query = "SELECT COUNT(*) FROM admins WHERE username='" + input_username.Text + "' AND password='" + input_password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}