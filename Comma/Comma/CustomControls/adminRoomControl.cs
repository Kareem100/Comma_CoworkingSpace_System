using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using Comma.CustomClasses;

namespace Comma.Forms.Admin_Forms
{
    public partial class AdminRoom : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, int nTopRect, int nRightRect,
           int nBottomRect, int nWidthEllipse, int nHeightEllipse
       );
        private AdminHomeForm homeForm;

        public AdminRoom(AdminHomeForm homeForm)
        {
            InitializeComponent();
            editRoomBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, editRoomBtn.Width, editRoomBtn.Height, 40, 40));
            removeRoomBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, removeRoomBtn.Width, removeRoomBtn.Height, 40, 40));
            this.homeForm = homeForm;
        }

        // EDIT BUTTON EVENT
        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.RoomsBtn_Click(sender, e, roomID.Text, GlobalData.editRoom);
        }

        // REMOVE BUTTON EVENT
        private void removeRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.RoomsBtn_Click(sender, e, roomID.Text, GlobalData.removeRoom);
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
