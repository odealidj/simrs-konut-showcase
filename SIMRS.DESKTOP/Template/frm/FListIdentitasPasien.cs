using SIMRS.Model.view;
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
    public partial class FListIdentitasPasien : MetroFramework.Forms.MetroForm
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

        protected v_identitaspasien_jk_alamatpasien v_Identitaspasien_Jk_Alamatpasien;

        protected int indexSelectedRow = -1;

        public FListIdentitasPasien()
        {
            InitializeComponent();
        }

        public FListIdentitasPasien(ref Panel _pnlConent)
        {
            InitializeComponent();
            this.pnlContent = _pnlConent;
            

        }

        #region private method control
        protected void ValueDefaultControl()
        {
            KriteriaComboBoxEdit.Properties.Items.AddRange(new string[] { "No.RM atau Nama Pasien", "Tgl. Lahir" });
            KriteriaComboBoxEdit.SelectedIndex = 0;

            CariMTxt.Visible = true;
            CariTglLahirDateEdit.Visible = false;
            CariTglLahirDateEdit.EditValue = null;
            identitaspasienGC.Focus();

            CariMTxt.WaterMark = "Input No.RM atau Nama Pasien untuk melakukan pencarian";
        }

        protected async void LoadVidentitaspasien_jk_alamatpasienByPageIndexAsync(int pageIndex, int pageSize)
        {
            try
            {
                using (var service = new ListIdentitasPasienServices())
                {
                    var result = await service.SelectVidentitaspasien_jk_alamatpasienByPageIndexAsync(pageIndex, pageSize);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        identitaspasienGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync(int pageIndex, int pageSize, string value)
        {
            try
            {
                using (var service = new ListIdentitasPasienServices())
                {
                    var result = await service.SelectVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync (pageIndex, pageSize, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        identitaspasienGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(int pageIndex, int pageSize, string value)
        {
            try
            {
                using (var service = new ListIdentitasPasienServices())
                {
                    var result = await service.SelectVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(pageIndex, pageSize, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        identitaspasienGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void SingleOrDefaultVidentitaspasien_for_listidentitaspasienByNoCMAsync(string nocm, string jknm)
        {
            try
            {
                using (var service = new ListIdentitasPasienServices())
                {
                    var result = await service.FirtOrDefaultVidentitaspasien_for_listidentitaspasienByNoCMAsync(nocm);
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
                            TempatLahirMTxt.Text = data.tempatlahir;
                            KecMTxt.Text = data.kecnm;
                            KelMTxt.Text = data.keldesanm;
                            RTRWMTxt.Text = string.Format("{0}/{1}", data.rtnm, data.rwnm);
                            PendidikanMTxt.Text = data.pendidikannm;
                            PekerjaanMTxt.Text = data.pekerjaannm;
                            GolDarahMTxt.Text = data.goldarahnm;
                            AgamaMTxt.Text = data.agamanm;
                            //SukuMTxt.Text = data.sukunm;
                        }
                        else
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref identitaspasienPanel);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref identitaspasienPanel);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void KriteriaComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (KriteriaComboBoxEdit.SelectedIndex == 0)
            {
                
                CariMTxt.Visible = true;
                CariMTxt.Text = "";
                CariTglLahirDateEdit.Visible = false;
                CariMTxt.Focus();
            }
            else
            {
                CariMTxt.Visible = false;
                CariTglLahirDateEdit.Visible = true;
                CariTglLahirDateEdit.EditValue = null;
                CariTglLahirDateEdit.Focus();
            }
        }

        protected virtual void FListIdentitasPasien_Load(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;

                Helper.CommonFuncControl.ClearControlInWindowsFormPanel (ref identitaspasienPanel);

                ValueDefaultControl();


                //if (identitaspasienGC.DataSource==null)
                LoadVidentitaspasien_jk_alamatpasienByPageIndexAsync(this.PageIndex, this.PageSize);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CariMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref identitaspasienPanel);
                if (string.IsNullOrEmpty(CariMTxt.Text))
                {
                    LoadVidentitaspasien_jk_alamatpasienByPageIndexAsync(this.PageIndex, this.PageSize);
                }
                else
                {
                    LoadVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync(this.PageIndex, this.PageSize, CariMTxt.Text);
                }
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CariTglLahirDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref identitaspasienPanel);
                if (CariTglLahirDateEdit.EditValue==null)
                {
                    LoadVidentitaspasien_jk_alamatpasienByPageIndexAsync(this.PageIndex, this.PageSize);
                }
                else if ((DateTime)CariTglLahirDateEdit.EditValue == DateTime.Now.Date)
                {
                    LoadVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(this.PageIndex, this.PageSize, ((DateTime)CariTglLahirDateEdit.EditValue).ToString("yyyy-MM-dd"));
                }
                else
                {
                    LoadVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync  (this.PageIndex, this.PageSize, ((DateTime)CariTglLahirDateEdit.EditValue).ToString("yyyy-MM-dd"));
                }
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void identitaspasienGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Identitaspasien_Jk_Alamatpasien = identitaspasienGV.GetRow(e.FocusedRowHandle) as v_identitaspasien_jk_alamatpasien;
                if (this.v_Identitaspasien_Jk_Alamatpasien != null)
                {
                    SingleOrDefaultVidentitaspasien_for_listidentitaspasienByNoCMAsync((this.v_Identitaspasien_Jk_Alamatpasien as v_identitaspasien_jk_alamatpasien).nocm, (this.v_Identitaspasien_Jk_Alamatpasien as v_identitaspasien_jk_alamatpasien).jknm);
                    this.indexSelectedRow = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedRow = -1;
                }
                //data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {

        }

        private void identitaspasienGV_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Data tidak ada !!!", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }

        protected virtual void detailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void identitaspasienGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.indexSelectedRow = e.RowHandle;
        }

        protected virtual void identitaspasienGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.indexSelectedRow = e.RowHandle;
        }

        protected virtual void FListIdentitasPasien_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
