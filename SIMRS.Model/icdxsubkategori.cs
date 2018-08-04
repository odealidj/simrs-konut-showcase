using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class icdxsubkategori
    {
        public string icdxsubkategoriid { get; set; } // varchar(6), not null
        public string icdxkategoriid { get; set; } // varchar(3), null
        public string icdxsubkategorinmeng { get; set; } // varchar(150), null
        public string icdxsubkategorieng { get; set; } // varchar(155), null
        public string icdxsubkategorinmindo { get; set; } // varchar(150), null
        public string icdxsubkategoriindo { get; set; } // varchar(155), null
        public bool? icdxsubkategorists { get; set; } // bit, null
    }

}
