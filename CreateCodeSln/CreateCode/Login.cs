using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreateCode
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.txtPass, "KAIZEN");
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text.ToUpper();

            if (pass.Equals("KAIZEN"))
            {
                GeneratedCodePage generatedCodePage = new GeneratedCodePage();
                generatedCodePage.Show();
                this.Close();
            }
            else
            {
                lblLoginResult.Text = "Password is invalid";
                lblLoginResult.ForeColor = Color.Red;
            }
        }
    }
}
