using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Comma
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        private Thread thread;
        public LoginForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 30, 30));
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            this.Close();
        }

        private void nameTxt_Enter(object sender, System.EventArgs e)
        {
            if (mailTxt.Text == "E-mail") { mailTxt.Text = ""; mailTxt.ForeColor = Color.Gold; }

        }

        private void nameTxt_Leave(object sender, System.EventArgs e)
        {
            if (mailTxt.Text == "") { mailTxt.ForeColor = Color.WhiteSmoke; mailTxt.Text = "E-mail"; }
        }

        private void passTxt_Enter(object sender, System.EventArgs e)
        {
            if (passTxt.Text == "Password") { 
                passTxt.Text = ""; passTxt.ForeColor = Color.Gold;
                passTxt.UseSystemPasswordChar = false;
            }
        }

        private void passTxt_Leave(object sender, System.EventArgs e)
        {
            if (passTxt.Text == "") { 
                passTxt.ForeColor = Color.WhiteSmoke; passTxt.Text = "Password";
                passTxt.UseSystemPasswordChar = true;
            }
        }

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            loginButton.FlatAppearance.BorderSize = 1;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.FlatAppearance.BorderSize = 0;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void openForm(Object obj)
        {
            Application.Run(new RegisterForm());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                // DATABASE PART
                MessageBox.Show("You Have Logged in Successfully !!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool isValidData()
        {
            string mail = mailTxt.Text.Trim();
            if (mail == "" || mail == "E-mail" || mail == null)
            {
                MessageBox.Show("Please Enter Your E-mail...", "INVALID LOGIN !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(mail);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Correct E-mail...", "INVALID E-MAIL !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string pass = passTxt.Text.Trim();
            if (pass == "" || pass == "Password" || pass == null)
            {
                MessageBox.Show("Please Enter a Password...", "INVALID LOGIN !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
