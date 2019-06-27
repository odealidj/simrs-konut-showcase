using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi.Pembelian
{
    public partial class TFListPembelianDetail : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        
        public TFListPembelianDetail()
        {
            InitializeComponent();
        }

        public TFListPembelianDetail(ref Panel pnlContent) 
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
           

        }

        protected virtual void FListPembelianDetail_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FListPembelianDetail_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void vaptpembeliandetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void vaptpembeliandetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void bBack_Click(object sender, EventArgs e)
        {

        }
    }
}
