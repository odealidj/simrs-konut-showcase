using SIMRS.DESKTOP.FrontEnd.LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.FrontEnd.RAD
{
    public class FAddEditTarifRad : FAddEditTarifLab
    {
        public FAddEditTarifRad(int daftartindakanid,
                string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
            : base(daftartindakanid, namatarif, harga, jasasarana, jasapelayanan)
        {
            this.Text = "Edit Tarif RAD";
            this.bUpdate.Text = "Update";
        }
    }
}
