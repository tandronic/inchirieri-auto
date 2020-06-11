namespace inchirieri_auto_form
{
    partial class ClientiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientiForm));
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblNrTel = new System.Windows.Forms.Label();
            this.lblCnp = new System.Windows.Forms.Label();
            this.lblNumarMasina = new System.Windows.Forms.Label();
            this.lblDataInchiriere = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNrTel = new System.Windows.Forms.TextBox();
            this.txtCnp = new System.Windows.Forms.TextBox();
            this.lblDataSfarsitInc = new System.Windows.Forms.Label();
            this.dtpStartInc = new System.Windows.Forms.DateTimePicker();
            this.dtpSfarsitInc = new System.Windows.Forms.DateTimePicker();
            this.btnFiltreaza = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbNrMasina = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvAfisare = new System.Windows.Forms.DataGridView();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisare)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Black;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(12, 36);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(57, 20);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.BackColor = System.Drawing.Color.Black;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.ForeColor = System.Drawing.Color.White;
            this.lblPrenume.Location = new System.Drawing.Point(12, 65);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(83, 20);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.BackColor = System.Drawing.Color.Black;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.White;
            this.lblAdresa.Location = new System.Drawing.Point(12, 96);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(68, 20);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblNrTel
            // 
            this.lblNrTel.AutoSize = true;
            this.lblNrTel.BackColor = System.Drawing.Color.Black;
            this.lblNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrTel.ForeColor = System.Drawing.Color.White;
            this.lblNrTel.Location = new System.Drawing.Point(12, 129);
            this.lblNrTel.Name = "lblNrTel";
            this.lblNrTel.Size = new System.Drawing.Size(132, 20);
            this.lblNrTel.TabIndex = 4;
            this.lblNrTel.Text = "Numar Telefon";
            // 
            // lblCnp
            // 
            this.lblCnp.AutoSize = true;
            this.lblCnp.BackColor = System.Drawing.Color.Black;
            this.lblCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnp.ForeColor = System.Drawing.Color.White;
            this.lblCnp.Location = new System.Drawing.Point(12, 162);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.Size = new System.Drawing.Size(47, 20);
            this.lblCnp.TabIndex = 5;
            this.lblCnp.Text = "CNP";
            // 
            // lblNumarMasina
            // 
            this.lblNumarMasina.AutoSize = true;
            this.lblNumarMasina.BackColor = System.Drawing.Color.Black;
            this.lblNumarMasina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumarMasina.ForeColor = System.Drawing.Color.White;
            this.lblNumarMasina.Location = new System.Drawing.Point(12, 197);
            this.lblNumarMasina.Name = "lblNumarMasina";
            this.lblNumarMasina.Size = new System.Drawing.Size(130, 20);
            this.lblNumarMasina.TabIndex = 6;
            this.lblNumarMasina.Text = "Numar masina";
            // 
            // lblDataInchiriere
            // 
            this.lblDataInchiriere.AutoSize = true;
            this.lblDataInchiriere.BackColor = System.Drawing.Color.Black;
            this.lblDataInchiriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInchiriere.ForeColor = System.Drawing.Color.White;
            this.lblDataInchiriere.Location = new System.Drawing.Point(14, 231);
            this.lblDataInchiriere.Name = "lblDataInchiriere";
            this.lblDataInchiriere.Size = new System.Drawing.Size(134, 20);
            this.lblDataInchiriere.TabIndex = 7;
            this.lblDataInchiriere.Text = "Data inchiriere";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(232, 36);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(249, 22);
            this.txtNume.TabIndex = 8;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(232, 67);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(249, 22);
            this.txtPrenume.TabIndex = 9;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(232, 98);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(249, 22);
            this.txtAdresa.TabIndex = 10;
            // 
            // txtNrTel
            // 
            this.txtNrTel.Location = new System.Drawing.Point(232, 131);
            this.txtNrTel.Name = "txtNrTel";
            this.txtNrTel.Size = new System.Drawing.Size(249, 22);
            this.txtNrTel.TabIndex = 11;
            // 
            // txtCnp
            // 
            this.txtCnp.Location = new System.Drawing.Point(232, 164);
            this.txtCnp.Name = "txtCnp";
            this.txtCnp.Size = new System.Drawing.Size(249, 22);
            this.txtCnp.TabIndex = 12;
            // 
            // lblDataSfarsitInc
            // 
            this.lblDataSfarsitInc.AutoSize = true;
            this.lblDataSfarsitInc.BackColor = System.Drawing.Color.Black;
            this.lblDataSfarsitInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSfarsitInc.ForeColor = System.Drawing.Color.White;
            this.lblDataSfarsitInc.Location = new System.Drawing.Point(14, 264);
            this.lblDataSfarsitInc.Name = "lblDataSfarsitInc";
            this.lblDataSfarsitInc.Size = new System.Drawing.Size(194, 20);
            this.lblDataSfarsitInc.TabIndex = 14;
            this.lblDataSfarsitInc.Text = "Data sfarsit inchiriere";
            // 
            // dtpStartInc
            // 
            this.dtpStartInc.Location = new System.Drawing.Point(232, 231);
            this.dtpStartInc.Name = "dtpStartInc";
            this.dtpStartInc.Size = new System.Drawing.Size(249, 22);
            this.dtpStartInc.TabIndex = 15;
            // 
            // dtpSfarsitInc
            // 
            this.dtpSfarsitInc.Location = new System.Drawing.Point(232, 262);
            this.dtpSfarsitInc.Name = "dtpSfarsitInc";
            this.dtpSfarsitInc.Size = new System.Drawing.Size(249, 22);
            this.dtpSfarsitInc.TabIndex = 16;
            // 
            // btnFiltreaza
            // 
            this.btnFiltreaza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltreaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltreaza.Location = new System.Drawing.Point(275, 468);
            this.btnFiltreaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreaza.Name = "btnFiltreaza";
            this.btnFiltreaza.Size = new System.Drawing.Size(168, 41);
            this.btnFiltreaza.TabIndex = 44;
            this.btnFiltreaza.Text = "Filtreaza";
            this.btnFiltreaza.UseVisualStyleBackColor = false;
            this.btnFiltreaza.Click += new System.EventHandler(this.btnFiltreaza_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(275, 430);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(168, 34);
            this.btnModifica.TabIndex = 43;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(275, 389);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(168, 36);
            this.btnCauta.TabIndex = 42;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.Location = new System.Drawing.Point(275, 346);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(168, 38);
            this.btnAfiseaza.TabIndex = 41;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(275, 304);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(168, 37);
            this.btnAdauga.TabIndex = 40;
            this.btnAdauga.Text = "Adauga client";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuPrincipalToolStripMenuItem,
            this.masiniToolStripMenuItem,
            this.angajatiToolStripMenuItem,
            this.salvareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 30);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuPrincipalToolStripMenuItem
            // 
            this.meniuPrincipalToolStripMenuItem.Name = "meniuPrincipalToolStripMenuItem";
            this.meniuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.meniuPrincipalToolStripMenuItem.Text = "Meniu principal";
            this.meniuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.meniuPrincipalToolStripMenuItem_Click);
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.masiniToolStripMenuItem.Text = "Masini";
            this.masiniToolStripMenuItem.Click += new System.EventHandler(this.masiniToolStripMenuItem_Click);
            // 
            // angajatiToolStripMenuItem
            // 
            this.angajatiToolStripMenuItem.Name = "angajatiToolStripMenuItem";
            this.angajatiToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.angajatiToolStripMenuItem.Text = "Angajati";
            this.angajatiToolStripMenuItem.Click += new System.EventHandler(this.angajatiToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // cmbNrMasina
            // 
            this.cmbNrMasina.FormattingEnabled = true;
            this.cmbNrMasina.Location = new System.Drawing.Point(232, 197);
            this.cmbNrMasina.Name = "cmbNrMasina";
            this.cmbNrMasina.Size = new System.Drawing.Size(249, 24);
            this.cmbNrMasina.TabIndex = 46;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(489, 304);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 17);
            this.lblInfo.TabIndex = 47;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            // 
            // dgvAfisare
            // 
            this.dgvAfisare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAfisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfisare.Location = new System.Drawing.Point(507, 36);
            this.dgvAfisare.Name = "dgvAfisare";
            this.dgvAfisare.RowHeadersWidth = 51;
            this.dgvAfisare.RowTemplate.Height = 24;
            this.dgvAfisare.Size = new System.Drawing.Size(486, 248);
            this.dgvAfisare.TabIndex = 48;
            this.dgvAfisare.SelectionChanged += new System.EventHandler(this.dgvAfisare_SelectionChanged);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inchirieri_auto_form.Properties.Resources.car;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 536);
            this.Controls.Add(this.dgvAfisare);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbNrMasina);
            this.Controls.Add(this.btnFiltreaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dtpSfarsitInc);
            this.Controls.Add(this.dtpStartInc);
            this.Controls.Add(this.lblDataSfarsitInc);
            this.Controls.Add(this.txtCnp);
            this.Controls.Add(this.txtNrTel);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblDataInchiriere);
            this.Controls.Add(this.lblNumarMasina);
            this.Controls.Add(this.lblCnp);
            this.Controls.Add(this.lblNrTel);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientiForm";
            this.Text = "Clienti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clienti_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblNrTel;
        private System.Windows.Forms.Label lblCnp;
        private System.Windows.Forms.Label lblNumarMasina;
        private System.Windows.Forms.Label lblDataInchiriere;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNrTel;
        private System.Windows.Forms.TextBox txtCnp;
        private System.Windows.Forms.Label lblDataSfarsitInc;
        private System.Windows.Forms.DateTimePicker dtpStartInc;
        private System.Windows.Forms.DateTimePicker dtpSfarsitInc;
        private System.Windows.Forms.Button btnFiltreaza;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angajatiToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbNrMasina;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvAfisare;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}