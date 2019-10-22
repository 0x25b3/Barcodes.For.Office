namespace Barcodes.For.Excel
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group = this.Factory.CreateRibbonGroup();
            this.btnMain = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();

            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";

            this.group.Items.Add(this.btnMain);
            this.group.Label = "Barcodes.For.Excel";
            this.group.Name = "group";

            this.btnMain.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnMain.Image = Shared.Resources.Header;
            this.btnMain.Label = "Toggle Sidebar";
            this.btnMain.Name = "btnMain";
            this.btnMain.ShowImage = true;
            this.btnMain.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMain_Click);

            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
