using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class kotakab
    {
        public short kotakabid { get; set; } // smallint, not null
        public short? propinsiid { get; set; } // smallint, null
        public string kotakabnm { get; set; } // varchar(30), null
        public string kotakabnmpendek { get; set; } // varchar(15), null
        public bool? kotakabsts { get; set; } // bit, null
    }
}
