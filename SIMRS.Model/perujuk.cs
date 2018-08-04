using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class perujuk
    {
        public short perujukid { get; set; } // smallint, not null
        public string perujuknm { get; set; } // varchar(50), null
        public bool? perujuksts { get; set; } // bit, null
    }

}
