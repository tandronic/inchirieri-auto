// Andronic Tudor - 3121A

using LibrarieModele;
using NivelAccesDate;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace inchirieri_auto_form
{
    public partial class SetariCont : Form
    {
        Useri LogInUser;
        Color lblColor = Color.Black;
        public SetariCont(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
            txtUsername.Text = LogInUser.Username;
        }

        private void Profil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main MainForm = new Main(LogInUser);
            MainForm.Show();
        }

        private bool ValidareParola()
        {
            if (SqliteConnectUseri.Login(LogInUser.Username, txtCurrentPassword.Text) == null)
                return false;
            return true;
        }

        private bool ValidareUsername()
        {
            if (SqliteConnectUseri.SearchUser(txtUsername.Text) != null)
                return false;
            return true;
        }

        private void SetLblColor()
        {
            // Set BackColor for all labels
            lblUsername.BackColor = lblColor;
            lblCurrentPassword.BackColor = lblColor;
            lblPassword.BackColor = lblColor;
            lblPassword2.BackColor = lblColor;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SetLblColor();
            lblInfo.Visible = false;
            string username = null;
            string password = null;
            bool update = true;
            if (ValidareParola())
            {
                if (txtUsername.Text.Length == 0)
                    username = LogInUser.Username;
                else
                {
                    if (ValidareUsername())
                        username = txtUsername.Text;
                    else
                    {
                        lblInfo.Text = "Exista deja un utilizator cu acest nume";
                        lblInfo.Visible = true;
                        update = false;
                        lblUsername.BackColor = Color.Red;
                    }
                }
                if (txtPassword1.Text.Length != 0 && txtPassword2.Text.Length != 0 && txtPassword1.Text.Equals(txtPassword2.Text))
                {
                    if (Utils.PasswordValidate(txtPassword1.Text))
                    {
                        password = txtPassword1.Text;
                    }
                    else
                    {
                        lblInfo.Text = "Parola trebuie sa aibe 8 caractere, o litera mare si o cifra";
                        lblInfo.Visible = true;
                        update = false;
                        lblPassword.BackColor = Color.Red;
                        lblPassword2.BackColor = Color.Red;
                    }
                }
                else if(username.Equals(LogInUser.Username))
                {
                    update = false;
                    lblPassword.BackColor = Color.Red;
                    lblPassword2.BackColor = Color.Red;
                    lblUsername.BackColor = Color.Red;
                    lblInfo.Text = "Introdu o parola noua sau un numde de utilizator nou";
                    lblInfo.Visible = true;
                }
                if (update)
                {
                    LogInUser.Username = username;
                    if (password != null)
                        LogInUser.Password = password;
                    SqliteConnectUseri.UpdateUser(LogInUser);
                    lblInfo.Text = "Date au fost actualizate";
                    lblInfo.Visible = true;
                }
            }
            else
            {
                lblInfo.Text = "Pentru orice actualizare trebuie sa introduci parola curenta valida";
                lblInfo.Visible = true;
                lblCurrentPassword.BackColor = Color.Red;
            }
        }
    }
}
