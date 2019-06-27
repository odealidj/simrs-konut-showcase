using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.frm.Farmasi;
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

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Obat
{
    public class FListBarang : TFListOneFilter
    {

        protected v_aptbarang v_Aptbarang;

        #region private method control
        protected void LoadAptdef1brgAsync()
        {
            try
            {
                using (var service = new Aptdef1brgServices())
                {
                    var result = Task.Run(() => service.SelectAllAptdef1brgAsync());
                    
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtercbo.DataSource = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.InnerException.Message , "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Load_v_aptbarang_ByPageIndex(int pageIndex, int pageSize, string filtered)
        {
            try
            {
                using (var service = new ListbarangServices())
                {
                    var result = Task.Run(() => service.SelectAll_v_aptbarang_ByPageIndex(pageIndex, pageSize, filtered));
                    
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        obatGC.DataSource = result.Result.Item1;
                        dn1.DataSource = obatGC.DataSource;
                        this.totalPage = (int)Math.Ceiling((decimal)result.Result.Item1.Count() / (decimal)PageSize);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Load_v_aptbarang_ByPageIndexAndAptdef1id(int pageIndex, int pageSize, string aptdef1id)
        {
            try
            {
                using (var service = new ListbarangServices())
                {
                    var result = Task.Run(() => service.GetAll_v_aptbarang_ByPageIndexAndAptdef1id(pageIndex, pageSize, aptdef1id));
                    
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        obatGC.DataSource = result.Result.Item1;
                        dn1.DataSource = obatGC.DataSource;
                        this.totalPage = (int)Math.Ceiling((decimal)result.Result.Item1.Count() / (decimal)PageSize);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string RemoveAptBarang(aptbarang obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new Aptbarangservices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.DeleteAptbarang(obj);

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

        private void defaultControl()
        {
            this.filtercbo.DisplayMember = "aptdef1singkatan";
            this.filtercbo.ValueMember = "aptdef1kode";

            this.obatGC.Visible = true;
            //this.cariDataMTxt2.Location = new Point { X = 561, Y = 85 };
        }

        #endregion private method control

        public FListBarang(ref Panel pnlContent) : base(ref pnlContent)
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nFListBarang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(aktifFilterCheck.CheckState==CheckState.Checked) 
            {
                filtercbo.Enabled = false;
                filtercbo.SelectedIndex = -1;
            }
            else if (aktifFilterCheck.CheckState==CheckState.Indeterminate)
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
                Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariDataMTxt_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void dn1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == NavigatorButtonType.Custom)
                {

                    switch (int.Parse(e.Button.Tag.ToString()))
                    {
                        case 0:
                            this.PageIndex = 1;
                            break;
                        case 1:
                            this.PageIndex--;
                            if (this.PageIndex < 1) this.PageIndex = 1;
                            break;
                        case 6:
                            this.PageIndex++;
                            if (this.PageIndex > this.totalPage) this.PageIndex = this.totalPage;
                            break;
                        case 7:
                            this.PageIndex = this.totalPage;
                            break;
                    }
                    //LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);

                    if (filtercbo.Enabled == true)
                    {
                        if (filtercbo.SelectedIndex != -1)
                        {
                            //this.PageIndex = 1;
                            this.Load_v_aptbarang_ByPageIndexAndAptdef1id(this.PageIndex, this.PageSize, filtercbo.SelectedValue.ToString());
                        }
                    }
                    else
                    {
                        //this.PageIndex = 1;
                        Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndataNavigator1_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var data = obatGV.GetFocusedRow() as v_aptbarang;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data obat yang akan di edit pada tabel !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    obatGC.Focus();
                    return;
                }

                using (FEditObat f = new FEditObat(new aptbarang
                {
                    aptbarangid = data.aptbarangid,
                    aptbarangnm = data.aptbarangnm,
                    aptdef1id = data.aptdef1kode

                })
                    )

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
                        Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, string.Empty);

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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\neditrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = obatGV.GetFocusedRow() as v_aptbarang;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data obat yang akan dihapus pada tabel !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    obatGC.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah data barang "+ data.aptbarangnm +"["+data.aptdef1singkatan+"] berikut, akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var errResult = this.RemoveAptBarang(new aptbarang { aptbarangid = data.aptbarangid } );
                    if (string.IsNullOrEmpty(errResult))
                    {
                        Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, string.Empty);
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "Menghapus data barang tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nobatGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void obatGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Aptbarang = obatGV.GetFocusedRow()as v_aptbarang;
                if (this.v_Aptbarang != null)
                {
                    //this.lblSelect.Text = string.Format("Selected => {0}, Kategori:{1}", this.v_Aptbarang.aptbarangnm, this.v_Aptbarang.aptdef1singkatan);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nobatGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void obatGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {
            try
            {

                using (FAddObat f = new FAddObat())

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
                        Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, string.Empty);

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

        protected override void BFirst_Click(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                if (filtercbo.Enabled == true)
                {
                    if (filtercbo.SelectedIndex != -1)
                    {
                        //this.PageIndex = 1;
                        this.Load_v_aptbarang_ByPageIndexAndAptdef1id(this.PageIndex, this.PageSize, filtercbo.SelectedValue.ToString());
                    }
                }
                else
                {
                    //this.PageIndex = 1;
                    Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message + "\nFirst_Click()",this.Name, this);

            }
        }

        protected override void BPrev_Click(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                if (filtercbo.Enabled == true)
                {
                    if (filtercbo.SelectedIndex != -1)
                    {
                        //this.PageIndex = 1;
                        this.Load_v_aptbarang_ByPageIndexAndAptdef1id(this.PageIndex, this.PageSize, filtercbo.SelectedValue.ToString());
                    }
                }
                else
                {
                    //this.PageIndex = 1;
                    Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message + "\nFirst_Click()", this.Name, this);

            }

        }

        protected override void BNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex++;
                if (this.PageIndex < 1) this.PageIndex = 1;
                if (filtercbo.Enabled == true)
                {
                    if (filtercbo.SelectedIndex != -1)
                    {
                        //this.PageIndex = 1;
                        this.Load_v_aptbarang_ByPageIndexAndAptdef1id(this.PageIndex, this.PageSize, filtercbo.SelectedValue.ToString());
                    }
                }
                else
                {
                    //this.PageIndex = 1;
                    Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message + "\nFirst_Click()", this.Name, this);

            }
        }

        protected override void BLast_Click(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = this.totalPage;
                if (filtercbo.Enabled == true)
                {
                    if (filtercbo.SelectedIndex != -1)
                    {
                        //this.PageIndex = 1;
                        this.Load_v_aptbarang_ByPageIndexAndAptdef1id(this.PageIndex, this.PageSize, filtercbo.SelectedValue.ToString());
                    }
                }
                else
                {
                    //this.PageIndex = 1;
                    Load_v_aptbarang_ByPageIndex(this.PageIndex, this.PageSize, this.cariDataMTxt.Text);
                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message + "\nFirst_Click()", this.Name, this);

            }
        }

    }
}
