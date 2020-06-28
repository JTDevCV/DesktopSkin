using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;


namespace DesktopSkin
{
    public partial class Form2 : Form
    {
        int currentNavMenu = 0;
#pragma warning disable CS0414 // The field 'Form2.currentPanelNum' is assigned but its value is never used
        int currentPanelNum = 0;
#pragma warning restore CS0414 // The field 'Form2.currentPanelNum' is assigned but its value is never used
        

        List<Panel> panels;
        List<Panel> decorBars;
        List<Panel> iconBoxes;
        List<Button> iconNames;

        // NavBar Components
        List<Panel> navBarButtons;
        List<Panel> navBarIcons;
        List<Button> navBarNames;

        
        
        int iconBoxesHeight;

        int iconGalWidth, iconGalHeight;

        Form1 frm = new Form1();
        public Form2()
        {
            InitializeComponent();

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

            iconGalButton.Click += new EventHandler(GalleryAnimation);

            

            saveButton.Click += new EventHandler(settingsUpdate);

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

        private void settingsUpdate(object sender, EventArgs e)
        {
            frm.writeJson_iconName(currentNavMenu, currentPanelNum, settingsTxt1.Text);
            frm.writeJson_iconImageFilename(currentNavMenu, currentPanelNum, settingsTxt2.Text);
            frm.writeJson_mouseoverImageFilename(currentNavMenu, currentPanelNum, settingsTxt3.Text);

            iconDisplay();
        }

        private void panelInfo()
        {
            selectedNav.FlatStyle = FlatStyle.Standard;

            settingsLabel1.Visible = true;
            settingsTxt1.Visible = true;
            settingsLabel2.Visible = true;
            settingsTxt2.Visible = true;
            settingsLabel3.Visible = true;
            settingsTxt3.Visible = true;

            selectedPanel.Text = frm.readJson_iconName(currentNavMenu, currentPanelNum);

            selectedNav.FlatStyle = FlatStyle.Flat;
            selectedPanel.FlatStyle = FlatStyle.Standard;

            settingsLabel1.Text = "Panel Name";
            settingsTxt1.Text = frm.readJson_iconName(currentNavMenu, currentPanelNum);

            settingsLabel2.Text = "Icon Image Name";
            settingsTxt2.Text = frm.readJson_iconImagesFilename(currentNavMenu, currentPanelNum);

            settingsLabel3.Text = "Mouseover Image";
            settingsTxt3.Text = frm.readJson_mouseoverImageFilename(currentNavMenu, currentPanelNum);
        }

        private void navInfo()
        {
            selectedNav.FlatStyle = FlatStyle.Standard;
            selectedPanel.FlatStyle = FlatStyle.Flat;

            settingsLabel1.Visible = true;
            settingsTxt1.Visible = true;
            settingsLabel2.Visible = true;
            settingsTxt2.Visible = true;
            settingsLabel3.Visible = false;
            settingsTxt3.Visible = false;

            settingsLabel1.Text = "Nav Icon";
            settingsLabel2.Text = "NavBar Color";

            settingsTxt1.Text = frm.readJson_navIconsFilename(currentNavMenu);
            settingsTxt2.Text = navBarPanel.BackColor.ToString();
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
            selectedNav.Text = navBarNames[currentNavMenu].Text;
            navInfo();
        }

        private void iconDisplay()
        {
            // Panel 1
            iconBoxes[0].BackgroundImage = ResizeImage(
                frm.readJson_iconImages(currentNavMenu, 0),
                iconBoxesHeight,
                iconBoxesHeight);
            iconNames[0].Text = frm.readJson_iconName(currentNavMenu, 0);

            // Panel 2
            iconBoxes[1].BackgroundImage = ResizeImage(
                frm.readJson_iconImages(currentNavMenu, 1),
                iconBoxesHeight,
                iconBoxesHeight);
            iconNames[1].Text = frm.readJson_iconName(currentNavMenu, 1);

            // Panel 3
            iconBoxes[2].BackgroundImage = ResizeImage(
                frm.readJson_iconImages(currentNavMenu, 2),
                iconBoxesHeight,
                iconBoxesHeight);
            iconNames[2].Text = frm.readJson_iconName(currentNavMenu, 2);

            // Panel 4
            iconBoxes[3].BackgroundImage = ResizeImage(
                frm.readJson_iconImages(currentNavMenu, 3),
                iconBoxesHeight,
                iconBoxesHeight);
            iconNames[3].Text = frm.readJson_iconName(currentNavMenu, 3);

            // Panel 5
            iconBoxes[4].BackgroundImage = ResizeImage(
                frm.readJson_iconImages(currentNavMenu, 4),
                iconBoxesHeight,
                iconBoxesHeight);
            iconNames[4].Text = frm.readJson_iconName(currentNavMenu, 4);

            // Panel 6
            iconBoxes[5].BackgroundImage = ResizeImage(
                frm.readJson_iconImages(currentNavMenu, 5),
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

            panelInfo();
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

        private void GalleryAnimation(object sender, EventArgs e)
        {
            iconGalTimer.Start();
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
    }
}
