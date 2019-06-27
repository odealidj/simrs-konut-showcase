using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FListLihatTindakanPasienPoli : FListTindakanPasienPoli
    {
        public FListLihatTindakanPasienPoli(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, ref int indexSelectedRow_v_registrasiruangrawat) :base(ref _pnlContent,ref _vregistrasiruangrawat, ref indexSelectedRow_v_registrasiruangrawat)
        {

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            //FListPasienPoli myForm = new FListPasienPoli(ref this.pnlContent);
            FListPasienPoli myForm = new FListPasienPoli(ref this.pnlContent,ref this.Vregistrasiruangrawat,this.indexSelectedRow_v_registrasiruangrawat);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        
    }
}
