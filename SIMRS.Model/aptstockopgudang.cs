using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptstockopgudang
    {
        public short aptstockopgudangid { get; set; }
        public short? aptgudangid { get; set; }
        public short? aptbarangmasukid { get; set; }
        public DateTime? tglstock { get; set; }
        public DateTime? jamstock { get; set; }
        public string tahun { get; set; }
        public string bulan { get; set; }
        public string keterangan { get; set; }
        public byte? aptstsstockid { get; set; }
        public short? loginid { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
    }

}
