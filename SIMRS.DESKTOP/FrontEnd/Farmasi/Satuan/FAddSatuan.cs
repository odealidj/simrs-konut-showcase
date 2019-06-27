using SIMRS.DESKTOP.Template.frm.Farmasi.Depo;
using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Satuan
{
    public class FAddSatuan : FAddEditDepo
    {

        protected string SaveUpdateAptSatuan(aptsatuan obj,string newsatuan)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptsatuanServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.InsertUpdateAptsatuan(obj, newsatuan);

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

        public FAddSatuan():base ()
        {
            this.Text = "Add Satuan";
            this.namadepoLbl.Text = "Nama Satuan";
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
                    aptsatuankode = this.namadepoTxt.Text
                                   };

                var errResult = SaveUpdateAptSatuan(apt,string.Empty);
                if (string.IsNullOrEmpty(errResult))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
    }
}
