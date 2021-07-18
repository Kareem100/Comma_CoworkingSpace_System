using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class ManageAdminsForm : Form
    {
        List<int> AdminIDs;
        List<string> AdminNames;
        List<string> AdminMails;
        List<string> AdminPhones;
        int addminID;
        int index;
        private SqlConnection con;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse, int nHeightEllipse
       );
        private string currentState;
        public ManageAdminsForm()
        {
            InitializeComponent();
            currentState = "ADD ADMIN";
            processBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, processBtn.Width, processBtn.Height, 30, 30));
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }

        // NAVIGATION CODE 
        // ===================================================================
        private void addAdminLbl_Click(object sender, EventArgs e)
        {
            addAdminLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            addAdminLbl.ForeColor = Color.WhiteSmoke;
            addAdminLbl.BorderStyle = BorderStyle.Fixed3D;
            removeAdminLbl.BackColor = Color.FromArgb(200, 250, 205, 0); 
            removeAdminLbl.ForeColor = Color.RoyalBlue;
            removeAdminLbl.BorderStyle = BorderStyle.None;
            processBtn.Text = "ADD ADMIN";
            currentState = "ADD ADMIN";
            adminSelectBox.Items.Clear();
            AdminIDs.Clear();
            enableControls();
        }

        private void removeAdminLbl_Click(object sender, EventArgs e)
        {
            removeAdminLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            removeAdminLbl.ForeColor = Color.WhiteSmoke;
            removeAdminLbl.BorderStyle = BorderStyle.Fixed3D;
            addAdminLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            addAdminLbl.ForeColor = Color.RoyalBlue;
            addAdminLbl.BorderStyle = BorderStyle.None;
            processBtn.Text = "REMOVE ADMIN";
            currentState = "REMOVE ADMIN";

            disableControls();
            fillDop();
        }

        private void fillDop()
        {
            SqlCommand cmd = new SqlCommand("select userID, userName, userMail, userPhone from Users2 where userType='Admin'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
                AdminIDs = new List<int>();
                AdminNames = new List<string>();
                AdminMails = new List<string>();
                AdminPhones = new List<string>();
                while (dr.Read())
                {
                    adminSelectBox.Items.Add(dr[1].ToString());
                    AdminIDs.Add(int.Parse(dr[0].ToString()));
                    AdminNames.Add(dr[1].ToString());
                    AdminMails.Add(dr[2].ToString());
                    AdminPhones.Add(dr[3].ToString());
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

        private void disableControls()
        {
            nameTxt.Enabled = false;
            mailTxt.Enabled = false;
            phoneTxt.Enabled = false;
            passTxt.Enabled = false;
            rePassTxt.Enabled = false;
            adminSelectBox.Visible = true;
        }
        private void enableControls()
        {
            nameTxt.Enabled = true;
            mailTxt.Enabled = true;
            phoneTxt.Enabled = true;
            passTxt.Enabled = true;
            rePassTxt.Enabled = true;
            adminSelectBox.Visible = false;
            nameTxt.Text = "Full Name";
            mailTxt.Text = "E-mail";
            phoneTxt.Text = "Phone Number";
            passTxt.Text = "Password"; passTxt.ForeColor = Color.Gold;
            passTxt.UseSystemPasswordChar = false;
            rePassTxt.Text = "Confirm Password"; rePassTxt.ForeColor = Color.Gold;
            rePassTxt.UseSystemPasswordChar = false;
        }
        private void nameTxt_Enter(object sender, EventArgs e)
        {
            if (nameTxt.Text == "Full Name")
            {
                nameTxt.Text = ""; nameTxt.ForeColor = Color.Gold;
            }
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.Text = "Full Name"; nameTxt.ForeColor = Color.WhiteSmoke;
            }
        }

        private void phoneTxt_Enter(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "Phone Number")
            {
                phoneTxt.Text = ""; phoneTxt.ForeColor = Color.Gold;
            }
        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            {
                phoneTxt.Text = "Phone Number"; phoneTxt.ForeColor = Color.WhiteSmoke;
            }
        }
        private void mailTxt_Enter(object sender, EventArgs e)
        {
            if (mailTxt.Text == "E-mail")
            {
                mailTxt.Text = ""; mailTxt.ForeColor = Color.Gold;
            }
        }

        private void mailTxt_Leave(object sender, EventArgs e)
        {
            if (mailTxt.Text == "")
            {
                mailTxt.Text = "E-mail"; mailTxt.ForeColor = Color.WhiteSmoke;
            }
        }

        private void passTxt_Enter(object sender, EventArgs e)
        {
            if (passTxt.Text == "Password")
            {
                passTxt.Text = ""; passTxt.ForeColor = Color.Gold;
                passTxt.UseSystemPasswordChar = false;
            }
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            if (passTxt.Text == "")
            {
                passTxt.Text = "Password"; passTxt.ForeColor = Color.WhiteSmoke;
                passTxt.UseSystemPasswordChar = true;
            }
        }

        private void rePassTxt_Enter(object sender, EventArgs e)
        {
            if (rePassTxt.Text == "Confirm Password")
            {
                rePassTxt.Text = ""; rePassTxt.ForeColor = Color.Gold;
                rePassTxt.UseSystemPasswordChar = false;
            }
        }

        private void rePassTxt_Leave(object sender, EventArgs e)
        {
            if (rePassTxt.Text == "")
            {
                rePassTxt.Text = "Confirm Password"; rePassTxt.ForeColor = Color.WhiteSmoke;
                rePassTxt.UseSystemPasswordChar = true;
            }
        }
        // ===================================================================

        private void processBtn_Click(object sender, EventArgs e)
        {
           SqlCommand cmd=null;
            if (currentState == "ADD ADMIN")
            {
            if (isValidData())
            {
                cmd = new SqlCommand("insertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = nameTxt.Text.ToString();
                cmd.Parameters.Add("@userMail", SqlDbType.NVarChar).Value = mailTxt.Text.ToString();
                cmd.Parameters.Add("@userPhone", SqlDbType.NVarChar).Value = phoneTxt.Text.ToString();
                cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = passTxt.Text.ToString();
                cmd.Parameters.Add("@userType", SqlDbType.NVarChar).Value = "Admin";
                cmd.Parameters.Add("@userNumberOfRentals", SqlDbType.Int).Value = 0;
            }
            }
            else if(currentState == "REMOVE ADMIN")
            {
                cmd = new SqlCommand("RemoveAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = addminID;
            }
            try
            {
                cmd.ExecuteNonQuery();
            if (currentState == "ADD ADMIN")
                MessageBox.Show("Admin Has Been Added Successfully !!", "ADD ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                adminSelectBox.Items.RemoveAt(index);
                MessageBox.Show("Admin Has Been Deleted Successfully !!", "ADD ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool isValidData()
        {
            string mail = mailTxt.Text.Trim();
            if (mail == "" || mail == "E-mail" || mail == null)
            {
                MessageBox.Show("Please Enter Your E-mail...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                new MailAddress(mail);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Correct E-mail...", "Invalid E-mail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            string pass = passTxt.Text.Trim();
            if (pass == "" || pass == "Password" || pass == null)
            {
                MessageBox.Show("Please Enter a Password...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;     
            }
            string rePass = rePassTxt.Text.Trim();
            if (rePass == "" || rePass == "Confirm Password" || rePass == null)
            {
                MessageBox.Show("Please Confirm Password...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pass != rePass)
            {
                MessageBox.Show("Passwords Doesn't Match !!", "Missmatch Passwords !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void adminSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = adminSelectBox.SelectedIndex;
            addminID = AdminIDs[index];
            fillFields(index);
        }

        private void fillFields(int idx)
        {
            nameTxt.Text = AdminNames[idx];
            mailTxt.Text = AdminMails[idx];
            phoneTxt.Text = AdminPhones[idx];
        }

        private void ManageAdminsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }
    }
}
