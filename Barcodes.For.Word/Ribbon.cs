using Microsoft.Office.Tools.Ribbon;

namespace Barcodes.For.Word
{
    public partial class Ribbon
    {
        private void btnMain_Click(object sender, RibbonControlEventArgs e) => 
            Globals.WordAddIn.Sidebar.Visible = !Globals.WordAddIn.Sidebar.Visible;
    }
}
