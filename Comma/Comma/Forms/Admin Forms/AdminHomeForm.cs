using Comma.CustomClasses;
using Comma.Forms.Admin_Forms;
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
    public partial class AdminHomeForm : Form
    {
        // ============================================================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );
        // ============================================================

        private Form activeForm = null;
        private string facebookLink, twitterLink, instagramLink, askfmLink;

        public AdminHomeForm()
        {
            InitializeComponent();
            sidebarPanel.Top = homeBtn.Top;
            homeBtn.ForeColor = Color.Goldenrod;settingsContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingsContainer.Width, settingsContainer.Height, 15, 15));
            showRoomsBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showRoomsBtn.Width, showRoomsBtn.Height, 30, 30));
            notificationsAlertLbl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, notificationsAlertLbl.Width, notificationsAlertLbl.Height, 100, 100));
            string[] names = GlobalData.userFullName.Split(' ');
            userNameLbl.Text = names[0][0] + "." + names[1];
            facebookLink = twitterLink = instagramLink = askfmLink = "";
            loadSocialLinks();
            loadMessagesIfAny();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (settingsContainer.Visible == false)
            {
                settingsContainer.Visible = true;
                connectPanel.Visible = true;
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
            connectPanel.Visible = false;
            settingsContainer.Visible = false;
            settingsBtn.BackColor = Color.Transparent;
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

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            openForm(new MessagesForm(true));
            highlightSelectedButton(homeBtn);
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

        private void showRoomsBtn_MouseEnter(object sender, EventArgs e)
        {
            showRoomsBtn.BackColor = Color.DodgerBlue;
            showRoomsBtn.ForeColor = Color.WhiteSmoke;
        }

        private void showRoomsBtn_MouseLeave(object sender, EventArgs e)
        {
            showRoomsBtn.BackColor = Color.Goldenrod;
            showRoomsBtn.ForeColor = Color.Crimson;
        }

        // ================== NAVIGATION BAR BUTTONS ==================
        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            highlightSelectedButton(homeBtn);
        }

        private void rentsBtn_Click(object sender, EventArgs e)
        {
            openForm(new ShowRentsForm(this));
            highlightSelectedButton(rentsBtn);
        }

        public void openRentsForm()
        {
            openForm(new ShowRentsForm(this));
        }

        public void openRentsInformation(string RequestedID, string RoomName)
        {
            openForm(new RentInformationForm(this, RequestedID, RoomName));
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            openForm(new ManageRoomsForm());
            highlightSelectedButton(roomsBtn);
        }
        public void RoomsBtn_Click(object sender, EventArgs e, string roomID, string choice)
        {
            openForm(new ManageRoomsForm(e, roomID, choice));
            highlightSelectedButton(roomsBtn);
        }

        private void adminsBtn_Click(object sender, EventArgs e)
        {
            openForm(new ManageAdminsForm());
            highlightSelectedButton(adminsBtn);
        }

        private void socialLinksBtn_Click(object sender, EventArgs e)
        {
            openForm(new ManageSocialLinksForm(this));
            highlightSelectedButton(socialLinksBtn);
        }
        public void setSocialLinks(string facebook, string twitter, string insta, string ask)
        {
            facebookLink = facebook;
            twitterLink = twitter;
            instagramLink = insta;
            askfmLink = ask;
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            openForm(new showFeedbacksForm());
            highlightSelectedButton(feedbackBtn);
        }

        private void showRoomsBtn_Click(object sender, EventArgs e)
        {
            openForm(new DisplayRoomsForm(this));
        }

        private void highlightSelectedButton(Button selectedButton)
        {
            foreach (Control b in navbarPanel.Controls)
                if (b == selectedButton)
                {
                    sidebarPanel.Top = b.Top;
                    b.ForeColor = Color.Goldenrod;
                }
                else if (b is Button)
                    b.ForeColor = Color.WhiteSmoke;
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
        // ==============================================================

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
        // =========================================================

        // ==================== NOTIFICATIONS ======================
        private void notificationsBtn_Click(object sender, EventArgs e)
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

        private void loadMessagesIfAny()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getAdminMessages";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("adminID", int.Parse(GlobalData.userID));

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

        // ==========================================================
    }
}
