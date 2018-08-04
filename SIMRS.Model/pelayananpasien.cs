using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pelayananpasien
    {
        public int pelayananpasienid { get; set; }
        public DateTime? pelayananpasientgl { get; set; }
        public DateTime? pelayananpasienjam { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public short? registrasipenunjangid { get; set; }
        public short? pelayananmedikid { get; set; }
        public short? dokterid { get; set; }
        public short? perawatid { get; set; }
        public string jenistarifid { get; set; }
        public int? tarifid { get; set; }
        public decimal? biaya { get; set; }
        public short? jml { get; set; }
        public decimal? totalbiaya { get; set; }
        public short? loginappid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? pelayananpasiensts { get; set; }
    }


}
