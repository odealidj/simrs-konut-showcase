using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class icdxpasienstskasus
    {
        public short icdxpasienid { get; set; }
        public string icdxsubkategoriid { get; set; }
        public byte? stskasusid { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
        public bool? sts { get; set; }
    }

}
