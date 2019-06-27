using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FListRegistrasiGizi : FListRegistrasiLAB
    {
        public FListRegistrasiGizi (ref Panel _pnlContent):base(ref _pnlContent)
        {
            this.Text = "List Pasien Gizi";
            //this.bTindakan.Visible = false;
        }

        public FListRegistrasiGizi(ref Panel _pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, int indexSelectedRegistrasi) : base(ref _pnlContent)
        {

            //Contructor Back From Tindakan RAD

            this.Text = "List Pasien Radiologi";

        }

        protected override void registerRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if ((this.v_Distinctpasienpenunjang == null) || (this.v_Registrasiruangrawat_Penunjang == null)) return;


                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();

                FTindakanPasienGizi myForm = new FTindakanPasienGizi(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref indexSelectedRegistrasi);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nregisterRepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListCariPasienGizi myForm = new FListCariPasienGizi(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        //protected override void bTindakan_Click(object sender, EventArgs e)
        //{
        //    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

        //    this.pnlContent.Controls.Clear();
        //    //fDashboard myForm = new fDashboard();
        //    FTindakanPasienGizi myForm = new FTindakanPasienGizi();
        //    myForm.TopLevel = false;
        //    myForm.AutoScroll = true;
        //    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
        //    this.pnlContent.Controls.Add(myForm);
        //    myForm.Dock = DockStyle.Fill;
        //    myForm.Show();
        //}
    }
}
