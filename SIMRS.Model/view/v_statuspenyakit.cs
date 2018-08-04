using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_statuspenyakit
    {
        public string nocm { get; set; }
        public string nama { get; set; }
        public short? thn { get; set; }
        public short? bulan { get; set; }
        public short? hari { get; set; }
        public short? goldarahid { get; set; }
        public string goldarahnm { get; set; }
        public short? pekerjaanid { get; set; }
        public string pekerjaannm { get; set; }
        public short alamatpasienid { get; set; }
        public string alamat { get; set; }
        public short registrasiid { get; set; }
        public short? penjaminpasienid { get; set; }
        public string penjaminpasiennm { get; set; }
        public DateTime? tglmasuk { get; set; }
        public DateTime? jammasuk { get; set; }
        public DateTime? tglkeluar { get; set; }
        public short? stsmasukkeluarid { get; set; }
        public short? loginappid { get; set; }
        public short registrasiruangrawatid { get; set; }
        public short? ruangrawatid { get; set; }
        public string ruangrawatnm { get; set; }
        public string icdxsubkategorieng { get; set; }
        public short? pemeriksaanfisikid { get; set; }
        public string periksafisik { get; set; }
        public short? anamnesapasienid { get; set; }
        public string keluhanutama { get; set; }
        public int? pengobatanid { get; set; }
        public string pengobatanuraian { get; set; }
    }



}
