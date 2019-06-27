using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.frm.RekamMedis;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.RekaMedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis.Report
{
    public class FRptTopTenPenyakitRM : TFListReportFilterByPelayananmedisAndDate
    {

        #region private method control

        private void defaultsetinglookupeditPelayananmedik()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref pelayananmedisLookUpEdit,
               new string[] { "pelayananmedikid", "pelayananmediknm" },
               new string[] { "Kode", "Nama" },
               new bool[] { false, true },
               "pelayananmediknm", "pelayananmedikid", "Pilih pelayananmedik");
        }

        protected void LoadAllPelayananmedik()
        {
            try
            {
                using (var service = new PelayananmedikServices())
                {
                    var result = service.SelectAll();
                    if (result == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data pelayananmedik tidak diada!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        pelayananmedisLookUpEdit.Properties.DataSource = result;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_RL_54ByThnAndBlnAsync(int tahun, int bulan)
        {
            try
            {
                using (var service = new RLServices())
                {
                    var result = await service.SelectAllv_RL_54ByThnAndBlnAsync (tahun,bulan);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.RL54GC.DataSource = result.Item1;
                        
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion
        private void defaultControl()
        {
            this.tglregistrasiLbl.Text = "Periode";
            this.pelayananmedisLbl.Visible = true;
            this.pelayananmedisLookUpEdit.Visible = true;
            this.CaridataMTxt.Visible = false;

            this.tglregistrasiDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglregistrasiDateEdit.Properties.Mask.EditMask = "MMMM-yyyy";
            this.tglregistrasiDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tglregistrasiDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            this.RL54GC.Visible = true;
        }

        public FRptTopTenPenyakitRM(ref Panel pnlContent) : base(ref pnlContent)
        {

            defaultControl();
            defaultsetinglookupeditPelayananmedik();
            LoadAllPelayananmedik();
            this.tglregistrasiDateEdit.EditValue = DateTime.Now;

        }

        public FRptTopTenPenyakitRM()
        {
            defaultControl();

            //this.tglregistrasiDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.

        }

        protected override void pelayananmedisLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (tglregistrasiDateEdit.EditValue == null)
                {
                    this.tglregistrasiDateEdit.Focus();
                    return;
                }
                if (this.pelayananmedisLookUpEdit.EditValue == null)
                {
                    this.pelayananmedisLookUpEdit.Focus();
                    return;
                }

                LoadAllv_RL_54ByThnAndBlnAsync(((DateTime)tglregistrasiDateEdit.EditValue).Year, ((DateTime)tglregistrasiDateEdit.EditValue).Month);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntglregistrasiDateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (this.pelayananmedisLookUpEdit.EditValue == null)
                {
                    this.pelayananmedisLookUpEdit.Focus();
                    return;
                }

                LoadAllv_RL_54ByThnAndBlnAsync(((DateTime)tglregistrasiDateEdit.EditValue).Year, ((DateTime)tglregistrasiDateEdit.EditValue).Month);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntglregistrasiDateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
