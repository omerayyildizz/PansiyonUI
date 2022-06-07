using PansiyonUI.BusinessLayer;
using PansiyonUI.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PansiyonUI.UI_Forms
{
    public partial class KonaklamalarForm : Form
    {
        public int MUSTERIID { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public decimal OdaFiyat { get; set; }

        KonaklamaManager _konaklamalarManager = new KonaklamaManager();
        public KonaklamalarForm()
        {
            InitializeComponent();
        }
        private void KonaklamaListele()
        {

            dgwKonaklama.DataSource = _konaklamalarManager.Listele().Where(k => k.AktifMi == true && k.MusteriId == MUSTERIID).ToList();


        }
        private void KonaklamalarForm_Load(object sender, EventArgs e)
        {
            tbxMusteriAdi.Text = MusteriAdiSoyadi;
            lblmusteriid.Text = MUSTERIID.ToString();
            tbxOdaFiyat.Text = Convert.ToInt32(OdaFiyat).ToString();
            KonaklamaListele();
            OdaSec();
            GunSayisiHesapla();
            dgwKonaklama.DataSource = _konaklamalarManager.Listele().ToList();
        }
        private void GunSayisiHesapla()
        {
            TimeSpan gunsayisi;
            gunsayisi = DateTime.Parse(dtpCikisTarihi.Text) - DateTime.Parse(dtpGirisTarihi.Text);
            tbxGunSayisi.Text = gunsayisi.TotalDays.ToString();
        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            GunSayisiHesapla();
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
            GunSayisiHesapla();
        }
        //private void OdaSec()
        //{
        //    OdaManager odaManager = new OdaManager();
        //    int pozisyonX = 50;
        //    int pozisyonY = 50;
        //    int sutun = 1;

        //    for (int i = 0; i < odaManager.Listele().Count; i++)
        //    {
        //        Button button = new Button();
        //        if (!odaManager.Listele()[i].MusaitMi)
        //        {
        //            button.BackColor = Color.Green;
        //        }

        //        button.Location = new Point(pozisyonX, pozisyonY);
        //        button.Height = 50;
        //        button.Width = 50;
        //        button.Text = "Oda" + (i + 1);
        //        button.Name = "btnOda" + (i + 1);
        //        gbxOdalar.Controls.Add(button);
        //    }
        //    if (sutun < 5)
        //    {
        //        pozisyonX += 80;
        //        sutun++;
        //    }
        //    else
        //    {
        //        sutun = 1;
        //        pozisyonX = 50;
        //        pozisyonY += 80;
        //    }




        //}
        private void OdaSec()
        {
            OdaManager odaManager = new OdaManager();
            int pozisyonX = 50;
            int pozisyonY = 50;
            int sutun = 1;
            for (int i = 0; i < odaManager.Listele().Count; i++)
            {
                Button button = new Button();
                button.Location = new Point(pozisyonX, pozisyonY);
                button.Height = 50;
                button.Width = 50;
                button.Text = odaManager.Listele()[i].OdaNo.ToString();
                button.Name = odaManager.Listele()[i].Id.ToString();
                //button.Text = "Oda"+(i+1);
                //button.Name = "btnOda"+(i + 1);
                button.Click += new EventHandler(SeciliButon);
                gbxOdalar.Controls.Add(button);
                if (!odaManager.Listele()[i].MusaitMi)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
                else
                {
                    button.BackColor = Color.Green;
                }
                if (sutun < 8)
                {
                    pozisyonX += 80;
                    sutun++;
                }
                else
                {
                    sutun = 1;
                    pozisyonX = 50;
                    pozisyonY += 80;
                }
                
            }



        }
        private void SeciliButon(object sender, EventArgs e)
        {
            Button dinamikButon = (sender as Button);
            tbxOdaNo.Text = dinamikButon.Text;
            tbxOdaId.Text = dinamikButon.Name;  
            OdaManager odaManager = new OdaManager();
            int id = Convert.ToInt32(tbxOdaId.Text);
            Odalar oda = odaManager.OdaGetir(id);
            tbxOdaFiyat.Text = oda.Fiyat.ToString();
            ToplamFiyatHesapla();
            //tbxToplamFiyat.Text = (oda.Fiyat.ToString()) *Convert.ToDateTime(tbxGunSayisi.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbxOdaId.Text != "" && tbxToplamFiyat.Text != "" && cbxAktifmi.Checked)
            {
                Konaklamalar konaklama = new Konaklamalar()
                {
                    MusteriId = MUSTERIID,
                    OdaId = Convert.ToInt32(tbxOdaId.Text),
                    GirisTarihi = dtpGirisTarihi.Value,
                    CikisTarihi = dtpCikisTarihi.Value,
                    AktifMi = cbxAktifmi.Checked,
                    ToplamFiyat = Convert.ToDecimal(tbxToplamFiyat.Text)
                };
                _konaklamalarManager.Ekle(konaklama);
                OdaManager odaManager = new OdaManager();
                Odalar oda = new Odalar();
                oda = odaManager.Listele().Where(o => o.OdaNo == tbxOdaNo.Text).FirstOrDefault();
                odaManager.OdaGuncelleKonaklamaGiris(oda);
                KonaklamaListele();
                gbxOdalar.Controls.Clear();
                OdaSec();
                
            }
            else
            {
                MessageBox.Show("Lütfen önce bir oda seçin ve boş alanları doldurun(Tarih,Fiyat ve Konaklama Durumu).");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxOdaId.Text != "" && tbxToplamFiyat.Text != "" && tbxKonaklama.Text != "")
            {
                Konaklamalar konaklama = new Konaklamalar()
                {
                    Id = Convert.ToInt32(tbxKonaklama.Text),
                    MusteriId = MUSTERIID,
                    OdaId = Convert.ToInt32(tbxOdaId.Text),
                    GirisTarihi = dtpGirisTarihi.Value,
                    CikisTarihi = dtpCikisTarihi.Value,
                    AktifMi = cbxAktifmi.Checked,
                    ToplamFiyat = Convert.ToDecimal(tbxToplamFiyat.Text)
                };
                _konaklamalarManager.Guncelle(konaklama);
                if (!konaklama.AktifMi)
                {
                    OdaManager odaManager = new OdaManager();
                    Odalar oda = new Odalar();
                    oda = odaManager.Listele().Where(o => o.Id == Convert.ToInt32(tbxOdaId.Text)).FirstOrDefault();
                    odaManager.OdaGuncelleKonaklamaCikis(oda);
                }
                KonaklamaListele();
                gbxOdalar.Controls.Clear();
                OdaSec();
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçin");
            }
        }

        private void dgwKonaklama_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKonaklama.Text = dgwKonaklama.CurrentRow.Cells[0].Value.ToString();
            lblmusteriid.Text = dgwKonaklama.CurrentRow.Cells[1].Value.ToString();
            tbxOdaId.Text = dgwKonaklama.CurrentRow.Cells[2].Value.ToString();
            dtpGirisTarihi.Value = DateTime.Parse(dgwKonaklama.CurrentRow.Cells[3].Value.ToString());
            dtpCikisTarihi.Value = DateTime.Parse(dgwKonaklama.CurrentRow.Cells[4].Value.ToString());
            tbxToplamFiyat.Text = dgwKonaklama.CurrentRow.Cells[5].Value.ToString();
            cbxAktifmi.Checked = dgwKonaklama.CurrentRow.Cells[6].Selected;
        }
        private void ToplamFiyatHesapla()
        {
            tbxToplamFiyat.Text = (Convert.ToDecimal(tbxOdaFiyat.Text)*Convert.ToInt32(tbxGunSayisi.Text)).ToString();
        }

        private void dgwKonaklama_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}