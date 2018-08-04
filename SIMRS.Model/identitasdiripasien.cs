using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class identitasdiripasien
    {
        public string nocm { get; set; }
        public short? identitasdiriid { get; set; }
        public string nomoridentitas { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool? identitasdiripasiensts { get; set; }
    }

}
