using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD
{
    public class FLapBukuRegisterRD : FLapBukuRegister
    {

        public FLapBukuRegisterRD(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.Text = "List Buku Register - Rawat Darurat";
            this.tglregistrasiDateEdit.EditValue = DateTime.Now.Date;
            this.bukuregisterGC.Visible = true;
        }
    }
}
