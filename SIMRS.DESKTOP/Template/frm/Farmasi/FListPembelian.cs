using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi
{
    public partial class FListPembelian : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;
        public FListPembelian()
        {
            InitializeComponent();
        }

        public FListPembelian(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            //periodedateEdit.EditValue = DateTime.Now.Date;
        }

        protected virtual void periodedateEdit_EditValueChanged(object sender, EventArgs e)
        {
            //var value = (((DateTime)periodedateEdit.EditValue).Month);
        }

        protected virtual void FListPembelian_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FListPembelian_Shown(object sender, EventArgs e)
        {

        }

        protected virtual  void GV1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void GV1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void GV1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void cariDataMTxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gcGudang_Click(object sender, EventArgs e)
        {

        }

        protected virtual void aktifPeriodeCheck_Click(object sender, EventArgs e)
        {

        }

        protected virtual void gvGudang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gvGudang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(new Point(  btnMenu.Location.X+184 , btnMenu.Location.Y + 92));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void periodeJenisObatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void cariDataMTxt2_Click(object sender, EventArgs e)
        {
            
        }

        //bool klik;
        private void cariDataMTxt2_ButtonClick(object sender, EventArgs e)
        {
            
        }

        protected virtual void filtercbo_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void aktifFilterJenisObatCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
