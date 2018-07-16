using SiparisTakip.Interfaces.StokIG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Abstract.StokA;

namespace SiparisTakip.BLL.StokBLL
{
    public class StokManager : IStokService //IStokService burda implemente ediyoruz kalıtım yapmıyoruz. class'tan class'a ınterfaceden ınterfaceden kalıtım alır.yani özelliklerin aynısı ona da gecer.
      //BLL kullanıcınn gördüğü UI yani kullanıcınn gördüğü ekranın hemen arkasındaki katmandır.yani login sayfasını düşünürsek,kullaniciadi veya sifresi dogrumu,sayfaya girme yetkisi varmı gibi kontroller burda yapılır.   
    {

        IStokDal _IStokDal;//

        public StokManager(IStokDal IStokDal)
        {
            _IStokDal = IStokDal;
        }

        public Stok Getir(int id)
        {
            var data = _IStokDal.Getir(id);
            return data;
        }

        public int Guncelle(Stok nesne)
        {
            var data = _IStokDal.Guncelle(nesne);
            return data;
        }

        public int Kaydet(Stok nesne)
        {
            var data = _IStokDal.Kaydet(nesne);
            return data;
        }

        public List<Stok> ListeGetir()
        {
            return _IStokDal.ListeGetir();

        }

        public List<Stok> OrnekEkstraMetod()
        {
            throw new NotImplementedException();
        }

        public Stok Sil(Stok nesne)
        {
            var data = _IStokDal.Sil(nesne);
            return data;
        }
    }
}
