using CreateCode.CodeOperation;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreateCode
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                CodeManager.Codemanager.GenerateCode();
                
                lblGenerateResult.ForeColor=Color.Green;
                lblGenerateResult.Text = "Codes Genereted";
                btnCodeList.Visible = true;

            }
            catch (Exception ex)
            {
                lblGenerateResult.Text = "During of Generate Codes has been fault:\n" + ex.Message;
                lblGenerateResult.ForeColor=Color.Red;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtEntryCode.Text.ToUpper();
                if (code != null || code != "" || code.Count()==8)
                {
                    if (CodeManager.Codemanager.CheckCode(code))
                    {
                        lblCheckResult.Text = "Entered Code Aviable";
                        lblCheckResult.ForeColor = Color.Green;
                    }
                    else
                    {                        
                        lblCheckResult.Text = "The Entered Code doesn't include \n in the Campaign";
                        lblCheckResult.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblCheckResult.Text = "Entered Code is Fault";
                    lblCheckResult.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                lblCheckResult.Text="During of Code Check has been fault:\n" + ex.Message;
                lblCheckResult.ForeColor = Color.Red;
            }
        }

        private void btnCodeList_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnGnr_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtCofC.Text, out int d))
            {
                CodeManager.Codemanager.GenerateCode(d);
            }
            else
            {
                lblGenerateResult.Text = "Please entry correct number ";
                lblGenerateResult.ForeColor = Color.Red;
            }
        }
    }
}
