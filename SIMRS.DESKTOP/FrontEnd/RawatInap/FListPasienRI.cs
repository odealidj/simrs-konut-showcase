using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FListPasienRI : FListPasienPoli
    {

        public FListPasienRI(ref Panel pnlContent ):base(ref pnlContent)
        {
            this.Text = "List Pasien Rawat Inap - [Telah Keluar]";
            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            Helper.Carapulang.carapulangid = 99;
            //StsmasukKeluarruangrawatid = 0;//Keluar

            //btnCaraPulang.Location = btnPeriksaFisik.Location;
        }

       
        public FListPasienRI(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) : base(ref _pnlContent, ref v_registrasiruangrawat, indexRow)
        {
            this.Text = "List Pasien Rawat Inap - [Telah Keluar]";
            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            Helper.Carapulang.carapulangid = 99;
            //this.StsmasukKeluarruangrawatid = 0;//Keluar
            this.vregistrasiruangrawat = v_registrasiruangrawat;

            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;
            this.indexFocusedRow = indexRow;

            //btnCaraPulang.Location = btnPeriksaFisik.Location;


        }
    }
}
