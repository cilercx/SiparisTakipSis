using SiparisTakip.Interfaces.StokIG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;

namespace SiparisTakip.BLL.StokBLL
{
    public class StokManager : IStokService //IStokService burda implemente ediyoruz kalıtım yapmıyoruz. class'tan class'a ınterfaceden ınterfaceden kalıtım alır.yani özelliklerin aynısı ona da gecer.
      //BLL kullanıcınn gördüğü UI yani kullanıcınn gördüğü ekranın hemen arkasındaki katmandır.yani login sayfasını düşünürsek,kullaniciadi veya sifresi dogrumu,sayfaya girme yetkisi varmı gibi kontroller burda yapılır.   
    {
        public Stok Getir(int id)
        {
            throw new NotImplementedException();
        }

        public int Guncelle(Stok nesne)
        {
            throw new NotImplementedException();
        }

        public int Kaydet(Stok nesne)
        {
            throw new NotImplementedException();
        }

        public List<Stok> ListeGetir()
        {
            throw new NotImplementedException();
        }

        public List<Stok> OrnekEkstraMetod()
        {
            throw new NotImplementedException();
        }

        public Stok Sil(Stok nesne)
        {
            throw new NotImplementedException();
        }
    }
}
