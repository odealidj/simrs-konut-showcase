using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class penjaminpasienbpjs
    {
        public short penjaminpasienbpjsid { get; set; }
        public string nosep { get; set; }
        public DateTime? tglsep { get; set; }
        public short? ruangrawatid { get; set; }
        public string icdxsubkategoriid { get; set; }
        public short? icdxpuskesmasid { get; set; }
        public string diagnosaalt { get; set; }
        public DateTime created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? penjaminpasienbpjssts { get; set; }
    }

}
