using SIMRS.DESKTOP.Template.frm;
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
    public class FListRegistrasiLAB : FListRegistrasiPenunjang
    {
        


        #region private method control
        protected async void LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, string value)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(pageIndex, pageSize, pelayananmedikid, stsregistrasiid.Value, value);
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

        protected async void LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, DateTime tglmasuk)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(pageIndex, pageSize, pelayananmedikid, stsregistrasiid.Value, tglmasuk);
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

        protected async void LoadVregistrasiruangrawatpenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikid)
        {
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    var result = await service.SelectVregistrasiruangrawatpenunjangByRegistrasiIdAsync(registrasiid, pelayananmedikid);
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

        protected string RemoveRegistrasiPenunjang(registrasipenunjang obj)
        {
            var result = string.Empty;
            try
            {
                using (var service = new ListRegistrasiPenunjangServices())
                {
                    result = service.DeleteRegistrasiPenunjang(obj);
                    if (!string.IsNullOrEmpty( result))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                   
                }
            }

            catch (Exception ex)
            {
                result = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }


        #endregion

        #region protected

        protected int indexSelectedRegistrasi = 0;
        protected int indexSelectedDetailRegistrasi = 0;

        protected int indexSelectedRegistrasiFromSender = 0;
        protected int indexSelectedDetailRegistrasiFromSender = 0;

        protected v_distinctpasienpenunjang v_Distinctpasienpenunjang;
        protected v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang;
        protected v_registrasiruangrawat v_Registrasiruangrawat;

        #endregion




        public FListRegistrasiLAB(ref Panel _pnlContent) : base (ref _pnlContent)
        {
            Helper.Stsregistrasi.stsregistrasiid = 1;


            this.Text = "List Pasien Laboratorium";
            this.coltglregistrasipenunjang.Visible = true;
            btnAdd.Text = "Tambah Pasien";

            this.bTindakan.Visible = false;

            this.registerRepositoryItemButtonEdit.Buttons[0].Caption = "Tindakan";

            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                ////LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                ////    Helper.Pelayananmedik.pelayananmedikid, Helper.Stsregistrasi.stsregistrasiid, string.Empty);

                tglregistrasiDateEdit.EditValue = DateTime.Now.Date;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public FListRegistrasiLAB(ref Panel _pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, int indexSelectedRegistrasi) : base(ref _pnlContent)
        {

            //Contructor Back From Tindakan LAB

            Helper.Stsregistrasi.stsregistrasiid = 1;


            this.Text = "List Pasien Laboratorium";
            this.coltglregistrasipenunjang.Visible = true;
            btnAdd.Text = "Tambah Pasien";

            this.bTindakan.Visible = false;

            this.registerRepositoryItemButtonEdit.Buttons[0].Caption = "Tindakan";


            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                ////LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                ////    Helper.Pelayananmedik.pelayananmedikid, Helper.Stsregistrasi.stsregistrasiid, string.Empty);

                this.v_Registrasiruangrawat_Penunjang = v_Registrasiruangrawat_Penunjang;
                //this.indexRow = indexRow;
                this.indexSelectedDetailRegistrasiFromSender = indexSelectedRegistrasi;
                tglregistrasiDateEdit.EditValue = this.v_Registrasiruangrawat_Penunjang.tglmasuk.Value.Date;

                registrasiGV.ClearSelection();
                registrasiGV.FocusedRowHandle = this.indexSelectedDetailRegistrasiFromSender;
                registrasiGV.SelectRow(this.indexSelectedDetailRegistrasiFromSender);

                registrasidetailGV.ClearSelection();
                registrasidetailGV.FocusedRowHandle = 0;
                registrasidetailGV.SelectRow(0);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        protected override void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (tglregistrasiDateEdit.EditValue!=null)
                {
                    LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                    Helper.Pelayananmedik.pelayananmedikid, Helper.Stsregistrasi.stsregistrasiid,
                    ((DateTime)tglregistrasiDateEdit.EditValue).Date);

                    registrasiGV.ClearSelection();
                    registrasiGV.FocusedRowHandle = 0;
                    registrasiGV.SelectRow(0);

                    registrasidetailGV.ClearSelection();
                    registrasidetailGV.FocusedRowHandle = 0;
                    registrasidetailGV.SelectRow(0);
                    //LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                    //Helper.Pelayananmedik.pelayananmedikid, Helper.Stsregistrasi.stsregistrasiid,
                    //string.Empty);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\ntglregistrasiDateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListRegistrasiPenunjang_Shown(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListRegistrasiPenunjang_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registrasiGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Distinctpasienpenunjang = registrasiGV.GetRow(e.FocusedRowHandle) as v_distinctpasienpenunjang;
                if (this.v_Distinctpasienpenunjang != null)
                {
                    //if (e.FocusedRowHandle==-1) registrasiGV.FocusedRowHandle = 0;
                    lblTitle.Text = "Selected : [Tgl.Masuk: " + this.v_Distinctpasienpenunjang.tglmasuk.Value.ToString("dd-MM-yyyy")
                        + ", Noregistrasi: " + this.v_Distinctpasienpenunjang.noregistrasi
                        + ", No.RM: " + this.v_Distinctpasienpenunjang.nocm
                        + ", Nama: " + this.v_Distinctpasienpenunjang.nama
                        + ", Kelamin: " + this.v_Distinctpasienpenunjang.jknm
                        + ", Penjamin: " + this.v_Distinctpasienpenunjang.penjaminpasiennm
                        + "]";

                    LoadVregistrasiruangrawatpenunjangByRegistrasiIdAsync(this.v_Distinctpasienpenunjang.registrasiid, Helper.Pelayananmedik.pelayananmedikid);
                    SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync((this.v_Distinctpasienpenunjang as v_distinctpasienpenunjang).nocm, (this.v_Distinctpasienpenunjang as v_distinctpasienpenunjang).jknm);

                    
                    ////this.indexSelectedRegistrasi = e.FocusedRowHandle;
                    ////if (this.indexSelectedRegistrasi == -1) this.indexSelectedRegistrasi = 0;
                }
                else
                {
                    this.indexSelectedRegistrasi = -1;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nregistrasiGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                    Helper.Pelayananmedik.pelayananmedikid, Helper.Stsregistrasi.stsregistrasiid, CaridataMTxt.Text);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListCariPasienLAB myForm = new FListCariPasienLAB(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void bTindakan_Click(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbTindakan_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void registerRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if ((this.v_Distinctpasienpenunjang == null) || (this.v_Registrasiruangrawat_Penunjang == null)) return;


                ////this.v_Registrasiruangrawat = new v_registrasiruangrawat
                ////{
                ////    registrasiid = this.v_Registrasiruangrawat_Penunjang.registrasiid,
                ////    tglmasuk = this.v_Registrasiruangrawat_Penunjang.tglmasuk,
                ////    jammasuk = this.v_Registrasiruangrawat_Penunjang.jammasuk,
                ////    noregistrasi = this.v_Registrasiruangrawat_Penunjang.noregistrasi,
                ////    nocm = this.v_Registrasiruangrawat_Penunjang.nocm,
                ////    nama = this.v_Registrasiruangrawat_Penunjang.nama,
                ////    jknm = this.v_Registrasiruangrawat_Penunjang.jknm,
                ////    tanggallahir = this.v_Registrasiruangrawat_Penunjang.tanggallahir,
                ////    thn = this.v_Registrasiruangrawat_Penunjang.thn,
                ////    bulan = this.v_Registrasiruangrawat_Penunjang.bulan,
                ////    hari = this.v_Registrasiruangrawat_Penunjang.hari,
                ////    ruangrawatid = this.v_Registrasiruangrawat_Penunjang.ruangrawatid,
                ////    ruangrawatnm = this.v_Registrasiruangrawat_Penunjang.ruangrawatnm,
                ////    penjaminpasienid = this.v_Registrasiruangrawat_Penunjang.penjaminpasienid,
                ////    penjaminpasiennm = this.v_Registrasiruangrawat_Penunjang.penjaminpasiennm,
                ////    prosedurmasukid = this.v_Registrasiruangrawat_Penunjang.prosedurmasukid,
                ////    prosedurmasuknm = this.v_Registrasiruangrawat_Penunjang.prosedurmasuknm,
                ////    pelayananmedikid = this.v_Registrasiruangrawat_Penunjang.pelayananmedikid,
                ////    pelayananmediknm = this.v_Registrasiruangrawat_Penunjang.pelayananmediknm,
                ////    registrasiruangrawatid = this.v_Registrasiruangrawat_Penunjang.registrasiruangrawatid,
                ////    tglmasukruangan = this.v_Registrasiruangrawat_Penunjang.tglmasukruangan,
                ////    kelasid = this.v_Registrasiruangrawat_Penunjang.kelasid,
                ////    kelasnm = this.v_Registrasiruangrawat_Penunjang.kelasnm,
                ////    kelasuraian = this.v_Registrasiruangrawat_Penunjang.kelasuraian,
                ////    kamarid = this.v_Registrasiruangrawat_Penunjang.kamarid,
                ////    kamarnm = this.v_Registrasiruangrawat_Penunjang.kamarnm,
                ////    tempattidurid = this.v_Registrasiruangrawat_Penunjang.tempattidurid,
                ////    tempattidurnm = this.v_Registrasiruangrawat_Penunjang.tempattidurnm,
                ////    stsregistrasiid = this.v_Registrasiruangrawat_Penunjang.stsregistrasiid,
                ////    stsregistrasinm = this.v_Registrasiruangrawat_Penunjang.stsregistrasinm,
                ////    stsmasukkeluarid = this.v_Registrasiruangrawat_Penunjang.stsmasukkeluarid,
                ////    stsmasukkeluarnm = this.v_Registrasiruangrawat_Penunjang.stsmasukkeluarnm,
                ////    stsmasukkeluarruangrawatid = this.v_Registrasiruangrawat_Penunjang.stsmasukkeluarruangrawatid,
                ////    stsmasukkeluarruangrawatnm = this.v_Registrasiruangrawat_Penunjang.stsmasukkeluarruangrawatnm

                ////};
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();

                FTindakanPasienLAB myForm = new FTindakanPasienLAB(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref indexSelectedRegistrasi);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nregisterRepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Registrasiruangrawat_Penunjang != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this,
                        string.Format("Apakah data registrasi pasien dengan NoRM: {0}, Nama: {1}, Noregistrasi: {2}, Ruang Perawatan: {3},Kelas: {4},Tgl.Masuk: {5} berikut akan dihapus?" +
                        "\n[Yes] untuk melajutkan proses" +
                        "\n[No] untuk membatalkan",
                        this.v_Registrasiruangrawat_Penunjang.nocm,
                        this.v_Registrasiruangrawat_Penunjang.nama,
                        this.v_Registrasiruangrawat_Penunjang.noregistrasi,
                        this.v_Registrasiruangrawat_Penunjang.ruangrawatnm,
                        this.v_Registrasiruangrawat_Penunjang.kelasuraian,
                        this.v_Registrasiruangrawat_Penunjang.tglmasuk.Value.ToString("dd-MM-yyyy")),
                        "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    

                    registrasipenunjang r = new registrasipenunjang
                    {
                        registrasipenunjangid = this.v_Registrasiruangrawat_Penunjang.registrasipenunjangid
                    };

                    if (string.IsNullOrEmpty(RemoveRegistrasiPenunjang(r)))
                    {
                        tglregistrasiDateEdit_EditValueChanged(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nregisterRepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected override void registrasidetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Registrasiruangrawat_Penunjang= registrasidetailGV.GetRow(e.FocusedRowHandle) as v_registrasiruangrawat_penunjang;
                if (this.v_Registrasiruangrawat_Penunjang != null)
                {
                    //if (e.FocusedRowHandle == -1) registrasidetailGV.FocusedRowHandle = 0;
                    this.indexSelectedDetailRegistrasi = e.FocusedRowHandle;
                    ////if (this.indexSelectedDetailRegistrasi == -1) this.indexSelectedDetailRegistrasi = 0;
                }
                else
                {
                    this.indexSelectedDetailRegistrasi = -1;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nregistrasiGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registrasidetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected override void registrasidetailGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected override void registrasiGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected override void registrasiGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }



        private void InitializeComponent()
        {
            this.pnlDetailIdentitasPasien.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.PicPictureEdit.Properties)).BeginInit();
            this.pnlDetailIdentitasPasienHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_distinctpasienpenunjangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ruangrawatpasienpenunjangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglreglabRepositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglreglabRepositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // CaridataMTxt
            // 
            // 
            // 
            // 
            this.CaridataMTxt.CustomButton.Image = null;
            this.CaridataMTxt.CustomButton.Location = new System.Drawing.Point(649, 1);
            this.CaridataMTxt.CustomButton.Name = "";
            this.CaridataMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CaridataMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CaridataMTxt.CustomButton.TabIndex = 1;
            this.CaridataMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CaridataMTxt.CustomButton.UseSelectable = true;
            this.CaridataMTxt.CustomButton.Visible = false;
            this.CaridataMTxt.Lines = new string[0];

            // 
            // PicPictureEdit
            // 
            // 
            // GolDarahMTxt
            // 
            // 
            // 
            // 
            this.GolDarahMTxt.CustomButton.Image = null;
            this.GolDarahMTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.GolDarahMTxt.CustomButton.Name = "";
            this.GolDarahMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GolDarahMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GolDarahMTxt.CustomButton.TabIndex = 1;
            this.GolDarahMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GolDarahMTxt.CustomButton.UseSelectable = true;
            this.GolDarahMTxt.CustomButton.Visible = false;
            this.GolDarahMTxt.Lines = new string[0];
            // 
            // AlamatMTxt
            // 
            // 
            // 
            // 
            this.AlamatMTxt.CustomButton.Image = null;
            this.AlamatMTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.AlamatMTxt.CustomButton.Name = "";
            this.AlamatMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AlamatMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlamatMTxt.CustomButton.TabIndex = 1;
            this.AlamatMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AlamatMTxt.CustomButton.UseSelectable = true;
            this.AlamatMTxt.CustomButton.Visible = false;
            this.AlamatMTxt.Lines = new string[0];
            // 
            // PekerjaanMTxt
            // 
            // 
            // 
            // 
            this.PekerjaanMTxt.CustomButton.Image = null;
            this.PekerjaanMTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.PekerjaanMTxt.CustomButton.Name = "";
            this.PekerjaanMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PekerjaanMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PekerjaanMTxt.CustomButton.TabIndex = 1;
            this.PekerjaanMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PekerjaanMTxt.CustomButton.UseSelectable = true;
            this.PekerjaanMTxt.CustomButton.Visible = false;
            this.PekerjaanMTxt.Lines = new string[0];
            // 

            // 
            // RTRWMTxt
            // 
            // 
            // 
            // 
            this.RTRWMTxt.CustomButton.Image = null;
            this.RTRWMTxt.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.RTRWMTxt.CustomButton.Name = "";
            this.RTRWMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RTRWMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RTRWMTxt.CustomButton.TabIndex = 1;
            this.RTRWMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RTRWMTxt.CustomButton.UseSelectable = true;
            this.RTRWMTxt.CustomButton.Visible = false;
            this.RTRWMTxt.Lines = new string[0];
            // 
            // KelMTxt
            // 
            // 
            // 
            // 
            this.KelMTxt.CustomButton.Image = null;
            this.KelMTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.KelMTxt.CustomButton.Name = "";
            this.KelMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KelMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KelMTxt.CustomButton.TabIndex = 1;
            this.KelMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KelMTxt.CustomButton.UseSelectable = true;
            this.KelMTxt.CustomButton.Visible = false;
            this.KelMTxt.Lines = new string[0];
            // 
            // KecMTxt
            // 
            // 
            // 
            // 
            this.KecMTxt.CustomButton.Image = null;
            this.KecMTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.KecMTxt.CustomButton.Name = "";
            this.KecMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KecMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KecMTxt.CustomButton.TabIndex = 1;
            this.KecMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KecMTxt.CustomButton.UseSelectable = true;
            this.KecMTxt.CustomButton.Visible = false;
            this.KecMTxt.Lines = new string[0];
            // 
            // icdxindoDataNavigator
            // 
            this.icdxindoDataNavigator.Buttons.Append.Visible = false;
            this.icdxindoDataNavigator.Buttons.CancelEdit.Visible = false;
            this.icdxindoDataNavigator.Buttons.EndEdit.Visible = false;
            this.icdxindoDataNavigator.Buttons.First.Visible = false;
            this.icdxindoDataNavigator.Buttons.Last.Visible = false;
            this.icdxindoDataNavigator.Buttons.NextPage.Visible = false;
            this.icdxindoDataNavigator.Buttons.PrevPage.Visible = false;
            this.icdxindoDataNavigator.Buttons.Remove.Visible = false;
            // 
            // tglreglabRepositoryItemDateEdit
            // 
            // 
            // FListRegistrasiLAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Name = "FListRegistrasiLAB";
            this.pnlDetailIdentitasPasien.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.PicPictureEdit.Properties)).EndInit();
            this.pnlDetailIdentitasPasienHeader.ResumeLayout(false);
            this.pnlDetailIdentitasPasienHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_distinctpasienpenunjangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ruangrawatpasienpenunjangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglreglabRepositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglreglabRepositoryItemDateEdit)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
