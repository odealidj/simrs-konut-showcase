using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class hubkeluarga
    {
        public short hubkeluargaid { get; set; } // smallint, not null
        public string hubkeluarganm { get; set; } // varchar(20), null
        public bool? hubkeluargasts { get; set; } // bit, null
    }

}
