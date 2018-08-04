using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_identitaspasien_jk_alamatpasien
    {
        [Display(Name="NO.RM")]
        public string nocm { get; set; } // varchar(11), not null
        [DisplayName("NAMA PASIEN")]
        public string nama { get; set; } // varchar(40), not null
        [DisplayName("TGL.LAHIR")]
        public DateTime? tanggallahir { get; set; } // datetime, null
        public string tempatlahir { get; set; } // varchar(20), null
        public string thn { get; set; } // varchar(4), null
        public string bulan { get; set; } // varchar(2), null
        public string hari { get; set; } // varchar(2), null
        public short? jkid { get; set; } // smallint, null
        public string notelp { get; set; } // varchar(15), null
        public string nohp { get; set; } // varchar(15), null
        public string jknm { get; set; } // varchar(1), null
        public short alamatpasienid { get; set; } // smallint, not null
        public string alamat { get; set; } // varchar(100), null
        public string kodepos { get; set; } // varchar(5), null
        public short? kotakabid { get; set; } // smallint, null
        public short? kecid { get; set; } // smallint, null
        public short? keldesaid { get; set; } // smallint, null
        public short? rwid { get; set; } // smallint, null
        public short? rtid { get; set; } // smallint, null
        public bool? alamatpasiensts { get; set; } // bit, null
        public short? stspernikahanid { get; set; } // smallint, null
        public short? pendidikanid { get; set; } // smallint, null
        public short? pekerjaanid { get; set; } // smallint, null
        public short? agamaid { get; set; } // smallint, null
        public short? goldarahid { get; set; }
        public short? sukuid { get; set; }
        public short? negaraid { get; set; }
    }
}
