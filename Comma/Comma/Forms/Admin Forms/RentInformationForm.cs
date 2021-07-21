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
        string mRequestId, mRoomName;
        private AdminHomeForm homeForm;

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
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
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
                    setRoomImage(int.Parse(dr[4].ToString()));
                    getCustomer(int.Parse(dr[3].ToString()));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("editeRentalState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(mRequestId.ToString());
            cmd.Parameters.Add("@State", SqlDbType.NVarChar).Value = "Accepted";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            MessageBox.Show("Request Accepted Successfully", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            returnToRequests();
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("editeRentalState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(mRequestId.ToString());
            cmd.Parameters.Add("@State", SqlDbType.NVarChar).Value = "Decline";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            MessageBox.Show("Request Declined Successfully", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            returnToRequests();
        }

        private void setRoomImage(int roomId)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomImage FROM ROOMS WHERE roomID = " + roomId, con);
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
                con.Close();
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
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("select userName,userMail,userPhone from Users2 where userID = " + Id, con);
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
                con.Close();
            }
        }

        private void returnToRequests(){
            homeForm.openRentsForm();
        }

    }
}
