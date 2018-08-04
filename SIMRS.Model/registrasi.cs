using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class registrasi
    {
        public short registrasiid { get; set; }
        public string nocm { get; set; }
        public string noregistrasi { get; set; }
        public string prosedurmasukid { get; set; }
        public DateTime? tglmasuk { get; set; }
        public DateTime? jammasuk { get; set; }
        public DateTime? tglkeluar { get; set; }
        public DateTime? jamkeluar { get; set; }
        public short? instalasipelayananid { get; set; }
        public short? penjaminpasienid { get; set; }
        public short? stspasienbaruid { get; set; }
        public short? petugasid { get; set; }
        public short? carapulangid { get; set; }
        public short? kondisipulangid { get; set; }
        public short? stsmasukkeluarid { get; set; }
        public short? loginappid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? registrasists { get; set; }
    }




}
