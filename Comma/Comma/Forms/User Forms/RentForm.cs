using Comma.CustomClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Comma
{
    public partial class RentForm : Form
    {
        int Roomid;
        List<int>RoomIDs;
        private SqlConnection con;

        public RentForm()
        {
            InitializeComponent();
            generateQuote();
        }
        public RentForm(string roomID)
        {
            InitializeComponent();
            generateQuote();
            //DISPLAY DATA OF THE ROOM WITH roomID
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
            SqlCommand cmd = new SqlCommand("select roomID,roomName from Rooms", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr=null;
            try
            {
                dr = cmd.ExecuteReader();
                RoomIDs = new List<int>();
                while (dr.Read())
                {
                    roomIDdropDown.Items.Add(dr[1].ToString());
                    RoomIDs.Add(int.Parse(dr[0].ToString()));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }

        }

        private void dayFrom_ValueChanged(object sender, EventArgs e)
        {
            // DateTime t = new DateTime(sender);
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
                float totalPrice = capacity * getRoomRentPrice(Roomid);
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTCGCDF;Initial Catalog=CommaSpace;Integrated Security=True");
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
                con.Open();
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

        private float getRoomRentPrice(int RoomId)
        {
            float price = 0.0f;
            SqlCommand cmd = new SqlCommand("select rentPrice from Rooms where roomID = " + RoomId, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = null;
            try
            {

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    price = float.Parse(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
            return price;
        }

        private void roomIDdropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = roomIDdropDown.SelectedIndex;
            Roomid = RoomIDs[i];
        }

        private void guestsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int capacity = int.Parse(guestsDropDown.Text.ToString());
            float totalPrice = capacity * getRoomRentPrice(Roomid);
            totalPriceLbl.Text = totalPrice + " £";

        }

        private void RentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }
    }
}
