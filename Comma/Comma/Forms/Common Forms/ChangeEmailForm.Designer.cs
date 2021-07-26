
namespace Comma.Forms.Common_Forms
{
    partial class ChangeEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeEmailForm));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.confirmNewEmailTxt = new System.Windows.Forms.TextBox();
            this.newEmailTxt = new System.Windows.Forms.TextBox();
            this.changeEmailBtn = new System.Windows.Forms.Button();
            this.confirmNewEmailLbl = new System.Windows.Forms.Label();
            this.newEmailLbl = new System.Windows.Forms.Label();
            this.oldEmailTxt = new System.Windows.Forms.TextBox();
            this.oldEmailLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.containerPanel.Controls.Add(this.confirmNewEmailTxt);
            this.containerPanel.Controls.Add(this.newEmailTxt);
            this.containerPanel.Controls.Add(this.changeEmailBtn);
            this.containerPanel.Controls.Add(this.confirmNewEmailLbl);
            this.containerPanel.Controls.Add(this.newEmailLbl);
            this.containerPanel.Controls.Add(this.oldEmailTxt);
            this.containerPanel.Controls.Add(this.oldEmailLbl);
            this.containerPanel.Location = new System.Drawing.Point(112, 200);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(381, 328);
            this.containerPanel.TabIndex = 13;
            // 
            // confirmNewEmailTxt
            // 
            this.confirmNewEmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmNewEmailTxt.Location = new System.Drawing.Point(62, 216);
            this.confirmNewEmailTxt.Name = "confirmNewEmailTxt";
            this.confirmNewEmailTxt.Size = new System.Drawing.Size(264, 26);
            this.confirmNewEmailTxt.TabIndex = 3;
            this.confirmNewEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newEmailTxt
            // 
            this.newEmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newEmailTxt.Location = new System.Drawing.Point(62, 145);
            this.newEmailTxt.Name = "newEmailTxt";
            this.newEmailTxt.Size = new System.Drawing.Size(264, 26);
            this.newEmailTxt.TabIndex = 2;
            this.newEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeEmailBtn
            // 
            this.changeEmailBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changeEmailBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.changeEmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeEmailBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeEmailBtn.FlatAppearance.BorderSize = 0;
            this.changeEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEmailBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmailBtn.ForeColor = System.Drawing.Color.Crimson;
            this.changeEmailBtn.Location = new System.Drawing.Point(119, 272);
            this.changeEmailBtn.Name = "changeEmailBtn";
            this.changeEmailBtn.Size = new System.Drawing.Size(151, 35);
            this.changeEmailBtn.TabIndex = 4;
            this.changeEmailBtn.Text = "Change E-mail";
            this.changeEmailBtn.UseVisualStyleBackColor = false;
            this.changeEmailBtn.Click += new System.EventHandler(this.changeEmailBtn_Click);
            // 
            // confirmNewEmailLbl
            // 
            this.confirmNewEmailLbl.AutoSize = true;
            this.confirmNewEmailLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewEmailLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.confirmNewEmailLbl.Location = new System.Drawing.Point(91, 183);
            this.confirmNewEmailLbl.Name = "confirmNewEmailLbl";
            this.confirmNewEmailLbl.Size = new System.Drawing.Size(207, 23);
            this.confirmNewEmailLbl.TabIndex = 5;
            this.confirmNewEmailLbl.Text = "CONFIRM NEW E-MAIL";
            // 
            // newEmailLbl
            // 
            this.newEmailLbl.AutoSize = true;
            this.newEmailLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmailLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.newEmailLbl.Location = new System.Drawing.Point(134, 112);
            this.newEmailLbl.Name = "newEmailLbl";
            this.newEmailLbl.Size = new System.Drawing.Size(121, 23);
            this.newEmailLbl.TabIndex = 2;
            this.newEmailLbl.Text = "NEW E-MAIL";
            // 
            // oldEmailTxt
            // 
            this.oldEmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldEmailTxt.Location = new System.Drawing.Point(62, 74);
            this.oldEmailTxt.Name = "oldEmailTxt";
            this.oldEmailTxt.Size = new System.Drawing.Size(264, 26);
            this.oldEmailTxt.TabIndex = 1;
            this.oldEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldEmailLbl
            // 
            this.oldEmailLbl.AutoSize = true;
            this.oldEmailLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldEmailLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.oldEmailLbl.Location = new System.Drawing.Point(137, 41);
            this.oldEmailLbl.Name = "oldEmailLbl";
            this.oldEmailLbl.Size = new System.Drawing.Size(115, 23);
            this.oldEmailLbl.TabIndex = 0;
            this.oldEmailLbl.Text = "OLD E-MAIL";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(191, 120);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "   CHANGE E-MAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeEmailForm";
            this.Text = "ChangeEmailForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeEmailForm_FormClosing);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button changeEmailBtn;
        private System.Windows.Forms.Label confirmNewEmailLbl;
        private System.Windows.Forms.Label newEmailLbl;
        private System.Windows.Forms.TextBox oldEmailTxt;
        private System.Windows.Forms.Label oldEmailLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmNewEmailTxt;
        private System.Windows.Forms.TextBox newEmailTxt;
    }
}