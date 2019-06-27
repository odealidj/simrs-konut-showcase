using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FTarifRI : FTarifPoli2
    {
        public FTarifRI(ref Panel pnlContent) : base(ref pnlContent)
        {

        }

        public FTarifRI(ref Panel pnlContent, ref short penjaminid, ref short kelasid, ref short ruangrawatid) :
            base(ref pnlContent, ref penjaminid, ref kelasid, ref ruangrawatid)
        {


        }

        public FTarifRI(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat, ref int indexSelectedRowFromSender) : 
            base(ref pnlContent, ref Vregistrasiruangrawat,ref indexSelectedRowFromSender)
        {
            

        }

        public FTarifRI(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat) : 
            base(ref pnlContent, ref Vregistrasiruangrawat)
        {

        }


        public FTarifRI(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat, ref v_tindakanpoli v_Tindakanpoli) : 
            base(ref pnlContent, ref Vregistrasiruangrawat,ref v_Tindakanpoli)
        {
            
        }

        public FTarifRI(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref int indexSelectedRowFromSender) : 
            base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang,ref indexSelectedRowFromSender)
        {
            
        }

        public FTarifRI(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref v_tindakanpenunjang v_Tindakanpenunjang) : 
            base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang,ref v_Tindakanpenunjang)
        {
            
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    //FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat);
                    FListTindakanPasienRI myForm = new FListTindakanPasienRI(ref this.pnlContent, ref this.Vregistrasiruangrawat, ref this.indexSelectedRowFromSender);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
