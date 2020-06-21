namespace inchirieri_auto_form
{
    partial class AngajatiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngajatiForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAfisare = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbFunctie = new System.Windows.Forms.ComboBox();
            this.btnFiltreaza = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dtpAngajare = new System.Windows.Forms.DateTimePicker();
            this.txtCnp = new System.Windows.Forms.TextBox();
            this.txtNrTel = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblDataAngajari = new System.Windows.Forms.Label();
            this.lblFunctie = new System.Windows.Forms.Label();
            this.lblCnp = new System.Windows.Forms.Label();
            this.lblNrTel = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisare)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuPrincipalToolStripMenuItem,
            this.masiniToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuPrincipalToolStripMenuItem
            // 
            this.meniuPrincipalToolStripMenuItem.Name = "meniuPrincipalToolStripMenuItem";
            this.meniuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.meniuPrincipalToolStripMenuItem.Text = "Meniu principal";
            this.meniuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.meniuPrincipalToolStripMenuItem_Click_1);
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.masiniToolStripMenuItem.Text = "Masini";
            this.masiniToolStripMenuItem.Click += new System.EventHandler(this.masiniToolStripMenuItem_Click_1);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // dgvAfisare
            // 
            this.dgvAfisare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAfisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfisare.Location = new System.Drawing.Point(380, 26);
            this.dgvAfisare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAfisare.Name = "dgvAfisare";
            this.dgvAfisare.RowHeadersWidth = 51;
            this.dgvAfisare.RowTemplate.Height = 24;
            this.dgvAfisare.Size = new System.Drawing.Size(364, 202);
            this.dgvAfisare.TabIndex = 71;
            this.dgvAfisare.SelectionChanged += new System.EventHandler(this.dgvAfisare_SelectionChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(367, 244);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 70;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            // 
            // cmbFunctie
            // 
            this.cmbFunctie.FormattingEnabled = true;
            this.cmbFunctie.Location = new System.Drawing.Point(174, 157);
            this.cmbFunctie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFunctie.Name = "cmbFunctie";
            this.cmbFunctie.Size = new System.Drawing.Size(188, 21);
            this.cmbFunctie.TabIndex = 69;
            // 
            // btnFiltreaza
            // 
            this.btnFiltreaza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltreaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltreaza.Location = new System.Drawing.Point(206, 377);
            this.btnFiltreaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltreaza.Name = "btnFiltreaza";
            this.btnFiltreaza.Size = new System.Drawing.Size(126, 33);
            this.btnFiltreaza.TabIndex = 68;
            this.btnFiltreaza.Text = "Filtreaza";
            this.btnFiltreaza.UseVisualStyleBackColor = false;
            this.btnFiltreaza.Click += new System.EventHandler(this.btnFiltreaza_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(206, 346);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(126, 28);
            this.btnModifica.TabIndex = 67;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(206, 313);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(126, 29);
            this.btnCauta.TabIndex = 66;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.Location = new System.Drawing.Point(206, 278);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(126, 31);
            this.btnAfiseaza.TabIndex = 65;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(206, 244);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(126, 30);
            this.btnAdauga.TabIndex = 64;
            this.btnAdauga.Text = "Adauga angajat";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dtpAngajare
            // 
            this.dtpAngajare.Location = new System.Drawing.Point(174, 184);
            this.dtpAngajare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpAngajare.Name = "dtpAngajare";
            this.dtpAngajare.Size = new System.Drawing.Size(188, 20);
            this.dtpAngajare.TabIndex = 62;
            // 
            // txtCnp
            // 
            this.txtCnp.Location = new System.Drawing.Point(174, 130);
            this.txtCnp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCnp.Name = "txtCnp";
            this.txtCnp.Size = new System.Drawing.Size(188, 20);
            this.txtCnp.TabIndex = 60;
            // 
            // txtNrTel
            // 
            this.txtNrTel.Location = new System.Drawing.Point(174, 103);
            this.txtNrTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNrTel.Name = "txtNrTel";
            this.txtNrTel.Size = new System.Drawing.Size(188, 20);
            this.txtNrTel.TabIndex = 59;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(174, 76);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(188, 20);
            this.txtAdresa.TabIndex = 58;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(174, 51);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(188, 20);
            this.txtPrenume.TabIndex = 57;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(174, 26);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(188, 20);
            this.txtNume.TabIndex = 56;
            // 
            // lblDataAngajari
            // 
            this.lblDataAngajari.AutoSize = true;
            this.lblDataAngajari.BackColor = System.Drawing.Color.Black;
            this.lblDataAngajari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAngajari.ForeColor = System.Drawing.Color.White;
            this.lblDataAngajari.Location = new System.Drawing.Point(10, 184);
            this.lblDataAngajari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAngajari.Name = "lblDataAngajari";
            this.lblDataAngajari.Size = new System.Drawing.Size(110, 17);
            this.lblDataAngajari.TabIndex = 55;
            this.lblDataAngajari.Text = "Data angajarii";
            // 
            // lblFunctie
            // 
            this.lblFunctie.AutoSize = true;
            this.lblFunctie.BackColor = System.Drawing.Color.Black;
            this.lblFunctie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctie.ForeColor = System.Drawing.Color.White;
            this.lblFunctie.Location = new System.Drawing.Point(9, 157);
            this.lblFunctie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFunctie.Name = "lblFunctie";
            this.lblFunctie.Size = new System.Drawing.Size(61, 17);
            this.lblFunctie.TabIndex = 54;
            this.lblFunctie.Text = "Functie";
            // 
            // lblCnp
            // 
            this.lblCnp.AutoSize = true;
            this.lblCnp.BackColor = System.Drawing.Color.Black;
            this.lblCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnp.ForeColor = System.Drawing.Color.White;
            this.lblCnp.Location = new System.Drawing.Point(9, 128);
            this.lblCnp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.Size = new System.Drawing.Size(39, 17);
            this.lblCnp.TabIndex = 53;
            this.lblCnp.Text = "CNP";
            // 
            // lblNrTel
            // 
            this.lblNrTel.AutoSize = true;
            this.lblNrTel.BackColor = System.Drawing.Color.Black;
            this.lblNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrTel.ForeColor = System.Drawing.Color.White;
            this.lblNrTel.Location = new System.Drawing.Point(9, 102);
            this.lblNrTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNrTel.Name = "lblNrTel";
            this.lblNrTel.Size = new System.Drawing.Size(115, 17);
            this.lblNrTel.TabIndex = 52;
            this.lblNrTel.Text = "Numar Telefon";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.BackColor = System.Drawing.Color.Black;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.White;
            this.lblAdresa.Location = new System.Drawing.Point(9, 75);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(59, 17);
            this.lblAdresa.TabIndex = 51;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.BackColor = System.Drawing.Color.Black;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.ForeColor = System.Drawing.Color.White;
            this.lblPrenume.Location = new System.Drawing.Point(9, 50);
            this.lblPrenume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(72, 17);
            this.lblPrenume.TabIndex = 50;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Black;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(9, 26);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(49, 17);
            this.lblNume.TabIndex = 49;
            this.lblNume.Text = "Nume";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // AngajatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inchirieri_auto_form.Properties.Resources.car;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 436);
            this.Controls.Add(this.dgvAfisare);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbFunctie);
            this.Controls.Add(this.btnFiltreaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dtpAngajare);
            this.Controls.Add(this.txtCnp);
            this.Controls.Add(this.txtNrTel);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblDataAngajari);
            this.Controls.Add(this.lblFunctie);
            this.Controls.Add(this.lblCnp);
            this.Controls.Add(this.lblNrTel);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AngajatiForm";
            this.Text = "Angajati";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Angajati_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfisare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAfisare;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbFunctie;
        private System.Windows.Forms.Button btnFiltreaza;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DateTimePicker dtpAngajare;
        private System.Windows.Forms.TextBox txtCnp;
        private System.Windows.Forms.TextBox txtNrTel;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblDataAngajari;
        private System.Windows.Forms.Label lblFunctie;
        private System.Windows.Forms.Label lblCnp;
        private System.Windows.Forms.Label lblNrTel;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}