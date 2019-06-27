using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.FObatSatuan
{
    public class FEditObatSatuan : FAddObatSatuan
    {
        private v_aptbarangsatuan_pbf v_Aptbarangsatuan_Pbf = null;
        public FEditObatSatuan(ref v_aptbarang v_Aptbarang, ref v_aptbarangsatuan_pbf v_Aptbarangsatuan_Pbf) : base(ref v_Aptbarang)
        {
            try
            {
                this.Text = "Edit Defenisi Satuan Obat/BHP";
                this.v_Aptbarangsatuan_Pbf = v_Aptbarangsatuan_Pbf;

                this.pbfLookUpEdit.EditValue = this.v_Aptbarangsatuan_Pbf.aptpbfid;
                this.satuankecilLookUpEdit.EditValue = this.v_Aptbarangsatuan_Pbf.satuankecilkode;
                this.jmlsatuankecilTxt.Text = this.v_Aptbarangsatuan_Pbf.jmlsatuankecil.ToString();
                this.satuanbesarLookUpEdit.EditValue = this.v_Aptbarangsatuan_Pbf.satuanbesarkode;
                this.jmlsatuanbesarTxt.Text = this.v_Aptbarangsatuan_Pbf.jmlsatuanbesar.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
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

                if (string.IsNullOrEmpty(this.jmlsatuanbesarTxt.Text))
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

                aptbarangsatuan apt = new aptbarangsatuan
                {
                    aptbarangsatuanid = this.v_Aptbarangsatuan_Pbf.aptbarangsatuanid ,
                    aptbarangid = short.Parse( this.pbfLookUpEdit.EditValue.ToString()),
                    aptpbfid = this.v_Aptbarangsatuan_Pbf.aptpbfid,
                    satuankecilkode = this.satuankecilLookUpEdit.EditValue.ToString(),
                    jmlsatuankecil = short.Parse(this.jmlsatuankecilTxt.Text),
                    satuanbesarkode = this.satuanbesarLookUpEdit.EditValue.ToString(),
                    jmlsatuanbesar = short.Parse(this.jmlsatuanbesarTxt.Text)

                };

                aptbarangsatuantrigger aptkecil = new aptbarangsatuantrigger
                {
                    aptbarangsatuantriggerid = -1,
                    aptbarangsatuanid = this.v_Aptbarangsatuan_Pbf.aptbarangsatuanid,
                    aptsatuankode = this.satuankecilLookUpEdit.EditValue.ToString(),
                    qty = short.Parse(this.jmlsatuankecilTxt.Text),
                    stskb = "K"
                };

                aptbarangsatuantrigger aptbesar = new aptbarangsatuantrigger
                {
                    aptbarangsatuantriggerid = -1,
                    aptbarangsatuanid = this.v_Aptbarangsatuan_Pbf.aptbarangsatuanid,
                    aptsatuankode = this.satuanbesarLookUpEdit.EditValue.ToString(),
                    qty = short.Parse(this.jmlsatuanbesarTxt.Text),
                    stskb = "B"
                };

                var result = this.SaveUpdateAptBarangsatuan(apt, aptkecil, aptbesar);
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
    }
}
