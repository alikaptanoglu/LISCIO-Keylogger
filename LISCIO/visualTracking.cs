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
    public partial class visualTracking : UserControl
    {
        public visualTracking()
        {
            InitializeComponent();
        }

        private void visualSaveBtn_Click(object sender, EventArgs e)
        {
            if (visualCheckBox.Checked == true)
            {
                Transactions.visualTracking = true;

            }
            MessageBox.Show("Settings saved successfully", "Was Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
