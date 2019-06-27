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
    public class FPeriksaFisikPoli : FPeriksaFisik
    {
        

        protected TFListRegistrasi ListRegistrasi;
        protected int indexRow;

        public FPeriksaFisikPoli(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat,ref int indexRow,
            TFListRegistrasi ListRegistrasi) :base(ref pnlContent)
        {
            try
            {
                this.Text = "Pemeriksaan Fisik";
                this.tglperiksadateEdit.ReadOnly = true;

                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.ListRegistrasi = ListRegistrasi;

                lblTitle.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama Pasien: {2}",
                    this.v_Registrasiruangrawat.noregistrasi, this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama);
                ruangrawatMTxt.Text = this.v_Registrasiruangrawat.ruangrawatnm;
                kelasMTxt.Text = string.Empty;
                tglperiksadateEdit.EditValue = this.v_Registrasiruangrawat.tglmasuk.Value.Date;
                this.indexRow = indexRow;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nFPeriksaFisikPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPeriksaFisikPoli()\nbtnBack_Click()" + "\nFPeriksaFisikPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        


    }
}
