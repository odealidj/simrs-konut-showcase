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
    public partial class FListRegistrasi : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;


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

        protected v_registrasiruangrawat vregistrasiruangrawat;

        protected int indexRow = 0;

        public FListRegistrasi()
        {
            InitializeComponent();
            //loadKriteriaCari();
            ////tglregistrasiDateEdit.EditValue = DateTime.Now;
            CaridataMTxt.WaterMark = "Input No.RM atau Nama Pasien atau Noregistrasi untuk pencarian";
            

        }

        public FListRegistrasi(ref Panel _pnlContent)
        {
            InitializeComponent();
            //loadKriteriaCari();
            
            CaridataMTxt.WaterMark = "Input No.RM atau Nama Pasien atau Noregistrasi untuk pencarian";

            this.pnlContent = _pnlContent;
        }



        #region private method

        

        #endregion

        #region private method control
        private async void LoadVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsregistrasiid, string value)
        {
            try
            {
                using (var service = new ListRegistrasiServices())
                {
                    var result = await service.SelectVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, stsregistrasiid, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        RegistrasiGC.DataSource = result.Item1;
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
                            if (!string.IsNullOrEmpty(jknm))
                            {
                                if (jknm.Trim().ToUpper() == "L")
                                {

                                    if (System.IO.File.Exists(Helper.CommonFunc.basePathImageIdentitasPasien()+ "facl.png"))
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

        protected virtual void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e)
        {

        }

        protected virtual void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Stsregistrasi.stsregistrasiid, CaridataMTxt.Text);

            }
            catch (Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void FListRegistrasi_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1; 
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid, 
                    Helper.Stsregistrasi.stsregistrasiid, string.Empty);
                
            }
            catch(Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void RegistrasiGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.indexRow = e.FocusedRowHandle;
                this.vregistrasiruangrawat = RegistrasiGV.GetRow(e.FocusedRowHandle) as v_registrasiruangrawat;
                if (this.vregistrasiruangrawat != null)
                {
                    lblTitle.Text = string.Format("Selected => [ Noreg: {0}, NoRM: {1}, Nama Pasien: {2}, Kelamin: {3}, Penjamin: {4}, Kelas: {5} ]",
                        this.vregistrasiruangrawat.noregistrasi,
                        this.vregistrasiruangrawat.nocm,
                        this.vregistrasiruangrawat.nama,
                        this.vregistrasiruangrawat.jknm,
                        this.vregistrasiruangrawat.penjaminpasiennm,
                        this.vregistrasiruangrawat.kelasuraian);

                    SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync(this.vregistrasiruangrawat.nocm, this.vregistrasiruangrawat.jknm);
                }
                //data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrasiGV_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

         

            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Data registrasi tidak ada !!!", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }

        protected virtual void stsmasukkeluarruangrawatidrepositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("checked changed");
        }

        protected virtual void stsmasukkeluarruangrawatidrepositoryItemCheckEdit_EditValueChanged(object sender, EventArgs e)
        {
            ////try
            ////{
            ////    if (this.vregistrasiruangrawat != null)
            ////    {
            ////        if (MetroFramework.MetroMessageBox.Show(this, "Apakah pasien dengan No.RM : " + this.vregistrasiruangrawat.nocm+", Nama: "+this.vregistrasiruangrawat.nama+" akan dipulangkan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            ////        {
            ////            if (UpdateStsMasukKeluarRuangRawat(this.vregistrasiruangrawat.registrasiruangrawatid, 0) != 99)
            ////            {
            ////                Helper.CommonFuncControl.ClearControlInMetroTabPage(ref mtpIdentitasPasien);

            ////                this.PageIndex = 1;
            ////                LoadVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
            ////                    Helper.Stsregistrasi.stsregistrasiid, string.Empty);
            ////            }
            ////            else
            ////            {
            ////                this.stsmasukkeluarruangrawatidrepositoryItemCheckEdit.ValueChecked = 1;
            ////            }
            ////        }
            ////        else
            ////        {
            ////            //this.RegistrasiGV.Columns["stsmasukkeluarruangrawatid"].ColumnEdit
            ////            this.stsmasukkeluarruangrawatidrepositoryItemCheckEdit.ValueChecked = 1;
            ////        }
            ////    }

            ////}
            ////catch(Exception ex)
            ////{
            ////    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}
            
        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnAnamnesis_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnPeriksaFisik_Click(object sender, EventArgs e)
        {

        }

        protected virtual void FListRegistrasi_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void btnPengobatan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void controlrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat.nocm != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    //FListDiagnosaPasienPoli myForm = new FListDiagnosaPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);

                    ////FPeriksaFisikPoli myForm = new FPeriksaFisikPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);

                    //myForm.TopLevel = false;
                    //myForm.AutoScroll = true;
                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    //this.pnlContent.Controls.Add(myForm);
                    //myForm.Dock = DockStyle.Fill;
                    //myForm.Show();

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\n"+this.Name +"\ncontrolrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnCaraPulang_Click(object sender, EventArgs e)
        {

        }

        private void filtercheck_CheckedChanged(object sender, EventArgs e)
        {
            if (filtercheck.CheckState==CheckState.Checked)
            {
                tglregistrasiLbl.Enabled = true;
                tglregistrasiDateEdit.Enabled = true;
            }
            else
            {
                tglregistrasiLbl.Enabled = false;
                tglregistrasiDateEdit.Enabled = false;
            }
        }

        protected virtual void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
