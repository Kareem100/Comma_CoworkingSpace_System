using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.roomsBtn_Click(sender, e, roomID.Text, "EDIT ROOM");
        }

        private void removeRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.roomsBtn_Click(sender, e, roomID.Text, "REMOVE ROOM");
        }
    }
}
