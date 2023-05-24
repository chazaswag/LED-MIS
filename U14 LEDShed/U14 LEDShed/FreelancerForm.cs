using System;
using System.Windows.Forms;

namespace U14_LEDShed
{
    public partial class FreelancerForm : Form
    {
        Freelancer free;
        Control controlclass;
        public FreelancerForm(Control inControl)
        {
            controlclass = inControl;
            free = new Freelancer();
            InitializeComponent();
        }

        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            FreelancerDetailsBox.Visible = true;
            paymentdetailsBox.Visible = false;
            email.Visible = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            FreelancerDetailsBox.Visible = false;
            paymentdetailsBox.Visible = false;
            email.Visible = true;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FreelancerDetailsBox.Visible = false;
            paymentdetailsBox.Visible = true;
            email.Visible = false;
        }
        private void WritetoObject()
        {
            free.sName = name.Text;
            free.sSpecialism = specialism.Text;
            free.sProfessionNotes = notes.Text;
            free.sRegion = region.Text;
            free.sAvaliability = avaliability.Text;
            free.sPreviousJobs = previousjobs.Text;
            free.sDailyRate = dailyrate.Text;
            free.sSortCode = sortcode.Text;
            free.sNINumber = NiN.Text;
            free.bVatRegistered = VAT.Checked;
            free.sWebAddress = webaddress.Text;
            free.sMobileNumber = PhoneNumber.Text;
            free.sEmail = email.Text;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
                WritetoObject();
                controlclass.freelancerList.Add(free);
                this.Close();
        }

        private void FreelancerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
