using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Globalization;

namespace DesktopSkin
{
    public partial class IconGallery : UserControl
    {
        List<IconDisplay> iconDisplays;
        List<string> iconNamesResx = new List<string>();
        int numUsedImage = 0;

        public IconGallery()
        {
            InitializeComponent();

            // IconDisplays
            iconDisplays = new List<IconDisplay> { iconDisplay1, iconDisplay2, iconDisplay3, iconDisplay4, iconDisplay5,
                                                    iconDisplay6, iconDisplay7, iconDisplay8, iconDisplay9, iconDisplay10,
                                                    iconDisplay11, iconDisplay12, iconDisplay13, iconDisplay14, iconDisplay15,
                                                    iconDisplay16, iconDisplay17, iconDisplay18, iconDisplay19, iconDisplay20 };

            enumerateIconsRes_Gal();
        }

        private void IconGallery_Load(object sender, EventArgs e)
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
            int numImages = iconNamesResx.Count;

            for (int i = 0; i < iconDisplays.Count; i++)
            {
                if (numUsedImage < numImages)
                {
                    iconDisplays[i].Icon = (Image)iconImagesRESX.ResourceManager.GetObject(iconNamesResx[numUsedImage]);
                    iconDisplays[i].IconText = iconNamesResx[numUsedImage];
                    numUsedImage++;
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Next");
            Console.WriteLine("numUsedImage: " + numUsedImage);
        }

        private void previousButtonClick()
        {
            if (numUsedImage > iconDisplays.Count)
            {
                numUsedImage -= iconDisplays.Count * 2;
                nextButtonClick();
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Previous");
            Console.WriteLine("numUsedImage: " + numUsedImage);
        }

        private void enumerateIconsRes_Gal()
        {
            ResourceSet resourceSet =
                iconImagesRESX.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();

                iconNamesResx.Add(resourceKey);
                // Console.WriteLine(resourceKey);
            }
            nextButtonClick();
            //Console.WriteLine(iconNamesResx.Count);
        }
    }
}
