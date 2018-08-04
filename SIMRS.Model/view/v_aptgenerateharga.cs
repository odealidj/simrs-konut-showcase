using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptgenerateharga
    {
        public short aptbarangmasukdetailid { get; set; }
        public DateTime? tglbeli { get; set; }
        public string aptpbfnm { get; set; }
        public string aptbarangnm { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public decimal? hargasatuan { get; set; }
        public decimal? hargappn { get; set; }
        public decimal? hargatigalima { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
    }

}
