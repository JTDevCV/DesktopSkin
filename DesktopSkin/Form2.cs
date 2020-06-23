using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DesktopSkin
{
    public partial class Form2 : Form
    {
        string jsonFile = File.ReadAllText(@"C:\Users\joshk\OneDrive\Documents\GitHub\C#\DesktopSkin\panelLinks.json");
        JsonConfig jsonConfig;

        int currenNavMenu = 0;
        int currentPanelNum = 0;

        List<Panel> panels;
        List<Panel> decorBars;
        List<Panel> iconBoxes;
        List<Button> iconNames;

        // NavBar Components
        List<Panel> navBarButtons;
        List<Panel> navBarIcons;
        List<Button> navBarNames;

        int iconBoxesHeight;

        public Form2()
        {
            InitializeComponent();


            jsonConfig = JsonConvert.DeserializeObject<JsonConfig>(jsonFile);

            timer.Start();

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

        public static object EnvironmentFolders { get; private set; }

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
                    currenNavMenu = 0;
                    break;
                case "navBarButton2":
                    currenNavMenu = 1;
                    break;
                case "navBarButton3":
                    currenNavMenu = 2;
                    break;
                case "navBarButton4":
                    currenNavMenu = 3;
                    break;
            }

            iconDisplay();
            currentSelection_Nav();
        }

        private void currentSelection_Nav()
        {
            //selectedNav.Text = navBarNames[currenNavMenu].Text;
        }

        private void currentSelection_Panel()
        {
            //selectedPanel.Text = jsonConfig.Config[currenNavMenu][currentPanelNum][4];
        }

        private Image readJson_mouseoverImage(int panel, int panelInfo)
        {
            return (Image)mouseoverImages.ResourceManager.GetObject(jsonConfig.Config[currenNavMenu][panel][panelInfo]);
        }
        private Image readJson_iconImages(int panel, int panelInfo)
        {
            return (Image)icons.ResourceManager.GetObject(jsonConfig.Config[currenNavMenu][panel][panelInfo]);
        }

        private void iconDisplay()
        {
            // Panel 1
            iconBoxes[0].BackgroundImage = ResizeImage(
                readJson_iconImages(0,2), 
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[0].Text = jsonConfig.Config[currenNavMenu][0][4];

            // Panel 2
            iconBoxes[1].BackgroundImage = ResizeImage(
                readJson_iconImages(1, 2),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[1].Text = jsonConfig.Config[currenNavMenu][1][4];

            // Panel 3
            iconBoxes[2].BackgroundImage = ResizeImage(
                readJson_iconImages(2, 2),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[2].Text = jsonConfig.Config[currenNavMenu][2][4];

            // Panel 4
            iconBoxes[3].BackgroundImage = ResizeImage(
                readJson_iconImages(3, 2),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[3].Text = jsonConfig.Config[currenNavMenu][3][4];

            // Panel 5
            iconBoxes[4].BackgroundImage = ResizeImage(
                readJson_iconImages(4, 2),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[4].Text = jsonConfig.Config[currenNavMenu][4][4];

            // Panel 6
            iconBoxes[5].BackgroundImage = ResizeImage(
                readJson_iconImages(5, 2),
                iconBoxesHeight, 
                iconBoxesHeight);
            iconNames[5].Text = jsonConfig.Config[currenNavMenu][5][4];



            // NavBarIcons
            int navBarIconHeight = navBarIcon1.Height;
            navBarIcons[0].BackgroundImage = ResizeImage(Image.FromFile(jsonConfig.NavBarIcons[0]), navBarIconHeight, navBarIconHeight);
            navBarIcons[1].BackgroundImage = ResizeImage(Image.FromFile(jsonConfig.NavBarIcons[1]), navBarIconHeight, navBarIconHeight);
            navBarIcons[2].BackgroundImage = ResizeImage(Image.FromFile(jsonConfig.NavBarIcons[2]), navBarIconHeight, navBarIconHeight);
            navBarIcons[3].BackgroundImage = ResizeImage(Image.FromFile(jsonConfig.NavBarIcons[3]), navBarIconHeight, navBarIconHeight);
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
                    readJson_mouseoverImage(0, 1),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel2.Tag == currentPanel)
            {
                // Panel 2
                panels[1].BackgroundImage = ResizeImage(
                    readJson_mouseoverImage(1, 1),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel3.Tag == currentPanel)
            {
                // Panel 3
                panels[2].BackgroundImage = ResizeImage(
                    readJson_mouseoverImage(2, 1),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel4.Tag == currentPanel)
            {
                // Panel 4
                panels[3].BackgroundImage = ResizeImage(
                    readJson_mouseoverImage(3, 1),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel5.Tag == currentPanel)
            {
                // Panel 5
                panels[4].BackgroundImage = ResizeImage(
                    readJson_mouseoverImage(4, 1),
                    panel1.Width, 
                    panel1.Height);
            }
            if (panel6.Tag == currentPanel)
            {
                // Panel 6
                panels[5].BackgroundImage = ResizeImage(
                    readJson_mouseoverImage(5, 1),
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
            currentSelection_Panel();
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
    }
}
