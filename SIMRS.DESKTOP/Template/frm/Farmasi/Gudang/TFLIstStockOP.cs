using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi.Gudang
{
    public partial class TFLIstStockOP : Form
    {
        protected int sisePage = 25;
        protected int pageNo = 1;

        protected Panel pnlContent;
        
        public TFLIstStockOP()
        {
            InitializeComponent();
        }

        public TFLIstStockOP(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void BAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void TFLIstStockOP_Load(object sender, EventArgs e)
        {

        }

        protected virtual void TFLIstStockOP_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void StockopListBoxControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void ListstockkontrolGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }
    }
}
