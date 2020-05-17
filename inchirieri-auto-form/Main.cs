﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inchirieri_auto_form
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMasini_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasiniForm masiniForm = new MasiniForm();
            masiniForm.Show();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm clientiForm = new ClientiForm();
            clientiForm.Show();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            this.Hide();
            AngajatiForm angajatiForm = new AngajatiForm();
            angajatiForm.Show();
        }
    }
}
