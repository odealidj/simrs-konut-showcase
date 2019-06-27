using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FListTindakanPasienKeluarRI : FListTindakanPasienRI
    {
        public FListTindakanPasienKeluarRI(ref Panel _pnlContent) : base(ref _pnlContent)
        {

        }

        public FListTindakanPasienKeluarRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, ref int indexSelectedRow_v_registrasiruangrawat) :
            base(ref _pnlContent, ref _vregistrasiruangrawat, ref indexSelectedRow_v_registrasiruangrawat)
        {
            //contructor
            this.addMbtn.Enabled = false;
            this.colEdit.OptionsColumn.AllowEdit = false;
            this.colDelete.OptionsColumn.AllowEdit = false;
        }

        public FListTindakanPasienKeluarRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat) :
            base(ref _pnlContent, ref _vregistrasiruangrawat)
        {

        }


        public FListTindakanPasienKeluarRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat,
            int indexSelectedRow_v_registrasiruangrawat_forSender) :
            base(ref _pnlContent, ref _vregistrasiruangrawat, indexSelectedRow_v_registrasiruangrawat_forSender)
        {

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {


            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiKeluarRI myForm = new FListRegistrasiKeluarRI(ref this.pnlContent, ref this.Vregistrasiruangrawat, this.indexSelectedRow_v_registrasiruangrawat);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
