using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD
{
    public class FMainMenuRegistrasiRD : FMainMenuRegistrasiRJ
    {
        public FMainMenuRegistrasiRD() :base()
        {
            Helper.Prosedurmasuk.ProsedurmasukId = "02";
            Helper.Prosedurmasuk.ProsedurmasukNm = "Rawat Darurat";
            Helper.Prosedurmasuk.Prosedurmasuksts = true;
        }

        protected override void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

            pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListIdentitasPasienRD myForm = new FListIdentitasPasienRD(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

            pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiRD myForm = new FListRegistrasiRD(ref this.pnlContent);
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
            FHomeIGD myForm = new FHomeIGD();
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
            FLapBukuRegisterRD myForm = new FLapBukuRegisterRD(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
