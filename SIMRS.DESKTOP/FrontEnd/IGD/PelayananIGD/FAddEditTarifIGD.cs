using SIMRS.DESKTOP.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.FrontEnd.IGD.PelayananIGD
{
    public class FAddEditTarifIGD : FAddEditTarifPoli
    {
        public FAddEditTarifIGD(int daftartindakanid, short kelasid,
               string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
           : base(daftartindakanid, kelasid, namatarif, harga, jasasarana, jasapelayanan)
        {
            this.Text = "Edit Tarif Pelayanan IGD";
            this.bUpdate.Text = "Update";
        }
    }
}
