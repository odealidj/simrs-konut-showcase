using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class propinsi
    {
        public short propinsiid { get; set; } // smallint, not null
        public string propinsinm { get; set; } // varchar(75), null
        public bool? propinsists { get; set; } // bit, null
    }
}
