﻿
namespace MarkZither.KimaiDotNet.OutlookAddin
{
    partial class CalendarRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CalendarRibbon()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnApiCredentials = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Kimai";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnApiCredentials);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // btnApiCredentials
            // 
            this.btnApiCredentials.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnApiCredentials.Label = "Api Credentials";
            this.btnApiCredentials.Name = "btnApiCredentials";
            this.btnApiCredentials.OfficeImageId = "PivotTableFieldSettings";
            this.btnApiCredentials.ShowImage = true;
            this.btnApiCredentials.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnApiCredentials_Click);
            // 
            // CalendarRibbon
            // 
            this.Name = "CalendarRibbon";
            this.RibbonType = "Microsoft.Outlook.Appointment, Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail" +
    ".Compose, Microsoft.Outlook.Mail.Read, Microsoft.Outlook.MeetingRequest.Read, Mi" +
    "crosoft.Outlook.MeetingRequest.Send";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CalendarRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnApiCredentials;
    }

    partial class ThisRibbonCollection
    {
        internal CalendarRibbon CalendarRibbon
        {
            get { return this.GetRibbon<CalendarRibbon>(); }
        }
    }
}
