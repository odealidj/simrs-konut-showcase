using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Satuan
{
    public class FEditSatuan : FAddSatuan
    {
        private aptsatuan Aptsatuan = null;
        public FEditSatuan(aptsatuan Aptsatuan) :base ()
        {
            this.Aptsatuan = Aptsatuan;
            this.namadepoTxt.Text = this.Aptsatuan.aptsatuankode;
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.namadepoTxt.Text))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Nama Satuan tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.namadepoTxt.Focus();
                    return;
                }

                aptsatuan apt = new aptsatuan
                {
                    aptsatuankode = this.Aptsatuan.aptsatuankode
                };

                var errResult = SaveUpdateAptSatuan(apt, this.namadepoTxt.Text);
                if (string.IsNullOrEmpty(errResult))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
