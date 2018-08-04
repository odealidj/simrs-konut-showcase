using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class registrasirujukanpuskesmas
    {
        public short registrasirujukanpuskesmasid { get; set; } // smallint, not null
        public short? suratrujukanpuskesmasid { get; set; } // smallint, null
        public string nosep { get; set; } // varchar(50), null
        public DateTime? tglsep { get; set; } // datetime, null
        public string pathsep { get; set; } // varchar(255), null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? registrasirujukanpuskesmassts { get; set; } // bit, null
    }

}
