using System;
using Comma.Forms;
using System.Windows.Forms;

namespace Comma
{
    public partial class RoomsForm : Form
    {   // max lines for description is 3 lines
        private string roomName, description; // max chars is 45 in first 3 lines and 30 in last line..
        private int roomID, roomPrice;
        private char rentType;
        private UserHomeForm homeForm;
        public RoomsForm(UserHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        // DATAPASE PART
        private void button1_Click(object sender, EventArgs e)
        {
            roomControl room = new roomControl(homeForm);
            initializeRoom(ref room);
            containerPanel.Controls.Add(room);
        }

        private void initializeRoom(ref roomControl room)
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
            string temp = (rentType=='H') ? "£ / H" : "£ / D";
            string P = roomPrice.ToString() + temp;
            Control[] price = room.Controls.Find("roomPrice", true);
            price[0].Text = P;
        }
    }
}
