using System;
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
    public partial class AngajatiForm : Form
    {
        public AngajatiForm()
        {
            InitializeComponent();
        }

        private void Angajati_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
