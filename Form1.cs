using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace COVID_Management
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            //this.Close();
        }
        
        private void yesCovidPosButton_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            //this.Close();
        }

        private void quarantineScheduleButton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            //this.Close();

        }

        private void companyLogoPicture_Click(object sender, EventArgs e)
        {

        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();

            loginButton.Visible = false;
            goodMorningLabel.Text = "Good Morning, " + NameClass.firstName;   
            goodMorningLabel.Visible = true;
            managerNameLabel.Visible = true;
        }
    }

}