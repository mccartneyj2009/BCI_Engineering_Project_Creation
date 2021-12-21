namespace Drawing_Creation
{
    partial class AhuEquipmentSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ahuTabControl = new System.Windows.Forms.TabControl();
            this.safetiesTab = new System.Windows.Forms.TabPage();
            this.supplySmokeCheckBox = new System.Windows.Forms.CheckBox();
            this.returnSmokeCheckBox = new System.Windows.Forms.CheckBox();
            this.returnSPLLCheckBox = new System.Windows.Forms.CheckBox();
            this.returnSPHLCheckBox = new System.Windows.Forms.CheckBox();
            this.supplySPLLCheckBox = new System.Windows.Forms.CheckBox();
            this.supplySPHLCheckBox = new System.Windows.Forms.CheckBox();
            this.lltPanel = new System.Windows.Forms.Panel();
            this.lltCheckBox = new System.Windows.Forms.CheckBox();
            this.lltLengthsCb = new System.Windows.Forms.ComboBox();
            this.lltLengthLbl = new System.Windows.Forms.Label();
            this.fansTab = new System.Windows.Forms.TabPage();
            this.heatingTab = new System.Windows.Forms.TabPage();
            this.coolingTab = new System.Windows.Forms.TabPage();
            this.dampersTab = new System.Windows.Forms.TabPage();
            this.serviceTypeTab = new System.Windows.Forms.TabPage();
            this.afmsTab = new System.Windows.Forms.TabPage();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.alarmingTab = new System.Windows.Forms.TabPage();
            this.controllerTab = new System.Windows.Forms.TabPage();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lltAutoResetRadioBtn = new System.Windows.Forms.RadioButton();
            this.lltResetLbl = new System.Windows.Forms.Label();
            this.lltManResetRadioBtn = new System.Windows.Forms.RadioButton();
            this.ahuTabControl.SuspendLayout();
            this.safetiesTab.SuspendLayout();
            this.lltPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ahuTabControl
            // 
            this.ahuTabControl.Controls.Add(this.safetiesTab);
            this.ahuTabControl.Controls.Add(this.fansTab);
            this.ahuTabControl.Controls.Add(this.heatingTab);
            this.ahuTabControl.Controls.Add(this.coolingTab);
            this.ahuTabControl.Controls.Add(this.dampersTab);
            this.ahuTabControl.Controls.Add(this.serviceTypeTab);
            this.ahuTabControl.Controls.Add(this.afmsTab);
            this.ahuTabControl.Controls.Add(this.miscTab);
            this.ahuTabControl.Controls.Add(this.alarmingTab);
            this.ahuTabControl.Controls.Add(this.controllerTab);
            this.ahuTabControl.Location = new System.Drawing.Point(12, 12);
            this.ahuTabControl.Name = "ahuTabControl";
            this.ahuTabControl.SelectedIndex = 0;
            this.ahuTabControl.Size = new System.Drawing.Size(644, 383);
            this.ahuTabControl.TabIndex = 0;
            // 
            // safetiesTab
            // 
            this.safetiesTab.Controls.Add(this.supplySmokeCheckBox);
            this.safetiesTab.Controls.Add(this.returnSmokeCheckBox);
            this.safetiesTab.Controls.Add(this.returnSPLLCheckBox);
            this.safetiesTab.Controls.Add(this.returnSPHLCheckBox);
            this.safetiesTab.Controls.Add(this.supplySPLLCheckBox);
            this.safetiesTab.Controls.Add(this.supplySPHLCheckBox);
            this.safetiesTab.Controls.Add(this.lltPanel);
            this.safetiesTab.Location = new System.Drawing.Point(4, 22);
            this.safetiesTab.Name = "safetiesTab";
            this.safetiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.safetiesTab.Size = new System.Drawing.Size(636, 357);
            this.safetiesTab.TabIndex = 0;
            this.safetiesTab.Text = "Safeties";
            this.safetiesTab.UseVisualStyleBackColor = true;
            // 
            // supplySmokeCheckBox
            // 
            this.supplySmokeCheckBox.AutoSize = true;
            this.supplySmokeCheckBox.Location = new System.Drawing.Point(10, 279);
            this.supplySmokeCheckBox.Name = "supplySmokeCheckBox";
            this.supplySmokeCheckBox.Size = new System.Drawing.Size(138, 17);
            this.supplySmokeCheckBox.TabIndex = 9;
            this.supplySmokeCheckBox.Text = "Supply Smoke Detector";
            this.supplySmokeCheckBox.UseVisualStyleBackColor = true;
            // 
            // returnSmokeCheckBox
            // 
            this.returnSmokeCheckBox.AutoSize = true;
            this.returnSmokeCheckBox.Location = new System.Drawing.Point(10, 332);
            this.returnSmokeCheckBox.Name = "returnSmokeCheckBox";
            this.returnSmokeCheckBox.Size = new System.Drawing.Size(138, 17);
            this.returnSmokeCheckBox.TabIndex = 8;
            this.returnSmokeCheckBox.Text = "Return Smoke Detector";
            this.returnSmokeCheckBox.UseVisualStyleBackColor = true;
            // 
            // returnSPLLCheckBox
            // 
            this.returnSPLLCheckBox.AutoSize = true;
            this.returnSPLLCheckBox.Location = new System.Drawing.Point(10, 226);
            this.returnSPLLCheckBox.Name = "returnSPLLCheckBox";
            this.returnSPLLCheckBox.Size = new System.Drawing.Size(179, 17);
            this.returnSPLLCheckBox.TabIndex = 7;
            this.returnSPLLCheckBox.Text = "Return Static Pressure Low Limit";
            this.returnSPLLCheckBox.UseVisualStyleBackColor = true;
            // 
            // returnSPHLCheckBox
            // 
            this.returnSPHLCheckBox.AutoSize = true;
            this.returnSPHLCheckBox.Location = new System.Drawing.Point(10, 173);
            this.returnSPHLCheckBox.Name = "returnSPHLCheckBox";
            this.returnSPHLCheckBox.Size = new System.Drawing.Size(186, 17);
            this.returnSPHLCheckBox.TabIndex = 6;
            this.returnSPHLCheckBox.Text = "Return Static Pressure High Limit\"";
            this.returnSPHLCheckBox.UseVisualStyleBackColor = true;
            // 
            // supplySPLLCheckBox
            // 
            this.supplySPLLCheckBox.AutoSize = true;
            this.supplySPLLCheckBox.Location = new System.Drawing.Point(10, 120);
            this.supplySPLLCheckBox.Name = "supplySPLLCheckBox";
            this.supplySPLLCheckBox.Size = new System.Drawing.Size(179, 17);
            this.supplySPLLCheckBox.TabIndex = 5;
            this.supplySPLLCheckBox.Text = "Supply Static Pressure Low Limit";
            this.supplySPLLCheckBox.UseVisualStyleBackColor = true;
            // 
            // supplySPHLCheckBox
            // 
            this.supplySPHLCheckBox.AutoSize = true;
            this.supplySPHLCheckBox.Location = new System.Drawing.Point(10, 67);
            this.supplySPHLCheckBox.Name = "supplySPHLCheckBox";
            this.supplySPHLCheckBox.Size = new System.Drawing.Size(181, 17);
            this.supplySPHLCheckBox.TabIndex = 4;
            this.supplySPHLCheckBox.Text = "Supply Static Pressure High Limit";
            this.supplySPHLCheckBox.UseVisualStyleBackColor = true;
            // 
            // lltPanel
            // 
            this.lltPanel.Controls.Add(this.lltManResetRadioBtn);
            this.lltPanel.Controls.Add(this.lltResetLbl);
            this.lltPanel.Controls.Add(this.lltAutoResetRadioBtn);
            this.lltPanel.Controls.Add(this.lltCheckBox);
            this.lltPanel.Controls.Add(this.lltLengthsCb);
            this.lltPanel.Controls.Add(this.lltLengthLbl);
            this.lltPanel.Location = new System.Drawing.Point(6, 6);
            this.lltPanel.Name = "lltPanel";
            this.lltPanel.Size = new System.Drawing.Size(624, 25);
            this.lltPanel.TabIndex = 0;
            // 
            // lltCheckBox
            // 
            this.lltCheckBox.AutoSize = true;
            this.lltCheckBox.Location = new System.Drawing.Point(4, 4);
            this.lltCheckBox.Name = "lltCheckBox";
            this.lltCheckBox.Size = new System.Drawing.Size(126, 17);
            this.lltCheckBox.TabIndex = 3;
            this.lltCheckBox.Text = "Low Limit Thermostat";
            this.lltCheckBox.UseVisualStyleBackColor = true;
            this.lltCheckBox.Click += new System.EventHandler(this.lltCheckBox_Clicked);
            // 
            // lltLengthsCb
            // 
            this.lltLengthsCb.Enabled = false;
            this.lltLengthsCb.FormattingEnabled = true;
            this.lltLengthsCb.Location = new System.Drawing.Point(251, 2);
            this.lltLengthsCb.Name = "lltLengthsCb";
            this.lltLengthsCb.Size = new System.Drawing.Size(121, 21);
            this.lltLengthsCb.TabIndex = 2;
            // 
            // lltLengthLbl
            // 
            this.lltLengthLbl.AutoSize = true;
            this.lltLengthLbl.Location = new System.Drawing.Point(202, 6);
            this.lltLengthLbl.Name = "lltLengthLbl";
            this.lltLengthLbl.Size = new System.Drawing.Size(43, 13);
            this.lltLengthLbl.TabIndex = 1;
            this.lltLengthLbl.Text = "Length:";
            // 
            // fansTab
            // 
            this.fansTab.Location = new System.Drawing.Point(4, 22);
            this.fansTab.Name = "fansTab";
            this.fansTab.Padding = new System.Windows.Forms.Padding(3);
            this.fansTab.Size = new System.Drawing.Size(636, 357);
            this.fansTab.TabIndex = 1;
            this.fansTab.Text = "Fans";
            this.fansTab.UseVisualStyleBackColor = true;
            // 
            // heatingTab
            // 
            this.heatingTab.Location = new System.Drawing.Point(4, 22);
            this.heatingTab.Name = "heatingTab";
            this.heatingTab.Padding = new System.Windows.Forms.Padding(3);
            this.heatingTab.Size = new System.Drawing.Size(636, 357);
            this.heatingTab.TabIndex = 2;
            this.heatingTab.Text = "Heating";
            this.heatingTab.UseVisualStyleBackColor = true;
            // 
            // coolingTab
            // 
            this.coolingTab.Location = new System.Drawing.Point(4, 22);
            this.coolingTab.Name = "coolingTab";
            this.coolingTab.Padding = new System.Windows.Forms.Padding(3);
            this.coolingTab.Size = new System.Drawing.Size(636, 357);
            this.coolingTab.TabIndex = 3;
            this.coolingTab.Text = "Cooling";
            this.coolingTab.UseVisualStyleBackColor = true;
            // 
            // dampersTab
            // 
            this.dampersTab.Location = new System.Drawing.Point(4, 22);
            this.dampersTab.Name = "dampersTab";
            this.dampersTab.Padding = new System.Windows.Forms.Padding(3);
            this.dampersTab.Size = new System.Drawing.Size(636, 357);
            this.dampersTab.TabIndex = 4;
            this.dampersTab.Text = "Dampers";
            this.dampersTab.UseVisualStyleBackColor = true;
            // 
            // serviceTypeTab
            // 
            this.serviceTypeTab.Location = new System.Drawing.Point(4, 22);
            this.serviceTypeTab.Name = "serviceTypeTab";
            this.serviceTypeTab.Padding = new System.Windows.Forms.Padding(3);
            this.serviceTypeTab.Size = new System.Drawing.Size(636, 357);
            this.serviceTypeTab.TabIndex = 5;
            this.serviceTypeTab.Text = "Service Type";
            this.serviceTypeTab.UseVisualStyleBackColor = true;
            // 
            // afmsTab
            // 
            this.afmsTab.Location = new System.Drawing.Point(4, 22);
            this.afmsTab.Name = "afmsTab";
            this.afmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.afmsTab.Size = new System.Drawing.Size(636, 357);
            this.afmsTab.TabIndex = 6;
            this.afmsTab.Text = "AFMS";
            this.afmsTab.UseVisualStyleBackColor = true;
            // 
            // miscTab
            // 
            this.miscTab.Location = new System.Drawing.Point(4, 22);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(636, 357);
            this.miscTab.TabIndex = 7;
            this.miscTab.Text = "Miscellaneous";
            this.miscTab.UseVisualStyleBackColor = true;
            // 
            // alarmingTab
            // 
            this.alarmingTab.Location = new System.Drawing.Point(4, 22);
            this.alarmingTab.Name = "alarmingTab";
            this.alarmingTab.Padding = new System.Windows.Forms.Padding(3);
            this.alarmingTab.Size = new System.Drawing.Size(636, 357);
            this.alarmingTab.TabIndex = 8;
            this.alarmingTab.Text = "Alarming";
            this.alarmingTab.UseVisualStyleBackColor = true;
            // 
            // controllerTab
            // 
            this.controllerTab.Location = new System.Drawing.Point(4, 22);
            this.controllerTab.Name = "controllerTab";
            this.controllerTab.Padding = new System.Windows.Forms.Padding(3);
            this.controllerTab.Size = new System.Drawing.Size(636, 357);
            this.controllerTab.TabIndex = 9;
            this.controllerTab.Text = "Controller";
            this.controllerTab.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(93, 415);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 15;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(581, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lltAutoResetRadioBtn
            // 
            this.lltAutoResetRadioBtn.AutoSize = true;
            this.lltAutoResetRadioBtn.Enabled = false;
            this.lltAutoResetRadioBtn.Location = new System.Drawing.Point(549, 3);
            this.lltAutoResetRadioBtn.Name = "lltAutoResetRadioBtn";
            this.lltAutoResetRadioBtn.Size = new System.Drawing.Size(72, 17);
            this.lltAutoResetRadioBtn.TabIndex = 4;
            this.lltAutoResetRadioBtn.TabStop = true;
            this.lltAutoResetRadioBtn.Text = "Automatic";
            this.lltAutoResetRadioBtn.UseVisualStyleBackColor = true;
            // 
            // lltResetLbl
            // 
            this.lltResetLbl.AutoSize = true;
            this.lltResetLbl.Location = new System.Drawing.Point(436, 6);
            this.lltResetLbl.Name = "lltResetLbl";
            this.lltResetLbl.Size = new System.Drawing.Size(41, 13);
            this.lltResetLbl.TabIndex = 5;
            this.lltResetLbl.Text = "Reset: ";
            // 
            // lltManResetRadioBtn
            // 
            this.lltManResetRadioBtn.AutoSize = true;
            this.lltManResetRadioBtn.Enabled = false;
            this.lltManResetRadioBtn.Location = new System.Drawing.Point(483, 3);
            this.lltManResetRadioBtn.Name = "lltManResetRadioBtn";
            this.lltManResetRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.lltManResetRadioBtn.TabIndex = 6;
            this.lltManResetRadioBtn.TabStop = true;
            this.lltManResetRadioBtn.Text = "Manual";
            this.lltManResetRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AhuEquipmentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.ahuTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AhuEquipmentSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AHU Setup";
            this.ahuTabControl.ResumeLayout(false);
            this.safetiesTab.ResumeLayout(false);
            this.safetiesTab.PerformLayout();
            this.lltPanel.ResumeLayout(false);
            this.lltPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ahuTabControl;
        private System.Windows.Forms.TabPage safetiesTab;
        private System.Windows.Forms.TabPage fansTab;
        private System.Windows.Forms.TabPage heatingTab;
        private System.Windows.Forms.TabPage coolingTab;
        private System.Windows.Forms.TabPage dampersTab;
        private System.Windows.Forms.TabPage serviceTypeTab;
        private System.Windows.Forms.TabPage afmsTab;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.TabPage alarmingTab;
        private System.Windows.Forms.TabPage controllerTab;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel lltPanel;
        private System.Windows.Forms.Label lltLengthLbl;
        private System.Windows.Forms.ComboBox lltLengthsCb;
        private System.Windows.Forms.CheckBox lltCheckBox;
        private System.Windows.Forms.CheckBox supplySmokeCheckBox;
        private System.Windows.Forms.CheckBox returnSmokeCheckBox;
        private System.Windows.Forms.CheckBox returnSPLLCheckBox;
        private System.Windows.Forms.CheckBox returnSPHLCheckBox;
        private System.Windows.Forms.CheckBox supplySPLLCheckBox;
        private System.Windows.Forms.CheckBox supplySPHLCheckBox;
        private System.Windows.Forms.RadioButton lltManResetRadioBtn;
        private System.Windows.Forms.Label lltResetLbl;
        private System.Windows.Forms.RadioButton lltAutoResetRadioBtn;
    }
}