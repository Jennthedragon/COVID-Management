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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedIndices.Count > 0)
            {
                Form8 f8 = new Form8();
                f8.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Congratulations! You are fit for work. See you at 8!");
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
