using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptdistribusi
    {
        public short aptdistribusiid { get; set; }
        public short? depoasalid { get; set; }
        public short? depotujuanid { get; set; }
        public DateTime? tgldistribusi { get; set; }
        public string tahun { get; set; }
        public string bulan { get; set; }
        public string ketdistribusi { get; set; }
        public bool? online { get; set; }
        public string depoasalnm { get; set; }
        public string depotujuannm { get; set; }
    }


}
