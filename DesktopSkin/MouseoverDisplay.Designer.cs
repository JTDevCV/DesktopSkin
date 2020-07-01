namespace DesktopSkin
{
    partial class MouseoverDisplay
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
            this.filenameDisplayBox = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filenameDisplayBox
            // 
            this.filenameDisplayBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.filenameDisplayBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.filenameDisplayBox.FlatAppearance.BorderSize = 0;
            this.filenameDisplayBox.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.filenameDisplayBox.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.filenameDisplayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filenameDisplayBox.ForeColor = System.Drawing.Color.White;
            this.filenameDisplayBox.Location = new System.Drawing.Point(0, 0);
            this.filenameDisplayBox.Name = "filenameDisplayBox";
            this.filenameDisplayBox.Size = new System.Drawing.Size(288, 21);
            this.filenameDisplayBox.TabIndex = 0;
            this.filenameDisplayBox.Text = "_Mouseover_Filename";
            this.filenameDisplayBox.UseVisualStyleBackColor = false;
            // 
            // displayBox
            // 
            this.displayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.displayBox.Location = new System.Drawing.Point(0, 21);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(288, 411);
            this.displayBox.TabIndex = 2;
            this.displayBox.UseVisualStyleBackColor = true;
            // 
            // MouseoverDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.filenameDisplayBox);
            this.Name = "MouseoverDisplay";
            this.Size = new System.Drawing.Size(288, 432);
            this.Load += new System.EventHandler(this.MouseoverDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filenameDisplayBox;
        private System.Windows.Forms.Button displayBox;
    }
}
