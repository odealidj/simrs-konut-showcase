using SIMRS.DESKTOP.Template.frm.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.LAB
{
    public class FMainMenuLAB : FMainMenuRegistrasi
    {
        public FMainMenuLAB()
        {
            Helper.Stsregistrasi.stsregistrasiid = 1;
            Helper.Stsregistrasi.stsregistrasinm = "Daftar";
            Helper.Stsregistrasi.stsregistrasists = true;

            Helper.Ruangrawat.ruangrawatid = 51;
            Helper.Ruangrawat.pelayananmedikid = Helper.Pelayananmedik.pelayananmedikid;
            Helper.Ruangrawat.ruangrawatnm = "Laboratorium";

            this.btnSubMenuViewPoliklinik.Text = "      List Tarif";
            this.btnSubMenuViewPenjamin.Text = "      List Dokter";
            this.btnSubMenuViewKecamatan.Text = "      List Analis";

            this.btnSubMenuLaporan1.Text = "      Register";
            this.btnSubMenuLaporan2.Text = "      Pendapatan";

        }

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeLAB myForm = new FHomeLAB();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiLAB myForm = new FListRegistrasiLAB(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void btnMenuView_Click(object sender, EventArgs e)
        {
            if (pnlMenuView.Height == btnMenuView.Height)
            {
                pnlMenuView.Height = (btnMenuView.Height * 4) - 15;

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

        protected override void btnSubMenuViewPoliklinik_Click(object sender, EventArgs e) //List Tarif LAB
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListTarifLAB myForm = new FListTarifLAB();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuViewPenjamin_Click(object sender, EventArgs e) //List Dokter
        {

        }

        protected override void btnSubMenuViewKecamatan_Click(object sender, EventArgs e) //LIst Analist
        {

        }

        protected override void btnMenuLaporan_Click(object sender, EventArgs e)
        {
            if (pnlMenuLaporan.Height == btnMenuLaporan.Height)
            {
                pnlMenuLaporan.Height = (btnMenuLaporan.Height * 3) - 10;

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
