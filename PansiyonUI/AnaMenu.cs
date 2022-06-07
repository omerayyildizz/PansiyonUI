using PansiyonUI.UI_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        private void FormGetir(Form form)
        {
            pForms.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            form.MdiParent = this;
            pForms.Controls.Add(form);
            form.Show();
        }
        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusterilerForm musterilerForm = new MusterilerForm();
            FormGetir(musterilerForm);
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            OdalarForm odalarForm = new OdalarForm();
            FormGetir(odalarForm);
        }

        private void btnKonaklama_Click(object sender, EventArgs e)
        {
            KonaklamalarForm konaklamalarForm = new KonaklamalarForm();
            FormGetir(konaklamalarForm);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
