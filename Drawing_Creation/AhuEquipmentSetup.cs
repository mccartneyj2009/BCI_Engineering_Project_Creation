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
        // Fields
        public Control info = MainWindow.mainWindow;
        private List<string> lltLengths = new List<string>()
            {
                "6'",
                "10'",
                "20'"
            };
        private List<string> constFanStatuses = new List<string>()
                {
                    "Switch",
                    "Analog"
                };
        private List<string> varFanStatuses = new List<string>()
                {
                    "VFD",
                    "ECM"
                };
        private List<string> fanVolumes = new List<string>()
            {
                "Constant Volume",
                "Variable Air Volume"
            };
        private List<string> volumeSources = new List<string>()
                {
                    "VFD",
                    "ECM",
                    "Turning Vanes"
                };
        private List<string> bacnetCommOptions = new List<string>()
                {
                    "Yes",
                    "No"
                };

        //Constructor
        public AhuEquipmentSetup()
        {
            InitializeComponent();

            //Low Limit Lengths Combo Box
            foreach (string length in lltLengths)
            {
                lltLengthsCb.Items.Add(length);
            }

            //Supply Fan Combo Boxes
            //number of Fans. Accounts for a fan wall.
            List<string> sfanCounts = new List<string>()
            {
                "1",
                "2",
                "4",
                "8"
            };

            foreach(string fanCount in sfanCounts)
            {
                sfanCountCb.Items.Add(fanCount);
            }

            sfanCountCb.SelectedIndex = 0;

            //fan volume
            foreach (string sfanVolume in fanVolumes)
            {
                sfanVolCb.Items.Add(sfanVolume);
            }

            sfanVolCb.SelectedIndex = 0;
            sfanStatusCb.SelectedIndex = 0;


            //Return Fan Combo Boxes
            //number of Fans. Accounts for a fan wall.
            List<string> rfanCounts = new List<string>()
            {
                "0",
                "1",
                "2",
                "4",
                "8"
            };

            foreach (string fanCount in rfanCounts)
            {
                rfanCountCb.Items.Add(fanCount);
            }

            rfanCountCb.SelectedIndex = 0;

            //fan volume
            foreach (string rfanVolume in fanVolumes)
                {
                    rfanVolCb.Items.Add(rfanVolume);
                }
                        
        }

        //Class Methods
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lltCheckBox_Clicked(object sender, EventArgs e)
        {
            lltLengthsCb.Enabled = lltCheckBox.Checked;
            lltManResetRadioBtn.Enabled = lltCheckBox.Checked;
            lltAutoResetRadioBtn.Enabled = lltCheckBox.Checked;
        }
        private void sfanVolCb_TextChanged(object sender, EventArgs e)
        {
            sfanStatusCb.Items.Clear();
            sfanVolSourceCb.Items.Clear();
            sfBacnetCommCb.Items.Clear();

            if (sfanVolCb.Text == "")
            {
                sfanStatusCb.Enabled = false;
                sfanVolSourceCb.Enabled = false;
                sfBacnetCommCb.Enabled = false;
                
                sfanStatusCb.Text = "";
                sfanVolSourceCb.Text = "";
                sfBacnetCommCb.Text = "";
            }

            if (sfanVolCb.Text == "Constant Volume")
            {
                sfanStatusCb.Enabled = true;
                sfanVolSourceCb.Enabled = false;
                sfBacnetCommCb.Enabled = false;

                sfanVolSourceCb.Text = "";
                sfBacnetCommCb.Text = "";

                //fan status
                foreach (string sfanStatus in constFanStatuses)
                {
                    sfanStatusCb.Items.Add(sfanStatus);
                }

                sfanStatusCb.SelectedIndex = 0;
            }

            if (sfanVolCb.Text == "Variable Air Volume")
            {
                sfanStatusCb.Enabled = true;
                sfanVolSourceCb.Enabled = true;
                sfBacnetCommCb.Enabled = true;

                //fan status
                foreach (string fanStatus in varFanStatuses)
                {
                    sfanStatusCb.Items.Add(fanStatus);
                }
                sfanStatusCb.SelectedIndex = 0;

                //fan volume source
                foreach (string volumeSource in volumeSources)
                {
                    sfanVolSourceCb.Items.Add(volumeSource);
                }
                sfanVolSourceCb.SelectedIndex = 0;


                //bacnet communication
                foreach (string bacnetOption in bacnetCommOptions)
                {
                    sfBacnetCommCb.Items.Add(bacnetOption);
                }
                sfBacnetCommCb.SelectedIndex = 0;
            }
        }

        private void rfanCountCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfFans = Convert.ToInt32(rfanCountCb.Text);

            if (numOfFans > 0)
            {
                rfanVolCb.Enabled = true;
                rfanVolCb.SelectedIndex = 0;
                rfanStatusCb.Enabled = true;
                rfanStatusCb.SelectedIndex = 0;
            }

            if (numOfFans < 1)
            {
                rfanVolCb.Enabled = false;
                rfanStatusCb.Enabled = false;
            }
        }
        private void rfanVolCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            rfanStatusCb.Items.Clear();
            rfanVolSourceCb.Items.Clear();
            rfBacnetCommCb.Items.Clear();

            if (rfanVolCb.Text == "Constant Volume")
            {
                rfanStatusCb.Enabled = true;
                rfanVolSourceCb.Enabled = false;
                rfBacnetCommCb.Enabled = false;

                rfanStatusCb.Text = "";
                rfanVolSourceCb.Text = "";
                rfBacnetCommCb.Text = "";

                //fan status
                foreach (string rfanStatus in constFanStatuses)
                {
                    rfanStatusCb.Items.Add(rfanStatus);
                }
            }

            if (rfanVolCb.Text == "Variable Air Volume")
            {
                rfanStatusCb.Enabled = true;
                rfanVolSourceCb.Enabled = true;
                rfBacnetCommCb.Enabled = true;

                rfanStatusCb.Text = "";

                //fan status
                foreach (string fanStatus in varFanStatuses)
                {
                    rfanStatusCb.Items.Add(fanStatus);
                }

                //fan volume source
                foreach (string volumeSource in volumeSources)
                {
                    rfanVolSourceCb.Items.Add(volumeSource);
                }

                //bacnet communication
                foreach (string bacnetOption in bacnetCommOptions)
                {
                    rfBacnetCommCb.Items.Add(bacnetOption);
                }
            }

        }
    }
}
