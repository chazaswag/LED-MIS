using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U14_LEDShed
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            EventForm eventform = new EventForm();
            this.Hide();
            eventform.ShowDialog();
            this.Show();
        }
    }
}
