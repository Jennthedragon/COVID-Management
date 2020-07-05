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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {            
            DateTime[] QuarantineDates = new DateTime[]
            {
                Variables.iDate, Variables.iDate.AddDays(1), Variables.iDate.AddDays(2), Variables.iDate.AddDays(3), Variables.iDate.AddDays(4), Variables.iDate.AddDays(5), Variables.iDate.AddDays(6), Variables.iDate.AddDays(7), Variables.iDate.AddDays(8), Variables.iDate.AddDays(9), Variables.iDate.AddDays(10), Variables.iDate.AddDays(11), Variables.iDate.AddDays(12), Variables.iDate.AddDays(13)
            };
            monthCalendar1.BoldedDates = QuarantineDates;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
