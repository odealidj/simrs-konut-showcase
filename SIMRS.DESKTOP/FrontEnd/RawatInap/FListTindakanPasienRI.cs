
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
    public class FListTindakanPasienRI : FListTindakanPasienPoli
    {
        public FListTindakanPasienRI(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            
        }

        public FListTindakanPasienRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, ref int indexSelectedRow_v_registrasiruangrawat) : 
            base(ref _pnlContent,ref _vregistrasiruangrawat, ref indexSelectedRow_v_registrasiruangrawat)
        {
            
        }

        public FListTindakanPasienRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat) : 
            base(ref _pnlContent, ref _vregistrasiruangrawat)
        {
           
        }


        public FListTindakanPasienRI(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat,
            int indexSelectedRow_v_registrasiruangrawat_forSender) : 
            base(ref _pnlContent,ref _vregistrasiruangrawat, indexSelectedRow_v_registrasiruangrawat_forSender)
        {

        }

        protected override void addMbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FTarifRI myForm = new FTarifRI(ref this.pnlContent, ref this.Vregistrasiruangrawat, ref this.indexSelectedRow_v_registrasiruangrawat);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message +"\n"+this.Name+ "\naddMbtn_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        protected override void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.selectedTindakanPoli != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FTarifRI myForm = new FTarifRI(ref this.pnlContent, ref this.Vregistrasiruangrawat, ref this.selectedTindakanPoli);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message +"\n"+ this.Name+ "\neditrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {


            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiRI myForm = new FListRegistrasiRI(ref this.pnlContent, ref this.Vregistrasiruangrawat, this.indexSelectedRow_v_registrasiruangrawat);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }


    }
}
