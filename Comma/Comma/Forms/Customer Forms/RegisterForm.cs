using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Comma
{
    public partial class RegisterForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse, int nHeightEllipse
       );

        private Thread thread;

        public RegisterForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panel.Region =Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 30, 30));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }                 

        private void loginBtn_Click(object sender, EventArgs e)
        {
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void openForm(object obj)
        {
            Application.Run(new LoginForm());
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {   
                // DATABASE PART
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd = new SqlCommand("insertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = nameTxt.Text.ToString();
                cmd.Parameters.Add("@userMail", SqlDbType.NVarChar).Value = mailTxt.Text.ToString();
                cmd.Parameters.Add("@userPhone", SqlDbType.NVarChar).Value = phoneTxt.Text.ToString();
                cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = passTxt.Text.ToString();
                cmd.Parameters.Add("@userType", SqlDbType.NVarChar).Value = "Customer";
                cmd.Parameters.Add("@userNumberOfRentals", SqlDbType.Int).Value =0;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You Have Been Registered Successfully !!", "Congratulations...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    int ExcRes = ex.ErrorCode;
                    if (ExcRes == -2146232060)
                        MessageBox.Show("There's Aleardy Registered User with the same mail !!", "REGISTER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else 
                        MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private bool isValidData()
        {
            string name = nameTxt.Text.Trim();
            if (name == "" || name == "Full Name" || name == null || !name.Contains(" "))
            {
                MessageBox.Show("Please Enter Your Full Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string mail = mailTxt.Text.Trim();
            if (mail == "" || mail == "E-mail" || mail == null)
            {
                MessageBox.Show("Please Enter Your E-mail...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(mail);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Correct E-mail...", "Invalid E-mail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string phone = phoneTxt.Text.Trim();
            if (phone == "" || phone == "Phone Number" || phone.Length != 11 ||phone == null)
            {
                MessageBox.Show("Please Enter a Correct Phone Number...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                registerBtn_Click(sender, e);
        }

        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                registerBtn_Click(sender, e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

    }
}
