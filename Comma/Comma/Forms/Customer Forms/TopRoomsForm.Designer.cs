namespace Comma
{
    partial class TopRoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopRoomsForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelRoom2Container = new System.Windows.Forms.Panel();
            this.panelRoom1Container = new System.Windows.Forms.Panel();
            this.panelRoom3Container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(215, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(175, 31);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "   TOP ROOMS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRoom2Container
            // 
            this.panelRoom2Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelRoom2Container.Location = new System.Drawing.Point(28, 220);
            this.panelRoom2Container.Name = "panelRoom2Container";
            this.panelRoom2Container.Size = new System.Drawing.Size(340, 500);
            this.panelRoom2Container.TabIndex = 8;
            // 
            // panelRoom1Container
            // 
            this.panelRoom1Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelRoom1Container.Location = new System.Drawing.Point(415, 160);
            this.panelRoom1Container.Name = "panelRoom1Container";
            this.panelRoom1Container.Size = new System.Drawing.Size(340, 500);
            this.panelRoom1Container.TabIndex = 9;
            // 
            // panelRoom3Container
            // 
            this.panelRoom3Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelRoom3Container.Location = new System.Drawing.Point(800, 220);
            this.panelRoom3Container.Name = "panelRoom3Container";
            this.panelRoom3Container.Size = new System.Drawing.Size(340, 500);
            this.panelRoom3Container.TabIndex = 10;
            // 
            // TopRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.panelRoom3Container);
            this.Controls.Add(this.panelRoom1Container);
            this.Controls.Add(this.panelRoom2Container);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopRoomsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopRoomsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelRoom2Container;
        private System.Windows.Forms.Panel panelRoom1Container;
        private System.Windows.Forms.Panel panelRoom3Container;
    }
}