using Comma.CustomClasses;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Comma
{
    public partial class ManageRoomsForm : Form
    {
        // TO USE WHEN FETCHING DATA FROM DATABASE
        private string currentState; 

        // **** ROOM DATA **** //
        private RoomModel roomModel;

        // SQL CONNECTION
        private SqlConnection conn;

        public ManageRoomsForm()
        {
            InitializeComponent();
            currentState = "ADD ROOM";
            roomModel = new RoomModel();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if(conn.State == ConnectionState.Closed) conn.Open();
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

        // ============= LAYOUT AND NAVIGATION CODE =========================
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

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
        // =================================================================

        // ======================= ADD ROOM ================================
        private void roomImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png;", Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    roomImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private byte[] convertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            getFieldsData();

            if(isValidData())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "addRoom";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("roomName", roomModel.roomName);
                    cmd.Parameters.AddWithValue("roomImage", roomModel.roomImage);
                    cmd.Parameters.AddWithValue("roomDescription", roomModel.roomDescription);
                    cmd.Parameters.AddWithValue("rentType", roomModel.roomRentType);
                    cmd.Parameters.AddWithValue("rentPrice", roomModel.roomRentPrice);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Room has been Added Successfully !", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch
                {
                    MessageBox.Show("A Room with the Same Name Already Exist !!\nPlease Specify a Unique Room Name.", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void getFieldsData()
        {
            roomModel.roomName = nameTxt.Text;
            roomModel.roomImage = convertImageToByteArray(roomImage.Image);
            roomModel.roomDescription = descriptionBox.Text;
            if (hourlyTypeBtn.BackColor == Color.Green) // active
                roomModel.roomRentType = hourlyTypeBtn.Text;
            else if (dailyTypeBtn.BackColor == Color.Green)
                roomModel.roomRentType = dailyTypeBtn.Text;
            else
                roomModel.roomRentType = "";
            if (priceTxt.Text.Equals(""))
                roomModel.roomRentPrice = 0;
            else
                roomModel.roomRentPrice = int.Parse(priceTxt.Text);
        }

        private bool isValidData()
        {
            if (roomModel.roomName.Equals(""))
            {
                MessageBox.Show("Room Must has a Name !!", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (roomModel.roomImage.Equals(null))
            {
                MessageBox.Show("Room Must has an Image !!", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (roomModel.roomDescription.Length < 5)
            {
                MessageBox.Show("Room Must has a Good Description !!", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (roomModel.roomRentType.Equals(""))
            {
                MessageBox.Show("Room Must has a Rent Type !!", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (roomModel.roomRentPrice == 0)
            {
                MessageBox.Show("Room Must has a Rent Price !!", "ADDING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // =================================================================

        private void ManageRoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
