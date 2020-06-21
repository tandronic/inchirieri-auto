namespace inchirieri_auto_form
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.rdbAngajat = new System.Windows.Forms.RadioButton();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Black;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(49, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 18);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Parola";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(206, 52);
            this.txtPassword1.MaxLength = 30;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(169, 20);
            this.txtPassword1.TabIndex = 8;
            this.txtPassword1.UseSystemPasswordChar = true;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(49, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 18);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Utilizator";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(206, 26);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(169, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.BackColor = System.Drawing.Color.Black;
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.ForeColor = System.Drawing.Color.White;
            this.lblPassword2.Location = new System.Drawing.Point(49, 80);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(146, 18);
            this.lblPassword2.TabIndex = 13;
            this.lblPassword2.Text = "Confirmare Parola";
            this.lblPassword2.Click += new System.EventHandler(this.lblPassword2_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(206, 81);
            this.txtPassword2.MaxLength = 30;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(169, 20);
            this.txtPassword2.TabIndex = 12;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Black;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(49, 109);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(101, 18);
            this.lblUserType.TabIndex = 14;
            this.lblUserType.Text = "Tip utilizator";
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // rdbAngajat
            // 
            this.rdbAngajat.AutoSize = true;
            this.rdbAngajat.Location = new System.Drawing.Point(206, 111);
            this.rdbAngajat.Name = "rdbAngajat";
            this.rdbAngajat.Size = new System.Drawing.Size(61, 17);
            this.rdbAngajat.TabIndex = 15;
            this.rdbAngajat.TabStop = true;
            this.rdbAngajat.Text = "Angajat";
            this.rdbAngajat.UseVisualStyleBackColor = true;
            this.rdbAngajat.CheckedChanged += new System.EventHandler(this.rdbAngajat_CheckedChanged);
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(273, 111);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(51, 17);
            this.rdbClient.TabIndex = 16;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "Client";
            this.rdbClient.UseVisualStyleBackColor = true;
            this.rdbClient.CheckedChanged += new System.EventHandler(this.rdbClient_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(206, 168);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 30);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Inregistrare";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(206, 204);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 29);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Black;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(49, 140);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(32, 18);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(330, 111);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbAdmin.TabIndex = 20;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inchirieri_auto_form.Properties.Resources.car;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 315);
            this.Controls.Add(this.rdbAdmin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbClient);
            this.Controls.Add(this.rdbAngajat);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.RadioButton rdbAngajat;
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rdbAdmin;
    }
}