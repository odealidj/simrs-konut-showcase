using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class kelasruangrawat
    {
        public short kelasruangrawatid { get; set; }
        public short? kelasid { get; set; }
        public short? ruangrawatid { get; set; }
        public bool? kelasruangrawatsts { get; set; }
    }

}
