using PansiyonUI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PansiyonUI.Dal
{
    public class OdalarDal
    {
        public void Ekle(Odalar odalar)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(odalar);
                result.State = EntityState.Added;
                myContext.SaveChanges();
            }
        }
        public void Guncelle(Odalar odalar)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(odalar);
                result.State = EntityState.Modified;
                myContext.SaveChanges();
            }
        }

        public void Sil(Odalar odalar)
        {
            using (MyContext myContext = new MyContext())
            {
                var result = myContext.Entry(odalar);
                result.State = EntityState.Deleted;
                myContext.SaveChanges();
            }
        }
        public List<Odalar> Listele()
        {
            MyContext myContext = new MyContext();

            return myContext.Odalar.ToList();
        }
        public Odalar OdaGetir(int id)
        {
            using (MyContext myContext = new MyContext())
            {
                return myContext.Odalar.Find(id);
            }
        }
    }
}
