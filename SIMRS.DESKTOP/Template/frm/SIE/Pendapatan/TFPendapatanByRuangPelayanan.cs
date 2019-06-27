using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.SIE.Pendapatan
{
    public partial class TFPendapatanByRuangPelayanan : DevExpress.XtraEditors.XtraForm
    {
        protected Panel pnlContent;
        public TFPendapatanByRuangPelayanan()
        {
            InitializeComponent();
        }

        public TFPendapatanByRuangPelayanan(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }
    }
}
