using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptdistribusi
    {
        public short aptdistribusiid { get; set; }
        public short? aptdepoid { get; set; }
        public short? aptdepoid2 { get; set; }
        public DateTime? tgldistribusi { get; set; }
        public DateTime? jamdistribusi { get; set; }
        public string tahun { get; set; }
        public string bulan { get; set; }
        public string ketdistribusi { get; set; }
        public bool? online { get; set; }
        public short? loginid { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
    }

}
