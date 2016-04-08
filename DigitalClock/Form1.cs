using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }// end Form1

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString().ToString();
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            lblTime.Focus();
            SetAlarmForm SetAlarmForm = new SetAlarmForm();
            SetAlarmForm.ShowDialog();
        }

        private void radioAlarmOff_CheckedChanged(object sender, EventArgs e)
        {
            btnSetAlarm.Enabled = false;
            lblAlarmStatus.Text = "Alarm Disabled";
        }

        private void radioAlarmOn_CheckedChanged(object sender, EventArgs e)
        {
            btnSetAlarm.Enabled = true;
            lblAlarmStatus.Text = "";
        }


    }// end Class
}// end Namespace
