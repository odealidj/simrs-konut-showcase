using SIMRS.DESKTOP.Template.frm.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Kasir
{
    public class FMainMenuKasir : FMainMenuRegistrasi
    {
        public FMainMenuKasir():base()
        {

            this.btnMenuRegistrasi.Text = "          Berkas";
            this.btnSubMenuRegistrasiListPasien.Text = "       Pelunasan";
            this.btnSubMenuRegistrasiListRegistrasi.Text = "       Registrasi";

            this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            this.btnSubMenuViewPenjamin.Text = "       Ruang Perawatan";
            this.btnSubMenuViewKecamatan.Text = "       Poliklinik";
            //this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            //this.btnSubMenuViewPoliklinik.Text = "       Tarif";

            this.btnSubMenuLaporan1.Text = "       Pendapatan";
        }

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeKasir myForm = new FHomeKasir();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
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

        protected override void btnMenuLaporan_Click(object sender, EventArgs e)
        {
            if (pnlMenuLaporan.Height == btnMenuLaporan.Height)
            {
                pnlMenuLaporan.Height = (btnMenuLaporan.Height * 2) - 5;

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


        protected override void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListPelunasan myForm = new FListPelunasan(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasi myForm = new FListRegistrasi(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
