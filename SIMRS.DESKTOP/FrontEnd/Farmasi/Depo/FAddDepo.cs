using SIMRS.DESKTOP.Template.frm.Farmasi.Depo;
using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Depo
{
    public class FAddDepo : FAddEditDepo
    {

        protected string SaveUpdateAptDepo(aptdepo obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptdepoServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.InsertUpdateAptdepo(obj);

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


        public FAddDepo() : base()
        {
            this.Text = "Add Depo";
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty( this.namadepoTxt.Text))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Nama PBF tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.namadepoTxt.Focus();
                    return;
                }

                aptdepo apt = new aptdepo {
                    aptdepoid = -1,
                    aptdeponm = this.namadepoTxt.Text
                };

                var errResult = SaveUpdateAptDepo(apt) ;
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
