using SiparisTakip.Dal.Abstract.KullaniciA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFrameWork.Context;

namespace SiparisTakip.Dal.Concrete.EntityFrameWork.Repository
{

    public class EKullaniciRepository : IKullaniciDal
    {
        SiparisTakipEntity ctx = new SiparisTakipEntity();

        public Kullanici Getir(int id)
        {
            return ctx.Kullanici.Where(x => x.KullaniciID == id).FirstOrDefault();
        }

        public int Guncelle(Kullanici nesne)
        {
            ctx.Kullanici.Attach(nesne);
            return ctx.SaveChanges();
        }

        public int Kaydet(Kullanici nesne)
        {
            ctx.Kullanici.Add(nesne);
            return ctx.SaveChanges();
        }

        public List<Kullanici> ListeGetir()
        {
           return ctx.Kullanici.ToList();
        }

        public Kullanici Sil(Kullanici nesne)
        {
           return ctx.Kullanici.Remove(nesne);
        }
    }
}
