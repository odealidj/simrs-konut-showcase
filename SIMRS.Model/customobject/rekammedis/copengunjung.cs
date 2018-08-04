using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.customobject.rekammedis
{
    public class copengunjung
    {
        public int nomor { get; set; } // smallint, not null
        public int tahun { get; set; } // smallint, not null
        public int bulan { get; set; } // varchar(50), null
        public string  jeniskegiatan { get; set; } // bit, null

        public int jml { get; set; }
    }
}
