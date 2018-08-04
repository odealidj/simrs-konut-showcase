using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class vruangrawat_kelasruangrawatid_kamarid_tempattidurid
    {
        public short ruangrawatid { get; set; } // smallint, not null
        public string ruangrawatnm { get; set; } // varchar(50), null
        public short? pelayananmedikid { get; set; } // smallint, null
        public short kelasruangrawatid { get; set; } // smallint, not null
        public short? kelasid { get; set; } // smallint, null
        public short kamarid { get; set; } // smallint, not null
        public short tempattidurid { get; set; } // smallint, not null
    }

}
