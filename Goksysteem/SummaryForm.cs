using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goksysteem
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();

            using (var sr = new StreamReader("Tokens.txt"))
            {
                lbTokens.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void lbSummary_Click(object sender, EventArgs e)
        {
            var summaryForm = new SummaryForm();
            this.Hide();
            summaryForm.Show(this);
        }

        private void lbStake_Click(object sender, EventArgs e)
        {
            var gamesForm = new GamesForm();
            this.Hide();
            gamesForm.Show(this);
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show(this);
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {
            var homeForm = new HomeForm();
            this.Hide();
            homeForm.Show(this);
        }

        private void txbHistory_TextChanged(object sender, EventArgs e)
        {
            using (var sr = new StreamReader("History.txt"))
            {
                txbHistory.Text = sr.ReadLine();
                sr.Close();
            }
        }
    }
}
