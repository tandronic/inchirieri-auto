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
    public partial class MasiniForm : Form
    {
        List<string> OptiuniSelectate = new List<string>();
        Color lblColor = Color.Black;
        private const int LUNGIME_MAX = 35;
        private const char DELIMITER = ' ';
        Useri LogInUser;

        public MasiniForm(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
        }

        private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 

            string optiuneSelectata = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                OptiuniSelectate.Add(optiuneSelectata);
            else
                OptiuniSelectate.Remove(optiuneSelectata);
        }

        private void ResetareControale()
        {
            // Reset all imputs
            txtNrInmatriculare.Enabled = true;
            txtBrend.Text = txtModel.Text = txtNrInmatriculare.Text = string.Empty;
            txtCapacitateMotor.Text = txtAnFabricatie.Text  = string.Empty;
            rdbAlb.Checked = false;
            rdbAlbastru.Checked = false;
            rdbBenzina.Checked = false;
            rdbDiesel.Checked = false;
            rdbElectric.Checked = false;
            rdbGalben.Checked = false;
            rdbNegru.Checked = false;
            rdbPortocaliu.Checked = false;
            rdbVerde.Checked = false;
            ckbAerConditionat.Checked = false;
            ckbClima.Checked = false;
            ckbCutieAutomata.Checked = false;
            ckbGeamuriElectrice.Checked = false;
            ckbIncalzireInScaune.Checked = false;
            ckbNavigatie.Checked = false;
            ckbPilotAutomat.Checked = false;
            ckbXenon.Checked = false;
            ckbInchiriata.Checked = false;
            OptiuniSelectate.Clear();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            txtNrInmatriculare.Enabled = true;
            // Set default BackColor for all labels
            SetLblColor();
            if (validare())
            {
                // Add a new car if the data is valid
                LibrarieModele.Masini masina = new LibrarieModele.Masini();
                masina.Brend = txtBrend.Text;
                masina.Model = txtModel.Text;
                masina.NumarInmatriculare = txtNrInmatriculare.Text;
                masina.AnFabricatie = Utils.IntConvert(txtAnFabricatie.Text);
                masina.CapacitateMotor = Utils.IntConvert(txtCapacitateMotor.Text);
                masina.Culoare = GetCuloareMasinaSelectata();
                masina.Combustibil = GetCombustibilMasinaSelectata();
                masina.Inchiriata = ckbInchiriata.Checked;
                masina.Optiuni = new List<string>();
                masina.Optiuni.AddRange(OptiuniSelectate);
                masina.dataActualizare = DateTime.Now;
                // Add a new car in the file
                //adminMasini.AddMasina(masina);
                SqliteConnectMasini.SaveMasina(masina);
                lblInfo.Text = "Masina a fost adaugata";
                lblInfo.Visible = true;
                // Reset all input text
                ResetareControale();
            }
        }

        private void SetLblColor()
        {
            // Set BackColor for all labels
            lblBrend.BackColor = lblColor;
            lblModel.BackColor = lblColor;
            lblNrInmatriculare.BackColor = lblColor;
            lblAnFabricatie.BackColor = lblColor;
            lblCapacitateMotor.BackColor = lblColor;
            lblCuloare.BackColor = lblColor;
            lblCombustibil.BackColor = lblColor;
            lblInchiriata.BackColor = lblColor;
            lblOptiuni.BackColor = lblColor;
        }

        private bool validare(bool adaugare=true)
        {
            // Check if all fields are valid
            bool valid = true;
            if (adaugare && SqliteConnectMasini.SearchMasinaByNr(txtNrInmatriculare.Text.ToUpper()) != null)
            {
                lblNrInmatriculare.BackColor = Color.Red;
                lblInfo.Text = "Nu se pot adauga mai multe masini cu acelasi numar de inmatriculare";
                lblInfo.Visible = true;
                valid = false;
            }
            if (validare_field(txtBrend, lblBrend) == false)
                valid = false;
            if (validare_field(txtModel, lblModel) == false)
                valid = false;
            if (validare_field(txtAnFabricatie, lblAnFabricatie) == false)
                valid = false;
            if (validare_field(txtNrInmatriculare, lblNrInmatriculare) == false)
                valid = false;
            if (validare_field(txtCapacitateMotor, lblCapacitateMotor) == false)
                valid = false;
            if (GetCombustibilMasinaSelectata() == CombustibilMasina.CombustibilInvalid)
            {
                lblCombustibil.BackColor = Color.Red;
                valid = false;
            }
            if (GetCuloareMasinaSelectata() == CuloareMasina.CuloareInexistenta)
            {
                lblCuloare.BackColor = Color.Red;
                valid = false;
            }
            if (OptiuniSelectate.Count == 0)
            {
                lblOptiuni.BackColor = Color.Red;
                valid = false;
            }
            if (GetCombustibilMasinaSelectata() == CombustibilMasina.CombustibilInvalid)
                valid = false;
            return valid;
        }

        private bool validare_field(TextBox txtbox, Label lbl)
        {
            // Check if one field is valid
            if (txtbox == txtAnFabricatie || txtbox == txtCapacitateMotor)
            {
                if (txtbox.Text.Length == 0 || Utils.IntConvert(txtbox.Text) == Utils.ERROR_CONVERT)
                {
                    lbl.BackColor = Color.Red;
                    return false;
                }
            }
            if (txtbox.Text.Length == 0 || txtbox.Text.Length > LUNGIME_MAX)
            {
                lbl.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void afisare_date()
        {
            // Display all the cars
            ResetareControale();
            lblInfo.Visible = false;
            List<Masini> masini = SqliteConnectMasini.LoadMasini();
            dgvAfisare.DataSource = masini;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            afisare_date();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            // Search for a car
            lblInfo.Visible = false;
            txtNrInmatriculare.Enabled = true;
            Masini m = SqliteConnectMasini.SearchMasinaByNr(txtNrInmatriculare.Text.ToUpper());
            if (m == null)
            {
                lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                lblInfo.Visible = true;
            }
            else
            {
                // Set car data to all imput fields
                FileToFormData(m);
                lblInfo.Text = "Masina a fost gasita";
                lblInfo.Visible = true;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            // Update car data
            lblInfo.Visible = false;
            if (txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Introdu un Numar de Inmatriculare pentru a se identifica masina";
                lblInfo.Visible = true;
                return;
            }
            Masini m = SqliteConnectMasini.SearchMasinaByNr(txtNrInmatriculare.Text.ToUpper());
            if (m == null)
            {
                lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                lblInfo.Visible = true;
            }
            else
            {
                SetLblColor();
                if (validare(adaugare:false))
                {
                    m.Brend = txtBrend.Text;
                    m.Model = txtModel.Text;
                    m.NumarInmatriculare = txtNrInmatriculare.Text.ToUpper();
                    m.AnFabricatie = Utils.IntConvert(txtAnFabricatie.Text);
                    m.CapacitateMotor = Utils.IntConvert(txtCapacitateMotor.Text);
                    m.Combustibil = GetCombustibilMasinaSelectata();
                    m.Culoare = GetCuloareMasinaSelectata();
                    m.Optiuni = new List<string>();
                    m.Optiuni.AddRange(OptiuniSelectate);
                    m.Inchiriata = ckbInchiriata.Checked;
                    SqliteConnectMasini.UpdateMasina(m);
                    lblInfo.Text = "Datele masinii au fost modificate";
                    lblInfo.Visible = true;
                    ResetareControale();
                    afisare_date();
                }
            }
        }

        private void FileToFormData(LibrarieModele.Masini m)
        {
            // Set car data to all imput fields
            txtNrInmatriculare.Enabled = false;
            txtBrend.Text = m.Brend;
            txtModel.Text = m.Model;
            txtNrInmatriculare.Text = m.NumarInmatriculare;
            txtAnFabricatie.Text = System.Convert.ToString(m.AnFabricatie);
            txtCapacitateMotor.Text = System.Convert.ToString(m.CapacitateMotor);
            SelectCombustibil(m.Combustibil.ToString());
            SelectCuloare(m.Culoare.ToString());
            foreach (string optiune in m.Optiuni)
                SelectOptiune(optiune);
            ckbInchiriata.Checked = m.Inchiriata;
        }

        private void btnAfisareProp_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Introdu numarul masinii pentru care sa se afiseze proprietatea";
                lblInfo.Visible = true;
            }
            else
            {
                Masini m = SqliteConnectMasini.SearchMasinaByNr(txtNrInmatriculare.Text);
                if (m == null)
                {
                    lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                    lblInfo.Visible = true;
                }
                else
                {
                    FileToFormData(m);
                    lblProp.Text = string.Format("Vechimea masinii este de {0} ani", m.Vechime);
                    lblProp.Visible = true;
                }
            }
        }

        private CuloareMasina GetCuloareMasinaSelectata()
        {
            if (rdbAlb.Checked)
                return CuloareMasina.Alb;
            if (rdbNegru.Checked)
                return CuloareMasina.Negru;
            if (rdbAlbastru.Checked)
                return CuloareMasina.Albastru;
            if (rdbVerde.Checked)
                return CuloareMasina.Verde;
            if (rdbGalben.Checked)
                return CuloareMasina.Galben;
            if (rdbPortocaliu.Checked)
                return CuloareMasina.Portocaliu;
            return CuloareMasina.CuloareInexistenta;
        }

        private CombustibilMasina GetCombustibilMasinaSelectata()
        {
            if (rdbBenzina.Checked)
                return CombustibilMasina.Benzina;
            if (rdbDiesel.Checked)
                return CombustibilMasina.Diesel;
            if (rdbElectric.Checked)
                return CombustibilMasina.Electric;
            return CombustibilMasina.CombustibilInvalid;
        }

        private void SelectCombustibil(string text)
        {
            if (rdbBenzina.Text.Equals(text))
                rdbBenzina.Checked = true;
            if (rdbDiesel.Text.Equals(text))
                rdbDiesel.Checked = true;
            if (rdbElectric.Text.Equals(text))
                rdbElectric.Checked = true;
        }

        private void SelectCuloare(string text)
        {
            foreach (var control in grbCuloare.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Text.Equals(text))
                    rdb.Checked = true;
            }
        }

        private void SelectOptiune(string text)
        {
            foreach (var control in grbOptiuni.Controls)
            {
                CheckBox ckb = null;
                try
                {
                    ckb = (CheckBox)control;
                }
                catch { }

                if (ckb != null && ckb.Text.Equals(text))
                    ckb.Checked = true;
            }
        }

        private void Masini_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_form = new Main(LogInUser);
            main_form.Show();
        }

        private void meniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main(LogInUser);
            mainForm.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm clientiForm = new ClientiForm(LogInUser);
            clientiForm.Show();
        }

        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AngajatiForm angajatiForm = new AngajatiForm(LogInUser);
            angajatiForm.Show();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            saveFile.ShowDialog();
            string numeFisier = saveFile.FileName;
            bool succes = SalvareMasina(numeFisier);
            if (succes)
                lblInfo.Text = "Fisierul a fost scris";
            else
                lblInfo.Text = "Scrierea in fisier nu a fost realizata";
            lblInfo.Visible = true;
        }

        private bool SalvareMasina(string numeFisier)
        {
            // Save car data to a specific text file
            bool succes = false;
            List<Masini> salvareMasini = SqliteConnectMasini.LoadMasini();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (Masini m in salvareMasini)
                        swFisierText.WriteLine(m.ConversieLaSir(DELIMITER));
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

        private void dgvAfisare_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAfisare.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgvAfisare.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAfisare.Rows[selectedrowindex];
                string NrInmat = Convert.ToString(selectedRow.Cells["NumarInmatriculare"].Value);
                Masini masina = SqliteConnectMasini.SearchMasinaByNr(NrInmat);
                FileToFormData(masina);
            }
        }
    }
}
