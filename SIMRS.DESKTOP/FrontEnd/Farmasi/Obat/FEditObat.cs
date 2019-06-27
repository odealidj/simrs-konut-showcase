using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Obat
{
    public class FEditObat : FAddObat
    {
        private aptbarang Aptbarang = null;
        public FEditObat(aptbarang Aptbarang) : base()
        {
            this.Aptbarang = Aptbarang;
            this.jenisLookUpEdit.EditValue = this.Aptbarang.aptdef1id;
            this.namabarangTxt.Text = this.Aptbarang.aptbarangnm;
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.jenisLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis barang !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.jenisLookUpEdit.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.namabarangTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nama barang tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.namabarangTxt.Focus();
                    return;
                }

                aptbarang apt = new aptbarang
                {
                    aptbarangid = this.Aptbarang.aptbarangid,
                    aptbarangnm = this.namabarangTxt.Text,
                    aptdef1id = this.jenisLookUpEdit.EditValue.ToString()

                };

                var result = this.SaveUpdateAptBarang(apt);
                if (string.IsNullOrEmpty(result))
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
