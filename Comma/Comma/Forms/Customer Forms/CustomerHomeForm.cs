using Comma.CustomClasses;
using Comma.Forms.Common_Forms;
using Comma.Forms.Customer_Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Comma
{
    public partial class UserHomeForm : Form
    {
        // ============================================================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse,  int nHeightEllipse
        );
        // ============================================================
        
        private Form activeForm = null;
        private string facebookLink, twitterLink, instagramLink, askfmLink;

        public UserHomeForm()
        {
            InitializeComponent();
            sidebarPanel.Top = homeBtn.Top;
            homeBtn.ForeColor = Color.Goldenrod;
            notificationsContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, notificationsContainer.Width, notificationsContainer.Height, 15, 15));
            settingsContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingsContainer.Width, settingsContainer.Height, 15, 15));
            showRoomsBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showRoomsBtn.Width, showRoomsBtn.Height, 30, 30));
            notificationsAlertLbl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, notificationsAlertLbl.Width, notificationsAlertLbl.Height, 100, 100));
            initializeQuotes();
            string[] names = GlobalData.userFullName.Split(' ');
            userNameLbl.Text = names[0][0] + "." + names[1];
            facebookLink = twitterLink = instagramLink = askfmLink = "";
            loadSocialLinks();
            loadMessagesIfAny();
        }

        private void loadMessagesIfAny()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getCustomerMessages";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("customerID", int.Parse(GlobalData.userID));

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                noMessagesLbl.Visible = false;
                notificationsAlertLbl.Visible = true;
            }
            else
                noMessagesLbl.Visible = true;

            while (reader.Read())
                addMessage(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            
            reader.Close();
            conn.Dispose();
        }

        private void addMessage(int messageID, string from, string messageContent)
        {
            CustomMessage message = new CustomMessage(messageID);
            message.Width = notificationsContainer.Width - 24;
            message.setFromLbl(from);
            message.setMessageContent(messageContent);

            notificationsContainer.Controls.Add(message);
        }

        private void initializeQuotes()
        {
            Random r = new Random();
            string[] quotes = new string[6];
            quotes[0] = "In the sky there are always answers and explanations for everything: every pain, every suffering, joy and confusion.";
            quotes[1] = "We long for things that harm us and run from the things that grow and heal us. We think good is bad and bad is good.";
            quotes[2] = "It was unfair that people who longed for love the most, searched the hardest for it, found it so elusive.";
            quotes[3] = "Just take my hand, lead, dance with me...and I will simply follow the blueness of the water, the white waves rolling free...where the earth beneath my feet and stars make my heart whole again...in long and priceless moments of shared solitude...";
            quotes[4] = "We have three roles here on earth: to learn, to love, and to live. When we stop learning, we start to stagnate and die. When we stop loving, we lose our sense of purpose and become self-centered. When we limit our living, we deny the world the benefits of our talents.";
            quotes[5] = "Simplicity requires a two-step process. First, we must invest time and energy to discover what stirs us as human beings, what makes our hearts sing, and what brings us joy. Then, we must proceed to create the life that reflects the unique people we truly are. This is the heart and soul of simplicity.";

            quoteLbl.Text = quotes[r.Next(6)];
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            highlightSelectedButton(homeBtn);
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            openForm(new RoomsForm(this));
            highlightSelectedButton(roomsBtn);
        }

        private void topRoomsBtn_Click(object sender, EventArgs e)
        {
            openForm(new TopRoomsForm(this));
            highlightSelectedButton(topRoomsBtn);
        }

        private void topCustomersBtn_Click(object sender, EventArgs e)
        {
            openForm(new TopCustomersForm());
            highlightSelectedButton(topCustomersBtn);
        }

        public void rentBtn_Click(object sender, EventArgs e, string roomID)
        {
            openForm(new RentForm(roomID));
            highlightSelectedButton(rentBtn);
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            openForm(new RentForm());
            highlightSelectedButton(rentBtn);
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            openForm(new FeedbackForm());
            highlightSelectedButton(feedbackBtn);
        }

        private void openForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            resetContextMenus();
        }

        private void highlightSelectedButton(Button button)
        {
            foreach(Control b in navbarPanel.Controls)
                if (b == button)
                {
                    sidebarPanel.Top = b.Top;
                    b.ForeColor = Color.Goldenrod;
                }
                else if (b is Button)
                    b.ForeColor = Color.WhiteSmoke;
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            settingsContainer.Visible = false;
            notificationsAlertLbl.Visible = false;
            settingsBtn.BackColor = Color.Transparent;

            if (notificationsContainer.Visible == false)
            {
                notificationsContainer.Visible = true;
                connectPanel.Visible = true;
                connectPanel.Left = notificationsBtn.Left;
                notificationsContainer.BringToFront();
                notificationsBtn.BackColor = Color.Goldenrod;
            }
            else
            {
                notificationsContainer.Visible = false;
                connectPanel.Visible = false;
                notificationsBtn.BackColor = Color.Transparent;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            notificationsContainer.Visible = false;
            notificationsBtn.BackColor = Color.Transparent;

            if (settingsContainer.Visible == false)
            {
                settingsContainer.Visible = true;
                connectPanel.Visible = true;
                connectPanel.Left = settingsBtn.Left;
                settingsContainer.BringToFront();
                settingsBtn.BackColor = Color.Goldenrod;
            }
            else
            {
                settingsContainer.Visible = false;
                connectPanel.Visible = false;
                settingsBtn.BackColor = Color.Transparent;
            }
        }

        private void resetContextMenus()
        {
            notificationsContainer.Visible = false;
            connectPanel.Visible = false;
            notificationsBtn.BackColor = Color.Transparent;
            settingsContainer.Visible = false;
            settingsBtn.BackColor = Color.Transparent;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        // ================= SOCIAL MEDIA LINKS ====================
        private void loadSocialLinks()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM SocialLinks";
            cmd.CommandType = CommandType.Text;
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                facebookLink = r["facebook"].ToString();
                twitterLink = r["twitter"].ToString();
                instagramLink = r["instagram"].ToString();
                askfmLink = r["askfm"].ToString();
            }
            r.Close();
            conn.Close();
        }

        private void facebookBtn_Click(object sender, EventArgs e)
        {
            if (!facebookLink.Equals(""))
                System.Diagnostics.Process.Start(facebookLink);
            else
                MessageBox.Show("There's No Corresponding Link Associated Yet !!", "SOCIAL LINKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void twitterBtn_Click(object sender, EventArgs e)
        {
            if (!twitterLink.Equals(""))
                System.Diagnostics.Process.Start(twitterLink);
            else
                MessageBox.Show("There's No Corresponding Link Associated Yet !!", "SOCIAL LINKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void instagramBtn_Click(object sender, EventArgs e)
        {
            if (!instagramLink.Equals(""))
                System.Diagnostics.Process.Start(instagramLink);
            else
                MessageBox.Show("There's No Corresponding Link Associated Yet !!", "SOCIAL LINKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void askfmBtn_Click(object sender, EventArgs e)
        {
            if (!askfmLink.Equals(""))
                System.Diagnostics.Process.Start(askfmLink);
            else
                MessageBox.Show("There's No Corresponding Link Associated Yet !!", "SOCIAL LINKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
             openForm(new MessagesForm(false));
             highlightSelectedButton(homeBtn);
        }

        private void changeMailBtn_Click(object sender, EventArgs e)
        {
            openForm(new ChangeEmailForm());
            highlightSelectedButton(homeBtn);
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            openForm(new ChangePasswordForm());
            highlightSelectedButton(homeBtn);
        }

        // =========================================================

        private void showRoomsBtn_Click(object sender, EventArgs e)
        {
            openForm(new RoomsForm(this));
        }

        private void showRoomsBtn_MouseEnter(object sender, EventArgs e)
        {
            showRoomsBtn.BackColor = Color.FromArgb(50, 0, 255, 0);
            showRoomsBtn.ForeColor = Color.WhiteSmoke;
        }

        private void showRoomsBtn_MouseLeave(object sender, EventArgs e)
        {
            showRoomsBtn.BackColor = Color.Goldenrod;
            showRoomsBtn.ForeColor = Color.Crimson;
        }

    }
}
