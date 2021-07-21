using System.Data;
using Comma.Forms;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Comma.CustomClasses;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Comma
{
    public partial class RoomsForm : Form
    {   
        private UserHomeForm homeForm;
        private SqlConnection conn;
        private List<RoomModel> roomsList;

        public RoomsForm(UserHomeForm homeForm)
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

            for (int i = 0; i < roomsList.Count; ++i)
            {
                UserRoom room = new UserRoom(homeForm);

                string temp = (roomsList[i].roomRentType[0] == 'H') ? "£ / H" : "£ / D";
                string PriceFormat = roomsList[i].roomRentPrice.ToString() + temp;
                room.setRoomID(roomsList[i].roomID);
                room.setRoomName(roomsList[i].roomName);
                room.setRoomImage(convertByteArrayToImage(roomsList[i].roomImage));
                room.setRoomDescription(roomsList[i].roomDescription);
                room.setRoomPrice(PriceFormat);

                containerPanel.Controls.Add(room);
            }
        }

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

        private Image convertByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
            {
                return Image.FromStream(ms);
            }
        }
        // =====================================================

        private void RoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
