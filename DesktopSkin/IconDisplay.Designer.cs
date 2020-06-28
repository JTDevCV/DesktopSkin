namespace DesktopSkin
{
    partial class IconDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DisplayIcon = new System.Windows.Forms.Button();
            this.iconName = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.iconName);
            this.flowLayoutPanel1.Controls.Add(this.DisplayIcon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 175);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // DisplayIcon
            // 
            this.DisplayIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisplayIcon.FlatAppearance.BorderSize = 0;
            this.DisplayIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisplayIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisplayIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayIcon.Location = new System.Drawing.Point(0, 30);
            this.DisplayIcon.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayIcon.Name = "DisplayIcon";
            this.DisplayIcon.Size = new System.Drawing.Size(144, 144);
            this.DisplayIcon.TabIndex = 9;
            this.DisplayIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DisplayIcon.UseVisualStyleBackColor = true;
            // 
            // iconName
            // 
            this.iconName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconName.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconName.FlatAppearance.BorderSize = 0;
            this.iconName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconName.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.iconName.ForeColor = System.Drawing.Color.White;
            this.iconName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconName.Location = new System.Drawing.Point(0, 0);
            this.iconName.Margin = new System.Windows.Forms.Padding(0);
            this.iconName.Name = "iconName";
            this.iconName.Size = new System.Drawing.Size(144, 30);
            this.iconName.TabIndex = 10;
            this.iconName.Text = "iconName";
            this.iconName.UseVisualStyleBackColor = false;
            // 
            // IconDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "IconDisplay";
            this.Size = new System.Drawing.Size(144, 175);
            this.Load += new System.EventHandler(this.IconDisplay_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button iconName;
        private System.Windows.Forms.Button DisplayIcon;
    }
}
