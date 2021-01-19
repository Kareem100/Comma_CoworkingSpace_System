using System;
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

        private void rentRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.rentBtn_Click(sender, e, roomID.Text);
        }
    }
}
