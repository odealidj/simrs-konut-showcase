using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class TFListOneFilter : Form
    {
        private const int _maxPageSize = 100;
        private int _pageSize = 100;

        protected int totalPage = 0;
        protected int PageIndex { get; set; }

        protected int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < _maxPageSize) ? value : _maxPageSize;
            }
        }

        protected Panel pnlContent;
        public TFListOneFilter()
        {
            InitializeComponent();
        }

        public TFListOneFilter(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void FListOneFilter_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FListOneFilter_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void aktifFilterCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected virtual void filtercbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void cariDataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void GV1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void dn1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            
        }

        protected virtual void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void obatGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void obatGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void bAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void defenisiobatGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void editdefenisisatuanrepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void deletedefenisisatuanrepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void BFirst_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BPrev_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BLast_Click(object sender, EventArgs e)
        {

        }
    }
}
