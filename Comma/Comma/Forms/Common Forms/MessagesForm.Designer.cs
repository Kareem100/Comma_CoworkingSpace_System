
namespace Comma.Forms.Common_Forms
{
    partial class MessagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerIDLbl = new System.Windows.Forms.Label();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.messageLbl = new System.Windows.Forms.Label();
            this.toCmb = new System.Windows.Forms.ComboBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.fromLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(224, 90);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "   MESSAGES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.customerIDLbl);
            this.panel1.Controls.Add(this.sendMessageBtn);
            this.panel1.Controls.Add(this.messageTxt);
            this.panel1.Controls.Add(this.messageLbl);
            this.panel1.Controls.Add(this.toCmb);
            this.panel1.Controls.Add(this.toLbl);
            this.panel1.Controls.Add(this.fromTxt);
            this.panel1.Controls.Add(this.fromLbl);
            this.panel1.Location = new System.Drawing.Point(120, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 400);
            this.panel1.TabIndex = 11;
            // 
            // customerIDLbl
            // 
            this.customerIDLbl.AutoSize = true;
            this.customerIDLbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLbl.ForeColor = System.Drawing.Color.Crimson;
            this.customerIDLbl.Location = new System.Drawing.Point(207, 113);
            this.customerIDLbl.Name = "customerIDLbl";
            this.customerIDLbl.Size = new System.Drawing.Size(83, 15);
            this.customerIDLbl.TabIndex = 14;
            this.customerIDLbl.Text = "(Customer ID)";
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendMessageBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.sendMessageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendMessageBtn.FlatAppearance.BorderSize = 0;
            this.sendMessageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessageBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageBtn.ForeColor = System.Drawing.Color.Crimson;
            this.sendMessageBtn.Location = new System.Drawing.Point(119, 353);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(151, 35);
            this.sendMessageBtn.TabIndex = 13;
            this.sendMessageBtn.Text = "Send Message";
            this.sendMessageBtn.UseVisualStyleBackColor = false;
            this.sendMessageBtn.Click += new System.EventHandler(this.sendMessageBtn_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTxt.Location = new System.Drawing.Point(62, 206);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(264, 128);
            this.messageTxt.TabIndex = 6;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.messageLbl.Location = new System.Drawing.Point(135, 172);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(106, 27);
            this.messageLbl.TabIndex = 5;
            this.messageLbl.Text = "MESSAGE";
            // 
            // toCmb
            // 
            this.toCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toCmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toCmb.FormattingEnabled = true;
            this.toCmb.Location = new System.Drawing.Point(62, 138);
            this.toCmb.Name = "toCmb";
            this.toCmb.Size = new System.Drawing.Size(264, 27);
            this.toCmb.TabIndex = 4;
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.toLbl.Location = new System.Drawing.Point(168, 104);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(40, 27);
            this.toLbl.TabIndex = 2;
            this.toLbl.Text = "TO";
            // 
            // fromTxt
            // 
            this.fromTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTxt.Enabled = false;
            this.fromTxt.Location = new System.Drawing.Point(62, 71);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(264, 26);
            this.fromTxt.TabIndex = 1;
            this.fromTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.fromLbl.Location = new System.Drawing.Point(154, 37);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(68, 27);
            this.fromLbl.TabIndex = 0;
            this.fromLbl.Text = "FROM";
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MessagesForm";
            this.Text = "MessagesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessagesForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.ComboBox toCmb;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button sendMessageBtn;
        private System.Windows.Forms.Label customerIDLbl;
    }
}