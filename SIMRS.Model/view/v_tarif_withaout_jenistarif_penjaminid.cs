using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_tarif_withaout_jenistarif_penjaminid
    {

        public int numrow { get; set; }
        public int daftartindakanid { get; set; }
        public string daftartindakannm { get; set; }
        public short kelasid { get; set; }
        public string kelasuraian { get; set; }
        public short ruangrawatid { get; set; }
        public short kelasruangrawatid { get; set; }
        public decimal? biaya { get; set; }
        public decimal? jasasarana { get; set; }
        public decimal? jasapelayanan { get; set; }
    }

}
