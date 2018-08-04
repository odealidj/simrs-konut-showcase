using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class suku
    {
        public short sukuid { get; set; } // smallint, not null
        public string sukunm { get; set; } // varchar(20), null
        public bool? sukusts { get; set; } // bit, null
    }
}
