using SIMRS.DESKTOP.FrontEnd.Gizi;
using SIMRS.DESKTOP.FrontEnd.IGD;
using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.FrontEnd.RAD;
using SIMRS.DESKTOP.FrontEnd.RawatInap;
using SIMRS.DESKTOP.FrontEnd.RegistrasiRI;
using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using SIMRS.DESKTOP.FrontEnd.Kasir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS.DESKTOP.FrontEnd.RekamMedis;
using SIMRS.DESKTOP.FrontEnd.IGD.PelayananIGD;
using SIMRS.DESKTOP.FrontEnd.Operasi;
using SIMRS.DESKTOP.FrontEnd.Farmasi;

using SIMRS.DESKTOP.Template.frm.SIE;
using SIMRS.DESKTOP.Template.frm;

namespace SIMRS.DESKTOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //modul registrasi rawat jalan
            //Application.Run(new FLoginRegistrasiRJ());

            //modul Registrasi IGD
            //Application.Run(new FLoginRegistrasiIGD());

            //modul Pelayanan IGD
            //Application.Run(new FLoginPelayananIGD());


            //modul registrasi rawat inap
            //Application.Run(new FLoginRegistrasiRI());

            //modul pelayanan RI
            //Application.Run(new FLoginRI());

            //modul Operasi
            //Application.Run(new FLoginOperasi());

            //modul LAB
            ///Application.Run(new FLoginLAB());

            //modul RAD
            //Application.Run(new FLoginRAD());

            //modul gizi
            //Application.Run(new FLoginGizi());

            //modul POLI

            //Application.Run(new FLoginPoli());

            //modul rekam medis
            //Application.Run(new FLoginRekamMedis());

            //modul kasir
            //Application.Run(new FLoginKasir());

           

            Application.Run(new TFWalpaper());

            //Modul SIE
            //Application.Run(new FMainMenuSIE());



        }
    }
}
