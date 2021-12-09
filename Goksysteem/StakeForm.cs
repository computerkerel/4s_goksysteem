using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goksysteem
{
    public partial class StakeForm : Form
    {
        public StakeForm()
        {
            InitializeComponent();
        }

        private void lbSummary_Click(object sender, EventArgs e)
        {
            var summaryForm = new SummaryForm();
            this.Hide();
            summaryForm.Show(this);
        }

        private void lbStake_Click(object sender, EventArgs e)
        {
            var stakeForm = new StakeForm();
            this.Hide();
            stakeForm.Show(this);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(txbStakeAmount.Text, out result))
            {
                lbError.Text = "Voer een getal in";
            }
            else
            {
                lbError.Text = "";
                lbMessage.Text = "Succesvol opgeslagen";
                txbStakeAmount.Text = "";
            }
        }
    }
}
