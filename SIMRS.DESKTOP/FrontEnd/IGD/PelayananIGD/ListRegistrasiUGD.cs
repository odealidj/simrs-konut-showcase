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
    public class ListRegistrasiUGD : ListRegistrasiPoli
    {

        public ListRegistrasiUGD(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            //this.pnlContent = panel;
            colkelasnm.Visible = false;
            colkamarnm.Visible = false;
            colruangrawatnm.Visible = false;

            colEdit.Visible = false;
            colDelete.Visible = false;

            this.Text = "List Registrasi Pasien IGD";

            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            this.StsmasukKeluarruangrawatid = 1;//Masuk

            tglregistrasiDateEdit.EditValue = DateTime.Now;
        }

        public ListRegistrasiUGD(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) : base(ref _pnlContent)
        {
            //this.pnlContent = panel;
            colkelasnm.Visible = false;
            colkamarnm.Visible = false;
            colruangrawatnm.Visible = false;

            colEdit.Visible = false;
            colDelete.Visible = false;

            this.Text = "List Registrasi IGD";

            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            this.StsmasukKeluarruangrawatid = 1;//Masuk

            this.vregistrasiruangrawat = v_registrasiruangrawat;
            //this.indexRow = indexRow;
            this.indexFocusedRow = indexRow;
            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;


        }
    }
}
