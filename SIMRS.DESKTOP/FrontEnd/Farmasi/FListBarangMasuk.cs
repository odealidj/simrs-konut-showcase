using SIMRS.DESKTOP.Helper;
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
    public class FListBarangMasuk : FListPembelian
    {
        private v_aptpembelian V_Aptpembelian;
        private int indexSelectedBarangMasuk = -1 ;

        #region private method control

        protected async void LoadAptdef1brgAsync()
        {
            try
            {
                using (var service = new Aptdef1brgServices())
                {
                    var result = await service.SelectAllAptdef1brgAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtercbo.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Load_v_aptpembelianByYearAndMonth(short year, short month)
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelianByYearAndMonth(year, month);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        GC1.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_v_aptpembelian()
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelian();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        GC1.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Load_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid,string search)
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
                        GC2.DataSource = result.Item1;
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

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref filtercbo,
              new string[] { "aptdef1kode", "aptdef1singkatan" },
              new string[] { "KODE", "JENIS" },
              new bool[] { false, true },
              "aptdef1singkatan", "aptdef1kode", "Pilih ...");


            this.aktifPeriodeCheck.Checked = true;
            this.periodedateEdit.Enabled = false;

            this.aktifFilterJenisObatCheck.Checked = true;
        }

        #endregion private method control
        public FListBarangMasuk(ref Panel pnlContent) : base(ref  pnlContent)
        {
            this.Text = "List Pembelian";

            this.GC1.Visible = true;
            this.GC2.Visible = true;
            this.gcGudang.Visible = false;
            this.gcGudangDetail.Visible = false;

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
                GC1.Focus();
                GV1.ClearSelection();
                GV1.SelectRow(0);
                GV1.FocusedRowHandle = 0;
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name+ "\nFListPembelian_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GV1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ////try
            ////{
            ////    if (GV1.DataRowCount==1)
            ////    {
            ////        this.V_Aptpembelian = GV1.GetRow(0) as v_aptpembelian;
            ////        Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid);
            ////        this.indexSelectedBarangMasuk = 0;
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name+ "\nGV1_RowCellClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}
        }

        protected override void GV1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (GV1.DataRowCount == 1)
                {
                    this.V_Aptpembelian = GV1.GetRow(0) as v_aptpembelian;
                    Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid,string.Empty);
                    this.indexSelectedBarangMasuk = 0;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_RowClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GV1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.V_Aptpembelian = GV1.GetRow(e.FocusedRowHandle) as v_aptpembelian;
                if (this.V_Aptpembelian != null)
                {
                    Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid,string.Empty);
                    this.indexSelectedBarangMasuk = e.FocusedRowHandle;
                }
                else
                {
                    GC2.DataSource = null;
                    this.indexSelectedBarangMasuk = -1;
                }

            }
            catch (Exception ex)
            {
                this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void periodedateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (periodedateEdit.Enabled == true)
                {
                    Load_v_aptpembelianByYearAndMonth((short)periodedateEdit.DateTime.Year, (short)periodedateEdit.DateTime.Month);
                }
                else
                {
                    Load_v_aptpembelian();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name+ "\nperiodedateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void cariDataMTxt2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (this.V_Aptpembelian != null)
                {
                    
                    Load_v_aptpembeliandetailByAptbarangmasukId(this.V_Aptpembelian.aptbarangmasukid, cariDataMTxt2.Text);
                    

                }
                

            }
            catch (Exception ex)
            {
                this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariDataMTxt2_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void aktifPeriodeCheck_Click(object sender, EventArgs e)
        {
            if (aktifPeriodeCheck.Checked==true)
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

        protected override void filtercbo_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected override void aktifFilterJenisObatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.aktifFilterJenisObatCheck.Checked==true)
            {
                this.filtercbo.Enabled = false;
            }
            else
            {
                this.filtercbo.Enabled = true;
            }
        }
    }
}
