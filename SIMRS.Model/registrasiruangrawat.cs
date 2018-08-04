using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class registrasiruangrawat
    {
        public short registrasiruangrawatid { get; set; }
        public short? registrasiid { get; set; }
        public DateTime? tglmasukruangan { get; set; }
        public DateTime? jammasukruangan { get; set; }
        public DateTime? tglkeluarruangan { get; set; }
        public DateTime? jamkeluarruangan { get; set; }
        public short? kelasid { get; set; }
        public short? ruangrawatid { get; set; }
        public short? kamarid { get; set; }
        public short? tempattidurid { get; set; }
        public short? loginappid { get; set; }
        public short? stsregistrasiid { get; set; }
        public short? stsmasukkeluarruangrawatid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? registrasiruangrawatsts { get; set; }
    }



}
