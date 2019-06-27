

using SIMRS.DESKTOP.FrontEnd.LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FMainMenuGizi : FMainMenuLAB
    {
        public FMainMenuGizi() : base()
        {
            Helper.Stsregistrasi.stsregistrasiid = 1;
            Helper.Stsregistrasi.stsregistrasinm = "Daftar";
            Helper.Stsregistrasi.stsregistrasists = true;

            Helper.Ruangrawat.ruangrawatid = 55;
            Helper.Ruangrawat.pelayananmedikid = Helper.Pelayananmedik.pelayananmedikid;
            Helper.Ruangrawat.ruangrawatnm = "Gizi";

            this.btnSubMenuViewPoliklinik.Text = "      List Tarif";
            this.btnSubMenuViewPenjamin.Text = "      List Dokter";
            this.btnSubMenuViewKecamatan.Text = "      List Perawat";
        }

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeGizi myForm = new FHomeGizi();
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
                FListRegistrasiGizi myForm = new FListRegistrasiGizi(ref this.pnlContent);
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

        protected override void btnSubMenuViewPoliklinik_Click(object sender, EventArgs e) //List Tarif LAB
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListTarifGizi myForm = new FListTarifGizi();
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
    }
}
