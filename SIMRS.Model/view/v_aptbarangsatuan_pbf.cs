using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptbarangsatuan_pbf
    {
        public short aptbarangsatuanid { get; set; }
        public short? aptbarangid { get; set; }
        public string aptbarangnm { get; set; }
        public short? aptpbfid { get; set; }
        public string aptpbfnm { get; set; }
        public string satuankecilkode { get; set; }
        public short? jmlsatuankecil { get; set; }
        public string satuanbesarkode { get; set; }
        public short? jmlsatuanbesar { get; set; }
        public string defenisisatuan { get; set; }
    }


}
