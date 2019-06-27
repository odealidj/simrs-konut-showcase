using SIMRS.DESKTOP.Template.frm.Farmasi.Depo;
using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pbf
{
    public class FAddPbf : FAddEditDepo
    {
        protected string SaveUpdateAptPbf(aptpbf obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptpbfServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.InsertUpdateAptpbf(obj);

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
        public FAddPbf(): base()
        {
            this.Text = "Add PBF";
            this.namadepoLbl.Text = "Nama PBF";
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.namadepoTxt.Text))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Nama PBF tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.namadepoTxt.Focus();
                    return;
                }

                aptpbf apt = new aptpbf
                {
                    aptpbfid = -1,
                    aptpbfnm = this.namadepoTxt.Text
                };

                var errResult = SaveUpdateAptPbf(apt);
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


        protected override void FAddEditDepo_Load(object sender, EventArgs e)
        {

        }

        protected override void FAddEditDepo_Shown(object sender, EventArgs e)
        {

        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
