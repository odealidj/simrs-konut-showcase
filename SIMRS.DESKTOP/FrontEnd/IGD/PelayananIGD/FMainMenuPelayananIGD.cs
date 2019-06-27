using SIMRS.DESKTOP.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD.PelayananIGD
{
    public class FMainMenuPelayananIGD : FMainMenuPoli
    {


        public FMainMenuPelayananIGD() : base()
        {
            this.mlblTitleHeader.Text = string.Format("{0} - [{1}]", this.mlblTitleHeader.Text, Helper.Ruangrawat.ruangrawatnm);

            this.btnMenuRegistrasi.Text = "          Berkas";
            this.btnSubMenuRegistrasiListPasien.Text = "       Pasien UGD";
            this.btnSubMenuRegistrasiListRegistrasi.Text = "       Registrasi Pasien";

            this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            this.btnSubMenuViewPenjamin.Text = "       Dokter";
            this.btnSubMenuViewKecamatan.Text = "       Perawat";
            //this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            //this.btnSubMenuViewPoliklinik.Text = "       Tarif";


        }

        protected override void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListPasienUGD myForm = new FListPasienUGD(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            ListRegistrasiUGD myForm = new ListRegistrasiUGD(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuViewPoliklinik_Click(object sender, EventArgs e) // tarif IGD
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListTarifIGD myForm = new FListTarifIGD();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
