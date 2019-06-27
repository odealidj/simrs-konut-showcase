using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.DESKTOP.FrontEnd.RAD;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Operasi
{
    public class FTindakanPasienOperasi : FTindakanPasienLAB
    {
        public FTindakanPasienOperasi(ref Panel pnlContent,
           ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref int indexSelectedFromSender) :
                base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang, ref indexSelectedFromSender)
        {
            this.Text = "Tindakan Pasien Operasi";
        }

        protected override void addMbtn_Click(object sender, EventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FTarifPoli2 myForm = new FTarifPoli2(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.indexSelectedRow_v_registrasiruangrawat);

                FTarifOperasi myForm = new FTarifOperasi(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.indexSelectedRow_v_registrasiruangrawat_penunjang);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\naddMbtn_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Tindakanpenunjang != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();

                    ////FTarifPoli2 myForm = new FTarifPoli2(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.v_Tindakanpenunjang);
                    FTarifOperasi myForm = new FTarifOperasi(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.v_Tindakanpenunjang);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\neditrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {

            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiOperasi myForm = new FListRegistrasiOperasi(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, this.indexSelectedRow_v_registrasiruangrawat_penunjang);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
