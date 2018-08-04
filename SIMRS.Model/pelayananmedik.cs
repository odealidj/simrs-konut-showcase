using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pelayananmedik
    {
        public short pelayananmedikid { get; set; } // smallint, not null
        public string pelayananmediknm { get; set; } // varchar(45), null
        public string pelayananmedikuraian { get; set; } // varchar(120), null
        public bool? pelayananmediksts { get; set; } // bit, null
    }

}
