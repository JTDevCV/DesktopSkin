using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DesktopSkin
{
    public partial class IconHolder : UserControl
    {
        public IconHolder()
        {
            InitializeComponent();
        }


        #region Properties
        private string _iconText = "iconName";
        private Image _iconImage;
        private Color _backgroundColor;

        
        [Category("Custom Prop")]
        public string IconText
        {
            get { return _iconText; }
            set { _iconText = value; iconName_Gal.Text = value; }
        }

        [Category("Custom Prop")]
        public Image Icon
        {
            get { return _iconImage; }
            set { _iconImage = value; icon_Gal.BackgroundImage = value; }
        }

        [Category("Custom Prop")]
        public Color backColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; icon_Gal.BackColor = value; }
        }
        #endregion
    }
}
