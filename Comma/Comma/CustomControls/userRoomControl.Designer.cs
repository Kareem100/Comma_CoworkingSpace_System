namespace Comma.Forms
{
    partial class UserRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoom));
            this.roomImage = new System.Windows.Forms.PictureBox();
            this.roomPrice = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.Label();
            this.roomID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomDescription = new System.Windows.Forms.Label();
            this.rentRoomBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRank)).BeginInit();
            this.SuspendLayout();
            // 
            // roomImage
            // 
            this.roomImage.Image = ((System.Drawing.Image)(resources.GetObject("roomImage.Image")));
            this.roomImage.Location = new System.Drawing.Point(15, 54);
            this.roomImage.Name = "roomImage";
            this.roomImage.Size = new System.Drawing.Size(309, 251);
            this.roomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomImage.TabIndex = 0;
            this.roomImage.TabStop = false;
            // 
            // roomPrice
            // 
            this.roomPrice.AutoSize = true;
            this.roomPrice.BackColor = System.Drawing.Color.Crimson;
            this.roomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.roomPrice.Location = new System.Drawing.Point(197, 77);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(106, 29);
            this.roomPrice.TabIndex = 4;
            this.roomPrice.Text = "120£ / H";
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.BackColor = System.Drawing.Color.Transparent;
            this.roomName.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roomName.Location = new System.Drawing.Point(115, 17);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(110, 34);
            this.roomName.TabIndex = 1;
            this.roomName.Text = "Jokky";
            // 
            // roomID
            // 
            this.roomID.AutoSize = true;
            this.roomID.BackColor = System.Drawing.Color.Transparent;
            this.roomID.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomID.ForeColor = System.Drawing.Color.Crimson;
            this.roomID.Location = new System.Drawing.Point(44, 17);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(30, 34);
            this.roomID.TabIndex = 0;
            this.roomID.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.roomPrice);
            this.panel1.Controls.Add(this.roomDescription);
            this.panel1.Location = new System.Drawing.Point(15, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 113);
            this.panel1.TabIndex = 10;
            // 
            // roomDescription
            // 
            this.roomDescription.AutoSize = true;
            this.roomDescription.BackColor = System.Drawing.Color.Transparent;
            this.roomDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roomDescription.Location = new System.Drawing.Point(5, 10);
            this.roomDescription.Name = "roomDescription";
            this.roomDescription.Size = new System.Drawing.Size(268, 72);
            this.roomDescription.TabIndex = 3;
            this.roomDescription.Text = "Lorem ipsum dolor sit amet, adipiscing elit. \r\nPraesent in aliquet justo. Donec e" +
    "get risus,\r\nNam iaculis, nibh quis facilisis tempor, \r\nrisus ligula malesuada to" +
    "rtor.";
            // 
            // rentRoomBtn
            // 
            this.rentRoomBtn.BackColor = System.Drawing.Color.Indigo;
            this.rentRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentRoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rentRoomBtn.FlatAppearance.BorderSize = 0;
            this.rentRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentRoomBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentRoomBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rentRoomBtn.Location = new System.Drawing.Point(95, 450);
            this.rentRoomBtn.Name = "rentRoomBtn";
            this.rentRoomBtn.Size = new System.Drawing.Size(150, 35);
            this.rentRoomBtn.TabIndex = 11;
            this.rentRoomBtn.Text = "Rent Room";
            this.rentRoomBtn.UseVisualStyleBackColor = false;
            this.rentRoomBtn.Click += new System.EventHandler(this.rentRoomBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "#";
            // 
            // pictureBoxRank
            // 
            this.pictureBoxRank.Location = new System.Drawing.Point(67, 5);
            this.pictureBoxRank.Name = "pictureBoxRank";
            this.pictureBoxRank.Size = new System.Drawing.Size(52, 45);
            this.pictureBoxRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRank.TabIndex = 13;
            this.pictureBoxRank.TabStop = false;
            this.pictureBoxRank.Visible = false;
            // 
            // UserRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.pictureBoxRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentRoomBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roomID);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.roomImage);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserRoom";
            this.Size = new System.Drawing.Size(340, 500);
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roomImage;
        private System.Windows.Forms.Label roomPrice;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Label roomID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roomDescription;
        private System.Windows.Forms.Button rentRoomBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRank;
    }
}
