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
    public partial class Contributor : Form
    {
        public Contributor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JK8KA3B;Initial Catalog=Bookdatabase;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Contributer VALUES(@Con_ID, @Con_Level, @Con_Type)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Con_ID", textBoxCon_ID.Text);
                cmd.Parameters.AddWithValue("@Con_Level", textBoxCon_Level.Text);
                cmd.Parameters.AddWithValue("@Con_Type", textBoxCon_Type.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Contributor Record successfull save", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private bool IsValid()
        {
            if (textBoxCon_ID.Text == string.Empty)
            {
                MessageBox.Show("Contributor Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Contributor_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            textBoxCon_ID.Clear();
            textBoxCon_Level.Clear();
            textBoxCon_Type.Clear();
        }
    }
}
