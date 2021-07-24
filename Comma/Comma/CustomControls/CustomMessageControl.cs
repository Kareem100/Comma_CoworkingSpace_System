using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comma.Forms.Customer_Forms
{
    public partial class CustomMessage : UserControl
    {
        public CustomMessage()
        {
            InitializeComponent();
        }

        private void deleteLbl_Click(object sender, EventArgs e)
        {
            fromLbl.Text = "";
            messageLbl.Text = "";
            deleteLbl.Size = Size.Empty;
            Size = Size.Empty;
        }

        public void setFromLbl(string fromLblTxt)
        {
            fromLbl.Text = fromLblTxt;
        }

        public void setMessageContetn(string messageTxt)
        {
            messageLbl.Text = messageTxt;
            Height = messageLbl.Location.Y + messageLbl.Height;
        }
    }
}
