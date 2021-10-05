using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bookdatabase
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JK8KA3B;Initial Catalog=Bookdatabase;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LogIn VALUES(@UserName, @Password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", textBoxUserName.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
               
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Record successfull save", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
            if (textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Book Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-JK8KA3B; Database = Bookdatabase; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM LogIn WHERE UserName = '" + textBoxUserName.Text + "' and Password = '" + textBoxPassword.Text +" ' ";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxUserName.Text = reader["UserName"].ToString();
                textBoxPassword.Text = reader["Password"].ToString();

                HomeView HV = new HomeView();
                HV.Show();


            }
            else
            {
                MessageBox.Show("Admin not found with this Database");
            }
            connection.Close();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
