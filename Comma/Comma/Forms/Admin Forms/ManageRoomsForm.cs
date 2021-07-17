using Comma.CustomClasses;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

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

        private Dictionary<string, int> roomDictionary;

        private int currentRoomID;

        public ManageRoomsForm()
        {
            commonConstructorsLines();
            currentState = "ADD ROOM";
            roomModel = new RoomModel();
            currentRoomID = -1;
        }

        public ManageRoomsForm(EventArgs e, string roomID, string choice)
        {
            commonConstructorsLines();
            currentState = choice;
            if (choice == GlobalData.editRoom)
                editRoomLbl_Click(this, e);
            else
                removeRoomLbl_Click(this, e);

            currentRoomID = int.Parse(roomID);
            loadRoom(currentRoomID, e);
            foreach (KeyValuePair<string, int> room in roomDictionary)
                if (room.Value == currentRoomID)
                {
                    roomSelectBox.SelectedItem = room.Key;
                    break;
                }
        }

        // ======================= HELPER METHODS =======================

        private void commonConstructorsLines()
        {
            InitializeComponent();
            roomModel = new RoomModel();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            loadAllRoomNames();
        }

        // Get All The Room Names Into roomSelectBox
        private void loadAllRoomNames()
        {
            roomSelectBox.Items.Clear();
            roomDictionary = new Dictionary<string, int>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT roomName, roomID FROM ROOMS";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                roomSelectBox.Items.Add(reader.GetString(0));
                roomDictionary.Add(reader.GetString(0), reader.GetInt32(1));
            }
            reader.Close();
        }

        private void roomSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentRoomID = roomDictionary[roomSelectBox.SelectedItem.ToString()];
            loadRoom(currentRoomID, e);
        }

        // Show Data of the Room with  the Given roomID
        private void loadRoom(int roomID, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Rooms WHERE RoomID = @RoomID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("RoomID", roomID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                roomModel.roomID = roomID;
                roomModel.roomName = reader[1].ToString(); // roomName
                roomModel.roomImage = ((byte[])reader.GetSqlBinary(2)); // roomImage
                roomModel.roomDescription = reader[3].ToString(); // roomDescription
                roomModel.roomRentType = reader[4].ToString();
                roomModel.roomRentPrice = int.Parse(reader[5].ToString()); // rentPrice
                loadFields(e);
            }
            else
                MessageBox.Show("Something went Wrong!\nPlease try again...", "Oops !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
        }

        // Get Data from RoomModel into Form Fields
        private void loadFields(EventArgs e)
        {
            nameTxt.Text = roomModel.roomName; // roomName
            roomImage.Image = convertByteArrayToImage(roomModel.roomImage); // roomImage
            descriptionBox.Text = roomModel.roomDescription; // roomDescription
            if (roomModel.roomRentType == GlobalData.hourlyRoom) // rentType
                hourlyTypeBtn_Click(this, e);
            else
                dailyTypeBtn_Click(this, e);
            priceTxt.Text = roomModel.roomRentPrice.ToString(); // rentPrice
        }

        private byte[] convertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image convertByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
            {
                return Image.FromStream(ms);
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
            clickLbl.Text = "Click To Add Room Image";
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
            clickLbl.Text = "Click To Edit Room Image";
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

        private void roomImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png;", Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    roomImage.Image = Image.FromFile(dialog.FileName);
            }
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
        private void addRoom()
        {
            getFieldsData();

            if (isValidData())
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
                    loadAllRoomNames();
                }
                catch
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

        // ======================= EDIT ROOM ===============================
        private void editRoom()
        {
            if (isValidUpdate())
            {
                updateRoomModel();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "updateRoom";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("roomID", roomModel.roomID);
                cmd.Parameters.AddWithValue("roomName", roomModel.roomName);
                cmd.Parameters.AddWithValue("roomImage", roomModel.roomImage);
                cmd.Parameters.AddWithValue("roomDescription", roomModel.roomDescription);
                cmd.Parameters.AddWithValue("rentType", roomModel.roomRentType);
                cmd.Parameters.AddWithValue("rentPrice", roomModel.roomRentPrice);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room has been Edited Successfully !", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isValidUpdate()
        {
            if (nameTxt.Text.Equals(""))
            {
                MessageBox.Show("Room Must has a Name !!", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (roomImage.Equals(null))
            {
                MessageBox.Show("Room Must has an Image !!", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (descriptionBox.Text.Length < 5)
            {
                MessageBox.Show("Room Must has a Good Description !!", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (hourlyTypeBtn.BackColor != Color.Green && dailyTypeBtn.BackColor != Color.Green)
            {
                MessageBox.Show("Room Must has a Rent Type !!", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.Parse(priceTxt.Text) == 0 || priceTxt.Text.Equals(""))
            {
                MessageBox.Show("Room Must has a Rent Price !!", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if there are any data changed...
            if (!roomModel.roomName.Equals(nameTxt.Text))
                return true;
            if (!isDifferentBytes(roomModel.roomImage, convertImageToByteArray(roomImage.Image)))
                return true;
            if (!roomModel.roomDescription.Equals(descriptionBox.Text))
                return true;
            if (roomModel.roomRentType == GlobalData.dailyRoom && hourlyTypeBtn.BackColor == Color.Green)
                return true;
            if (roomModel.roomRentType == GlobalData.hourlyRoom && dailyTypeBtn.BackColor == Color.Green)
                return true;
            if (roomModel.roomRentPrice != int.Parse(priceTxt.Text))
                return true;

            MessageBox.Show("There are no Data Changes to Update the Current Room !!", "EDITING ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private unsafe bool isDifferentBytes(byte[] imageData1, byte[] imageData2)
        {
            if (imageData1 == imageData2) return true;
            if (imageData1 == null || imageData2 == null || imageData1.Length != imageData2.Length)
                return false;
            fixed (byte* p1 = imageData1, p2 = imageData2)
            {
                byte* x1 = p1, x2 = p2;
                int l = imageData1.Length;
                for (int i = 0; i < l / 8; i++, x1 += 8, x2 += 8)
                    if (*((long*)x1) != *((long*)x2)) return false;
                if ((l & 4) != 0) { if (*((int*)x1) != *((int*)x2)) return false; x1 += 4; x2 += 4; }
                if ((l & 2) != 0) { if (*((short*)x1) != *((short*)x2)) return false; x1 += 2; x2 += 2; }
                if ((l & 1) != 0) if (*x1 != *x2) return false;
                return true;
            }
        }

        private void updateRoomModel()
        {
            roomModel.roomName = nameTxt.Text;
            roomModel.roomImage = convertImageToByteArray(roomImage.Image);
            roomModel.roomDescription = descriptionBox.Text;
            roomModel.roomRentPrice = int.Parse(priceTxt.Text);
            if (dailyTypeBtn.BackColor == Color.Green)
                roomModel.roomRentType = GlobalData.dailyRoom;
            else
                roomModel.roomRentType = GlobalData.hourlyRoom;
        }

        // ======================= REMOVE ROOM =============================
        private void removeRoom()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "removeRoom";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("roomID", currentRoomID);
            int res = cmd.ExecuteNonQuery();
            if (res == -1)
                MessageBox.Show("Something went wrong !!\nPlease try again...", "REMOVE ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                cleanAfterRoomDeletion();
                MessageBox.Show("The Room has been Removed Successfuly !", "REMOVE ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cleanAfterRoomDeletion()
        {
            roomDictionary.Remove(roomSelectBox.SelectedItem.ToString());
            roomSelectBox.Items.RemoveAt(roomSelectBox.SelectedIndex);
            clearFields();
        }

        private void clearFields()
        {
            roomImage.Image = null;
            nameTxt.Text = "";
            hourlyTypeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
            hourlyTypeBtn.ForeColor = Color.WhiteSmoke;
            dailyTypeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
            dailyTypeBtn.ForeColor = Color.WhiteSmoke;
            priceTxt.Text = "";
            descriptionBox.Text = "";
        }
        // =================================================================

        private void processBtn_Click(object sender, EventArgs e)
        {
            if (currentState == "ADD ROOM")
                addRoom();
            else if (currentState == "EDIT ROOM")
                if (roomSelectBox.Items.Count == 0)
                {
                    MessageBox.Show("No Rooms to Edit\nTry to Add Some Rooms First.", "EDIT ROOMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                    editRoom();
            else if (roomSelectBox.Items.Count == 0)
            {
                MessageBox.Show("No Rooms to Remove\nTry to Add Some Rooms First.", "REMOVE ROOMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
                removeRoom();
        }

        private void ManageRoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
