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
        }

        private void EventViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
