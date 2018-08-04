using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pekerjaan
    {
        public short pekerjaanid { get; set; } // smallint, not null
        public string pekerjaannm { get; set; } // varchar(50), null
        public bool pekerjaansts { get; set; } // bit, not null
    }
}
