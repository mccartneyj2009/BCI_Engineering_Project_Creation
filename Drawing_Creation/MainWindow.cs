using System;
using Visio = Microsoft.Office.Interop.Visio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drawing_Creation;

namespace Engineering_Project_Creation
{
    public partial class MainWindow : Form
    {

        public static MainWindow mainWindow;
        public string customer { get; set; }
        public string projName { get; set; }
        public string projNumber { get; set; }
        public string sysName { get; set; }
        public string sysType { get; set; }
        public string rev { get; set; }
        public string revNum { get; set; }
        public string drawingNum { get; set; }
        public string designer { get; set; }
        public string installer { get; set; }


        //Constructor
        public MainWindow()
        {
            InitializeComponent();

            // revision type
            List<string> revTypes = new List<string>()
            {
                "Submittal",
                "Revision",
                "As-built"
            };

            foreach (var rev in revTypes)
            {
                revCb.Items.Add(rev);
            }

            // system type
            List<string> systemTypes = new List<string>()
            {
                "AHU",
                "Hot Water System",
                "Chilled Water System"
            };

            foreach (var system in systemTypes)
            {
                sysTypeCb.Items.Add(system);
            }

            // revision numbers added to dropdown
            for (int i = 0; i < 5; i++)
            {
                revNumCb.Items.Add($"REV{i}");
            }

            // drawing numbers added to dropdown
            for (int i = 0; i < 21; i++)
            {
                if (i < 10)
                {
                    drawingNumCb.Items.Add($"0{i}");
                }
                else
                {
                    drawingNumCb.Items.Add(i);
                }
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            customer = custTb.Text;
            projName = projNameTb.Text;
            projNumber = projNumTb.Text;
            sysName = sysNameTb.Text;
            sysType = sysTypeCb.Text;
            rev = revCb.Text;
            revNum = revNumCb.Text;
            drawingNum = drawingNumCb.Text;
            designer = desInitTb.Text;
            installer = instInitTb.Text;
            mainWindow = this;

            

            var equipSetupForm = new AhuEquipmentSetup();
            equipSetupForm.ShowDialog();

            
            //Below is some code for how to start the Visio stuff.
            //string path = "C:\\Users\\James McCartney\\source\\repos\\Engineering_Project_Creation\\Drawing_Creation\\assests\\visio_files\\template.vsdx";
            //Visio.Application vs = new Visio.Application();
            //var drawing = vs.Documents.Add(path);
            // Console.WriteLine(drawing.Name);
            //this.customer = custTb.Text;
            //string cust = this.customer;

        }

        private void revCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (revCb.Text != "Revision")
            {
                revNumCb.Enabled = false;
            }

            if (revCb.Text == "Revision")
            {
                revNumCb.Enabled = true;
            }
        }
    }
}
