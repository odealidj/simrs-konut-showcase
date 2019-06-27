using SIMRS.DESKTOP.Helper;
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
    public partial class TFListPembelian2 : Form
    {
        protected int sisePage = 25;
        protected int pageNo = 1;

        protected Panel pnlContent;
        public TFListPembelian2()
        {
            InitializeComponent();
        }

        public TFListPembelian2(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            
            //periodedateEdit.EditValue = DateTime.Now.Date;
            
        }

        protected virtual void FListPembelian2_Load(object sender, EventArgs e)
        {

        }

        protected virtual void gv1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gv1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void gv1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void cariDataMTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnMenu_Click(object sender, EventArgs e)
        {

        }

        protected virtual void FListPembelian2_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void gv2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void gv2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gvDistribusi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gvDistribusi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void bAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bFirst_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bPrev_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bLast_Click(object sender, EventArgs e)
        {

        }

        protected virtual void detailpembeianrepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void vaptpembelianGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void vaptpembelianGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void vaptpembelianGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void bBack_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        protected virtual void PeriodeDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void DetailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void VaptpembelianGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

        }

        protected virtual void VaptpembelianGV_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        protected virtual void VaptpembelianGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        protected virtual void DetailnotingudangrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void VaptpembelianNotInGudangGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

        }
    }
}
