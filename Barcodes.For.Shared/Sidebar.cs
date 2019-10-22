using Barcoded;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Barcodes.For.Shared
{
    public partial class Sidebar : UserControl
    {
        public Action<string> AddPicture { get; set; }

        public Sidebar()
        {
            InitializeComponent();

            this.Load += Sidebar_Load;
        }

        /// <summary>
        /// Initialize ComboBoxes etc
        /// </summary>
        private void Sidebar_Load(object sender, EventArgs e)
        {
            foreach (int val in Enum.GetValues(typeof(Symbology)))
            {
                var memInfo = typeof(Symbology).GetMember(typeof(Symbology).GetEnumName(val));
                var descriptionAttribute = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

                var tmp = new ComboboxItem();
                tmp.Text = descriptionAttribute?.Description ?? memInfo[0].Name;
                tmp.Value = memInfo[0].Name;
                cboSymbology.Items.Add(tmp);
            }

            txtData.Text = "Hello World";
            cboPosition.SelectedIndex = 2;
            cboSymbology.SelectedIndex = 4;
            cboFontFamily.SelectedIndex = 46;
        }

        /// <summary>
        /// Inserts the barcode at the cursors position
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var image = GetImage();

                // Save image to temp file
                var tmpFile = Path.GetTempFileName();
                Path.ChangeExtension(tmpFile, "png");
                image.Save(tmpFile, ImageFormat.Png);

                // Insert the picture
                AddPicture(tmpFile);

                File.Delete(tmpFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barcode could no be inserted.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Copies the barcode to clipboard
        /// </summary>
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Generates a barcode image according to the users settings and returns it
        /// </summary>
        public Image GetImage()
        {
            var barcode = new LinearBarcode(txtData.Text, (Symbology)Enum.Parse(typeof(Symbology), ((ComboboxItem)cboSymbology.SelectedItem).Value))
            {
                Encoder =
                {
                    Quietzone = chkIncludeQuitezone.Checked,
                    TargetWidth = (int)numTargetWidth.Value,
                    BarcodeHeight = (int)numHeight.Value,
                    XDimension = (int)numXDimension.Value,
                    Dpi = (int)numDPI.Value,
                }
            };

            barcode.Encoder.HumanReadableValue = txtText.Text;
            barcode.Encoder.SetHumanReadableFont(cboFontFamily.Text, (int)numFontSize.Value);
            barcode.Encoder.SetHumanReadablePosition(cboPosition.Text);

            return barcode.Image;
        }

        /// <summary>
        /// Enable/disable the data textbox according to the chkUseAsText
        /// </summary>
        private void chkUseAsText_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Enabled = !chkUseAsText.Checked;

            // Transfer the Data to the Text when the checkbox is checked
            if (chkUseAsText.Checked)
                txtText.Text = txtData.Text;
        }

        /// <summary>
        /// Apply data to text if desired
        /// </summary>
        private void txtData_TextChanged(object sender, EventArgs e)
        {
            if (chkUseAsText.Checked)
                txtText.Text = txtData.Text;
        }
    }
}
