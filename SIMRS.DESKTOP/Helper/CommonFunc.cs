using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Helper
{
    public static class Usia
    {
        public static short Tahun { get; set; }
        public static short Bulan { get; set; }
        public static short Hari { get; set; }
    }

    public class CommonFunc
    {
        static short tanggalLahir, tanggalSekarang, bulanLahir, bulanSekarang, tahunLahir, tahunSekarang;

        static short bulan, tahun, bulan1, tgl1, tgl2;

        public static (short, short, short) HitungUmur (short _tahun, short _bulan, short _hari)
        {

            //Usia static usia;

            tanggalLahir = _hari;
            bulanLahir = _bulan;
            tahunLahir = _tahun;

            tanggalSekarang = (short)( DateTime.Now.Day);
            bulanSekarang = (short)(DateTime.Now.Month);
            tahunSekarang = (short)(DateTime.Now.Year);

            tahun = (short)(tahunSekarang - tahunLahir);
            bulan1 = (short)(bulanSekarang - bulanLahir);
            tgl1 = (short)(tanggalSekarang - tanggalLahir);
            tgl2 = (short)(tanggalLahir - tanggalSekarang);

            if (bulanSekarang < bulanLahir)
            {
                tahun = (short)(tahun - 1);
                bulan = (short)(12 - bulanLahir + bulanSekarang);

            }

            if ((tahunSekarang > tanggalLahir) && (tanggalSekarang >= tanggalLahir) && (bulanSekarang >= bulanLahir))
            {
                Usia.Tahun = tahun; Usia.Bulan = bulan1; Usia.Hari = tgl1;
            }
            else if ((tahunSekarang > tanggalLahir) && (tanggalSekarang <= tanggalLahir) && (bulanSekarang <= bulanLahir))
            {
                bulan = (short)(12 - bulanLahir + bulanSekarang);
                Usia.Tahun = tahun; Usia.Bulan = bulan; Usia.Hari = tgl2;
            }
            else if ((tahunSekarang > tanggalLahir) && (tanggalSekarang >= tanggalLahir) && (bulanSekarang <= bulanLahir))
            {
                bulan = (short) (12 - bulanLahir + bulanSekarang);
                Usia.Tahun = tahun; Usia.Bulan = bulan; Usia.Hari = tgl1;
            }
            else if ((tahunSekarang > tanggalLahir) && (tanggalSekarang <= tanggalLahir) && (bulanSekarang >= bulanLahir))
            {
                Usia.Tahun = tahun; Usia.Bulan = bulan1; Usia.Hari = tgl2;
            }
            else
            {
                Usia.Tahun = (short) DateTime.Now.Year; ; Usia.Bulan = (short)DateTime.Now.Month ; Usia.Hari = (short)DateTime.Now.Day;
            }
            return (Usia.Tahun,Usia.Bulan,Usia.Hari);
        }

       
        public static string basePathImageIdentitasPasien()
        {
            //return @"C:\\Projct\\Myproject\\simrs-konut\\app\\SIMRSv8\\SIMRS\\Image\\IdentitasPasien\\";

            return Application.StartupPath + @"\Image\IdentitasPasien\";
        }

    }
}
