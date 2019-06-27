using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FPengobatanPasienPoli : FPengobatanPasien
    {
        protected TFListRegistrasi ListRegistrasi;
        protected int indexRow;

        public FPengobatanPasienPoli(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat, ref int indexRow,
            TFListRegistrasi ListRegistrasi) : base(ref pnlContent)
        {
            try
            {
                this.Text = "Pengobatan Pasien";
                this.tglperiksadateEdit.ReadOnly = true;
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.ListRegistrasi = ListRegistrasi;
                lblTitle.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama Pasien: {2}",
                    this.v_Registrasiruangrawat.noregistrasi, this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama);
                ruangrawatMTxt.Text = this.v_Registrasiruangrawat.ruangrawatnm;
                kelasMTxt.Text = string.Empty;

                this.indexRow = indexRow;
                this.tglperiksadateEdit.EditValue = this.v_Registrasiruangrawat.tglmasuk;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPengobatanPasienPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (this.ListRegistrasi.GetType().Name.ToLower() == "listregistrasipoli")
                {
                    ListRegistrasi = new ListRegistrasiPoli(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexRow);
                }
                else
                {
                    ListRegistrasi = new FListPasienPoli(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexRow);
                }

                ListRegistrasi.TopLevel = false;
                ListRegistrasi.AutoScroll = true;
                //ListRegistrasi.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(ListRegistrasi);
                ListRegistrasi.Dock = DockStyle.Fill;
                ListRegistrasi.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPengobatanPasienPoli()\nbtnBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
