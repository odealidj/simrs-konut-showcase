using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FDialogLogoutRegistrasiRJ : TFDialogExit
    {
        public FDialogLogoutRegistrasiRJ()
        {

        }
        public FDialogLogoutRegistrasiRJ(string text)
        {
            this.lblText.Text = text;
        }

        protected override void BOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
