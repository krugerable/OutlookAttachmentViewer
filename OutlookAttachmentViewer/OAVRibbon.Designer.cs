namespace OutlookAttachmentViewer
{
    partial class OAVRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OAVRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOAV = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ddProfile = this.Factory.CreateRibbonDropDown();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.lblSelectedFolder = this.Factory.CreateRibbonLabel();
            this.chkRecursive = this.Factory.CreateRibbonCheckBox();
            this.btnSelectFolder = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btnLoadProfile = this.Factory.CreateRibbonButton();
            this.btnSaveAttachments = this.Factory.CreateRibbonButton();
            this.tabOAV.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOAV
            // 
            this.tabOAV.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabOAV.Groups.Add(this.group1);
            this.tabOAV.Groups.Add(this.group2);
            this.tabOAV.Groups.Add(this.group3);
            this.tabOAV.Label = "Outlook Attachment Viewer";
            this.tabOAV.Name = "tabOAV";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ddProfile);
            this.group1.Items.Add(this.btnLoadProfile);
            this.group1.Label = "Outlook Profiles";
            this.group1.Name = "group1";
            // 
            // ddProfile
            // 
            this.ddProfile.Label = "Select Outlook Profile";
            this.ddProfile.Name = "ddProfile";
            this.ddProfile.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ddProfile_SelectionChanged);
            // 
            // group2
            // 
            this.group2.Items.Add(this.lblSelectedFolder);
            this.group2.Items.Add(this.chkRecursive);
            this.group2.Items.Add(this.btnSelectFolder);
            this.group2.Label = "Select Outlook Folder";
            this.group2.Name = "group2";
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.Label = "Selected Outlook Folder";
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            // 
            // chkRecursive
            // 
            this.chkRecursive.Label = "Scan Subfolders";
            this.chkRecursive.Name = "chkRecursive";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSelectFolder.Label = "Select Outlook Folder";
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.ShowImage = true;
            // 
            // group3
            // 
            this.group3.Items.Add(this.btnSaveAttachments);
            this.group3.Label = "Attachment Operations";
            this.group3.Name = "group3";
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLoadProfile.Label = "Load Outlook Profile";
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.ShowImage = true;
            // 
            // btnSaveAttachments
            // 
            this.btnSaveAttachments.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSaveAttachments.Label = "Save Attachments";
            this.btnSaveAttachments.Name = "btnSaveAttachments";
            this.btnSaveAttachments.ShowImage = true;
            // 
            // OAVRibbon
            // 
            this.Name = "OAVRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tabOAV);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OAVRibbon_Load);
            this.tabOAV.ResumeLayout(false);
            this.tabOAV.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabOAV;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown ddProfile;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lblSelectedFolder;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox chkRecursive;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSelectFolder;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLoadProfile;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSaveAttachments;
    }

    partial class ThisRibbonCollection
    {
        internal OAVRibbon OAVRibbon
        {
            get { return this.GetRibbon<OAVRibbon>(); }
        }
    }
}
