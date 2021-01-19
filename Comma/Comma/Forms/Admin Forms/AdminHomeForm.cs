using Comma.Forms.Admin_Forms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Comma
{
    public partial class AdminHomeForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private Form activeForm = null;
        public AdminHomeForm()
        {
            InitializeComponent();
            sidebarPanel.Top = homeBtn.Top;
            homeBtn.ForeColor = Color.Goldenrod;settingsContainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, settingsContainer.Width, settingsContainer.Height, 15, 15));
            showRoomsBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, showRoomsBtn.Width, showRoomsBtn.Height, 30, 30));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        public void openRentsInformation()
        {
            openForm(new RentInformationForm());
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            openForm(new ManageRoomsForm());
            highlightSelectedButton(roomsBtn);
        }
        public void roomsBtn_Click(object sender, EventArgs e, string roomID, string choice)
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
            openForm(new ManageSocialLinksForm());
            highlightSelectedButton(socialLinksBtn);
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

    }
}
