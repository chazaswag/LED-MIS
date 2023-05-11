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
    public partial class FreelancerForm : Form
    {
        Control controlclass;
        public FreelancerForm(Control inControl)
        {
            controlclass = inControl;
            InitializeComponent();
        }
    }
}
