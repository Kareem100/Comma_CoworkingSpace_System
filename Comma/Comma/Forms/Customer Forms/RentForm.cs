using Comma.CustomClasses;
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
    public partial class RentForm : Form
    {
        private int selectedRoomIdx;
        private int Roomid;
        private List<RoomModel> roomModelList;
        private SqlConnection con;

        public RentForm()
        {
            InitializeComponent();
            generateQuote();
            Roomid = selectedRoomIdx = -1;
        }
        public RentForm(string roomID)
        {
            InitializeComponent();
            generateQuote();
            Roomid = int.Parse(roomID);
        }

        private void generateQuote()
        {
            string[] quotes; quotes = new string[6];
            quotes[0] = "Here is a place to work outside work...";
            quotes[1] = "Love for all, Hatred for none.";
            quotes[2] = "Change the world by being yourself.";
            quotes[3] = "Every moment is a fresh beginning.";
            quotes[4] = "Never regret anything that made you smile.";
            quotes[5] = "Die with memories, not dreams.";
            Random r = new Random();
            quoteLbl.Text = quotes[r.Next(6)];
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("select * from Rooms", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr=null;
            try
            {
                dr = cmd.ExecuteReader();
                roomModelList = new List<RoomModel>();
                while (dr.Read())
                {
                    RoomModel tempRoom = new RoomModel();
                    roomIDdropDown.Items.Add(dr[1].ToString());
                    tempRoom.roomID = dr.GetInt32(0);
                    tempRoom.roomName = dr.GetString(1);
                    tempRoom.roomImage = ((byte[])dr.GetSqlBinary(2));
                    tempRoom.roomDescription = dr.GetString(3);
                    tempRoom.roomRentType = dr.GetString(4);
                    tempRoom.roomRentPrice = dr.GetInt32(5);
                    roomModelList.Add(tempRoom);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                if (roomModelList.Count > 0)
                {
                    if (Roomid == -1) // SELECT FIRST ROOM
                        roomIDdropDown.SelectedIndex = 0;
                    else
                        for (int k = 0; k < roomModelList.Count; ++k)
                            if (roomModelList[k].roomID == Roomid) // SELECT CHOSEN ROOM
                            {
                                roomIDdropDown.SelectedIndex = k;
                                break;
                            }
                }
            }

        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = dayFrom.Value;
            DateTime endDate = dayTo.Value;

            if (hourFrom.Text.ToString() != "" && hourtTo.Text.ToString() != "" && requestsTxt.Text.ToString() != "" &&
                guestsDropDown.Text.ToString() != "" && roomIDdropDown.SelectedIndex != -1)
            {
                int stratHour = int.Parse(hourFrom.Text.ToString().Substring(0, 2));
                if (hourFrom.Text.ToString().Substring(6, 2).Equals("PM"))
                {
                    stratHour += 12;
                }
                int EndHour = int.Parse(hourtTo.Text.ToString().Substring(0, 2));
                if (hourtTo.Text.ToString().Substring(6, 2).Equals("PM"))
                {
                    EndHour += 12;
                }
                int capacity = int.Parse(guestsDropDown.Text.ToString());
                string addRequests = requestsTxt.Text.ToString();
                int totalPrice = capacity * roomModelList[selectedRoomIdx].roomRentPrice;
                SqlCommand cmd = new SqlCommand("insertReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RentStartDate", SqlDbType.DateTime).Value = startDate;
                cmd.Parameters.Add("@RentEndDate", SqlDbType.DateTime).Value = endDate;
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = int.Parse(GlobalData.userID);
                cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = Roomid;
                cmd.Parameters.Add("@RentStartHour", SqlDbType.Int).Value = stratHour;
                cmd.Parameters.Add("@RentEndHour", SqlDbType.Int).Value = EndHour;
                cmd.Parameters.Add("@cap", SqlDbType.Int).Value = int.Parse(guestsDropDown.Text.ToString());
                cmd.Parameters.Add("@ReservationPrice", SqlDbType.Float).Value = totalPrice;
                cmd.Parameters.Add("@ReservationState", SqlDbType.NVarChar).Value = "Request";
                cmd.Parameters.Add("@AddRequests", SqlDbType.NVarChar).Value = addRequests;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You Have Been Rented Successfully !!", "Congratulations...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Errors + "");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Data Required", "Hour", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roomIDdropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoomIdx = roomIDdropDown.SelectedIndex;
            Roomid = roomModelList[selectedRoomIdx].roomID;
            loadRoom(selectedRoomIdx);
        }

        private void loadRoom(int RoomIdx)
        {
            string temp = (roomModelList[RoomIdx].roomRentType.Equals(GlobalData.hourlyRoom)) ? "£ / H" : "£ / D";
            string PriceFormat = roomModelList[RoomIdx].roomRentPrice.ToString() + temp;
            roomID.Text = roomModelList[RoomIdx].roomID.ToString();
            roomName.Text = roomModelList[RoomIdx].roomName;
            roomImage.Image = convertByteArrayToImage(roomModelList[RoomIdx].roomImage);
            roomDescription.Text = roomModelList[RoomIdx].roomDescription;
            roomPrice.Text = PriceFormat;
        }

        private Image convertByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
            {
                return Image.FromStream(ms);
            }
        }

        private void guestsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int capacity = int.Parse(guestsDropDown.Text.ToString());
            int totalPrice = capacity * roomModelList[selectedRoomIdx].roomRentPrice;
            totalPriceLbl.Text = totalPrice + " £";

        }

        private void RentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

    }
}
