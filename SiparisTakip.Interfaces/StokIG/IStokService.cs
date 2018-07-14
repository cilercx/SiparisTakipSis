using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces.StokIG
{
    public interface IStokService:IGenericService<Stok> // Burda interface interfaceden kalıtım almıştır.Yani IStokService IGenericService 'den kalıtım almıştır.
    {
        List<Stok> OrnekEkstraMetod();
    }
}
