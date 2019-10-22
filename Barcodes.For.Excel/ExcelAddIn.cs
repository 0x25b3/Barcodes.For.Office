using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Barcodes.For.Shared;
using Microsoft.Office.Tools;

namespace Barcodes.For.Excel
{
    public partial class ExcelAddIn
    {
        public CustomTaskPane Sidebar { get; private set; }

        private void ExcelAddIn_Startup(object sender, System.EventArgs e)
        {
            var sidebarControl = new Sidebar();
            sidebarControl.AddPicture = delegate(string path) { Globals.ExcelAddIn.Application.ActiveSheet.Pictures.Insert(path); };

            Sidebar = this.CustomTaskPanes.Add(sidebarControl, "Barcodes For Excel");
            Sidebar.Visible = false;
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
