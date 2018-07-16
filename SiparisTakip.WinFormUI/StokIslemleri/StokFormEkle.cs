using SiparisTakip.Entity.ModelsDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakip.WinFormUI.StokIslemleri
{
    public partial class StokFormEkle : Form
    {
        public StokFormEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            StokDto sDto = new StokDto();
            sDto.BarkodNo = txtBarkodNo.Text.Trim();
            sDto.StokAdi = txtStokAdi.Text.Trim();
            sDto.AlisFyati = Convert.ToInt32(txtAlisFiyati);
            sDto.KdvOrani = Convert.ToInt32(txtKdvOrani);
            sDto.AktifMi = Convert.ToBoolean(chkAktifMi);


        }
    }
}
