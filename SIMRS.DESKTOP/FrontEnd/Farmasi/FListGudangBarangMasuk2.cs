using SIMRS.DESKTOP.Template.frm.Farmasi;
using SIMRS.DESKTOP.Template.frm.Farmasi.Pembelian;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi
{
    public class FListGudangBarangMasuk2 : TFListPembelian2
    {
        protected v_aptstockopgudang v_Aptstockopgudang;
        protected int indexSelectedaptstockopgudang = -1;

        #region private method control

        private void LoadAll_v_aptstockopgudangByYearAndMonth(short year, short month)
        {
            try
            {
                using (var service = new ListaptstockopgudangServices())
                {
                    var result = service.SelectAll_v_aptstockopgudangByYearAndMonth(year, month);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc2.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAll_v_aptstockopgudangByYearAndMonthAndKet(string value)
        {
            try
            {
                using (var service = new ListaptstockopgudangServices())
                {
                    var result = service.SelectAll_v_aptstockopgudangByYearAndMonthAndKet(value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc2.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAll_v_aptstockopgudang()
        {
            try
            {
                using (var service = new ListaptstockopgudangServices())
                {
                    var result = service.SelectAll_v_aptstockopgudang();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc2.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void defaultControl()
        {
            this.Text = "List Barang Masuk - Gudang";
            this.vaptpembelianGC.Visible = false;
            this.gc2.Visible = true;
            this.gcDistribusi.Visible = false;
        }

        #endregion private method control

        public FListGudangBarangMasuk2(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.Text = "List Barang Masuk - Gudang";

            

            defaultControl();
            //LoadAptdef1brgAsync();

        }

        public FListGudangBarangMasuk2(ref Panel pnlContent, int indexSelectedaptstockopgudang) : base(ref pnlContent)
        {
            this.Text = "List Barang Masuk - Gudang";

            

            defaultControl();
            //LoadAptdef1brgAsync();
            this.indexSelectedaptstockopgudang = indexSelectedaptstockopgudang;
        }



        protected override void FListPembelian2_Load(object sender, EventArgs e)
        {
            try
            {
                //Load_v_aptpembelianByYearAndMonth(DateTime.Now.Year.ToString());
                //periodedateEdit.EditValue = DateTime.Now.Date;
                LoadAll_v_aptstockopgudangByYearAndMonthAndKet(DateTime.Now.Year.ToString());
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListPembelian2_Shown(object sender, EventArgs e)
        {
            try
            {
                gc2.Focus();
                gv2.ClearSelection();
                if (this.indexSelectedaptstockopgudang == -1) this.indexSelectedaptstockopgudang = 0;
                gv2.Focus();
                gv2.SelectRow(this.indexSelectedaptstockopgudang);
                gv2.FocusedRowHandle = this.indexSelectedaptstockopgudang;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListPembelian_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gv2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gv2.DataRowCount == 1)
                {
                    this.v_Aptstockopgudang = gv2.GetRow(0) as v_aptstockopgudang;
                    //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
                    this.indexSelectedaptstockopgudang = 0;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedaptstockopgudang = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gv2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Aptstockopgudang = gv2.GetRow(e.FocusedRowHandle) as v_aptstockopgudang;
                if (this.v_Aptstockopgudang != null)
                {
                    //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
                    this.indexSelectedaptstockopgudang = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedaptstockopgudang = -1;
                }

            }
            catch (Exception ex)
            {
                this.indexSelectedaptstockopgudang = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FDetailGudangBarangMasuk myForm = new FDetailGudangBarangMasuk(ref this.pnlContent, this.v_Aptstockopgudang);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
