using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Registrasi
{
    public partial class FListReportFilterByDate : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;
        public FListReportFilterByDate()
        {
            InitializeComponent();
        }

        public FListReportFilterByDate(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void FListReportFilterByDate_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FListReportFilterByDate_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnPrint_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tglregistrasiDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
