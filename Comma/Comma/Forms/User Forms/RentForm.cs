using System;
using System.Windows.Forms;

namespace Comma
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
            generateQuote();
        }
        public RentForm(int roomId)
        {
            InitializeComponent();
            generateQuote();
        }
        private void generateQuote()
        {
            string[] quotes; quotes = new string[6];
            quotes[0] = "Here is a place to work outside work...";
            quotes[1] = "Love for all, Hatred for none.";
            quotes[2] = "Change the world by being yourself.";
            quotes[3] = "Every moment is a fresh beginning.";
            quotes[4] = "Never regret anything that made you smile.";
            quotes[5] = "Die with memories, not dreams.";
            Random r = new Random();
            quoteLbl.Text = quotes[r.Next(6)];
        }
    }
}
