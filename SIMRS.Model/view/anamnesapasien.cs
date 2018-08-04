using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_anamnesapasien
    {
        public short anamnesapasienid { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public string keluhanutama { get; set; }
        public DateTime? tglperiksa { get; set; }
        public short? dokterid { get; set; }
        public string dokternm { get; set; }
        public short? perawatid { get; set; }
        public string perawatnm { get; set; }
    }

}
