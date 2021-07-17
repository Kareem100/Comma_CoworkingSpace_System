namespace Comma
{
    partial class ManageRoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoomsForm));
            this.removeRoomLbl = new System.Windows.Forms.Label();
            this.addRoomLbl = new System.Windows.Forms.Label();
            this.titleForm = new System.Windows.Forms.Label();
            this.roomImage = new System.Windows.Forms.PictureBox();
            this.editRoomLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.rentPriceLbl = new System.Windows.Forms.Label();
            this.dailyTypeBtn = new System.Windows.Forms.Button();
            this.clickLbl = new System.Windows.Forms.Label();
            this.hourlyTypeBtn = new System.Windows.Forms.Button();
            this.rentTypeLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.processBtn = new System.Windows.Forms.Button();
            this.roomDescGroupBox = new System.Windows.Forms.GroupBox();
            this.addRoomGroupBox = new System.Windows.Forms.GroupBox();
            this.addRoomPanel = new System.Windows.Forms.Panel();
            this.roomSelectBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).BeginInit();
            this.roomDescGroupBox.SuspendLayout();
            this.addRoomGroupBox.SuspendLayout();
            this.addRoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeRoomLbl
            // 
            this.removeRoomLbl.AutoSize = true;
            this.removeRoomLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeRoomLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeRoomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRoomLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRoomLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeRoomLbl.Location = new System.Drawing.Point(277, 195);
            this.removeRoomLbl.Name = "removeRoomLbl";
            this.removeRoomLbl.Size = new System.Drawing.Size(160, 27);
            this.removeRoomLbl.TabIndex = 27;
            this.removeRoomLbl.Text = "REMOVE ROOM";
            this.removeRoomLbl.Click += new System.EventHandler(this.removeRoomLbl_Click);
            // 
            // addRoomLbl
            // 
            this.addRoomLbl.AutoSize = true;
            this.addRoomLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.addRoomLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addRoomLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRoomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addRoomLbl.Location = new System.Drawing.Point(28, 195);
            this.addRoomLbl.Name = "addRoomLbl";
            this.addRoomLbl.Size = new System.Drawing.Size(123, 29);
            this.addRoomLbl.TabIndex = 25;
            this.addRoomLbl.Text = "ADD ROOM";
            this.addRoomLbl.Click += new System.EventHandler(this.addRoomLbl_Click);
            // 
            // titleForm
            // 
            this.titleForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleForm.AutoSize = true;
            this.titleForm.BackColor = System.Drawing.Color.Goldenrod;
            this.titleForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleForm.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleForm.ForeColor = System.Drawing.Color.Green;
            this.titleForm.Image = ((System.Drawing.Image)(resources.GetObject("titleForm.Image")));
            this.titleForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleForm.Location = new System.Drawing.Point(278, 90);
            this.titleForm.Name = "titleForm";
            this.titleForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleForm.Size = new System.Drawing.Size(225, 31);
            this.titleForm.TabIndex = 24;
            this.titleForm.Text = "   MANAGE ROOMS";
            this.titleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomImage
            // 
            this.roomImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roomImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomImage.Location = new System.Drawing.Point(30, 71);
            this.roomImage.Name = "roomImage";
            this.roomImage.Size = new System.Drawing.Size(310, 251);
            this.roomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomImage.TabIndex = 14;
            this.roomImage.TabStop = false;
            this.roomImage.Click += new System.EventHandler(this.roomImage_Click);
            // 
            // editRoomLbl
            // 
            this.editRoomLbl.AutoSize = true;
            this.editRoomLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editRoomLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRoomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoomLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editRoomLbl.Location = new System.Drawing.Point(149, 195);
            this.editRoomLbl.Name = "editRoomLbl";
            this.editRoomLbl.Size = new System.Drawing.Size(128, 27);
            this.editRoomLbl.TabIndex = 26;
            this.editRoomLbl.Text = "EDIT ROOM";
            this.editRoomLbl.Click += new System.EventHandler(this.editRoomLbl_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.SystemColors.Control;
            this.priceTxt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(103, 179);
            this.priceTxt.MaxLength = 4;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(191, 26);
            this.priceTxt.TabIndex = 25;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // rentPriceLbl
            // 
            this.rentPriceLbl.AutoSize = true;
            this.rentPriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.rentPriceLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentPriceLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentPriceLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rentPriceLbl.Location = new System.Drawing.Point(21, 181);
            this.rentPriceLbl.Name = "rentPriceLbl";
            this.rentPriceLbl.Size = new System.Drawing.Size(74, 19);
            this.rentPriceLbl.TabIndex = 26;
            this.rentPriceLbl.Text = "Rent Price";
            // 
            // dailyTypeBtn
            // 
            this.dailyTypeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailyTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyTypeBtn.Location = new System.Drawing.Point(204, 120);
            this.dailyTypeBtn.Name = "dailyTypeBtn";
            this.dailyTypeBtn.Size = new System.Drawing.Size(90, 33);
            this.dailyTypeBtn.TabIndex = 24;
            this.dailyTypeBtn.Text = "Daily";
            this.dailyTypeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dailyTypeBtn.UseVisualStyleBackColor = true;
            this.dailyTypeBtn.Click += new System.EventHandler(this.dailyTypeBtn_Click);
            // 
            // clickLbl
            // 
            this.clickLbl.AutoSize = true;
            this.clickLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clickLbl.Location = new System.Drawing.Point(94, 191);
            this.clickLbl.Name = "clickLbl";
            this.clickLbl.Size = new System.Drawing.Size(175, 19);
            this.clickLbl.TabIndex = 19;
            this.clickLbl.Text = "Click To Add Room Image";
            this.clickLbl.Click += new System.EventHandler(this.roomImage_Click);
            // 
            // hourlyTypeBtn
            // 
            this.hourlyTypeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hourlyTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourlyTypeBtn.Location = new System.Drawing.Point(103, 120);
            this.hourlyTypeBtn.Name = "hourlyTypeBtn";
            this.hourlyTypeBtn.Size = new System.Drawing.Size(90, 33);
            this.hourlyTypeBtn.TabIndex = 23;
            this.hourlyTypeBtn.Text = "Hourly";
            this.hourlyTypeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hourlyTypeBtn.UseVisualStyleBackColor = true;
            this.hourlyTypeBtn.Click += new System.EventHandler(this.hourlyTypeBtn_Click);
            // 
            // rentTypeLbl
            // 
            this.rentTypeLbl.AutoSize = true;
            this.rentTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.rentTypeLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentTypeLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentTypeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rentTypeLbl.Location = new System.Drawing.Point(21, 127);
            this.rentTypeLbl.Name = "rentTypeLbl";
            this.rentTypeLbl.Size = new System.Drawing.Size(73, 19);
            this.rentTypeLbl.TabIndex = 22;
            this.rentTypeLbl.Text = "Rent Type";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.nameTxt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(103, 70);
            this.nameTxt.MaxLength = 20;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(191, 26);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Room Name";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(13, 26);
            this.descriptionBox.MaxLength = 500;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(284, 207);
            this.descriptionBox.TabIndex = 25;
            this.descriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processBtn
            // 
            this.processBtn.BackColor = System.Drawing.Color.Indigo;
            this.processBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.processBtn.FlatAppearance.BorderSize = 0;
            this.processBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBtn.ForeColor = System.Drawing.Color.Gold;
            this.processBtn.Location = new System.Drawing.Point(468, 362);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(150, 35);
            this.processBtn.TabIndex = 17;
            this.processBtn.Text = "ADD ROOM";
            this.processBtn.UseVisualStyleBackColor = false;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // roomDescGroupBox
            // 
            this.roomDescGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roomDescGroupBox.Controls.Add(this.descriptionBox);
            this.roomDescGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roomDescGroupBox.Location = new System.Drawing.Point(741, 71);
            this.roomDescGroupBox.Name = "roomDescGroupBox";
            this.roomDescGroupBox.Size = new System.Drawing.Size(310, 251);
            this.roomDescGroupBox.TabIndex = 15;
            this.roomDescGroupBox.TabStop = false;
            this.roomDescGroupBox.Text = "Room Description";
            // 
            // addRoomGroupBox
            // 
            this.addRoomGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addRoomGroupBox.Controls.Add(this.priceTxt);
            this.addRoomGroupBox.Controls.Add(this.rentPriceLbl);
            this.addRoomGroupBox.Controls.Add(this.dailyTypeBtn);
            this.addRoomGroupBox.Controls.Add(this.hourlyTypeBtn);
            this.addRoomGroupBox.Controls.Add(this.rentTypeLbl);
            this.addRoomGroupBox.Controls.Add(this.nameTxt);
            this.addRoomGroupBox.Controls.Add(this.label1);
            this.addRoomGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addRoomGroupBox.Location = new System.Drawing.Point(385, 71);
            this.addRoomGroupBox.Name = "addRoomGroupBox";
            this.addRoomGroupBox.Size = new System.Drawing.Size(310, 251);
            this.addRoomGroupBox.TabIndex = 14;
            this.addRoomGroupBox.TabStop = false;
            this.addRoomGroupBox.Text = "Room Data";
            // 
            // addRoomPanel
            // 
            this.addRoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addRoomPanel.Controls.Add(this.label2);
            this.addRoomPanel.Controls.Add(this.roomSelectBox);
            this.addRoomPanel.Controls.Add(this.processBtn);
            this.addRoomPanel.Controls.Add(this.roomDescGroupBox);
            this.addRoomPanel.Controls.Add(this.clickLbl);
            this.addRoomPanel.Controls.Add(this.addRoomGroupBox);
            this.addRoomPanel.Controls.Add(this.roomImage);
            this.addRoomPanel.Location = new System.Drawing.Point(28, 222);
            this.addRoomPanel.Name = "addRoomPanel";
            this.addRoomPanel.Size = new System.Drawing.Size(1082, 420);
            this.addRoomPanel.TabIndex = 23;
            // 
            // roomSelectBox
            // 
            this.roomSelectBox.BackColor = System.Drawing.Color.Indigo;
            this.roomSelectBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomSelectBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomSelectBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomSelectBox.ForeColor = System.Drawing.Color.Gold;
            this.roomSelectBox.FormattingEnabled = true;
            this.roomSelectBox.Location = new System.Drawing.Point(385, 31);
            this.roomSelectBox.MaxDropDownItems = 20;
            this.roomSelectBox.Name = "roomSelectBox";
            this.roomSelectBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomSelectBox.Size = new System.Drawing.Size(310, 27);
            this.roomSelectBox.TabIndex = 20;
            this.roomSelectBox.Text = "SELECT ROOM NAME";
            this.roomSelectBox.Visible = false;
            this.roomSelectBox.SelectedIndexChanged += new System.EventHandler(this.roomSelectBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(464, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "SELECT ROOM NAME";
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 590);
            this.Controls.Add(this.removeRoomLbl);
            this.Controls.Add(this.addRoomLbl);
            this.Controls.Add(this.titleForm);
            this.Controls.Add(this.editRoomLbl);
            this.Controls.Add(this.addRoomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRoomsForm";
            this.Text = "ManageRoomsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageRoomsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).EndInit();
            this.roomDescGroupBox.ResumeLayout(false);
            this.roomDescGroupBox.PerformLayout();
            this.addRoomGroupBox.ResumeLayout(false);
            this.addRoomGroupBox.PerformLayout();
            this.addRoomPanel.ResumeLayout(false);
            this.addRoomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label removeRoomLbl;
        private System.Windows.Forms.Label addRoomLbl;
        private System.Windows.Forms.Label titleForm;
        private System.Windows.Forms.PictureBox roomImage;
        private System.Windows.Forms.Label editRoomLbl;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label rentPriceLbl;
        private System.Windows.Forms.Button dailyTypeBtn;
        private System.Windows.Forms.Label clickLbl;
        private System.Windows.Forms.Button hourlyTypeBtn;
        private System.Windows.Forms.Label rentTypeLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.GroupBox roomDescGroupBox;
        private System.Windows.Forms.GroupBox addRoomGroupBox;
        private System.Windows.Forms.Panel addRoomPanel;
        private System.Windows.Forms.ComboBox roomSelectBox;
        private System.Windows.Forms.Label label2;
    }
}