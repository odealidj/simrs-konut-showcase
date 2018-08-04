using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class rw
    {
        public short rwid { get; set; } // smallint, not null
        public short? keldesaid { get; set; } // smallint, null
        public string rwnm { get; set; } // varchar(4), null
        public bool? rwsts { get; set; } // bit, null
    }
}
