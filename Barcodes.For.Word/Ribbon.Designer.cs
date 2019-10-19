namespace Barcodes.For.Word
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen, andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group = this.Factory.CreateRibbonGroup();
            this.txtBarcode = this.Factory.CreateRibbonEditBox();
            this.ddSymbology = this.Factory.CreateRibbonDropDown();
            this.cbShowText = this.Factory.CreateRibbonCheckBox();
            this.btnInsert = this.Factory.CreateRibbonButton();
            this.btnCopyBarcode = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group
            // 
            this.group.Items.Add(this.txtBarcode);
            this.group.Items.Add(this.ddSymbology);
            this.group.Items.Add(this.cbShowText);
            this.group.Items.Add(this.btnInsert);
            this.group.Items.Add(this.btnCopyBarcode);
            this.group.Label = "Barcodes.For.Word";
            this.group.Name = "group";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Label = " Data";
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Text = null;
            // 
            // ddSymbology
            // 
            this.ddSymbology.Label = "Symb.";
            this.ddSymbology.Name = "ddSymbology";
            // 
            // cbShowText
            // 
            this.cbShowText.Checked = true;
            this.cbShowText.Label = "Show Text";
            this.cbShowText.Name = "cbShowText";
            // 
            // btnInsert
            // 
            this.btnInsert.Label = "Insert Barcode";
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsertBarcode_Click);
            // 
            // btnCopyBarcode
            // 
            this.btnCopyBarcode.Label = "Copy to Clipboard";
            this.btnCopyBarcode.Name = "btnCopyBarcode";
            this.btnCopyBarcode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCopyBarcode_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsert;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtBarcode;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown ddSymbology;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbShowText;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCopyBarcode;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
