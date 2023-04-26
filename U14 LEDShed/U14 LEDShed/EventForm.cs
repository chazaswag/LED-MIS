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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            CostDetailsBox.Visible = true;
            EventDetailsBox.Visible = false;

        }

        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            CostDetailsBox.Visible = false;
            EventDetailsBox.Visible = true;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void tblStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EventForm_Load_1(object sender, EventArgs e)
        {

        }

        private void tblStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int rows = 0; rows < tblStock.Rows.Count - 1; rows++)
            {
                float fQuantity = float.Parse(tblStock.Rows[rows].Cells["Amount"].Value.ToString());
                float fCost = float.Parse(tblStock.Rows[rows].Cells["Cost"].Value.ToString());
                float fAmount = fQuantity * fCost;
                tblStock.Rows[rows].Cells["TotalCost"].Value = fAmount;
            }
        }
    }
}
