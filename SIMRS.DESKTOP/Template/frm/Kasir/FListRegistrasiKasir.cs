using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Kasir;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Kasir
{
    public partial class FListRegistrasiKasir : MetroFramework.Forms.MetroForm
    {

        protected Panel pnlContent;

        protected int indexSelectedRow = -1;

        protected v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat;


        #region property paging

        private const int _maxPageSize = 100;
        private int _pageSize = 50;

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

        #endregion property paging


        #region private methode
        protected void defaultControl()
        {
            tglmasukMLbl.Visible = false;
            tanggaldateEdit.Visible = false;
            aktifcheckEdit.CheckState = CheckState.Unchecked;

        }




        #endregion private methode

        #region methode control

        protected async void Load50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = await service.Select50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(pageIndex, pageSize, stsmasukkeluarid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc1.DataSource = null;
                        gc.DataSource = result.Item1;
                        gv.ClearSelection();
                        gv.FocusedRowHandle = 0;
                        gv.SelectRow(0);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid, string filter)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = await service.SelectAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(pageIndex, pageSize, stsmasukkeluarid, filter);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc1.DataSource = null;

                        gc.DataSource = result.Item1;

                        gv.ClearSelection();
                        gv.FocusedRowHandle = 0;
                        gv.SelectRow(0);
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
                using (var service = new ListRegistrasiServices())
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


                            AlamatMTxt.Text = data.alamat;
                            KecMTxt.Text = data.kecnm;
                            KelMTxt.Text = data.keldesanm;
                            RTRWMTxt.Text = string.Format("{0}/{1}", data.rtnm, data.rwnm);
                            PekerjaanMTxt.Text = data.pekerjaannm;

                        }
                        else
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
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

        protected async void LoadAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync(int registrasiid)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = await service.SelectAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync (registrasiid);
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

        public FListRegistrasiKasir()
        {
            InitializeComponent();

            
            defaultControl();
            this.PageIndex = 1;
        }

        public FListRegistrasiKasir(ref Panel _pnlContent)
        {
            InitializeComponent();
            //loadKriteriaCari();

            

            caridataMTxt.WaterMark = "Cari data ...";

            this.pnlContent = _pnlContent;

            defaultControl();

            this.PageIndex = 1;
        }

        private void aktifcheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (aktifcheckEdit.CheckState == CheckState.Checked)
            {
                tanggaldateEdit.EditValue = null;
                tglmasukMLbl.Visible =true;
                tanggaldateEdit.Visible = true;
            }
            else
            {
                tglmasukMLbl.Visible = false;
                tanggaldateEdit.Visible = false;
                tanggaldateEdit.EditValue = null;
            }
        }

        private void FListRegistrasiKasir_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FListRegistrasiKasir_Shown(object sender, EventArgs e)
        {

        }

        private void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Pelayananpasien_Distinct_From_Not_Alamat = gv.GetRow(e.FocusedRowHandle) as v_pelayananpasien_distinct_from_not_alamat; 
                if (this.v_Pelayananpasien_Distinct_From_Not_Alamat == null) return;
                    
                SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync(this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm, this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm);
                LoadAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync(this.v_Pelayananpasien_Distinct_From_Not_Alamat.registrasiid);

                lblSelect.Text = string.Format("selected: [ Noregistrasi:{0}, NOCM:{1}, Nama Pasien:{2}, kelamin:{3}, Penjamin:{4} ]", this.v_Pelayananpasien_Distinct_From_Not_Alamat.noregistrasi,
                    this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm,
                    this.v_Pelayananpasien_Distinct_From_Not_Alamat.nama,
                    this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm,
                    this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasiennm);
                this.indexSelectedRow = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                this.indexSelectedRow = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nregistrasiGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gv.DataRowCount == 1)
            {
                this.indexSelectedRow = e.RowHandle;
            }
        }

        private void gv_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gv.DataRowCount == 1)
            {
                this.indexSelectedRow = e.RowHandle;
            }
        }

        protected virtual void caridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void tanggaldateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
