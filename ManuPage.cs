using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookdatabase
{
    public partial class ManuPage : Form
    {
        public ManuPage()
        {
            InitializeComponent();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            BookSave BS = new BookSave();
            BS.Show();
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            AuthorSave AS = new AuthorSave();
            AS.Show();

        }

        private void buttonPublisher_Click(object sender, EventArgs e)
        {
            Publisher PR = new Publisher();
            PR.Show();
        }

        private void buttonContributor_Click(object sender, EventArgs e)
        {
            Contributor CR = new Contributor();
            CR.Show();
        }
    }
}
