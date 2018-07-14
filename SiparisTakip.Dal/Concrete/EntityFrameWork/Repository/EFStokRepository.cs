using SiparisTakip.Dal.Abstract.StokA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFrameWork.Context;

namespace SiparisTakip.Dal.Concrete.EntityFrameWork.Repository
{
    public class EFStokRepository : IStokDal
    {
        SiparisTakipEntity ctx = new SiparisTakipEntity();//veri tabanı ile bağlantıyı kurduk.

        public Stok Getir(int id)
        {
            var data = ctx.Stok.Where(x => x.StokID == id).FirstOrDefault();// id si bnim gönderdiğim id ye göre stok tablosunu sorguladık.
            // firstordefault() demek ilkini getir veya defaultta neyse onu getir demek. where kullanmamaizin sebebi queryable oldugu için.

            return data;
        }

        public int Guncelle(Stok nesne)// güncelleme yapıdığında kac satırın etkilendiği sayısı döner.o yüzden dönüş tipi integer.
        {
            ctx.Stok.Attach(nesne);
            return ctx.SaveChanges();// kac satır döndü.
        }

        public int Kaydet(Stok nesne)
        {
            ctx.Stok.Add(nesne);
            return ctx.SaveChanges();
        }

        public List<Stok> ListeGetir()
        {
            return ctx.Stok.ToList();
        }

        public Stok Sil(Stok nesne)
        {
           return ctx.Stok.Remove(nesne);
        }
    }
}
