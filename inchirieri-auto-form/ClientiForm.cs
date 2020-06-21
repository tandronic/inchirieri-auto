// Andronic Tudor - 3121A

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using System.IO;

namespace inchirieri_auto_form
{
    public partial class ClientiForm : Form
    {
        Color lblColor = Color.Black;
        private const char DELIMITER = ' ';
        Useri LogInUser;
        public ClientiForm(Useri user)
        {
            LogInUser = user;
            InitializeComponent();  
        }

        private void Clienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void meniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main(LogInUser);
            mainForm.Show();
        }

        private void masiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasiniForm masiniForm = new MasiniForm(LogInUser);
            masiniForm.Show();
        }

        private void ResetareControale()
        {
            // Reset all input fields
            txtNume.Text = txtPrenume.Text = txtAdresa.Text = txtNrTel.Text = txtCnp.Text = string.Empty;
            txtCnp.Enabled = true;
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
            txtCnp.Enabled = true;
            // Set default BackColor for all labels
            SetLblColor();
            if (validare())
            {
                // Add a new client if the data is valid
                Clienti client = new Clienti();
                client.Nume = txtNume.Text;
                client.Prenume = txtPrenume.Text;
                client.NumarTelefon = txtNrTel.Text;
                client.Adresa = txtAdresa.Text;
                client.Cnp = txtCnp.Text;
                // Add a new client in the file
                SqliteConnectClienti.UpdateClient(client);
                lblInfo.Text = "Clientul a fost adaugat";
                lblInfo.Visible = true;
                // Reset all input text
                ResetareControale();
                List<Clienti> clienti = SqliteConnectClienti.LoadClienti();
                dgvAfisare.DataSource = clienti;
            }
        }

        private void afisare_date()
        {
            // Display all the clients
            lblInfo.Visible = false;
            List<Clienti> clienti = SqliteConnectClienti.LoadClienti();
            dgvAfisare.DataSource = clienti;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            afisare_date();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            // Search for a client
            lblInfo.Visible = false;
            txtCnp.Enabled = true;
            Clienti c = SqliteConnectClienti.SearchClientByCnp(txtCnp.Text);
            if (c == null)
            {
                lblInfo.Text = "Nu exista nici un client cu acest CNP";
                lblInfo.Visible = true;
            }
            else
            {
                // Set client data to all imput fields
                FileToFormData(c);
                lblInfo.Text = "Clientul a fost gasit";
                lblInfo.Visible = true;
            }
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

        private void btnModifica_Click(object sender, EventArgs e)
        {
            // Update client data
            lblInfo.Visible = false;
            if (txtCnp.Text.Length == 0)
            {
                lblInfo.Text = "Introdu CNP-ul clinetului cautat";
                lblInfo.Visible = true;
                return;
            }
            Clienti c = SqliteConnectClienti.SearchClientByCnp(txtCnp.Text);
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
                    SqliteConnectClienti.UpdateClient(c);
                    lblInfo.Text = "Datele clientului au fost modificate";
                    lblInfo.Visible = true;
                    ResetareControale();
                    afisare_date();
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
                Clienti c = SqliteConnectClienti.SearchClientByCnp(cnp);

                FileToFormData(c);
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            saveFile.ShowDialog();
            string numeFisier = saveFile.FileName;
            bool succes = SalvareClienti(numeFisier);
            if (succes)
                lblInfo.Text = "Fisierul a fost scris";
            else
                lblInfo.Text = "Scrierea in fisier nu a fost realizata";
            lblInfo.Visible = true;
        }

        private bool SalvareClienti(string numeFisier)
        {
            // Save clients data to a specific text file
            bool succes = false;
            List<Clienti> salvareClienti = SqliteConnectClienti.LoadClienti();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (Clienti c in salvareClienti)
                        swFisierText.WriteLine(c.ConversieLaSir(DELIMITER));
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }
    }
}
