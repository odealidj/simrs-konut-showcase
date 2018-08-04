using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptbarangsatuantrigger
    {
        public short aptbarangsatuantriggerid { get; set; }
        public short? aptbarangsatuanid { get; set; }
        public string aptsatuankode { get; set; }
        public short? qty { get; set; }
        public string stskb { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
    }

}
