namespace Comma.Forms.Admin_Forms
{
    partial class RentInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentInformationForm));
            this.declineBtn = new System.Windows.Forms.Button();
            this.responseGroupBox = new System.Windows.Forms.GroupBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.roomGroupBox = new System.Windows.Forms.GroupBox();
            this.capacityGroupBox = new System.Windows.Forms.GroupBox();
            this.guestsLbl = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.hourTo = new System.Windows.Forms.Label();
            this.dayTo = new System.Windows.Forms.Label();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.hourFrom = new System.Windows.Forms.Label();
            this.dayFrom = new System.Windows.Forms.Label();
            this.requestsGroupBox = new System.Windows.Forms.GroupBox();
            this.customerAdditionalRequests = new System.Windows.Forms.Label();
            this.hashLbl = new System.Windows.Forms.Label();
            this.roomID = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.Label();
            this.roomImage = new System.Windows.Forms.PictureBox();
            this.userMailLbl = new System.Windows.Forms.Label();
            this.userPhoneLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.responseGroupBox.SuspendLayout();
            this.roomGroupBox.SuspendLayout();
            this.capacityGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.fromGroupBox.SuspendLayout();
            this.requestsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).BeginInit();
            this.userGroupBox.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // declineBtn
            // 
            this.declineBtn.BackColor = System.Drawing.Color.Transparent;
            this.declineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.declineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineBtn.ForeColor = System.Drawing.Color.Crimson;
            this.declineBtn.Location = new System.Drawing.Point(150, 33);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(126, 37);
            this.declineBtn.TabIndex = 1;
            this.declineBtn.Text = "DECLINE";
            this.declineBtn.UseVisualStyleBackColor = false;
            this.declineBtn.Click += new System.EventHandler(this.declineBtn_Click);
            this.declineBtn.MouseEnter += new System.EventHandler(this.declineBtn_MouseEnter);
            this.declineBtn.MouseLeave += new System.EventHandler(this.declineBtn_MouseLeave);
            // 
            // responseGroupBox
            // 
            this.responseGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.responseGroupBox.Controls.Add(this.declineBtn);
            this.responseGroupBox.Controls.Add(this.acceptBtn);
            this.responseGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.responseGroupBox.Location = new System.Drawing.Point(342, 396);
            this.responseGroupBox.Name = "responseGroupBox";
            this.responseGroupBox.Size = new System.Drawing.Size(284, 97);
            this.responseGroupBox.TabIndex = 22;
            this.responseGroupBox.TabStop = false;
            this.responseGroupBox.Text = "Response";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Location = new System.Drawing.Point(18, 33);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(126, 37);
            this.acceptBtn.TabIndex = 0;
            this.acceptBtn.Text = "ACCEPT";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            this.acceptBtn.MouseEnter += new System.EventHandler(this.acceptBtn_MouseEnter);
            this.acceptBtn.MouseLeave += new System.EventHandler(this.acceptBtn_MouseLeave);
            // 
            // roomGroupBox
            // 
            this.roomGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roomGroupBox.Controls.Add(this.responseGroupBox);
            this.roomGroupBox.Controls.Add(this.capacityGroupBox);
            this.roomGroupBox.Controls.Add(this.toGroupBox);
            this.roomGroupBox.Controls.Add(this.fromGroupBox);
            this.roomGroupBox.Controls.Add(this.requestsGroupBox);
            this.roomGroupBox.Controls.Add(this.hashLbl);
            this.roomGroupBox.Controls.Add(this.roomID);
            this.roomGroupBox.Controls.Add(this.roomName);
            this.roomGroupBox.Controls.Add(this.roomImage);
            this.roomGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roomGroupBox.Location = new System.Drawing.Point(460, 51);
            this.roomGroupBox.Name = "roomGroupBox";
            this.roomGroupBox.Size = new System.Drawing.Size(632, 509);
            this.roomGroupBox.TabIndex = 2;
            this.roomGroupBox.TabStop = false;
            this.roomGroupBox.Text = "REQUESTED ROOM";
            // 
            // capacityGroupBox
            // 
            this.capacityGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.capacityGroupBox.Controls.Add(this.guestsLbl);
            this.capacityGroupBox.Controls.Add(this.totalPriceLbl);
            this.capacityGroupBox.Controls.Add(this.label11);
            this.capacityGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityGroupBox.ForeColor = System.Drawing.Color.Cyan;
            this.capacityGroupBox.Location = new System.Drawing.Point(38, 396);
            this.capacityGroupBox.Name = "capacityGroupBox";
            this.capacityGroupBox.Size = new System.Drawing.Size(285, 97);
            this.capacityGroupBox.TabIndex = 21;
            this.capacityGroupBox.TabStop = false;
            this.capacityGroupBox.Text = "Capacity";
            // 
            // guestsLbl
            // 
            this.guestsLbl.AutoSize = true;
            this.guestsLbl.BackColor = System.Drawing.Color.Transparent;
            this.guestsLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guestsLbl.Location = new System.Drawing.Point(55, 33);
            this.guestsLbl.Name = "guestsLbl";
            this.guestsLbl.Size = new System.Drawing.Size(140, 19);
            this.guestsLbl.TabIndex = 7;
            this.guestsLbl.Text = "Number Of Guests: ";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.BackColor = System.Drawing.Color.SeaGreen;
            this.totalPriceLbl.ForeColor = System.Drawing.Color.Gold;
            this.totalPriceLbl.Location = new System.Drawing.Point(163, 60);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(60, 23);
            this.totalPriceLbl.TabIndex = 6;
            this.totalPriceLbl.Text = "100 £";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(55, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total Price: ";
            // 
            // toGroupBox
            // 
            this.toGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.toGroupBox.Controls.Add(this.hourTo);
            this.toGroupBox.Controls.Add(this.dayTo);
            this.toGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toGroupBox.ForeColor = System.Drawing.Color.Crimson;
            this.toGroupBox.Location = new System.Drawing.Point(342, 272);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(285, 113);
            this.toGroupBox.TabIndex = 20;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "T O";
            // 
            // hourTo
            // 
            this.hourTo.AutoSize = true;
            this.hourTo.BackColor = System.Drawing.Color.Transparent;
            this.hourTo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hourTo.Location = new System.Drawing.Point(22, 59);
            this.hourTo.Name = "hourTo";
            this.hourTo.Size = new System.Drawing.Size(64, 27);
            this.hourTo.TabIndex = 3;
            this.hourTo.Text = "Hour:";
            // 
            // dayTo
            // 
            this.dayTo.AutoSize = true;
            this.dayTo.BackColor = System.Drawing.Color.Transparent;
            this.dayTo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dayTo.Location = new System.Drawing.Point(22, 32);
            this.dayTo.Name = "dayTo";
            this.dayTo.Size = new System.Drawing.Size(56, 27);
            this.dayTo.TabIndex = 1;
            this.dayTo.Text = "Day:";
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.fromGroupBox.Controls.Add(this.hourFrom);
            this.fromGroupBox.Controls.Add(this.dayFrom);
            this.fromGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromGroupBox.ForeColor = System.Drawing.Color.Crimson;
            this.fromGroupBox.Location = new System.Drawing.Point(38, 272);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(285, 113);
            this.fromGroupBox.TabIndex = 19;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "F R O M";
            // 
            // hourFrom
            // 
            this.hourFrom.AutoSize = true;
            this.hourFrom.BackColor = System.Drawing.Color.Transparent;
            this.hourFrom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hourFrom.Location = new System.Drawing.Point(22, 59);
            this.hourFrom.Name = "hourFrom";
            this.hourFrom.Size = new System.Drawing.Size(64, 27);
            this.hourFrom.TabIndex = 3;
            this.hourFrom.Text = "Hour:";
            // 
            // dayFrom
            // 
            this.dayFrom.AutoSize = true;
            this.dayFrom.BackColor = System.Drawing.Color.Transparent;
            this.dayFrom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dayFrom.Location = new System.Drawing.Point(22, 32);
            this.dayFrom.Name = "dayFrom";
            this.dayFrom.Size = new System.Drawing.Size(56, 27);
            this.dayFrom.TabIndex = 1;
            this.dayFrom.Text = "Day:";
            // 
            // requestsGroupBox
            // 
            this.requestsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requestsGroupBox.Controls.Add(this.customerAdditionalRequests);
            this.requestsGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.requestsGroupBox.Location = new System.Drawing.Point(342, 71);
            this.requestsGroupBox.Name = "requestsGroupBox";
            this.requestsGroupBox.Size = new System.Drawing.Size(284, 195);
            this.requestsGroupBox.TabIndex = 18;
            this.requestsGroupBox.TabStop = false;
            this.requestsGroupBox.Text = "ADDITIONAL REQUESTS";
            // 
            // customerAdditionalRequests
            // 
            this.customerAdditionalRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerAdditionalRequests.BackColor = System.Drawing.Color.Transparent;
            this.customerAdditionalRequests.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAdditionalRequests.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customerAdditionalRequests.Location = new System.Drawing.Point(15, 22);
            this.customerAdditionalRequests.Name = "customerAdditionalRequests";
            this.customerAdditionalRequests.Size = new System.Drawing.Size(258, 158);
            this.customerAdditionalRequests.TabIndex = 4;
            this.customerAdditionalRequests.Text = "Lorem ipsum dolor sit amet, adipiscing elit. \r\nPraesent in aliquet justo. Donec e" +
    "get risus,\r\nNam iaculis, nibh quis facilisis tempor, \r\nrisus ligula malesuada to" +
    "rtor.";
            // 
            // hashLbl
            // 
            this.hashLbl.AutoSize = true;
            this.hashLbl.BackColor = System.Drawing.Color.Transparent;
            this.hashLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashLbl.ForeColor = System.Drawing.Color.Crimson;
            this.hashLbl.Location = new System.Drawing.Point(40, 34);
            this.hashLbl.Name = "hashLbl";
            this.hashLbl.Size = new System.Drawing.Size(35, 34);
            this.hashLbl.TabIndex = 17;
            this.hashLbl.Text = "#";
            // 
            // roomID
            // 
            this.roomID.AutoSize = true;
            this.roomID.BackColor = System.Drawing.Color.Transparent;
            this.roomID.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomID.ForeColor = System.Drawing.Color.Crimson;
            this.roomID.Location = new System.Drawing.Point(67, 34);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(30, 34);
            this.roomID.TabIndex = 13;
            this.roomID.Text = "1";
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.BackColor = System.Drawing.Color.Transparent;
            this.roomName.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.ForeColor = System.Drawing.Color.Gold;
            this.roomName.Location = new System.Drawing.Point(138, 34);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(110, 34);
            this.roomName.TabIndex = 15;
            this.roomName.Text = "Jokky";
            // 
            // roomImage
            // 
            this.roomImage.Image = ((System.Drawing.Image)(resources.GetObject("roomImage.Image")));
            this.roomImage.Location = new System.Drawing.Point(38, 71);
            this.roomImage.Name = "roomImage";
            this.roomImage.Size = new System.Drawing.Size(285, 195);
            this.roomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomImage.TabIndex = 14;
            this.roomImage.TabStop = false;
            // 
            // userMailLbl
            // 
            this.userMailLbl.AutoSize = true;
            this.userMailLbl.BackColor = System.Drawing.Color.Transparent;
            this.userMailLbl.Location = new System.Drawing.Point(21, 129);
            this.userMailLbl.Name = "userMailLbl";
            this.userMailLbl.Size = new System.Drawing.Size(88, 27);
            this.userMailLbl.TabIndex = 2;
            this.userMailLbl.Text = "E-mail: ";
            // 
            // userPhoneLbl
            // 
            this.userPhoneLbl.AutoSize = true;
            this.userPhoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.userPhoneLbl.Location = new System.Drawing.Point(21, 203);
            this.userPhoneLbl.Name = "userPhoneLbl";
            this.userPhoneLbl.Size = new System.Drawing.Size(159, 27);
            this.userPhoneLbl.TabIndex = 1;
            this.userPhoneLbl.Text = "Phone Number: ";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Location = new System.Drawing.Point(21, 61);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(80, 27);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "Name: ";
            // 
            // userGroupBox
            // 
            this.userGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userGroupBox.Controls.Add(this.userMailLbl);
            this.userGroupBox.Controls.Add(this.userPhoneLbl);
            this.userGroupBox.Controls.Add(this.userNameLbl);
            this.userGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userGroupBox.Location = new System.Drawing.Point(37, 51);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(404, 266);
            this.userGroupBox.TabIndex = 1;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "REQUESTED USER";
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.containerPanel.Controls.Add(this.roomGroupBox);
            this.containerPanel.Controls.Add(this.userGroupBox);
            this.containerPanel.Location = new System.Drawing.Point(28, 160);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1110, 586);
            this.containerPanel.TabIndex = 13;
            // 
            // formTitle
            // 
            this.formTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formTitle.AutoSize = true;
            this.formTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.formTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Green;
            this.formTitle.Image = ((System.Drawing.Image)(resources.GetObject("formTitle.Image")));
            this.formTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formTitle.Location = new System.Drawing.Point(419, 90);
            this.formTitle.Name = "formTitle";
            this.formTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formTitle.Size = new System.Drawing.Size(274, 31);
            this.formTitle.TabIndex = 12;
            this.formTitle.Text = "   RENT INFORMATION";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.formTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentInformationForm";
            this.Text = "UserProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentInformationForm_FormClosing);
            this.Load += new System.EventHandler(this.RentInformationForm_Load);
            this.responseGroupBox.ResumeLayout(false);
            this.roomGroupBox.ResumeLayout(false);
            this.roomGroupBox.PerformLayout();
            this.capacityGroupBox.ResumeLayout(false);
            this.capacityGroupBox.PerformLayout();
            this.toGroupBox.ResumeLayout(false);
            this.toGroupBox.PerformLayout();
            this.fromGroupBox.ResumeLayout(false);
            this.fromGroupBox.PerformLayout();
            this.requestsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).EndInit();
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button declineBtn;
        private System.Windows.Forms.GroupBox responseGroupBox;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.GroupBox roomGroupBox;
        private System.Windows.Forms.GroupBox capacityGroupBox;
        private System.Windows.Forms.Label guestsLbl;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.Label hourTo;
        private System.Windows.Forms.Label dayTo;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.Label hourFrom;
        private System.Windows.Forms.Label dayFrom;
        private System.Windows.Forms.GroupBox requestsGroupBox;
        private System.Windows.Forms.Label customerAdditionalRequests;
        private System.Windows.Forms.Label hashLbl;
        private System.Windows.Forms.Label roomID;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.PictureBox roomImage;
        private System.Windows.Forms.Label userMailLbl;
        private System.Windows.Forms.Label userPhoneLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label formTitle;
    }
}