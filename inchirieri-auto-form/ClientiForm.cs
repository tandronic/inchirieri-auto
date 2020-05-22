using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace inchirieri_auto_form
{
    public partial class ClientiForm : Form
    {
        IStocareDataClienti adminClienti;
        IStocareDataMasini adminMasini;
        Color lblColor = Color.Black;
        public ClientiForm()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocareClienti();
            adminMasini = StocareFactory.GetAdministratorStocareMasini();
            AddNrMasini();
        }

        private void Clienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);

        }

        private void AddNrMasini()
        {
            List<Masini> masini = new List<Masini>();
            masini = adminMasini.GetMasini();
            foreach (Masini m in masini)
                cmbNrMasina.Items.Add(m.NumarInmatriculare);
        }

        private void meniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void masiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasiniForm masiniForm = new MasiniForm();
            masiniForm.Show();
        }

        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AngajatiForm angajatiForm = new AngajatiForm();
            angajatiForm.Show();
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtAdresa.Text = txtNrTel.Text = txtCnp.Text = string.Empty;
            cmbNrMasina.Items.Clear();
        }

        private void SetLblColor()
        {
            lblNume.BackColor = lblColor;
            lblPrenume.BackColor = lblColor;
            lblAdresa.BackColor = lblColor;
            lblNrTel.BackColor = lblColor;
            lblCnp.BackColor = lblColor;
            lblNumarMasina.BackColor = lblColor;
            lblDataInchiriere.BackColor = lblColor;
            lblDataSfarsitInc.BackColor = lblColor;
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
                Clienti client = new Clienti();
                client.Nume = txtNume.Text;
                client.Prenume = txtPrenume.Text;
                client.NumarTelefon = txtNrTel.Text;
                client.Adresa = txtAdresa.Text;
                client.Cnp = txtCnp.Text;
                client.NrMasinaInc = cmbNrMasina.Text;
                client.dataInchiriere = dtpStartInc.Value;
                client.dataSfarsitInc = dtpSfarsitInc.Value;
                adminClienti.AddClient(client);
                lblInfo.Text = "Clientul a fost adaugat";
                lblInfo.Visible = true;
                ResetareControale();
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            dgvAfisare.DataSource = null;
            List<Clienti> clienti = adminClienti.GetClienti();
            dgvAfisare.DataSource = clienti;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Clienti c = adminClienti.GetClient(txtCnp.Text);
            if (c == null)
            {
                lblInfo.Text = "Nu exista nici un client cu acest CNP";
                lblInfo.Visible = true;
            }
            else
            {
                FileToFormData(c);
                if (txtCnp.Enabled == true)
                    txtCnp.Enabled = false;
                else
                    txtCnp.Enabled = true;
            }
        }

        private void FileToFormData(Clienti c)
        {
            txtNume.Text = c.Nume;
            txtPrenume.Text = c.Prenume;
            txtAdresa.Text = c.Adresa;
            txtCnp.Text = c.Cnp;
            txtNrTel.Text = c.NumarTelefon;
            cmbNrMasina.SelectedItem = c.NrMasinaInc;
            dtpStartInc.Value = c.dataInchiriere;
            dtpSfarsitInc.Value = c.dataSfarsitInc;
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
            Clienti c = adminClienti.GetClient(txtCnp.Text);
            if (c == null)
            {
                lblInfo.Text = "Nu exista nici un client cu acest CNP";
                lblInfo.Visible = true;
            }
            else
            {
                SetLblColor();
                if (validare())
                {
                    c.Nume = txtNume.Text;
                    c.Prenume = txtPrenume.Text;
                    c.Adresa = txtAdresa.Text;
                    c.Cnp = txtCnp.Text;
                    c.NumarTelefon = txtNrTel.Text;
                    c.NrMasinaInc = cmbNrMasina.Text;
                    c.dataInchiriere = dtpStartInc.Value;
                    c.dataSfarsitInc = dtpStartInc.Value;
                    adminClienti.UpdateClient(c);
                    lblInfo.Text = "Datele clientului au fost modificate";
                    lblInfo.Visible = true;
                }
            }
        }

        private void dgvAfisare_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAfisare.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgvAfisare.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAfisare.Rows[selectedrowindex];
                string cnp = Convert.ToString(selectedRow.Cells["cnp"].Value);
                Clienti c = adminClienti.GetClient(cnp);
                FileToFormData(c);
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            List<Clienti> clienti = adminClienti.GetClienti();
            List<Clienti> clientiFiltrati = new List<Clienti>();
            DateTime startDate = dtpStartInc.Value;
            DateTime endDate = dtpSfarsitInc.Value;
            foreach (Clienti c in clienti)
                if (c.dataInchiriere == startDate && c.dataSfarsitInc == endDate)
                    clientiFiltrati.Add(c);
            dgvAfisare.DataSource = null;
            dgvAfisare.DataSource = clientiFiltrati;
        }
    }
}
