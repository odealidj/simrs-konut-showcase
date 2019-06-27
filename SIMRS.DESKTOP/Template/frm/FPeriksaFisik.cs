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
    public partial class FPeriksaFisik : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected v_registrasiruangrawat v_Registrasiruangrawat;

        protected v_pemeriksaanfisik v_Pemeriksaanfisik;

        protected List<v_pemeriksaanfisik> listv_Pemeriksaanfisik;

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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasien()\nLoadVperawatAsync()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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
                    var result = await service.SelectAllv_pemeriksaanfisikAsync (pemeriksaanfisikid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        gc1.DataSource = result.Item1;
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
                    var result = await service.SelectAllv_pemeriksaanfisikByregistrasiruangrawatidAsync(registrasiruangrawatid,tglpemeriksaanfisik);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        gc1.DataSource = result.Item1.ToList();
                        this.listv_Pemeriksaanfisik =  result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        public FPeriksaFisik()
        {
            InitializeComponent();
        }

        public FPeriksaFisik(ref Panel pnlContent)
        {
            InitializeComponent();

            try
            {

                this.pnlContent = pnlContent;
                this.defaultControl();
                this.LoadDokterAsync();
                this.LoadVperawatAsync(Helper.Ruangrawat.ruangrawatid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPeriksaFisik(ref Panel pnlContent)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FPeriksaFisik_Load(object sender, EventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {
           
        }

        protected virtual void FPeriksaFisik_Shown(object sender, EventArgs e)
        {
            try
            {
                this.LoadV_pemeriksaanfisikByregistrasiruangrawatidAsync(this.v_Registrasiruangrawat.registrasiruangrawatid, this.v_Registrasiruangrawat.tglmasuk.Value);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPeriksaFisik_Shown()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnAddPeriksa_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tglperiksadateEdit.EditValue ==null)
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
                    pemeriksaanfisikid = (this.listv_Pemeriksaanfisik==null)?(short)-1: ((this.listv_Pemeriksaanfisik.Count==0)?(short)-1: this.listv_Pemeriksaanfisik.FirstOrDefault().pemeriksaanfisikid) ,
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
                    kepala = null, leher = null, dada = null,perut =null, punggung = null,daerahgenetalis=null,
                    extremitas_atas =null,extremitas_bwh=null,terapi=null
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

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Pemeriksaanfisik!=null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah data pemeriksaan fisik, pasien dengan NoRM : "
                        + this.v_Registrasiruangrawat.nocm + ", Nama: "
                        + this.v_Registrasiruangrawat.nama + " akan dihapus?"
                        + "\n[Yes] untuk melanjtkan"
                        + "\n[No] untuk membatalkan", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemovePemeriksaanfisikpasien(new pemeriksaanfisik { pemeriksaanfisikid = this.v_Pemeriksaanfisik.pemeriksaanfisikid });
                        LoadV_pemeriksaanfisikAsync((short)this.v_Pemeriksaanfisik.pemeriksaanfisikid);
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
                this.v_Pemeriksaanfisik = gv1.GetRow(e.FocusedRowHandle) as v_pemeriksaanfisik;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
