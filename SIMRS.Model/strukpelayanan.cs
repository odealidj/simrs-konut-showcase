using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class strukpelayanan
    {
        public short strukpelayananid { get; set; }
        public string strukpelayanannostruk { get; set; }
        public DateTime? strukpelayanantgl { get; set; }
        public DateTime? strukpelayananjam { get; set; }
        public string strukpelayanannokw { get; set; }
        public decimal? grandtotalbiaya { get; set; }
        public decimal? grandtotalbayar { get; set; }
        public decimal? grandtotalpiutang { get; set; }
        public decimal? grandtotalbebas { get; set; }
        public short? loginappid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? strukpelayanansts { get; set; }
    }


}
