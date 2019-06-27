using SIMRS.DESKTOP.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FEditStockOP : FAddStockOP
    {
        #region private method

        private void defaultControl()
        {
            this.lblHeader.Text = "List Stock -> Add/Remove Stock";
        }

        #endregion private method
        public FEditStockOP(ref Panel pnlContent): base (ref pnlContent)
        {
            try
            {
                defaultControl();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FEditStockOP()", this.Name, this);

            }
        }
    }
}
