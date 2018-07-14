using SiparisTakip.Dal.Abstract.FaturaA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFrameWork.Context;

namespace SiparisTakip.Dal.Concrete.EntityFrameWork.Repository
{
    public class EFFaturaRepository : IFaturaDal
    {
        SiparisTakipEntity ctx = new SiparisTakipEntity();


        public Fatura Getir(int id)
        {
            Fatura data = ctx.Fatura.Where(x => x.FaturaID == id).FirstOrDefault();
            return data;

            // return ctx.Fatura.Where(x => x.FaturaID == id).FirstOrDefault();

        }

        public int Guncelle(Fatura nesne)
        {
            ctx.Fatura.Attach(nesne);
            return ctx.SaveChanges();
        }

        public int Kaydet(Fatura nesne)
        {
            ctx.Fatura.Add(nesne);
            return ctx.SaveChanges();// eklediğimi veritabanına yansıttım.
        }

        public List<Fatura> ListeGetir()
        {
           return ctx.Fatura.ToList();
        }

        public Fatura Sil(Fatura nesne)
        {
           return ctx.Fatura.Remove(nesne);

        }
    }
}
