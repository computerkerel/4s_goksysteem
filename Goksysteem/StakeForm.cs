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
    public partial class StakeForm : Form
    {
        public StakeForm()
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
            int test = 0;
            int result;
            if (!int.TryParse(txbStakeAmount.Text, out result) || cbResult.Text.Length == 0)
            {
                lbError.Text = "Voer alle velden juist in";
            }
            else
            {
                //on af code doe nu filetoken - stakeamount.text
                using (var sr = new StreamReader("Tokens.txt"))
                {
                    int FileToken = Convert.ToInt16(sr.ReadToEnd());
                    test = FileToken - Convert.ToInt16(txbStakeAmount.Text);
                    sr.Close();
                    StreamWriter sw = new StreamWriter("Tokens.txt");
                    sw.WriteLine(test);
                    sw.Close();
                }

                lbError.Text = "";
                lbMessage.Text = "Succesvol opgeslagen";
                txbStakeAmount.Text = "";
                lbTokens.Text = Convert.ToString(test);
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            var gamesForm = new GamesForm();
            this.Hide();
            gamesForm.Show(this);
        }
    }
}
