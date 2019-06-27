using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.FObatSatuan
{
    public class FListObatSatuan : TFListOneFilter
    {

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
                        filtercbo.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void Load_v_aptbarang_ByPageIndex(int pageIndex, int pageSize, string filtered)
        {
            try
            {
                using (var service = new ListbarangServices())
                {
                    var result = await service.SelectAll_v_aptbarang_ByPageIndex(pageIndex, pageSize, filtered);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        defenisiobatGC.DataSource = result.Item1;
                        dn1.DataSource = defenisiobatGC.DataSource;
                        this.totalPage = (int)Math.Ceiling((decimal)result.Item1.Count() / (decimal)PageSize);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void Load_v_aptbarang_ByPageIndexAndAptdef1id(int pageIndex, int pageSize, string aptdef1id)
        {
            try
            {
                using (var service = new ListbarangServices())
                {
                    var result = await service.GetAll_v_aptbarang_ByPageIndexAndAptdef1id(pageIndex, pageSize, aptdef1id);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        defenisiobatGC.DataSource = result.Item1;
                        dn1.DataSource = defenisiobatGC.DataSource;
                        this.totalPage = (int)Math.Ceiling((decimal)result.Item1.Count() / (decimal)PageSize);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string RemoveAptBarangsatuan(aptbarangsatuan obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.DeleteAptbarangsatuan(obj);

                    if (!string.IsNullOrEmpty(errResult))
                    {
                        MetroFramework.MetroMessageBox.Show(this, errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            catch (Exception ex)
            {
                errResult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return errResult;
        }


        protected void LoadBarangSatuanByIdAsync(short barangsatuanid)
        {
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    var result = Task.Run(() => service.SelectAllByIdAsync(barangsatuanid));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        defenisiobatsatuanGC.DataSource = result.Result.Item1;
                        //dn1.DataSource = defenisiobatsatuanGC.DataSource;
                        this.totalPage = (int)Math.Ceiling((decimal)result.Result.Item1.Count() / (decimal)PageSize);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadBarangSatuanByAptarangidAsync(short barangid)
        {
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    var result = Task.Run(() => service.SelectAllByAptarangidAsync(barangid));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        defenisiobatsatuanGC.DataSource = result.Result.Item1;
                        //dn1.DataSource = defenisiobatsatuanGC.DataSource;
                        this.totalPage = (int)Math.Ceiling((decimal)result.Result.Item1.Count() / (decimal)PageSize);
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
            this.filtercbo.DisplayMember = "aptdef1singkatan";
            this.filtercbo.ValueMember = "aptdef1kode";

            this.defenisiobatGC.Visible = true;
            this.defenisiobatsatuanGC.Visible = true;

            //this.cariDataMTxt2.Location = new Point { X = 561, Y = 81 };
        }

        #endregion private method control

        public FListObatSatuan(ref Panel pnlContent) : base(ref pnlContent)
        {
            try
            {
                this.lblHeader.Text = "List Obat && BHP";
                this.aktifFilterCheck.CheckState = CheckState.Checked;
                this.filtercbo.Enabled = false;
                defaultControl();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListBarang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListOneFilter_Load(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                LoadAptdef1brgAsync();
                Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, string.Empty);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListOneFilter_Load()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListOneFilter_Shown(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListOneFilter_Shown()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void aktifFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (aktifFilterCheck.CheckState == CheckState.Checked)
            {
                filtercbo.Enabled = false;
                filtercbo.SelectedIndex = -1;
            }
            else if (aktifFilterCheck.CheckState == CheckState.Indeterminate)
            {
                aktifFilterCheck.CheckState = CheckState.Checked;
                filtercbo.SelectedIndex = -1;
            }
            else
            {
                filtercbo.Enabled = true;
                filtercbo.SelectedIndex = 0;
            }
        }

        protected override void filtercbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filtercbo.Enabled == true)
                {
                    if (filtercbo.SelectedIndex != -1)
                    {
                        this.PageIndex = 1;
                        this.Load_v_aptbarang_ByPageIndexAndAptdef1id(this.PageIndex, this.PageSize, filtercbo.SelectedValue.ToString());
                    }
                }
                else
                {
                    this.PageIndex = 1;
                    Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nfiltercbo_SelectedIndexChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void cariDataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.ToString());
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariDataMTxt_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void defenisiobatGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = this.defenisiobatGV.GetFocusedRow() as v_aptbarang;
                if (data==null)
                {
                    this.defenisiobatGV.Focus();
                    return;
                }

                LoadBarangSatuanByAptarangidAsync(data.aptbarangid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndefenisiobatGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var data = this.defenisiobatGV.GetFocusedRow() as v_aptbarang;
                if(data==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silah pilih data obat yang akan didefenisikan satuannya,\ndengan cara klik baris pada tabel obat ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    defenisiobatGC.Focus();
                }

                using (FAddObatSatuan f = new FAddObatSatuan(ref data))

                {
                    //create an overlay form
                    XtraForm overlayForm = new XtraForm();
                    overlayForm.StartPosition = this.StartPosition;// FormStartPosition.CenterScreen; //this.StartPosition;
                    overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                    overlayForm.Opacity = .80d;
                    overlayForm.BackColor = Color.Black;
                    overlayForm.Size = Screen.PrimaryScreen.WorkingArea.Size;// base.Size; //(this as FListRegistrasiRI).Activate.Size; //mainmenu.Size;// this.Size;
                    overlayForm.Location = Screen.PrimaryScreen.WorkingArea.Location; //base.Location;// FMainMenuRI.ActiveForm.Location; //mainmenu.Location;// this.Location;
                                                                                      //overlayForm.Size = this.Size;
                                                                                      //overlayForm.Location =  this.Location;
                    overlayForm.ShowInTaskbar = false;
                    overlayForm.Show();

                    //Show the dialog
                    f.Owner = overlayForm;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        //Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, string.Empty);
                        LoadBarangSatuanByAptarangidAsync(data.aptbarangid);

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();


                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbAdd_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void editdefenisisatuanrepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                
                var dataobat = this.defenisiobatGV.GetFocusedRow() as v_aptbarang;
                if (dataobat == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silah pilih data obat,\ndengan cara klik baris pada tabel obat ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    defenisiobatGC.Focus();
                }

                
                var dataobatsatuan = this.defenisiobatsatuanGV.GetFocusedRow() as v_aptbarangsatuan_pbf;
                if (dataobatsatuan == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silah pilih data satuan yang akan diedit satuannya,\ndengan cara klik baris pada tabel barang satuan ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    defenisiobatGC.Focus();
                }

                using (FEditObatSatuan f = new FEditObatSatuan(ref dataobat, ref dataobatsatuan))

                {
                    //create an overlay form
                    XtraForm overlayForm = new XtraForm();
                    overlayForm.StartPosition = this.StartPosition;// FormStartPosition.CenterScreen; //this.StartPosition;
                    overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                    overlayForm.Opacity = .80d;
                    overlayForm.BackColor = Color.Black;
                    overlayForm.Size = Screen.PrimaryScreen.WorkingArea.Size;// base.Size; //(this as FListRegistrasiRI).Activate.Size; //mainmenu.Size;// this.Size;
                    overlayForm.Location = Screen.PrimaryScreen.WorkingArea.Location; //base.Location;// FMainMenuRI.ActiveForm.Location; //mainmenu.Location;// this.Location;
                                                                                      //overlayForm.Size = this.Size;
                                                                                      //overlayForm.Location =  this.Location;
                    overlayForm.ShowInTaskbar = false;
                    overlayForm.Show();

                    //Show the dialog
                    f.Owner = overlayForm;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadBarangSatuanByIdAsync(dataobatsatuan.aptbarangsatuanid);

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();


                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\neditdefenisisatuanrepository_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void deletedefenisisatuanrepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var dataobat = this.defenisiobatGV.GetFocusedRow() as v_aptbarang;
                if (dataobat == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silah pilih data obat,\ndengan cara klik baris pada tabel obat ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    defenisiobatGC.Focus();
                }

                var dataobatsatuan = this.defenisiobatsatuanGV.GetFocusedRow() as v_aptbarangsatuan_pbf;
                if (dataobatsatuan == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silah pilih data satuan yang akan diedit satuannya,\ndengan cara klik baris pada tabel barang satuan ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    defenisiobatGC.Focus();
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah data Obat : " + dataobat.aptbarangnm + ", PBF :" +dataobatsatuan.aptpbfnm+", Satuan Kecil : " + dataobatsatuan.satuankecilkode
                        + ", dan Satuan Besar : " + dataobatsatuan.satuanbesarkode+ " berikut akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var errResult = this.RemoveAptBarangsatuan(new aptbarangsatuan { aptbarangsatuanid = dataobatsatuan.aptbarangsatuanid });
                    if (string.IsNullOrEmpty(errResult))
                    {
                        LoadBarangSatuanByAptarangidAsync(dataobat.aptbarangid);
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "Menghapus data barang tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndeletedefenisisatuanrepository_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
