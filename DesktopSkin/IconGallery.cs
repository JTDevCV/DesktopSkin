using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;
using System.Resources;


// Bugs**
    // If the user goes to the very end of the program and comes back to the first page, there's a misalignment causing the program to crash because of going out of index
namespace DesktopSkin
{
    public partial class IconGallery : UserControl
    {
        List<IconDisplay> iconDisplays;
        List<string> iconNamesResx = new List<string>();

        // Keeps track of the number of images that the user has passed/seen
        int numUsedImage = 0;

        public IconGallery()
        {
            InitializeComponent();

            // IconDisplays
            iconDisplays = new List<IconDisplay> { iconDisplay1, iconDisplay2, iconDisplay3, iconDisplay4, iconDisplay5,
                                                    iconDisplay6, iconDisplay7, iconDisplay8, iconDisplay9, iconDisplay10,
                                                    iconDisplay11, iconDisplay12, iconDisplay13, iconDisplay14, iconDisplay15 };
            // Call this function once to store a list of strings that exists in iconImagesRESX into a list
            enumerateIconsRes_Gal();
        }

        // Click Events for the next and previous button
        private void IconGallery_Load(object sender, EventArgs e)
        {
            nextButton.Click += new EventHandler(nextORprevious);
            previousButton.Click += new EventHandler(nextORprevious);
        }

        // IconGallery_Load will only be allowed to have access to this event. This event will determine which button was pressed and will call the function accord to its function
        private void nextORprevious(object sender, EventArgs e) 
        {
            string clickedButton = ((Control)sender).Name;

            switch (clickedButton)
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
                if (numUsedImage < numImages && numUsedImage >= 0)
                {
                    iconDisplays[i].Icon = (Image)iconImagesRESX.ResourceManager.GetObject(iconNamesResx[numUsedImage]);
                    iconDisplays[i].IconText = iconNamesResx[numUsedImage];
                    numUsedImage++;
                }
            }
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Next");
            //Console.WriteLine("numUsedImage: " + numUsedImage);
        }

        private void previousButtonClick()
        {
            if (numUsedImage > iconDisplays.Count && numUsedImage >= 0)
            {
                numUsedImage -= iconDisplays.Count * 2;
                nextButtonClick();
            }
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Previous");
            //Console.WriteLine("numUsedImage: " + numUsedImage);
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
            // Console.WriteLine(iconNamesResx.Count);
            nextButtonClick();
        }
    }
}
