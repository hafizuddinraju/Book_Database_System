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
    public partial class AuthorSave : Form
    {
        public AuthorSave()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JK8KA3B;Initial Catalog=Bookdatabase;Integrated Security=True");


        private void buttonAuthorSave_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO AuthorSave VALUES (@ID, @Name, @PhoneNumber)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Author Record successfull save", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("Book Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
