namespace Comma.Forms.Admin_Forms
{
    partial class DisplayRoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayRoomsForm));
            this.titleLbl = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Goldenrod;
            this.titleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Green;
            this.titleLbl.Image = ((System.Drawing.Image)(resources.GetObject("titleLbl.Image")));
            this.titleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLbl.Location = new System.Drawing.Point(236, 90);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLbl.Size = new System.Drawing.Size(123, 31);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "   ROOMS";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.AutoScroll = true;
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.containerPanel.Location = new System.Drawing.Point(28, 160);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.containerPanel.Size = new System.Drawing.Size(544, 540);
            this.containerPanel.TabIndex = 13;
            // 
            // DisplayRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.containerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayRoomsForm";
            this.Text = "DisplayRoomsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayRoomsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.FlowLayoutPanel containerPanel;
    }
}