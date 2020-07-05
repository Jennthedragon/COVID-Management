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
    public partial class Form9 : Form
    {
        //configures firebase 
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "B2ZyJIc6a1qeGcy31DfSrGGSwevdn2tPWPii8HsR",
            BasePath = "https://covid-manager-bf570.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //tests if firebase connection is successful
            client = new FireSharp.FirebaseClient(config);

            /*if (client != null)
            {
                MessageBox.Show("Connection is established");
            }*/


        }
        private async void loginButton_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = textBox1.Text,
                FirstName = textBox2.Text,
                LastName = textBox3.Text,
                Email = textBox4.Text
            };

            SetResponse response = await client.SetAsync("Information/"+textBox1.Text,data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Verified Employee " + result.Id);


            Close();

            NameClass.firstName = textBox2.Text;            

        }
        

    }
}
