using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD.PelayananIGD
{
    public class FListPasienUGD : FListPasienPoli
    {
        public FListPasienUGD(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "List Pasien IGD - [Telah Periksa]";
            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            this.StsmasukKeluarruangrawatid = 0;//Keluar

        }

        public FListPasienUGD(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) : base(ref _pnlContent)
        {
            this.Text = "List Pasien UGD - [Telah Periksa]";
            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            this.StsmasukKeluarruangrawatid = 0;//Keluar
            this.vregistrasiruangrawat = v_registrasiruangrawat;

            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;
            this.indexFocusedRow = indexRow;



        }
    }
}
