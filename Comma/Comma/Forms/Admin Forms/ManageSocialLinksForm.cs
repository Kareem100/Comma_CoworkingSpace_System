using System;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class ManageSocialLinksForm : Form
    {
        private string fb, tw, ins, ask;
        public ManageSocialLinksForm()
        {
            InitializeComponent();
            fb = tw = ins = ask = "";
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
        }
    }
}
