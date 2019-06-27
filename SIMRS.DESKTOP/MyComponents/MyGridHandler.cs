using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.MyComponents
{
    public class MyGridHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public MyGridHandler(GridView gridView) : base(gridView) { }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Delete && View.State == GridState.Normal)
                View.DeleteRow(View.FocusedRowHandle);
        }
    }
}
