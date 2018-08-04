using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class registrasipenunjang
    {
        public short registrasipenunjangid { get; set; }
        public DateTime? tglregistrasi { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public short? ruangrawatid { get; set; }
        public short? kelasid { get; set; }
        public short? loginappid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? registrasipenunjangsts { get; set; }
    }


}
