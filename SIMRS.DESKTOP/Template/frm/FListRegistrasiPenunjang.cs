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

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class FListRegistrasiPenunjang : MetroFramework.Forms.MetroForm
    {
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

        protected Panel pnlContent;

        #region private method control
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
                            GolDarahMTxt.Text = data.goldarahnm;
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

        #endregion

        //public FListRegistrasiPenunjang()
        //{
        //    InitializeComponent();
        //    this.Text = "List Registrasi Laboratorium";
        //    this.CaridataMTxt.WaterMark = "...input No.RM atau Nama Pasien atau Noregistrasi untuk melakukan pencarian";
        //    btnAdd.Text = "Add";
        //}

        public FListRegistrasiPenunjang(ref Panel _pnlContent)
        {
            InitializeComponent();

            this.pnlContent = _pnlContent;
            this.Text = "List Registrasi Laboratorium";
            this.CaridataMTxt.WaterMark = "Pencarian data pasien ...";
            btnAdd.Text = "Add";
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void registrasiGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void registerRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void bTindakan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void registrasidetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void registrasidetailGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void registrasiGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void registrasiGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void FListRegistrasiPenunjang_Shown(object sender, EventArgs e)
        {
            
        }

        protected virtual void registrasidetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
