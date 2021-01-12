using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Comma.Forms
{
    public partial class roomControl : UserControl
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
        private UserHomeForm homeForm;

        public roomControl(UserHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            rentRoomBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, rentRoomBtn.Width, rentRoomBtn.Height, 50, 50));
            roomPrice.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, roomPrice.Width, roomPrice.Height, 40, 40));
        }

        private void rentRoomBtn_Click(object sender, EventArgs e)
        {
            homeForm.rentBtn_Click(sender, e, Int32.Parse(roomID.Text));
        }
    }
}
