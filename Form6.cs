using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_Management
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void COVIDPosButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Close();

        }

        private void COVIDNegButton_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Close();

        }

        private void COVIDResultsNotReceivedButton_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Close();

        }
    }
}
