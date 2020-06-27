namespace DesktopSkin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.blurBackground = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Panel();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.animatePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconName6 = new System.Windows.Forms.Button();
            this.iconBox6 = new System.Windows.Forms.Panel();
            this.decorBar6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconName5 = new System.Windows.Forms.Button();
            this.iconBox5 = new System.Windows.Forms.Panel();
            this.decorBar5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconName4 = new System.Windows.Forms.Button();
            this.iconBox4 = new System.Windows.Forms.Panel();
            this.decorBar4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconName3 = new System.Windows.Forms.Button();
            this.iconBox3 = new System.Windows.Forms.Panel();
            this.decorBar3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconName1 = new System.Windows.Forms.Button();
            this.iconBox1 = new System.Windows.Forms.Panel();
            this.decorBar1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconName2 = new System.Windows.Forms.Button();
            this.iconBox2 = new System.Windows.Forms.Panel();
            this.decorBar2 = new System.Windows.Forms.Panel();
            this.gradientBar = new System.Windows.Forms.Panel();
            this.navMenu = new System.Windows.Forms.Panel();
            this.navBarButton2 = new System.Windows.Forms.Panel();
            this.navBarIcon2 = new System.Windows.Forms.Panel();
            this.navBarName2 = new System.Windows.Forms.Button();
            this.navBarButton3 = new System.Windows.Forms.Panel();
            this.navBarIcon3 = new System.Windows.Forms.Panel();
            this.navBarName3 = new System.Windows.Forms.Button();
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Panel();
            this.navBarButton4 = new System.Windows.Forms.Panel();
            this.navBarIcon4 = new System.Windows.Forms.Panel();
            this.navBarName4 = new System.Windows.Forms.Button();
            this.navBarButton1 = new System.Windows.Forms.Panel();
            this.navBarIcon1 = new System.Windows.Forms.Panel();
            this.navBarName1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.activationBar = new System.Windows.Forms.Panel();
            this.blurBackground.SuspendLayout();
            this.clock.SuspendLayout();
            this.animatePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navMenu.SuspendLayout();
            this.navBarButton2.SuspendLayout();
            this.navBarButton3.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            this.navBarButton4.SuspendLayout();
            this.navBarButton1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // blurBackground
            // 
            this.blurBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blurBackground.AutoSize = true;
            this.blurBackground.BackColor = System.Drawing.Color.Magenta;
            this.blurBackground.Controls.Add(this.clock);
            this.blurBackground.Controls.Add(this.animatePanel);
            this.blurBackground.Controls.Add(this.gradientBar);
            this.blurBackground.Controls.Add(this.navMenu);
            this.blurBackground.Controls.Add(this.exitButton);
            this.blurBackground.Controls.Add(this.activationBar);
            this.blurBackground.Location = new System.Drawing.Point(0, 0);
            this.blurBackground.Name = "blurBackground";
            this.blurBackground.Size = new System.Drawing.Size(1920, 1080);
            this.blurBackground.TabIndex = 1;
            // 
            // clock
            // 
            this.clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clock.BackColor = System.Drawing.Color.Transparent;
            this.clock.Controls.Add(this.labelDay);
            this.clock.Controls.Add(this.labelDate);
            this.clock.Controls.Add(this.labelSeconds);
            this.clock.Controls.Add(this.labelTime);
            this.clock.Location = new System.Drawing.Point(650, 24);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(610, 160);
            this.clock.TabIndex = 18;
            this.clock.Visible = false;
            // 
            // labelDay
            // 
            this.labelDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(324, 105);
            this.labelDay.Margin = new System.Windows.Forms.Padding(0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(286, 55);
            this.labelDay.TabIndex = 4;
            this.labelDay.Text = "SATURDAY";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(0, 105);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(311, 55);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Sept 30 2020";
            // 
            // labelSeconds
            // 
            this.labelSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSeconds.ForeColor = System.Drawing.Color.White;
            this.labelSeconds.Location = new System.Drawing.Point(413, 53);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(62, 44);
            this.labelSeconds.TabIndex = 1;
            this.labelSeconds.Text = "22";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(156, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(284, 108);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "22:22";
            // 
            // animatePanel
            // 
            this.animatePanel.BackColor = System.Drawing.Color.Transparent;
            this.animatePanel.Controls.Add(this.panel6);
            this.animatePanel.Controls.Add(this.panel5);
            this.animatePanel.Controls.Add(this.panel4);
            this.animatePanel.Controls.Add(this.panel3);
            this.animatePanel.Controls.Add(this.panel1);
            this.animatePanel.Controls.Add(this.panel2);
            this.animatePanel.Location = new System.Drawing.Point(80, 319);
            this.animatePanel.Name = "animatePanel";
            this.animatePanel.Size = new System.Drawing.Size(1778, 432);
            this.animatePanel.TabIndex = 11;
            this.animatePanel.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.iconName6);
            this.panel6.Controls.Add(this.iconBox6);
            this.panel6.Controls.Add(this.decorBar6);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(1490, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 0, 71, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 432);
            this.panel6.TabIndex = 10;
            this.panel6.Tag = "panel6";
            // 
            // iconName6
            // 
            this.iconName6.BackColor = System.Drawing.Color.Transparent;
            this.iconName6.FlatAppearance.BorderSize = 0;
            this.iconName6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconName6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconName6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconName6.ForeColor = System.Drawing.Color.White;
            this.iconName6.Location = new System.Drawing.Point(0, 281);
            this.iconName6.Margin = new System.Windows.Forms.Padding(0);
            this.iconName6.Name = "iconName6";
            this.iconName6.Size = new System.Drawing.Size(288, 151);
            this.iconName6.TabIndex = 2;
            this.iconName6.Tag = "panel6";
            this.iconName6.UseVisualStyleBackColor = false;
            // 
            // iconBox6
            // 
            this.iconBox6.BackColor = System.Drawing.Color.Transparent;
            this.iconBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox6.Location = new System.Drawing.Point(0, 134);
            this.iconBox6.Name = "iconBox6";
            this.iconBox6.Size = new System.Drawing.Size(288, 144);
            this.iconBox6.TabIndex = 1;
            this.iconBox6.Tag = "panel6";
            // 
            // decorBar6
            // 
            this.decorBar6.BackColor = System.Drawing.Color.White;
            this.decorBar6.Location = new System.Drawing.Point(0, 0);
            this.decorBar6.Name = "decorBar6";
            this.decorBar6.Size = new System.Drawing.Size(288, 10);
            this.decorBar6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.iconName5);
            this.panel5.Controls.Add(this.iconBox5);
            this.panel5.Controls.Add(this.decorBar5);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(1192, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 432);
            this.panel5.TabIndex = 9;
            this.panel5.Tag = "panel5";
            // 
            // iconName5
            // 
            this.iconName5.BackColor = System.Drawing.Color.Transparent;
            this.iconName5.FlatAppearance.BorderSize = 0;
            this.iconName5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconName5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconName5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconName5.ForeColor = System.Drawing.Color.White;
            this.iconName5.Location = new System.Drawing.Point(0, 281);
            this.iconName5.Margin = new System.Windows.Forms.Padding(0);
            this.iconName5.Name = "iconName5";
            this.iconName5.Size = new System.Drawing.Size(288, 151);
            this.iconName5.TabIndex = 2;
            this.iconName5.Tag = "panel5";
            this.iconName5.UseVisualStyleBackColor = false;
            // 
            // iconBox5
            // 
            this.iconBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox5.Location = new System.Drawing.Point(0, 134);
            this.iconBox5.Name = "iconBox5";
            this.iconBox5.Size = new System.Drawing.Size(288, 144);
            this.iconBox5.TabIndex = 1;
            this.iconBox5.Tag = "panel5";
            // 
            // decorBar5
            // 
            this.decorBar5.BackColor = System.Drawing.Color.White;
            this.decorBar5.Location = new System.Drawing.Point(0, 0);
            this.decorBar5.Name = "decorBar5";
            this.decorBar5.Size = new System.Drawing.Size(288, 10);
            this.decorBar5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.iconName4);
            this.panel4.Controls.Add(this.iconBox4);
            this.panel4.Controls.Add(this.decorBar4);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(894, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 432);
            this.panel4.TabIndex = 8;
            this.panel4.Tag = "panel4";
            // 
            // iconName4
            // 
            this.iconName4.BackColor = System.Drawing.Color.Transparent;
            this.iconName4.FlatAppearance.BorderSize = 0;
            this.iconName4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconName4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconName4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconName4.ForeColor = System.Drawing.Color.White;
            this.iconName4.Location = new System.Drawing.Point(0, 281);
            this.iconName4.Margin = new System.Windows.Forms.Padding(0);
            this.iconName4.Name = "iconName4";
            this.iconName4.Size = new System.Drawing.Size(288, 151);
            this.iconName4.TabIndex = 2;
            this.iconName4.Tag = "panel4";
            this.iconName4.UseVisualStyleBackColor = false;
            // 
            // iconBox4
            // 
            this.iconBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox4.Location = new System.Drawing.Point(0, 134);
            this.iconBox4.Name = "iconBox4";
            this.iconBox4.Size = new System.Drawing.Size(288, 144);
            this.iconBox4.TabIndex = 1;
            this.iconBox4.Tag = "panel4";
            // 
            // decorBar4
            // 
            this.decorBar4.BackColor = System.Drawing.Color.White;
            this.decorBar4.Location = new System.Drawing.Point(0, 0);
            this.decorBar4.Name = "decorBar4";
            this.decorBar4.Size = new System.Drawing.Size(288, 10);
            this.decorBar4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.iconName3);
            this.panel3.Controls.Add(this.iconBox3);
            this.panel3.Controls.Add(this.decorBar3);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(596, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 432);
            this.panel3.TabIndex = 7;
            this.panel3.Tag = "panel3";
            // 
            // iconName3
            // 
            this.iconName3.BackColor = System.Drawing.Color.Transparent;
            this.iconName3.FlatAppearance.BorderSize = 0;
            this.iconName3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconName3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconName3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconName3.ForeColor = System.Drawing.Color.White;
            this.iconName3.Location = new System.Drawing.Point(0, 281);
            this.iconName3.Margin = new System.Windows.Forms.Padding(0);
            this.iconName3.Name = "iconName3";
            this.iconName3.Size = new System.Drawing.Size(288, 151);
            this.iconName3.TabIndex = 2;
            this.iconName3.Tag = "panel3";
            this.iconName3.UseVisualStyleBackColor = false;
            // 
            // iconBox3
            // 
            this.iconBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox3.Location = new System.Drawing.Point(0, 134);
            this.iconBox3.Name = "iconBox3";
            this.iconBox3.Size = new System.Drawing.Size(288, 144);
            this.iconBox3.TabIndex = 1;
            this.iconBox3.Tag = "panel3";
            // 
            // decorBar3
            // 
            this.decorBar3.BackColor = System.Drawing.Color.White;
            this.decorBar3.Location = new System.Drawing.Point(0, 0);
            this.decorBar3.Name = "decorBar3";
            this.decorBar3.Size = new System.Drawing.Size(288, 10);
            this.decorBar3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.iconName1);
            this.panel1.Controls.Add(this.iconBox1);
            this.panel1.Controls.Add(this.decorBar1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(71, 0, 5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 432);
            this.panel1.TabIndex = 5;
            this.panel1.Tag = "panel1";
            // 
            // iconName1
            // 
            this.iconName1.BackColor = System.Drawing.Color.Transparent;
            this.iconName1.FlatAppearance.BorderSize = 0;
            this.iconName1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconName1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconName1.ForeColor = System.Drawing.Color.White;
            this.iconName1.Location = new System.Drawing.Point(0, 281);
            this.iconName1.Margin = new System.Windows.Forms.Padding(0);
            this.iconName1.Name = "iconName1";
            this.iconName1.Size = new System.Drawing.Size(288, 147);
            this.iconName1.TabIndex = 2;
            this.iconName1.Tag = "panel1";
            this.iconName1.UseVisualStyleBackColor = false;
            // 
            // iconBox1
            // 
            this.iconBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox1.Location = new System.Drawing.Point(0, 134);
            this.iconBox1.Name = "iconBox1";
            this.iconBox1.Size = new System.Drawing.Size(288, 144);
            this.iconBox1.TabIndex = 1;
            this.iconBox1.Tag = "panel1";
            // 
            // decorBar1
            // 
            this.decorBar1.BackColor = System.Drawing.Color.White;
            this.decorBar1.Location = new System.Drawing.Point(0, 0);
            this.decorBar1.Name = "decorBar1";
            this.decorBar1.Size = new System.Drawing.Size(288, 10);
            this.decorBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.iconName2);
            this.panel2.Controls.Add(this.iconBox2);
            this.panel2.Controls.Add(this.decorBar2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(298, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 432);
            this.panel2.TabIndex = 4;
            this.panel2.Tag = "panel2";
            // 
            // iconName2
            // 
            this.iconName2.BackColor = System.Drawing.Color.Transparent;
            this.iconName2.FlatAppearance.BorderSize = 0;
            this.iconName2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconName2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconName2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconName2.ForeColor = System.Drawing.Color.White;
            this.iconName2.Location = new System.Drawing.Point(0, 281);
            this.iconName2.Margin = new System.Windows.Forms.Padding(0);
            this.iconName2.Name = "iconName2";
            this.iconName2.Size = new System.Drawing.Size(288, 151);
            this.iconName2.TabIndex = 2;
            this.iconName2.Tag = "panel2";
            this.iconName2.UseVisualStyleBackColor = false;
            // 
            // iconBox2
            // 
            this.iconBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox2.Location = new System.Drawing.Point(0, 134);
            this.iconBox2.Name = "iconBox2";
            this.iconBox2.Size = new System.Drawing.Size(288, 144);
            this.iconBox2.TabIndex = 1;
            this.iconBox2.Tag = "panel2";
            // 
            // decorBar2
            // 
            this.decorBar2.BackColor = System.Drawing.Color.White;
            this.decorBar2.Location = new System.Drawing.Point(0, 0);
            this.decorBar2.Name = "decorBar2";
            this.decorBar2.Size = new System.Drawing.Size(288, 10);
            this.decorBar2.TabIndex = 0;
            // 
            // gradientBar
            // 
            this.gradientBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientBar.BackColor = System.Drawing.Color.White;
            this.gradientBar.Location = new System.Drawing.Point(80, 199);
            this.gradientBar.Name = "gradientBar";
            this.gradientBar.Size = new System.Drawing.Size(1778, 10);
            this.gradientBar.TabIndex = 10;
            this.gradientBar.Visible = false;
            // 
            // navMenu
            // 
            this.navMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navMenu.BackColor = System.Drawing.Color.Transparent;
            this.navMenu.Controls.Add(this.navBarButton2);
            this.navMenu.Controls.Add(this.navBarButton3);
            this.navMenu.Controls.Add(this.navBarPanel);
            this.navMenu.Controls.Add(this.navBarButton4);
            this.navMenu.Controls.Add(this.navBarButton1);
            this.navMenu.Location = new System.Drawing.Point(80, 228);
            this.navMenu.Margin = new System.Windows.Forms.Padding(0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(1778, 54);
            this.navMenu.TabIndex = 9;
            this.navMenu.Visible = false;
            // 
            // navBarButton2
            // 
            this.navBarButton2.BackColor = System.Drawing.Color.Black;
            this.navBarButton2.Controls.Add(this.navBarIcon2);
            this.navBarButton2.Controls.Add(this.navBarName2);
            this.navBarButton2.Location = new System.Drawing.Point(160, 0);
            this.navBarButton2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navBarButton2.Name = "navBarButton2";
            this.navBarButton2.Size = new System.Drawing.Size(150, 54);
            this.navBarButton2.TabIndex = 16;
            this.navBarButton2.Tag = "navBarButton2";
            // 
            // navBarIcon2
            // 
            this.navBarIcon2.BackColor = System.Drawing.Color.Transparent;
            this.navBarIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navBarIcon2.Location = new System.Drawing.Point(0, 0);
            this.navBarIcon2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navBarIcon2.Name = "navBarIcon2";
            this.navBarIcon2.Size = new System.Drawing.Size(54, 54);
            this.navBarIcon2.TabIndex = 2;
            this.navBarIcon2.Tag = "navBarButton2";
            // 
            // navBarName2
            // 
            this.navBarName2.BackColor = System.Drawing.Color.Transparent;
            this.navBarName2.FlatAppearance.BorderSize = 0;
            this.navBarName2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.navBarName2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.navBarName2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBarName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.navBarName2.ForeColor = System.Drawing.Color.White;
            this.navBarName2.Location = new System.Drawing.Point(75, 0);
            this.navBarName2.Margin = new System.Windows.Forms.Padding(0);
            this.navBarName2.Name = "navBarName2";
            this.navBarName2.Size = new System.Drawing.Size(75, 54);
            this.navBarName2.TabIndex = 1;
            this.navBarName2.Tag = "navBarButton2";
            this.navBarName2.Text = "02";
            this.navBarName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.navBarName2.UseVisualStyleBackColor = false;
            // 
            // navBarButton3
            // 
            this.navBarButton3.BackColor = System.Drawing.Color.Black;
            this.navBarButton3.Controls.Add(this.navBarIcon3);
            this.navBarButton3.Controls.Add(this.navBarName3);
            this.navBarButton3.Location = new System.Drawing.Point(320, 0);
            this.navBarButton3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navBarButton3.Name = "navBarButton3";
            this.navBarButton3.Size = new System.Drawing.Size(150, 54);
            this.navBarButton3.TabIndex = 14;
            this.navBarButton3.Tag = "navBarButton3";
            // 
            // navBarIcon3
            // 
            this.navBarIcon3.BackColor = System.Drawing.Color.Transparent;
            this.navBarIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navBarIcon3.Location = new System.Drawing.Point(0, 0);
            this.navBarIcon3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navBarIcon3.Name = "navBarIcon3";
            this.navBarIcon3.Size = new System.Drawing.Size(54, 54);
            this.navBarIcon3.TabIndex = 2;
            this.navBarIcon3.Tag = "navBarButton3";
            // 
            // navBarName3
            // 
            this.navBarName3.BackColor = System.Drawing.Color.Transparent;
            this.navBarName3.FlatAppearance.BorderSize = 0;
            this.navBarName3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.navBarName3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.navBarName3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBarName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.navBarName3.ForeColor = System.Drawing.Color.White;
            this.navBarName3.Location = new System.Drawing.Point(75, 0);
            this.navBarName3.Margin = new System.Windows.Forms.Padding(0);
            this.navBarName3.Name = "navBarName3";
            this.navBarName3.Size = new System.Drawing.Size(75, 54);
            this.navBarName3.TabIndex = 1;
            this.navBarName3.Tag = "navBarButton3";
            this.navBarName3.Text = "03";
            this.navBarName3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.navBarName3.UseVisualStyleBackColor = false;
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.Black;
            this.navBarPanel.Controls.Add(this.settings);
            this.navBarPanel.Location = new System.Drawing.Point(641, 0);
            this.navBarPanel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(1137, 54);
            this.navBarPanel.TabIndex = 13;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings.Location = new System.Drawing.Point(1083, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(54, 54);
            this.settings.TabIndex = 3;
            // 
            // navBarButton4
            // 
            this.navBarButton4.BackColor = System.Drawing.Color.Black;
            this.navBarButton4.Controls.Add(this.navBarIcon4);
            this.navBarButton4.Controls.Add(this.navBarName4);
            this.navBarButton4.Location = new System.Drawing.Point(481, 0);
            this.navBarButton4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navBarButton4.Name = "navBarButton4";
            this.navBarButton4.Size = new System.Drawing.Size(150, 54);
            this.navBarButton4.TabIndex = 12;
            this.navBarButton4.Tag = "navBarButton4";
            // 
            // navBarIcon4
            // 
            this.navBarIcon4.BackColor = System.Drawing.Color.Transparent;
            this.navBarIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navBarIcon4.Location = new System.Drawing.Point(0, 0);
            this.navBarIcon4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navBarIcon4.Name = "navBarIcon4";
            this.navBarIcon4.Size = new System.Drawing.Size(54, 54);
            this.navBarIcon4.TabIndex = 2;
            this.navBarIcon4.Tag = "navBarButton4";
            // 
            // navBarName4
            // 
            this.navBarName4.BackColor = System.Drawing.Color.Transparent;
            this.navBarName4.FlatAppearance.BorderSize = 0;
            this.navBarName4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.navBarName4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.navBarName4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBarName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.navBarName4.ForeColor = System.Drawing.Color.White;
            this.navBarName4.Location = new System.Drawing.Point(75, 0);
            this.navBarName4.Margin = new System.Windows.Forms.Padding(0);
            this.navBarName4.Name = "navBarName4";
            this.navBarName4.Size = new System.Drawing.Size(75, 54);
            this.navBarName4.TabIndex = 1;
            this.navBarName4.Tag = "navBarButton4";
            this.navBarName4.Text = "04";
            this.navBarName4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.navBarName4.UseVisualStyleBackColor = false;
            // 
            // navBarButton1
            // 
            this.navBarButton1.BackColor = System.Drawing.Color.Black;
            this.navBarButton1.Controls.Add(this.navBarIcon1);
            this.navBarButton1.Controls.Add(this.navBarName1);
            this.navBarButton1.Location = new System.Drawing.Point(0, 0);
            this.navBarButton1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.navBarButton1.Name = "navBarButton1";
            this.navBarButton1.Size = new System.Drawing.Size(150, 54);
            this.navBarButton1.TabIndex = 9;
            this.navBarButton1.Tag = "navBarButton1";
            // 
            // navBarIcon1
            // 
            this.navBarIcon1.BackColor = System.Drawing.Color.Transparent;
            this.navBarIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navBarIcon1.Location = new System.Drawing.Point(0, 0);
            this.navBarIcon1.Margin = new System.Windows.Forms.Padding(0);
            this.navBarIcon1.Name = "navBarIcon1";
            this.navBarIcon1.Size = new System.Drawing.Size(54, 54);
            this.navBarIcon1.TabIndex = 2;
            this.navBarIcon1.Tag = "navBarButton1";
            // 
            // navBarName1
            // 
            this.navBarName1.BackColor = System.Drawing.Color.Transparent;
            this.navBarName1.FlatAppearance.BorderSize = 0;
            this.navBarName1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.navBarName1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.navBarName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBarName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.navBarName1.ForeColor = System.Drawing.Color.White;
            this.navBarName1.Location = new System.Drawing.Point(75, 0);
            this.navBarName1.Margin = new System.Windows.Forms.Padding(0);
            this.navBarName1.Name = "navBarName1";
            this.navBarName1.Size = new System.Drawing.Size(75, 54);
            this.navBarName1.TabIndex = 1;
            this.navBarName1.Tag = "navBarButton1";
            this.navBarName1.Text = "01";
            this.navBarName1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.navBarName1.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exitButton.Location = new System.Drawing.Point(1366, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 78);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // activationBar
            // 
            this.activationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activationBar.BackColor = System.Drawing.Color.White;
            this.activationBar.Location = new System.Drawing.Point(0, 0);
            this.activationBar.Name = "activationBar";
            this.activationBar.Size = new System.Drawing.Size(1500, 1);
            this.activationBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.blurBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.blurBackground.ResumeLayout(false);
            this.clock.ResumeLayout(false);
            this.clock.PerformLayout();
            this.animatePanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.navMenu.ResumeLayout(false);
            this.navBarButton2.ResumeLayout(false);
            this.navBarButton3.ResumeLayout(false);
            this.navBarPanel.ResumeLayout(false);
            this.navBarButton4.ResumeLayout(false);
            this.navBarButton1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Panel blurBackground;
        private System.Windows.Forms.Panel clock;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel animatePanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button iconName6;
        private System.Windows.Forms.Panel iconBox6;
        private System.Windows.Forms.Panel decorBar6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button iconName5;
        private System.Windows.Forms.Panel iconBox5;
        private System.Windows.Forms.Panel decorBar5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button iconName4;
        private System.Windows.Forms.Panel iconBox4;
        private System.Windows.Forms.Panel decorBar4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button iconName3;
        private System.Windows.Forms.Panel iconBox3;
        private System.Windows.Forms.Panel decorBar3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button iconName1;
        private System.Windows.Forms.Panel iconBox1;
        private System.Windows.Forms.Panel decorBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button iconName2;
        private System.Windows.Forms.Panel iconBox2;
        private System.Windows.Forms.Panel decorBar2;
        private System.Windows.Forms.Panel gradientBar;
        private System.Windows.Forms.Panel navMenu;
        private System.Windows.Forms.Panel navBarButton2;
        private System.Windows.Forms.Panel navBarIcon2;
        private System.Windows.Forms.Button navBarName2;
        private System.Windows.Forms.Panel navBarButton3;
        private System.Windows.Forms.Panel navBarIcon3;
        private System.Windows.Forms.Button navBarName3;
        private System.Windows.Forms.Panel navBarPanel;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Panel navBarButton4;
        private System.Windows.Forms.Panel navBarIcon4;
        private System.Windows.Forms.Button navBarName4;
        private System.Windows.Forms.Panel navBarButton1;
        private System.Windows.Forms.Panel navBarIcon1;
        private System.Windows.Forms.Button navBarName1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel activationBar;
    }
}

