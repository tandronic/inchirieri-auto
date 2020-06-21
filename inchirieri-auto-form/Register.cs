// Andronic Tudor - 3121A

using LibrarieModele;
using NivelAccesDate;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace inchirieri_auto_form
{
    public partial class Register : Form
    {
        private Color lblColor = Color.Black;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void LoginRedirect()
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginRedirect();
        }
        private void SetLblColor()
        {
            // Set BackColor for all labels
            lblUsername.BackColor = lblColor;
            lblPassword.BackColor = lblColor;
            lblPassword2.BackColor = lblColor;
            lblUserType.BackColor = lblColor;
        }

        private UserType GetSelectedUserType()
        {
            if (rdbAngajat.Checked)
                return UserType.Angajat;
            if (rdbClient.Checked)
                return UserType.Client;
            if (rdbAdmin.Checked)
                return UserType.Admin;
            return UserType.UserInvalid;
        }

        private bool validare()
        {
            // Check if all fields are valid
            bool valid = true;
            if (validare_field(txtUsername, lblUsername) == false)
                valid = false;
            if (validare_field(txtPassword1, lblPassword) == false)
                valid = false;
            if (validare_field(txtPassword2, lblPassword2) == false)
                valid = false;
            if (!txtPassword1.Text.Equals(txtPassword2.Text))
            {
                valid = false;
                lblPassword.BackColor = Color.Red;
                lblPassword2.BackColor = Color.Red;
                lblInfo.Text = "Cele 2 parole nu coincid";
                lblInfo.Visible = true;
            }
            if (!Utils.PasswordValidate(txtPassword1.Text))
            {
                valid = false;
                lblPassword.BackColor = Color.Red;
                lblPassword2.BackColor = Color.Red;
                lblInfo.Text = "Parola trebuie sa contina cel putin 8 caractere, o litera mica, o litera mare si o cifra";
                lblInfo.Visible = true;
            }
           if(GetSelectedUserType() == UserType.UserInvalid)
            {
                valid = false;
                lblUserType.BackColor = Color.Red;
            }
           if(SqliteConnectUseri.SearchUser(txtUsername.Text) != null)
            {
                valid = false;
                lblUsername.BackColor = Color.Red;
                lblInfo.Text = "Exista un user cu acest Username";
                lblInfo.Visible = true;
            }
                
            return valid;
        }

        private bool validare_field(TextBox txtbox, Label lbl)
        {
            // Check if one field is valid
            if (txtbox.Text.Length == 0)
            {
                lbl.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            // Set default BackColor for all labels
            SetLblColor();
            if (validare())
            {
                // Add a new car if the data is valid
                Useri user = new Useri();
                user.Username = txtUsername.Text;
                user.Password = txtPassword1.Text;
                user.Type = GetSelectedUserType();
                user.dataActualizare = DateTime.Now;
                // Add a new user in the database
                SqliteConnectUseri.SaveUser(user);
                if(user.Type == UserType.Client)
                {
                    Clienti c = new Clienti();
                    user = SqliteConnectUseri.SearchUser(user.Username);
                    SqliteConnectClienti.SaveClient(c, user.IdUser);
                }
                if(user.Type == UserType.Angajat)
                {
                    Angajati a = new Angajati();
                    user = SqliteConnectUseri.SearchUser(user.Username);
                    SqliteConnectAngajati.SaveAngajat(a, user.IdUser);
                }
                LoginRedirect();
            }

        }
    }
}
