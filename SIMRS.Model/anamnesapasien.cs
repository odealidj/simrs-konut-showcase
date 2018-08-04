using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class anamnesapasien
    {
        public short anamnesapasienid { get; set; }
        public int? registrasiruangrawatid { get; set; }
        public string keluhanutama { get; set; }
        public string keluhantambahan { get; set; }
        public string imunisasi { get; set; }
        public DateTime? tglperiksa { get; set; }
        public short? dokterid { get; set; }
        public short? perawatid { get; set; }
    }

}
