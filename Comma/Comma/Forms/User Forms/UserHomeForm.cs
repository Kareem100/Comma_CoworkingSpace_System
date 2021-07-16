using Comma.CustomClasses;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Comma
{
    public partial class UserHomeForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse,  int nHeightEllipse
        );

        private Form activeForm = null;

        public UserHomeForm()
        {
            InitializeComponent();
            sidebarPanel.Top = homeBtn.Top;
            homeBtn.ForeColor = Color.Goldenrod;
            notificationsContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, notificationsContainer.Width, notificationsContainer.Height, 15, 15));
            settingsContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingsContainer.Width, settingsContainer.Height, 15, 15));
            showRoomsBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showRoomsBtn.Width, showRoomsBtn.Height, 30, 30));
            initializeQuotes();
            string[] names = GlobalData.userFullName.Split(' ');
            userNameLbl.Text = names[0][0] + "." + names[1];
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
            this.WindowState = FormWindowState.Minimized;
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

        // DATABASE PART
        // ADD MESSAGE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Panel border = new Panel();
            border.BackColor = Color.Silver;
            border.Width = notificationsContainer.Width - 6;
            border.Height = 4;
            Label L = new Label();
            L.Text = "NEW LABEL...";
            L.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            notificationsContainer.Controls.Add(border);
            notificationsContainer.Controls.Add(L);

            notificationsContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, notificationsContainer.Width, notificationsContainer.Height, 15, 15));
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
            this.Close();
        }

        private void openLoginForm(Object obj)
        {
            Application.Run(new LoginForm());
        }

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
