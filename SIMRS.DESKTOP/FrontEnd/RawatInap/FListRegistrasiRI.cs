using DevExpress.XtraEditors;
using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{

    public class FListRegistrasiRI : ListRegistrasiPoli
    {

        #region private methode

        protected async void LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid,
            short stsmasukkeluarruangrawatid,
            string value, DateTime tglmasuk)
        {
            try
            {
                using (var service = new ListRegistrasiServices())
                {
                    var result = await service.SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, ruangrawatid,
                        stsmasukkeluarruangrawatid,
                        value,
                        tglmasuk);
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

        protected async void LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid,
            short stsmasukkeluarruangrawatid,
            string value)
        {
            try
            {
                using (var service = new ListRegistrasiServices())
                {
                    var result = await service.SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, ruangrawatid,
                        stsmasukkeluarruangrawatid,
                        value);
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

        #endregion

        public FListRegistrasiRI(ref Panel _pnlContent) : base(ref _pnlContent)
        {

            filtercheck.Visible = true;
            filtercheck.CheckState = CheckState.Unchecked;

            tglregistrasiLbl.Enabled = false;
            tglregistrasiDateEdit.Enabled = false;


            //contructor
            this.RegistrasiGC.BeginInit();
            this.RegistrasiGV.BeginInit();

            colthn.Visible = false;
            colbulan.Visible = false;
            colhari.Visible = false;

            colruangrawatnm.Visible = false;
            //colruangrawatnm.VisibleIndex = -1;
            colkelasuraian.Visible = true;
            colkamarnm.Visible = true;
            colruangrawatnm.Visible = true;


            colEdit.Visible = false;
            colDelete.Visible = false;

            coltanggallahir.VisibleIndex = 5;
            colkelasuraian.VisibleIndex = 6;
            colkamarnm.VisibleIndex = 7;
            colpenjaminpasiennm.VisibleIndex = 8;
            colstsmasukkeluarid.VisibleIndex = 9;
            colstsmasukkekuarruangrawatid.VisibleIndex = 10;
            colControl.VisibleIndex = 11;

            colruangrawatnm.VisibleIndex = 12;
            colruangrawatnm.Visible = false;


            this.RegistrasiGV.EndInit();
            this.RegistrasiGC.EndInit();
            this.RegistrasiGC.Refresh();

            this.Text = "List Pasien Masuk";


            this.btnAddRegistrasiPasienBaru.Text = "Add Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Add Tindakan";

            this.colstsmasukkekuarruangrawatid.Caption = "KELUAR ?";
            this.btnCaraPulang.Visible = false;

            this.StsmasukKeluarruangrawatid = 1;
            tglregistrasiLbl.Text = "Tgl.Masuk";
            tglregistrasiDateEdit.EditValue = null;



        }

        public FListRegistrasiRI(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) : base(ref _pnlContent)
        {
            //this.pnlContent = panel;
            filtercheck.Visible = true;
            filtercheck.CheckState = CheckState.Unchecked;

            tglregistrasiLbl.Enabled = false;
            tglregistrasiDateEdit.Enabled = false;


            //contructor
            this.RegistrasiGC.BeginInit();
            this.RegistrasiGV.BeginInit();

            colthn.Visible = false;
            colbulan.Visible = false;
            colhari.Visible = false;

            colruangrawatnm.Visible = false;
            //colruangrawatnm.VisibleIndex = -1;
            colkelasuraian.Visible = true;
            colkamarnm.Visible = true;
            colruangrawatnm.Visible = true;


            colEdit.Visible = false;
            colDelete.Visible = false;

            coltanggallahir.VisibleIndex = 5;
            colkelasuraian.VisibleIndex = 6;
            colkamarnm.VisibleIndex = 7;
            colpenjaminpasiennm.VisibleIndex = 8;
            colstsmasukkeluarid.VisibleIndex = 9;
            colstsmasukkekuarruangrawatid.VisibleIndex = 10;
            colControl.VisibleIndex = 11;

            colruangrawatnm.VisibleIndex = 12;
            colruangrawatnm.Visible = false;


            this.RegistrasiGV.EndInit();
            this.RegistrasiGC.EndInit();
            this.RegistrasiGC.Refresh();

            this.Text = "List Pasien Masuk";


            this.btnAddRegistrasiPasienBaru.Text = "Add Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Add Tindakan";

            this.colstsmasukkekuarruangrawatid.Caption = "KELUAR ?";
            this.btnCaraPulang.Visible = false;

            this.StsmasukKeluarruangrawatid = 1;
            tglregistrasiLbl.Text = "Tgl.Masuk";

            this.vregistrasiruangrawat = v_registrasiruangrawat;
            //this.indexRow = indexRow;
            this.indexFocusedRow = indexRow;
            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;


        }

        protected override void FListRegistrasi_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Ruangrawat.ruangrawatid,
                    this.StsmasukKeluarruangrawatid,
                    string.Empty);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nFListRegistrasi_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListRegistrasi_Shown(object sender, EventArgs e)
        {
            RegistrasiGV.ClearSelection();
            //RegistrasiGV.foc  = this.vregistrasiruangrawat;
            RegistrasiGV.FocusedRowHandle = this.indexFocusedRow;
            //RegistrasiGV.OptionsSelection.MultiSelect = true;
            RegistrasiGV.SelectRow(this.indexFocusedRow);
        }
        protected override void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               

                    Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                    this.PageIndex = 1;
                    if (tglregistrasiDateEdit.EditValue != null)
                    {
                        if (filtercheck.CheckState == CheckState.Checked)
                        {
                            LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                            Helper.Ruangrawat.ruangrawatid,
                            this.StsmasukKeluarruangrawatid,
                            string.Empty,
                            ((DateTime)tglregistrasiDateEdit.EditValue).Date);
                        }
                    }
                    ////else
                    ////{
                    ////    LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    ////        Helper.Ruangrawat.ruangrawatid,
                    ////        this.StsmasukKeluarruangrawatid,
                    ////        CaridataMTxt.Text);
                    ////}
                

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntglregistrasiDateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Ruangrawat.ruangrawatid,
                    this.StsmasukKeluarruangrawatid,
                    CaridataMTxt.Text);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nCaridataMTxt_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void stsmasukkeluarruangrawatidrepositoryItemCheckEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah pasien dengan NoRegistrasi: " + this.vregistrasiruangrawat.noregistrasi + ", No.RM : " + this.vregistrasiruangrawat.nocm + ", Nama: "
                        + this.vregistrasiruangrawat.nama + " telah selesai mendapatkan perawatan?\nPeriksa kembali Diagnosa, Tindakan, Pemeriksaan Fisik, Anamnesa, dan Pengobatan pasien, apakah sudah diisi?" +
                        "\n\n Jika pilihan=[Yes]; Diganosa, Tindakan, Pemeriksaan Fisik, Anamnesa tidak dapat diisi kembali. Kemudian data akan di tampilkan pada form 'LIST PASIEN KELUAR'" +
                        "\n Jika pilihan=[No]; Akan kembali ke tampilan sebelumnya", "Peringatan [Penting untuk dibaca]", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        if (UpdateStsMasukKeluarRuangRawat(this.vregistrasiruangrawat.registrasiruangrawatid, 0,DateTime.Now.Date,DateTime.Now) != -99)
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                            this.PageIndex = 1;

                            if ((tglregistrasiDateEdit.Enabled == true) && (tglregistrasiDateEdit.EditValue != null))
                            {
                                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                                    Helper.Ruangrawat.ruangrawatid,
                                    this.StsmasukKeluarruangrawatid,
                                    CaridataMTxt.Text, ((DateTime)tglregistrasiDateEdit.EditValue).Date);
                            }
                            else
                            {
                                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                                    Helper.Ruangrawat.ruangrawatid,
                                    this.StsmasukKeluarruangrawatid,
                                    CaridataMTxt.Text);
                            }
                        }
                        else
                        {
                            this.stsmasukkeluarruangrawatidrepositoryItemCheckEdit.ValueChecked = 1;
                        }
                    }
                    else
                    {
                        //this.RegistrasiGV.Columns["stsmasukkeluarruangrawatid"].ColumnEdit
                        this.stsmasukkeluarruangrawatidrepositoryItemCheckEdit.ValueChecked = 1;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void controlrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    FListRiwayatPenyakitPasienRI myForm = new FListRiwayatPenyakitPasienRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncontrolrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e) //tindakan
        {
            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat);
                FListTindakanPasienRI myForm = new FListTindakanPasienRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }

        }

        protected override void btnAnamnesis_Click(object sender, EventArgs e) //anamnesa
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FAnamnesaPasienRI myForm = new FAnamnesaPasienRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAnamnesis_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnPeriksaFisik_Click(object sender, EventArgs e) // Periksa Fisik
        {
            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FPeriksaFisikRI myForm = new FPeriksaFisikRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
        }

        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e) // diagnosa
        {
            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListDiagnosaPasienRI myForm = new FListDiagnosaPasienRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);

                //FPeriksaFisikPoli myForm = new FPeriksaFisikPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
        }

        protected override void btnPengobatan_Click(object sender, EventArgs e) //Pengobatan


        {
            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FPengobatanPasienRI myForm = new FPengobatanPasienRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
        }
    }
}
