using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace DesktopSkin
{
    public partial class Form2 : Form
    {
        int currentNavMenu = 0;
        int currentPanelNum = 0;


        List<Panel> panels;
        List<Panel> decorBars;
        List<Panel> iconBoxes;
        List<Button> iconNames;

        // NavBar Components
        List<Panel> navBarButtons;
        List<Panel> navBarIcons;
        List<Button> navBarNames;

        List<string> iconNamesResx = new List<string>();
        List<string> mouseoverNamesResx = new List<string>();

        int iconBoxesHeight;
        int iconGalWidth, iconGalHeight;

        int dropdownHeight;

        Form1 frm = new Form1();
        public Form2()
        {
            InitializeComponent();

            dropdownHeight = dropdownButton.Height;
            dropdownButton.Size = new Size(GalleryButton.Width, GalleryButton.Height);

            iconGalWidth = iconGallery.Width;
            iconGalHeight = iconGallery.Height;

            iconGallery.Size = new Size(0, iconGalHeight);

            iconBoxesHeight = iconBox1.Height;

            // Add panels to panels list
            panels = new List<Panel> { panel1, panel2, panel3, panel4, panel5, panel6 };

            // Add decorBars to decorBars list
            decorBars = new List<Panel> { decorBar1, decorBar2, decorBar3, decorBar4, decorBar5, decorBar6 };

            // Add iconBoxes to iconBoxes list
            iconBoxes = new List<Panel> { iconBox1, iconBox2, iconBox3, iconBox4, iconBox5, iconBox6 };

            // Add iconNames to iconNames list
            iconNames = new List<Button> { iconName1, iconName2, iconName3, iconName4, iconName5, iconName6 };

            ///////////////////////////////////////////////////////////
            // NavBarButtons
            navBarButtons = new List<Panel> { navBarButton1, navBarButton2, navBarButton3, navBarButton4 };

            // NavBarIcons
            navBarIcons = new List<Panel> { navBarIcon1, navBarIcon2, navBarIcon3, navBarIcon4 };

            // navBarNames
            navBarNames = new List<Button> { navBarName1, navBarName2, navBarName3, navBarName4 };


            navBarPanel.BackColor = Color.FromArgb(125, Color.Black);

            enumerateRESX();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            frm.Show();
            frm.Hide();

            timer.Start();

            for (int i = 0; i < navBarButtons.Count; i++)
            {
                navBarButtons[i].BackColor = Color.FromArgb(125, Color.Black);
            }

            for (int i = 0; i < panels.Count; i++)
            {
                decorBars[i].BackColor = Color.FromArgb(125, Color.White);

                panels[i].BackColor = Color.FromArgb(125, Color.Black);

                iconBoxes[i].BackColor = Color.FromArgb(0, Color.Black);
                iconNames[i].BackColor = Color.FromArgb(0, Color.Black);
            }
            iconDisplay();

            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].MouseEnter += new EventHandler(panel_onEnter);
                panels[i].MouseLeave += new EventHandler(panel_onLeave);
                panels[i].Click += new EventHandler(panel_onClick);

                iconBoxes[i].MouseEnter += new EventHandler(panel_onEnter);
                iconBoxes[i].MouseLeave += new EventHandler(panel_onLeave);
                iconBoxes[i].Click += new EventHandler(panel_onClick);

                iconNames[i].MouseEnter += new EventHandler(panel_onEnter);
                iconNames[i].MouseLeave += new EventHandler(panel_onLeave);
                iconNames[i].Click += new EventHandler(panel_onClick);
            }

            for (int i = 0; i < navBarButtons.Count; i++)
            {
                navBarButtons[i].MouseEnter += new EventHandler(this.navBarButtons_hover);
                navBarButtons[i].MouseLeave += new EventHandler(this.navBarButtons_default);
                navBarButtons[i].Click += new EventHandler(this.navBarButtons_Click);

                navBarIcons[i].MouseEnter += new EventHandler(this.navBarButtons_hover);
                navBarIcons[i].MouseLeave += new EventHandler(this.navBarButtons_default);
                navBarIcons[i].Click += new EventHandler(this.navBarButtons_Click);

                navBarNames[i].MouseEnter += new EventHandler(this.navBarButtons_hover);
                navBarNames[i].MouseLeave += new EventHandler(this.navBarButtons_default);
                navBarNames[i].Click += new EventHandler(this.navBarButtons_Click);
            }

            GalleryButton.Click += new EventHandler(dropdownAnimation);

            iconGalButton.Click += new EventHandler(iconGalAnimation);

            settingsButton.Click += new EventHandler(closeGallery);

            saveButton.Click += new EventHandler(saveSettings);

            helpIcon.BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/help.png");
            exitSetting.Click += new EventHandler(this.exitButton);
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

        private void closeGallery(object sender, EventArgs e)
        {
           iconGallery.Visible = false;
        }

        private void saveSettings(object sender, EventArgs e)
        {
            bool iconExists = false;
            bool mouseoverExists = false;
            for (int i = 0; i < iconNamesResx.Count; i++)
            {
                if (iconNamesResx[i] == settingTxtBox2.Text)
                {
                    Console.WriteLine("App File Exists");
                    frm.writeJson_IconName(currentNavMenu, currentPanelNum, settingTxtBox1.Text);
                    frm.writeJson_AppImage(currentNavMenu, currentPanelNum, settingTxtBox2.Text);
                    iconExists = true;
                }
            }
            for (int i = 0; i < mouseoverNamesResx.Count; i++)
            {
                if (mouseoverNamesResx[i] == settingTxtBox3.Text)
                {
                    Console.WriteLine("Mouseover File Exists");
                    frm.writeJson_MouseoverImage(currentNavMenu, currentPanelNum, settingTxtBox3.Text);
                    mouseoverExists = true;
                }
            }

            if (!iconExists && !mouseoverExists)
            {
                MessageBox.Show("App Image: " + settingTxtBox2.Text + "\n" + "Mouseover Image: " + settingTxtBox3.Text + "\n------------------------------\nDOES NOT EXISTS!");
            }
            else
            {
                if (!iconExists)
                {
                    MessageBox.Show("App Image: " + settingTxtBox2.Text + "\n------------------------------\nDOES NOT EXISTS!");
                }
                if (!mouseoverExists)
                {
                    MessageBox.Show("Mouseover Image: " + settingTxtBox3.Text + "\n------------------------------\nDOES NOT EXISTS!");
                }
            }
            iconDisplay();
        }

        private void navBarButtons_hover(object sender, EventArgs e)
        {
            object currentNavButton = ((Control)sender).Tag;
            // On Hover
            for (int i = 0; i < navBarButtons.Count; i++)
            {
                if (navBarButtons[i].Tag == currentNavButton)
                {
                    navBarButtons[i].BackColor = Color.FromArgb(200, Color.Black);
                }
            }
        }

        private void navBarButtons_default(object sender, EventArgs e)
        {
            object currentNavButton = ((Control)sender).Tag;
            // default
            for (int i = 0; i < navBarButtons.Count; i++)
            {
                if (navBarButtons[i].Tag == currentNavButton)
                {
                    navBarButtons[i].BackColor = Color.FromArgb(125, Color.Black);
                }
            }
        }

        private void navBarButtons_Click(object sender, EventArgs e)
        {
            object currentNavButton_Tag = ((Control)sender).Tag;

            for (int i = 0; i < navBarButtons.Count; i++)
            {
                if (navBarButtons[i].Tag == currentNavButton_Tag)
                {
                    navBarButtons[i].BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    navBarButtons[i].BorderStyle = BorderStyle.None;
                }
            }

            switch (currentNavButton_Tag)
            {
                case "navBarButton1":
                    currentNavMenu = 0;
                    break;
                case "navBarButton2":
                    currentNavMenu = 1;
                    break;
                case "navBarButton3":
                    currentNavMenu = 2;
                    break;
                case "navBarButton4":
                    currentNavMenu = 3;
                    break;
            }

            iconDisplay();
            navSettings();
            selectedNav.Text = navBarNames[currentNavMenu].Text;
        }

        private void navSettings()
        {
            settings1.Visible = true;
            settings2.Visible = true;
            settings3.Visible = false;
            settings4.Visible = false;

            labelName1.Text = "Navigation Icon";
            settingTxtBox1.Text = frm.readJson_navIconsFilename(currentNavMenu);

            labelName2.Text = "Navigation Menu Color";
            settingTxtBox2.Text = navBarButtons[currentNavMenu].BackColor.ToString();
        }

        private void iconDisplay()
        {
            // Panel 1
            iconBoxes[0].BackgroundImage = ResizeImage(
                frm.readJson_iconImage(currentNavMenu, 0), 
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[0].Text = frm.readJson_iconName(currentNavMenu, 0);

            // Panel 2
            iconBoxes[1].BackgroundImage = ResizeImage(
                frm.readJson_iconImage(currentNavMenu, 1),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[1].Text = frm.readJson_iconName(currentNavMenu, 1);

            // Panel 3
            iconBoxes[2].BackgroundImage = ResizeImage(
                frm.readJson_iconImage(currentNavMenu, 2),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[2].Text = frm.readJson_iconName(currentNavMenu, 2);

            // Panel 4
            iconBoxes[3].BackgroundImage = ResizeImage(
                frm.readJson_iconImage(currentNavMenu, 3),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[3].Text = frm.readJson_iconName(currentNavMenu, 3);

            // Panel 5
            iconBoxes[4].BackgroundImage = ResizeImage(
                frm.readJson_iconImage(currentNavMenu, 4),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[4].Text = frm.readJson_iconName(currentNavMenu, 4);

            // Panel 6
            iconBoxes[5].BackgroundImage = ResizeImage(
                frm.readJson_iconImage(currentNavMenu, 5),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[5].Text = frm.readJson_iconName(currentNavMenu, 5);


            // NavBarIcons
            int navBarIconHeight = navBarIcon1.Height;
            navBarIcons[0].BackgroundImage = ResizeImage(
                frm.readJson_navIcons(0),
                navBarIconHeight, 
                navBarIconHeight);
            navBarIcons[1].BackgroundImage = ResizeImage(
                frm.readJson_navIcons(1),
                navBarIconHeight, 
                navBarIconHeight);
            navBarIcons[2].BackgroundImage = ResizeImage(
                frm.readJson_navIcons(2),
                navBarIconHeight, 
                navBarIconHeight);
            navBarIcons[3].BackgroundImage = ResizeImage(
                frm.readJson_navIcons(3),
                navBarIconHeight, 
                navBarIconHeight);
        }

        private void panel_onLeave(object sender, EventArgs e)
        {
            object currentPanel = ((Control)sender).Tag;

            for (int i = 0; i < panels.Count; i++)
            {
                if (panels[i].Tag == currentPanel)
                {
                    decorBars[i].BackColor = Color.FromArgb(125, Color.White);
                    panels[i].BackgroundImage = null;
                    panels[i].BackColor = Color.FromArgb(125, Color.Black);
                }
            }
        }

        private void panel_onEnter(object sender, EventArgs e)
        {
            object currentPanel = ((Control)sender).Tag;

            for (int i = 0; i < panels.Count; i++)
            {
                if (panels[i].Tag == currentPanel)
                {
                    decorBars[i].BackColor = Color.White;
                }
            }

            if (panel1.Tag == currentPanel)
            {
                // Panel 1
                panels[0].BackgroundImage = ResizeImage(
                    frm.readJson_mouseoverImage(currentNavMenu, 0),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel2.Tag == currentPanel)
            {
                // Panel 2
                panels[1].BackgroundImage = ResizeImage(
                    frm.readJson_mouseoverImage(currentNavMenu, 1),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel3.Tag == currentPanel)
            {
                // Panel 3
                panels[2].BackgroundImage = ResizeImage(
                    frm.readJson_mouseoverImage(currentNavMenu, 2),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel4.Tag == currentPanel)
            {
                // Panel 4
                panels[3].BackgroundImage = ResizeImage(
                    frm.readJson_mouseoverImage(currentNavMenu, 3),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel5.Tag == currentPanel)
            {
                // Panel 5
                panels[4].BackgroundImage = ResizeImage(
                    frm.readJson_mouseoverImage(currentNavMenu, 4),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel6.Tag == currentPanel)
            {
                // Panel 6
                panels[5].BackgroundImage = ResizeImage(
                    frm.readJson_mouseoverImage(currentNavMenu, 5),
                    panel1.Width, 
                    panel1.Height);
            }
        }

        private void panel_onClick(object sender, EventArgs e)
        {
            object currentPanel = ((Control)sender).Tag;
            for (int i = 0; i < panels.Count; i++)
            {
                if (panels[i].Tag == currentPanel)
                {
                    panels[i].BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    panels[i].BorderStyle = BorderStyle.None;
                }
            }

            switch (currentPanel)
            {
                case "panel1":
                    currentPanelNum = 0;
                    break;
                case "panel2":
                    currentPanelNum = 1;
                    break;
                case "panel3":
                    currentPanelNum = 2;
                    break;
                case "panel4":
                    currentPanelNum = 3;
                    break;
                case "panel5":
                    currentPanelNum = 4;
                    break;
                case "panel6":
                    currentPanelNum = 5;
                    break;
            }

            selectedPanel.Text = frm.readJson_iconName(currentNavMenu, currentPanelNum);
            panelSettings();
        }

        private void panelSettings()
        {
            settings1.Visible = true;
            settings2.Visible = true;
            settings3.Visible = true;
            settings4.Visible = false;

            labelName1.Text = "App Name";
            settingTxtBox1.Text = frm.readJson_iconName(currentNavMenu, currentPanelNum);

            labelName2.Text = "App Icon";
            settingTxtBox2.Text = frm.readJson_iconImageFilename(currentNavMenu, currentPanelNum);

            labelName3.Text = "Mouseover Image";
            settingTxtBox3.Text = frm.readJson_mouseoverImageFilename(currentNavMenu, currentPanelNum);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
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

        private void exitButton(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            labelSeconds.Text = DateTime.Now.ToString("ss");
            labelDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
        }

        private void iconGalAnimation(object sender, EventArgs e)
        {
            iconGalTimer.Start();
            iconGallery.Visible = true;
            int iconGalCurrentWidth = iconGallery.Width;
            if (iconGalCurrentWidth < iconGalWidth)
            {
                iconGallery.Size = new Size(iconGalCurrentWidth + (iconGalWidth / 14), iconGalHeight);
            }
            else
            {
                iconGalTimer.Stop();
                iconGallery.Size = new Size(iconGalWidth, iconGalHeight);
            }
        }

        private void dropdownAnimation(object sender, EventArgs e)
        {
            dropdownTimer.Start();
            
            if (dropdownButton.Height <= dropdownHeight)
            {
                dropdownButton.Size = new Size(dropdownButton.Width, dropdownButton.Height + (dropdownHeight / 14));
            }
            else
            {
                dropdownTimer.Stop();
                dropdownButton.Size = new Size(GalleryButton.Width, dropdownHeight);
                Console.WriteLine(dropdownButton.Height + " <= " + dropdownHeight);
            }
            
        }

        private void enumerateRESX()
        {
            ResourceSet resourceSet =
                iconImagesRESX.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();

                iconNamesResx.Add(resourceKey);
            }

            ResourceSet resourceSet2 =
                mouseoverImagesRESX.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach (DictionaryEntry entry in resourceSet2)
            {
                string resourceKey = entry.Key.ToString();

                mouseoverNamesResx.Add(resourceKey);
                //Console.WriteLine(resourceKey);
            }
        }
    }
}
