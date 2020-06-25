namespace DesktopSkin
{
    partial class IconHolder
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
            this.iconName_Gal = new System.Windows.Forms.Button();
            this.icon_Gal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // iconName_Gal
            // 
            this.iconName_Gal.BackColor = System.Drawing.Color.White;
            this.iconName_Gal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconName_Gal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName_Gal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.iconName_Gal.ForeColor = System.Drawing.Color.Black;
            this.iconName_Gal.Location = new System.Drawing.Point(0, 144);
            this.iconName_Gal.Margin = new System.Windows.Forms.Padding(0);
            this.iconName_Gal.Name = "iconName_Gal";
            this.iconName_Gal.Size = new System.Drawing.Size(144, 24);
            this.iconName_Gal.TabIndex = 3;
            this.iconName_Gal.Text = "iconName";
            this.iconName_Gal.UseVisualStyleBackColor = false;
            // 
            // icon_Gal
            // 
            this.icon_Gal.BackColor = System.Drawing.Color.Transparent;
            this.icon_Gal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icon_Gal.Dock = System.Windows.Forms.DockStyle.Top;
            this.icon_Gal.Location = new System.Drawing.Point(0, 0);
            this.icon_Gal.Margin = new System.Windows.Forms.Padding(0);
            this.icon_Gal.Name = "icon_Gal";
            this.icon_Gal.Size = new System.Drawing.Size(144, 144);
            this.icon_Gal.TabIndex = 8;
            // 
            // IconHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.icon_Gal);
            this.Controls.Add(this.iconName_Gal);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Name = "IconHolder";
            this.Size = new System.Drawing.Size(144, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iconName_Gal;
        private System.Windows.Forms.Panel icon_Gal;
    }
}
