using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.frm.Poli;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class ListRegistrasiPoli : TFListRegistrasi
    {
        protected short StsmasukKeluarruangrawatid;

        protected int indexFocusedRow = 0;

        #region private methode

        protected async void LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid, 
                short stsregistrasiid, 
                short stsmasukKeluarruangrawatid, string value, DateTime tglmasuk)
        {
            try
            {
                using (var service = new ListRegistrasiServices())
                {
                    var result = await service.SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid,ruangrawatid,  
                        stsregistrasiid,
                        stsmasukKeluarruangrawatid,
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

        

        protected int UpdateStsMasukKeluarRuangRawat(short registrasiruangrawatid, short stsmasukkeluarruangrawatid, 
            DateTime tglkeluarruangan, DateTime jamkeluarruangan)
        {
            var result = -99;
            try
            {

                using (var service = new ListRegistrasiServices())
                {
                    result = service.UpdateStsMasukKeluarRuangRawat(registrasiruangrawatid, stsmasukkeluarruangrawatid,tglkeluarruangan,jamkeluarruangan);
                    if (result == -99)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Update Stsmasukkeluarruangrawat tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }

            catch (Exception ex)
            {
                result = -99;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }



        string AddRujukanPoli(registrasiruangrawat _registrasiruangrawat, v_pelayananpasienkarcis _vpelayananpasienkarcis)
        {
            using (var service = new RegistrasiPasienLamaServices())
            {
                return service.InsertRujukanPoli(_registrasiruangrawat, _vpelayananpasienkarcis);
            }
        }


        #endregion

        public ListRegistrasiPoli(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            //this.pnlContent = panel;
            colkelasnm.Visible = false;
            colkamarnm.Visible = false;
            colruangrawatnm.Visible = false;

            colEdit.Visible = false;
            colDelete.Visible = false;

            this.Text = "List pasien poliklinik";

            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            this.StsmasukKeluarruangrawatid = 1;//Masuk

            tglregistrasiDateEdit.EditValue = DateTime.Now;

            btnPeriksaFisik.Visible = false;
            btnAnamnesis.Visible = false;
            btnPengobatan.Visible = false;
        }

        public ListRegistrasiPoli(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) :base(ref _pnlContent)
        {
            //this.pnlContent = panel;
            colkelasnm.Visible = false;
            colkamarnm.Visible = false;
            colruangrawatnm.Visible = false;

            colEdit.Visible = false;
            colDelete.Visible = false;

            this.Text = "List pasien poliklinik";

            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";

            this.StsmasukKeluarruangrawatid = 1;//Masuk

            this.vregistrasiruangrawat = v_registrasiruangrawat;
            //this.indexRow = indexRow;
            this.indexFocusedRow = indexRow;
            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;

            btnPeriksaFisik.Visible = false;
            btnAnamnesis.Visible = false;
            btnPengobatan.Visible = false;
        }

 
        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.StsmasukKeluarruangrawatid = 1;//Masuk
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Ruangrawat.ruangrawatid, Helper.Stsregistrasi.stsregistrasiid, this.StsmasukKeluarruangrawatid, CaridataMTxt.Text,((DateTime) tglregistrasiDateEdit.EditValue).Date);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        protected override void FListRegistrasi_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
                tglregistrasiDateEdit.EditValue = DateTime.Now;

                ////this.PageIndex = 1;
                ////LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                ////    Helper.Ruangrawat.ruangrawatid, Helper.Stsregistrasi.stsregistrasiid,
                ////    this.StsmasukKeluarruangrawatid,
                ////    string.Empty,
                ////    ((DateTime)tglregistrasiDateEdit.EditValue).Date);

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
                this.StsmasukKeluarruangrawatid = 1;//Masuk
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Ruangrawat.ruangrawatid, Helper.Stsregistrasi.stsregistrasiid,
                    this.StsmasukKeluarruangrawatid,
                    string.Empty,
                    ((DateTime)tglregistrasiDateEdit.EditValue).Date);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e) // diagnosa
        {
            //if (this.vregistrasiruangrawat != null)
            //{
            //    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            //    this.pnlContent.Controls.Clear();
            //    //fDashboard myForm = new fDashboard();
            //    FListDiagnosaPasienPoli myForm = new FListDiagnosaPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);

            //    //FPeriksaFisikPoli myForm = new FPeriksaFisikPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);

            //    myForm.TopLevel = false;
            //    myForm.AutoScroll = true;
            //    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            //    this.pnlContent.Controls.Add(myForm);
            //    myForm.Dock = DockStyle.Fill;
            //    myForm.Show();
            //}


            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListPelayananPasienPoli myForm = new FListPelayananPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);

                //FPeriksaFisikPoli myForm = new FPeriksaFisikPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
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
                FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }

        }

        protected override void btnAnamnesis_Click(object sender, EventArgs e) //Anannesa

        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FAnamnesaPasienPoli myForm = new FAnamnesaPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
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

        protected override void btnPeriksaFisik_Click(object sender, EventArgs e) // periksa fisik // Rujuk ke poli lain
        {

            try
            {
                using (FRujukantarpoli f = new FRujukantarpoli(this.vregistrasiruangrawat.noregistrasi, this.vregistrasiruangrawat.tglmasuk.Value.Date,
                    this.vregistrasiruangrawat.nocm, this.vregistrasiruangrawat.nama, this.vregistrasiruangrawat.ruangrawatid.Value,
                    this.vregistrasiruangrawat.ruangrawatnm, this.vregistrasiruangrawat.registrasiid,
                    Helper.Pelayananmedik.pelayananmedikid,this.vregistrasiruangrawat.penjaminpasienid.Value))
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passDataRujukanpoli += new FRujukantarpoli.PassDataRujukanpoli(passDataRujukanpoli);
                    f.ShowDialog();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nDiagnosaAwalButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            ////if (this.vregistrasiruangrawat != null)
            ////{
            ////    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            ////    this.pnlContent.Controls.Clear();
            ////    //fDashboard myForm = new fDashboard();
            ////    FPeriksaFisikPoli myForm = new FPeriksaFisikPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
            ////    myForm.TopLevel = false;
            ////    myForm.AutoScroll = true;
            ////    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            ////    this.pnlContent.Controls.Add(myForm);
            ////    myForm.Dock = DockStyle.Fill;
            ////    myForm.Show();
            ////}
        }


        private void passDataRujukanpoli(registrasiruangrawat Registrasiruangrawat, v_pelayananpasienkarcis v_Pelayananpasienkarcis)
        {
            if ((Registrasiruangrawat != null) && (v_Pelayananpasienkarcis != null))
            {
                var result = AddRujukanPoli(Registrasiruangrawat, v_Pelayananpasienkarcis);
                if (string.IsNullOrEmpty(result))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Rujukan pasien sukesss!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, result+"\nRujukan pasien tidak valid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void btnPengobatan_Click(object sender, EventArgs e) //Pengobatan

        {
            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FPengobatanPasienPoli myForm = new FPengobatanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
        }

        protected override void stsmasukkeluarruangrawatidrepositoryItemCheckEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah pasien dengan NoRegistrasi: "+this.vregistrasiruangrawat.noregistrasi+", No.RM : " + this.vregistrasiruangrawat.nocm + ", Nama: " 
                        + this.vregistrasiruangrawat.nama + " telah selesai mendapatkan perawatan?\nPeriksa kembali diagnosa, tindakan, pemeriksaan fisik, dan pengobatan pasien, apakah sudah diisi?"+
                        "\n\n Jika pilihan=[Yes], Tindakan dan Diagnosa pasien tidak dapat diisi kembali, kemudian data pasien akan ditampilkan pada form 'List Pasien Poli'"+
                        "\n Jika pilihan=[No], akan kembali ke tampilan sebelumnya", "Peringatan [Penting untuk dibaca]", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        if (UpdateStsMasukKeluarRuangRawat(this.vregistrasiruangrawat.registrasiruangrawatid, 0, DateTime.Now.Date, DateTime.Now ) != -99)
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                            this.PageIndex = 1;
                            LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                                Helper.Ruangrawat.ruangrawatid, Helper.Stsregistrasi.stsregistrasiid,
                                this.StsmasukKeluarruangrawatid,
                                CaridataMTxt.Text, ((DateTime)tglregistrasiDateEdit.EditValue).Date);
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
                    FListRiwayatPenyakitPasienPoli myForm = new FListRiwayatPenyakitPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
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



        protected override void btnBack_Click(object sender, EventArgs e)
        {

        }

        
    }
}
