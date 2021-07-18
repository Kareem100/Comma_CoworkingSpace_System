using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Comma
{
    public partial class showFeedbacksForm : Form
    {
        private SqlConnection conn;

        public showFeedbacksForm()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            showFeedbacks();
        }

        private void showFeedbacks()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "showfeedback";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader r = cmd.ExecuteReader();
            int i = 0;
            while (r.Read())
            {
                i++;
                string[] row = new string[]{i.ToString(),r["userID"].ToString(),r["userName"].ToString(),r["userMail"].ToString(),r["customerIsSatisfied"].ToString()
                                ,r["customerHadGoodService"].ToString(),r["customerHadProblems"].ToString(),r["feedbackType"].ToString(),r["feedbackContent"].ToString()};
                dgv.Rows.Add(row);
            }
        }

        private void showFeedbacksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
