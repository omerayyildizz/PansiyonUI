using PansiyonUI.BusinessLayer;
using PansiyonUI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUI.UI_Forms
{
    public partial class OdalarForm : Form
    {
        OdaManager _odaManager = new OdaManager();
        public OdalarForm()
        {
            InitializeComponent();
        }

        private void OdalarForm_Load(object sender, EventArgs e)
        {
            OdaListele();
        }

        private void OdaListele()
        {
            dgwOdaList.DataSource = _odaManager.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar()
            {
                OdaNo = tbxOdaNo.Text,
                Fiyat =Convert.ToDecimal(tbxOdaFiyat.Text),
                MusaitMi = checkMusait.Checked

            };
            _odaManager.Ekle(oda);
            OdaListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar()
            {
                Id=Convert.ToInt32(tbxOdaId.Text),
                OdaNo = tbxOdaNo.Text,
                Fiyat = Convert.ToDecimal(tbxOdaFiyat.Text),
                MusaitMi = checkMusait.Checked

            };
            _odaManager.Guncelle(oda);
            OdaListele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar()
            {
                Id = Convert.ToInt32(tbxOdaId.Text),
                OdaNo = tbxOdaNo.Text,
                Fiyat = Convert.ToDecimal(tbxOdaFiyat.Text),
                MusaitMi = checkMusait.Checked

            };
            _odaManager.Sil(oda);
            OdaListele();
        }

        private void dgwOdaList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxOdaId.Text = dgwOdaList.CurrentRow.Cells[0].Value.ToString();
            tbxOdaNo.Text = dgwOdaList.CurrentRow.Cells[1].Value.ToString();
            tbxOdaFiyat.Text = dgwOdaList.CurrentRow.Cells[2].Value.ToString();
            checkMusait.Text = dgwOdaList.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxOdaFiyat.Clear();
            tbxOdaId.Clear();
            tbxOdaNo.Clear();
            checkMusait.Checked = false;
        }
    }
}
