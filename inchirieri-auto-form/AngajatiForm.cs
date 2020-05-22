using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace inchirieri_auto_form
{
    public partial class AngajatiForm : Form
    {
        IStocareDataAngajati adminAngajati;
        Color lblColor = Color.Black;
        public AngajatiForm()
        {
            InitializeComponent();
            adminAngajati = StocareFactory.GetAdministratorStocareAngajati();
            cmbFunctie.Items.Add(Functie.Director);
            cmbFunctie.Items.Add(Functie.Marketing);
            cmbFunctie.Items.Add(Functie.Mecanic);
            cmbFunctie.Items.Add(Functie.FemeieServiciu);
        }

        private void Angajati_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void meniuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main mainMenu = new Main();
            mainMenu.Show();
        }

        private void masiniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasiniForm masiniForm = new MasiniForm();
            masiniForm.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm clientiForm = new ClientiForm();
            clientiForm.Show();
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtAdresa.Text = txtNrTel.Text = txtCnp.Text = string.Empty;
            cmbFunctie.Items.Clear();
        }

        private void SetLblColor()
        {
            lblNume.BackColor = lblColor;
            lblPrenume.BackColor = lblColor;
            lblAdresa.BackColor = lblColor;
            lblNrTel.BackColor = lblColor;
            lblCnp.BackColor = lblColor;
            lblFunctie.BackColor = lblColor;
            lblDataAngajari.BackColor = lblColor;
        }

        private bool validare()
        {
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

        private bool validare_field(TextBox txtbox, Label lbl)
        {
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

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            SetLblColor();
            if (validare())
            {
                Angajati angajat = new Angajati();
                angajat.Nume = txtNume.Text;
                angajat.Prenume = txtPrenume.Text;
                angajat.NumarTelefon = txtNrTel.Text;
                angajat.Adresa = txtAdresa.Text;
                angajat.Cnp = txtCnp.Text;
                angajat.Functie = Utils.FunctieConvert(cmbFunctie.Text);
                angajat.DataAngajare = dtpAngajare.Value;
                adminAngajati.AddAngajat(angajat);
                lblInfo.Text = "Angajatul a fost adaugat";
                lblInfo.Visible = true;
                ResetareControale();
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            dgvAfisare.DataSource = null;
            List<Angajati> angajati = adminAngajati.GetAngajati();
            dgvAfisare.DataSource = angajati;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Angajati a = adminAngajati.GetAngajat(txtCnp.Text);
            if (a == null)
            {
                lblInfo.Text = "Nu exista nici un angajat cu acest CNP";
                lblInfo.Visible = true;
            }
            else
            {
                FileToFormData(a);
                if (txtCnp.Enabled == true)
                    txtCnp.Enabled = false;
                else
                    txtCnp.Enabled = true;
            }
        }

        private void FileToFormData(Angajati a)
        {
            txtNume.Text = a.Nume;
            txtPrenume.Text = a.Prenume;
            txtAdresa.Text = a.Adresa;
            txtCnp.Text = a.Cnp;
            txtNrTel.Text = a.NumarTelefon;
            cmbFunctie.SelectedItem = a.Functie;
            dtpAngajare.Value = a.DataAngajare;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (txtCnp.Text.Length == 0)
            {
                lblInfo.Text = "Introdu CNP-ul clinetului cautat";
                lblInfo.Visible = true;
                return;
            }
            Angajati angajat = adminAngajati.GetAngajat(txtCnp.Text);
            if (angajat == null)
            {
                lblInfo.Text = "Nu exista nici un angajat cu acest CNP";
                lblInfo.Visible = true;
            }
            else
            {
                SetLblColor();
                if (validare())
                {
                    angajat.Nume = txtNume.Text;
                    angajat.Prenume = txtPrenume.Text;
                    angajat.NumarTelefon = txtNrTel.Text;
                    angajat.Adresa = txtAdresa.Text;
                    angajat.Cnp = txtCnp.Text;
                    angajat.Functie = Utils.FunctieConvert(cmbFunctie.Text);
                    angajat.DataAngajare = dtpAngajare.Value;
                    adminAngajati.UpdateAngajat(angajat);
                    lblInfo.Text = "Datele angajatului au fost modificate";
                    lblInfo.Visible = true;
                }
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            List<Angajati> angajati = adminAngajati.GetAngajati();
            List<Angajati> angajatiFiltrati = new List<Angajati>();
            DateTime dataAngajare = dtpAngajare.Value;
            foreach (Angajati a in angajati)
                if (a.DataAngajare == dataAngajare)
                    angajatiFiltrati.Add(a);
            dgvAfisare.DataSource = null;
            dgvAfisare.DataSource = angajatiFiltrati;
        }
    }
}
