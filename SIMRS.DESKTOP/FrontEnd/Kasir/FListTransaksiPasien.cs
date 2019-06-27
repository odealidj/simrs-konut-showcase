using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Kasir
{
    public class FListTransaksiPasien : FListSeven
    {
        public FListTransaksiPasien(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "List Transaksi Pasien";
            this.CaridataMTxt.WaterMark = "Input NoRM or Nama or Noregistrasi or NoKwitanasi untuk pencarian transasi pasien";
        }
    }
}
