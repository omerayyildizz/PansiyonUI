using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PansiyonUI.Entities;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PansiyonUI.Dal
{
    public class MusterilerDal
    {
        public void Ekle(Musteriler musteri)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(musteri);
                result.State = EntityState.Added;
                myContext.SaveChanges();
            }
        }
        public void Guncelle(Musteriler musteri)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(musteri);
                result.State = EntityState.Modified;
                myContext.SaveChanges();
            }
        }

        public void Sil(Musteriler musteri)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(musteri);
                result.State = EntityState.Deleted;
                myContext.SaveChanges();
            }
        }
        public List<Musteriler> Listele()
        {
            MyContext myContext = new MyContext();



            return myContext.Musteriler.ToList();


        }
    }
}
