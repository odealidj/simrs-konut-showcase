using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptbrggu
    {
        public short aptbrgguid { get; set; }
        public short? aptgudangid { get; set; }
        public short? loginid { get; set; }
        public DateTime? tglgu { get; set; }
        public DateTime? jamgu { get; set; }
        public string tahun { get; set; }
        public string bulan { get; set; }
        public string ket { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public string updateddate { get; set; }
    }


}
