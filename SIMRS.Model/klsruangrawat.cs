using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class klsruangrawat
    {
        public short klsruangrawatid { get; set; } // smallint, not null
        public short? kelasid { get; set; } // smallint, null
        public short? ruangrawatid { get; set; } // smallint, null
        public bool? klsruangrawatsts { get; set; } // bit, null
    }

}
