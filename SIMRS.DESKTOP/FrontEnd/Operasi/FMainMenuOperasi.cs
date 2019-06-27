using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.DESKTOP.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Operasi
{
    public class FMainMenuOperasi: FMainMenuLAB
    {
        public FMainMenuOperasi() : base()
        {
            
            Helper.Stsregistrasi.stsregistrasiid = 1;
            Helper.Stsregistrasi.stsregistrasinm = "Daftar";
            Helper.Stsregistrasi.stsregistrasists = true;

            Helper.Ruangrawat.ruangrawatid = 38;
            Helper.Ruangrawat.pelayananmedikid = Helper.Pelayananmedik.pelayananmedikid;
            Helper.Ruangrawat.ruangrawatnm = "Kamar Operasi";

        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiOperasi myForm = new FListRegistrasiOperasi(ref this.pnlContent);
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

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeOperasi myForm = new FHomeOperasi();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
