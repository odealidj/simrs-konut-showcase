using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class negara
    {
        public short negaraid { get; set; } // smallint, not null
        public short? negaranm { get; set; } // smallint, null
        public bool? negarasts { get; set; } // bit, null
    }
}
