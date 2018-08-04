using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_registrasi_identitaspasien_nocm_nama
    {
        public short registrasiid { get; set; } // smallint, not null
        public string nocm { get; set; } // varchar(11), null
        public string noregistrasi { get; set; } // varchar(10), not null
        public string prosedurmasukid { get; set; } // varchar(2), null
        public DateTime? tglmasuk { get; set; } // datetime, null
        public DateTime? tglkeluar { get; set; } // datetime, null
        public short? instalasipelayananid { get; set; } // smallint, null
        public short? kelasid { get; set; } // smallint, null
        public string kelasnm { get; set; } // varchar(15), null
        public short? ruangrawatid { get; set; } // smallint, null
        public string ruangrawatnm { get; set; } // varchar(50), null
        public short? kamarid { get; set; } // smallint, null
        public short? penjaminpasienid { get; set; } // smallint, null
        public short? petugasid { get; set; } // smallint, null
        public string nama { get; set; } // varchar(40), not null
        public short? klpkpasiendid { get; set; } // smallint, null
        public string penjaminpasiennm { get; set; } // varchar(75), null
        public string klpkpasiendnm { get; set; } // varchar(50), null
        public bool? registrasists { get; set; } // bit, null
        public bool? ruangrawatsts { get; set; } // bit, null
        public string instalasipelayanannm { get; set; } // varchar(50), null
    }

}
