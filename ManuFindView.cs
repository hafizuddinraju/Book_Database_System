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
    public partial class ManuFindView : Form
    {
        public ManuFindView()
        {
            InitializeComponent();
        }

        private void buttonFindBook_Click(object sender, EventArgs e)
        {
            FindoutBook Fob = new FindoutBook();
            Fob.Show();
        }

        private void buttonFindAuthor_Click(object sender, EventArgs e)
        {
            FindoutAuthor foa = new FindoutAuthor();
            foa.Show();
        }

        private void buttonFindPublisher_Click(object sender, EventArgs e)
        {
            FindoutPublisher fop = new FindoutPublisher();
            fop.Show();
        }

        private void buttonFindContributor_Click(object sender, EventArgs e)
        {
            FindoutContributor foc = new FindoutContributor();
            foc.Show();
        }
    }
}
