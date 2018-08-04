using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class identitaspasien
    {
        public string nocm { get; set; } // varchar(11), not null
        public short? sapaanid { get; set; } // smallint, null
        public string nama { get; set; } // varchar(50), null
        public string tempatlahir { get; set; } // varchar(20), null
        public DateTime? tanggallahir { get; set; } // datetime, null
        public short? thn { get; set; } // smallint, null
        public short? bulan { get; set; } // smallint, null
        public short? hari { get; set; } // smallint, null
        public short? jkid { get; set; } // smallint, null
        public short? stspernikahanid { get; set; } // smallint, null
        public short? pendidikanid { get; set; } // smallint, null
        public short? pekerjaanid { get; set; } // smallint, null
        public short? agamaid { get; set; } // smallint, null
        public string notelp { get; set; } // varchar(15), null
        public string nohp { get; set; } // varchar(15), null
        public short? goldarahid { get; set; } // smallint, null
        public short? sukuid { get; set; } // smallint, null
        public short? negaraid { get; set; } // smallint, null
        public bool? identitaspasiensts { get; set; } // bit, null
    }



}
