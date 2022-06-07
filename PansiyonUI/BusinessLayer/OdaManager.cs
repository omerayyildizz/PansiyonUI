using PansiyonUI.Dal;
using PansiyonUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PansiyonUI.BusinessLayer
{
    public class OdaManager
    {
        OdalarDal _odalarDal = new OdalarDal();
        public void OdaGuncelleKonaklamaGiris(Odalar oda)
        {
            oda.MusaitMi = false;
            Guncelle(oda);
        }
        public void OdaGuncelleKonaklamaCikis(Odalar oda)
        {
            oda.MusaitMi = true;
            Guncelle(oda);
        }
        public void Ekle(Odalar oda)
        {
            _odalarDal.Ekle(oda);
        }
        public void Sil(Odalar oda)
        {
            _odalarDal.Sil(oda);
        }
        public void Guncelle(Odalar oda)
        {
            _odalarDal.Guncelle(oda);
        }
        public List<Odalar> Listele()
        {
            return _odalarDal.Listele();
        }
        public Odalar OdaGetir(int id)
        {
            return _odalarDal.OdaGetir(id);
        }
    }
}
