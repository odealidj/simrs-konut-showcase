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
    public partial class FListThree : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected int indexSeletedRow =-1;
        

        public FListThree()
        {
            InitializeComponent();
        }

        public FListThree(ref Panel _pnlContent)
        {
            InitializeComponent();

            this.pnlContent = _pnlContent;

            usetanggalcheckEdit.Checked = true;
            tanggaldateEdit.EditValue = DateTime.Now.Date;
            pelunasancheckEdit.CheckState = CheckState.Indeterminate;
             
        }

        private void usetanggalcheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (usetanggalcheckEdit.Checked)
            {
                tanggaldateEdit.Enabled = true;
            }
            else
            {
                tanggaldateEdit.Enabled = false;
            }
        }

        private void pelunasancheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            //if (pelunasancheckEdit.CheckState == CheckState.Checked)
            //{
            //    pelunasancheckEdit.Text = "Keluar";
            //}
            //else if (pelunasancheckEdit.CheckState == CheckState.Unchecked)
            //{
            //    pelunasancheckEdit.Text = "Masuk";
            //}
            //else
            //{
            //    pelunasancheckEdit.Text = "All";
            //}
        }

        protected virtual void pelunasancheckEdit_CheckStateChanged(object sender, EventArgs e)
        {
            if (pelunasancheckEdit.CheckState == CheckState.Checked)
            {
                pelunasancheckEdit.Text = "Keluar";
            }
            else if (pelunasancheckEdit.CheckState == CheckState.Unchecked)
            {
                pelunasancheckEdit.Text = "Masuk";
            }
            else
            {
                pelunasancheckEdit.Text = "All";
            }
        }

        protected virtual void tanggaldateEdit_DateTimeChanged(object sender, EventArgs e)
        {

        }

        protected virtual void caridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void usetanggalcheckEdit_CheckStateChanged(object sender, EventArgs e)
        {

        }

        protected virtual void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void detailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void gv_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.indexSeletedRow = e.RowHandle;
        }

        protected virtual void gv_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.indexSeletedRow = e.RowHandle;
        }
    }
}
