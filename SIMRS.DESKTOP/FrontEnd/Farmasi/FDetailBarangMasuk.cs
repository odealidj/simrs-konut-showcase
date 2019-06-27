using SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian;
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
    public class FDetailBarangMasuk : FDetailPembelian
    {

        private int indexSelectedBarangMasuk = -1;
        private int indexSelectedDetailBarangMasuk = -1;
        private v_aptpembelian v_Aptpembelian;
        private v_aptpembeliandetail v_Aptpembeliandetail;

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

        private void Load_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid, string search)
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembeliandetailByAptbarangmasukId(aptbarangmasukid, search);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gcDetailPembelian.DataSource = result.Item1;
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
            this.gcDetailBarangMasuk.Visible = false;
            this.gcDetailPembelian.Visible = true;
        }

        #endregion private method control

        public FDetailBarangMasuk(ref Panel pnlContent, v_aptpembelian v_Aptpembelian ) : base(ref pnlContent)
        {
            this.Text = "Detail Pembelian";
            this.v_Aptpembelian = v_Aptpembelian;
            defaultControl();
        }

        public FDetailBarangMasuk(ref Panel pnlContent, v_aptpembelian v_Aptpembelian, int indexSelectedBarangMasuk) : base(ref pnlContent)
        {
            this.Text = "Detail Pembelian";
            this.v_Aptpembelian = v_Aptpembelian;
            this.indexSelectedBarangMasuk = indexSelectedBarangMasuk;
            defaultControl();
        }

        protected override void gvDetailPembelian_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gvDetailBarangMasuk.DataRowCount == 1)
                {
                    this.v_Aptpembeliandetail = gvDetailBarangMasuk.GetRow(0) as v_aptpembeliandetail;
                    //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
                    lblSelect.Text = string.Format("Selected => Tgl.Beli: {0}, NoPembelian: {1}", this.v_Aptpembeliandetail.tglmasuk, this.v_Aptpembeliandetail.nobeli);
                    //this.indexSelectedBarangMasuk = 0;
                }
            }
            catch (Exception ex)
            {
                //this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV2_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void gvDetailPembelian_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Aptpembeliandetail = gvDetailBarangMasuk.GetRow(e.FocusedRowHandle) as v_aptpembeliandetail;
                if (this.v_Aptpembeliandetail != null)
                {
                    lblSelect.Text = string.Format("Selected => Tgl.Beli: {0}, NoPembelian: {1}", this.v_Aptpembeliandetail.tglmasuk, this.v_Aptpembeliandetail.nobeli);

                    //Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, string.Empty);
                    //this.indexSelectedBarangMasuk = e.FocusedRowHandle;
                }
                else
                {
                    lblSelect.Text = string.Empty;
                    //this.indexSelectedBarangMasuk = -1;
                }

            }
            catch (Exception ex)
            {
                //this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV2_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void cariDataMTxt1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Load_v_aptpembeliandetailByAptbarangmasukId(this.v_Aptpembelian.aptbarangmasukid, cariDataMTxt1.Text);

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariDataMTxt1_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected override void FDetailPembelian_Load(object sender, EventArgs e)
        {
            try
            {
                
                Load_v_aptpembeliandetailByAptbarangmasukId(this.v_Aptpembelian.aptbarangmasukid , string.Empty);
                
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
                if (this.indexSelectedDetailBarangMasuk == -1) this.indexSelectedDetailBarangMasuk = 0;
                gvDetailPembelian.SelectRow(this.indexSelectedDetailBarangMasuk);
                gvDetailPembelian.FocusedRowHandle = this.indexSelectedDetailBarangMasuk;

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
                FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent,this.indexSelectedBarangMasuk);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType =   MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
