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
    public partial class FindoutBook : Form
    {
        public FindoutBook()
        {
            InitializeComponent();
        }

        private void buttonFindout_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-JK8KA3B; Database = Bookdatabase; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Title, Price FROM BookAdd WHERE ISBN = '" + textBoxISBN.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxTitle.Text = reader["Title"].ToString();
                textBoxPrice.Text = reader["Price"].ToString();
                

            }
            else
            {
                MessageBox.Show("ISBN Number not found with this Database");
            }
            connection.Close();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            textBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxPrice.Clear();
        }
    }
}
