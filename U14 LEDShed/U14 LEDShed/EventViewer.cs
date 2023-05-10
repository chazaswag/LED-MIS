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
        public EventViewer(Control inControl)
        {
            InitializeComponent();
            controlClass = inControl;

            foreach (Event e in controlClass.eventsList)
            {
                lstEvents.Items.Add(e.sEventName);
            }
        }
    }
}
