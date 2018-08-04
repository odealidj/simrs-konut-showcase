using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_pelayananpasienkarcis
    {
        public short? pelayananpasienid { get; set; }
        public DateTime? pelayananpasientgl { get; set; }
        public DateTime? pelayananpasienjam { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public short? pelayananmedikid { get; set; }
        public string jenistarifid { get; set; }
        public short? tarifid { get; set; }
        public decimal? biaya { get; set; }
        public short? jml { get; set; }
        public decimal? total { get; set; }
        public short? loginappid { get; set; }
        public short? ruangrawatid { get; set; }
        public short? kelasid { get; set; }
        public short? stspasienbaruid { get; set; }
    }

}
