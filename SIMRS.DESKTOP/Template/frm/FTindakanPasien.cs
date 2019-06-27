using DevExpress.XtraGrid;
using SIMRS.Model;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.POLI;
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
    public partial class FTindakanPasien : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;


        #region private methode control

        protected int RemovePelayananPasien(pelayananpasien obj)
        {
            using (var service = new ListTindakanPasienServices())
            {
                var result = service.DeletePelayananPasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove tindakan pasien tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        #endregion


        public FTindakanPasien()
        {
            InitializeComponent();


            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref noregistrasiPanel);
            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref normPanel);
            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref kelasPanel);
            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref usiaPanel);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref noregistrasiPanel, true);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref normPanel, true);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref kelasPanel, true);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref usiaPanel, true);
        }

        public FTindakanPasien(ref Panel _pnlContent)
        {
            InitializeComponent();

            this.pnlContent = _pnlContent;

            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref noregistrasiPanel);
            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref normPanel);
            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref kelasPanel);
            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref usiaPanel);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref noregistrasiPanel, true);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref normPanel, true);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref kelasPanel, true);
            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref usiaPanel, true);

            
        }

        protected virtual void addMbtn_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //this.indexSelectedRow = e.FocusedRowHandle;
        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void tindakanGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //this.indexSelectedRow = e.RowHandle;
        }

        private void tindakanGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //this.indexSelectedRow = e.RowHandle;
        }

        private Font font_Renamed = new Font("Arials", 11,FontStyle.Bold);
        private void tindakanGV_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            ////e.Appearance.Font = font_Renamed;
            ////e.Appearance.DrawString(e.Cache, e.Info.DisplayText, e.Bounds);
            ////e.Handled = true;


            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            //string summaryText = String.Format("{0} {1} = {2:c2}", summary.SummaryType, e.Column.GetCaption(), summaryValue);
            string summaryText = String.Format("{0:#,##}",summaryValue);
            e.Appearance.Font = font_Renamed;
            e.Appearance.ForeColor = Color.DarkRed;
            e.Info.DisplayText = summaryText;
        }

        protected virtual void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void FTindakanPasien_Load(object sender, EventArgs e)
        {

        }
    }
}
