using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class sapaan
    {
        public short sapaanid { get; set; } // smallint, not null
        public string sapaannm { get; set; } // varchar(4), null
        public string sapaandesk { get; set; } // varchar(25), null
        public bool? sapaansts { get; set; } // bit, null
    }

}
