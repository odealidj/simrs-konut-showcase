using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pbf
{
    public class FEditPbf : FAddPbf
    {
        private aptpbf Aptpbf = null;
        public FEditPbf(aptpbf Aptpbf)
        {
            this.Text = "Edit PBF";
            this.Aptpbf = Aptpbf;
            this.namadepoTxt.Text = this.Aptpbf.aptpbfnm;

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
                    aptpbfid = this.Aptpbf.aptpbfid,
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
    }
}
