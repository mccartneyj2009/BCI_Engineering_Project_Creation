using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engineering_Project_Creation;

namespace Drawing_Creation
{
    public partial class AhuEquipmentSetup : Form
    {
        public AhuEquipmentSetup()
        {
            InitializeComponent();

            List<string> safeties = new List<string>()
            {
                "Low Limit Thermostat",
                "Supply Static Pressure High Limit",
                "Supply Static Pressure Low Limit",
                "Return Static Pressure High Limit",
                "Return Static Pressure Low Limit",
                "Supply Smoke Detector",
                "Return Smoke Detector"
            };

            List<string> lltLengths = new List<string>()
            {
                "6'",
                "10'",
                "20'"
            };

            foreach (string length in lltLengths)
            {
                lltLengthsCb.Items.Add(length);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lltCheckBox_Clicked(object sender, EventArgs e)
        {
            lltLengthsCb.Enabled = lltCheckBox.Checked;
            lltManResetRadioBtn.Enabled = lltCheckBox.Checked;
            lltAutoResetRadioBtn.Enabled = lltCheckBox.Checked;
        }
    }
}
