using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_pengobatan
    {
        public int pengobatanid { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public DateTime? tglperiksa { get; set; }
        public short? dokterid { get; set; }
        public string dokternm { get; set; }
        public short? perawatid { get; set; }
        public string perawatnm { get; set; }
        public string pengobatannm { get; set; }
        public string ukuran { get; set; }
        public string satuan { get; set; }
        public string aturanpakai { get; set; }
        public string uraian { get; set; }
    }


}
