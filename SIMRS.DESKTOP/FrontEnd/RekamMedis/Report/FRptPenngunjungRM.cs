using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.frm.RekamMedis;
using SIMRS.Services.FrontEnd.RekaMedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis.Report
{
    public class FRptPenngunjungRM : TFListReportFilterByPelayananmedisAndDate
    {
        private bool IsLoadedForm = false;
        private void defaultControl ()
        {
            this.tglregistrasiLbl.Text = "Periode";
            this.pelayananmedisLbl.Visible = true;
            this.pelayananmedisLookUpEdit.Visible = true;
            this.CaridataMTxt.Visible = false;

            this.tglregistrasiDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglregistrasiDateEdit.Properties.Mask.EditMask = "MMMM-yyyy";
            this.tglregistrasiDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tglregistrasiDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            this.lappengunjungGC.Visible = true;
        }

        protected void LoadAllPengunjung(int tahun, int bulan)
        {
            try
            {
                using (var service = new FLapPengunjungServices())
                {
                    //var data = Task.Run(() => RestClient.RestBank.GetAllBankAsync(token, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAllPengunjung(tahun, bulan));
                    if (result.Result.Item2 != null)
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, this);
                        return;
                    }
                    else
                    {
                        this.lappengunjungGC.DataSource = result.Result.Item1;
                        //this.v_Registrasiruangrawats = result.Item1.ToList();
                        //bukuregisterGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, this);
            }
        }

        public FRptPenngunjungRM(ref Panel pnlContent) : base(ref pnlContent)
        {
            
            defaultControl();
            this.tglregistrasiDateEdit.EditValue = DateTime.Now;

        }

        public FRptPenngunjungRM()
        {
            defaultControl();

            //this.tglregistrasiDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.

        }

        protected override void FListReportFilterByPelayananmedisAndDate_Load(object sender, EventArgs e)
        {
            this.IsLoadedForm = false;
        }

        protected override void FListReportFilterByPelayananmedisAndDate_Shown(object sender, EventArgs e)
        {
            this.IsLoadedForm = true;
        }

        protected override void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.IsLoadedForm == false) return;
                if (tglregistrasiDateEdit.EditValue == null)
                {
                    CustomMessageBox.MessageWarning("Periode tanggal tidak boleh kosong", this);
                    this.tglregistrasiDateEdit.Focus();
                    return;
                }
                this.LoadAllPengunjung(DateTime.Parse(tglregistrasiDateEdit.EditValue.ToString()).Year,
                    DateTime.Parse(tglregistrasiDateEdit.EditValue.ToString()).Month);
            }
            catch(Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "tglregistrasiDateEdit_EditValueChanged()", this.Name, this);
            }

        }
    }
}
