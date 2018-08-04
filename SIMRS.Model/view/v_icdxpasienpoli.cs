using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_icdxpasienpoli
    {
        public short icdxpasienid { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public string icdxsubkategoriid { get; set; }
        public string icdxsubkategorinmeng { get; set; }
        public string icdxsubkategorinmindo { get; set; }
        public short jenisdiagnosaid { get; set; }
        public string jenisdiagnosanm { get; set; }
    }


}
