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

        public Control info = MainWindow.mainWindow;

        //Constructor
        public AhuEquipmentSetup()
        {
            InitializeComponent();

            foreach (var item in info.Controls)
            {
                Console.WriteLine(item);
            }

            //Low Limit Lengths Combo Box
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

            //Supply Fan Combo Boxes
            //number of Fans. Accounts for a fan wall.
            List<string> fanCounts = new List<string>()
            {
                "1",
                "2",
                "4",
                "8"
            };

            foreach(string fanCount in fanCounts)
            {
                fanCountCb.Items.Add(fanCount);
            }

            //fan volume
            List<string> fanVolumes = new List<string>()
            {
                "Constant Volume",
                "Variable Air Volume"
            };
            foreach (string fanVolume in fanVolumes)
            {
                fanVolCb.Items.Add(fanVolume);
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

        private void fanVolCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fanStatusCb.Items.Clear();
            fanVolSourceCb.Items.Clear();
            bacnetCommCb.Items.Clear();

            if (fanVolCb.Text == "Constant Volume")
            {
                fanStatusCb.Enabled = true;
                fanVolSourceCb.Enabled = false;
                bacnetCommCb.Enabled = false;

                fanStatusCb.Text = "";
                fanVolSourceCb.Text = "";
                bacnetCommCb.Text = "";

                //fan status
                List<string> fanStatuses = new List<string>()
                {
                    "Binary",
                    "Analog"
                };

                foreach (string fanStatus in fanStatuses)
                {
                    fanStatusCb.Items.Add(fanStatus);
                }
            }

            if (fanVolCb.Text == "Variable Air Volume")
            {
                fanStatusCb.Enabled = true;
                fanVolSourceCb.Enabled = true;
                bacnetCommCb.Enabled = true;

                fanStatusCb.Text = "";

                //fan status
                List<string> fanStatuses = new List<string>()
                {
                    "Binary",
                    "Analog",
                    "VFD", 
                    "ECM"
                };

                foreach (string fanStatus in fanStatuses)
                {
                    fanStatusCb.Items.Add(fanStatus);
                }

                //fan volume source
                List<string> volumeSources = new List<string>()
                {
                    "VFD",
                    "ECM",
                    "Turning Vanes"
                };

                foreach(string volumeSource in volumeSources)
                {
                    fanVolSourceCb.Items.Add(volumeSource);
                }

                //bacnet communication
                List<string> bacnetCommOptions = new List<string>()
                {
                    "Yes",
                    "No"
                };

                foreach (string bacnetOption in bacnetCommOptions)
                {
                    bacnetCommCb.Items.Add(bacnetOption);
                }
            }
        }
    }
}
