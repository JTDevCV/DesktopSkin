using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Globalization;

namespace DesktopSkin
{
    public partial class MouseoverGallery : UserControl
    {
        List<MouseoverDisplay> mouseoverDisplays;
        List<string> mouseoverFilenamesResx = new List<string>();
        int numUsedImage = 0;

        public MouseoverGallery()
        {
            InitializeComponent();

            // IconDisplays
            mouseoverDisplays = new List<MouseoverDisplay> { mouseoverDisplay1, mouseoverDisplay2, mouseoverDisplay3, mouseoverDisplay4,
                                                        mouseoverDisplay5, mouseoverDisplay6, mouseoverDisplay7, mouseoverDisplay8 };


            enumerateIconsRes_Gal();
        }

        private void MouseoverGallery_Load(object sender, EventArgs e)
        {
            nextButton.Click += new EventHandler(nextORprevious);
            previousButton.Click += new EventHandler(nextORprevious);
        }

        // Double Buffer -- Prevents Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void nextORprevious(object sender, EventArgs e)
        {
            string buttonPressed = ((Control)sender).Name;
            switch (buttonPressed)
            {
                case "nextButton":
                    nextButtonClick();
                    break;
                case "previousButton":
                    previousButtonClick();
                    break;
            }
        }

        private void nextButtonClick()
        {
            int numImages = mouseoverFilenamesResx.Count;

            for (int i = 0; i < mouseoverDisplays.Count; i++)
            {
                if (numUsedImage < numImages)
                {
                    mouseoverDisplays[i].MouseoverImage = (Image)mouseoverImagesRESX.ResourceManager.GetObject(mouseoverFilenamesResx[numUsedImage]);
                    mouseoverDisplays[i].MouseoverFilename = mouseoverFilenamesResx[numUsedImage];
                    numUsedImage++;
                }
            }
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Next");
            //Console.WriteLine("numUsedImage: " + numUsedImage);
        }

        private void previousButtonClick()
        {
            if (numUsedImage > mouseoverDisplays.Count)
            {
                numUsedImage -= mouseoverDisplays.Count * 2;
                nextButtonClick();
            }

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Previous");
            //Console.WriteLine("numUsedImage: " + numUsedImage);
        }

        private void enumerateIconsRes_Gal()
        {
            ResourceSet resourceSet =
                mouseoverImagesRESX.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();

                mouseoverFilenamesResx.Add(resourceKey);
                //Console.WriteLine(resourceKey);
            }
            mouseoverFilenamesResx.Reverse();
            nextButtonClick();
            //Console.WriteLine(mouseoverFilenamesResx.Count);
        }
    }
}
