// Andronic Tudor - 3121A

using LibrarieModele;
using System;
using System.Windows.Forms;

namespace inchirieri_auto_form
{
    public partial class Main : Form
    {
        Useri LogInUser;
        public Main(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
            if(LogInUser.Type == UserType.Client)
            {
                btnAngajati.Visible = false;
                btnClienti.Visible = false;
                btnMasini.Text = "Inchirieaza";
                btnProfil.Location = new System.Drawing.Point(263, 93);
                btnCont.Location = new System.Drawing.Point(263, 161);
                btnLogOut.Location = new System.Drawing.Point(263, 231);
            }
            else if(LogInUser.Type == UserType.Angajat)
            {
                btnAngajati.Visible = false;
                btnProfil.Location = new System.Drawing.Point(263, 161);
                btnCont.Location = new System.Drawing.Point(263, 231);
                btnLogOut.Location = new System.Drawing.Point(263, 298);
            }
            else
            {
                btnProfil.Visible = false;
                btnCont.Location = new System.Drawing.Point(263, 231);
                btnLogOut.Location = new System.Drawing.Point(263, 298);
            }
        }

        private void btnMasini_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (LogInUser.Type == UserType.Client)
            {
                InchiriazaMasina InchirieazaForm = new InchiriazaMasina(LogInUser);
                InchirieazaForm.Show();
            }
            else
            {
                MasiniForm masiniForm = new MasiniForm(LogInUser);
                masiniForm.Show();
            }
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm ClientForm = new ClientiForm(LogInUser);
            ClientForm.Show();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            this.Hide();
            AngajatiForm angajatiForm = new AngajatiForm(LogInUser);
            angajatiForm.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetariCont ContForm = new SetariCont(LogInUser);
            ContForm.Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil ProfileForm = new Profil(LogInUser);
            ProfileForm.Show();
        }
    }
}
