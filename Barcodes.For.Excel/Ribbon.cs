using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Barcodes.For.Excel
{
    public partial class Ribbon
    {
        private void btnMain_Click(object sender, RibbonControlEventArgs e) =>
            Globals.ExcelAddIn.Sidebar.Visible = !Globals.ExcelAddIn.Sidebar.Visible;
    }
}
