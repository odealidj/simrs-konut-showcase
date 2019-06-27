using MetroFramework.Controls;
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
    public partial class TFAddEditPembelian : Form
    {
        protected Panel pnlContent;
        public TFAddEditPembelian()
        {
            InitializeComponent();
            this.dppTxt.Text = "0";
            this.ppnTxt.Text = "0";
            this.biayakirimTxt.Text = "0";
            this.biayaMateraiTxt.Text = "0";
            this.jmlTagihanTxt.Text = "0";
        }

        public TFAddEditPembelian(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;

            this.dppTxt.Text = "0";
            this.ppnTxt.Text = "0";
            this.biayakirimTxt.Text = "0";
            this.biayaMateraiTxt.Text = "0";
            this.jmlTagihanTxt.Text = "0";
        }

        protected virtual void bBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bSimpan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bBatal_Click(object sender, EventArgs e)
        {

        }

        protected virtual void FAddEditPembelian_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FAddEditPembelian_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void pbfLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void itembarangGV_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        protected virtual void itembarangGV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        
        private void dppTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty((sender as MetroTextBox).Text))
                {
                    if (decimal.Parse((sender as MetroTextBox).Text) != 0)
                        (sender as MetroTextBox).Text = decimal.Parse((sender as MetroTextBox).Text).ToString("#,#.00");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\ndppTxt_Leave()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ppnTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty((sender as MetroTextBox).Text))
                {
                    if (decimal.Parse((sender as MetroTextBox).Text) != 0)
                        (sender as MetroTextBox).Text = decimal.Parse((sender as MetroTextBox).Text).ToString("#,#.00");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nppnTxt_Leave()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void biayakirimTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty((sender as MetroTextBox).Text))
                {
                    if (decimal.Parse((sender as MetroTextBox).Text) != 0)
                        (sender as MetroTextBox).Text = decimal.Parse((sender as MetroTextBox).Text).ToString("#,#");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbiayakirimTxt_Leave()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void biayaMateraiTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty((sender as MetroTextBox).Text))
                {
                    if (decimal.Parse((sender as MetroTextBox).Text) != 0)
                        (sender as MetroTextBox).Text = decimal.Parse((sender as MetroTextBox).Text).ToString("#,#");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbiayaMateraiTxt_Leave()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void jmlTagihanTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty((sender as MetroTextBox).Text))
                {
                    if (decimal.Parse((sender as MetroTextBox).Text) != 0)
                        (sender as MetroTextBox).Text = decimal.Parse((sender as MetroTextBox).Text).ToString("#,#.00");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\njmlTagihanTxt_Leave()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected virtual void itembarangGV_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

        }

        private void dppTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty((sender as MetroTextBox).Text))
                {
                    if (decimal.Parse((sender as MetroTextBox).Text) != 0)
                    {
                        var dpp = decimal.Parse((sender as MetroTextBox).Text);
                        var ppn = dpp * (decimal.Parse(this.ppnpersenTxt.Text)/100);
                        this.ppnTxt.Text = ppn==0?"0": ppn.ToString("#,#.00");
                        if (!String.IsNullOrEmpty(this.biayakirimTxt.Text))
                        {
                            this.jmlTagihanTxt.Text = (dpp + ppn + decimal.Parse(this.biayakirimTxt.Text)).ToString("#,#.00");
                        }
                        if ((!String.IsNullOrEmpty(this.biayakirimTxt.Text)) &&(!String.IsNullOrEmpty(this.biayaMateraiTxt.Text)))
                        {
                            this.jmlTagihanTxt.Text = (dpp + ppn + decimal.Parse(this.biayakirimTxt.Text) + decimal.Parse(this.biayaMateraiTxt.Text)).ToString("#,#.00");
                        }
                    }
                    else
                    {
                        this.biayaMateraiTxt.Text = "0";
                        this.biayakirimTxt.Text = "0";
                        this.jmlTagihanTxt.Text = "0";

                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndppTxt_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        protected virtual void itembarangGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void itembarangGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected virtual void itembarangGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected virtual void itembarangGV_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

        }

        //protected virtual void itembarangGV_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{

        //}

        protected virtual void satuanrepositoryItemLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        protected virtual void satuanrepositoryItemLookUpEdit_Popup(object sender, EventArgs e)
        {

        }

        private void qtyrepositoryItemTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
                //&&
                  //  (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        protected virtual void bAddRow_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void itembarangGV_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

        }

        protected virtual void itembarangGV_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            
        }

        private void MetroLabel10_Click(object sender, EventArgs e)
        {

        }

        protected virtual void ItembarangGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        protected virtual void ItembarangGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

        }
    }
}
