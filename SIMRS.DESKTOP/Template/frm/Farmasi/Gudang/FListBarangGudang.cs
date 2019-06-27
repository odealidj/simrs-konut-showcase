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
    public partial class FListBarangGudang : MetroFramework.Forms.MetroForm
    {
       

        protected int sisePage = 25;
        protected int pageNo = 1;

        protected Panel pnlContent;
        public FListBarangGudang()
        {
            InitializeComponent();
        }

        public FListBarangGudang(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            //periodedateEdit.EditValue = DateTime.Now.Date;
        }

        protected virtual void brgguBandedGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

        protected virtual void brgguBandedGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void listbaranggudangGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void listbaranggudangGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void listbaranggudangdetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void listbaranggudangdetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void sethargarepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void detailhargajualrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
