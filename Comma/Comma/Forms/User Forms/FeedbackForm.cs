using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Comma.CustomClasses;

namespace Comma
{
    public partial class FeedbackForm : Form
    {
        private SqlConnection con;

        public FeedbackForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }

        private void submitFeedbackBtn_Click(object sender, EventArgs e)
        {
            int neid, maid, customerID = int.Parse(GlobalData.userID);
            string satisfied, service, problem, feedbacktype;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "getfeedbackID";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@ID";
            p1.SqlDbType = SqlDbType.Int;
            p1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p1);
            cmd.ExecuteNonQuery();
            try
            {
                maid = Convert.ToInt32(cmd.Parameters["@ID"].Value.ToString());
                neid = maid + 1;
            }
            catch
            {
                neid = 1;
            }

            if (yesSatisfied.Checked)
                satisfied = yesSatisfied.Text;
            else if (noSatisfied.Checked)
                satisfied = noSatisfied.Text;
            else if (somewhatSatisfied.Checked)
                satisfied = somewhatSatisfied.Text;
            else
                satisfied = "none";

            if (yesProvided.Checked)
                service = yesProvided.Text;
            else if (noProvided.Checked)
                service = noProvided.Text;
            else if (somewhatProvided.Checked)
                service = somewhatProvided.Text;
            else
                service = "none";

            if (yesProblem.Checked)
                problem = yesProblem.Text;
            else if (noProblem.Checked)
                problem = noProblem.Text;
            else if (somewhatProblem.Checked)
                problem = somewhatProblem.Text;
            else
                problem = "none";

            if (comments.Checked)
                feedbacktype = comments.Text;
            else if (suggestions.Checked)
                feedbacktype = suggestions.Text;
            else if (questions.Checked)
                feedbacktype = questions.Text;
            else
                feedbacktype = "none";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2 = con.CreateCommand();
            cmd2.CommandText = "insertinfofeedback";
            cmd2.CommandType = CommandType.StoredProcedure;
            //cmd2.Parameters.AddWithValue("@feedback", neid);
            cmd2.Parameters.AddWithValue("@sattisfied", satisfied);
            cmd2.Parameters.AddWithValue("@service", service);
            cmd2.Parameters.AddWithValue("@problem", problem);
            cmd2.Parameters.AddWithValue("@feedbacktype", feedbacktype);
            cmd2.Parameters.AddWithValue("@tex", feedback.Text);
            cmd2.Parameters.AddWithValue("@custID", customerID);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Your Feedback has been sent successfully!\nOne of our admins will respond sonner.", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
            yesSatisfied.Checked = false; noSatisfied.Checked = false; somewhatSatisfied.Checked = false;
            yesProvided.Checked = false; noProvided.Checked = false; somewhatProvided.Checked = false;
            yesProblem.Checked = false; noProblem.Checked = false; somewhatProblem.Checked = false;
            comments.Checked = false; suggestions.Checked = false; questions.Checked = false;
            feedback.Text = "";
        }

        private void FeedbackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }
    }
}
