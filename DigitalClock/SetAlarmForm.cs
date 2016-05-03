using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class SetAlarmForm : Form
    {
        public SetAlarmForm()
        {
            InitializeComponent();
        }

        private void SetAlarmForm_Load(object sender, EventArgs e)
        {
            cbDate.SelectedIndex = 0;
            cbTimeHour.SelectedIndex = 0;
            cbTimeMin.SelectedIndex = 0;
            cbSnoozMin.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }
    }// end Class
}// end Namepace
