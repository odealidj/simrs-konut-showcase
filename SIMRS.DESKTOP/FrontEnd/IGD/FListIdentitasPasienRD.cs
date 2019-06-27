using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using SIMRS.Model.view;

using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD
{
    public class FListIdentitasPasienRD : FListIdentitasPasienRJ
    {
        public FListIdentitasPasienRD(ref Panel _pnlContent):base(ref _pnlContent)
        {

        }

        protected override void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {
            var data = identitaspasienGV.GetRow(identitaspasienGV.GetSelectedRows()[0]) as v_identitaspasien_jk_alamatpasien;

            if (data == null)
            {
                identitaspasienGV.SelectRow(0);
                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih atau klik data pasien yang akan diregistrasikan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FAddEditRegistrasiPasienLamaRD myForm = new FAddEditRegistrasiPasienLamaRD(ref this.pnlContent, data.nocm);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
        }
    }
}
