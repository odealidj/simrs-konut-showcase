using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class goldarah
    {
        public short goldarahid { get; set; } // smallint, not null
        public string goldarahnm { get; set; } // varchar(5), null
        public bool? goldarahsts { get; set; } // bit, null
    }
}
