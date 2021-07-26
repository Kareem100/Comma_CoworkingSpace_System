using Comma.CustomClasses;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace Comma.Forms.Common_Forms
{
    public partial class ChangeEmailForm : Form
    {
        private SqlConnection con; 
                
        public ChangeEmailForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }

        private void changeEmailBtn_Click(object sender, EventArgs e)
        {
            if (isValidData())
                if (isValidOldEmail() && isValidNewEmail())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE Users2 SET userMail = @userMail WHERE userID = @userID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("userMail", newEmailTxt.Text);
                    cmd.Parameters.AddWithValue("userID", int.Parse(GlobalData.userID));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Email has been Changed Successfully !", "CHANGE EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private bool isValidData()
        {
            try
            {
                MailAddress m = new MailAddress(oldEmailTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Correct E-mail...", "Invalid Old E-mail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(newEmailTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Correct E-mail...", "Invalid New E-mail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(confirmNewEmailTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Correct E-mail...", "Invalid Confirm New E-mail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!newEmailTxt.Text.Equals(confirmNewEmailTxt.Text))
            {
                MessageBox.Show("Emails are not the same !!...", "Emails Missmatch !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (newEmailTxt.Text.Trim().Equals(oldEmailTxt.Text.Trim()))
            {
                MessageBox.Show("Old and New Emails are the Same !!", "Invalid Move !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool isValidOldEmail()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT userMail FROM Users2 WHERE userID = @userID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("userID", int.Parse(GlobalData.userID));
            string oldEmail = cmd.ExecuteScalar().ToString();
            if (!oldEmail.Equals(oldEmailTxt.Text))
            {
                MessageBox.Show("Please Enter the Old Email You Specified with The Account Registeration !!", "Old Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool isValidNewEmail()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT userID FROM Users2 WHERE userMail = @userMail";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("userMail", newEmailTxt.Text);
            object res = cmd.ExecuteScalar();
            if (res!=null)
            {
                MessageBox.Show("The New Email You Specified is Already Linked with Other Account !!", "New Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ChangeEmailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

    }
}
