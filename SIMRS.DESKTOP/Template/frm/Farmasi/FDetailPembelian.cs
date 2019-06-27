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
    public partial class FDetailPembelian : MetroFramework.Forms.MetroForm
    {

        protected Panel pnlContent;


        public FDetailPembelian()
        {
            InitializeComponent();
        }

        public FDetailPembelian(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            //periodedateEdit.EditValue = DateTime.Now.Date;
        }

        protected virtual void gvDetailPembelian_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void gvDetailPembelian_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void cariDataMTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void FDetailPembelian_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FDetailPembelian_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void gvDetailPembelian_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void gvGudangBarangKeluar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gvGudangBarangKeluar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void gvDetailPembelian_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gvDetailPembelian_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void gvDetailBarangMasuk_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void gvDetailBarangMasuk_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
    }
}
