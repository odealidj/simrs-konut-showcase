using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class identitaspasienbpjs
    {
        public string nocm { get; set; }
        public string nopeserta { get; set; }
        public string namapeserta { get; set; }
        public string faskes { get; set; }
        public short? kelasbpjsid { get; set; }
        public short? jkid { get; set; }
        public string tempatlahir { get; set; }
        public DateTime? tanggallahir { get; set; }
        public string alamat { get; set; }
        public short? kotakabid { get; set; }
        public short? kecid { get; set; }
        public short? keldesaid { get; set; }
        public short? rwid { get; set; }
        public short? rtid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? identitaspasienbpjssts { get; set; }
    }


}
