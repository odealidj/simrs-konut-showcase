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
    public partial class FAnamnesaPasien : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected v_registrasiruangrawat v_Registrasiruangrawat;

        protected v_anamnesapasien v_Anamnesapasien;

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
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nFAnamnesaPasien()\nLoadVperawatAsync()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private async void Loadv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid)
        {
            try
            {
                using (var service = new AnamnesaServices())
                {
                    var result = await service.SelectAllv_anamnesapasienByRegistrasiruangrawatidAsync(registrasiruangrawatid);
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

        #endregion

        public FAnamnesaPasien()
        {
            InitializeComponent();
        }

        public FAnamnesaPasien(ref Panel pnlContent)
        {
            try
            {
                InitializeComponent();
                this.pnlContent = pnlContent;
                this.defaultControl();
                this.LoadDokterAsync();
                this.LoadVperawatAsync(Helper.Ruangrawat.ruangrawatid);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nFAnamnesaPasien()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAnamnesa_Click(object sender, EventArgs e)
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
                Loadv_anamnesapasienByRegistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);
                //}
                //LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbtnAddAnamnesa_Click() ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void FAnamnesaPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Loadv_anamnesapasienByRegistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasien_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Anamnesapasien != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah data anamnesa pasien, pasien dengan NoRM : "
                        + this.v_Registrasiruangrawat.nocm + ", Nama: "
                        + this.v_Registrasiruangrawat.nama 
                        + ", Keluhan: " +this.v_Anamnesapasien.keluhanutama + " akan dihapus?"
                        + "\n[Yes] untuk melanjutkan"
                        + "\n[No] untuk membatalkan", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemoveAnamnesapasien(new anamnesapasien { anamnesapasienid = this.v_Anamnesapasien.anamnesapasienid });
                        Loadv_anamnesapasienByRegistrasiruangrawatidAsync((short)this.v_Registrasiruangrawat.registrasiruangrawatid);
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void gv1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Anamnesapasien = gv1.GetRow(e.FocusedRowHandle) as v_anamnesapasien;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.v_Anamnesapasien = gv1.GetRow(e.RowHandle) as v_anamnesapasien;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_RowCellClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        private void gv1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.v_Anamnesapasien = gv1.GetRow(e.RowHandle) as v_anamnesapasien;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
