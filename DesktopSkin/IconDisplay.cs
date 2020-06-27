using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

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
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            if (image == null)
            {
                image = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/null.png");
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
