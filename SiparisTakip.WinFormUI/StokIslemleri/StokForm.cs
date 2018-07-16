using SiparisTakip.BLL.StokBLL;
using SiparisTakip.Dal.Concrete.EntityFrameWork.Repository;
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
    public partial class StokForm : Form
    {
        public StokForm()
        {
            InitializeComponent();

        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            StokManager stokmanager = new StokManager(new EFStokRepository());

            var data = stokmanager.ListeGetir();
            grdStok.DataSource = data;
        }
    }
}
