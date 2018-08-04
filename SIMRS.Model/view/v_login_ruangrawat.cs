using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_login_ruangrawat
    {
        public short loginappid { get; set; }
        public string loginappuser { get; set; }
        public string loginapppasswd { get; set; }
        public short loginappdetailid { get; set; }
        public string loginappdetailnik { get; set; }
        public string loginappdetailnm { get; set; }
        public string modulappkode { get; set; }
        public string modulappnm { get; set; }
        public short ruangrawatid { get; set; }
        public short pelayananmedikid { get; set; }
    }

}
