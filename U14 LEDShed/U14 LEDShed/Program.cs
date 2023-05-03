using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U14_LEDShed
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Control control = new Control();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(control));
        }
    }
}
