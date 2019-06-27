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
    public class FListGudangBarangMasuk : FListBarangMasuk
    {

        protected v_aptstockopgudang v_Aptstockopgudang; 
        protected int indexSelectedstockgudang = -1;

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
                        gcGudang.DataSource = result.Item1;
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
                        gcGudang.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(short aptbarangmasukid, string search)
        {
            try
            {
                using (var service = new ListaptstockopgudangServices())
                {
                    var result = service.SelectAll_v_aptstockopgudangdetailByAptstockopgudangId(aptbarangmasukid, search);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gcGudangDetail.DataSource = result.Item1;
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
            this.filtercbo.Properties.DisplayMember = "aptdef1singkatan";
            this.filtercbo.Properties.ValueMember = "aptdef1kode";


            this.aktifPeriodeCheck.Checked = true;
            this.periodedateEdit.Enabled = false;

            cariDataMTxt1.BringToFront();
            cariDataMTxt2.BringToFront();


        }

        #endregion private method control

        public FListGudangBarangMasuk(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.GC1.Visible = false;
            this.GC2.Visible = false;
            this.gcGudang.Visible = true;
            this.gcGudangDetail.Visible = true;

            this.Text = "List Barang Masuk - Gudang";

            defaultControl();
            LoadAptdef1brgAsync();
        }

        protected override void FListPembelian_Load(object sender, EventArgs e)
        {
            try
            {
                //Load_v_aptpembelianByYearAndMonth((short)periodedateEdit.DateTime.Year, (short)periodedateEdit.DateTime.Month);
                periodedateEdit.EditValue = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListPembelian_Shown(object sender, EventArgs e)
        {
            try
            {
                gvGudang.Focus();
                gvGudang.ClearSelection();
                gvGudang.SelectRow(0);
                gvGudang.FocusedRowHandle = 0;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListPembelian_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gvGudang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                this.v_Aptstockopgudang = gvGudang.GetRow(e.FocusedRowHandle) as v_aptstockopgudang;
                if (this.v_Aptstockopgudang != null)
                {
                    LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(this.v_Aptstockopgudang.aptbarangmasukid, string.Empty);
                    this.indexSelectedstockgudang = e.FocusedRowHandle;
                }
                else
                {
                    gcGudangDetail.DataSource = null;
                    this.indexSelectedstockgudang = -1;
                }

            }
            catch (Exception ex)
            {
                this.indexSelectedstockgudang = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void gvGudang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gvGudang.DataRowCount == 1)
                {
                    this.v_Aptstockopgudang = gvGudang.GetRow(0) as v_aptstockopgudang;
                    LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(this.v_Aptstockopgudang.aptstockopgudangid, string.Empty);
                    this.indexSelectedstockgudang = 0;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedstockgudang = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void periodedateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (periodedateEdit.Enabled == true)
                {
                    LoadAll_v_aptstockopgudangByYearAndMonth((short)periodedateEdit.DateTime.Year, (short)periodedateEdit.DateTime.Month);
                }
                else
                {
                    LoadAll_v_aptstockopgudang();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nperiodedateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void cariDataMTxt2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (this.v_Aptstockopgudang != null)
                {

                    LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(this.v_Aptstockopgudang.aptbarangmasukid, cariDataMTxt2.Text);


                }


            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariDataMTxt2_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void aktifPeriodeCheck_Click(object sender, EventArgs e)
        {
            if (aktifPeriodeCheck.Checked == true)
            {
                periodedateEdit.Enabled = false;
                periodedateEdit.EditValue = null;
            }
            else
            {
                periodedateEdit.Enabled = true;
                periodedateEdit.EditValue = DateTime.Now.Date;
            }
        }

    }
}
