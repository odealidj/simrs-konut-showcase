using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class penjaminpasien
    {
        public short penjaminpasienid { get; set; } // smallint, not null
        public short? klpkpasiendid { get; set; } // smallint, null
        public string penjaminpasiennm { get; set; } // varchar(75), null
        public bool? penjaminpasiensts { get; set; } // bit, null
    }

}
