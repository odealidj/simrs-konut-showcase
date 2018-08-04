using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class alamatpasien
    {
        public short alamatpasienid { get; set; }
        public string nocm { get; set; }
        public string alamat { get; set; }
        public string kodepos { get; set; }
        public short? kotakabid { get; set; }
        public short? kecid { get; set; }
        public short? keldesaid { get; set; }
        public short? rwid { get; set; }
        public short? rtid { get; set; }
        public bool? alamatpasiensts { get; set; }
    }

}
