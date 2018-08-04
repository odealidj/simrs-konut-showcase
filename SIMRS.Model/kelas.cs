using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class kelas
    {
        public short kelasid { get; set; } // smallint, not null
        public string kelasnm { get; set; } // varchar(15), null
        public string kelasuraian { get; set; } // varchar(25), null
        public bool? kelassts { get; set; } // bit, null
    }

}
