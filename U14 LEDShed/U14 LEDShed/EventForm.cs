using System;
using System.Windows.Forms;

namespace U14_LEDShed
{
    public partial class EventForm : Form
    {
        float fOverall = 0;
        Event evnt;
        EventCost evntcst;
        Control controlClass;
        public EventForm(Control inControl)
        {
            InitializeComponent();
            evnt = new Event();
            evntcst = new EventCost();
            controlClass = inControl;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            CostDetailsBox.Visible = true;
            EventDetailsBox.Visible = false;
            btnCompleteEvent.Visible = false;
            EventContactBox.Visible = false;
            freelancer.Visible = false;
        }

        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            CostDetailsBox.Visible = false;
            EventDetailsBox.Visible = true;
            btnCompleteEvent.Visible = false;
            EventContactBox.Visible = false;
            freelancer.Visible = false;
        }

        private void btnEventCosts_Click(object sender, EventArgs e)
        {
            CostDetailsBox.Visible = false;
            EventDetailsBox.Visible = false;
            btnCompleteEvent.Visible = true;
            EventContactBox.Visible = false;
            freelancer.Visible = false;
        }
        private void btnContact_Click(object sender, EventArgs e)
        {
            EventContactBox.Visible = true;
            CostDetailsBox.Visible = false;
            EventDetailsBox.Visible = false;
            btnCompleteEvent.Visible = false;
            freelancer.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EventContactBox.Visible = false;
            CostDetailsBox.Visible = false;
            EventDetailsBox.Visible = false;
            btnCompleteEvent.Visible = false;
            freelancer.Visible = true;
        }

        private void EventForm_Load_1(object sender, EventArgs e)
        {
            foreach (Freelancer f in controlClass.freelancerList)
            {
                freelancherCheckbox.Items.Add(f.sName);
            }
        }

        private void tblStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateItems();
        }


        public void calculateItems()
        {
            try
            {
                for (int rows = 0; rows < tblStock.Rows.Count - 1; rows++)
                {
                    float fQuantity = (float)Math.Ceiling(float.Parse(tblStock.Rows[rows].Cells["Amount"].Value.ToString()));
                    float fCost = float.Parse(tblStock.Rows[rows].Cells["Cost"].Value.ToString());
                    if (fCost < 0 || fQuantity < 0)
                    {
                        MessageBox.Show("Check the data is enetered correctly. Numbers cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        float fAmount = fQuantity * fCost;
                        tblStock.Rows[rows].Cells["Total"].Value = fAmount;
                        tblStock.Rows[rows].Cells["Amount"].Value = fQuantity.ToString();
                        fOverall = 0;
                        for (rows = 0; rows < tblStock.Rows.Count - 1; rows++)
                        {
                            float fTotal = float.Parse(tblStock.Rows[rows].Cells["Total"].Value.ToString());
                            fOverall += fTotal;
                            label3.Text = "Total: " + fOverall.ToString();
                        }
                    }
                }
                
            }
            catch {
                MessageBox.Show("Check the data is enetered correctly. Use numbers as digits not text.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void totalmoney()
        {
            evntcst.dTransportCost = evnt.dDays * 22;
            txtTravelCost.Text = "Travel Cost: " + evntcst.dTransportCost;
            evntcst.dAccomodationCost = evnt.dDays * 32;
            txtAccomodationCost.Text = "Accomodation Cost: " + evntcst.dAccomodationCost;
            evntcst.dStaffingCost = evnt.dDays * 50.5;
            txtStaffingCost.Text = "Staffing Cost: " + evntcst.dStaffingCost;
            evntcst.dCateringCost = evnt.dDays * 23.5;
            txtCateringCost.Text = "Catering Cost: " + evntcst.dCateringCost;
            evntcst.dTotalCost = evntcst.dCateringCost + evntcst.dStaffingCost + evntcst.dAccomodationCost + evntcst.dTransportCost + fOverall;
            txtTotalCost.Text = "Total Cost: " + evntcst.dTotalCost;

            for (int rows = 0; rows < freelancherCheckbox.Items.Count; rows++)
            {
                eventFreeLancer ef = new eventFreeLancer();
                ef.name = freelancherCheckbox.Items[rows].ToString();
                ef.onevent = freelancherCheckbox.GetItemChecked(rows);
                evnt.freelancerList.Add(ef);

            }
        }

        public void writeToObject()
        {
            evnt.sEventName = textBox5.Text;
            evnt.sCompanyName = txtCompanyName.Text;
            evnt.sEventDetails = textBox4.Text;
            evnt.sEventLocation = textBox3.Text;
            evnt.dEventStart = dateTimePicker2.Value;
            evnt.dEventEnd = dateTimePicker1.Value;
            evnt.sEmail = txtEmail.Text;
            evnt.sPhoneNumber = txtPhoneNumber.Text;
            evnt.dTotalcost = evntcst.dTotalCost;


            for (int rows = 0; rows < tblStock.Rows.Count - 1; rows++)
            {
                evnt.slEventItems.Add(tblStock.Rows[rows].Cells["Item"].Value.ToString());
                evnt.slItemAmount.Add(tblStock.Rows[rows].Cells["Amount"].Value.ToString());
                evnt.slItemCost.Add(tblStock.Rows[rows].Cells["Cost"].Value.ToString());
            }
        }
        bool valid = false;
        public void ValidateForm()
        {
            if (textBox5.Text == "" || txtCompanyName.Text == "" || textBox4.Text == "" || textBox3.Text == "" || evnt.dDays < 1 || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Some of your details are invalid or blank. Please fill them in.");
                valid = false;
            }
            if (textBox3.Text.Contains("@") == false || textBox3.Text.Contains(".") == false)
            {
                MessageBox.Show("The email address is invalid.");
                valid = false;
            }
            if (txtPhoneNumber.Text.Length > 14)
            {
                MessageBox.Show("The phone number is invalid.");
                valid = false;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            evnt.DatesElapsed();
            calculateItems();
            totalmoney();
            writeToObject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valid = true;
            evnt.DatesElapsed();
            ValidateForm();
            if (valid)
            {
                writeToObject();
                calculateItems();
                totalmoney();
                controlClass.eventsList.Add(evnt);
                this.Close();
            }

        }


    }
}