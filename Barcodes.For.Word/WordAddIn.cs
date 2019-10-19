using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace Barcodes.For.Word
{
    public partial class WordAddIn
    {
        private void WordAddIn_Startup(object sender, System.EventArgs e)
        {
            
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
