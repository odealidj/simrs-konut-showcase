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
    

    public partial class FAddTarifPasien2 : MetroFramework.Forms.MetroForm
    {

        protected Panel pnlContent;

        public delegate void LoadPelayananpasienHandler();
        public LoadPelayananpasienHandler DelegateMethodPelayananpasien;

        protected short penjaminid, kelasid, ruangrawatid;

        protected v_registrasiruangrawat Vregistrasiruangrawat;

        protected v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang;

        protected v_tarif v_Tarif;

        protected v_tindakanpoli v_Tindakanpoli;

        protected v_tindakanpenunjang v_Tindakanpenunjang;

        protected int indexSelectedRowTarif = -1;

        protected int indexSelectedRowTindakan = -1;

        #region private method control
        private void defaultControl()
        {
            this.tgltindakanDateEdit.EditValue = DateTime.Now;

            int[] elems = new int[1000];
            for (int i = 0; i <= elems.Length - 1; i++)
            {
                elems[i] = i + 1;
            }
            jmlCboEdit.Properties.DataSource = elems;// .Items.AddRange(elems);
            jmlCboEdit.EditValue = 1;

            //this.tindakanMtxt.Enabled = false;
            this.totalMtxt.Text = "0";
            this.totalMtxt.Enabled = false;

            jenistarifLookUpEdit.Visible = true;


            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref jenistarifLookUpEdit,
               new string[] { "jenistarifid", "jenistarifnm", "penjaminpasienid" },
               new string[] { "Kode", "Nama", "penjaminpasienid" },
               new bool[] { true, true, false },
               "jenistarifnm", "jenistarifid", "Pilih jenis tarif");

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
            //jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);

        }


        private async void LoadVjenistarifpenjaminByPenjaminIdAsync(short penjaminid)
        {
            try
            {
                using (var service = new ListTindakanPasienServices())
                {
                    var result = await service.SelectVjenistarifpenjaminByPenjaminIdAsync(penjaminid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        jenistarifLookUpEdit.Properties.DataSource = result.Item1;
                        //jenistarifCboEdit.DataBindings.Add( tarifGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadVjenistarifpenjaminByPenjaminId(short penjaminid)
        {
            try
            {
                using (var service = new ListTindakanPasienServices())
                {
                    var result = service.SelectVjenistarifpenjaminByPenjaminId(penjaminid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        jenistarifLookUpEdit.Properties.DataSource = result.Item1;
                        //jenistarifCboEdit.DataBindings.Add( tarifGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected int AddPelayananPasien(pelayananpasien obj)
        {
            int result;
            try
            {
                using (var service = new ListTindakanPasienServices())
                {
                    result = service.InsertPelayananPasien(obj);

                }
            }

            catch (Exception ex)
            {
                result = -99;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        protected int RemovePelayananPasien(pelayananpasien obj)
        {
            using (var service = new ListTindakanPasienServices())
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


        protected async void LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan)
        {
            try
            {
                using (var service = new TarifServices())
                {
                    var result = await service.SelectVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(penjaminid, kelasid, ruangrawatid, jenistarifid, tindakan);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        tarifGC.DataSource = result.Item1;
                        //if (result.Item1 != null)

                        //   tarifGC.Visible = true;
                        //else
                        // tarifGC.Visible = false;

                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid)
        {
            try
            {
                using (var service = new TarifServices())
                {
                    var result = await service.SelectTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(penjaminid, kelasid, ruangrawatid, jenistarifid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        tarifGC.DataSource = result.Item1;
                        ////if (result.Item1 != null)

                        ////    tarifGC.Visible = true;
                        ////else
                        ////    tarifGC.Visible = false;

                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        protected virtual void tindakabbuttonEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (jenistarifLookUpEdit.EditValue != null)
                {
                    tarifGC.Visible = true;
                    if (string.IsNullOrEmpty(tindakabbuttonEdit.Text))
                    {
                        LoadTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()));
                    }
                    else
                    {
                        LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()), (tindakabbuttonEdit.EditValue != null) ? tindakabbuttonEdit.EditValue.ToString() : string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakabbuttonEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void tarifGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Tarif = tarifGV.GetRow(e.FocusedRowHandle) as v_tarif;
                if (v_Tarif != null)
                {
                    this.indexSelectedRowTarif = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedRowTarif = -1;
                }


            }
            catch (Exception ex)
            {
                this.indexSelectedRowTarif = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void tarifGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void tarifGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void bSave_Click(object sender, EventArgs e)
        {

        }

        
        protected v_tarif Vtarif;


        public FAddTarifPasien2()
        {
            

            InitializeComponent();

            try
            {

                Helper.CommonFuncControl.ClearControlInWindowsMetroForm(this);
                defaultControl();

                LoadDokterAsync();
                LoadVperawatAsync(this.Vregistrasiruangrawat.ruangrawatid.Value);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddTarifPasien2", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FAddTarifPasien2(ref Panel pnlContent, ref short penjaminid, ref short kelasid, ref short ruangrawatid)
        {
            
            InitializeComponent();
            try
            {
                this.penjaminid = penjaminid; this.kelasid = kelasid; this.ruangrawatid = ruangrawatid;

                this.pnlContent = pnlContent;

                Helper.CommonFuncControl.ClearControlInWindowsMetroForm(this);
                defaultControl();

                //LoadVjenistarifpenjaminByPenjaminIdAsync(this.penjaminid);

                LoadDokterAsync();
                LoadVperawatAsync(this.Vregistrasiruangrawat.ruangrawatid.Value);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddTarifPasien2", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FAddTarifPasien2(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat)
        {
           
            InitializeComponent();
            try
            {

                this.pnlContent = pnlContent;
                this.Vregistrasiruangrawat = Vregistrasiruangrawat;

                this.penjaminid = this.Vregistrasiruangrawat.penjaminpasienid.Value; this.kelasid = this.Vregistrasiruangrawat.kelasid.Value; this.ruangrawatid = this.Vregistrasiruangrawat.ruangrawatid.Value;


                Helper.CommonFuncControl.ClearControlInWindowsMetroForm(this);
                defaultControl();

                //LoadVjenistarifpenjaminByPenjaminIdAsync(this.penjaminid);

                LoadDokterAsync();
                LoadVperawatAsync(this.Vregistrasiruangrawat.ruangrawatid.Value);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddTarifPasien2", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FAddTarifPasien2(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang)
        {

            InitializeComponent();
            try
            {

                this.pnlContent = pnlContent;
                this.v_Registrasiruangrawat_Penunjang = v_Registrasiruangrawat_Penunjang;

                this.penjaminid = this.v_Registrasiruangrawat_Penunjang.penjaminpasienid.Value;
                this.kelasid = this.v_Registrasiruangrawat_Penunjang.kelasid.Value;
                this.ruangrawatid = this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value;


                Helper.CommonFuncControl.ClearControlInWindowsMetroForm(this);
                defaultControl();

                //LoadVjenistarifpenjaminByPenjaminIdAsync(this.penjaminid);

                LoadDokterAsync();
                LoadVperawatAsync(this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddTarifPasien2", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected virtual void FAddTarifPasien2_Shown(object sender, EventArgs e)
        {
           
        }

        protected virtual void FAddTarifPasien2_Load(object sender, EventArgs e)
        {
            try
            {

                LoadVjenistarifpenjaminByPenjaminId(this.penjaminid);

                jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);
                //LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()), string.Empty);
                jenistarifLookUpEdit.Visible = false;



            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ncaridataMTxt_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void tindakabbuttonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Enter))
                {
                    tarifGV.Focus();
                    tarifGV.FocusedRowHandle = 0;
                    tarifGV.SelectRow(0);
                }

                if (e.KeyCode == Keys.Escape)
                {
                    tindakabbuttonEdit.Text = string.Empty;
                    tarifGC.Visible = false;
                    jmlCboEdit.EditValue = 1;
                    totalMtxt.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakabbuttonEdit_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void tarifGV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.v_Tarif = tarifGV.GetRow(this.indexSelectedRowTarif) as v_tarif;
                    if (this.v_Tarif == null) return;
                    tindakabbuttonEdit.EditValue = this.v_Tarif.daftartindakannm;

                    //jmlCboEdit.SelectionStart = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length + 1 : 1;
                    jmlCboEdit.SelectionLength = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length : 0;
                    totalMtxt.Text = (this.v_Tarif.biaya * ((jmlCboEdit.EditValue != null) ? (int)jmlCboEdit.EditValue : 1)).ToString();
                    tarifGC.Visible = false;
                    jmlCboEdit.Focus();
                    tarifGC.Visible = false;
                    //tarifGC.SendToBack();
                }
            }
            catch (Exception ex)
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (this.v_Tarif.biaya).ToString();

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void jmlCboEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (v_Tarif.biaya * ((jmlCboEdit.EditValue != null) ? ((jmlCboEdit.EditValue.ToString() != string.Empty) ? (int)jmlCboEdit.EditValue : 1) : 1)).ToString();
            }
            catch (Exception ex)
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (this.v_Tarif.biaya).ToString();

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\njmlCboEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void jmlCboEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Down)) bSave.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\njmlCboEdit_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void tindakabbuttonEdit_Enter(object sender, EventArgs e)
        {

        }

        protected virtual void tindakabbuttonEdit_Leave(object sender, EventArgs e)
        {

        }

        private void dokterLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            tarifGC.Visible = false;
            if (dokterLookUpEdit.EditValue!=null)
            {
                if (e.KeyCode == Keys.Enter) perawatLookUpEdit.Focus();
            }
        }

        private void perawatLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            tarifGC.Visible = false;
            if (perawatLookUpEdit.EditValue != null)
            {
                if (e.KeyCode == Keys.Enter) tindakabbuttonEdit.Focus();
            }
        }

        protected virtual void tindakabbuttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tindakabbuttonEdit.Text))
                {
                    tarifGC.Visible = true;
                    LoadTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakabbuttonEdit_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void tarifGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.v_Tarif = tarifGV.GetRow(this.indexSelectedRowTarif) as v_tarif;
                if (this.v_Tarif == null) return;
                tindakabbuttonEdit.EditValue = this.v_Tarif.daftartindakannm;

                //jmlCboEdit.SelectionStart = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length + 1 : 1;
                jmlCboEdit.SelectionLength = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length : 0;
                totalMtxt.Text = (this.v_Tarif.biaya * ((jmlCboEdit.EditValue != null) ? (int)jmlCboEdit.EditValue : 1)).ToString();
                tarifGC.Visible = false;
                jmlCboEdit.Focus();
                tarifGC.Visible = false;
                //tarifGC.SendToBack();

            }
            catch (Exception ex)
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (this.v_Tarif.biaya).ToString();

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            tarifGC.Visible = false;
        }

        private void tgltindakanDateEdit_Click(object sender, EventArgs e)
        {
            tarifGC.Visible = false;
        }

        private void dokterLookUpEdit_Click(object sender, EventArgs e)
        {
            tarifGC.Visible = false;
        }

        private void perawatLookUpEdit_Click(object sender, EventArgs e)
        {
            tarifGC.Visible = false;
        }

        private void tindakanGC_Click(object sender, EventArgs e)
        {
            tarifGC.Visible = false;
        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void tindakanGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.indexSelectedRowTindakan = e.RowHandle;
        }

        private void tindakanGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.indexSelectedRowTindakan = e.RowHandle;
        }

        private void totalMtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(totalMtxt.Text))
                {
                    if (totalMtxt.Text=="0")
                        totalMtxt.Text = "0";
                    else
                        totalMtxt.Text = decimal.Parse(totalMtxt.Text).ToString("#,##");
                }
                else
                {
                    //totalMtxt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\totalMtxt_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

       
    }
}
