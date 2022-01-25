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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void xz_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text.Length == 0 || txbPassword.Text.Length == 0)
            {
                lbError.Text = "Vul alle velden in";
            }
            else
            {
                var homeForm = new HomeForm();
                this.Hide();
                homeForm.Show(this);
            }

            if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
            {
                var adminForm = new AdminForm();
                this.Hide();
                adminForm.Show(this);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show(this);
        }
    }
}
