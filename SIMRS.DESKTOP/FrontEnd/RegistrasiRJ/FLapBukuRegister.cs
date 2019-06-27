using DevExpress.XtraReports.UI;
using SIMRS.DESKTOP.Template.frm.Registrasi;
using SIMRS.DESKTOP.Template.Report.Registrasi;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FLapBukuRegister : FListReportFilterByDate
    {
        private IList<v_registrasiruangrawat> v_Registrasiruangrawats;

        private stsmasukkeluar Stsmasukkeluar;

        #region private method



        #endregion

        #region private method control
        protected void LoadAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(short pelayananmedikid, DateTime tglmasuk, short stsmasukkeluar, string value)
        {
            try
            {
                using (var service = new FLapBukuRegisterServices())
                {
                    var result = service.SelectAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(pelayananmedikid, tglmasuk, stsmasukkeluar, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.v_Registrasiruangrawats = result.Item1.ToList();
                        bukuregisterGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        public FLapBukuRegister(ref Panel pnlContent) : base(ref pnlContent)
        {

            this.Stsmasukkeluar = new stsmasukkeluar { stsmasukkeluarid = 1 };

            this.Text = "List Buku Register - Rawat Jalan";
            this.tglregistrasiDateEdit.EditValue = DateTime.Now.Date;
            this.bukuregisterGC.Visible = true;
        }

        protected override void FListReportFilterByDate_Load(object sender, EventArgs e)
        {
            
        }

        protected override void FListReportFilterByDate_Shown(object sender, EventArgs e)
        {

        }

        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.v_Registrasiruangrawats == null) return;
                RegisterReport1 report = new RegisterReport1(this.v_Registrasiruangrawats);
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }
                
                report.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnPrint_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (tglregistrasiDateEdit.EditValue == null)
                {
                    this.tglregistrasiDateEdit.Focus();
                    return;
                }
                LoadAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(Helper.Pelayananmedik.pelayananmedikid,
                    (DateTime)tglregistrasiDateEdit.EditValue, this.Stsmasukkeluar.stsmasukkeluarid, string.Empty);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntglregistrasiDateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
