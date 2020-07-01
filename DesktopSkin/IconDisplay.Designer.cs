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
            this.iconName = new System.Windows.Forms.Button();
            this.DisplayIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.iconName.Size = new System.Drawing.Size(144, 21);
            this.iconName.TabIndex = 4;
            this.iconName.Text = "iconName_";
            this.iconName.UseVisualStyleBackColor = false;
            // 
            // DisplayIcon
            // 
            this.DisplayIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisplayIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayIcon.FlatAppearance.BorderSize = 0;
            this.DisplayIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisplayIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayIcon.Location = new System.Drawing.Point(0, 21);
            this.DisplayIcon.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayIcon.Name = "DisplayIcon";
            this.DisplayIcon.Size = new System.Drawing.Size(144, 144);
            this.DisplayIcon.TabIndex = 5;
            this.DisplayIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DisplayIcon.UseVisualStyleBackColor = true;
            // 
            // IconDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayIcon);
            this.Controls.Add(this.iconName);
            this.Name = "IconDisplay";
            this.Size = new System.Drawing.Size(144, 160);
            this.Load += new System.EventHandler(this.IconDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button iconName;
        private System.Windows.Forms.Button DisplayIcon;
    }
}
