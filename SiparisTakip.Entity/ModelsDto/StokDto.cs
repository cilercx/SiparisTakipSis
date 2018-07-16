using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Entity.ModelsDto
{
    public class StokDto
    {
        public string BarkodNo { get; set; }
        public string StokAdi { get; set; }
        public int AlisFyati { get; set; }
        public int KdvOrani { get; set; }
        public int SatisFiyati { get; set; }
        public bool AktifMi { get; set; }

    }
}
