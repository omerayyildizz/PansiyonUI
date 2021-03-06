using PansiyonUI.Dal;
using PansiyonUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PansiyonUI.BusinessLayer
{
    public class KonaklamaManager
    {
        KonaklamalarDal _konaklamalarDal = new KonaklamalarDal();
        public void Ekle(Konaklamalar konaklama)
        {
            _konaklamalarDal.Ekle(konaklama);
        }
        public void Guncelle(Konaklamalar konaklama)
        {
            _konaklamalarDal.Guncelle(konaklama);
        }
        public void Sil(Konaklamalar konaklama)
        {
            _konaklamalarDal.Sil(konaklama);
        }
        public List<Konaklamalar> Listele()
        {
            return _konaklamalarDal.Listele();  
        }
    }
}
