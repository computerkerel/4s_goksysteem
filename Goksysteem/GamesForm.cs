using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goksysteem
{
    public partial class GamesForm : Form
    {
        public GamesForm()
        {
            InitializeComponent();
            fetchArray();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
            fetchArray();
>>>>>>> Stashed changes
=======
            fetchArray();
>>>>>>> Stashed changes
=======
            fetchArray();
>>>>>>> Stashed changes
=======
            fetchArray();
>>>>>>> Stashed changes
            listboxGames.Items.Clear();
            foreach (var m in games)
            {
                int team1 = m.team1_id;
                listboxGames.Items.Add(m);
            }
        }

        List<Games> games;

        public void fetchArray()
        {
            string url = "http://4s_schoolvoetbal.test/api/fetchinator";
            string output = "";
            using (WebClient wc = new WebClient())
            {
                output = wc.DownloadString(url);
            }
            games = JsonConvert.DeserializeObject<List<Games>>(output);
        }

        private void lbSummary_Click(object sender, EventArgs e)
        {
            var summaryForm = new SummaryForm();
            this.Hide();
            summaryForm.Show(this);
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {
            var homeForm = new HomeForm();
            this.Hide();
            homeForm.Show(this);
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show(this);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if(listboxGames.SelectedIndex == -1)
            {
                lbError.Text = "Selecteer een wedstrijd";
            }
            else
            {
                var stakeForm = new StakeForm();
                this.Hide();
                stakeForm.Show(this);
            }
        }
    }
}
