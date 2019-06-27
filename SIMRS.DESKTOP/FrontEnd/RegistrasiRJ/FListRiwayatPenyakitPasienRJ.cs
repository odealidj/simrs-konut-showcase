using DevExpress.XtraReports.UI;
using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.Report.Registrasi;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FListRiwayatPenyakitPasienRJ : FListRiwayatPenyakitPasien
    {

        private int indexSelectedGridFromSender;
        private FListRegistrasiRJ fListRegistrasiRJ ;
        private FListIdentitasPasienRJ fListIdentitasPasienRJ;


        public FListRiwayatPenyakitPasienRJ(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat,
            ref int indexSelectedGridFromSender, FListRegistrasiRJ fListRegistrasiRJ) :
            base(ref pnlContent)
        {
            try
            {
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.indexSelectedGridFromSender = indexSelectedGridFromSender;

                //this.ListRegistrasi = ListRegistrasi;
                lblTitle.Text = string.Format("NoRM: {0}, Nama Pasien: {1}",
                    this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama);

                if (fListRegistrasiRJ!=null)
                {
                    this.fListRegistrasiRJ = fListRegistrasiRJ;
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFListRiwayatPenyakitPasienPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public FListRiwayatPenyakitPasienRJ(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat,
            ref int indexSelectedGridFromSender, FListIdentitasPasienRJ fListIdentitasPasienRJ) :
            base(ref pnlContent)
        {
            try
            {
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.indexSelectedGridFromSender = indexSelectedGridFromSender;

                //this.ListRegistrasi = ListRegistrasi;
                lblTitle.Text = string.Format("NoRM: {0}, Nama Pasien: {1}",
                    this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama);

                if (fListIdentitasPasienRJ != null)
                {
                    this.fListIdentitasPasienRJ = fListIdentitasPasienRJ;
                }

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
                if (this.fListRegistrasiRJ != null)
                {
                    this.fListRegistrasiRJ = new FListRegistrasiRJ(ref this.pnlContent, this.indexSelectedGridFromSender);
                    fListRegistrasiRJ.TopLevel = false;
                    fListRegistrasiRJ.AutoScroll = true;
                    //fListRegistrasiRJ.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(fListRegistrasiRJ);
                    fListRegistrasiRJ.Dock = DockStyle.Fill;
                    fListRegistrasiRJ.Show();
                }

                if (this.fListIdentitasPasienRJ != null)
                {
                    this.fListIdentitasPasienRJ = new FListIdentitasPasienRJ(ref this.pnlContent, this.indexSelectedGridFromSender);
                    fListIdentitasPasienRJ.TopLevel = false;
                    fListIdentitasPasienRJ.AutoScroll = true;
                    //fListIdentitasPasienRJ.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(fListIdentitasPasienRJ);
                    fListIdentitasPasienRJ.Dock = DockStyle.Fill;
                    fListIdentitasPasienRJ.Show();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                KartuStatusReport1 report = new KartuStatusReport1(this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama,
                    string.Format("{0} Thn, {1} Bln, {2} Hari",this.v_Registrasiruangrawat.thn.ToString(), this.v_Registrasiruangrawat.bulan, this.v_Registrasiruangrawat.hari),
                    "", this.v_Registrasiruangrawat.alamat, this.v_Registrasiruangrawat.penjaminpasiennm,
                    ((this.v_Registrasiruangrawat.ruangrawatnm !=null)? this.v_Registrasiruangrawat.ruangrawatnm.ToUpper():string.Empty),
                    this.v_Statuspenyakits);
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }

                report.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nbtnPrint_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
