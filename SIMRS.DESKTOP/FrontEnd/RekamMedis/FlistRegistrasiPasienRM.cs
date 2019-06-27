using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.RekaMedis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis
{
    public class FlistRegistrasiPasienRM : FListThreeRM
    {
        private int indexSelectedRowFromSender = -1;

        private int indexSelectedRowFromSender2 = -1;

        private const int _maxPageSize = 100;
        private int _pageSize = 25;

        protected int PageIndex { get; set; }

        protected int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < _maxPageSize) ? value : _maxPageSize;
            }
        }

        protected v_registrasi_rekammedis_from_v_registrasiruangrawat v_Registrasi_Rekammedis_From_V_Registrasiruangrawat;

        protected v_registrasiruangrawat v_Registrasiruangrawat;


        #region private methode control

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk );
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, int stsmasukkeluar)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk,stsmasukkeluar);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk,string value)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk,value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, string value, int stsmasukkeluar)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk, value,stsmasukkeluar);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize,value );
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value, int stsmasukkeluarid)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, value,stsmasukkeluarid) ;
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, int stsmasukkeluarid)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, stsmasukkeluarid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync(string nocm, string jknm)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.FirtOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync(nocm);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var data = result.Item1;
                        if (data != null)
                        {
                            if (!string.IsNullOrEmpty(jknm))
                            {
                                if (jknm.Trim().ToUpper() == "L")
                                {

                                    if (System.IO.File.Exists(Helper.CommonFunc.basePathImageIdentitasPasien() + "facl.png"))
                                    {
                                        PicPictureEdit.Image = Image.FromFile(Helper.CommonFunc.basePathImageIdentitasPasien() + "facl.png");
                                    }
                                    else
                                    {
                                        PicPictureEdit.Image = null;
                                    }
                                }
                                else
                                {
                                    if (System.IO.File.Exists(Helper.CommonFunc.basePathImageIdentitasPasien() + "facp.png"))
                                    {
                                        PicPictureEdit.Image = Image.FromFile(Helper.CommonFunc.basePathImageIdentitasPasien() + "facp.png");
                                    }
                                    else
                                    {
                                        PicPictureEdit.Image = null;
                                    }
                                }
                            }
                            else
                            {
                                PicPictureEdit.Image = null;
                            }
                            //MessageBox.Show(Helper.CommonFunc.basePathImageIdentitasPasien());
                            AlamatMTxt.Text = data.alamat;
                            KecMTxt.Text = data.kecnm;
                            KelMTxt.Text = data.keldesanm;
                            RTRWMTxt.Text = string.Format("{0}/{1}", data.rtnm, data.rwnm);
                            PendidikanMTxt.Text = data.pendidikannm;
                            PekerjaanMTxt.Text = data.pekerjaannm;
                            //GolDarahMTxt.Text = data.goldarahnm;
                        }
                        else
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel (ref pnlDetailIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_registrasiruangrawatByRegistrasiidAsync(short registrasiid)
        {
            try
            {
                using (var service = new ListRegistrasiRMServices())
                {
                    var result = await service.SelectAllv_registrasiruangrawatByRegistrasiidAsync(registrasiid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc1.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public FlistRegistrasiPasienRM(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            try
            {
                this.PageIndex = 1;

                this.Text = "List Registrasi Pasien";

                this.colDetail.Visible = false;
                //LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime) tanggaldateEdit.EditValue).Date);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tanggaldateEdit_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;

                if (usetanggalcheckEdit.Checked == true)
                {
                    if (tanggaldateEdit.EditValue == null) return;

                    if (string.IsNullOrEmpty(caridataMTxt.Text))
                    {
                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize,   ((DateTime)tanggaldateEdit.EditValue).Date, 0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, 1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date);
                                break;
                        }
                    }
                    else
                    {
                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, caridataMTxt.Text, 0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, caridataMTxt.Text, 1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, caridataMTxt.Text);
                                break;
                        }
                    }
                }
                else // usetanggal false
                {
                    if (string.IsNullOrEmpty(caridataMTxt.Text))
                    {
                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, 0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize,  1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize);
                                break;
                        }
                    }
                    else
                    {
                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, caridataMTxt.Text,  0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, caridataMTxt.Text, 1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, caridataMTxt.Text);
                                break;
                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\ntanggaldateEdit_DateTimeChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void caridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if  (string.IsNullOrEmpty(caridataMTxt.Text))
                {
                    if (usetanggalcheckEdit.Checked == true)
                    {
                        if (tanggaldateEdit.EditValue == null) return;

                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, 0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, 1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date);
                                break;
                        }
                    }
                    else
                    {
                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize,  0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize,  1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize);
                                break;
                        }
                    }
                }
                else // cari tidak kosong
                {
                    if (usetanggalcheckEdit.Checked == true)
                    {
                        if (tanggaldateEdit.EditValue == null) return;

                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, caridataMTxt.Text,  0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, caridataMTxt.Text, 1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date, caridataMTxt.Text);
                                break;
                        }
                    }
                    else
                    {
                        switch (pelunasancheckEdit.CheckState)
                        {
                            case CheckState.Checked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, caridataMTxt.Text, 0);
                                break;
                            case CheckState.Unchecked:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, caridataMTxt.Text, 1);
                                break;
                            case CheckState.Indeterminate:
                                LoadAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(this.PageIndex, this.PageSize, caridataMTxt.Text);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\ncaridataMTxt_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void usetanggalcheckEdit_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                pelunasancheckEdit.CheckState = CheckState.Indeterminate;

                this.PageIndex = 1;
                if (string.IsNullOrEmpty(caridataMTxt.Text))
                {
                    tanggaldateEdit_DateTimeChanged(null, null);
                }
                else
                {
                    caridataMTxt_TextChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nusetanggalcheckEdit_CheckStateChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void pelunasancheckEdit_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {

                if (pelunasancheckEdit.CheckState == CheckState.Checked)
                {
                    pelunasancheckEdit.Text = "Keluar";
                }
                else if (pelunasancheckEdit.CheckState == CheckState.Unchecked)
                {
                    pelunasancheckEdit.Text = "Masuk";
                }
                else
                {
                    pelunasancheckEdit.Text = "All";
                }



                this.PageIndex = 1;
                if (string.IsNullOrEmpty(caridataMTxt.Text))
                {
                    tanggaldateEdit_DateTimeChanged(null, null);
                }
                else
                {
                    caridataMTxt_TextChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npelunasancheckEdit_CheckStateChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat = gv.GetRow(e.FocusedRowHandle) as v_registrasi_rekammedis_from_v_registrasiruangrawat;
                if (this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat != null)
                {
                    SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync(this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nocm, this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.jknm);
                    lblSelect.Text = this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.noregistrasi + ", "
                        + this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nocm + ", "
                        + this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nama;
                    this.indexSeletedRow = e.FocusedRowHandle;

                    LoadAllv_registrasiruangrawatByRegistrasiidAsync(this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.registrasiid);
                }
                else
                {
                    this.indexSelectedRowFromSender = -1;
                }

                //data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gv_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.indexSelectedRowFromSender = e.RowHandle;
        }

        protected override void gv_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.indexSelectedRowFromSender = e.RowHandle;
        }

        protected override void gv1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Registrasiruangrawat = gv1.GetRow(e.FocusedRowHandle) as v_registrasiruangrawat;
                if (this.v_Registrasiruangrawat != null)
                {
                    
                    //lblSelect.Text = this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.noregistrasi + ", "
                    //    + this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nocm + ", "
                    //    + this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nama;
                    this.indexSelectedRowFromSender2 = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedRowFromSender2 = -1;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\ngv1_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gv1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.indexSelectedRowFromSender2 = e.RowHandle;
        }

        protected override void gv1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.indexSelectedRowFromSender2 = e.RowHandle;
        }

        protected override void detailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListDetailTransaksiPasien myForm = new FListDetailTransaksiPasien(ref this.pnlContent,
                    ref this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndetailrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {

        }

    }
}
