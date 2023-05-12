using System;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewFreelancer_Click(object sender, EventArgs e)
        {
            FreelancerForm freelancer = new FreelancerForm(controlClass);
            this.Hide();
            freelancer.ShowDialog();
            this.Show();
        }

        private void btnEditFreelancer_Click(object sender, EventArgs e)
        {
            Freelancer_Viewer freelancerviewer = new Freelancer_Viewer(controlClass);
            this.Hide();
            freelancerviewer.ShowDialog();
            this.Show();
        }
    }
}
