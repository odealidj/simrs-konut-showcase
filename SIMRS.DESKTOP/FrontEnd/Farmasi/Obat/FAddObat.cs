using SIMRS.DESKTOP.Template.frm.Farmasi.Obat;
using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Obat
{
    public class FAddObat : TFAddEditObat
    {

        protected string SaveUpdateAptBarang(aptbarang obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new Aptbarangservices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.InsertUpdateAptbarang(obj);

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

        public FAddObat()
        {
            this.Text = "Add Data Obat/BHP";
        }

        protected override void FAddEditObat_Load(object sender, EventArgs e)
        {

        }

        protected override void FAddEditObat_Shown(object sender, EventArgs e)
        {

        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.jenisLookUpEdit.EditValue==null)
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
                    aptbarangid = -1,
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
