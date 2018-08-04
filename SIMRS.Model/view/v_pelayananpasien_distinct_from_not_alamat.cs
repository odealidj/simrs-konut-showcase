using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_pelayananpasien_distinct_from_not_alamat
    {
        public short registrasiid { get; set; }
        public DateTime? tglmasuk { get; set; }

        public DateTime? tglkeluar { get; set; }
        
        public string noregistrasi { get; set; }
        public string nocm { get; set; }
        public string nama { get; set; }
        public string jknm { get; set; }
        public DateTime? tanggallahir { get; set; }
        public short? thn { get; set; }
        public short? bulan { get; set; }
        public short? hari { get; set; }
        public short? penjaminpasienid { get; set; }
        public string penjaminpasiennm { get; set; }
        public short? stsmasukkeluarid { get; set; }
        public string stsmasukkeluarnm { get; set; }
    }

}
