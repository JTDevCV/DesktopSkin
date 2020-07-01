using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace DesktopSkin
{
    public partial class IconDisplay : UserControl
    {
        int IconWidth;
        public IconDisplay()
        {
            InitializeComponent();
        }


        private void IconDisplay_Load(object sender, EventArgs e)
        {
            IconWidth = this.Width;

            iconName.Click += new EventHandler(clipboardText);
            DisplayIcon.Click += new EventHandler(clipboardText);

            iconName.MouseLeave += new EventHandler(resetText);
            DisplayIcon.MouseLeave += new EventHandler(resetText);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            if (image == null)
            {
                image = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/null.png");
                width /= 2;
                height /= 2;
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
        private void clipboardText(object sender, EventArgs e)
        {
            Clipboard.SetText(_iconText);
            currentAppName = _iconText;
            iconName.Text = "Copied To Clipboard!";
            isDefault = false;
        }

        private void resetText(object sender, EventArgs e)
        {
            if (!isDefault)
            {
                iconName.Text = currentAppName;
                isDefault = true;
            }
        }

        #region Properties
        private string _iconText;
        private Image _iconImage;


        [Category("Custom Prop")]
        public string IconText
        {
            get { return _iconText; }
            set { _iconText = value; iconName.Text = value; }
        }

        [Category("Custom Prop")]
        public Image Icon
        {
            get { return _iconImage; }
            set { _iconImage = ResizeImage(value, DisplayIcon.Width, DisplayIcon.Height); DisplayIcon.Image = ResizeImage(value, DisplayIcon.Width, DisplayIcon.Height); }
        }
        #endregion
    }
}
