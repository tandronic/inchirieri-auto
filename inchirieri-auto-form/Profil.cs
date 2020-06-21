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
        Clienti client;
        bool actualizare = true;
        public Profil(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
            client = SqliteConnectClienti.SearchClientByUserId(LogInUser.IdUser);
            if (client != null)
                FileToFormData(client);
            else
                actualizare = false;
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
        private void FileToFormData(Clienti c)
        {
            // Set client data to all imput fields
            txtCnp.Enabled = false;
            txtNume.Text = c.Nume;
            txtPrenume.Text = c.Prenume;
            txtAdresa.Text = c.Adresa;
            txtCnp.Text = c.Cnp;
            txtNrTel.Text = c.NumarTelefon;
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
            if(!actualizare)
                txtCnp.Enabled = true;
            // Set default BackColor for all labels
            SetLblColor();
            if (validare())
            {
                // Add a new client if the data is valid
                if(!actualizare)
                    client = new Clienti();
                client.Nume = txtNume.Text;
                client.Prenume = txtPrenume.Text;
                client.NumarTelefon = txtNrTel.Text;
                client.Adresa = txtAdresa.Text;
                client.Cnp = txtCnp.Text;
                if (actualizare)
                    SqliteConnectClienti.UpdateClient(client);
                else
                    SqliteConnectClienti.SaveClient(client, LogInUser.IdUser);
                actualizare = true;
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
