using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pelayananpasienpelunasan
    {
        public int pelayananpasienpelunasanid { get; set; }
        public short? strukpelayananid { get; set; }
        public decimal? totalbayar { get; set; }
        public decimal? totalpiutang { get; set; }
        public decimal? totalbebas { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? pelayananpasienpelunasansts { get; set; }
    }



}
