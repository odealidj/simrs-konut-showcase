using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class identitasdiri
    {
        public short identitasdiriid { get; set; } // smallint, not null
        public string identitasdirinm { get; set; } // varchar(20), null
        public bool? identitasdirists { get; set; } // bit, null
    }

}
