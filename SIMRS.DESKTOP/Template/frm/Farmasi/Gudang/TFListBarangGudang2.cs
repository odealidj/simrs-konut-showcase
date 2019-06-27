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
    public partial class TFListBarangGudang2 : Form
    {
        protected int sisePage = 25;
        protected int pageNo = 1;

        protected Panel pnlContent;
        public TFListBarangGudang2()
        {
            InitializeComponent();
        }

        public TFListBarangGudang2(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            this.databarangbeliTab.SelectedTabPageIndex = 0;
            //periodedateEdit.EditValue = DateTime.Now.Date;
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

        
        protected virtual void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void TFListBarangGudang2_Load(object sender, EventArgs e)
        {

        }

        protected virtual void TFListBarangGudang2_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void CaridataTxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void PeriodeDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void ListbaranggudangdetailGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        protected virtual void EditrepositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void ListbaranggudangdetailGV_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }
    }
}
