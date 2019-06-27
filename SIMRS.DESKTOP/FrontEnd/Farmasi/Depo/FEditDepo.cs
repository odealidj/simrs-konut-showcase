using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Depo
{
    public class FEditDepo : FAddDepo
    {
        private aptdepo Aptdepo = null;
        public FEditDepo(aptdepo Aptdepo) : base()
        {
            this.Text = "Edit Depo";
            this.Aptdepo = Aptdepo;
            this.namadepoTxt.Text = this.Aptdepo.aptdeponm;
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

                aptdepo apt = new aptdepo
                {
                    aptdepoid = this.Aptdepo.aptdepoid,
                    aptdeponm = this.namadepoTxt.Text
                };

                var errResult = SaveUpdateAptDepo(apt);
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
