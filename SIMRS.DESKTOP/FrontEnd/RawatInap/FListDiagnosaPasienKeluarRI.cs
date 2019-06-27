using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FListDiagnosaPasienKeluarRI : FListDiagnosaPasienRI
    {
        public FListDiagnosaPasienKeluarRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, ref int indexRow) : base
            (ref _pnlContent, ref _vregistrasiruangrawat, ref indexRow)
        {
            this.bAddIcdX.Enabled = false;

            this.colDel.OptionsColumn.AllowEdit = false;

        }



        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiKeluarRI myForm = new FListRegistrasiKeluarRI(ref this.pnlContent, ref this.Vregistrasiruangrawat, this.indexSelectedRow);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }
    }
}
