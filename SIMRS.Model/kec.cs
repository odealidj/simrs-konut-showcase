using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class kec
    {
        public short kecid { get; set; } // smallint, not null
        public short? kotakabid { get; set; } // smallint, null
        public string kecnm { get; set; } // varchar(60), null
        public bool? kecsts { get; set; } // bit, null
    }

}
