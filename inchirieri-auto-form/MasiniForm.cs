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
    public partial class MasiniForm : Form
    {
        IStocareDataMasini adminMasini;
        List<string> OptiuniSelectate = new List<string>();
        Color lblColor = Color.Black;
        private const int LUNGIME_MAX = 35;
        private const char DELIMITER = ' ';

        public MasiniForm()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocareMasini();
        }

        private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 

            string optiuneSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                OptiuniSelectate.Add(optiuneSelectata);
            else
                OptiuniSelectate.Remove(optiuneSelectata);
        }

        private void ResetareControale()
        {
            txtBrend.Text = txtModel.Text = txtNrInmatriculare.Text = string.Empty;
            txtCapacitateMotor.Text = txtAnFabricatie.Text = txtInchiriata.Text = string.Empty;
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
            OptiuniSelectate.Clear();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            SetLblColor();
            if (validare())
            {
                LibrarieModele.Masini masina = new LibrarieModele.Masini();
                masina.Brend = txtBrend.Text;
                masina.Model = txtModel.Text;
                masina.NumarInmatriculare = txtNrInmatriculare.Text;
                masina.AnFabricatie = Utils.IntConvert(txtAnFabricatie.Text);
                masina.CapacitateMotor = Utils.IntConvert(txtCapacitateMotor.Text);
                masina.Culoare = GetCuloareMasinaSelectata();
                masina.Combustibil = GetCombustibilMasinaSelectata();
                masina.Inchiriata = Utils.InchiriataToBoolConvert(txtInchiriata.Text);
                masina.Optiuni = new List<string>();
                masina.Optiuni.AddRange(OptiuniSelectate);
                masina.dataActualizare = DateTime.Now;
                adminMasini.AddMasina(masina);
                lblInfo.Text = "Masina a fost adaugata";
                lblInfo.Visible = true;
                ResetareControale();
            }
        }

        private void SetLblColor()
        {
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

        private bool validare()
        {
            bool valid = true;
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
            if (validare_field(txtInchiriata, lblInchiriata) == false)
                valid = false;
            return valid;
        }

        private bool validare_field(TextBox txtbox, Label lbl)
        {
            if (txtbox == txtAnFabricatie || txtbox == txtCapacitateMotor)
            {
                if (txtbox.Text.Length == 0 || Utils.IntConvert(txtbox.Text) == Utils.ERROR_CONVERT)
                {
                    lbl.BackColor = Color.Red;
                    return false;
                }
            }
            if (txtbox == txtInchiriata)
            {
                if (txtbox.Text.Length == 0 || Utils.InchiriataValidate(txtbox.Text) == false)
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

        private void lsbAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            LibrarieModele.Masini m = adminMasini.GetMasinaByIndex(lsbAfisare.SelectedIndex - 1);
            if(m != null)
            {
                FileToFormData(m);
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            lsbAfisare.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,10}{2,20}{3,25}{4,30}{5,35}{6,40}{7,45}{8,55}\n", "Id", "Brend", "Model", "NumarInmatriculare",
                "AnFabricare", "CapacitateMotor", "Culoare", "Combustibil", "Inchiriata");
            lsbAfisare.Items.Add(antetTabel);

            List<Masini> masinii = adminMasini.GetMasini();
            foreach (LibrarieModele.Masini m in masinii)
            {
                var linieTabel = string.Format("{0,-5}{1,10}{2,20}{3,25}{4,35}{5,40}{6,45}{7,50}{8,55}\n", m.IdMasina, m.Brend, m.Model, m.NumarInmatriculare,
                    m.AnFabricatie, m.CapacitateMotor, m.Culoare, m.Combustibil, m.Inchiriata);
                lsbAfisare.Items.Add(linieTabel);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            dgvFiltrare.Visible = false;
            LibrarieModele.Masini m = adminMasini.GetMasina(txtNrInmatriculare.Text);
            if (m == null)
            {
                lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                lblInfo.Visible = true;
            }
            else
            {
                FileToFormData(m);
                lblCauta.Text = m.ConversieLaSir(DELIMITER);
                lblCauta.Visible = true;
                if (txtNrInmatriculare.Enabled == true)
                    txtNrInmatriculare.Enabled = false;
                else
                    txtNrInmatriculare.Enabled = true;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            dgvFiltrare.Visible = false;
            if (txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Introdu un Numar de Inmatriculare pentru a se identifica masina";
                lblInfo.Visible = true;
                return;
            }
            LibrarieModele.Masini m = adminMasini.GetMasina(txtNrInmatriculare.Text);
            if (m == null)
            {
                lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                lblInfo.Visible = true;
            }
            else
            {
                SetLblColor();
                if (validare())
                {
                    m.Brend = txtBrend.Text;
                    m.Model = txtModel.Text;
                    m.NumarInmatriculare = txtNrInmatriculare.Text;
                    m.AnFabricatie = Utils.IntConvert(txtAnFabricatie.Text);
                    m.CapacitateMotor = Utils.IntConvert(txtCapacitateMotor.Text);
                    m.Combustibil = GetCombustibilMasinaSelectata();
                    m.Culoare = GetCuloareMasinaSelectata();
                    m.Optiuni = new List<string>();
                    m.Optiuni.AddRange(OptiuniSelectate);
                    m.Inchiriata = Utils.InchiriataToBoolConvert(txtInchiriata.Text);
                    adminMasini.UpdateMasina(m);
                    lblInfo.Text = "Datele masinii au fost modificate";
                    lblInfo.Visible = true;
                }
            }
        }

        private void FileToFormData(LibrarieModele.Masini m)
        {
            txtBrend.Text = m.Brend;
            txtModel.Text = m.Model;
            txtNrInmatriculare.Text = m.NumarInmatriculare;
            txtAnFabricatie.Text = System.Convert.ToString(m.AnFabricatie);
            txtCapacitateMotor.Text = System.Convert.ToString(m.CapacitateMotor);
            SelectCombustibil(m.Combustibil.ToString());
            SelectCuloare(m.Culoare.ToString());
            foreach (string optiune in m.Optiuni)
                SelectOptiune(optiune);
            txtInchiriata.Text = Utils.BoolToInchiriataConvert(m.Inchiriata);
        }

        private void btnAfisareProp_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            dgvFiltrare.Visible = false;
            if (txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Introdu numarul masinii pentru care sa se afiseze proprietatea";
                lblInfo.Visible = true;
            }
            else
            {
                LibrarieModele.Masini m = adminMasini.GetMasina(txtNrInmatriculare.Text);
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
                    if (txtNrInmatriculare.Enabled == true)
                        txtNrInmatriculare.Enabled = false;
                    else
                        txtNrInmatriculare.Enabled = true;
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
            Main main_form = new Main();
            main_form.Show();
        }

        private void meniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm clientiForm = new ClientiForm();
            clientiForm.Show();
        }

        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AngajatiForm angajatiForm = new AngajatiForm();
            angajatiForm.Show();
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            this.Width = 1300;
            dgvFiltrare.Visible = true;
            FiltreazaMasini();
        }

        private void FiltreazaMasini()
        {
            List<Masini> masini = adminMasini.GetMasini();
            List<Masini> masiniFiltrate = new List<Masini>();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            foreach (Masini m in masini)
                if (m.dataActualizare >= startDate && m.dataActualizare <= endDate)
                    masiniFiltrate.Add(m);
            AdaugaMasiniDataGridView(masiniFiltrate);

        }

        private void AdaugaMasiniDataGridView(List<Masini> masini)
        {
            dgvFiltrare.DataSource = null;

            dgvFiltrare.DataSource = masini;

            //dataGridStudenti.DataSource = studenti.Select(s => new { s.IdStudent, s.Nume, s.Prenume, s.ProgramSTD, Discipline = string.Join(",", s.Discipline), Note = string.Join(",", s.GetNote()) }).ToList();
        }
    }
}
