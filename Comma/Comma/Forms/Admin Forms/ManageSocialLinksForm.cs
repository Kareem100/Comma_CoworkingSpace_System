using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Comma.Forms.Admin_Forms
{
    public partial class ManageSocialLinksForm : Form
    {
        private SqlConnection conn;
        private AdminHomeForm adminHome;

        public ManageSocialLinksForm(AdminHomeForm homeForm)
        {
            InitializeComponent();
            adminHome = homeForm;
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            loadSocialLinks();
        }

        // ================= FEILDS FOCUS EFFECTS ======================
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

        private void loadSocialLinks()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM SocialLinks";
            cmd.CommandType = CommandType.Text;
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                fbTxt.Text = r["facebook"].ToString();
                twTxt.Text = r["twitter"].ToString();
                insTxt.Text = r["instagram"].ToString();
                askTxt.Text = r["askfm"].ToString();
            }
            r.Close();
        }

        private void addLinksBtn_Click(object sender, EventArgs e)
        {
            string fb = fbTxt.Text, tw = twTxt.Text, inst = insTxt.Text, ask = askTxt.Text;
            try
            {
                if (fb.Equals("facebook"))
                    fb = "";
                if (tw.Equals("twitter"))
                    tw = "";
                if (inst.Equals("instagram"))
                    inst = "";
                if (ask.Equals("askfm"))
                    ask = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "addSocialLinks";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fa", fb);
                cmd.Parameters.AddWithValue("@tw", tw);
                cmd.Parameters.AddWithValue("@ins", inst);
                cmd.Parameters.AddWithValue("@ask", ask);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            adminHome.setSocialLinks(fb, tw, inst, ask);
            MessageBox.Show("The Social Links has been Updated Successfully !", "SOCIAL LINKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageSocialLinksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
