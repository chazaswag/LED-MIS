using System;
using System.Windows.Forms;

namespace U14_LEDShed
{
    public partial class Form1 : Form
    {
        Control controlClass;
        public Form1(Control inControl)
        {
            InitializeComponent();
            controlClass = inControl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "login" && txtPassword.Text == "1234")
            {
                lblWarning.Visible = false;
                WelcomeScreen mm = new WelcomeScreen(controlClass);
                this.Hide();
                mm.ShowDialog();
                this.Close();
            }
            else
            {
                lblWarning.Visible = true;
            }
        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
