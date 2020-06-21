// Andronic Tudor - 3121A

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace inchirieri_auto_form
{
    public partial class AngajatiForm : Form
    {
        Color lblColor = Color.Black;
        private const char DELIMITER = ' ';
        Useri LogInUser;
        public AngajatiForm(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
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
            Main mainMenu = new Main(LogInUser);
            mainMenu.Show();
        }

        private void masiniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasiniForm masiniForm = new MasiniForm(LogInUser);
            masiniForm.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm clientiForm = new ClientiForm(LogInUser);
            clientiForm.Show();
        }

        private void ResetareControale()
        {
            // Reset all input
            txtCnp.Enabled = true;
            txtNume.Text = txtPrenume.Text = txtAdresa.Text = txtNrTel.Text = txtCnp.Text = string.Empty;
            cmbFunctie.SelectedItem = null;
        }

        private void SetLblColor()
        {
            // Set BackColor for all labels
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

        private void afisare_date()
        {
            // Display all the employees
            ResetareControale();
            lblInfo.Visible = false;
            dgvAfisare.DataSource = null;
            List<Angajati> angajati = SqliteConnectAngajati.LoadAngajati();
            dgvAfisare.DataSource = angajati;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            afisare_date();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            // Search for a employee
            lblInfo.Visible = false;
            txtCnp.Enabled = true;
            Angajati a = SqliteConnectAngajati.SearchAngajatByCnp(txtCnp.Text);
            if (a == null)
            {
                lblInfo.Text = "Nu exista nici un angajat cu acest CNP";
                lblInfo.Visible = true;
            }
            else
            {
                // Set employee data to all imput fields
                FileToFormData(a);
                lblInfo.Text = "Angajatul a fost gasit";
                lblInfo.Visible = true;
            }
        }

        private void FileToFormData(Angajati a)
        {
            // Set employee data to all imput fields
            txtCnp.Enabled = false;
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
            // Update employee data
            lblInfo.Visible = false;
            if (txtCnp.Text.Length == 0)
            {
                lblInfo.Text = "Introdu CNP-ul clinetului cautat";
                lblInfo.Visible = true;
                return;
            }
            Angajati angajat = SqliteConnectAngajati.SearchAngajatByCnp(txtCnp.Text);
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
                    SqliteConnectAngajati.UpdateAngajat(angajat);
                    lblInfo.Text = "Datele angajatului au fost modificate";
                    lblInfo.Visible = true;
                    ResetareControale();
                    afisare_date();
                }
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            // Filter employees
            List<Angajati> angajati = SqliteConnectAngajati.LoadAngajati();
            List<Angajati> angajatiFiltrati = new List<Angajati>();
            DateTime dataAngajare = dtpAngajare.Value;
            foreach (Angajati a in angajati)
                if (a.DataAngajare.Date == dataAngajare.Date)
                    angajatiFiltrati.Add(a);
            dgvAfisare.DataSource = null;
            dgvAfisare.DataSource = angajatiFiltrati;
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            saveFile.ShowDialog();
            string numeFisier = saveFile.FileName;
            bool succes = SalvareAngajati(numeFisier);
            if (succes)
                lblInfo.Text = "Fisierul a fost scris";
            else
                lblInfo.Text = "Scrierea in fisier nu a fost realizata";
            lblInfo.Visible = true;
        }

        private bool SalvareAngajati(string numeFisier)
        {
            // Save employees data to a specific text file
            bool succes = false;
            List<Angajati> salvareAngajati = SqliteConnectAngajati.LoadAngajati();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (Angajati a in salvareAngajati)
                        swFisierText.WriteLine(a.ConversieLaSir(DELIMITER));
                }
                succes = true;
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return succes;
        }

        private void dgvAfisare_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAfisare.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgvAfisare.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAfisare.Rows[selectedrowindex];
                string cnp = Convert.ToString(selectedRow.Cells["cnp"].Value);
                Angajati a = SqliteConnectAngajati.SearchAngajatByCnp(cnp);
                FileToFormData(a);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }
    }
}
