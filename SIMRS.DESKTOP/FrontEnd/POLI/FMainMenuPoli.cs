
using SIMRS.DESKTOP.Template.frm.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FMainMenuPoli : FMainMenuRegistrasi
    {
        public FMainMenuPoli() : base()
        {
            this.mlblTitleHeader.Text = string.Format("{0} - [{1}]", this.mlblTitleHeader.Text, Helper.Ruangrawat.ruangrawatnm);

            this.btnMenuRegistrasi.Text = "          Berkas";
            this.btnSubMenuRegistrasiListPasien.Text = "       Pasien Poli";
            this.btnSubMenuRegistrasiListRegistrasi.Text = "       Registrasi Pasien";

            this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            this.btnSubMenuViewPenjamin.Text = "       Dokter";
            this.btnSubMenuViewKecamatan.Text = "       Perawat";
            //this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            //this.btnSubMenuViewPoliklinik.Text = "       Tarif";

            this.btnSubMenuLaporan1.Text = "       Register";
            this.btnSubMenuLaporan2.Text = "       Pendapatan";
            this.btnSubMenuLaporan3.Text = "       Jasa Medis";


        }

        protected override void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListPasienPoli myForm = new FListPasienPoli(ref this.pnlContent);
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
            ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnMenuRegistrasi_Click(object sender, EventArgs e)
        {
            if (pnlMenuRegistrasi.Height == btnMenuRegistrasi.Height)
            {
                pnlMenuRegistrasi.Height = (btnMenuRegistrasi.Height * 3) - 10;

                btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuRegistrasi.Height = btnMenuRegistrasi.Height;
                btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        protected override void btnMenuView_Click(object sender, EventArgs e)
        {
            if (pnlMenuView.Height == btnMenuView.Height)
            {
                pnlMenuView.Height = (btnMenuView.Height * 4) - 20;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuView.Height = btnMenuView.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        protected override void btnSubMenuViewPoliklinik_Click(object sender, EventArgs e) // tarif poli
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListTarifPoli myForm = new FListTarifPoli();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuViewPenjamin_Click(object sender, EventArgs e) // dokter poli
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListDokterPoli myForm = new FListDokterPoli();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuViewKecamatan_Click(object sender, EventArgs e) // perawat poli
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListPerawatPoli myForm = new FListPerawatPoli();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomePoli myForm = new FHomePoli();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnMenuLaporan_Click(object sender, EventArgs e)
        {
            if (pnlMenuLaporan.Height == btnMenuLaporan.Height)
            {
                pnlMenuLaporan.Height = (btnMenuLaporan.Height * 4) - 15;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuLaporan.Height = btnMenuLaporan.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }
    }
}
