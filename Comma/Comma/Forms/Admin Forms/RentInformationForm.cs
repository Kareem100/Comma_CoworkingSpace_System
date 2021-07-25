using Comma.CustomClasses;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class RentInformationForm : Form
    {
        private string mRequestId, mRoomName;
        private int customerID;
        private AdminHomeForm homeForm;
        private SqlConnection con;

        public RentInformationForm(AdminHomeForm adminHome, string RequestId, string RoomName)
        {
            InitializeComponent();
            homeForm = adminHome;
            mRequestId = RequestId;
            mRoomName = RoomName;
        }

        private void acceptBtn_MouseEnter(object sender, EventArgs e)
        {
            acceptBtn.BackColor = Color.WhiteSmoke;
            acceptBtn.ForeColor = Color.DarkCyan;
        }

        private void acceptBtn_MouseLeave(object sender, EventArgs e)
        {
            acceptBtn.BackColor = Color.Transparent;
            acceptBtn.ForeColor = Color.Gold;
        }

        private void declineBtn_MouseEnter(object sender, EventArgs e)
        {
            declineBtn.BackColor = Color.WhiteSmoke;
            declineBtn.ForeColor = Color.Red;
        }

        private void declineBtn_MouseLeave(object sender, EventArgs e)
        {
            declineBtn.BackColor = Color.Transparent;
            declineBtn.ForeColor = Color.Crimson;
        }

        private void RentInformationForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("select * from Reservations where reservationID=" + int.Parse(mRequestId), con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    roomName.Text = mRoomName;
                    roomID.Text = dr[4].ToString();
                    customerAdditionalRequests.Text = dr[10].ToString();
                    DateTime date = DateTime.Parse(dr[1].ToString());
                    dayFrom.Text = "Day : " + date.Date.Day + "/" + date.Date.Month + "/" + date.Date.Year;
                    date = DateTime.Parse(dr[2].ToString());
                    dayTo.Text = "Day : " + date.Date.Day + "/" + date.Date.Month + "/" + date.Date.Year;
                    int sh = int.Parse(dr[5].ToString());
                    hourFrom.Text = "Hour : " + dr[5].ToString();
                    hourTo.Text = "Hour : " + dr[6].ToString();
                    guestsLbl.Text = "Number Of Guests: " + dr[7].ToString();
                    totalPriceLbl.Text = dr[8].ToString() + " £";

                    customerID = int.Parse(dr[3].ToString());
                    setRoomImage(int.Parse(dr[4].ToString()));
                    getCustomer(customerID);
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

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            increaseRentals();
            takeRequestAction("Accepted");
            sendMessageByResponse(true);
            returnToRequests();
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            takeRequestAction("Declined");
            sendMessageByResponse(false);
            returnToRequests();
        }

        private void increaseRentals()
        {
            SqlCommand cmd = new SqlCommand("increaseRentals", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("reservationID", int.Parse(mRequestId));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void takeRequestAction(string state)
        {
            SqlCommand cmd = new SqlCommand("editRentalState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(mRequestId.ToString());
            cmd.Parameters.Add("@State", SqlDbType.NVarChar).Value = state;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Request " + state +  " Successfully !", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendMessageByResponse(bool Accepted)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addMessage";
            cmd.CommandType = CommandType.StoredProcedure;
            string message = (Accepted) ? GlobalData.acceptedRentNotification : GlobalData.declinedRentNotification;
            cmd.Parameters.AddWithValue("adminID", int.Parse(GlobalData.userID));
            cmd.Parameters.AddWithValue("customerID", customerID);
            cmd.Parameters.AddWithValue("messageContent", message);
            cmd.Parameters.AddWithValue("fromAdmin", true);

            cmd.ExecuteNonQuery();
            MessageBox.Show("A Message has been Sent to The Customer Specifying the Response !", "MESSAGES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setRoomImage(int roomId)
        {
            SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con2.State == ConnectionState.Closed) con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomImage FROM ROOMS WHERE roomID = " + roomId, con2);
            cmd.CommandType = CommandType.Text;
            try
            {
                byte[] imageData = (byte[])cmd.ExecuteScalar();
                roomImage.Image = convertByteArrayToImage(imageData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con2.Close();
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

        private void getCustomer(int Id)
        {
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con3.State == ConnectionState.Closed) con3.Open();
            SqlCommand cmd = new SqlCommand("select userName,userMail,userPhone from Users2 where userID = " + Id, con3);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    userNameLbl.Text = "Name: " + dr[0].ToString();
                    userMailLbl.Text = "E-Mail: " + dr[1].ToString();
                    userPhoneLbl.Text = "Phone Number: " + dr[2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con3.Close();
            }
        }

        private void returnToRequests(){
            homeForm.openRentsForm();
        }

        private void RentInformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

    }
}
