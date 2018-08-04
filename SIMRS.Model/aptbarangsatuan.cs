using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptbarangsatuan
    {
        public short aptbarangsatuanid { get; set; }
        public short? aptbarangid { get; set; }

        public short? aptpbfid { get; set; }
        
        public string satuankecilkode { get; set; }
        public short? jmlsatuankecil { get; set; }
        public string satuanbesarkode { get; set; }
        public short? jmlsatuanbesar { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
    }

}
