// Andronic Tudor - 3121A

using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace inchirieri_auto_form
{
    public partial class InchiriazaMasina : Form
    {
        Useri LogInUser;
        List<Masini> MasiniDinsponibile;
        Masini masina = null;
        public InchiriazaMasina(Useri user)
        {
            LogInUser = user;
            InitializeComponent();
            MasiniDinsponibile = SqliteConnectMasini.GetMasiniDisponibile();
            dgvAfisare.DataSource = MasiniDinsponibile;
            if(MasiniDinsponibile.Count ==0)
            {
                lblInfo.Text = "Nu exista nici o masina disponibila";
                lblInfo.Visible = true;
            }
        }

        private void InchireazaMasina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void meniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main MainForm = new Main(LogInUser);
            MainForm.Show();
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
                masina = SqliteConnectMasini.SearchMasinaByNr(NrInmat);
                FileToFormData(masina);
            }
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
        }

        private void ResetareControale()
        {
            // Reset all imputs
            txtNrInmatriculare.Enabled = true;
            txtBrend.Text = txtModel.Text = txtNrInmatriculare.Text = string.Empty;
            txtCapacitateMotor.Text = txtAnFabricatie.Text = string.Empty;
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
        }

        private void SetLabelsColor(Color color)
        {
            // Set <color> to labels
            lblDataInceput.BackColor = color;
            lblDataSfarsit.BackColor = color;
        }

        private bool validare()
        {
            // Validated data
            if(masina.Inchiriata)
            {
                lblInfo.Text = "Aceasta masina este incheriata";
                lblInfo.Visible = true;
                return false;
            }
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date || dtpStartDate.Value.Date < DateTime.Now.Date)
            {
                SetLabelsColor(Color.Red);
                return false;
            }
            return true;
        }

        private void btnInchireaza_Click(object sender, EventArgs e)
        {
            SetLabelsColor(Color.Black);
            if(masina != null && validare())
            {
                masina.Inchiriata = true;
                SqliteConnectMasini.UpdateMasina(masina);
                SqliteConnectClientiMasini.SaveData(LogInUser.IdUser, masina.IdMasina, dtpStartDate.Value.Date.ToString(), 
                    dtpEndDate.Value.Date.ToString());
                MasiniDinsponibile = SqliteConnectMasini.GetMasiniDisponibile();
                dgvAfisare.DataSource = MasiniDinsponibile;
                ResetareControale();
            }
        }

        private void btnAfisareProp_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Alege o masina";
                lblInfo.Visible = true;
            }
            else
            {
                if (masina == null)
                {
                    lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                    lblInfo.Visible = true;
                }
                else
                {
                    lblProp.Text = string.Format("Vechimea masinii este de {0} ani", masina.Vechime);
                    lblProp.Visible = true;
                }
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            MasiniDinsponibile = SqliteConnectMasini.GetMasiniDisponibile();
            dgvAfisare.DataSource = MasiniDinsponibile;
            if (MasiniDinsponibile.Count == 0)
            {
                lblInfo.Text = "Nu exista nici o masina disponibila";
                lblInfo.Visible = true;
            }
        }

        private void btnIstoric_Click(object sender, EventArgs e)
        {
            DataTable Data = SqliteConnectClientiMasini.LoadDataForCustomer(LogInUser.IdUser);
            dgvAfisare.DataSource = Data;
        }
    }
}
