using SIMRS.DESKTOP.Template.frm.Farmasi.ObatSatuan;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.FObatSatuan
{
    public class FAddObatSatuan : TFAddEditObatSatuan
    {

        protected string SaveUpdateAptBarangsatuan(aptbarangsatuan objsatuan, aptbarangsatuantrigger objkecil, aptbarangsatuantrigger objbesar)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.InsertUpdateAptbarangsatuan(objsatuan, objkecil, objbesar);

                    if (!string.IsNullOrEmpty(errResult))
                    {
                        MetroFramework.MetroMessageBox.Show(this, errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            catch (Exception ex)
            {
                errResult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return errResult;
        }

        public FAddObatSatuan(ref v_aptbarang v_Aptbarang) : base(ref v_Aptbarang)
        {
            this.Text = "Add Defenisi Satuan Obat/BHP";
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(this.JenisBarangTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Jenis Barang tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.JenisBarangTxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.namabarangTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nama Barang tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.namabarangTxt.Focus();
                    return;
                }

                if (this.pbfLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih PBF !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.pbfLookUpEdit.Focus();
                    return;
                }

                if (this.satuankecilLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih satuan kecil !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.satuankecilLookUpEdit.Focus();
                    return;
                }
                if (this.satuanbesarLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih satuan besar !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.satuanbesarLookUpEdit.Focus();
                    return;
                }
                if (string.IsNullOrEmpty( this.jmlsatuanbesarTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Jumlah satuan besar tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.jmlsatuanbesarTxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.jmlsatuankecilTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Jumlah satuan kecil tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.jmlsatuankecilTxt.Focus();
                    return;
                }

                if (satuankecilLookUpEdit.EditValue == satuanbesarLookUpEdit.EditValue)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Satuan kecil dengan Satuan Besar tidak boleh sama !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.satuankecilLookUpEdit.Focus();
                    return;
                }

                if (satuankecilLookUpEdit.Text.Trim().ToLower() == satuanbesarLookUpEdit.Text.Trim().ToLower())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Satuan Kecil dengan Satuan Besar tidak boleh sama !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.satuankecilLookUpEdit.Focus();
                    return;
                }

                aptbarangsatuan aptsatuan = new aptbarangsatuan
                {
                    aptbarangsatuanid = -1,
                    aptbarangid = this.v_Aptbarang.aptbarangid,
                    aptpbfid = short.Parse( this.pbfLookUpEdit.EditValue.ToString()),
                    satuankecilkode = this.satuankecilLookUpEdit.EditValue.ToString(),
                    jmlsatuankecil = short.Parse( this.jmlsatuankecilTxt.Text),
                    satuanbesarkode = this.satuanbesarLookUpEdit.EditValue.ToString(),
                    jmlsatuanbesar = short.Parse(this.jmlsatuanbesarTxt.Text)
                    
                };

                aptbarangsatuantrigger aptkecil = new aptbarangsatuantrigger
                {
                    aptbarangsatuantriggerid = -1,
                    aptbarangsatuanid = -1,
                    aptsatuankode = this.satuankecilLookUpEdit.EditValue.ToString(),
                    qty = short.Parse(this.jmlsatuankecilTxt.Text),
                    stskb = "K"
                };

                aptbarangsatuantrigger aptbesar = new aptbarangsatuantrigger
                {
                    aptbarangsatuantriggerid = -1,
                    aptbarangsatuanid = -1,
                    aptsatuankode = this.satuanbesarLookUpEdit.EditValue.ToString(),
                    qty = short.Parse(this.jmlsatuanbesarTxt.Text),
                    stskb = "B"
                };

                var result = this.SaveUpdateAptBarangsatuan(aptsatuan,aptkecil,aptbesar);
                if (string.IsNullOrEmpty(result))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        protected override void FAddEditObatSatuan_Load(object sender, EventArgs e)
        {

        }

        protected override void FAddEditObatSatuan_Shown(object sender, EventArgs e)
        {
            this.pbfLookUpEdit.Focus();
        }
    }
}
