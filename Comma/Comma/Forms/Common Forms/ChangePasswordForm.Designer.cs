
namespace Comma.Forms.Common_Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.confirmNewPasswordTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.confirmNewPasswordLbl = new System.Windows.Forms.Label();
            this.newPasswordLbl = new System.Windows.Forms.Label();
            this.oldPasswordTxt = new System.Windows.Forms.TextBox();
            this.oldPasswordLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.containerPanel.Controls.Add(this.confirmNewPasswordTxt);
            this.containerPanel.Controls.Add(this.newPasswordTxt);
            this.containerPanel.Controls.Add(this.changePasswordBtn);
            this.containerPanel.Controls.Add(this.confirmNewPasswordLbl);
            this.containerPanel.Controls.Add(this.newPasswordLbl);
            this.containerPanel.Controls.Add(this.oldPasswordTxt);
            this.containerPanel.Controls.Add(this.oldPasswordLbl);
            this.containerPanel.Location = new System.Drawing.Point(113, 200);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(381, 328);
            this.containerPanel.TabIndex = 15;
            // 
            // confirmNewPasswordTxt
            // 
            this.confirmNewPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmNewPasswordTxt.Location = new System.Drawing.Point(62, 216);
            this.confirmNewPasswordTxt.Name = "confirmNewPasswordTxt";
            this.confirmNewPasswordTxt.Size = new System.Drawing.Size(264, 30);
            this.confirmNewPasswordTxt.TabIndex = 3;
            this.confirmNewPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTxt.Location = new System.Drawing.Point(62, 145);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.Size = new System.Drawing.Size(264, 30);
            this.newPasswordTxt.TabIndex = 2;
            this.newPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changePasswordBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changePasswordBtn.FlatAppearance.BorderSize = 0;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.Crimson;
            this.changePasswordBtn.Location = new System.Drawing.Point(119, 272);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(151, 35);
            this.changePasswordBtn.TabIndex = 4;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // confirmNewPasswordLbl
            // 
            this.confirmNewPasswordLbl.AutoSize = true;
            this.confirmNewPasswordLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.confirmNewPasswordLbl.Location = new System.Drawing.Point(75, 183);
            this.confirmNewPasswordLbl.Name = "confirmNewPasswordLbl";
            this.confirmNewPasswordLbl.Size = new System.Drawing.Size(238, 23);
            this.confirmNewPasswordLbl.TabIndex = 5;
            this.confirmNewPasswordLbl.Text = "CONFIRM NEW PASSWORD";
            // 
            // newPasswordLbl
            // 
            this.newPasswordLbl.AutoSize = true;
            this.newPasswordLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.newPasswordLbl.Location = new System.Drawing.Point(118, 112);
            this.newPasswordLbl.Name = "newPasswordLbl";
            this.newPasswordLbl.Size = new System.Drawing.Size(152, 23);
            this.newPasswordLbl.TabIndex = 2;
            this.newPasswordLbl.Text = "NEW PASSWORD";
            // 
            // oldPasswordTxt
            // 
            this.oldPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTxt.Location = new System.Drawing.Point(62, 74);
            this.oldPasswordTxt.Name = "oldPasswordTxt";
            this.oldPasswordTxt.Size = new System.Drawing.Size(264, 30);
            this.oldPasswordTxt.TabIndex = 1;
            this.oldPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldPasswordLbl
            // 
            this.oldPasswordLbl.AutoSize = true;
            this.oldPasswordLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.oldPasswordLbl.Location = new System.Drawing.Point(121, 41);
            this.oldPasswordLbl.Name = "oldPasswordLbl";
            this.oldPasswordLbl.Size = new System.Drawing.Size(146, 23);
            this.oldPasswordLbl.TabIndex = 0;
            this.oldPasswordLbl.Text = "OLD PASSWORD";
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Goldenrod;
            this.titleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Image = ((System.Drawing.Image)(resources.GetObject("titleLbl.Image")));
            this.titleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLbl.Location = new System.Drawing.Point(172, 120);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLbl.Size = new System.Drawing.Size(262, 31);
            this.titleLbl.TabIndex = 14;
            this.titleLbl.Text = "   CHANGE PASSWORD";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePasswordForm_FormClosing);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.TextBox confirmNewPasswordTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label confirmNewPasswordLbl;
        private System.Windows.Forms.Label newPasswordLbl;
        private System.Windows.Forms.TextBox oldPasswordTxt;
        private System.Windows.Forms.Label oldPasswordLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}