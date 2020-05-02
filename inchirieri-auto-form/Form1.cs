using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using NivelAccesDate;
using LibrarieModele;

namespace inchirieri_auto_form
{
    public partial class Form1 : Form
    {
        IStocareData adminMasini;

        Color lblColor = Color.Black;
        private const int LUNGIME_MAX = 35;

        public Form1()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            SetLblColor();
            if (validare())
            {
                Masini masina = new Masini();
                masina.Brend = txtBrend.Text;
                masina.Model = txtModel.Text;
                masina.NumarInmatriculare = txtNrInmatriculare.Text;
                masina.AnFabricatie = Utils.IntConvert(txtAnFabricatie.Text);
                masina.CapacitateMotor = Utils.IntConvert(txtCapacitateMotor.Text);
                masina.Culoare = Utils.CuloareConvert(txtCuloare.Text);
                masina.Combustibil = Utils.CombustibilConvert(txtCombustibil.Text);
                masina.Inchiriata = Utils.InchiriataToBoolConvert(txtInchiriata.Text);
                adminMasini.AddMasina(masina);
                lblInfo.Text = "Masina a fost adaugata";
                lblInfo.Visible = true;
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
            if (validare_field(txtCuloare, lblCuloare) == false)
                valid = false;
            if (validare_field(txtCombustibil, lblCombustibil) == false)
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
            if (txtbox == txtCombustibil)
            {
                if (txtbox.Text.Length == 0 || Utils.CombustibilValidate(txtbox.Text) == false)
                {
                    lbl.BackColor = Color.Red;
                    return false;
                }
            }
            if (txtbox == txtCuloare)
            {
                if (txtbox.Text.Length == 0 || Utils.CuloareValidate(txtbox.Text) == false)
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

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            rtbAfisare.Clear();
            ArrayList masinii = adminMasini.GetMasini();
            foreach(Masini m in masinii)
            {
                rtbAfisare.AppendText(m.ConversieLaSir());
                rtbAfisare.AppendText(Environment.NewLine);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Masini m = adminMasini.GetMasina(txtNrInmatriculare.Text);
            if(m == null)
            {
                lblInfo.Text = "Nu exista nici o masina cu acest numar de inmatriculare";
                lblInfo.Visible = true;
            }
            else
            {
                FileToFormData(m);
                lblCauta.Text = m.ConversieLaSir();
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
            if (txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Introdu un Numar de Inmatriculare pentru a se identifica masina";
                lblInfo.Visible = true;
                return;
            }
            Masini m = adminMasini.GetMasina(txtNrInmatriculare.Text);
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
                    m.Combustibil = Utils.CombustibilConvert(txtCombustibil.Text);
                    m.Culoare = Utils.CuloareConvert(txtCuloare.Text);
                    m.Inchiriata = Utils.InchiriataToBoolConvert(txtInchiriata.Text);
                    adminMasini.UpdateMasina(m);
                    lblInfo.Text = "Datele masinii au fost modificate";
                    lblInfo.Visible = true;
                }
            }
        }
        
        private void FileToFormData(Masini m)
        {
            txtBrend.Text = m.Brend;
            txtModel.Text = m.Model;
            txtNrInmatriculare.Text = m.NumarInmatriculare;
            txtAnFabricatie.Text = System.Convert.ToString(m.AnFabricatie);
            txtCapacitateMotor.Text = System.Convert.ToString(m.CapacitateMotor);
            txtCuloare.Text = m.Culoare.ToString();
            txtCombustibil.Text = m.Combustibil.ToString();
            txtInchiriata.Text = Utils.BoolToInchiriataConvert(m.Inchiriata);
        }

        private void btnAfisareProp_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if(txtNrInmatriculare.Text.Length == 0)
            {
                lblInfo.Text = "Introdu numarul masinii pentru care sa se afiseze proprietatea";
                lblInfo.Visible = true;
            }
            else
            {
                Masini m = adminMasini.GetMasina(txtNrInmatriculare.Text);
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
    }
}
