using SIMRS.DESKTOP.Template.frm.Farmasi;
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
    public class FDetailGudangBarangMasuk : FDetailPembelian
    {
        protected int indexSelectedaptstockopgudang = -1;
        private int indexSelecteddetailaptstockopgudang = -1;
        private v_aptstockopgudang v_Aptstockopgudang;
        private v_aptstockopgudangdetail v_Aptstockopgudangdetail;

        #region private method control

        ////protected async void LoadAptdef1brgAsync()
        ////{
        ////    try
        ////    {
        ////        using (var service = new Aptdef1brgServices())
        ////        {
        ////            var result = await service.SelectAllAptdef1brgAsync();
        ////            if (result.Item2 != null)
        ////            {
        ////                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////                return;
        ////            }
        ////            else
        ////            {
        ////                filtercbo.Properties.DataSource = result.Item1;
        ////            }
        ////        }
        ////    }

        ////    catch (Exception ex)
        ////    {
        ////        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}

        protected void LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(short aptstockopgudangid, string search)
        {
            try
            {
                using (var service = new ListaptstockopgudangServices())
                {
                    var result = service.SelectAll_v_aptstockopgudangdetailByAptstockopgudangId(aptstockopgudangid, search);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gcDetailBarangMasuk.DataSource = result.Item1;
                        
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

            ////SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref filtercbo,
            ////  new string[] { "aptdef1kode", "aptdef1singkatan" },
            ////  new string[] { "KODE", "JENIS" },
            ////  new bool[] { false, true },
            ////  "aptdef1singkatan", "aptdef1kode", "Pilih ...");


            //this.aktifPeriodeCheck.Checked = true;
            //this.periodedateEdit.Enabled = false;

            //this.aktifFilterJenisObatCheck.Checked = true;
            this.gcDetailBarangMasuk.Visible = true;
            this.gcDetailPembelian.Visible = false;
            this.gcGudangBarangKeluar.Visible = false;
        }

        #endregion private method control

        public FDetailGudangBarangMasuk(ref Panel pnlContent, v_aptstockopgudang v_Aptstockopgudang) : base(ref pnlContent)
        {
            this.Text = "Detail Barang Masuk - Gudang";
            this.v_Aptstockopgudang = v_Aptstockopgudang;
            defaultControl();
        }

        public FDetailGudangBarangMasuk(ref Panel pnlContent, v_aptstockopgudang v_Aptstockopgudang, int indexSelectedaptstockopgudang) : base(ref pnlContent)
        {
            this.Text = "Detail Barang Masuk - Gudang";
            this.v_Aptstockopgudang = v_Aptstockopgudang;
            this.indexSelectedaptstockopgudang = indexSelectedaptstockopgudang;
            defaultControl();
        }

        protected override void gvDetailBarangMasuk_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Aptstockopgudangdetail = gvDetailBarangMasuk.GetRow(e.FocusedRowHandle) as v_aptstockopgudangdetail;
                if (this.v_Aptstockopgudangdetail != null)
                {
                    lblSelect.Text = string.Format("Selected => Tgl.Masuk Gudang: {0}, Ket: {1}, Tgl.Beli: {2} ", this.v_Aptstockopgudang.tglmasukgudang.Value.ToString("dd-MM-yyyy"),
                        this.v_Aptstockopgudang.ketgudang,
                        this.v_Aptstockopgudang.tglmasukpembelian.Value.ToString("dd-MM-yyyy"));

                    //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
                    this.indexSelecteddetailaptstockopgudang = e.FocusedRowHandle;
                }
                else
                {
                    lblSelect.Text = string.Empty;
                    this.indexSelecteddetailaptstockopgudang = -1;
                }

            }
            catch (Exception ex)
            {
                //this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gvDetailBarangMasuk_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gvDetailBarangMasuk.DataRowCount == 1)
                {
                    this.v_Aptstockopgudangdetail = gvDetailBarangMasuk.GetRow(0) as v_aptstockopgudangdetail;
                    //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
                    lblSelect.Text = string.Format("Selected => Tgl.Masuk Gudang: {0}, Ket: {1}, Tgl.Beli: {2} ", this.v_Aptstockopgudang.tglmasukgudang.Value.ToString("dd-MM-yyyy"),
                        this.v_Aptstockopgudang.ketgudang,
                        this.v_Aptstockopgudang.tglmasukpembelian.Value.ToString("dd-MM-yyyy"));
                    this.indexSelecteddetailaptstockopgudang = 0;
                }
            }
            catch (Exception ex)
            {
                //this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ngv1_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //protected override void gv1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        if (gvDetailPembelian.DataRowCount == 1)
        //        {
        //            this.v_Aptstockopgudangdetail = gvDetailPembelian.GetRow(0) as v_aptstockopgudangdetail;
        //            //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
        //            lblSelect.Text = string.Format("Selected => Tgl.Masuk Gudang: {0}, Ket: {1}, Tgl.Beli: {2} ", this.v_Aptstockopgudang.tglmasukgudang.Value.ToString("dd-MM-yyyy"),
        //                this.v_Aptstockopgudang.ketgudang,
        //                this.v_Aptstockopgudang.tglmasukpembelian.Value.ToString("dd-MM-yyyy"));
        //            this.indexSelecteddetailaptstockopgudang = 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //this.indexSelectedBarangMasuk = -1;
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ngv1_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //protected override void gv1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    try
        //    {
        //        this.v_Aptstockopgudangdetail = gvDetailPembelian.GetRow(e.FocusedRowHandle) as v_aptstockopgudangdetail;
        //        if (this.v_Aptstockopgudangdetail != null)
        //        {
        //            lblSelect.Text = string.Format("Selected => Tgl.Masuk Gudang: {0}, Ket: {1}, Tgl.Beli: {2} ", this.v_Aptstockopgudang.tglmasukgudang.Value.ToString("dd-MM-yyyy"),
        //                this.v_Aptstockopgudang.ketgudang,
        //                this.v_Aptstockopgudang.tglmasukpembelian.Value.ToString("dd-MM-yyyy"));

        //            //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
        //            this.indexSelecteddetailaptstockopgudang = e.FocusedRowHandle;
        //        }
        //        else
        //        {
        //            lblSelect.Text = string.Empty;
        //            this.indexSelecteddetailaptstockopgudang = -1;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        //this.indexSelectedBarangMasuk = -1;
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ngv1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        protected override void cariDataMTxt1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(this.v_Aptstockopgudang.aptstockopgudangid, cariDataMTxt1.Text);

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariDataMTxt1_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FDetailPembelian_Load(object sender, EventArgs e)
        {
            try
            {

                LoadAll_v_aptstockopgudangdetailByAptstockopgudangId(this.v_Aptstockopgudang.aptstockopgudangid, string.Empty);

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFDetailPembelian_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FDetailPembelian_Shown(object sender, EventArgs e)
        {
            try
            {
                gcDetailPembelian.Focus();
                gvDetailPembelian.ClearSelection();
                if (this.indexSelecteddetailaptstockopgudang == -1) this.indexSelecteddetailaptstockopgudang = 0;
                gvDetailPembelian.Focus();
                gvDetailPembelian.SelectRow(this.indexSelecteddetailaptstockopgudang);
                gvDetailPembelian.FocusedRowHandle = this.indexSelecteddetailaptstockopgudang;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFDetailPembelian_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent, this.indexSelectedaptstockopgudang);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
