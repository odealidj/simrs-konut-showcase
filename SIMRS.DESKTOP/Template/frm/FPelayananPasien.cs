using DevExpress.XtraGrid;
using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Helper;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.POLI;
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
    public partial class FPelayananPasien : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected v_registrasiruangrawat v_Registrasiruangrawat;

        protected ruangrawat Ruangrawat;

        protected int indexSelectedRow;

        #region private methode control


        protected void populateVregistrasiruangrawat(ref v_registrasiruangrawat value)
        {
            if (value == null) return;
            this.lblTitle.Text = string.Format("Noreg:{0}, Tgl.Reg:{1}, NORM:{2}, Nama:{3}, JK:{4}, Umur:{5}", value.noregistrasi, value.tglmasuk.Value.ToString("dd/MM/yyyy"), value.nocm,
                value.nama.ToUpper(),value.jknm,string.Format("{0}Thn, {1}Bln, {2}Hari", value.thn, value.bulan, value.hari));

            //this.noregistrasiMtxt.Text = value.noregistrasi; this.tglregistrasiMtxt.Text = value.tglmasuk.Value.ToString("dd/MM/yyyy");
            //this.normMtxt.Text = value.nocm; this.namaMtxt.Text = value.nama;
            //this.kelasMtxt.Text = value.kelasuraian; this.ruangrawatMtxt.Text = value.ruangrawatnm;
            //this.kelumurMtxt.Text = string.Format("{0} / {1} Thn, {2} Bln, {3} Hari", value.jknm, value.thn, value.bulan, value.hari); this.penjaminMtxt.Text = value.penjaminpasiennm;
            ////this.lblTitle.Text = string.Format("NO.REGISTRASI: {0}, NO.RM: {1}, NAMA PASIEN: {2}", value.noregistrasi, value.nocm, value.nama);
            //this.lblTitle.Text = string.Format("{0}", value.nama.ToUpper());
        }

        public void defaultControl()
        {
            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref dokterLookUpEdit,
               new string[] { "dokterid", "dokternm" },
               new string[] { "Kode", "DOKTER" },
               new bool[] { false, true },
               "dokternm", "dokterid", "Pilih dokter ...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref perawatLookUpEdit,
               new string[] { "perawatid", "perawatnm" },
               new string[] { "Kode", "PERAWAT" },
               new bool[] { false, true },
               "perawatnm", "perawatid", "Pilih perawat ...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref jenisdiagnosaLookUpEdit,
               new string[] { "jenisdiagnosaid", "jenisdiagnosanm" },
               new string[] { "Kode", "JENIS DIAGNOSA" },
               new bool[] { false, true },
               "jenisdiagnosanm", "jenisdiagnosaid", "Pilih jenis diagnosa ...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref pengobatannmlookUpEdit,
               new string[] { "pengobatannm" },
               new string[] { "Nama" },
               new bool[] { true },
               "pengobatannm", "pengobatannm", " ");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref satuanlookUpEdit,
               new string[] { "satuan" },
               new string[] { "Satuan" },
               new bool[] { true },
               "satuan", "satuan", " ");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref ukuranlookUpEdit,
               new string[] { "ukuran" },
               new string[] { "Ukuran" },
               new bool[] { true },
               "ukuran", "ukuran", " ");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref aturanlookUpEdit,
               new string[] { "aturanpakai" },
               new string[] { "Aturanpakai" },
               new bool[] { true },
               "aturanpakai", "aturanpakai", " ");

        }

        private async void LoadDokterAsyn()
        {
            try
            {
                using (var service = new DokterServices())
                {
                    var result = await service.SelectDokterAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        dokterLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadVperawatAsync(short ruangrawatid)
        {
            try
            {
                using (var service = new PerawatServices())
                {
                    var result = await service.SelectVperawatAsync(ruangrawatid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        perawatLookUpEdit.Properties.DataSource = result.Item1;
                        //jenistarifCboEdit.DataBindings.Add( tarifGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasien()\nLoadVperawatAsync()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region pemeriksaan fisik

        protected v_pemeriksaanfisik v_Pemeriksaanfisik;

        protected List<v_pemeriksaanfisik> listv_Pemeriksaanfisik;

        public int AddPemeriksaanfisik(pemeriksaanfisik obj)
        {
            using (var service = new PeriksaFisikServices())
            {
                var result = service.InsertPemeriksaanFisik(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add pemeriksaan fisik tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        public bool RemovePemeriksaanfisikpasien(pemeriksaanfisik obj)
        {
            using (var service = new PeriksaFisikServices())
            {
                var result = service.DeletePemeriksaanFisik(obj);
                if (result == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove data pemeriksaan fisik tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return result;
            }
        }

        private async void LoadV_pemeriksaanfisikAsync(short pemeriksaanfisikid)
        {
            try
            {
                using (var service = new PeriksaFisikServices())
                {
                    var result = await service.SelectAllv_pemeriksaanfisikAsync(pemeriksaanfisikid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pemeriksaanfisikGC.DataSource = result.Item1;
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadV_pemeriksaanfisikByregistrasiruangrawatidAsync(short registrasiruangrawatid, DateTime tglpemeriksaanfisik)
        {
            try
            {
                using (var service = new PeriksaFisikServices())
                {
                    var result = await service.SelectAllv_pemeriksaanfisikByregistrasiruangrawatidAsync(registrasiruangrawatid, tglpemeriksaanfisik);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pemeriksaanfisikGC.DataSource = result.Item1.ToList();
                        this.listv_Pemeriksaanfisik = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion pemeriksaan fisik

        #region diagnosa

        protected icdxsubkategori selectedIcdxsubkategori;
        private async void LoadJenisDiagnosaAsync()
        {
            try
            {
                using (var service = new JenisdiagnosaServices())
                {
                    var result = await service.SelectJenisdiagnosaAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        jenisdiagnosaLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int AddIcdxpasien(icdxpasien obj)
        {
            using (var service = new IcdxServices())
            {
                var result = service.InsertIcdxpasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add diagnosa tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        public int RemoveIcdxpasien(icdxpasien obj)
        {
            using (var service = new IcdxServices())
            {
                var result = service.DeleteIcdxpasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove diagnosa tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        protected async void LoadVicdxpasienpoliAsync(short registrasiruangrawatid)
        {
            try
            {
                using (var service = new ListDiagosaPasienPoliServices())
                {
                    var result = await service.SelectVicdxpasienpoliAsync(registrasiruangrawatid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        icdxGC.DataSource = result.Item1;
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion diagnosa

        #region anamnesis

        protected v_anamnesapasien v_Anamnesapasien;

        public int AddAnamnesaPasien(anamnesapasien obj)
        {
            using (var service = new AnamnesaServices())
            {
                var result = service.InsertAnamnesaPasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add anamnesa pasien tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        public bool RemoveAnamnesapasien(anamnesapasien obj)
        {
            using (var service = new AnamnesaServices())
            {
                var result = service.DeleteAnamnesaPasien(obj);
                if (result == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove data anamnesa pasien tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return result;
            }
        }

        private async void Loadv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid,DateTime tglperiksa)
        {
            try
            {
                using (var service = new AnamnesaServices())
                {
                    var result = await service.SelectAllv_anamnesapasienByRegistrasiruangrawatidAsync(registrasiruangrawatid,tglperiksa);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        anamnesisGC.DataSource = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion #region anamnesis

        #region pengobatan

        protected v_pengobatan v_Pengobatan;

        public int AddPengobatanPasien(pengobatan obj)
        {
            using (var service = new PengobatanServices())
            {
                var result = service.InsertPengobatanPasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add pengobatan pasien tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        public bool RemovePengobatanpasien(pengobatan obj)
        {
            using (var service = new PengobatanServices())
            {
                var result = service.DeletePengobatanPasien(obj);
                if (result == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove data pengobatan pasien tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return result;
            }
        }

        private async void Loadv_pengobatanpasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid)
        {
            try
            {
                using (var service = new PengobatanServices())
                {
                    var result = await service.SelectAllv_pengobatanByRegistrasiruangrawatidAsync(registrasiruangrawatid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pengobatanGC.DataSource = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPengobatannama()
        {
            try
            {
                using (var service = new PengobatanServices())
                {
                    var result = service.SelectAllPengobatannama();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pengobatannmlookUpEdit.Properties.DataSource = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPengobatansatuan()
        {
            try
            {
                using (var service = new PengobatanServices())
                {
                    var result = service.SelectAllPengobatansatuan();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        satuanlookUpEdit.Properties.DataSource = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPengobatanukuran()
        {
            try
            {
                using (var service = new PengobatanServices())
                {
                    var result = service.SelectAllPengobatanukuran();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ukuranlookUpEdit.Properties.DataSource = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPengobatanaturanpakai()
        {
            try
            {
                using (var service = new PengobatanServices())
                {
                    var result = service.SelectAllPengobatanaturanpakai();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        aturanlookUpEdit.Properties.DataSource = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion pengobatan

        #region tindakan

        protected int RemovePelayananPasien(pelayananpasien obj)
        {
            using (var service = new PelayananpaseinServices())
            {
                var result = service.DeletePelayananPasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove tindakan pasien tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        #endregion tindakan

        #endregion

        public FPelayananPasien()
        {
            InitializeComponent();
        }

        public FPelayananPasien(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat)
        {
            InitializeComponent();
            try
            {
                this.pnlContent = pnlContent;
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;

                if (this.v_Registrasiruangrawat != null)
                {
                    this.tglperiksadateEdit.EditValue = this.v_Registrasiruangrawat.tglmasuk.Value.Date;
                }
                else
                {
                    this.tglperiksadateEdit.EditValue = DateTime.Now.Date;
                }
                this.pelayananpasienMTC.SelectedIndex = 0;

                this.defaultControl();
                this.LoadDokterAsyn();
                this.LoadVperawatAsync(this.v_Registrasiruangrawat.ruangrawatid.Value);
                this.LoadJenisDiagnosaAsync();

                this.LoadPengobatannama();
                this.LoadPengobatansatuan();
                this.LoadPengobatanukuran();
                this.LoadPengobatanaturanpakai();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nContructor FPelayananPasien", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void FPelayananPasien_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FPelayananPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.v_Registrasiruangrawat != null)
                {
                    populateVregistrasiruangrawat(ref this.v_Registrasiruangrawat);
                    this.Loadv_anamnesapasienByRegistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid, ((DateTime)this.tglperiksadateEdit.EditValue).Date);
                    this.LoadV_pemeriksaanfisikByregistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid, ((DateTime)this.tglperiksadateEdit.EditValue).Date);
                    this.LoadVicdxpasienpoliAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);
                    this.Loadv_pengobatanpasienByRegistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);
                }

                if (icdxGC.DataSource != null)
                {
                    icdxGV.Columns[0].Visible = false;
                    icdxGV.Columns[1].Visible = false;
                    icdxGV.Columns[5].Visible = false;

                    icdxGV.Columns[2].Caption = "KODE";
                    icdxGV.Columns[3].Caption = "Diagnosa [Eng]";
                    icdxGV.Columns[4].Caption = "Diagnosa [INA]";
                    icdxGV.Columns[6].Caption = "JENIS";

                    icdxGV.Columns[2].OptionsColumn.AllowEdit = false;
                    icdxGV.Columns[3].OptionsColumn.AllowEdit = false;
                    icdxGV.Columns[4].OptionsColumn.AllowEdit = false;
                    icdxGV.Columns[6].OptionsColumn.AllowEdit = false;

                    icdxGV.Columns[2].OptionsColumn.FixedWidth = true;
                    icdxGV.Columns[2].Width = 75;

                    icdxGV.Columns[6].OptionsColumn.FixedWidth = true;
                    icdxGV.Columns[6].Width = 90;

                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasien_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void icdxButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FListICDXPOLI f = new FListICDXPOLI())
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passData += new FListICDXPOLI.PassData(passData);
                    f.ShowDialog();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nDiagnosaAwalButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void passData(object kode, object name)
        {
            if (kode != null)
            {
                if (!string.IsNullOrEmpty(kode.ToString()))
                {
                    selectedIcdxsubkategori = new icdxsubkategori()
                    {
                        icdxsubkategoriid = kode.ToString()
                    };
                    icdxButtonEdit.Text = kode + " - " + name;
                }
                else
                {
                    icdxButtonEdit.Text = string.Empty;
                }
            }
            else
            {
                icdxButtonEdit.Text = string.Empty;
            }
        }

        protected virtual void anamnesisGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Anamnesapasien = anamnesisGV.GetRow(e.FocusedRowHandle) as v_anamnesapasien;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nanamnesisGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void anamnesisGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.v_Anamnesapasien = anamnesisGV.GetRow(e.RowHandle) as v_anamnesapasien;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nanamnesisGV_RowCellClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void anamnesisGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.v_Anamnesapasien = anamnesisGV.GetRow(e.RowHandle) as v_anamnesapasien;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nanamnesisGV_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void deleteanamnesarepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Anamnesapasien != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah data anamnesa pasien, pasien dengan NoRM : "
                        + this.v_Registrasiruangrawat.nocm + ", Nama: "
                        + this.v_Registrasiruangrawat.nama
                        + ", Keluhan: " + this.v_Anamnesapasien.keluhanutama + " akan dihapus?"
                        + "\n[Yes] untuk melanjutkan"
                        + "\n[No] untuk membatalkan", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemoveAnamnesapasien(new anamnesapasien { anamnesapasienid = this.v_Anamnesapasien.anamnesapasienid });
                        Loadv_anamnesapasienByRegistrasiruangrawatidAsync((short)this.v_Registrasiruangrawat.registrasiruangrawatid,((DateTime)tglperiksadateEdit.EditValue).Date);
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnAddPeriksa_Click(object sender, EventArgs e)
        {
            try
            {

                if (tglperiksadateEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tanggal periksa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tglperiksadateEdit.Focus();
                    return;
                }

                if (dokterLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dokterLookUpEdit.Focus();
                    return;
                }

                if (perawatLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih perawat ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    perawatLookUpEdit.Focus();
                    return;
                }


                pemeriksaanfisik p = new pemeriksaanfisik()
                {
                    pemeriksaanfisikid = (this.listv_Pemeriksaanfisik == null) ? (short)-1 : ((this.listv_Pemeriksaanfisik.Count == 0) ? (short)-1 : this.listv_Pemeriksaanfisik.FirstOrDefault().pemeriksaanfisikid),
                    tglperiksafisik = ((DateTime)tglperiksadateEdit.EditValue).Date,
                    registrasiruangrawatid = this.v_Registrasiruangrawat.registrasiruangrawatid,
                    perawatid = (perawatLookUpEdit.EditValue != null) ? (short)perawatLookUpEdit.EditValue : (short)-1,
                    dokterid = (dokterLookUpEdit.EditValue != null) ? (short)dokterLookUpEdit.EditValue : (short)-1,
                    tensi = tensiMTxt.Text,
                    suhu = suhuMTxt.Text,
                    beratbadan = beratbadanMTxt.Text,
                    nadi = nadiMTxt.Text,
                    respirasi = null,
                    kesadaran = kesadaranMTxt.Text,
                    kepala = null,
                    leher = null,
                    dada = null,
                    perut = null,
                    punggung = null,
                    daerahgenetalis = null,
                    extremitas_atas = null,
                    extremitas_bwh = null,
                    terapi = null,
                    tinggibadan = tinggibadanMTxt.Text,
                    lila = lilaMtxt.Text
                };

                var result = AddPemeriksaanfisik(p);
                //if (result != -1)
                //{
                LoadV_pemeriksaanfisikAsync((short)result);
                //}
                //LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbAddIcdX_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void deletepemeriksaanfisikrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Pemeriksaanfisik != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah data pemeriksaan fisik, pasien dengan NoRM : "
                        + this.v_Registrasiruangrawat.nocm + ", Nama: "
                        + this.v_Registrasiruangrawat.nama + " akan dihapus?"
                        + "\n[Yes] untuk melanjtkan"
                        + "\n[No] untuk membatalkan", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemovePemeriksaanfisikpasien(new pemeriksaanfisik { pemeriksaanfisikid = this.v_Pemeriksaanfisik.pemeriksaanfisikid });
                        LoadV_pemeriksaanfisikByregistrasiruangrawatidAsync((short)this.v_Pemeriksaanfisik.pemeriksaanfisikid,((DateTime)this.tglperiksadateEdit.EditValue).Date);
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void pemeriksaanfisikGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Pemeriksaanfisik = pemeriksaanfisikGV.GetRow(e.FocusedRowHandle) as v_pemeriksaanfisik;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npemeriksaanfisikGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void pemeriksaanfisikGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.v_Pemeriksaanfisik = pemeriksaanfisikGV.GetRow(e.RowHandle) as v_pemeriksaanfisik;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npemeriksaanfisikGV_RowCellClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void pemeriksaanfisikGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.v_Pemeriksaanfisik = pemeriksaanfisikGV.GetRow(e.RowHandle) as v_pemeriksaanfisik;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npemeriksaanfisikGV_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void addMbtn_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void tindakanGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void tindakanGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private Font font_Renamed = new Font("Arials", 11, FontStyle.Bold);
        private void tindakanGV_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            ////e.Appearance.Font = font_Renamed;
            ////e.Appearance.DrawString(e.Cache, e.Info.DisplayText, e.Bounds);
            ////e.Handled = true;


            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            //string summaryText = String.Format("{0} {1} = {2:c2}", summary.SummaryType, e.Column.GetCaption(), summaryValue);
            string summaryText = String.Format("{0:#,##}", summaryValue);
            e.Appearance.Font = font_Renamed;
            e.Appearance.ForeColor = Color.DarkRed;
            e.Info.DisplayText = summaryText;
        }

        protected virtual void deletetindakanrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void edittindakanrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void btnAddAnamnesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tglperiksadateEdit.EditValue == null)
                {
                    tglperiksadateEdit.Focus();
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tanggal periksa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                if (dokterLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dokterLookUpEdit.Focus();
                    return;
                }

                if (perawatLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih perawat ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    perawatLookUpEdit.Focus();
                    return;
                }

                anamnesapasien a = new anamnesapasien()
                {
                    anamnesapasienid = -1,
                    registrasiruangrawatid = this.v_Registrasiruangrawat.registrasiruangrawatid,
                    keluhanutama = this.keluhanTambahanMTxt.Text,
                    keluhantambahan = null,
                    imunisasi = null,
                    perawatid = (perawatLookUpEdit.EditValue != null) ? (short)perawatLookUpEdit.EditValue : (short)-1,
                    dokterid = (dokterLookUpEdit.EditValue != null) ? (short)dokterLookUpEdit.EditValue : (short)-1,
                    tglperiksa = (DateTime)tglperiksadateEdit.EditValue
                };

                var result = AddAnamnesaPasien(a);
                //if (result != -1)
                //{
                Loadv_anamnesapasienByRegistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid,((DateTime)this.tglperiksadateEdit.EditValue).Date);
                //}
                //LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbtnAddAnamnesa_Click() ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void bAddIcdX_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIcdxsubkategori == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih diagnosa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (jenisdiagnosaLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis diagnosa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dokterLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                icdxpasien icdx = new icdxpasien()
                {
                    icdxpasienid = -1,
                    icdxsubkategoriid = selectedIcdxsubkategori.icdxsubkategoriid,
                    registrasiruangrawatid = this.v_Registrasiruangrawat.registrasiruangrawatid,
                    icdxpasientgl = ((DateTime)tglperiksadateEdit.EditValue).Date,
                    jenisdiagnosaid = (jenisdiagnosaLookUpEdit.EditValue != null) ? (short)jenisdiagnosaLookUpEdit.EditValue : (short)-1,
                    dokterid = (dokterLookUpEdit.EditValue != null) ? (short)dokterLookUpEdit.EditValue : (short)-1,
                    loginappid = -1, //Helper.LoginAppDetail.loginappdetailid,
                    created_date = DateTime.Now,
                    updated_date = null,
                    icdxpasiensts = true
                };

                AddIcdxpasien(icdx);
                LoadVicdxpasienpoliAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbAddIcdX_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void deleteicdxrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void icdxGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void icdxGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void icdxGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void btnAddPengobatan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tglperiksadateEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tanggal periksa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tglperiksadateEdit.Focus();
                    return;
                }

                if (dokterLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dokterLookUpEdit.Focus();
                    return;
                }

                if (perawatLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih perawat ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    perawatLookUpEdit.Focus();
                    return;
                }

                if (pengobatannmlookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nama obat tidak boleh kosong ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pengobatannmlookUpEdit.Focus();
                    return;
                }

                if (ukuranlookUpEdit.EditValue == null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Ukuran obat belum diisi,\n [Yes=utk melanjutkan]\n[No=utk berhenti] \nContoh: ukuran misalnya [500/250] untuk obat tablet...", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        ukuranlookUpEdit.Focus();
                        return;
                    }
                }

                if (satuanlookUpEdit.EditValue == null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Satuan obat belum disi,\n [Yes=utk melanjutkan]\n[No=utk berhenti]  \nContoh: satuan misalnya [gram] untuk obat tablet...", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        satuanlookUpEdit.Focus();
                        return;
                    }
                }

                if (aturanlookUpEdit.EditValue == null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Aturan pakai obat belum diisi,\n [Yes=utk melanjutkan]\n[No=utk berhenti]  \nContoh: aturan pakai misalnya [3 x 1] untuk obat tablet...", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        aturanlookUpEdit.Focus();
                        return;
                    }
                }


                pengobatan p = new pengobatan()
                {
                    pengobatanid = -1,
                    registrasiruangrawatid = this.v_Registrasiruangrawat.registrasiruangrawatid,
                    tglperiksa = (DateTime)tglperiksadateEdit.EditValue,
                    perawatid = (perawatLookUpEdit.EditValue != null) ? (short)perawatLookUpEdit.EditValue : (short)-1,
                    dokterid = (dokterLookUpEdit.EditValue != null) ? (short)dokterLookUpEdit.EditValue : (short)-1,
                    pengobatannm = pengobatannmlookUpEdit.Text,
                    ukuran = ukuranlookUpEdit.Text,
                    satuan = satuanlookUpEdit.Text,
                    aturanpakai = aturanlookUpEdit.Text
                };



                var result = AddPengobatanPasien(p);
                //if (result != -1)
                //{
                Loadv_pengobatanpasienByRegistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);
                //}
                //LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbtnAddAnamnesa_Click() ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void pengobatanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Pengobatan = pengobatanGV.GetRow(e.FocusedRowHandle) as v_pengobatan;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npengobatanGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void pengobatanGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.v_Pengobatan = pengobatanGV.GetRow(e.RowHandle) as v_pengobatan;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npengobatanGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void pengobatanGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.v_Pengobatan = pengobatanGV.GetRow(e.RowHandle) as v_pengobatan;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npengobatanGV_RowClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void deletepengobatanrepositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Pengobatan != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah data pengobatan pasien, pasien dengan NoRM : "
                        + this.v_Registrasiruangrawat.nocm + ", Nama: "
                        + this.v_Registrasiruangrawat.nama
                        + ", Pengobatan: " + this.v_Pengobatan.pengobatannm + " akan dihapus?"
                        + "\n[Yes] untuk melanjutkan"
                        + "\n[No] untuk membatalkan", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemovePengobatanpasien(new pengobatan { pengobatanid = this.v_Pengobatan.pengobatanid });
                        Loadv_pengobatanpasienByRegistrasiruangrawatidAsync((short)this.v_Pengobatan.registrasiruangrawatid);
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
