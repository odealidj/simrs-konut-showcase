using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FEditBrgGu : TFEditBrgGu
    {
        private aptbrggu Aptbrggu;
        public FEditBrgGu(ref aptbrggu Aptbrggu ) : base()
        {
            try
            {
                this.Aptbrggu = Aptbrggu;
                if (this.Aptbrggu != null)
                {
                    this.TglMasukGuDateEdit.EditValue = this.Aptbrggu.tglgu;
                    this.ketGuTxt.Text = this.Aptbrggu.ket;
                }
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

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TFEditBrgGu_Load(object sender, EventArgs e)
        {

        }

        private void TFEditBrgGu_Shown(object sender, EventArgs e)
        {

        }


    }
}
