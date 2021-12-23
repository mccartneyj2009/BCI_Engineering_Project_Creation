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
                    "ECM",
                    "Switch"
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
        private List<string> preheatTypes = new List<string>()
        {
            "Hydronic (Glycol)",
            "Heat Wheel",
            "Electric"
        };
        private List<string> heatTypes = new List<string>()
        {
            "Hydronic",
            "Gas Heat",
            "Electric",
            "Steam"
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

            //Relief/Exhaust Fan Combo Boxes
            //number of Fans. Accounts for a fan wall.
            List<string> rlfExhFanCounts = new List<string>()
            {
                "0",
                "1",
                "2",
                "4",
                "8"
            };

            foreach (string fanCount in rlfExhFanCounts)
            {
                rlfExhFanCountCb.Items.Add(fanCount);
            }

            rlfExhFanCountCb.SelectedIndex = 0;

            //fan volume
            foreach (string rlfExhFanVolume in fanVolumes)
            {
                rlfExhFanVolCb.Items.Add(rlfExhFanVolume);
            }

            //Heating Types Combo Box
            foreach (string heatType in heatTypes)
            {
                heatTypeCb.Items.Add(heatType);
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
        private void rfanCountCb_TextChanged(object sender, EventArgs e)
        {

            if (rfanCountCb.Text == "0")
            {
                rfanVolCb.Enabled = false;
                rfanVolSourceCb.Enabled=false;
                rfanStatusCb.Enabled = false;
                rfBacnetCommCb.Enabled=false;

                rfanVolCb.Text = "";
                rfanVolSourceCb.Text = "";
                rfanStatusCb.Text = "";
                rfBacnetCommCb.Text = "";
            }

            if (rfanCountCb.Text != "0")
            {
                rfanVolCb.Enabled = true;
            }
        }
        private void rfanVolCb_TextChanged(object sender, EventArgs e)
        {
            rfanVolSourceCb.Items.Clear();
            rfanStatusCb.Items.Clear();
            rfBacnetCommCb.Items.Clear();

            if (rfanVolCb.Text == "Constant Volume")
            {
                //fan volume source
                rfanVolSourceCb.Enabled = false;
                rfanVolSourceCb.Text = "";

                //fan status
                rfanStatusCb.Enabled = true;
                foreach (string rfanStatus in constFanStatuses)
                {
                    rfanStatusCb.Items.Add(rfanStatus);
                }
                rfanStatusCb.SelectedIndex = 0;

                //bacnet
                rfBacnetCommCb.Enabled = false;
                rfBacnetCommCb.Text = "";
            }

            if (rfanVolCb.Text == "Variable Air Volume")
            {
                //fan volume source
                rfanVolSourceCb.Enabled = true;
                foreach (string volumeSource in volumeSources)
                {
                    rfanVolSourceCb.Items.Add(volumeSource);
                }
                rfanVolSourceCb.SelectedIndex = 0;

                //fan status
                rfanStatusCb.Enabled = true;
                foreach (string fanStatus in varFanStatuses)
                {
                    rfanStatusCb.Items.Add(fanStatus);
                }
                rfanStatusCb.SelectedIndex = 0;

                //bacnet communication
                rfBacnetCommCb.Enabled = true;
                foreach (string bacnetOption in bacnetCommOptions)
                {
                    rfBacnetCommCb.Items.Add(bacnetOption);
                }
                rfBacnetCommCb.SelectedIndex = 0;
            }
        }
        private void rlfExhFanCountCb_TextChanged(object sender, EventArgs e)
        {

            if (rlfExhFanCountCb.Text == "0")
            {
                rlfExhFanVolCb.Enabled = false;
                rlfExhFanVolSourceCb.Enabled = false;
                rlfExhFanStatusCb.Enabled = false;
                rlfExhBacnetCommCb.Enabled = false;

                rlfExhFanVolCb.Text = "";
                rlfExhFanVolSourceCb.Text = "";
                rlfExhFanStatusCb.Text = "";
                rlfExhBacnetCommCb.Text = "";
            }

            if (rlfExhFanCountCb.Text != "0")
            {
                rlfExhFanVolCb.Enabled = true;
            }
        }
        private void rlfExhFanVolCb_TextChanged(object sender, EventArgs e)
        {
            rlfExhFanVolSourceCb.Items.Clear();
            rlfExhFanStatusCb.Items.Clear();
            rlfExhBacnetCommCb.Items.Clear();

            if (rlfExhFanVolCb.Text == "Constant Volume")
            {
                //fan volume source
                rlfExhFanVolSourceCb.Enabled = false;
                rlfExhFanVolSourceCb.Text = "";

                //fan status
                rlfExhFanStatusCb.Enabled = true;
                foreach (string rlfExhFanStatus in constFanStatuses)
                {
                    rlfExhFanStatusCb.Items.Add(rlfExhFanStatus);
                }
                rlfExhFanStatusCb.SelectedIndex = 0;

                //bacnet
                rlfExhBacnetCommCb.Enabled = false;
                rlfExhBacnetCommCb.Text = "";
            }

            if (rlfExhFanVolCb.Text == "Variable Air Volume")
            {
                //fan volume source
                rlfExhFanVolSourceCb.Enabled = true;
                foreach (string volumeSource in volumeSources)
                {
                    rlfExhFanVolSourceCb.Items.Add(volumeSource);
                }
                rlfExhFanVolSourceCb.SelectedIndex = 0;

                //fan status
                rlfExhFanStatusCb.Enabled = true;
                foreach (string fanStatus in varFanStatuses)
                {
                    rlfExhFanStatusCb.Items.Add(fanStatus);
                }
                rlfExhFanStatusCb.SelectedIndex = 0;

                //bacnet communication
                rlfExhBacnetCommCb.Enabled = true;
                foreach (string bacnetOption in bacnetCommOptions)
                {
                    rlfExhBacnetCommCb.Items.Add(bacnetOption);
                }
                rlfExhBacnetCommCb.SelectedIndex = 0;
            }
        }
        private void preheatAvailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (preheatAvailCheckBox.Checked)
            {
                preheatTypeCb.Enabled = true;
                foreach(string preheatType in preheatTypes)
                {
                    preheatTypeCb.Items.Add(preheatType);
                }
            }

            if (!preheatAvailCheckBox.Checked)
            {
                preheatTypeCb.Enabled = false;
                preheatTypeCb.Text = "";
                preheatTypeCb.Items.Clear();
            }
        }
        private void preheatTypeCb_TextChanged(object sender, EventArgs e)
        {
            preheatTypeSelectedDetailCb.Items.Clear();

            if (preheatTypeCb.Text == "")
            {
                preheatTypeSelectedLbl.Text = ":";
                preheatTypeSelectedLbl.Visible = false;
                preheatTypeSelectedDetailCb.Enabled = false;
                preheatTypeSelectedDetailCb.Visible = false;
            }

            if (preheatTypeCb.Text == "Hydronic (Glycol)")
            {
                preheatTypeSelectedLbl.Text = "Valve Type:";
                preheatTypeSelectedLbl.Visible = true;
                preheatTypeSelectedDetailCb.Enabled = true;
                preheatTypeSelectedDetailCb.Visible = true;
                preheatTypeSelectedDetailCb.Text = "";
                preheatTypeSelectedDetailCb.Items.Add("Analog");
                preheatTypeSelectedDetailCb.Items.Add("Floating");
                preheatTypeSelectedDetailCb.Items.Add("No valve. Pump Only.");
            }

            if (preheatTypeCb.Text == "Heat Wheel")
            {
                preheatTypeSelectedLbl.Text = "Motor:";
                preheatTypeSelectedLbl.Visible = true;
                preheatTypeSelectedDetailCb.Enabled = true;
                preheatTypeSelectedDetailCb.Visible = true;
                preheatTypeSelectedDetailCb.Text = "";
                preheatTypeSelectedDetailCb.Items.Add("Constant");
                preheatTypeSelectedDetailCb.Items.Add("VFD");
            }

            if (preheatTypeCb.Text == "Electric")
            {
                preheatTypeSelectedLbl.Text = "Stages:";
                preheatTypeSelectedLbl.Visible = true;
                preheatTypeSelectedDetailCb.Enabled = true;
                preheatTypeSelectedDetailCb.Visible = true;
                preheatTypeSelectedDetailCb.Text = "";
                for (int i = 1; i < 5; i++)
                {
                    preheatTypeSelectedDetailCb.Items.Add(i);
                }
            }
        }
    }
}
