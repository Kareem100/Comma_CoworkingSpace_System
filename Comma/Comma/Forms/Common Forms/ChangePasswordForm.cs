using Comma.CustomClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comma.Forms.Common_Forms
{
    public partial class ChangePasswordForm : Form
    {
        private SqlConnection con;

        public ChangePasswordForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (isValidData())
                if (isValidOldPassword())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE Users2 SET userPassword = @userPassword WHERE userID = @userID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("userPassword", newPasswordTxt.Text);
                    cmd.Parameters.AddWithValue("userID", int.Parse(GlobalData.userID));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password has been Changed Successfully !", "CHANGE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private bool isValidData()
        {
            if (oldPasswordTxt.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Correct Old Password", "Invalid Old Password !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (newPasswordTxt.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Correct New Password", "Invalid New Password !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (confirmNewPasswordTxt.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Correct Passwords", "Invalid Confirm New Password !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!newPasswordTxt.Text.Equals(confirmNewPasswordTxt.Text))
            {
                MessageBox.Show("Passwords are not the same !!...", "Passwords Missmatch !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (newPasswordTxt.Text.Trim().Equals(oldPasswordTxt.Text.Trim()))
            {
                MessageBox.Show("Old and New Passwords are the Same !!", "Invalid Move !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool isValidOldPassword()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT userPassword FROM Users2 WHERE userID = @userID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("userID", int.Parse(GlobalData.userID));
            string oldPassword = cmd.ExecuteScalar().ToString();
            if (!oldPassword.Equals(oldPasswordTxt.Text))
            {
                MessageBox.Show("Please Enter the Old Password You Specified with The Account Registeration !!", "Old Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

    }
}
