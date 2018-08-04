using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class suratrujukanpuskesmas
    {
        public short suratrujukanpuskesmasid { get; set; } // smallint, not null
        public DateTime? suratrujukanpuskesmastgl { get; set; } // datetime, null
        public string suratrujukanpuskesmasno { get; set; } // varchar(30), null
        public short? puskesmasid { get; set; } // smallint, null
        public short? ruangrawatid { get; set; } // smallint, null
        public string icdxsubkategoriid { get; set; } // varchar(6), null
        public short? icdxpuskesmasid { get; set; } // smallint, null
        public string suratrujukanpuskesmastelahdiberikan { get; set; } // varchar(120), null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? suratrujukanpuskesmassts { get; set; } // bit, null
    }



}
