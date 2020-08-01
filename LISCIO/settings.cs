using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISCIO
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void _saveSettingsBtn_Click(object sender, EventArgs e)
        {
            if (startupCB.Checked == true)
            {
                Transactions.startUp = startupTxt.Text;
            }
            if (errCB.Checked== true)
            {
                Transactions.errorMessage = errTxt.Text;
            }
            MessageBox.Show("Settings saved successfully", "Was Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
