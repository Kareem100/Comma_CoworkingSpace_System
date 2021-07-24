using Comma.CustomClasses;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Comma.Forms.Common_Forms
{
    public partial class MessagesForm : Form
    {
        private bool fromAdmin;
        private SqlConnection con;

        public MessagesForm(bool isAdmin)
        {
            InitializeComponent();
            fromAdmin = isAdmin;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();

            fromTxt.Text = GlobalData.userFullName;
            if (!isAdmin)
            {
                toLbl.Visible = false;
                customerIDLbl.Visible = false;
                toCmb.Visible = false;
            }
            else
            {
                loadCustomersIDs();
                if (toCmb.Items.Count > 0)
                    toCmb.SelectedIndex = 0;
                else
                    sendMessageBtn.Enabled = false;
            }
        }

        private void loadCustomersIDs()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT userID FROM Users2 WHERE userType = 'Customer'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                toCmb.Items.Add(reader[0].ToString());
            
            reader.Close();
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "addMessage";
                cmd.CommandType = CommandType.StoredProcedure;

                int adminID = (GlobalData.userType.Equals(GlobalData.adminUser)) ? int.Parse(GlobalData.userID) : 1;
                int customerID = (GlobalData.userType.Equals(GlobalData.customerUser)) ? int.Parse(GlobalData.userID) : int.Parse(toCmb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("adminID", adminID);
                cmd.Parameters.AddWithValue("customerID", customerID);
                cmd.Parameters.AddWithValue("messageContent", messageTxt.Text);
                cmd.Parameters.AddWithValue("fromAdmin", fromAdmin);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Message has been Sent Successfully !", "MESSAGES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isValidData()
        {
            if (toCmb.Visible && toCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Customer the Message will Sent To !!", "MESSAGES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (messageTxt.Text.Length < 5)
            {
                MessageBox.Show("Please Type a Valid Message !!", "MESSAGES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void MessagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

    }
}
