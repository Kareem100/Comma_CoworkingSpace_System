using System.Windows.Forms;

namespace Comma.Forms.Admin_Forms
{
    public partial class ShowRentsForm : Form
    {
        private AdminHomeForm homeForm;
        public ShowRentsForm()
        {
            InitializeComponent();
        }
        public ShowRentsForm(AdminHomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            homeForm.openRentsInformation();
        }
    }
}
