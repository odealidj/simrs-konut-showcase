using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class klpkpasien
    {
        public short klpkpasiendid { get; set; } // smallint, not null
        public string klpkpasiendnm { get; set; } // varchar(50), null
        public bool? klpkpasiendsts { get; set; } // bit, null
    }

}
