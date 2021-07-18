namespace Comma
{
    partial class RentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentForm));
            this.roomDataPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.roomPrice = new System.Windows.Forms.Label();
            this.roomDescription = new System.Windows.Forms.Label();
            this.roomID = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.Label();
            this.roomImage = new System.Windows.Forms.PictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.requestsTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guestsDropDown = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hourtTo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dayTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hourFrom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dayFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.roomIDdropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quoteBox = new System.Windows.Forms.GroupBox();
            this.quoteLbl = new System.Windows.Forms.Label();
            this.privacyGroupbox = new System.Windows.Forms.GroupBox();
            this.rentBtn = new System.Windows.Forms.Button();
            this.privacyLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.roomDataPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.quoteBox.SuspendLayout();
            this.privacyGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomDataPanel
            // 
            this.roomDataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roomDataPanel.Controls.Add(this.label1);
            this.roomDataPanel.Controls.Add(this.descriptionPanel);
            this.roomDataPanel.Controls.Add(this.roomID);
            this.roomDataPanel.Controls.Add(this.roomName);
            this.roomDataPanel.Controls.Add(this.roomImage);
            this.roomDataPanel.Location = new System.Drawing.Point(37, 197);
            this.roomDataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.roomDataPanel.Name = "roomDataPanel";
            this.roomDataPanel.Size = new System.Drawing.Size(453, 554);
            this.roomDataPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "#";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.descriptionPanel.Controls.Add(this.roomPrice);
            this.descriptionPanel.Controls.Add(this.roomDescription);
            this.descriptionPanel.Location = new System.Drawing.Point(21, 398);
            this.descriptionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(412, 139);
            this.descriptionPanel.TabIndex = 16;
            // 
            // roomPrice
            // 
            this.roomPrice.AutoSize = true;
            this.roomPrice.BackColor = System.Drawing.Color.Crimson;
            this.roomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.roomPrice.Location = new System.Drawing.Point(263, 95);
            this.roomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(131, 37);
            this.roomPrice.TabIndex = 4;
            this.roomPrice.Text = "120£ / H";
            // 
            // roomDescription
            // 
            this.roomDescription.AutoSize = true;
            this.roomDescription.BackColor = System.Drawing.Color.Transparent;
            this.roomDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roomDescription.Location = new System.Drawing.Point(7, 12);
            this.roomDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomDescription.Name = "roomDescription";
            this.roomDescription.Size = new System.Drawing.Size(353, 96);
            this.roomDescription.TabIndex = 3;
            this.roomDescription.Text = "Lorem ipsum dolor sit amet, adipiscing elit. \r\nPraesent in aliquet justo. Donec e" +
    "get risus,\r\nNam iaculis, nibh quis facilisis tempor, \r\nrisus ligula malesuada to" +
    "rtor.";
            // 
            // roomID
            // 
            this.roomID.AutoSize = true;
            this.roomID.BackColor = System.Drawing.Color.Transparent;
            this.roomID.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomID.ForeColor = System.Drawing.Color.Crimson;
            this.roomID.Location = new System.Drawing.Point(60, 18);
            this.roomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(56, 42);
            this.roomID.TabIndex = 13;
            this.roomID.Text = "ID";
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.BackColor = System.Drawing.Color.Transparent;
            this.roomName.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roomName.Location = new System.Drawing.Point(155, 18);
            this.roomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(244, 42);
            this.roomName.TabIndex = 15;
            this.roomName.Text = "Room Name";
            // 
            // roomImage
            // 
            this.roomImage.Image = ((System.Drawing.Image)(resources.GetObject("roomImage.Image")));
            this.roomImage.Location = new System.Drawing.Point(21, 64);
            this.roomImage.Margin = new System.Windows.Forms.Padding(4);
            this.roomImage.Name = "roomImage";
            this.roomImage.Size = new System.Drawing.Size(412, 309);
            this.roomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomImage.TabIndex = 14;
            this.roomImage.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightPanel.Controls.Add(this.groupBox4);
            this.rightPanel.Controls.Add(this.groupBox3);
            this.rightPanel.Controls.Add(this.groupBox2);
            this.rightPanel.Controls.Add(this.groupBox1);
            this.rightPanel.Controls.Add(this.roomIDdropDown);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Location = new System.Drawing.Point(557, 197);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(933, 554);
            this.rightPanel.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.requestsTxt);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox4.Location = new System.Drawing.Point(480, 391);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(413, 127);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional Requests";
            // 
            // requestsTxt
            // 
            this.requestsTxt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsTxt.Location = new System.Drawing.Point(25, 37);
            this.requestsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.requestsTxt.Multiline = true;
            this.requestsTxt.Name = "requestsTxt";
            this.requestsTxt.Size = new System.Drawing.Size(373, 69);
            this.requestsTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.totalPriceLbl);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.guestsDropDown);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(40, 391);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(413, 127);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capacity";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.BackColor = System.Drawing.Color.SeaGreen;
            this.totalPriceLbl.ForeColor = System.Drawing.Color.Gold;
            this.totalPriceLbl.Location = new System.Drawing.Point(249, 81);
            this.totalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(50, 29);
            this.totalPriceLbl.TabIndex = 6;
            this.totalPriceLbl.Text = "0 £";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(105, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total Price: ";
            // 
            // guestsDropDown
            // 
            this.guestsDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guestsDropDown.FormattingEnabled = true;
            this.guestsDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.guestsDropDown.Location = new System.Drawing.Point(103, 36);
            this.guestsDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.guestsDropDown.Name = "guestsDropDown";
            this.guestsDropDown.Size = new System.Drawing.Size(225, 37);
            this.guestsDropDown.TabIndex = 4;
            this.guestsDropDown.Text = "Number Of Guests";
            this.guestsDropDown.SelectedIndexChanged += new System.EventHandler(this.guestsDropDown_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.hourtTo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dayTo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(480, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "T O";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(36, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 74);
            this.label7.TabIndex = 7;
            this.label7.Text = "It\'s important to choose a ReHour, \r\nas in case that the room isn\'t available \r\na" +
    "t your chosen hour.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourtTo
            // 
            this.hourtTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hourtTo.FormattingEnabled = true;
            this.hourtTo.Items.AddRange(new object[] {
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM"});
            this.hourtTo.Location = new System.Drawing.Point(141, 79);
            this.hourtTo.Margin = new System.Windows.Forms.Padding(4);
            this.hourtTo.Name = "hourtTo";
            this.hourtTo.Size = new System.Drawing.Size(257, 31);
            this.hourtTo.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(29, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "Hour:";
            // 
            // dayTo
            // 
            this.dayTo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTo.Location = new System.Drawing.Point(141, 49);
            this.dayTo.Margin = new System.Windows.Forms.Padding(4);
            this.dayTo.Name = "dayTo";
            this.dayTo.Size = new System.Drawing.Size(257, 27);
            this.dayTo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(29, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 34);
            this.label10.TabIndex = 1;
            this.label10.Text = "Day:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hourFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dayFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(40, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "F R O M";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(36, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 74);
            this.label6.TabIndex = 7;
            this.label6.Text = "It\'s important to choose a ReHour, \r\nas in case that the room isn\'t available \r\na" +
    "t your chosen hour.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourFrom
            // 
            this.hourFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hourFrom.FormattingEnabled = true;
            this.hourFrom.Items.AddRange(new object[] {
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM"});
            this.hourFrom.Location = new System.Drawing.Point(141, 79);
            this.hourFrom.Margin = new System.Windows.Forms.Padding(4);
            this.hourFrom.Name = "hourFrom";
            this.hourFrom.Size = new System.Drawing.Size(257, 31);
            this.hourFrom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hour:";
            // 
            // dayFrom
            // 
            this.dayFrom.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayFrom.Location = new System.Drawing.Point(141, 49);
            this.dayFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dayFrom.Name = "dayFrom";
            this.dayFrom.Size = new System.Drawing.Size(257, 27);
            this.dayFrom.TabIndex = 2;
            this.dayFrom.ValueChanged += new System.EventHandler(this.dayFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(29, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Day:";
            // 
            // roomIDdropDown
            // 
            this.roomIDdropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roomIDdropDown.FormattingEnabled = true;
            this.roomIDdropDown.Location = new System.Drawing.Point(465, 69);
            this.roomIDdropDown.Margin = new System.Windows.Forms.Padding(4);
            this.roomIDdropDown.Name = "roomIDdropDown";
            this.roomIDdropDown.Size = new System.Drawing.Size(231, 24);
            this.roomIDdropDown.TabIndex = 1;
            this.roomIDdropDown.SelectedIndexChanged += new System.EventHandler(this.roomIDdropDown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(289, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pick a Room:";
            // 
            // quoteBox
            // 
            this.quoteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quoteBox.Controls.Add(this.quoteLbl);
            this.quoteBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteBox.ForeColor = System.Drawing.Color.SpringGreen;
            this.quoteBox.Location = new System.Drawing.Point(37, 774);
            this.quoteBox.Margin = new System.Windows.Forms.Padding(4);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.Padding = new System.Windows.Forms.Padding(4);
            this.quoteBox.Size = new System.Drawing.Size(453, 144);
            this.quoteBox.TabIndex = 6;
            this.quoteBox.TabStop = false;
            this.quoteBox.Text = "Quote of the day";
            // 
            // quoteLbl
            // 
            this.quoteLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quoteLbl.BackColor = System.Drawing.Color.Transparent;
            this.quoteLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quoteLbl.Location = new System.Drawing.Point(27, 39);
            this.quoteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteLbl.Name = "quoteLbl";
            this.quoteLbl.Size = new System.Drawing.Size(399, 89);
            this.quoteLbl.TabIndex = 0;
            this.quoteLbl.Text = "QUOTE";
            this.quoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privacyGroupbox
            // 
            this.privacyGroupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.privacyGroupbox.Controls.Add(this.rentBtn);
            this.privacyGroupbox.Controls.Add(this.privacyLbl);
            this.privacyGroupbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyGroupbox.ForeColor = System.Drawing.Color.SpringGreen;
            this.privacyGroupbox.Location = new System.Drawing.Point(557, 774);
            this.privacyGroupbox.Margin = new System.Windows.Forms.Padding(4);
            this.privacyGroupbox.Name = "privacyGroupbox";
            this.privacyGroupbox.Padding = new System.Windows.Forms.Padding(4);
            this.privacyGroupbox.Size = new System.Drawing.Size(933, 144);
            this.privacyGroupbox.TabIndex = 7;
            this.privacyGroupbox.TabStop = false;
            this.privacyGroupbox.Text = "Privacy and Confirmation";
            // 
            // rentBtn
            // 
            this.rentBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentBtn.FlatAppearance.BorderSize = 0;
            this.rentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBtn.ForeColor = System.Drawing.Color.Red;
            this.rentBtn.Location = new System.Drawing.Point(673, 85);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(245, 47);
            this.rentBtn.TabIndex = 8;
            this.rentBtn.Text = "Confirm Renting";
            this.rentBtn.UseVisualStyleBackColor = false;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // privacyLbl
            // 
            this.privacyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privacyLbl.BackColor = System.Drawing.Color.Transparent;
            this.privacyLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.privacyLbl.Location = new System.Drawing.Point(16, 28);
            this.privacyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privacyLbl.Name = "privacyLbl";
            this.privacyLbl.Size = new System.Drawing.Size(879, 89);
            this.privacyLbl.TabIndex = 0;
            this.privacyLbl.Text = resources.GetString("privacyLbl.Text");
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Goldenrod;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(623, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(282, 40);
            this.label12.TabIndex = 8;
            this.label12.Text = "   RENTING ROOM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1513, 932);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.privacyGroupbox);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.roomDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.Load += new System.EventHandler(this.RentForm_Load);
            this.roomDataPanel.ResumeLayout(false);
            this.roomDataPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.quoteBox.ResumeLayout(false);
            this.privacyGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel roomDataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label roomPrice;
        private System.Windows.Forms.Label roomDescription;
        private System.Windows.Forms.Label roomID;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.PictureBox roomImage;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox requestsTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox guestsDropDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox hourtTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dayTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hourFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dayFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomIDdropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox quoteBox;
        private System.Windows.Forms.Label quoteLbl;
        private System.Windows.Forms.GroupBox privacyGroupbox;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Label privacyLbl;
        private System.Windows.Forms.Label label12;
    }
}