using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace DesktopSkin
{
    public partial class MouseoverDisplay : UserControl
    {
        public MouseoverDisplay()
        {
            InitializeComponent();
        }

        private void MouseoverDisplay_Load(object sender, EventArgs e)
        {
            filenameDisplayBox.Click += new EventHandler(clipboardTxt);
            displayBox.Click += new EventHandler(clipboardTxt);

            filenameDisplayBox.MouseLeave += new EventHandler(resetText);
            displayBox.MouseLeave += new EventHandler(resetText);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            if (image == null)
            {
                width /= 2;
                height = width;
                image = assetImages._null;
            }
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        string currentAppName;
        bool isDefault = true;
        private void clipboardTxt(object sender, EventArgs e)
        {
            Clipboard.SetText(_mouseoverFilename);
            currentAppName = _mouseoverFilename;
            filenameDisplayBox.Text = "Copied To Clipboard!";
            isDefault = false;
        }

        private void resetText(object sender, EventArgs e)
        {
            if (!isDefault)
            {
                filenameDisplayBox.Text = currentAppName;
                isDefault = true;
            }
        }


        #region MyRegion
        private string _mouseoverFilename;
        private Image _mouseoverImage;

        [Category("Custom Prop")]
        public string MouseoverFilename
        {
            get { return _mouseoverFilename; }
            set { _mouseoverFilename = value; filenameDisplayBox.Text = value; }
        }

        [Category("Custom Prop")]
        public Image MouseoverImage
        {
            get { return _mouseoverImage; }
            set { _mouseoverImage = ResizeImage(value, displayBox.Width, displayBox.Height); displayBox.Image = ResizeImage(value, displayBox.Width, displayBox.Height); }
        }
        #endregion


    }
}
