using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{

    public class puskesmas
    {
        public short puskesmasid { get; set; }
        public short? perujukid { get; set; }
        public string faskesno { get; set; }
        public string puskesmasno { get; set; }
        public string puskesmasnm { get; set; }
        public string puskesmasalamat { get; set; }
        public short? kotakabid { get; set; }
        public short? kecid { get; set; }
        public short? keldesaid { get; set; }
        public string puskesmasnotelp { get; set; }
        public string puskesmashp { get; set; }
        public string puskesmastag { get; set; }
        public bool? puskesmassts { get; set; }
    }



}
