using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Barcodes.For.Excel
{
    public partial class ExcelAddIn
    {
        private void ExcelAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ExcelAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Generated Code
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ExcelAddIn_Startup);
            this.Shutdown += new System.EventHandler(ExcelAddIn_Shutdown);
        }
        #endregion
    }
}
