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
    public partial class Freelancer_Viewer : Form
    {
        Control controlClass;
        Freelancer currentfreelancer;
        public Freelancer_Viewer(Control inControl)
        {
            InitializeComponent();
            controlClass = inControl;

            foreach (Event f in controlClass.eventsList)
            {
                lstEvents.Items.Add(f.sEventName);
            }
        }

        private void btnViewEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem == null)
            {
                MessageBox.Show("Please Select or create a freelancer profile.");
            }
            else
            {
                int freelancernumber = lstEvents.SelectedIndex;
                currentfreelancer = controlClass.freelancerList[freelancernumber];
                EventDetailsBox.Visible = false;

                name.Text = currentfreelancer.sName;
                notes.Text = currentfreelancer.sProfessionNotes;
                specialism.Text = currentfreelancer.sSpecialism;
                region.Text = currentfreelancer.sRegion;
                txtEmail.Text = currentfreelancer.sEmail;
                PhoneNumber.Text = currentfreelancer.sMobileNumber;
                avaliability.Text = currentfreelancer.sAvaliability;
                previousjobs.Text = currentfreelancer.sPreviousJobs;
                webaddress.Text = currentfreelancer.sWebAddress;
                sortcode.Text = currentfreelancer.sSortCode;
                NiN.Text = currentfreelancer.sNINumber;
                dailyrate.Text = currentfreelancer.sDailyRate;
                VAT.Checked = currentfreelancer.bVatRegistered;
            }
        }
    }
}
