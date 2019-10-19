using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Barcoded;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;

namespace Barcodes.For.Word
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            foreach (int val in Enum.GetValues(typeof(Symbology)))
            {
                var memInfo = typeof(Symbology).GetMember(typeof(Symbology).GetEnumName(val));
                var descriptionAttribute = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

                var tmp = this.Factory.CreateRibbonDropDownItem();
                tmp.Label = descriptionAttribute?.Description ?? memInfo[0].Name;
                tmp.Tag = memInfo[0].Name;
                ddSymbology.Items.Add(tmp);
            }
        }

        public Image GetImage()
        {
            var Text = txtBarcode.Text;

            var barcode = new LinearBarcode(Text, (Symbology)Enum.Parse(typeof(Symbology), (string)ddSymbology.SelectedItem.Tag))
            {
                Encoder =
                {
                    Dpi = 300,
                    BarcodeHeight = 150,
                }
            };

            if (cbShowText.Checked)
            {
                barcode.Encoder.HumanReadableValue = Text;
                barcode.Encoder.SetHumanReadablePosition("Below");
                barcode.Encoder.SetHumanReadableFont("Arial", 8);
            }

            return barcode.Image;
        }

        private void btnInsertBarcode_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var image = GetImage();

                var tmp = Path.GetTempFileName();
                Path.ChangeExtension(tmp, "png");
                image.Save(tmp, ImageFormat.Png);

                var Shape = Globals.WordAddIn.Application.ActiveDocument.InlineShapes.AddPicture(tmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barcode could no be inserted.\n\n" + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyBarcode_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var image = GetImage();

                Clipboard.SetImage(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barcode could no be copied.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
