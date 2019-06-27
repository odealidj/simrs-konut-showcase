using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.RekamMedis
{
    public partial class FListReportFilterByPelayananmedisAndDate : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        public FListReportFilterByPelayananmedisAndDate()
        {
            InitializeComponent();
        }

        public FListReportFilterByPelayananmedisAndDate(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void FListReportFilterByPelayananmedisAndDate_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FListReportFilterByPelayananmedisAndDate_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void pelayananmedisLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void GV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
