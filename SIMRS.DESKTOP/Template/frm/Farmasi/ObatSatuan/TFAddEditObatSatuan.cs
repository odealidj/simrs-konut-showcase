using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi.ObatSatuan
{
    public partial class TFAddEditObatSatuan : MetroFramework.Forms.MetroForm
    {
        protected v_aptbarang v_Aptbarang = null;
        private void defaultsetinglookupedit()
        {


            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref this.pbfLookUpEdit,
               new string[] { "aptpbfid", "aptpbfnm" },
               new string[] { "Kode PBF", "NAMA PBF" },
               new bool[] { false, true },
               "aptpbfnm", "aptpbfid", "Pilih PBF ...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref this.satuankecilLookUpEdit,
               new string[] { "aptsatuankode" },
               new string[] { "Kode Satuan" },
               new bool[] { true },
               "aptsatuankode", "aptsatuankode", "Pilih satuan ...");

            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref this.satuanbesarLookUpEdit,
                          new string[] { "aptsatuankode" },
                          new string[] { "Kode Satuan" },
                          new bool[] { true },
                          "aptsatuankode", "aptsatuankode", "Pilih satuan ...");


        }

        protected void LoadAptpbfAsync()
        {
            try
            {
                using (var service = new AptpbfServices())
                {
                    var result = Task.Run(() => service.SelectAllAptpbfAsync());
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.pbfLookUpEdit.Properties.DataSource = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAlllAptsatuanKecilAsync()
        {
            try
            {
                using (var service = new AptsatuanServices())
                {

                    var result = Task.Run(() => service.SelectAllAptsatuanAsync(string.Empty));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.satuankecilLookUpEdit.Properties.DataSource = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAlllAptsatuanBesarAsync(string aptsatuankode)
        {
            try
            {
                using (var service = new AptsatuanServices())
                {

                    var result = Task.Run(() => service.SelectAllNotInKodeAsync(aptsatuankode));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.satuanbesarLookUpEdit.Properties.DataSource = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAptsatuan(aptsatuan obj)
        {
            try
            {
                using (var service = new AptsatuanServices())
                {

                    var result = service.Get(obj);

                    this.satuanbesarLookUpEdit.Properties.DataSource = result;

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public TFAddEditObatSatuan()
        {
            InitializeComponent();
            try
            {
                defaultsetinglookupedit();
                LoadAptpbfAsync();
                LoadAlllAptsatuanKecilAsync();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public TFAddEditObatSatuan(ref v_aptbarang v_Aptbarang)
        {
            InitializeComponent();
            try
            {
                this.v_Aptbarang = v_Aptbarang;
                defaultsetinglookupedit();
                this.JenisBarangTxt.Text = this.v_Aptbarang.aptdef1singkatan;
                this.namabarangTxt.Text = this.v_Aptbarang.aptbarangnm;
                LoadAptpbfAsync();
                LoadAlllAptsatuanKecilAsync();
                this.jmlsatuankecilTxt.Text = "0";
                this.jmlsatuanbesarTxt.Text = "1";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void satuankecilLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (satuankecilLookUpEdit.EditValue != null)
                {
                    LoadAlllAptsatuanBesarAsync(satuankecilLookUpEdit.EditValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void bSimpan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bBatal_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void FAddEditObatSatuan_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FAddEditObatSatuan_Shown(object sender, EventArgs e)
        {

        }

        private void jmlsatuankecilTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void jmlsatuanbesarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void jmlsatuankecilTxt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(jmlsatuankecilTxt.Text))
            {
                var parse = int.Parse(jmlsatuankecilTxt.Text);
                jmlsatuankecilTxt.Text = parse.ToString("#,0");
            }
        }

        private void jmlsatuanbesarTxt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(jmlsatuanbesarTxt.Text))
            {
                var parse = int.Parse(jmlsatuanbesarTxt.Text);
                jmlsatuanbesarTxt.Text = parse.ToString("#,0");
            }
        }
    }
}
