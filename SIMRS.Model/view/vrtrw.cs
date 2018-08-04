using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class vrtrw
    {
        public short? keldesaid { get; set; } // smallint, null
        public short rwid { get; set; } // smallint, not null
        public short rtid { get; set; } // smallint, not null
        public string rtrw { get; set; } // varchar(9), null
    }


}
