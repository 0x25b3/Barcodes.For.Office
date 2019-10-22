using Barcodes.For.Shared;
using Microsoft.Office.Tools;

namespace Barcodes.For.Word
{
    public partial class WordAddIn
    {
        public CustomTaskPane Sidebar { get; private set; }

        private void WordAddIn_Startup(object sender, System.EventArgs e)
        {
            var sidebarControl = new Sidebar();
            sidebarControl.AddPicture = delegate (string path) { Globals.WordAddIn.Application.ActiveDocument.InlineShapes.AddPicture(path); };

            Sidebar = this.CustomTaskPanes.Add(sidebarControl, "Barcodes For Word");
            Sidebar.Visible = false;
        }

        private void WordAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Generated Code
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(WordAddIn_Startup);
            this.Shutdown += new System.EventHandler(WordAddIn_Shutdown);
        }
        #endregion
    }
}
