
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
    public class FListPasienPoli : ListRegistrasiPoli
    {
        #region private methode

        string AddRujukanPoli(registrasiruangrawat _registrasiruangrawat, v_pelayananpasienkarcis _vpelayananpasienkarcis)
        {
            using (var service = new RegistrasiPasienLamaServices())
            {
                return service.InsertRujukanPoli(_registrasiruangrawat, _vpelayananpasienkarcis);
            }
        }

        #endregion private methode

        public FListPasienPoli(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "List Pasien Poliklinik - [Telah Periksa]";
            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";
            this.btnPeriksaFisik.Text = "Rujuk Poli";

            this.btnPeriksaFisik.Visible = true;

            this.StsmasukKeluarruangrawatid = 0;//Keluar

        }

        public FListPasienPoli(ref Panel _pnlContent, ref v_registrasiruangrawat v_registrasiruangrawat, int indexRow) : base(ref _pnlContent)
        {
            this.Text = "List Pasien Poliklinik - [Telah Periksa]";
            this.btnAddRegistrasiPasienBaru.Text = "Diagnosa";
            this.btnAddRegistrasiPasienLama.Text = "Tindakan";
            this.btnPeriksaFisik.Text = "Rujuk Poli";
            this.btnPeriksaFisik.Visible = true;

            this.StsmasukKeluarruangrawatid = 0;//Keluar
            this.vregistrasiruangrawat = v_registrasiruangrawat;

            tglregistrasiDateEdit.EditValue = this.vregistrasiruangrawat.tglmasuk.Value.Date;
            this.indexFocusedRow = indexRow;



        }

        protected override void FListRegistrasi_Load(object sender, EventArgs e)
        {
            try
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                //this.PageIndex = 1;
                //LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                //    Helper.Ruangrawat.ruangrawatid, Helper.Stsregistrasi.stsregistrasiid,
                //    this.StsmasukKeluarruangrawatid,
                //    string.Empty,
                //    ((DateTime)tglregistrasiDateEdit.EditValue).Date);

                this.RegistrasiGV.Columns["stsmasukkeluarruangrawatid"].OptionsColumn.AllowEdit = false;
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
                this.StsmasukKeluarruangrawatid = 0;
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

        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.StsmasukKeluarruangrawatid = 0;
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);
                this.PageIndex = 1;
                LoadVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize, Helper.Pelayananmedik.pelayananmedikid,
                    Helper.Ruangrawat.ruangrawatid, Helper.Stsregistrasi.stsregistrasiid,
                    this.StsmasukKeluarruangrawatid,
                    CaridataMTxt.Text, ((DateTime)tglregistrasiDateEdit.EditValue).Date);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void stsmasukkeluarruangrawatidrepositoryItemCheckEdit_EditValueChanged(object sender, EventArgs e)
        {
        }

        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e) // diagnosa
        {
            if (this.vregistrasiruangrawat != null)
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListLihatDiagnosaPasienPoli myForm = new FListLihatDiagnosaPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat,ref this.indexRow);
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
                FListLihatTindakanPasienPoli myForm = new FListLihatTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat,ref this.indexRow);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }

        }

        protected override void btnAnamnesis_Click(object sender, EventArgs e)
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

        protected override void btnPeriksaFisik_Click(object sender, EventArgs e) // Periksa Fisik // Rujuk Poli
        {
            if (this.vregistrasiruangrawat != null)
            {

                try
                {
                    using (FRujukantarpoli f = new FRujukantarpoli(this.vregistrasiruangrawat.noregistrasi, this.vregistrasiruangrawat.tglmasuk.Value.Date,
                        this.vregistrasiruangrawat.nocm, this.vregistrasiruangrawat.nama, this.vregistrasiruangrawat.ruangrawatid.Value,
                        this.vregistrasiruangrawat.ruangrawatnm, this.vregistrasiruangrawat.registrasiid,
                        Helper.Pelayananmedik.pelayananmedikid, this.vregistrasiruangrawat.penjaminpasienid.Value))
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

                ////Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                ////this.pnlContent.Controls.Clear();
                //////fDashboard myForm = new fDashboard();
                ////FPeriksaFisikPoli myForm = new FPeriksaFisikPoli(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                ////myForm.TopLevel = false;
                ////myForm.AutoScroll = true;
                ////myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                ////this.pnlContent.Controls.Add(myForm);
                ////myForm.Dock = DockStyle.Fill;
                ////myForm.Show();
            }
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
                    MetroFramework.MetroMessageBox.Show(this, result + "\nRujukan pasien tidak valid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
