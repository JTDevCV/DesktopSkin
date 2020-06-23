using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace DesktopSkin
{
    public partial class Form1 : Form
    {
        // Menu Panel Components
        private List<Panel> panels;
        private List<Panel> decorBars;
        private List<Panel> iconBoxes;
        private List<Button> iconNames;

        // NavBar Components
        private List<Panel> navBarButtons;
        private List<Panel> navBarIcons;
        private List<Button> navBarNames;
        private string navBarMenu = "navBarButton1";
        private int panelsHeight, panelsWidth;
        private int decorBarHeight;
        private int iconBoxHeight, iconBoxWidth;
        private int iconNameHeight, iconNameWidth;
        private int navMenuHeight, navMenuWidth;
        private int gradientBarHeight, gradientBarWidth;
        private int animatePanelHeight, animatePanelWidth;


        public Form1()
        {
            InitializeComponent();

            panelsHeight = panel1.Height;
            panelsWidth = panel1.Width;
            decorBarHeight = decorBar1.Height;
            iconBoxHeight = iconBox1.Height;
            iconBoxWidth = panelsWidth;
            iconNameHeight = iconName1.Height;
            iconNameWidth = panelsWidth;
            navMenuHeight = navMenu.Height;
            navMenuWidth = navMenu.Width;
            gradientBarHeight = gradientBar.Height;
            gradientBarWidth = gradientBar.Width;
            animatePanelHeight = animatePanel.Height;
            animatePanelWidth = animatePanel.Width;


            // Add panels to panels list
            panels = new List<Panel> { panel1, panel2, panel3, panel4, panel5, panel6};

            // Add decorBars to decorBars list
            decorBars = new List<Panel> { decorBar1, decorBar2, decorBar3, decorBar4, decorBar5, decorBar6};

            // Add iconBoxes to iconBoxes list
            iconBoxes = new List<Panel> { iconBox1, iconBox2, iconBox3, iconBox4, iconBox5, iconBox6};

            // Add iconNames to iconNames list
            iconNames = new List<Button> { iconName1, iconName2, iconName3, iconName4, iconName5, iconName6};

            ///////////////////////////////////////////////////////////
            // NavBarButtons
            navBarButtons = new List<Panel> { navBarButton1 , navBarButton2, navBarButton3, navBarButton4};

            // NavBarIcons
            navBarIcons = new List<Panel> { navBarIcon1, navBarIcon2, navBarIcon3, navBarIcon4};

            // navBarNames
            navBarNames = new List<Button> { navBarName1, navBarName2, navBarName3, navBarName4};

            // Activation 
            activationBar.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 10, 0);
            activationBar.MouseHover += new EventHandler(this.screenshot);
            activationBar.MouseHover += new EventHandler(this.menuPanel_default);
            activationBar.MouseHover += new EventHandler(this.startupAnimation);



            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].MouseEnter += new EventHandler(this.menuPanel_hover);
                panels[i].MouseLeave += new EventHandler(this.menuPanel_default);
                panels[i].Click += new EventHandler(this.menuPanel_click);

                iconBoxes[i].MouseEnter += new EventHandler(this.menuPanel_hover);
                iconBoxes[i].MouseLeave += new EventHandler(this.menuPanel_default);
                iconBoxes[i].Click += new EventHandler(this.menuPanel_click);

                iconNames[i].MouseEnter += new EventHandler(this.menuPanel_hover);
                iconNames[i].MouseLeave += new EventHandler(this.menuPanel_default);
                iconNames[i].Click += new EventHandler(this.menuPanel_click);
            }
            for(int i = 0; i < navBarButtons.Count; i++)
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

            settings.MouseEnter += new EventHandler(this.setting_hover);
            settings.MouseLeave += new EventHandler(this.setting_default);
            settings.Click += new EventHandler(this.setting_click);

            exitButton.Click += new EventHandler(this.exit);
            blurBackground.Click += new EventHandler(this.menuClose);
        }

        // Double Buffer -- Prevents Flickering
        protected override CreateParams CreateParams
        {
            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        // ---------------------------------Settings hover, default, click
        private void setting_hover(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(125, Color.White);
        }
        private void setting_default(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void setting_click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
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
            string currentNavButton_Tag = ((Control)sender).Tag.ToString();
            if (!(navBarMenu == currentNavButton_Tag))
            {
                navBarMenu = currentNavButton_Tag;

                animatePanel.Visible = false;
                menuPanel_default(sender, e);
                panelAnimation(sender, e);
            }
        }
        // ------------------------------------------------------------------------------------------------------------Animation 
        private void startupAnimation(object sender, EventArgs e)
        {
            navBarAnimation(sender, e);
            panelAnimation(sender, e);
        }

        private void navBarAnimation(object sender, EventArgs e)
        {
            navMenu.Visible = true;
            gradientBar.Visible = true;
            //NavBar Animation
            navBarPanel.BackColor = Color.FromArgb(125, Color.Black);
            navMenu.Size = new Size(0, navMenuHeight);
            gradientBar.Size = new Size(0, gradientBarHeight);
            navIconDisplay(sender, e);
            for (int i = 0; i < navBarButtons.Count; i++)
            {
                navBarButtons[i].BackColor = Color.FromArgb(125, Color.Black);
                navBarIcons[i].BackColor = Color.FromArgb(0, Color.Black);
                navBarNames[i].BackColor = Color.FromArgb(0, Color.Black);
            }

            int navMenuCurrentWidth = 0;
            int gradientCurrentWidth = 0;
            while (navMenuCurrentWidth <= navMenuWidth || gradientCurrentWidth <= gradientBarWidth)
            {
                if (gradientCurrentWidth <= gradientBarWidth)
                {
                    gradientBar.Size = new Size(gradientCurrentWidth, gradientBarHeight);
                    gradientBar.Refresh();
                    gradientCurrentWidth += (gradientBarWidth / 25);
                    Thread.Sleep(20);
                }
                if (navMenuCurrentWidth <= navMenuWidth)
                {
                    navMenu.Size = new Size(navMenuCurrentWidth, navMenuHeight);
                    navMenu.Refresh();
                    navMenuCurrentWidth += (navMenuWidth / 25);
                    Thread.Sleep(15);
                }
            }
            navMenu.Size = new Size(navMenuWidth, navMenuHeight);
            navMenu.Refresh();
            gradientBar.Size = new Size(gradientBarWidth, gradientBarHeight);
            gradientBar.Refresh();
        }

        private void panelAnimation(object sender, EventArgs e)
        {
            //Decor bar animation --> Transition to right animation
            animatePanel.Size = new Size(animatePanelWidth, decorBarHeight);
            animatePanel.Visible = true;
            for (int i = 0; i < panels.Count; i++)
            {
                decorBars[i].Size = new Size(0, decorBarHeight);
                panels[i].BackColor = Color.FromArgb(125, Color.Black);

                // Icons visibility is false
                iconBoxes[i].Visible = false;
                iconNames[i].Visible = false;

                // Resize IconNames and IconBoxes
                iconBoxes[i].Size = new Size(iconBoxes[i].Width, 0);
                iconNames[i].Size = new Size(iconNames[i].Width, 0);

            }

            int decorBarsCurrentWidth = 0;
            while (decorBarsCurrentWidth <= panelsWidth)
            {
                for (int i = 0; i < decorBars.Count; i++)
                {
                    decorBars[i].Size = new Size(decorBarsCurrentWidth, 10);
                    decorBars[i].Refresh();
                }
                Thread.Sleep(25);
                decorBarsCurrentWidth += (panelsWidth / 9);
            }

            // Menu panels animation --> Transition down animation
            int panelsCurrentHeight = decorBarHeight;
            while (panelsCurrentHeight <= panelsHeight)
            {
                animatePanel.Size = new Size(animatePanelWidth, panelsCurrentHeight);
                animatePanel.Refresh();
                Thread.Sleep(20);
                panelsCurrentHeight += ((animatePanelHeight - decorBarHeight) / 10);
            }
            // Check if the menu panels are the same height as the background image
            animatePanel.Size = new Size(animatePanelWidth, animatePanelHeight);
            animatePanel.Refresh();

            // IconBoxes and IconNames animations
            int currentIconBoxHeight = 0;

            while (currentIconBoxHeight <= iconBoxHeight)
            {
                for (int i = 0; i < panels.Count; i++)
                {
                    iconBoxes[i].Visible = true;
                    iconBoxes[i].BackColor = Color.FromArgb(0, Color.Black);
                    iconBoxes[i].Size = new Size(iconBoxWidth, currentIconBoxHeight);
                    iconBoxes[i].Refresh();

                    iconNames[i].Visible = true;
                    iconNames[i].BackColor = Color.FromArgb(0, Color.Black);
                    iconNames[i].Size = new Size(iconBoxWidth, currentIconBoxHeight);
                    iconNames[i].Refresh();
                }
                Thread.Sleep(20);
                currentIconBoxHeight += (iconBoxHeight / 10);
            }
            // Check if the iconBoxes and panels panels are the same height as its original
            for (int i = 0; i < panels.Count; i++)
            {
                iconBoxes[i].Size = new Size(iconBoxWidth, iconBoxHeight);
                iconBoxes[i].Size = new Size(iconNameWidth, iconNameHeight);

                iconBoxes[i].Refresh();
                iconNames[i].Refresh();
            }
        }

        // -------------------------------------------------------------------------------------menuPanel
        private void menuPanel_default(object sender, EventArgs e)
        {
            object currentPanel = ((Control)sender).Tag;
            for (int i = 0; i < panels.Count; i++)
            {
                if (panels[i].Tag == currentPanel)
                {
                    panels[i].BackgroundImage = null;
                    panels[i].BackColor = Color.FromArgb(125, Color.Black);
                    decorBars[i].BackColor = Color.FromArgb(125, Color.White);
                }
            }
            // Call iconDisplay
            iconDisplay(sender, e);
        }

        private void menuPanel_hover(object sender, EventArgs e)
        {
            object currentPanel = ((Control)sender).Tag;
            // On Hover
            for (int i = 0; i < panels.Count; i++)
            {
                if (panels[i].Tag == currentPanel)
                {
                    decorBars[i].BackColor = Color.White;
                }
            }
            switch (navBarMenu)
            {
                case "navBarButton1":
                    switch (currentPanel)
                    {
                        case "panel1":
                            panels[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/001.png");
                            break;
                        case "panel2":
                            panels[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/001.png");
                            break;
                        case "panel3":
                            panels[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/001.png");
                            break;
                        case "panel4":
                            panels[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/001.png");
                            break;
                        case "panel5":
                            panels[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/001.png");
                            break;
                        case "panel6":
                            panels[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/001.png");
                            break;
                    }
                    break;
                case "navBarButton2":
                    switch (currentPanel)
                    {
                        case "panel1":
                            panels[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/003.png");
                            break;
                        case "panel2":
                            panels[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/003.png");
                            break;
                        case "panel3":
                            panels[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/003.png");
                            break;
                        case "panel4":
                            panels[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/003.png");
                            break;
                        case "panel5":
                            panels[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/003.png");
                            break;
                        case "panel6":
                            panels[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/003.png");
                            break;
                    }
                    break;
                case "navBarButton3":
                    switch (currentPanel)
                    {
                        case "panel1":
                            panels[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/053.png");
                            break;
                        case "panel2":
                            panels[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/053.png");
                            break;
                        case "panel3":
                            panels[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/053.png");
                            break;
                        case "panel4":
                            panels[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/053.png");
                            break;
                        case "panel5":
                            panels[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/053.png");
                            break;
                        case "panel6":
                            panels[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/053.png");
                            break;
                    }
                    break;
                case "navBarButton4":
                    switch (currentPanel)
                    {
                        case "panel1":
                            panels[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/038.png");
                            break;
                        case "panel2":
                            panels[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/038.png");
                            break;
                        case "panel3":
                            panels[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/038.png");
                            break;
                        case "panel4":
                            panels[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/038.png");
                            break;
                        case "panel5":
                            panels[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/038.png");
                            break;
                        case "panel6":
                            panels[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/038.png");
                            break;
                    }
                    break;
            }
        }

        private void menuPanel_click(object sender, EventArgs e)
        {
            Panel currentPanel = sender as Panel;
            // On Click
            currentPanel.Cursor = Cursors.AppStarting;
            switch (currentPanel.Tag)
            {
                case "panel1":
                    menuClose(sender, e);
                    Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
                    break;
                case "panel2":
                    menuClose(sender, e);
                    Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
                    break;
                case "panel3":
                    menuClose(sender, e);
                    Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
                    break;
                case "panel4":
                    menuClose(sender, e);
                    Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
                    break;
                case "panel5":
                    menuClose(sender, e);
                    Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
                    break;
                case "panel6":
                    menuClose(sender, e);
                    Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
                    break;
                default:
                    Console.WriteLine("No file execution");
                    break;
            }
        }

        private void iconDisplay(object sender, EventArgs e)
        {
            for (int i = 0; i < panels.Count; i++)
            {
                iconNames[i].Font = new Font(iconName1.Font.FontFamily, 30);
            }

            switch (navBarMenu)
            {
                case "navBarButton1":
                    // Panel 1
                    iconBoxes[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_D_Unity.png");
                    iconNames[0].Text = "Unity";

                    // Panel 2
                    iconBoxes[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_D_Unity.png");
                    iconNames[1].Text = "Unity";

                    // Panel 3
                    iconBoxes[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_D_Unity.png");
                    iconNames[2].Text = "Unity";

                    // Panel 4
                    iconBoxes[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_D_Unity.png");
                    iconNames[3].Text = "Unity";

                    // Panel 5
                    iconBoxes[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_D_Unity.png");
                    iconNames[4].Text = "Unity";

                    // Panel 6
                    iconBoxes[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_D_Unity.png");
                    iconNames[5].Text = "Unity";
                    break;
                case "navBarButton2":
                    // Panel 1
                    iconBoxes[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Beseige.png");
                    iconNames[0].Text = "Beseige";

                    // Panel 2
                    iconBoxes[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Beseige.png");
                    iconNames[1].Text = "Beseige";

                    // Panel 3
                    iconBoxes[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Beseige.png");
                    iconNames[2].Text = "Beseige";

                    // Panel 4
                    iconBoxes[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Beseige.png");
                    iconNames[3].Text = "Beseige";

                    // Panel 5
                    iconBoxes[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Beseige.png");
                    iconNames[4].Text = "Beseige";

                    // Panel 6
                    iconBoxes[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Beseige.png");
                    iconNames[5].Text = "Beseige";
                    break;
                case "navBarButton3":
                    // Panel 1
                    iconBoxes[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_BattleNet.png");
                    iconNames[0].Text = "BattleNet";

                    // Panel 2
                    iconBoxes[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_BattleNet.png");
                    iconNames[1].Text = "BattleNet";

                    // Panel 3
                    iconBoxes[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_BattleNet.png");
                    iconNames[2].Text = "BattleNet";

                    // Panel 4
                    iconBoxes[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_BattleNet.png");
                    iconNames[3].Text = "BattleNet";

                    // Panel 5
                    iconBoxes[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_BattleNet.png");
                    iconNames[4].Text = "BattleNet";

                    // Panel 6
                    iconBoxes[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_BattleNet.png");
                    iconNames[5].Text = "BattleNet";
                    break;
                case "navBarButton4":
                    // Panel 1
                    iconBoxes[0].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Crysis.png");
                    iconNames[0].Text = "Crysis";

                    // Panel 2
                    iconBoxes[1].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Crysis.png");
                    iconNames[1].Text = "Crysis";

                    // Panel 3
                    iconBoxes[2].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Crysis.png");
                    iconNames[2].Text = "Crysis";

                    // Panel 4
                    iconBoxes[3].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Crysis.png");
                    iconNames[3].Text = "Crysis";

                    // Panel 5
                    iconBoxes[4].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Crysis.png");
                    iconNames[4].Text = "Crysis";

                    // Panel 6
                    iconBoxes[5].BackgroundImage = Image.FromFile("C:/Users/joshk/OneDrive/Pictures/Module/_G_Crysis.png");
                    iconNames[5].Text = "Crysis";
                    break;
                default:
                    Console.WriteLine("Tag does not exists");
                    break;
            }
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].Refresh();
            }
        }

        private void navIconDisplay(object sender, EventArgs e)
        {
            navBarIcons[0].BackgroundImage = Image.FromFile(@"C:/Users/joshk/OneDrive/Documents/Rainmeter/Skins/Spectrum V3/@Resources/Images/Icons/Navbar/hexagons.png");
            navBarIcons[1].BackgroundImage = Image.FromFile(@"C:/Users/joshk/OneDrive/Documents/Rainmeter/Skins/Spectrum V3/@Resources/Images/Icons/Navbar/Arc.png");
            navBarIcons[2].BackgroundImage = Image.FromFile(@"C:/Users/joshk/OneDrive/Documents/Rainmeter/Skins/Spectrum V3/@Resources/Images/Icons/Navbar/gamepad.png");
            navBarIcons[3].BackgroundImage = Image.FromFile(@"C:/Users/joshk/OneDrive/Documents/Rainmeter/Skins/Spectrum V3/@Resources/Images/Icons/Navbar/dashboard.png");
        }

        private void screenshot(object sender, EventArgs e)
        {
            activationBar.Visible = false;

            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);


            blurBackground.BackColor = Color.Transparent;
            this.BackgroundImage = bmpScreenshot;
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuClose(object sender, EventArgs e)
        {
            blurBackground.BackColor = this.TransparencyKey;
            navBarMenu = "navBarButton1";

            activationBar.Visible = true;
            gradientBar.Visible = false;
            navMenu.Visible = false;
            animatePanel.Visible = false;
        }
    }
}
