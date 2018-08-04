using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptstockop
    {
        public short aptstockopid { get; set; }
        public short? aptdepoid { get; set; }
        public string aptstockopnm { get; set; }
        public DateTime? tglstockop { get; set; }
        public DateTime? jamstockop { get; set; }
        public string tahun { get; set; }
        public string bulan { get; set; }
        public string hari { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime updateddate { get; set; }
        public bool? sts { get; set; }
    }


}
