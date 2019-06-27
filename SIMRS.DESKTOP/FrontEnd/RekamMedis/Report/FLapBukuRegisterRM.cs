using DevExpress.XtraReports.UI;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.RekamMedis;
using SIMRS.DESKTOP.Template.Report.Registrasi;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.RekaMedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis
{
    public class FLapBukuRegisterRM : TFListReportFilterByPelayananmedisAndDate
    {
        private IList<v_registrasiruangrawat> v_Registrasiruangrawats;

        private stsmasukkeluar Stsmasukkeluar;

        #region private method



        #endregion

        #region private method control

        private void defaultsetinglookupeditPelayananmedik()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref pelayananmedisLookUpEdit ,
               new string[] { "pelayananmedikid", "pelayananmediknm" },
               new string[] { "Kode", "Nama" },
               new bool[] { false, true },
               "pelayananmediknm", "pelayananmedikid", "Pilih pelayananmedik");
        }

        protected void LoadAllPelayananmedik()
        {
            try
            {
                using (var service = new FLapBukuRegisterRMServices())
                {
                    var result = service.SelectAllPelayananmedik();
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

        protected void LoadAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(short pelayananmedikid, DateTime tglmasuk, short stsmasukkeluar, string value)
        {
            try
            {
                using (var service = new FLapBukuRegisterRMServices())
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


        public FLapBukuRegisterRM(ref Panel pnlContent) : base(ref pnlContent)
        {
            try
            {
                this.Stsmasukkeluar = new stsmasukkeluar { stsmasukkeluarid = 1 };

                this.Text = "List Buku Register";

                this.bukuregisterGC.Visible = true;
                defaultsetinglookupeditPelayananmedik();
                this.LoadAllPelayananmedik();
                this.pelayananmedisLookUpEdit.EditValue = this.pelayananmedisLookUpEdit.Properties.GetDataSourceValue(this.pelayananmedisLookUpEdit.Properties.ValueMember, 0);
                this.tglregistrasiDateEdit.EditValue = DateTime.Now.Date;
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nFLapBukuRegisterRM()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                LoadAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(
                    (short)this.pelayananmedisLookUpEdit.EditValue,
                    (DateTime)tglregistrasiDateEdit.EditValue, this.Stsmasukkeluar.stsmasukkeluarid, string.Empty);
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
                LoadAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(
                   (short)this.pelayananmedisLookUpEdit.EditValue ,
                    (DateTime)tglregistrasiDateEdit.EditValue, this.Stsmasukkeluar.stsmasukkeluarid, string.Empty);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntglregistrasiDateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                CustomMessageBox.MessageError(ex.InnerException.Message, "btnPrint_Click()", this.Name, this);
                
            }
        }
    }
}
