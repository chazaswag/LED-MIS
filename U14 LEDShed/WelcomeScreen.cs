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

        private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm eventform = new EventForm(controlClass);
            this.Hide();
            eventform.ShowDialog();
            this.Show();
        }

        private void editEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventViewer eventviewer = new EventViewer(controlClass);
            this.Hide();
            eventviewer.ShowDialog();
            this.Show();
        }

        private void newFreelancerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreelancerForm freelancer = new FreelancerForm(controlClass);
            this.Hide();
            freelancer.ShowDialog();
            this.Show();
        }

        private void editFreelancerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Freelancer_Viewer freelancerviewer = new Freelancer_Viewer(controlClass);
            this.Hide();
            freelancerviewer.ShowDialog();
            this.Show();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = sfd.Filter = "proj Files (*.LED)|*.LED";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = sfd.FileName.ToString();
                    Savedata(controlClass, filepath);
                }
            }
            catch 
            {
                MessageBox.Show("Error saving, trying again.", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Savedata(Control inControl, string inFilePath)
        {
            try
            {
                using (System.IO.Stream strm = System.IO.File.Open(inFilePath, System.IO.FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(strm, inControl);
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
                MessageBox.Show("Error saving, trying again.", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ofd.Filter = "proj Files (*.LED)|*.LED";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.Stream openStream = System.IO.File.Open(ofd.FileName, System.IO.FileMode.Open))
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        controlClass = (Control)binaryFormatter.Deserialize(openStream);
                    }
                }
                catch
                {
                    MessageBox.Show("Load Error", "Save/load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
