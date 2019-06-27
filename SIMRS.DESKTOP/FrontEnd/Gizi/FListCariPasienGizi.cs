using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FListCariPasienGizi : FListCariPasienLAB
    {
        public FListCariPasienGizi(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.bTindakan.Visible = false;
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataRuangRawatDeatil == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih ruang perawatan pasien yang akan didaftarkan\n" +
                        "dengan cara klik pada tabel ruang perawatan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FKonfirmasiRegistrasiPenunjangGizi myForm = new FKonfirmasiRegistrasiPenunjangGizi(ref this.pnlContent, ref this.dataRuangRawatDeatil);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nbtnAdd_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiGizi myForm = new FListRegistrasiGizi(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
