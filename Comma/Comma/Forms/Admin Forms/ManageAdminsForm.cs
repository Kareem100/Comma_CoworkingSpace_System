using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class ManageAdminsForm : Form
    {
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
            processBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, processBtn.Width, processBtn.Height, 30, 30));
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
        }

        private void disableControls()
        {
            mailTxt.Enabled = false;
            passTxt.Enabled = false;
            rePassTxt.Enabled = false;
            adminSelectBox.Visible = true;
        }
        private void enableControls()
        {
            mailTxt.Enabled = true;
            passTxt.Enabled = true;
            rePassTxt.Enabled = true;
            adminSelectBox.Visible = false;
            mailTxt.Text = "E-mail";
            passTxt.Text = "Password"; passTxt.ForeColor = Color.Gold;
            passTxt.UseSystemPasswordChar = false;
            rePassTxt.Text = "Confirm Password"; rePassTxt.ForeColor = Color.Gold;
            rePassTxt.UseSystemPasswordChar = false;
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
            if (isValidData())
            {
                // DATABASE PART
                MessageBox.Show("Admin Has Been Added Successfully !!", "ADD ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
        
    }
}
