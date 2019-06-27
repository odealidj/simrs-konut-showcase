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
    public partial class TFAddEditStockOP : Form
    {
        protected Panel pnlContent;
        public TFAddEditStockOP()
        {
            InitializeComponent();
        }

        public TFAddEditStockOP(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void TFAddEditStockOP_Load(object sender, EventArgs e)
        {

        }

        protected virtual void TFAddEditStockOP_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void BSimpan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BBatal_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BBack_Click(object sender, EventArgs e)
        {

        }
    }
}
