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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void buttonSaveInformation_Click(object sender, EventArgs e)
        {
            ManuPage MP = new ManuPage();
            MP.Show();
        }

        private void buttonFindoutInformation_Click(object sender, EventArgs e)
        {
            ManuFindView MFV = new ManuFindView();
            MFV.Show();
        }
    }
}
