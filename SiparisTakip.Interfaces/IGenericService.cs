using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    public interface IGenericService<T>// Heryerde kullanacağımız standart metodlarımız asağıdaki gibidir.Biz buraya T olarak Hangi nesne tipini gönderirsek bu metodlar ona göre sekil alır. 
    {

        T Getir(int id);

        List<T> ListeGetir();

        int Kaydet(T nesne);

        int Guncelle(T nesne);

        T Sil(T nesne);


    }
}
