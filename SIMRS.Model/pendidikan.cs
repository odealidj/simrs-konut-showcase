using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pendidikan
    {
        public short pendidikanid { get; set; } // smallint, not null
        public string pendidikannm { get; set; } // varchar(75), null
        public bool? pendidikansts { get; set; } // bit, null
    }
}
