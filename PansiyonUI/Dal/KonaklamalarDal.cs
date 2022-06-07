using PansiyonUI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PansiyonUI.Dal
{
    public class KonaklamalarDal
    {
        public void Ekle(Konaklamalar konaklamalar)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(konaklamalar);
                result.State = EntityState.Added;
                myContext.SaveChanges();
            }
        }
        public void Guncelle(Konaklamalar konaklamalar)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(konaklamalar);
                result.State = EntityState.Modified;
                myContext.SaveChanges();
            }
        }

        public void Sil(Konaklamalar konaklamalar)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(konaklamalar);
                result.State = EntityState.Deleted;
                myContext.SaveChanges();
            }
        }
        public List<Konaklamalar> Listele()
        {
            MyContext myContext = new MyContext();

            return myContext.Konaklamalar.ToList();


        }
    }
}
