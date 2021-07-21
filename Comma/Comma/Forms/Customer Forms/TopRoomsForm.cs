using Comma.CustomClasses;
using Comma.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Comma
{
    public partial class TopRoomsForm : Form
    {
        private UserHomeForm homeForm;
        private SqlConnection conn;
        private List<RoomModel> roomsList;

        public TopRoomsForm(UserHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            loadRooms();
        }


        // ================ HELPER METHODS ====================
        private void loadRooms()
        {
            fetchRooms();

            for (int i = 0; i < 3; ++i)
            {
                UserRoom room = new UserRoom(homeForm);

                string temp = (roomsList[i].roomRentType[0] == 'H') ? "£ / H" : "£ / D";
                string PriceFormat = roomsList[i].roomRentPrice.ToString() + temp;
                room.setRoomID(roomsList[i].roomID);
                room.setRoomName(roomsList[i].roomName);
                room.setRoomImage(convertByteArrayToImage(roomsList[i].roomImage));
                room.setRoomDescription(roomsList[i].roomDescription);
                room.setRoomPrice(PriceFormat);

                if (i == 0)
                {
                    room.setRank(1);
                    panelRoom1Container.Controls.Add(room);
                }
                else if (i == 1)
                {
                    room.setRank(2);
                    panelRoom2Container.Controls.Add(room);
                }
                else
                {
                    room.setRank(3);
                    panelRoom3Container.Controls.Add(room);
                }
            }
        }

        // Fetching all rooms from database to roomList
        private void fetchRooms()
        {
            roomsList = new List<RoomModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT TOP 3 * FROM Rooms ORDER BY rentPrice DESC";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            int rank = 1;
            while (reader.Read())
            {
                RoomModel room = new RoomModel();
                room.roomID = rank++;
                room.roomName = reader.GetString(1);
                room.roomImage = ((byte[])reader.GetSqlBinary(2));
                room.roomDescription = reader.GetString(3);
                room.roomRentType = reader.GetString(4);
                room.roomRentPrice = reader.GetInt32(5);
                roomsList.Add(room);
            }
            reader.Close();
        }

        private Image convertByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
            {
                return Image.FromStream(ms);
            }
        }
        // =====================================================

        private void TopRoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
