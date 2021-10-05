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
    public partial class FindoutAuthor : Form
    {
        public FindoutAuthor()
        {
            InitializeComponent();
        }

        private void buttonFindoutAuthor_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-JK8KA3B; Database = Bookdatabase; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Name, PhoneNumber FROM AuthorSave WHERE ID = '" + textBoxID.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxName.Text = reader["Name"].ToString();
                textBoxPhoneNumber.Text = reader["PhoneNumber"].ToString();


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
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxPhoneNumber.Clear();
        }
    }
}
