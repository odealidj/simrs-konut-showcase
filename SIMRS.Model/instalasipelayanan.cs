using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class Instalasipelayanan
    {
        public short instalasipelayananid { get; set; } // smallint, not null
        public string instalasipelayanannm { get; set; } // varchar(50), null
        public bool? instalasipelayanansts { get; set; } // bit, null
    }
}
