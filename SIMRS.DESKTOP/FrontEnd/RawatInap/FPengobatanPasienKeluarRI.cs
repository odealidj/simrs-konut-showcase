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
    public class FPengobatanPasienKeluarRI : FPengobatanPasienRI
    {
        public FPengobatanPasienKeluarRI(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat, ref int indexRow,
            TFListRegistrasi ListRegistrasi) :
                base(ref pnlContent, ref v_Registrasiruangrawat, ref indexRow, ListRegistrasi)
        {
            try
            {
                this.btnAddPengobatan.Enabled = false;
                this.colDelete.OptionsColumn.AllowEdit = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPengobatanPasienRI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent);

                ListRegistrasi = new FListRegistrasiKeluarRI(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexRow);


                ListRegistrasi.TopLevel = false;
                ListRegistrasi.AutoScroll = true;
                //ListRegistrasi.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(ListRegistrasi);
                ListRegistrasi.Dock = DockStyle.Fill;
                ListRegistrasi.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
