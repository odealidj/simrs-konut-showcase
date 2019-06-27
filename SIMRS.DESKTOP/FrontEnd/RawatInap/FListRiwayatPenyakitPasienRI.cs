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
    public class FListRiwayatPenyakitPasienRI : FListRiwayatPenyakitPasienPoli
    {
        public FListRiwayatPenyakitPasienRI(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat,
                ref int indexSelectedGridFromSender, TFListRegistrasi ListRegistrasi) :
            base(ref pnlContent, ref v_Registrasiruangrawat, ref indexSelectedGridFromSender, ListRegistrasi)
        {
           
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent);


                ListRegistrasi = new FListRegistrasiRI(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexSelectedGridFromSender);

                ListRegistrasi.TopLevel = false;
                ListRegistrasi.AutoScroll = true;
                //ListRegistrasi.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(ListRegistrasi);
                ListRegistrasi.Dock = DockStyle.Fill;
                ListRegistrasi.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasienPoli()\nbtnBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
