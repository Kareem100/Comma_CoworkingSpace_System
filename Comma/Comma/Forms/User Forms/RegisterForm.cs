using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 30, 30));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void openForm(Object obj)
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

                MessageBox.Show("You Have Been Registered Successfully !!", "Congratulations...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isValidData()
        {
            string name = nameTxt.Text.Trim();
            if (name == "" || name == "Full Name" || name == null)
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
            if (phone == "" || phone == "Phone Number" || phone == null)
            {
                MessageBox.Show("Please Enter Your Phone Number...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < phone.Length; ++i)
                if (phone[i] > '9' || phone[i] < '0')
                {
                    MessageBox.Show("Please Enter a Correct Phone Number...", "Invalid Phone Number !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
