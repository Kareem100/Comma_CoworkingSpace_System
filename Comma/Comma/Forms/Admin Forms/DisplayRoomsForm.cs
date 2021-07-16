using Comma.CustomClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class DisplayRoomsForm : Form
    {
        private AdminHomeForm homeForm;
        private SqlConnection conn;
        private List<RoomModel> roomsList;

        public DisplayRoomsForm(AdminHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            loadRooms();
        }

        private void loadRooms()
        {
            // max lines for description is 3 lines
            string roomName, roomDescription; // max chars is 45 in first 3 lines and 30 in last line..
            int roomID, roomPrice;
            Image roomImage;
            char rentType;
            fetchRooms();

            for (int i = 0; i < roomsList.Count; ++i)
            {
                roomID = roomsList[i].roomID;
                roomName = roomsList[i].roomName;
                roomImage = convertByteArrayToImage(roomName, roomsList[i].roomImage);
                roomDescription = roomsList[i].roomDescription;
                rentType = roomsList[i].roomRentType[0];
                roomPrice = roomsList[i].roomRentPrice;

                AdminRoom room = new AdminRoom(homeForm);

                string temp = (rentType == 'H') ? "£ / H" : "£ / D";
                string PriceFormat = roomPrice.ToString() + temp;
                room.setRoomID(roomID);
                room.setRoomName(roomName);
                room.setRoomImage(roomImage);
                room.setRoomDescription(roomDescription);
                room.setRoomPrice(PriceFormat);

                containerPanel.Controls.Add(room);
            }
        }

        // ================ HELPER METHODS ====================

        // Fetching all rooms from database to roomList
        private void fetchRooms()
        {
            roomsList = new List<RoomModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Rooms";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RoomModel room = new RoomModel();
                room.roomID = int.Parse(reader[0].ToString());
                room.roomName = reader[1].ToString();
                room.roomImage = ((byte[])reader.GetSqlBinary(2));
                room.roomDescription = reader[3].ToString();
                room.roomRentType = reader[4].ToString();
                room.roomRentPrice = int.Parse(reader[5].ToString());
                roomsList.Add(room);
            }
            reader.Close();
        }

        private Image convertByteArrayToImage(string roomName, byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
            {
                return Image.FromStream(ms);
            }
        }
        // =====================================================

        private void DisplayRoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
