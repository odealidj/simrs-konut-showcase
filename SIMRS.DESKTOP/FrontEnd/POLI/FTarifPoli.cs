using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FTarifPoli : FAddTarifPasien
    {
        

        #region private method control
        private async void LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan)
        {
            try
            {
                using (var service = new TarifServices())
                {
                    var result = await service.SelectVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(penjaminid, kelasid, ruangrawatid, jenistarifid,tindakan);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tarifGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int AddPelayananPasien(pelayananpasien obj)
        {
            int result;
            try
            {
                using (var service = new ListTindakanPasienPoliServices())
                {
                    result = service.InsertPelayananPasien(obj);
                   
                }
            }

            catch (Exception ex)
            {
                result = -99;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        //private async void LoadVjenistarifpenjaminByPenjaminIdAsync(short penjaminid)
        //{
        //    try
        //    {
        //        using (var service = new ListTindakanPasienPoliServices())
        //        {
        //            var result = await service.SelectVjenistarifpenjaminByPenjaminIdAsync (penjaminid);
        //            if (result.Item2 != null)
        //            {
        //                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //            else
        //            {
        //                jenistarifLookUpEdit.Properties.DataSource = result.Item1;
        //                //jenistarifCboEdit.DataBindings.Add( tarifGC.DataSource = result.Item1;
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion

        public FTarifPoli() 
        {
        }

        public FTarifPoli(ref short penjaminid,ref short kelasid, ref short ruangrawatid) : base(ref penjaminid,ref kelasid,ref ruangrawatid)
        {
            try
            {
                this.Text = "Tarif Poliklinik";

                jenistarifLookUpEdit.Visible = true;
                tindakanMtxt.Enabled = true;
                totalMtxt.Enabled = true;
                tindakanMtxt.ReadOnly = true;
                totalMtxt.ReadOnly = true;

                tgltindakanDateEdit.ReadOnly = true;

                //MessageBox.Show(jenistarifLookUpEdit.EditValue.ToString());
                //MessageBox.Show(this.penjaminid.ToString());

                //jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FTarifPoli(ref v_registrasiruangrawat Vregistrasiruangrawat) : base(ref Vregistrasiruangrawat)
        {
            try
            {
                this.Text = "Tarif Poliklinik";

                jenistarifLookUpEdit.Visible = true;
                tindakanMtxt.Enabled = true;
                totalMtxt.Enabled = true;
                tindakanMtxt.ReadOnly = true;
                totalMtxt.ReadOnly = true;

                tgltindakanDateEdit.ReadOnly = true;

                //MessageBox.Show(jenistarifLookUpEdit.EditValue.ToString());
                //MessageBox.Show(this.penjaminid.ToString());

                //jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void caridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (jenistarifLookUpEdit.EditValue!=null)
                LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()), caridataMTxt.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ncaridataMTxt_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FTarif_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVjenistarifpenjaminByPenjaminId(this.penjaminid);

                jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);
                LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()), string.Empty);
                jenistarifLookUpEdit.Visible = false;
                jenistarifLbl.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarif_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tarifGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (jmlCboEdit.EditValue == null) jmlCboEdit.EditValue = 1;

                this.Vtarif = tarifGV.GetRow(e.FocusedRowHandle) as v_tarif;
                if (this.Vtarif != null)
                {
                    tindakanMtxt.Text = this.Vtarif.daftartindakannm;
                    this.totalMtxt.Text = string.Format("{0:#,#}", this.Vtarif.biaya * decimal.Parse(jmlCboEdit.EditValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_FocusedRowChanged\n"+this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (jmlCboEdit.EditValue==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jumlah tindakan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dokterLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //                @pelayananpasienid int = NULL,
                //@pelayananpasientgl datetime = NULL,
                //    @pelayananpasienjam datetime = NULL,
                //    @registrasiruangrawatid smallint = NULL,

                //    @dokterid smallint = NULL,
                //    @perawatid smallint = NULL,
                //    @jenistarifid varchar(2) = NULL,
                //    @tarifid int = NULL,
                //    @biaya money = NULL,
                //    @jml smallint = NULL,
                //    @totalbiaya money = NULL,
                //    @loginappid smallint = NULL,

                pelayananpasien p = new pelayananpasien
                {
                    pelayananpasienid = -1,
                    pelayananpasientgl = ((DateTime)this.tgltindakanDateEdit.EditValue).Date,
                    pelayananpasienjam = ((DateTime)this.tgltindakanDateEdit.EditValue),
                    registrasiruangrawatid = this.Vregistrasiruangrawat.registrasiruangrawatid,
                    dokterid = short.Parse(dokterLookUpEdit.EditValue.ToString()),
                    perawatid = short.Parse(perawatLookUpEdit.EditValue.ToString()),
                    jenistarifid = jenistarifLookUpEdit.EditValue.ToString(),
                    tarifid = this.Vtarif.tarifid,
                    biaya = this.Vtarif.biaya,
                    jml = short.Parse(jmlCboEdit.EditValue.ToString()),
                    totalbiaya = decimal.Parse( totalMtxt.Text),
                    loginappid= null

                };

                if (AddPelayananPasien(p) !=-99)
                {

                    if (DelegateMethodPelayananpasien != null)
                        DelegateMethodPelayananpasien();
                    //this.Dispose(true);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Save tarif tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbSave_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
