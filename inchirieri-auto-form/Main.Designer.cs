namespace inchirieri_auto_form
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnMasini = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnAngajati = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasini
            // 
            this.btnMasini.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMasini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasini.Location = new System.Drawing.Point(263, 24);
            this.btnMasini.Margin = new System.Windows.Forms.Padding(2);
            this.btnMasini.Name = "btnMasini";
            this.btnMasini.Size = new System.Drawing.Size(130, 50);
            this.btnMasini.TabIndex = 16;
            this.btnMasini.Text = "Masini";
            this.btnMasini.UseVisualStyleBackColor = false;
            this.btnMasini.Click += new System.EventHandler(this.btnMasini_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienti.Location = new System.Drawing.Point(263, 93);
            this.btnClienti.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(130, 50);
            this.btnClienti.TabIndex = 17;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = false;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnAngajati
            // 
            this.btnAngajati.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngajati.Location = new System.Drawing.Point(263, 161);
            this.btnAngajati.Margin = new System.Windows.Forms.Padding(2);
            this.btnAngajati.Name = "btnAngajati";
            this.btnAngajati.Size = new System.Drawing.Size(130, 50);
            this.btnAngajati.TabIndex = 18;
            this.btnAngajati.Text = "Angajati";
            this.btnAngajati.UseVisualStyleBackColor = false;
            this.btnAngajati.Click += new System.EventHandler(this.btnAngajati_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(263, 374);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(130, 50);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.Location = new System.Drawing.Point(263, 298);
            this.btnCont.Margin = new System.Windows.Forms.Padding(2);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(130, 50);
            this.btnCont.TabIndex = 20;
            this.btnCont.Text = "Setari Cont";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.Location = new System.Drawing.Point(263, 231);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(130, 50);
            this.btnProfil.TabIndex = 21;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inchirieri_auto_form.Properties.Resources.car;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 481);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAngajati);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnMasini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasini;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnAngajati;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnProfil;
    }
}