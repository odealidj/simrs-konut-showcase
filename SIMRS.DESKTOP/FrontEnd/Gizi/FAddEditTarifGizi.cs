using SIMRS.DESKTOP.FrontEnd.LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FAddEditTarifGizi : FAddEditTarifLab
    {
        public FAddEditTarifGizi(int daftartindakanid,
                string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
            : base(daftartindakanid, namatarif, harga, jasasarana, jasapelayanan)
        {
            this.Text = "Edit Tarif Gizi";
            this.bUpdate.Text = "Update";
        }
    }
}
