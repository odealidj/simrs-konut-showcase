using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class dokter
    {
        public short dokterid { get; set; }
        public string dokterkode { get; set; }
        public string dokternm { get; set; }
        public bool? doktersts { get; set; }
    }


}
