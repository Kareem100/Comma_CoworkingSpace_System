using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Comma
{
    public partial class TopCustomersForm : Form
    {
        private SqlConnection conn;

        public TopCustomersForm()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }

        private void TopCustomersForm_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd = conn.CreateCommand();
            cmd.CommandText = "sortuser";
            SqlDataReader r = cmd.ExecuteReader();
            int i = 0;
            while (r.Read())
            {
                if (r["userType"].ToString() == "Admin")
                    continue;
                i++;
                string[] row = new string[] { i.ToString(), r["userID"].ToString(), r["userName"].ToString(), r["userMail"].ToString(), r["userPhone"].ToString(), r["userNumberOfRents"].ToString() };
                dgv.Rows.Add(row);
            }
        }

        private void TopCustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
