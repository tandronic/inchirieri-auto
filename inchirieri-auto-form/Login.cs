// Andronic Tudor - 3121A

using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inchirieri_auto_form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register RegisterForm = new Register();
            RegisterForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Useri user;
            user = SqliteConnectUseri.Login(txtUsername.Text, txtPassword.Text);
            if(user != null)
            {
                this.Hide();
                Main MainForm = new Main(user);
                MainForm.Show();
            }
            else
            {
                lblUsername.BackColor = Color.Red;
                lblPassword.BackColor = Color.Red;
                lblInfo.Text = "Username-ul sau parola sunt invalide";
                lblInfo.Visible = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
