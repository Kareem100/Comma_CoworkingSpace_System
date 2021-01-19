using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comma
{
    public partial class ManageRoomsForm : Form
    {
        private string currentState; // TO USE WHEN FETCHING DATA FROM DATABASE
        public ManageRoomsForm()
        {
            InitializeComponent();
            currentState = "ADD ROOM";
        }
        public ManageRoomsForm(EventArgs e, string roomID, string choice)
        {
            InitializeComponent();
            currentState = choice;
            if (choice == "EDIT ROOM")
            {
                editRoomLbl_Click(this, e);
                // SHOW DATA OF THE ROOM WITH  THE roomID
            }
            else
            {
                removeRoomLbl_Click(this, e);
                // SHOW DATA OF THE ROOM WITH  THE roomID
            }
        }

        // LAYOUT AND NAVIGATION CODE 
        // ===================================================================
        private void addRoomLbl_Click(object sender, EventArgs e)
        {
            addRoomLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            addRoomLbl.ForeColor = Color.RoyalBlue;
            addRoomLbl.BorderStyle = BorderStyle.Fixed3D;
            addRoomLbl.Left = 28;
            editRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            editRoomLbl.ForeColor = Color.WhiteSmoke;
            editRoomLbl.BorderStyle = BorderStyle.None;
            editRoomLbl.Left = addRoomLbl.Left + addRoomLbl.Width;
            removeRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            removeRoomLbl.ForeColor = Color.WhiteSmoke;
            removeRoomLbl.BorderStyle = BorderStyle.None;
            removeRoomLbl.Left = editRoomLbl.Left + editRoomLbl.Width;
            roomSelectBox.Visible = false;
            processBtn.Text = "ADD ROOM";
            currentState = "ADD ROOM";
            enableControls();
        }

        private void editRoomLbl_Click(object sender, EventArgs e)
        {
            editRoomLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            editRoomLbl.ForeColor = Color.RoyalBlue;
            editRoomLbl.BorderStyle = BorderStyle.Fixed3D;
            editRoomLbl.Left = 28;
            addRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            addRoomLbl.ForeColor = Color.WhiteSmoke;
            addRoomLbl.BorderStyle = BorderStyle.None;
            addRoomLbl.Left = editRoomLbl.Left + editRoomLbl.Width;
            removeRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            removeRoomLbl.ForeColor = Color.WhiteSmoke;
            removeRoomLbl.BorderStyle = BorderStyle.None;
            removeRoomLbl.Left = addRoomLbl.Left + addRoomLbl.Width;
            roomSelectBox.Visible = true;
            processBtn.Text = "EDIT ROOM";
            currentState = "EDIT ROOM";
            enableControls();
        }

        private void removeRoomLbl_Click(object sender, EventArgs e)
        {
            removeRoomLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            removeRoomLbl.ForeColor = Color.RoyalBlue;
            removeRoomLbl.BorderStyle = BorderStyle.Fixed3D;
            removeRoomLbl.Left = 28;
            addRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            addRoomLbl.ForeColor = Color.WhiteSmoke;
            addRoomLbl.BorderStyle = BorderStyle.None;
            addRoomLbl.Left = removeRoomLbl.Left + removeRoomLbl.Width;
            editRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            editRoomLbl.ForeColor = Color.WhiteSmoke;
            editRoomLbl.BorderStyle = BorderStyle.None;
            editRoomLbl.Left = addRoomLbl.Left + addRoomLbl.Width;
            roomSelectBox.Visible = true;
            processBtn.Text = "REMOVE ROOM";
            currentState = "REMOVE ROOM";
            disableControls();
        }
        
        private void hourlyTypeBtn_Click(object sender, EventArgs e)
        {
            hourlyTypeBtn.BackColor = Color.Green;
            hourlyTypeBtn.ForeColor = Color.Gold;
            dailyTypeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
            dailyTypeBtn.ForeColor = Color.WhiteSmoke;
        }
        private void dailyTypeBtn_Click(object sender, EventArgs e)
        {
            dailyTypeBtn.BackColor = Color.Green;
            dailyTypeBtn.ForeColor = Color.Gold;
            hourlyTypeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
            hourlyTypeBtn.ForeColor = Color.WhiteSmoke;
        }

        private void disableControls()
        {
            nameTxt.Enabled = false;
            hourlyTypeBtn.Enabled = false;
            dailyTypeBtn.Enabled = false;
            priceTxt.Enabled = false;
            descriptionBox.Enabled = false;
            roomImage.Enabled = false;
            clickLbl.Visible = false;
        }
        private void enableControls()
        {
            nameTxt.Enabled = true;
            hourlyTypeBtn.Enabled = true;
            dailyTypeBtn.Enabled = true;
            priceTxt.Enabled = true;
            descriptionBox.Enabled = true;
            roomImage.Enabled = false;
            clickLbl.Visible = true;
        }
        // ===================================================================

        private void roomImage_Click(object sender, EventArgs e)
        {

        }
    }
}
