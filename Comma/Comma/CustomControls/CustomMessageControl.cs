using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Comma.Forms.Customer_Forms
{
    public partial class CustomMessage : UserControl
    {
        private int messageID;
        public CustomMessage(int messageId)
        {
            InitializeComponent();
            messageID = messageId;
        }

        private void deleteLbl_Click(object sender, EventArgs e)
        {
            fromLbl.Text = "";
            messageLbl.Text = "";
            deleteLbl.Size = Size.Empty;
            Size = Size.Empty;
            setMessageSeen();
        }

        private void setMessageSeen()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "makeMessageSeen";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("messageID", messageID);
            
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }

        public void setFromLbl(string fromLblTxt)
        {
            fromLbl.Text = fromLblTxt;
        }

        public void setMessageContent(string messageTxt)
        {
            messageLbl.Text = messageTxt;
            Height = messageLbl.Location.Y + messageLbl.Height;
        }

    }
}
