using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pengobatan
    {
        public int pengobatanid { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public DateTime? tglperiksa { get; set; }
        public short? dokterid { get; set; }
        public short? perawatid { get; set; }
        public string pengobatannm { get; set; }
        public string ukuran { get; set; }
        public string satuan { get; set; }
        public string aturanpakai { get; set; }
    }

}
