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
    public partial class FAddTarifPasien : MetroFramework.Forms.MetroForm
    {
        public delegate void LoadPelayananpasienHandler();
        public LoadPelayananpasienHandler DelegateMethodPelayananpasien;

        protected short penjaminid, kelasid, ruangrawatid;

        protected v_registrasiruangrawat Vregistrasiruangrawat;
        protected v_tarif Vtarif;


        #region private method control
        private void defaultControl()
        {
            this.tgltindakanDateEdit.EditValue = DateTime.Now;

            int[] elems = new int[100];
            for (int i=0; i <= elems.Length-1; i++)
            {
                elems[i] = i+1;
            }
            jmlCboEdit.Properties.Items.AddRange(elems);
            jmlCboEdit.EditValue = 1;

            this.tindakanMtxt.Enabled = false;
            this.totalMtxt.Text = "0";
            this.totalMtxt.Enabled = false;

            jenistarifLookUpEdit.Visible = true;

            
            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref jenistarifLookUpEdit,
               new string[] { "jenistarifid", "jenistarifnm","penjaminpasienid" },
               new string[] { "Kode", "Nama", "penjaminpasienid" },
               new bool[] { true, true,false},
               "jenistarifnm", "jenistarifid", "Pilih jenis tarif");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref dokterLookUpEdit,
               new string[] { "dokterid ", "dokternm"},
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



        #endregion

        protected virtual void FTarif_Load(object sender, EventArgs e)
        {

        }

        protected virtual void tarifGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void caridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void bSave_Click(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FAddTarifPasien()
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nFAddTarifPasien", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FAddTarifPasien(ref short penjaminid, ref short kelasid, ref short ruangrawatid)
        {
           
                InitializeComponent();
            try
            {
                this.penjaminid = penjaminid; this.kelasid = kelasid; this.ruangrawatid = ruangrawatid;
                

                Helper.CommonFuncControl.ClearControlInWindowsMetroForm(this);
                defaultControl();

                //LoadVjenistarifpenjaminByPenjaminIdAsync(this.penjaminid);

                LoadDokterAsync();
                LoadVperawatAsync(this.Vregistrasiruangrawat.ruangrawatid.Value);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\nFAddTarifPasien", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FAddTarifPasien(ref v_registrasiruangrawat Vregistrasiruangrawat)
        {
           
                InitializeComponent();
            try
            {
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\nFAddTarifPasien", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
