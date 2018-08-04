using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class tarif
    {
        public int tarifid { get; set; }
        public int? daftartindakanid { get; set; }
        public string daftarjenistindakanid { get; set; }
        public short kelasid { get; set; }
        public string jenistarifid { get; set; }
        public decimal? biaya { get; set; }
        public decimal? Jasasarana { get; set; }
        public decimal? Jasapelayanan { get; set; }
        public decimal? Jasarumahsakit { get; set; }
        public decimal? jasadokter { get; set; }
        public decimal? jasaaskep { get; set; }
        public decimal? jasakeperawatan { get; set; }
        public bool? tarifsts { get; set; }
        public string kode { get; set; }
        public string Kodepelayanan { get; set; }
        public string KodeKelas { get; set; }
    }

}
