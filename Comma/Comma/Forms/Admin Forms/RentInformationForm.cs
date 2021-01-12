using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class RentInformationForm : Form
    {
        public RentInformationForm()
        {
            InitializeComponent();
        }

        private void acceptBtn_MouseEnter(object sender, EventArgs e)
        {
            acceptBtn.BackColor = Color.WhiteSmoke;
            acceptBtn.ForeColor = Color.DarkCyan;
        }

        private void acceptBtn_MouseLeave(object sender, EventArgs e)
        {
            acceptBtn.BackColor = Color.Transparent;
            acceptBtn.ForeColor = Color.Gold;
        }

        private void declineBtn_MouseEnter(object sender, EventArgs e)
        {
            declineBtn.BackColor = Color.WhiteSmoke;
            declineBtn.ForeColor = Color.Red;
        }

        private void declineBtn_MouseLeave(object sender, EventArgs e)
        {
            declineBtn.BackColor = Color.Transparent;
            declineBtn.ForeColor = Color.Crimson;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {

        }

        private void declineBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
