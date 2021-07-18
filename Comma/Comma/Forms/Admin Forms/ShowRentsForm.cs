using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class ShowRentsForm : Form
    {
        private SqlConnection con;
        private AdminHomeForm homeForm;

        public ShowRentsForm(AdminHomeForm HF)
        {
            InitializeComponent();
            homeForm = HF;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow.Index != -1)
            {
                string RequestId = dgv.CurrentRow.Cells[1].Value.ToString();
                string RoomName = dgv.CurrentRow.Cells[3].Value.ToString();
                homeForm.openRentsInformation(RequestId, RoomName);
            }
        }

        private void ShowRentsForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("select reservationID,customerID,roomID,rentStartDate,rentEndDate,reservationPrice from Reservations where reservationState='Request'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = null;
            DataTable tlb = new DataTable();
            try
            {
                dr = cmd.ExecuteReader();
                tlb.Columns.Add("Request ID");
                tlb.Columns.Add("Customer Name");
                tlb.Columns.Add("Room");
                tlb.Columns.Add("From Day");
                tlb.Columns.Add("To Day");
                tlb.Columns.Add("Total Price");
                DataRow row;
                while (dr.Read()){
                    row = tlb.NewRow();
                    row["Request ID"] = dr[0].ToString();
                    row["Customer Name"] = getCustomerName(int.Parse(dr[1].ToString()));
                    row["Room"] = getRoomName(int.Parse(dr[2].ToString()));
                    DateTime date = DateTime.Parse(dr[3].ToString());
                    row["From Day"] = date.Date.Day + "/" + date.Date.Month + "/" + date.Date.Year; ;
                    date = DateTime.Parse(dr[4].ToString());
                    row["To Day"] = date.Date.Day + "/"+date.Date.Month+"/"+date.Date.Year;
                    row["Total Price"] = dr[5];
                    tlb.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
                dgv.DataSource = tlb;
            }
        }
        
        private string getRoomName(int Id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("select roomName from Rooms where roomID = "+Id, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr=null;
            string roomName = null;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    roomName = dr[0].ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return roomName;
         }
        
        private string getCustomerName(int Id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand("select userName from Users2 where userID = " + Id, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = null;
            string Customer = null;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Customer = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return Customer;
        }

    }
}
