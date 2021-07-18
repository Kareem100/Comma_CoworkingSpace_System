using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Comma.Forms.Admin_Forms
{
    public partial class ManageSocialLinksForm : Form
    {
        SqlConnection conn;
        public ManageSocialLinksForm()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        // =============================================================

        private void fbTxt_Enter(object sender, EventArgs e)
        {
            if (fbTxt.Text == "facebook")
                fbTxt.Text = "";
        }

        private void fbTxt_Leave(object sender, EventArgs e)
        {
            if (fbTxt.Text == "")
                fbTxt.Text = "facebook";
        }

        private void twTxt_Enter(object sender, EventArgs e)
        {
            if (twTxt.Text == "twitter")
                twTxt.Text = "";
        }

        private void twTxt_Leave(object sender, EventArgs e)
        {
            if (twTxt.Text == "")
                twTxt.Text = "twitter";
        }

        private void insTxt_Enter(object sender, EventArgs e)
        {
            if (insTxt.Text == "instagram")
                insTxt.Text = "";
        }

        private void insTxt_Leave(object sender, EventArgs e)
        {
            if (insTxt.Text == "")
                insTxt.Text = "instagram";
        }

        private void askTxt_Enter(object sender, EventArgs e)
        {
            if (askTxt.Text == "askfm")
                askTxt.Text = "";
        }

        private void askTxt_Leave(object sender, EventArgs e)
        {
            if (askTxt.Text == "")
                askTxt.Text = "askfm";
        }
        // =============================================================
         private void addLinksBtn_Click(object sender, EventArgs e)
        {
            // DATABASE PART
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "addlinks";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fa", fbTxt.Text);
            cmd.Parameters.AddWithValue("@tw", twTxt.Text);
            cmd.Parameters.AddWithValue("@ins", insTxt.Text);
            cmd.Parameters.AddWithValue("@ask", askTxt.Text);
            cmd.ExecuteNonQuery();

            fbTxt.Text = ""; twTxt.Text = ""; insTxt.Text = ""; askTxt.Text = "";
        }

        private void ManageSocialLinksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
