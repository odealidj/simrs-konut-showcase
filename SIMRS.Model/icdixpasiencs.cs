using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class icdixpasien
    {
        public short icdixpasienid { get; set; }
        public DateTime? icdixpasientgl { get; set; }
        public int? pelayananpasienid { get; set; }
        public string icdixkode { get; set; }
        public short? loginappid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? icdixpasiensts { get; set; }
    }

}
