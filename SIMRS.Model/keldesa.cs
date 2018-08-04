using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class keldesa
    {
        public short keldesaid { get; set; } // smallint, not null
        public short? kecid { get; set; } // smallint, null
        public string keldesanm { get; set; } // varchar(60), null
        public bool? keldesasts { get; set; } // bit, null
    }
}
