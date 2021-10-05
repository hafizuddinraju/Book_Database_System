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
    public partial class BookSave : Form
    {
        public BookSave()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JK8KA3B;Initial Catalog=Bookdatabase;Integrated Security=True");
       
        private void BookSave_Load(object sender, EventArgs e)
        {

        }

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO BookAdd VALUES(@ISBN, @Title, @Price)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                cmd.Parameters.AddWithValue("@Price", textBoxPrice.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Book Record successfull save", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private bool IsValid()
        {
           if(textBoxTitle.Text == string.Empty )
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
            textBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxPrice.Clear();
        }
    }

   
}
