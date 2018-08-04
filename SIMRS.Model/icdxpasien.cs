using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class icdxpasien
    {
        public short icdxpasienid { get; set; }
        public string icdxsubkategoriid { get; set; }
        public short? registrasiid { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public DateTime? icdxpasientgl { get; set; }
        public short? jenisdiagnosaid { get; set; }
        public short? dokterid { get; set; }
        public short? loginappid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? icdxpasiensts { get; set; }
    }


}
