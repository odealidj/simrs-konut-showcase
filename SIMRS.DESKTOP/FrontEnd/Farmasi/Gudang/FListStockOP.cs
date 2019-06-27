using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FListStockOP : TFLIstStockOP
    {
        #region private method

        private void LoadAllv_aptstockkontrolAsync()
        {
            try
            {
                using (var service = new AptStockOPServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAll_v_aptstockkontrol());

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllv_aptstockkontrolAsync", this.Name, this);

                    }
                    else
                    {
                        this.liststockkontrolGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllv_aptstockkontrolAsync", this.Name, this);
            }
        }

        private void defaultControl()
        {
            this.lblHeader.Text = "List Stock Kontrol";
            
        }

        #endregion private method
        public FListStockOP (ref Panel pnlContent) : base(ref pnlContent)
        {
            defaultControl();
        }

        protected override void BAdd_Click(object sender, EventArgs e)
        {
            try
            {


                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FAddStockOP myForm = new FAddStockOP(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Add_Click()", this.Name, this);

            }
        }

        protected override void BEdit_Click(object sender, EventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FEditStockOP myForm = new FEditStockOP(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Add_Click()", this.Name, this);

            }
        }

        protected override void BDelete_Click(object sender, EventArgs e)
        {

        }

        protected override void TFLIstStockOP_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllv_aptstockkontrolAsync();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFLIstStockOP_Load()", this.Name, this);

            }
        }

        protected override void TFLIstStockOP_Shown(object sender, EventArgs e)
        {

        }

        protected override void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void StockopListBoxControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void ListstockkontrolGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                int stsisonline = Convert.ToInt32(this.liststockkontrolGV.GetRowCellValue(e.RowHandle, "stsisonline"));
                if (e.Column.FieldName == "stsisonline")
                {
                    if (stsisonline != 1)
                    {


                        e.Appearance.BackColor = Helper.CustomColor.IsDangerColor();
                        e.Appearance.ForeColor = Helper.CustomColor.IsDangerColor();
                        e.Column.ToolTip = "Belum masuk stock kontrol";

                    }
                    else
                    {
                        e.Appearance.BackColor = Helper.CustomColor.IsSuccesColor();
                        e.Appearance.ForeColor = Helper.CustomColor.IsSuccesColor();
                        e.Column.ToolTip = "Sudah masuk stock kontrol";
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "VaptpembelianGV_CustomDrawCell()", this.Name, this);
            }

        }
    }
}
