using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_registrasiruangrawat_penunjang
    {
        public short registrasiid { get; set; }
        public DateTime? tglmasuk { get; set; }
        public DateTime? jammasuk { get; set; }
        public string noregistrasi { get; set; }
        public string nocm { get; set; }
        public string nama { get; set; }
        public string jknm { get; set; }
        public DateTime? tanggallahir { get; set; }
        public short? thn { get; set; }
        public short? bulan { get; set; }
        public short? hari { get; set; }
        public short? ruangrawatid { get; set; }
        public string ruangrawatnm { get; set; }
        public short? penjaminpasienid { get; set; }
        public string penjaminpasiennm { get; set; }
        public string prosedurmasukid { get; set; }
        public string prosedurmasuknm { get; set; }
        public short? pelayananmedikid { get; set; }
        public string pelayananmediknm { get; set; }
        public short registrasiruangrawatid { get; set; }
        public DateTime? tglmasukruangan { get; set; }
        public short? kelasid { get; set; }
        public string kelasnm { get; set; }
        public string kelasuraian { get; set; }
        public short? kamarid { get; set; }
        public string kamarnm { get; set; }
        public short? tempattidurid { get; set; }
        public string tempattidurnm { get; set; }
        public short? stsregistrasiid { get; set; }
        public string stsregistrasinm { get; set; }
        public short? stsmasukkeluarid { get; set; }
        public string stsmasukkeluarnm { get; set; }
        public short? stsmasukkeluarruangrawatid { get; set; }
        public string stsmasukkeluarruangrawatnm { get; set; }
        public short registrasipenunjangid { get; set; }
        public DateTime? tglregistrasipenunjang { get; set; }
        public short? ruangrawatpenunjangid { get; set; }
        public string ruangrawatpenunjangnm { get; set; }
        public short? kelaspenunjangid { get; set; }
        public string kelaspenunjangnm { get; set; }
        public short? pelayananmedikpenunjangid { get; set; }
        public string pelayananmedikpenunjangnm { get; set; }
    }


}
