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
    public partial class Profil : Form
    {
        Useri LogInUser;
        Color lblColor = Color.Black;
        Clienti client=null;
        Angajati angajat=null;
        public Profil(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
            if(LogInUser.Type == UserType.Client)
            {
                client = SqliteConnectClienti.SearchClientByUserId(LogInUser.IdUser);
                FileToFormClientData(client);
            }
            if(LogInUser.Type == UserType.Angajat)
            {
                angajat = SqliteConnectAngajati.SearchAngajatByUserId(LogInUser.IdUser);
                FileToFormAngajatData(angajat);
            }
        }

        private void SetLblColor()
        {
            // Set BackColor for all labels
            lblNume.BackColor = lblColor;
            lblPrenume.BackColor = lblColor;
            lblAdresa.BackColor = lblColor;
            lblNrTel.BackColor = lblColor;
            lblCnp.BackColor = lblColor;
        }

        private bool validare()
        {
            // Check if all fields are valid
            bool valid = true;
            if (validare_field(txtNume, lblNume) == false)
                valid = false;
            if (validare_field(txtPrenume, lblPrenume) == false)
                valid = false;
            if (validare_field(txtCnp, lblCnp) == false)
                valid = false;
            if (validare_field(txtNrTel, lblNrTel) == false)
                valid = false;
            return valid;
        }
        private void FileToFormClientData(Clienti c)
        {
            // Set client data to all imput fields
            if(c.Cnp.Length != 0)
                txtCnp.Enabled = false;
            txtNume.Text = c.Nume;
            txtPrenume.Text = c.Prenume;
            txtAdresa.Text = c.Adresa;
            txtCnp.Text = c.Cnp;
            txtNrTel.Text = c.NumarTelefon;
        }

        private void FileToFormAngajatData(Angajati a)
        {
            // Set client data to all imput fields
            if(a.Cnp.Length != 0)
                txtCnp.Enabled = false;
            txtNume.Text = a.Nume;
            txtPrenume.Text = a.Prenume;
            txtAdresa.Text = a.Adresa;
            txtCnp.Text = a.Cnp;
            txtNrTel.Text = a.NumarTelefon;
        }

        private bool validare_field(TextBox txtbox, Label lbl)
        {
            // Check if one field is valid
            if (txtbox.Text.Length == 0)
            {
                lbl.BackColor = Color.Red;
                return false;
            }
            if (txtbox == txtCnp)
            {
                if (txtbox.Text.Length == 0 || Utils.CNPValidate(txtbox.Text) == false)
                {
                    lbl.BackColor = Color.Red;
                    return false;
                }
            }
            if (txtbox == txtNrTel)
            {
                if (txtbox.Text.Length == 0 || Utils.PhoneValidate(txtbox.Text) == false)
                {
                    lbl.BackColor = Color.Red;
                    return false;
                }
            }
            return true;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if((client != null && client.Cnp.Length == 0) || (angajat != null && angajat.Cnp.Length == 0))
                txtCnp.Enabled = true;
            // Set default BackColor for all labels
            SetLblColor();
            if (validare())
            {
                // Add a new client if the data is valid
                if(LogInUser.Type == UserType.Client)
                {
                    client.Nume = txtNume.Text;
                    client.Prenume = txtPrenume.Text;
                    client.NumarTelefon = txtNrTel.Text;
                    client.Adresa = txtAdresa.Text;
                    client.Cnp = txtCnp.Text;
                    SqliteConnectClienti.UpdateClient(client);
                }
                else
                {
                    angajat.Nume = txtNume.Text;
                    angajat.Prenume = txtPrenume.Text;
                    angajat.NumarTelefon = txtNrTel.Text;
                    angajat.Adresa = txtAdresa.Text;
                    angajat.Cnp = txtCnp.Text;
                    SqliteConnectAngajati.UpdateAngajat(angajat);
                }
                
                lblInfo.Text = "Datele au fost actualizate";
                lblInfo.Visible = true;
            }
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
    }
}
