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
            int customerID = int.Parse(GlobalData.userID);
            string satisfied, service, problem, feedbacktype;

            if (yesSatisfied.Checked)
                satisfied = yesSatisfied.Text;
            else if (noSatisfied.Checked)
                satisfied = noSatisfied.Text;
            else if (somewhatSatisfied.Checked)
                satisfied = somewhatSatisfied.Text;
            else
            {
                MessageBox.Show("Missing Data!\nWere You Satisfied with the customer service?", "FEEDBACK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yesProvided.Checked)
                service = yesProvided.Text;
            else if (noProvided.Checked)
                service = noProvided.Text;
            else if (somewhatProvided.Checked)
                service = somewhatProvided.Text;
            else
            {
                MessageBox.Show("Missing Data\nWas Our Customer Service Provided to you in Accessible Manner?", "FEEDBACK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yesProblem.Checked)
                problem = yesProblem.Text;
            else if (noProblem.Checked)
                problem = noProblem.Text;
            else if (somewhatProblem.Checked)
                problem = somewhatProblem.Text;
            else
            {
                MessageBox.Show("Missing Data!\nDid You Experience any Problems?", "FEEDBACK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comments.Checked)
                feedbacktype = comments.Text;
            else if (suggestions.Checked)
                feedbacktype = suggestions.Text;
            else if (questions.Checked)
                feedbacktype = questions.Text;
            else
            {
                MessageBox.Show("Missing Data\nPlease Chooce the Feedback Type.", "FEEDBACK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (feedback.Text.Length < 5)
            {
                MessageBox.Show("Invalid Data\nPlease Insert a valid Feedback Content to be Reviewed.", "FEEDBACK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2 = con.CreateCommand();
            cmd2.CommandText = "insertinfofeedback";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@sattisfied", satisfied);
            cmd2.Parameters.AddWithValue("@service", service);
            cmd2.Parameters.AddWithValue("@problem", problem);
            cmd2.Parameters.AddWithValue("@feedbacktype", feedbacktype);
            cmd2.Parameters.AddWithValue("@tex", feedback.Text);
            cmd2.Parameters.AddWithValue("@custID", customerID);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Your Feedback has been sent successfully!\nOne of our admins will respond sonner.", "FEEDBACK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
