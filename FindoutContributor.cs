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
    public partial class FindoutContributor : Form
    {
        public FindoutContributor()
        {
            InitializeComponent();
        }

        private void buttonFindoutContributor_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-JK8KA3B; Database = Bookdatabase; Integrated Security = True ";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Con_Level, Con_Type  FROM Contributer WHERE Con_ID = '" + textBoxCon_ID.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                textBoxCon_Level.Text = reader["Con_Level"].ToString();
                textBoxCon_Type.Text = reader["Con_Type"].ToString();


            }
            else
            {
                MessageBox.Show("ID Number not found with this Database");
            }
            connection.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            textBoxCon_Type.Clear();
            textBoxCon_ID.Clear();
            textBoxCon_Level.Clear();
        }
    }
}
