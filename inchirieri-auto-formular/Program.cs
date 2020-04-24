using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace inchirieri_auto_formular
{
    class Program
    {
        static void Main(string[] args)
        {
            InchirieriAutoFormular form1 = new InchirieriAutoFormular();
            form1.Show();
            Application.Run();
        }
    }

    public class InchirieriAutoFormular: Form
    {
        IStocareData adminMasini = StocareFactory.GetAdministratorStocare();

        private const int LATIME_CONTROL = 200;
        private const int INALTIME_CONTROL = 30;
        private const int DIMENSIUNE_PAS_Y = 40;
        private const int DIMENSIUNE_PAS_X = 220;
        private const int LUNGIME_MAX = 35;
        private const int LUNGIME_ADRESA_MAX = 150;

        private Button btnAdaugare;
        private Label lblBrend;
        private Label lblModel;
        private Label lblNumarInmatriculare;
        private Label lblAnFabricatie;
        private Label lblCapacitateMotor;
        private Label lblInchiriata;
        private Label lblCuloare;
        private Label lblCombustibil;
        private Label lblDate;
        private TextBox txtBrend;
        private TextBox txtModel;
        private TextBox txtNumarInmatriculare;
        private TextBox txtAnFabricatie;
        private TextBox txtCapacitateMotor;
        private TextBox txtInchiriata;
        private TextBox txtCuloare;
        private TextBox txtCombustibil;

        public InchirieriAutoFormular()
        {
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            this.ForeColor = Color.Blue;
            this.Text = "Administrare Masini";

            lblBrend = new Label();
            lblBrend.Width = LATIME_CONTROL;
            lblBrend.Text = "Brend: ";
            lblBrend.BackColor = Color.LightGray;
            this.Controls.Add(lblBrend);

            lblModel = new Label();
            lblModel.Width = LATIME_CONTROL;
            lblModel.Text = "Model: ";
            lblModel.Top = DIMENSIUNE_PAS_Y;
            lblModel.BackColor = Color.LightGray;
            this.Controls.Add(lblModel);

            lblNumarInmatriculare = new Label();
            lblNumarInmatriculare.Width = LATIME_CONTROL;
            lblNumarInmatriculare.Text = "Numar Inmatriculare: ";
            lblNumarInmatriculare.Top = DIMENSIUNE_PAS_Y * 2;
            lblNumarInmatriculare.BackColor = Color.LightGray;
            this.Controls.Add(lblNumarInmatriculare);

            lblAnFabricatie = new Label();
            lblAnFabricatie.Width = LATIME_CONTROL;
            lblAnFabricatie.Text = "An fabricatie: ";
            lblAnFabricatie.Top = DIMENSIUNE_PAS_Y * 3;
            lblAnFabricatie.BackColor = Color.LightGray;
            this.Controls.Add(lblAnFabricatie);

            lblCapacitateMotor = new Label();
            lblCapacitateMotor.Width = LATIME_CONTROL;
            lblCapacitateMotor.Text = "Capacitate motor: ";
            lblCapacitateMotor.Top = DIMENSIUNE_PAS_Y * 4;
            lblCapacitateMotor.BackColor = Color.LightGray;
            this.Controls.Add(lblCapacitateMotor);

            lblCuloare = new Label();
            lblCuloare.Width = LATIME_CONTROL;
            lblCuloare.Text = "Culoare: ";
            lblCuloare.Top = DIMENSIUNE_PAS_Y * 5;
            lblCuloare.BackColor = Color.LightGray;
            this.Controls.Add(lblCuloare);

            lblCombustibil = new Label();
            lblCombustibil.Width = LATIME_CONTROL;
            lblCombustibil.Text = "Combustibil: ";
            lblCombustibil.Top = DIMENSIUNE_PAS_Y * 6;
            lblCombustibil.BackColor = Color.LightGray;
            this.Controls.Add(lblCombustibil);

            lblInchiriata = new Label();
            lblInchiriata.Width = LATIME_CONTROL;
            lblInchiriata.Text = "Inchiriata: ";
            lblInchiriata.Top = DIMENSIUNE_PAS_Y * 7;
            lblInchiriata.BackColor = Color.LightGray;
            this.Controls.Add(lblInchiriata);

            lblDate = new Label();
            lblDate.Width = LATIME_CONTROL * 3;
            lblDate.Text = "";
            lblDate.Top = DIMENSIUNE_PAS_Y * 9;
            lblDate.BackColor = Color.LightGray;
            lblDate.Visible = false;
            this.Controls.Add(lblDate);

            txtBrend = new TextBox();
            txtBrend.Width = LATIME_CONTROL;
            txtBrend.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 0);
            this.Controls.Add(txtBrend);

            txtModel = new TextBox();
            txtModel.Width = LATIME_CONTROL;
            txtModel.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtModel);

            txtNumarInmatriculare = new TextBox();
            txtNumarInmatriculare.Width = LATIME_CONTROL;
            txtNumarInmatriculare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(txtNumarInmatriculare);

            txtAnFabricatie = new TextBox();
            txtAnFabricatie.Width = LATIME_CONTROL;
            txtAnFabricatie.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 3);
            this.Controls.Add(txtAnFabricatie);

            txtCapacitateMotor = new TextBox();
            txtCapacitateMotor.Width = LATIME_CONTROL;
            txtCapacitateMotor.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 4);
            this.Controls.Add(txtCapacitateMotor);

            txtCuloare = new TextBox();
            txtCuloare.Width = LATIME_CONTROL;
            txtCuloare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 5);
            this.Controls.Add(txtCuloare);

            txtCombustibil = new TextBox();
            txtCombustibil.Width = LATIME_CONTROL;
            txtCombustibil.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 6);
            this.Controls.Add(txtCombustibil);

            txtInchiriata = new TextBox();
            txtInchiriata.Width = LATIME_CONTROL;
            txtInchiriata.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 7);
            this.Controls.Add(txtInchiriata);

            btnAdaugare = new Button();
            btnAdaugare.Width = LATIME_CONTROL;
            btnAdaugare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 8);
            btnAdaugare.Text = "Adaugati masina";
            this.Controls.Add(btnAdaugare);

            btnAdaugare.Click += OnButtonAdaugaClicked;
            this.Controls.Add(btnAdaugare);
        }

        private void OnButtonAdaugaClicked(object sender, EventArgs e)
        {
            lblBrend.BackColor = Color.LightGray;
            lblModel.BackColor = Color.LightGray;
            lblNumarInmatriculare.BackColor = Color.LightGray;
            lblAnFabricatie.BackColor = Color.LightGray;
            lblCapacitateMotor.BackColor = Color.LightGray;
            lblCuloare.BackColor = Color.LightGray;
            lblCombustibil.BackColor = Color.LightGray;
            lblInchiriata.BackColor = Color.LightGray;
            if(validare())
            {
                Masini masina = new Masini();
                masina.Brend = txtBrend.Text;
                masina.Model = txtModel.Text;
                masina.NumarInmatriculare = txtNumarInmatriculare.Text;
                masina.AnFabricatie = Utils.IntConvert(txtAnFabricatie.Text);
                masina.CapacitateMotor = Utils.IntConvert(txtCapacitateMotor.Text);
                masina.Culoare = Utils.CuloareConvert(txtCuloare.Text);
                masina.Combustibil = Utils.CombustibilConvert(txtCombustibil.Text);
                masina.Inchiriata = Utils.InchiriataToBoolConvert(txtInchiriata.Text);
                adminMasini.AddMasina(masina);
                lblDate.Text = masina.ConversieLaSir();
                lblDate.Visible = true;
            }
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
            if (validare_field(txtNumarInmatriculare, lblNumarInmatriculare) == false)
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
            if(txtbox == txtInchiriata)
            {
                if(txtbox.Text.Length == 0 || Utils.InchiriataValidate(txtbox.Text) == false)
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
    }
}
