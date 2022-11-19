using CreateCode.CodeOperation;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreateCode
{
    public partial class GeneratedCodePage : Form
    {
        public GeneratedCodePage()
        {
            InitializeComponent();
            FillList();
        }
        /// <summary>
        /// Fill to list from genereted code
        /// </summary>
        private void FillList()
        {
            foreach (var item in CodeManager.Codemanager.GeneratedCodeList)
            {
                lstCode.Items.Add(item);
            }
        }
    }
}
