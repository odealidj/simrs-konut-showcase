using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class kamar
    {
        public short kamarid { get; set; }
        public short? kelasruangrawatid { get; set; }
        public short? ruangrawatid { get; set; }
        public string kamarnm { get; set; }
        public bool? kamarsts { get; set; }
    }


}
