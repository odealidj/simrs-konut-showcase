using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptstockopgudang
    {
        public short aptstockopgudangid { get; set; }
        public DateTime? tglmasukgudang { get; set; }
        public string ketgudang { get; set; }
        public short aptbarangmasukid { get; set; }
        public DateTime? tglmasukpembelian { get; set; }
        public string nobeli { get; set; }
        public string ketpembelian { get; set; }

        public string tahunstock { get; set; }
        public string bulanstock { get; set; }
    }

}
