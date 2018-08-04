using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class perawat
    {
        public short perawatid { get; set; }
        public byte? perawatgroupid { get; set; }
        public string perawatkode { get; set; }
        public string perawatnm { get; set; }
        public bool? perawatsts { get; set; }
    }

}
