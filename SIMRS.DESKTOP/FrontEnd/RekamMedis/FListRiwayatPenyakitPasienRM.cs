using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis
{
    public class FListRiwayatPenyakitPasienRM : FListRiwayatPenyakitPasien
    {
        private int indexSelectedGridFromSender;

        public FListRiwayatPenyakitPasienRM(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat,
            ref int indexSelectedGridFromSender) :
            base(ref pnlContent)
        {
            try
            {
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.indexSelectedGridFromSender = indexSelectedGridFromSender;

                //this.ListRegistrasi = ListRegistrasi;
                lblTitle.Text = string.Format("NoRM: {0}, Nama Pasien: {1}",
                    this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFListRiwayatPenyakitPasienPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListPasienRM myForm = new FListPasienRM(ref this.pnlContent,this.indexSelectedGridFromSender);
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
    }
}
