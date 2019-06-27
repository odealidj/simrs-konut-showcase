using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.LAB
{
    public class FListCariPasienLAB : FListRegistrasiLAB
    {


        protected v_registrasiruangrawat_notin_registrasipenunjang dataDistinctRuangRawat;
        protected v_registrasiruangrawat_notin_registrasipenunjang dataRuangRawatDeatil;

        #region private method control

        protected async void LoadVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short? stsregistrasiid, string value)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(pageIndex, pageSize, stsregistrasiid.Value, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        registrasiGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(int pageIndex, int pageSize, short pelayananmedikpenunjangid, short stsmasukkeluarid, string value)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(pageIndex, pageSize,pelayananmedikpenunjangid,stsmasukkeluarid, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        registrasiGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(short registrasiid,short pelayananmedikpenunjangid)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(registrasiid, pelayananmedikpenunjangid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        registrasidetailGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikpenunjangid)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(registrasiid, pelayananmedikpenunjangid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        registrasidetailGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region private
        protected string AddRegistrasiPenunjang(registrasipenunjang _registrasipenunjang)
        {
            using (var service = new ListRegistrasiPenunjangServices())
            {
                var result = service.InsertRegistrasiPenunjang(_registrasipenunjang);
                if (!string.IsNullOrEmpty(result))
                {
                    MetroFramework.MetroMessageBox.Show(this, result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                return result;

            }
        }
        #endregion

        public FListCariPasienLAB(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            Helper.Stsregistrasi.stsregistrasiid = 1;


            this.Text = "List pencarian data registrasi pasien";
            this.coltglregistrasipenunjang.Visible = false;
            btnAdd.Visible = true;
            btnAdd.Text = "Next";
            this.bTindakan.Visible = false;
            

            //btnAdd.Text = "Next";

            this.tglregistrasiDateEdit.Enabled = false;
            this.coljammasuk.Visible = false;
            this.colTindakan.Visible = false;
            this.colDelete.Visible = false;
            ////this.colTindakan.OptionsColumn.ShowCaption = false;
            ////this.registerRepositoryItemButtonEdit.Buttons[0].ImageOptions.Image = null;
            ////this.registerRepositoryItemButtonEdit.Buttons[0].Caption = "Register";

            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                //LoadVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                  //  Helper.Stsregistrasi.stsregistrasiid, string.Empty);

                LoadDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Stsregistrasi.stsregistrasiid, string.Empty);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void registrasiGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                
                this.dataDistinctRuangRawat = registrasiGV.GetRow(e.FocusedRowHandle) as v_registrasiruangrawat_notin_registrasipenunjang;
                if (this.dataDistinctRuangRawat != null)
                {

                    lblTitle.Text = "Selected : [Tgl.Masuk: " + this.dataDistinctRuangRawat.tglmasuk.Value.ToString("dd-MM-yyyy")
                       + ", Noregistrasi: " + this.dataDistinctRuangRawat.noregistrasi
                       + ", No.RM: " + this.dataDistinctRuangRawat.nocm
                       + ", Nama: " + this.dataDistinctRuangRawat.nama
                       + ", Kelamin: " + this.dataDistinctRuangRawat.jknm
                       + ", Penjamin: " + this.dataDistinctRuangRawat.penjaminpasiennm
                       + "]";

                    //LoadVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(data.registrasiid,Helper.Pelayananmedik.pelayananmedikid);
                    LoadVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(this.dataDistinctRuangRawat.registrasiid, Helper.Pelayananmedik.pelayananmedikid);
                    SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync((this.dataDistinctRuangRawat as v_registrasiruangrawat_notin_registrasipenunjang).nocm, (this.dataDistinctRuangRawat as v_registrasiruangrawat_notin_registrasipenunjang).jknm);
                    
                    this.indexSelectedRegistrasi = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedRegistrasi = -1;
                }

                this.dataRuangRawatDeatil = null;
            }
            catch(Exception ex)
            {
                this.indexSelectedRegistrasi = -1;
                this.dataRuangRawatDeatil = null;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registrasidetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.dataRuangRawatDeatil = registrasidetailGV.GetRow(e.FocusedRowHandle) as v_registrasiruangrawat_notin_registrasipenunjang;
                if (this.dataRuangRawatDeatil != null)
                {
                   
                    this.indexSelectedDetailRegistrasi = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedDetailRegistrasi = -1;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedDetailRegistrasi = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registrasidetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.dataRuangRawatDeatil = registrasidetailGV.GetRow(e.RowHandle) as v_registrasiruangrawat_notin_registrasipenunjang;
                if (this.dataRuangRawatDeatil != null)
                {
                    
                    this.indexSelectedDetailRegistrasi = e.RowHandle;
                }
                else
                {
                    this.indexSelectedDetailRegistrasi = -1;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedDetailRegistrasi = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registrasidetailGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.dataRuangRawatDeatil = registrasidetailGV.GetRow(e.RowHandle) as v_registrasiruangrawat_notin_registrasipenunjang;
                if (this.dataRuangRawatDeatil != null)
                {

                    this.indexSelectedDetailRegistrasi = e.RowHandle;
                }
                else
                {
                    this.indexSelectedDetailRegistrasi = -1;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedDetailRegistrasi = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registerRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////try
            ////{
            ////    //v_distinctcaripasienpenunjang_not_in_registrasipenunjang dataPasien = (registrasiGV.GetRow(registrasiGV.GetSelectedRows()[0]) as v_distinctcaripasienpenunjang_not_in_registrasipenunjang);
            ////    ////v_distinctcaripasienpenunjang_not_in_registrasipenunjang dataPasien = registrasiGV.GetRow(this.indexSelectedRegistrasi) as v_distinctcaripasienpenunjang_not_in_registrasipenunjang;
            ////    //v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang dataRuangRawat =  (registrasidetailGV.GetRow(registrasidetailGV.GetSelectedRows()[0]) as v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang);
            ////    ////v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang dataRuangRawat = registrasidetailGV.GetRow(this.indexSelectedDetailRegistrasi) as v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang;
            ////    if (this.dataDistinctRuangRawat == null)
            ////    {
            ////        MetroFramework.MetroMessageBox.Show(this, "Silahkan klik tabel untuk memilih data pasien", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ////        return;
            ////    }

            ////    if (this.dataRuangRawatDeatil == null)
            ////    {
            ////        MetroFramework.MetroMessageBox.Show(this, "Silahkan klik tabel untuk memilih data ruang rawat", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ////        return;
            ////    }

            ////    if (MetroFramework.MetroMessageBox.Show(this, string.Format("{0} No.RM: {1}, Nama: {2}, Ruang Perawatan: {3}, Kelas: {4} akan diregistrasikan?","Apakah data pasien",this.dataDistinctRuangRawat.nocm, this.dataDistinctRuangRawat.nama,this.dataRuangRawatDeatil.ruangrawatnm, this.dataRuangRawatDeatil.kelasuraian), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            ////    {


            ////        registrasipenunjang penunjang = new registrasipenunjang
            ////        {
            ////            registrasipenunjangid = -1,
            ////            tglregistrasi= DateTime.Now,
            ////            registrasiruangrawatid = this.dataRuangRawatDeatil.registrasiruangrawatid,
            ////            ruangrawatid = Helper.Ruangrawat.ruangrawatid, // dataRuangRawat.ruangrawatid,
            ////            kelasid = this.dataRuangRawatDeatil.kelasid,
            ////            loginappid = (short)(-1),
            ////            created_date = DateTime.Now,
            ////            updated_date = null,
            ////            registrasipenunjangsts = true

            ////        };

            ////        var data = AddRegistrasiPenunjang(penunjang);
            ////        if (string.IsNullOrEmpty(data))
            ////        {
            ////            //registrasiGV.GetDataRow((registrasiGV.)

            ////            //LoadVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(this.dataDistinctRuangRawat.registrasiid,Helper.Pelayananmedik.pelayananmedikid);
            ////            //if (registrasidetailGV.RowCount == 0)
            ////            //{
            ////                //LoadVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
            ////                //    Helper.Stsregistrasi.stsregistrasiid, string.Empty);
            ////                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            ////                this.pnlContent.Controls.Clear();
            ////                //fDashboard myForm = new fDashboard();
            ////                FListRegistrasiLAB myForm = new FListRegistrasiLAB(ref this.pnlContent);
            ////                myForm.TopLevel = false;
            ////                myForm.AutoScroll = true;
            ////                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            ////                this.pnlContent.Controls.Add(myForm);
            ////                myForm.Dock = DockStyle.Fill;
            ////                myForm.Show();
            ////            //}
            ////        }
            ////    }
            ////}
            ////catch
            ////{

            ////}
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataRuangRawatDeatil == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih ruang perawatan pasien yang akan didaftarkan\n"+
                        "dengan cara klik pada tabel ruang perawatan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FKonfirmasiRegistrasiPenunjangLAB myForm = new FKonfirmasiRegistrasiPenunjangLAB(ref this.pnlContent,ref this.dataRuangRawatDeatil);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                //LoadVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                //  Helper.Stsregistrasi.stsregistrasiid, string.Empty);

                LoadDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Stsregistrasi.stsregistrasiid, CaridataMTxt.Text);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiLAB myForm = new FListRegistrasiLAB(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
