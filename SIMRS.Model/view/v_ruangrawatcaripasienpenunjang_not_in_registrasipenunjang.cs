using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{

    public class v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang
    {
        public short registrasiid { get; set; }
        public short registrasiruangrawatid { get; set; }
        public short? ruangrawatid { get; set; }
        public string ruangrawatnm { get; set; }
        public short? pelayananmedikid { get; set; }
        public string pelayananmediknm { get; set; }
        public short? kelasid { get; set; }
        public string kelasnm { get; set; }
        public string kelasuraian { get; set; }
        public short? kamarid { get; set; }
        public string kamarnm { get; set; }
        public short? tempattidurid { get; set; }
        public string tempattidurnm { get; set; }
        public short? stsregistrasiid { get; set; }
        public string stsregistrasinm { get; set; }
        public short? stsmasukkeluarruangrawatid { get; set; }
        public string stsmasukkeluarruangrawatnm { get; set; }
        public short? pelayananmedikpenunjangid { get; set; }
    }



}
