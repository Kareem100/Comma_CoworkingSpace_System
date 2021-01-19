using System;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class DisplayRoomsForm : Form
    {
        // max lines for description is 3 lines
        private string roomName, description; // max chars is 45 in first 3 lines and 30 in last line..
        private int roomID, roomPrice;
        private char rentType;
        private AdminHomeForm homeForm;
        public DisplayRoomsForm(AdminHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminRoom room = new AdminRoom(homeForm);
            initializeRoom(ref room);
            containerPanel.Controls.Add(room);
        }
        private void initializeRoom(ref AdminRoom room)
        {
            /****************************************/ // FETCH FROM DATABASE
            roomName = "Jokky 2";
            description =
                "Lorem ipsum dolor sit amet, adipiscing elit.\nPraesent in aliquet justo. Donec eget risus,\n" +
                "Nam iaculis, nibh quis facilisis tempor,\nrisus ligula malesuada tortor.";
            roomID = 11;
            roomPrice = 120;
            rentType = 'H';
            /****************************************/

            Control[] name = room.Controls.Find("roomName", true);
            name[0].Text = roomName;
            Control[] id = room.Controls.Find("roomID", true);
            id[0].Text = roomID.ToString();
            Control[] desc = room.Controls.Find("roomDescription", true);
            desc[0].Text = description;
            string temp = (rentType == 'H') ? "£ / H" : "£ / D";
            string P = roomPrice.ToString() + temp;
            Control[] price = room.Controls.Find("roomPrice", true);
            price[0].Text = P;
        }

    }
}
