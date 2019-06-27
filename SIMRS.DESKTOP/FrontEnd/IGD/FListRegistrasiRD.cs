using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;

using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD
{
    public class FListRegistrasiRD : FListRegistrasiRJ
    {
        public FListRegistrasiRD(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            colkelasnm.Visible = false;
            colkamarnm.Visible = false;
            colruangrawatnm.Caption = "IGD";
        }

        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FAddEditRegistrasiPasienBaruRD myForm = new FAddEditRegistrasiPasienBaruRD(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {
            ////Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            ////this.pnlContent.Controls.Clear();
            //////fDashboard myForm = new fDashboard();
            ////FListIdentitasPasienRD myForm = new FListIdentitasPasienRD(ref this.pnlContent);
            ////myForm.TopLevel = false;
            ////myForm.AutoScroll = true;
            ////myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            ////this.pnlContent.Controls.Add(myForm);
            ////myForm.Dock = DockStyle.Fill;
            ////myForm.Show();

            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FAddEditRegistrasiPasienLamaRD myForm = new FAddEditRegistrasiPasienLamaRD(ref this.pnlContent, ref this.vregistrasiruangrawat);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAddRegistrasiPasienLama_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
