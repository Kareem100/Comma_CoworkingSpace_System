using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comma
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        private void addRoomLbl_Click(object sender, EventArgs e)
        {
            addRoomLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            addRoomLbl.ForeColor = Color.RoyalBlue;
            addRoomLbl.BorderStyle = BorderStyle.Fixed3D;
            addRoomLbl.Left = 28;
            editRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            editRoomLbl.ForeColor = Color.WhiteSmoke;
            editRoomLbl.BorderStyle = BorderStyle.None;
            editRoomLbl.Left = addRoomLbl.Left + addRoomLbl.Width;
            removeRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            removeRoomLbl.ForeColor = Color.WhiteSmoke;
            removeRoomLbl.BorderStyle = BorderStyle.None;
            removeRoomLbl.Left = editRoomLbl.Left + editRoomLbl.Width;
        }

        private void editRoomLbl_Click(object sender, EventArgs e)
        {
            editRoomLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            editRoomLbl.ForeColor = Color.RoyalBlue;
            editRoomLbl.BorderStyle = BorderStyle.Fixed3D;
            editRoomLbl.Left = 28;
            addRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            addRoomLbl.ForeColor = Color.WhiteSmoke;
            addRoomLbl.BorderStyle = BorderStyle.None;
            addRoomLbl.Left = editRoomLbl.Left + editRoomLbl.Width;
            removeRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            removeRoomLbl.ForeColor = Color.WhiteSmoke;
            removeRoomLbl.BorderStyle = BorderStyle.None;
            removeRoomLbl.Left = addRoomLbl.Left + addRoomLbl.Width;
        }

        private void removeRoomLbl_Click(object sender, EventArgs e)
        {
            removeRoomLbl.BackColor = Color.FromArgb(200, 250, 205, 0);
            removeRoomLbl.ForeColor = Color.RoyalBlue;
            removeRoomLbl.BorderStyle = BorderStyle.Fixed3D;
            removeRoomLbl.Left = 28;
            addRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            addRoomLbl.ForeColor = Color.WhiteSmoke;
            addRoomLbl.BorderStyle = BorderStyle.None;
            addRoomLbl.Left = removeRoomLbl.Left + removeRoomLbl.Width;
            editRoomLbl.BackColor = Color.FromArgb(100, 0, 0, 0);
            editRoomLbl.ForeColor = Color.WhiteSmoke;
            editRoomLbl.BorderStyle = BorderStyle.None;
            editRoomLbl.Left = addRoomLbl.Left + addRoomLbl.Width;
        }
        private void hourlyTypeBtn_Click(object sender, EventArgs e)
        {
            hourlyTypeBtn.BackColor = Color.Green;
            hourlyTypeBtn.ForeColor = Color.Gold;
            dailyTypeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
            dailyTypeBtn.ForeColor = Color.WhiteSmoke;
        }

        private void dailyTypeBtn_Click(object sender, EventArgs e)
        {
            dailyTypeBtn.BackColor = Color.Green;
            dailyTypeBtn.ForeColor = Color.Gold;
            hourlyTypeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
            hourlyTypeBtn.ForeColor = Color.WhiteSmoke;
        }
    }
}
