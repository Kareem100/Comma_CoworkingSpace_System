using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Comma.Forms
{
    public partial class UserRoom : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private UserHomeForm homeForm;

        public UserRoom(UserHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            rentRoomBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, rentRoomBtn.Width, rentRoomBtn.Height, 50, 50));
            roomPrice.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, roomPrice.Width, roomPrice.Height, 40, 40));
        }

        // RENT BUTTON EVENT
        private void rentRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.rentBtn_Click(sender, e, roomID.Text);
        }

        // =============== SET RANK IMAGES =================
        public void setRank(int rank)
        {
            pictureBoxRank.Visible = true;
            if (rank == 1)
                pictureBoxRank.Image = Properties.Resources.GoldenRank;
            else if (rank == 2)
                pictureBoxRank.Image = Properties.Resources.SilverRank;
            else
                pictureBoxRank.Image = Properties.Resources.BronzeRank;
        }

        // ============== CONTROLS SETTERS =================
        public void setRoomID(int id)
        {
            roomID.Text = id.ToString();
        }

        public void setRoomName(string name)
        {
            roomName.Text = name;
        }

        public void setRoomImage(Image img)
        {
            roomImage.Image = img;
        }

        public void setRoomDescription(string description)
        {
            roomDescription.Text = description;
        }

        public void setRoomPrice(string price)
        {
            roomPrice.Text = price;
        }
        // =================================================
    }
}
