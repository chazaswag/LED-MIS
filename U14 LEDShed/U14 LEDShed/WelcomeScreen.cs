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
        Control controlClass;
        public WelcomeScreen(Control inControl)
        {
            InitializeComponent();
            controlClass = inControl;
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            EventForm eventform = new EventForm(controlClass);
            this.Hide();
            eventform.ShowDialog();
            this.Show();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnViewEvent_Click(object sender, EventArgs e)
        {
            EventViewer eventviewer = new EventViewer(controlClass);
            this.Hide();
            eventviewer.ShowDialog();
            this.Show();
        }
    }
}
