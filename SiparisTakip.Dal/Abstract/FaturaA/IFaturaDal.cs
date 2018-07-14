using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.FaturaA
{
    public interface IFaturaDal
    {
        Fatura Getir(int id);// burda T getir generic olaraka cağırılmadı. Nesnenin kendisini cağırdık.Niye yaptığımızı ilerde görürcez.

        List<Fatura> ListeGetir();

        int Kaydet(Fatura nesne);

        int Guncelle(Fatura nesne);

        Fatura Sil(Fatura nesne);
    }
}
