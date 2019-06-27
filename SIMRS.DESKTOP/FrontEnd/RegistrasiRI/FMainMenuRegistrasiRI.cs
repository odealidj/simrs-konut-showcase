
using SIMRS.DESKTOP.Template.frm.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRI
{
    public class FMainMenuRegistrasiRI : FMainMenuRegistrasi
    {
        public FMainMenuRegistrasiRI() : base()
        {
            Helper.Stsregistrasi.stsregistrasiid = 1;
            Helper.Stsregistrasi.stsregistrasinm = "Daftar";
            Helper.Stsregistrasi.stsregistrasists = true;

            this.btnMenuRegistrasi.Text = "         Berkas";
            this.btnSubMenuRegistrasiListPasien.Text = "     List Pasien Pulang";
            this.btnSubMenuRegistrasiListRegistrasi.Text = "     List Registrasi";


            this.btnSubMenuViewPoliklinik.Text = "     List Tarif";
            this.btnSubMenuViewPenjamin.Text = "     List Ruang Rawat";
            this.btnSubMenuViewKecamatan.Text = "     List Dokter";
            this.btnSubMenuViewKelurahan.Text = "     List Perawat";

            this.btnSubMenuLaporan1.Text = "     Register";
        }

        protected override void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {
            //Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

            //pnlContent.Controls.Clear();
            ////fDashboard myForm = new fDashboard();
            //FListIdentitasPasienRJ myForm = new FListIdentitasPasienRJ();
            //myForm.TopLevel = false;
            //myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            //pnlContent.Controls.Add(myForm);
            //myForm.Dock = DockStyle.Fill;
            //myForm.Show();
        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

            pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiRI myForm = new FListRegistrasiRI(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

            pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeRegistrasiRI myForm = new FHomeRegistrasiRI();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }

        protected override void btnSubMenuLaporan1_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FLapBukuRegisterRI myForm = new FLapBukuRegisterRI(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
