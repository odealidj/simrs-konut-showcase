using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class icdxkategori
    {
        public string icdxkategoriid { get; set; } // varchar(3), not null
        public string icdxkategorinmeng { get; set; } // varchar(150), null
        public string icdxkategorinmindo { get; set; } // varchar(150), null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? icdxkategorists { get; set; } // bit, null
    }

}
