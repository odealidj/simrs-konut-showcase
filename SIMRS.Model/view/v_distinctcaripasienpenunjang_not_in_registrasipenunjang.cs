using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_distinctcaripasienpenunjang_not_in_registrasipenunjang
    {
        public short registrasiid { get; set; }
        public DateTime? tglmasuk { get; set; }
        public TimeSpan? jammasuk { get; set; }
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
        public string prosedurmasukid { get; set; }
        public string prosedurmasuknm { get; set; }
        public short? stsregistrasiid { get; set; }
        public string stsregistrasinm { get; set; }
        public short? stsmasukkeluarid { get; set; }
        public string stsmasukkeluarnm { get; set; }

    }


}
