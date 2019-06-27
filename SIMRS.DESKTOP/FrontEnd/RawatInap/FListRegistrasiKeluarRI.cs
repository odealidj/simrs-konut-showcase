using DevExpress.XtraEditors;
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
    public class FListRegistrasiKeluarRI : FListRegistrasiRI
    {


        #region private control methode
        protected async void LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid,
            short stsmasukkeluarruangrawatid,
            string value, DateTime tglkeluarruangan)
        {
            try
            {
                using (var service = new ListRegistrasiServices())
                {
                    var result = await service.SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(pageIndex, pageSize, pelayananmedikid, ruangrawatid,
                        stsmasukkeluarruangrawatid,
                        value,
                        tglkeluarruangan);
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

        #endregion private control methode

        public FListRegistrasiKeluarRI(ref Panel pnlContent):base( ref pnlContent)
        {
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
            
            colcarapulangnm.Visible = true;
            colcarapulangnm.VisibleIndex = 11;
            colcarapulangnm.FieldName = "carapulangnm";

            colControl.VisibleIndex = 12;

            colcarapulangid.VisibleIndex = 13;
            colcarapulangid.Visible = false;
            colcarapulangid.FieldName = "carapulangid";

            colruangrawatnm.VisibleIndex = 14;
            colruangrawatnm.Visible = false;


            this.RegistrasiGV.EndInit();
            this.RegistrasiGC.EndInit();
            this.RegistrasiGC.Refresh();

            this.Text = "List Pasien Keluar";


            this.colstsmasukkekuarruangrawatid.Caption = "KELUAR ?";
            this.btnCaraPulang.Visible = true;


            this.StsmasukKeluarruangrawatid = 0;
            tglregistrasiLbl.Text = "Tgl.Keluar";
            tglregistrasiDateEdit.EditValue = null;

            this.btnCaraPulang.Location = this.btnPeriksaFisik.Location;
        }

        public FListRegistrasiKeluarRI(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) : 
            base(ref _pnlContent, ref v_registrasiruangrawat, indexRow)
        {
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

            colcarapulangnm.Visible = true;
            colcarapulangnm.VisibleIndex = 11;
            colcarapulangnm.FieldName = "carapulangnm";

            colControl.VisibleIndex = 12;

            colcarapulangid.VisibleIndex = 13;
            colcarapulangid.Visible = false;
            colcarapulangid.FieldName = "carapulangid";

            colruangrawatnm.VisibleIndex = 14;
            colruangrawatnm.Visible = false;


            this.RegistrasiGV.EndInit();
            this.RegistrasiGC.EndInit();
            this.RegistrasiGC.Refresh();

            this.Text = "List Pasien Keluar";


            this.colstsmasukkekuarruangrawatid.Caption = "KELUAR ?";
            this.btnCaraPulang.Visible = true;


            this.StsmasukKeluarruangrawatid = 0;
            tglregistrasiLbl.Text = "Tgl.Keluar";
            tglregistrasiDateEdit.EditValue = null;

            this.vregistrasiruangrawat = v_registrasiruangrawat;
            //this.indexRow = indexRow;
            this.indexFocusedRow = indexRow;
            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;

            this.btnCaraPulang.Location = this.btnPeriksaFisik.Location;

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
                        LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
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

        protected override void controlrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    FListRiwayatPenyakitPasienKeluarRI myForm = new FListRiwayatPenyakitPasienKeluarRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
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

        protected override void btnCaraPulang_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {

                    if (this.vregistrasiruangrawat.stsmasukkeluarruangrawatid == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Silahkan centang 'selesai' perawatan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah pasien dengan NoRegistrasi: " + this.vregistrasiruangrawat.noregistrasi + ", No.RM : " + this.vregistrasiruangrawat.nocm + ", Nama: "
                        + this.vregistrasiruangrawat.nama + " akan dipulangkan?" +
                        "\n\n Jika pilihan=[Yes], Diagnosa, Tindakan, Periksa Fisik, Anamnesa, Pengobatan, Tindakan Penunjang DISEMUA RUANG PERAWATAN tidak dapat diisi kembali " +
                        "\n Jika pilihan=[No], akan kembali ke tampilan sebelumnya", "Peringatan [Penting untuk dibaca]", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        using (FCaraPulangRI f = new FCaraPulangRI(Helper.Pelayananmedik.pelayananmedikid, Helper.Ruangrawat.ruangrawatid, this.vregistrasiruangrawat.registrasiid))
                        {
                            //create an overlay form
                            XtraForm overlayForm = new XtraForm();
                            overlayForm.StartPosition = this.StartPosition;// FormStartPosition.CenterScreen; //this.StartPosition;
                            overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                            overlayForm.Opacity = .80d;
                            overlayForm.BackColor = Color.Black;
                            overlayForm.Size = Screen.PrimaryScreen.WorkingArea.Size;// base.Size; //(this as FListRegistrasiRI).Activate.Size; //mainmenu.Size;// this.Size;
                            overlayForm.Location = Screen.PrimaryScreen.WorkingArea.Location; //base.Location;// FMainMenuRI.ActiveForm.Location; //mainmenu.Location;// this.Location;
                            //overlayForm.Size = this.Size;
                            //overlayForm.Location =  this.Location;
                            overlayForm.ShowInTaskbar = false;
                            overlayForm.Show();

                            //Show the dialog
                            f.Owner = overlayForm;
                            if (f.ShowDialog() == DialogResult.OK)
                            {   
                                if ((tglregistrasiDateEdit.Enabled == true) && (tglregistrasiDateEdit.EditValue != null))
                                {
                                    LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                                    Helper.Ruangrawat.ruangrawatid,
                                    this.StsmasukKeluarruangrawatid,
                                    CaridataMTxt.Text,
                                    ((DateTime)tglregistrasiDateEdit.EditValue).Date);
                                }
                                else
                                {
                                    LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                                        Helper.Ruangrawat.ruangrawatid,
                                        this.StsmasukKeluarruangrawatid,
                                        CaridataMTxt.Text);
                                }

                            }
                            //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                            //tahunLookUpEdit.ItemIndex = 0;

                            //Get rid of the overlay form
                            overlayForm.Dispose();
                            f.Dispose();
                        }

                    }
                    else
                    {
                        //this.RegistrasiGV.Columns["stsmasukkeluarruangrawatid"].ColumnEdit
                        //this.stsmasukkeluarruangrawatidrepositoryItemCheckEdit.ValueChecked = 1;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FListTindakanPasienKeluarRI myForm = new FListTindakanPasienKeluarRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);
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
                    FAnamnesaPasienKeluarRI myForm = new FAnamnesaPasienKeluarRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
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
                FPeriksaFisikKeluarRI myForm = new FPeriksaFisikKeluarRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
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
                FListDiagnosaPasienKeluarRI myForm = new FListDiagnosaPasienKeluarRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);

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
                FPengobatanPasienKeluarRI myForm = new FPengobatanPasienKeluarRI(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
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
