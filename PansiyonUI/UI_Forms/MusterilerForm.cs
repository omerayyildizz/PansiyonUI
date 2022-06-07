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
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }
        MusteriManager _musteriManager = new MusteriManager();
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxAd.Clear();
            tbxEmail.Clear();
            tbxMID.Clear();
            tbxMTC.Clear();
            tbxSoyad.Clear();
            mtbxTEL.Clear();
            cbxCinsiyet.Text = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;



        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }
        public void MusteriListele()
        {
            dgwMusteriList.DataSource = _musteriManager.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
      
                Musteriler musteri = new Musteriler()
                {
                    MusteriAdi = tbxAd.Text,
                    MusteriSoyadi = tbxSoyad.Text,
                    TcNo = tbxMTC.Text,
                    TelefonNo = mtbxTEL.Text,
                    Email = tbxEmail.Text,
                    Cinsiyet = cbxCinsiyet.Text

                };
                _musteriManager.Ekle(musteri);
                MusteriListele();
            
            
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler()
            {
                Id = int.Parse(tbxMID.Text),
                MusteriAdi = tbxAd.Text,
                MusteriSoyadi = tbxSoyad.Text,
                TcNo = tbxMTC.Text,
                TelefonNo = mtbxTEL.Text,
                Email = tbxEmail.Text,
                Cinsiyet = cbxCinsiyet.Text

            };
            _musteriManager.Guncelle(musteri);
            MusteriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler()
            {
                Id = int.Parse(tbxMID.Text),
                MusteriAdi = tbxAd.Text,
                MusteriSoyadi = tbxSoyad.Text,
                TcNo = tbxMTC.Text,
                TelefonNo = mtbxTEL.Text,
                Email = tbxEmail.Text,
                Cinsiyet = cbxCinsiyet.Text

            };
            _musteriManager.Sil(musteri);
            MusteriListele();
        }

        private void dgwMusteriList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMID.Text = dgwMusteriList.CurrentRow.Cells[0].Value.ToString();
            tbxMTC.Text = dgwMusteriList.CurrentRow.Cells[1].Value.ToString();
            tbxAd.Text = dgwMusteriList.CurrentRow.Cells[2].Value.ToString();
            tbxSoyad.Text = dgwMusteriList.CurrentRow.Cells[3].Value.ToString();
            mtbxTEL.Text = dgwMusteriList.CurrentRow.Cells[4].Value.ToString();
            tbxEmail.Text = dgwMusteriList.CurrentRow.Cells[5].Value.ToString();
            cbxCinsiyet.Text = dgwMusteriList.CurrentRow.Cells[6].Value.ToString(); cbxCinsiyet.Text = dgwMusteriList.CurrentRow.Cells[5].Value.ToString();
            
            if (cbxCinsiyet.Items.Contains("ERKEK"))
            {
                checkBox1.Checked = true;

            }
            else if (cbxCinsiyet.Items.Contains("KADIN"))
            {
                
                checkBox2.Checked = true;

            }
        }

        private void btnKonaklamalar_Click(object sender, EventArgs e)
        {
            if (tbxAd.Text!=""&&tbxMID.Text!="")
            {
                KonaklamalarForm konaklamalarForm = new KonaklamalarForm();
                konaklamalarForm.MUSTERIID = Convert.ToInt32(tbxMID.Text);
                konaklamalarForm.MusteriAdiSoyadi = tbxAd.Text + " " + tbxSoyad.Text;
                konaklamalarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
            }
            
        }
    }

}
    

