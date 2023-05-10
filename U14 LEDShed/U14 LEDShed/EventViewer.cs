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
    public partial class EventViewer : Form
    {
        Control controlClass;
        Event currentEvent;
        EventForm evntform;
        public EventViewer(Control inControl)
        {
            InitializeComponent();
            controlClass = inControl;

            foreach (Event e in controlClass.eventsList)
            {
                lstEvents.Items.Add(e.sEventName);
            }
        }

        private void btnViewEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem == null)
            {
                MessageBox.Show("Please Select or create an event.");
            }
            else { 
            int eventNumber = lstEvents.SelectedIndex;
            currentEvent = controlClass.eventsList[eventNumber];
            EventDetailsBox.Visible = false;

            txtevebtname.Text = currentEvent.sEventName;
            txtevebtdetails.Text = currentEvent.sEventDetails;
            txtcompanyname.Text = currentEvent.sCompanyName;
            txtevebtlocation.Text = currentEvent.sEventLocation;
            txtEmail.Text = currentEvent.sEmail;
            txtPhoneNumber.Text = currentEvent.sPhoneNumber;
            dateTimePicker2.Value = currentEvent.dEventStart;
            dateTimePicker1.Value = currentEvent.dEventEnd;
            label2.Text = "Total cost: £" + currentEvent.dTotalcost;

            for (int rows = 0; rows < currentEvent.slEventItems.Count; rows++)
            {
                tblStock.Rows.Add(tblStock.Rows[rows].Clone());
                string item = currentEvent.slEventItems[rows];
                string cost = currentEvent.slItemCost[rows];
                string amount = currentEvent.slItemAmount[rows];
                tblStock.Rows[rows].Cells["Item"].Value = item;
                tblStock.Rows[rows].Cells["Amount"].Value = amount;
                tblStock.Rows[rows].Cells["Cost"].Value = cost;
                }

                for (int rows = 0; rows < tblStock.Rows.Count - 1; rows++)
                {
                    float fQuantity = float.Parse(tblStock.Rows[rows].Cells["Amount"].Value.ToString());
                    float fCost = float.Parse(tblStock.Rows[rows].Cells["Cost"].Value.ToString());
                    float fAmount = fQuantity * fCost;
                    tblStock.Rows[rows].Cells["Total"].Value = fAmount;
                }
            }
        }
    }
}
