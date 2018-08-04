using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class stspernikahan
    {
        public short stspernikahanid { get; set; } // smallint, not null
        public string stspernikahannm { get; set; } // varchar(50), null
        public bool? stspernikahansts { get; set; } // bit, null
    }
}
