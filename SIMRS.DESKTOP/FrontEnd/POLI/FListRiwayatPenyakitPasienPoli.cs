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
    public class FListRiwayatPenyakitPasienPoli : FListRiwayatPenyakitPasien
    {
        protected int indexSelectedGridFromSender;
        protected TFListRegistrasi ListRegistrasi;

        public FListRiwayatPenyakitPasienPoli(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat, 
            ref int indexSelectedGridFromSender, TFListRegistrasi ListRegistrasi) :
            base(ref pnlContent)
        {
            try
            {
                this.Text = "Riwayat Penyakit";
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.indexSelectedGridFromSender = indexSelectedGridFromSender;

                this.ListRegistrasi = ListRegistrasi;
                lblTitle.Text = string.Format("NoRM: {0}, Nama Pasien: {1}, Kelamin: {2}, Usia : {3} Thn {4} Bln {5} Hari",
                    this.v_Registrasiruangrawat.nocm, 
                    this.v_Registrasiruangrawat.nama,
                    this.v_Registrasiruangrawat.jknm,
                    this.v_Registrasiruangrawat.thn,
                    this.v_Registrasiruangrawat.bulan,
                    this.v_Registrasiruangrawat.hari);
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
                //ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent);

                if (this.ListRegistrasi.GetType().Name.ToLower() == "listregistrasipoli")
                {
                    ListRegistrasi = new ListRegistrasiPoli(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexSelectedGridFromSender);
                }
                else
                {
                    ListRegistrasi = new FListPasienPoli(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexSelectedGridFromSender);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasienPoli()\nbtnBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
