using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class dokterruangrawat
    {
        public short dokterruangrawatid { get; set; }
        public short? dokterid { get; set; }
        public short? ruangrawatid { get; set; }
        public bool? sts { get; set; }
    }

}
