using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
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
    public partial class FPengobatanPasien : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected v_registrasiruangrawat v_Registrasiruangrawat;

        protected v_pengobatan v_Pengobatan;

        #region private methode control
        private void defaultControl()
        {
            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref dokterLookUpEdit,
               new string[] { "dokterid ", "dokternm" },
               new string[] { "Kode", "Nama" },
               new bool[] { false, true },
               "dokternm", "dokterid", "Pilih dokter...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref perawatLookUpEdit,
               new string[] { "perawatid  ", "perawatnm" },
               new string[] { "Kode", "Nama" },
               new bool[] { false, true },
               "perawatnm", "perawatid", "Pilih perawat...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref pengobatannmlookUpEdit ,
               new string[] { "pengobatannm"},
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

        private async void LoadDokterAsync()
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
                        //jenistarifCboEdit.DataBindings.Add( tarifGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasien()\nLoadDokterAsync()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        gc1.DataSource = result.Item1.ToList();
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

        #endregion

        public FPengobatanPasien()
        {
            InitializeComponent();
        }

        public FPengobatanPasien(ref Panel pnlContent)
        {
            try
            {
                InitializeComponent();
                this.pnlContent = pnlContent;
                this.defaultControl();
                this.LoadDokterAsync();
                this.LoadVperawatAsync(Helper.Ruangrawat.ruangrawatid);
                this.LoadPengobatannama();
                this.LoadPengobatansatuan();
                this.LoadPengobatanukuran();
                this.LoadPengobatanaturanpakai();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPengobatanPasien()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }



        private void gv1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.v_Pengobatan = gv1.GetRow(e.RowHandle) as v_pengobatan;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.v_Pengobatan = gv1.GetRow(e.RowHandle) as v_pengobatan;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_RowClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void gv1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Pengobatan = gv1.GetRow(e.FocusedRowHandle) as v_pengobatan;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        protected virtual void FPengobatanPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Loadv_pengobatanpasienByRegistrasiruangrawatidAsync (this.v_Registrasiruangrawat.registrasiruangrawatid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPengobatanPasien_Shown()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPengobatan_Click(object sender, EventArgs e)
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
                    MetroFramework.MetroMessageBox.Show(this, "Uraian pengobatan tidak boleh kosong ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pengobatannmlookUpEdit.Focus();
                    return;
                }

                if (ukuranlookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ukuran obat tidak boleh kosong, \nContoh: ukuran misalnya [500/250] untuk obat tablet...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ukuranlookUpEdit.Focus();
                    return;
                }

                if (satuanlookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Satuan obat tidak boleh kosong, \nContoh: satuan misalnya [gram] untuk obat tablet...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    satuanlookUpEdit.Focus();
                    return;
                }

                if (aturanlookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Aturan pakai obat tidak boleh kosong, \nContoh: aturan pakai misalnya [3 x 1] untuk obat tablet...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    aturanlookUpEdit.Focus();
                    return;
                }


                pengobatan p = new pengobatan()
                {
                    pengobatanid = -1,
                    registrasiruangrawatid = this.v_Registrasiruangrawat.registrasiruangrawatid,
                    tglperiksa =  (DateTime)tglperiksadateEdit.EditValue,
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
    }
}
