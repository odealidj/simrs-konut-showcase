using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_perawat
    {
        public short perawatid { get; set; }
        public string perawatnm { get; set; }
        public short? ruangrawatid { get; set; }
        public string ruangrawatnm { get; set; }
    }

}
