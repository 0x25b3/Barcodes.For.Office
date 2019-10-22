namespace Barcodes.For.Shared
{
    partial class Sidebar
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cboSymbology = new System.Windows.Forms.ComboBox();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupDimensions = new System.Windows.Forms.GroupBox();
            this.tableDimensions = new System.Windows.Forms.TableLayoutPanel();
            this.numXDimension = new System.Windows.Forms.NumericUpDown();
            this.lblXDimension = new System.Windows.Forms.Label();
            this.lblDPI = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblTargetWidth = new System.Windows.Forms.Label();
            this.numTargetWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numDPI = new System.Windows.Forms.NumericUpDown();
            this.groupSymbology = new System.Windows.Forms.GroupBox();
            this.tableSymbology = new System.Windows.Forms.TableLayoutPanel();
            this.chkIncludeQuitezone = new System.Windows.Forms.CheckBox();
            this.groupText = new System.Windows.Forms.GroupBox();
            this.tableText = new System.Windows.Forms.TableLayoutPanel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.cboFontFamily = new System.Windows.Forms.ComboBox();
            this.lblFontFamily = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tableData = new System.Windows.Forms.TableLayoutPanel();
            this.chkUseAsText = new System.Windows.Forms.CheckBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.flowCredits = new System.Windows.Forms.FlowLayoutPanel();
            this.linkBarcodeForWord = new System.Windows.Forms.LinkLabel();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.linkBarcoded = new System.Windows.Forms.LinkLabel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tableMain.SuspendLayout();
            this.groupDimensions.SuspendLayout();
            this.tableDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPI)).BeginInit();
            this.groupSymbology.SuspendLayout();
            this.tableSymbology.SuspendLayout();
            this.groupText.SuspendLayout();
            this.tableText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.tableData.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSymbology
            // 
            this.cboSymbology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSymbology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymbology.FormattingEnabled = true;
            this.cboSymbology.Location = new System.Drawing.Point(3, 3);
            this.cboSymbology.Name = "cboSymbology";
            this.cboSymbology.Size = new System.Drawing.Size(182, 21);
            this.cboSymbology.TabIndex = 8;
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.groupDimensions, 0, 5);
            this.tableMain.Controls.Add(this.groupSymbology, 0, 4);
            this.tableMain.Controls.Add(this.groupText, 0, 3);
            this.tableMain.Controls.Add(this.tableData, 0, 2);
            this.tableMain.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableMain.Controls.Add(this.flowCredits, 0, 7);
            this.tableMain.Controls.Add(this.pictureLogo, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 8;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(200, 814);
            this.tableMain.TabIndex = 1;
            // 
            // groupDimensions
            // 
            this.groupDimensions.Controls.Add(this.tableDimensions);
            this.groupDimensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDimensions.Location = new System.Drawing.Point(3, 532);
            this.groupDimensions.Name = "groupDimensions";
            this.groupDimensions.Size = new System.Drawing.Size(194, 202);
            this.groupDimensions.TabIndex = 5;
            this.groupDimensions.TabStop = false;
            this.groupDimensions.Text = "Dimensions";
            // 
            // tableDimensions
            // 
            this.tableDimensions.ColumnCount = 1;
            this.tableDimensions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDimensions.Controls.Add(this.numXDimension, 0, 7);
            this.tableDimensions.Controls.Add(this.lblXDimension, 0, 6);
            this.tableDimensions.Controls.Add(this.lblDPI, 0, 4);
            this.tableDimensions.Controls.Add(this.lblHeight, 0, 2);
            this.tableDimensions.Controls.Add(this.lblTargetWidth, 0, 0);
            this.tableDimensions.Controls.Add(this.numTargetWidth, 0, 1);
            this.tableDimensions.Controls.Add(this.numHeight, 0, 3);
            this.tableDimensions.Controls.Add(this.numDPI, 0, 5);
            this.tableDimensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDimensions.Location = new System.Drawing.Point(3, 16);
            this.tableDimensions.Name = "tableDimensions";
            this.tableDimensions.RowCount = 8;
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDimensions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableDimensions.Size = new System.Drawing.Size(188, 183);
            this.tableDimensions.TabIndex = 0;
            // 
            // numXDimension
            // 
            this.numXDimension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numXDimension.Location = new System.Drawing.Point(3, 161);
            this.numXDimension.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXDimension.Name = "numXDimension";
            this.numXDimension.Size = new System.Drawing.Size(182, 20);
            this.numXDimension.TabIndex = 13;
            this.numXDimension.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblXDimension
            // 
            this.lblXDimension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblXDimension.Location = new System.Drawing.Point(3, 138);
            this.lblXDimension.Name = "lblXDimension";
            this.lblXDimension.Size = new System.Drawing.Size(182, 20);
            this.lblXDimension.TabIndex = 8;
            this.lblXDimension.Text = "X dimension";
            this.lblXDimension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDPI
            // 
            this.lblDPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDPI.Location = new System.Drawing.Point(3, 92);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(182, 20);
            this.lblDPI.TabIndex = 7;
            this.lblDPI.Text = "DPI";
            this.lblDPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeight
            // 
            this.lblHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeight.Location = new System.Drawing.Point(3, 46);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(182, 20);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetWidth
            // 
            this.lblTargetWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTargetWidth.Location = new System.Drawing.Point(3, 0);
            this.lblTargetWidth.Name = "lblTargetWidth";
            this.lblTargetWidth.Size = new System.Drawing.Size(182, 20);
            this.lblTargetWidth.TabIndex = 5;
            this.lblTargetWidth.Text = "TargetWidth (Overwrites X-Dim.)";
            this.lblTargetWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTargetWidth
            // 
            this.numTargetWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTargetWidth.Location = new System.Drawing.Point(3, 23);
            this.numTargetWidth.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numTargetWidth.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numTargetWidth.Name = "numTargetWidth";
            this.numTargetWidth.Size = new System.Drawing.Size(182, 20);
            this.numTargetWidth.TabIndex = 10;
            this.numTargetWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHeight.Location = new System.Drawing.Point(3, 69);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(182, 20);
            this.numHeight.TabIndex = 11;
            this.numHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numDPI
            // 
            this.numDPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDPI.Location = new System.Drawing.Point(3, 115);
            this.numDPI.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDPI.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDPI.Name = "numDPI";
            this.numDPI.Size = new System.Drawing.Size(182, 20);
            this.numDPI.TabIndex = 12;
            this.numDPI.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // groupSymbology
            // 
            this.groupSymbology.Controls.Add(this.tableSymbology);
            this.groupSymbology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSymbology.Location = new System.Drawing.Point(3, 454);
            this.groupSymbology.Name = "groupSymbology";
            this.groupSymbology.Size = new System.Drawing.Size(194, 72);
            this.groupSymbology.TabIndex = 4;
            this.groupSymbology.TabStop = false;
            this.groupSymbology.Text = "Symbology";
            // 
            // tableSymbology
            // 
            this.tableSymbology.ColumnCount = 1;
            this.tableSymbology.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSymbology.Controls.Add(this.chkIncludeQuitezone, 0, 1);
            this.tableSymbology.Controls.Add(this.cboSymbology, 0, 0);
            this.tableSymbology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSymbology.Location = new System.Drawing.Point(3, 16);
            this.tableSymbology.Name = "tableSymbology";
            this.tableSymbology.RowCount = 2;
            this.tableSymbology.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableSymbology.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSymbology.Size = new System.Drawing.Size(188, 53);
            this.tableSymbology.TabIndex = 0;
            // 
            // chkIncludeQuitezone
            // 
            this.chkIncludeQuitezone.AutoSize = true;
            this.chkIncludeQuitezone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIncludeQuitezone.Location = new System.Drawing.Point(3, 29);
            this.chkIncludeQuitezone.Name = "chkIncludeQuitezone";
            this.chkIncludeQuitezone.Size = new System.Drawing.Size(182, 21);
            this.chkIncludeQuitezone.TabIndex = 9;
            this.chkIncludeQuitezone.Text = "Include Quitezone";
            this.chkIncludeQuitezone.UseVisualStyleBackColor = true;
            // 
            // groupText
            // 
            this.groupText.Controls.Add(this.tableText);
            this.groupText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupText.Location = new System.Drawing.Point(3, 262);
            this.groupText.Name = "groupText";
            this.groupText.Size = new System.Drawing.Size(194, 186);
            this.groupText.TabIndex = 3;
            this.groupText.TabStop = false;
            this.groupText.Text = "Text";
            // 
            // tableText
            // 
            this.tableText.ColumnCount = 1;
            this.tableText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableText.Controls.Add(this.txtText, 0, 0);
            this.tableText.Controls.Add(this.numFontSize, 0, 6);
            this.tableText.Controls.Add(this.lblFontSize, 0, 5);
            this.tableText.Controls.Add(this.cboFontFamily, 0, 4);
            this.tableText.Controls.Add(this.lblFontFamily, 0, 3);
            this.tableText.Controls.Add(this.cboPosition, 0, 2);
            this.tableText.Controls.Add(this.lblPosition, 0, 1);
            this.tableText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableText.Location = new System.Drawing.Point(3, 16);
            this.tableText.Name = "tableText";
            this.tableText.RowCount = 7;
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableText.Size = new System.Drawing.Size(188, 167);
            this.tableText.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(3, 3);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(182, 20);
            this.txtText.TabIndex = 4;
            // 
            // numFontSize
            // 
            this.numFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numFontSize.Location = new System.Drawing.Point(3, 141);
            this.numFontSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(182, 20);
            this.numFontSize.TabIndex = 7;
            this.numFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblFontSize
            // 
            this.lblFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFontSize.Location = new System.Drawing.Point(3, 118);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(182, 20);
            this.lblFontSize.TabIndex = 4;
            this.lblFontSize.Text = "Font Size";
            this.lblFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFontFamily
            // 
            this.cboFontFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontFamily.FormattingEnabled = true;
            this.cboFontFamily.Items.AddRange(new object[] {
            "Arial",
            "Arial Black",
            "Calibri",
            "Calibri Light",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Code39AzaleaNarrow1",
            "Code39AzaleaNarrow2",
            "Code39AzaleaNarrow3",
            "Code39AzaleaRegular1",
            "Code39AzaleaRegular2",
            "Code39AzaleaRegular3",
            "Code39AzaleaWide1",
            "Code39AzaleaWide2",
            "Code39AzaleaWide3",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Corbel",
            "Courier New",
            "Dotum",
            "DotumChe",
            "Ebrima",
            "Franklin Gothic Medium",
            "Gabriola",
            "Gadugi",
            "Georgia",
            "Gulim",
            "GulimChe",
            "Impact",
            "Javanese Text",
            "Leelawadee UI",
            "Leelawadee UI Semilight",
            "Lucida Console",
            "Lucida Sans Unicode",
            "Malgun Gothic",
            "Malgun Gothic Semilight",
            "Marlett",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft JhengHei Light",
            "Microsoft JhengHei UI",
            "Microsoft JhengHei UI Light",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft YaHei",
            "Microsoft YaHei Light",
            "Microsoft YaHei UI",
            "Microsoft YaHei UI Light",
            "Microsoft Yi Baiti",
            "MingLiU",
            "MingLiU-ExtB",
            "MingLiU_HKSCS",
            "MingLiU_HKSCS-ExtB",
            "Mongolian Baiti",
            "MS Gothic",
            "MS PGothic",
            "MS UI Gothic",
            "MV Boli",
            "Myanmar Text",
            "Nirmala UI",
            "Nirmala UI Semilight",
            "NSimSun",
            "Palatino Linotype",
            "PMingLiU",
            "PMingLiU-ExtB",
            "Segoe MDL2 Assets",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI",
            "Segoe UI Black",
            "Segoe UI Emoji",
            "Segoe UI Historic",
            "Segoe UI Light",
            "Segoe UI Semibold",
            "Segoe UI Semilight",
            "Segoe UI Symbol",
            "SimSun",
            "SimSun-ExtB",
            "Sitka Banner",
            "Sitka Display",
            "Sitka Heading",
            "Sitka Small",
            "Sitka Subheading",
            "Sitka Text",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Times New Roman",
            "Trebuchet MS",
            "Verdana",
            "Webdings",
            "Wingdings",
            "Yu Gothic",
            "Yu Gothic Light",
            "Yu Gothic Medium",
            "Yu Gothic UI",
            "Yu Gothic UI Light",
            "Yu Gothic UI Semibold",
            "Yu Gothic UI Semilight"});
            this.cboFontFamily.Location = new System.Drawing.Point(3, 95);
            this.cboFontFamily.Name = "cboFontFamily";
            this.cboFontFamily.Size = new System.Drawing.Size(182, 21);
            this.cboFontFamily.TabIndex = 6;
            // 
            // lblFontFamily
            // 
            this.lblFontFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFontFamily.Location = new System.Drawing.Point(3, 72);
            this.lblFontFamily.Name = "lblFontFamily";
            this.lblFontFamily.Size = new System.Drawing.Size(182, 20);
            this.lblFontFamily.TabIndex = 2;
            this.lblFontFamily.Text = "Font Family";
            this.lblFontFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPosition
            // 
            this.cboPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Hidden",
            "Above",
            "Below",
            "Embedded"});
            this.cboPosition.Location = new System.Drawing.Point(3, 49);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(182, 21);
            this.cboPosition.TabIndex = 5;
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(3, 26);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(182, 20);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableData
            // 
            this.tableData.ColumnCount = 1;
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableData.Controls.Add(this.chkUseAsText, 0, 2);
            this.tableData.Controls.Add(this.lblData, 0, 0);
            this.tableData.Controls.Add(this.txtData, 0, 1);
            this.tableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableData.Location = new System.Drawing.Point(6, 185);
            this.tableData.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tableData.Name = "tableData";
            this.tableData.RowCount = 3;
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableData.Size = new System.Drawing.Size(188, 71);
            this.tableData.TabIndex = 6;
            // 
            // chkUseAsText
            // 
            this.chkUseAsText.AutoSize = true;
            this.chkUseAsText.Checked = true;
            this.chkUseAsText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseAsText.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkUseAsText.Location = new System.Drawing.Point(102, 49);
            this.chkUseAsText.Name = "chkUseAsText";
            this.chkUseAsText.Size = new System.Drawing.Size(83, 19);
            this.chkUseAsText.TabIndex = 3;
            this.chkUseAsText.Text = "Use as Text";
            this.chkUseAsText.UseVisualStyleBackColor = true;
            this.chkUseAsText.CheckedChanged += new System.EventHandler(this.chkUseAsText_CheckedChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblData.Location = new System.Drawing.Point(3, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(182, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(3, 23);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(182, 20);
            this.txtData.TabIndex = 2;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnInsert, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCopyToClipboard, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(194, 72);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.Location = new System.Drawing.Point(3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(188, 30);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(3, 39);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(188, 30);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // flowCredits
            // 
            this.flowCredits.Controls.Add(this.linkBarcodeForWord);
            this.flowCredits.Controls.Add(this.lblPoweredBy);
            this.flowCredits.Controls.Add(this.linkBarcoded);
            this.flowCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCredits.Location = new System.Drawing.Point(3, 797);
            this.flowCredits.Name = "flowCredits";
            this.flowCredits.Size = new System.Drawing.Size(194, 14);
            this.flowCredits.TabIndex = 9;
            // 
            // linkBarcodeForWord
            // 
            this.linkBarcodeForWord.AutoSize = true;
            this.linkBarcodeForWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.linkBarcodeForWord.Location = new System.Drawing.Point(0, 0);
            this.linkBarcodeForWord.Margin = new System.Windows.Forms.Padding(0);
            this.linkBarcodeForWord.Name = "linkBarcodeForWord";
            this.linkBarcodeForWord.Size = new System.Drawing.Size(81, 12);
            this.linkBarcodeForWord.TabIndex = 8;
            this.linkBarcodeForWord.TabStop = true;
            this.linkBarcodeForWord.Text = "Barcode.For.Word";
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.lblPoweredBy.Location = new System.Drawing.Point(81, 0);
            this.lblPoweredBy.Margin = new System.Windows.Forms.Padding(0);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(62, 12);
            this.lblPoweredBy.TabIndex = 9;
            this.lblPoweredBy.Text = "is powered by";
            // 
            // linkBarcoded
            // 
            this.linkBarcoded.AutoSize = true;
            this.linkBarcoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.linkBarcoded.Location = new System.Drawing.Point(143, 0);
            this.linkBarcoded.Margin = new System.Windows.Forms.Padding(0);
            this.linkBarcoded.Name = "linkBarcoded";
            this.linkBarcoded.Size = new System.Drawing.Size(44, 12);
            this.linkBarcoded.TabIndex = 10;
            this.linkBarcoded.TabStop = true;
            this.linkBarcoded.Text = "Barcoded";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = global::Barcodes.For.Shared.Resources.Header;
            this.pictureLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(194, 98);
            this.pictureLogo.TabIndex = 10;
            this.pictureLogo.TabStop = false;
            // 
            // Sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Name = "Sidebar";
            this.Size = new System.Drawing.Size(200, 814);
            this.tableMain.ResumeLayout(false);
            this.groupDimensions.ResumeLayout(false);
            this.tableDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numXDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPI)).EndInit();
            this.groupSymbology.ResumeLayout(false);
            this.tableSymbology.ResumeLayout(false);
            this.tableSymbology.PerformLayout();
            this.groupText.ResumeLayout(false);
            this.tableText.ResumeLayout(false);
            this.tableText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.tableData.ResumeLayout(false);
            this.tableData.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.flowCredits.ResumeLayout(false);
            this.flowCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cboSymbology;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.GroupBox groupDimensions;
        private System.Windows.Forms.GroupBox groupText;
        private System.Windows.Forms.GroupBox groupSymbology;
        private System.Windows.Forms.TableLayoutPanel tableData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TableLayoutPanel tableText;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ComboBox cboFontFamily;
        private System.Windows.Forms.Label lblFontFamily;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TableLayoutPanel tableSymbology;
        private System.Windows.Forms.CheckBox chkUseAsText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.CheckBox chkIncludeQuitezone;
        private System.Windows.Forms.TableLayoutPanel tableDimensions;
        private System.Windows.Forms.NumericUpDown numXDimension;
        private System.Windows.Forms.Label lblXDimension;
        private System.Windows.Forms.Label lblDPI;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblTargetWidth;
        private System.Windows.Forms.NumericUpDown numTargetWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numDPI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.FlowLayoutPanel flowCredits;
        private System.Windows.Forms.LinkLabel linkBarcodeForWord;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.LinkLabel linkBarcoded;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}
