using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
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

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FListBarangMasukGudang2 : TFListBarangGudang2
    {
        private bool isAllowChangedEvent = false;

        #region private methode

        private void LoadAllAptbrggudetailByAptbrgguidAsync()
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAllv_aptbrggudetailByAptbrgguidAsync());

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllAptbrgguAsync", this.Name, this);
                        
                    }
                    else
                    {
                        this.listbaranggudangdetailGC.DataSource = result.Result.Item1.ToList();
                        this.listbaranggudangdetailGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllAptbrgguAsync", this.Name, this);
            }
        }

        private void LoadAllAptbrggudetailByAptbrgguidAsync(string tahun, string bulan)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAllv_aptbrggudetailByAptbrgguidAsync(tahun,bulan));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllAptbrgguAsync", this.Name, this);

                    }
                    else
                    {
                        this.listbaranggudangdetailGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllAptbrgguAsync", this.Name, this);
            }
        }

        private void LoadAllAptbrggudetailByAptbrgguidAsync(string namabarang)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAllv_aptbrggudetailByAptbrgguidAsync(namabarang));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllAptbrgguAsync", this.Name, this);

                    }
                    else
                    {
                        this.listbaranggudangdetailGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllAptbrgguAsync", this.Name, this);
            }
        }

        private string DeleteBarangGU(aptbrggu Aptbrggu)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbrgguServices())
                {
                    Errresult = service.DeleteBarangGU(Aptbrggu);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                CustomMessageBox.MessageError(ex.InnerException.Message, "DeleteBarangGU()", this.Name, this);

            }

            return Errresult;
        }

        private void defaultControl()
        {
            lblhinttextcari.Visible = false;

            this.kriteriaCbo.Properties.Items.Clear();
            this.kriteriaCbo.Properties.Items.AddRange(new string[] { "Periode", "Barang" });
            this.kriteriaCbo.SelectedIndex = 0;
        }


        #endregion  private methode
        public FListBarangMasukGudang2(ref Panel pnlContent) : base(ref pnlContent)
        {
            isAllowChangedEvent = false;
            this.lblHeader.Text = "Barang Masuk Gudang";
            defaultControl();
        }

        protected override void TFListBarangGudang2_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllAptbrggudetailByAptbrgguidAsync();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFListBarangGudang2_Load()", this.Name, this);

            }
        }

        protected override void TFListBarangGudang2_Shown(object sender, EventArgs e)
        {
            isAllowChangedEvent = true;
        }

        protected override void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAllowChangedEvent)
            {
                switch (kriteriaCbo.SelectedIndex)
                {
                    case 0: //periode
                        this.periodeDateEdit.Visible = true;
                        this.caridataTxt.Visible = false;
                        lblhinttextcari.Visible = false;
                        this.periodeDateEdit.Focus();
                        break;
                    case 1: //Barang
                        this.periodeDateEdit.Visible = false;
                        this.caridataTxt.Visible = true;
                        lblhinttextcari.Visible = false;
                        this.caridataTxt.Focus();
                        break;
                   
                }
            }
        }

        protected override void CaridataTxt_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (isAllowChangedEvent == false) return;

                if (string.IsNullOrEmpty(caridataTxt.Text))
                    LoadAllAptbrggudetailByAptbrgguidAsync();
                else
                    LoadAllAptbrggudetailByAptbrgguidAsync((caridataTxt.EditValue != null) ? caridataTxt.EditValue.ToString() : string.Empty);

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "CaridataTxt_EditValueChanged()", this.Name, this);

            }

        }

        protected override void PeriodeDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (isAllowChangedEvent == false) return;

                if (periodeDateEdit.EditValue != null)
                {
                    LoadAllAptbrggudetailByAptbrgguidAsync(DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Year.ToString(),
                      DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Month.ToString("0#"));
                }
                else
                {
                    LoadAllAptbrggudetailByAptbrgguidAsync();
                }

                
                //LoadAllAptbrggudetailByAptbrgguidAsync(data.aptbrgguid);
                
                

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "PeriodeDateEdit_EditValueChanged()", this.Name, this);

            }

        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {
            try
            {


                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                    FAddBarangGudang2 myForm = new FAddBarangGudang2(ref this.pnlContent);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
               

                /*
                using (FAddBarangGudang f = new FAddBarangGudang())

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
                        LoadAllAptbrgguAsync();


                        ////var data = listbaranggudangdetailGV.GetFocusedRow() as v_aptbarangmasukdetail_aptbrggudetail;
                        ////if (data == null) return;
                        ////LoadAll_v_aptbarangmasukdetail_aptbrggudetail(data.aptbarangmasukdetailid);

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();


                }
                */


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Add_Click()", this.Name, this);
                
            }
        }

        protected override void bEdit_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                var data = this.brgguBandedGV.GetFocusedRow() as aptbrggu;
                if (data == null)
                {
                    CustomMessageBox.MessageWarning("Silahkan pilih data barang gudang yang akan diedit", this);
                    this.brgguGC.Focus();
                    return;
                }

                if (CustomMessageBox.MessageQuestion(string.Format("Apakah data gudang tanggal: {0} akan diedit", data.tglgu.Value.Date), this) == DialogResult.Yes)
                {

                }
                */
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Edit()", this.Name, this);

            }
        }
        protected override void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Delete()", this.Name, this);

            }
        }

        protected override void ListbaranggudangdetailGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                int isstock = Convert.ToInt32(this.listbaranggudangdetailGV.GetRowCellValue(e.RowHandle, "isbrggudetailinstockopdetail"));
                if (e.Column.FieldName == "isbrggudetailinstockopdetail")
                {
                    if (isstock != 1)
                    {


                        e.Appearance.BackColor = Helper.CustomColor.IsBarangNotInGudang();
                        e.Appearance.ForeColor = Helper.CustomColor.IsBarangNotInGudang();
                        e.Column.ToolTip = "Belum masuk stock kontrol";

                    }
                    else
                    {
                        //e.Appearance.BackColor = Helper.CustomColor.IsBarangInGudang();
                        //e.Appearance.ForeColor = Helper.CustomColor.IsBarangInGudang();
                        e.Column.ToolTip = "Sudah masuk stock kontrol";
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "VaptpembelianGV_CustomDrawCell()", this.Name, this);
            }
        }
       
        protected override void EditrepositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var data = this.listbaranggudangdetailGV.GetFocusedRow() as v_aptbrggudetail;
                if (data == null)
                {
                    CustomMessageBox.MessageWarning("silahkan pilih data tarif pada table barang gudang detail!", this);
                    return;
                }

                using (FEditTarifGudang f = new FEditTarifGudang(ref data))
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

                        //var dataRow = this.brgguBandedGV.GetFocusedRow() as aptbrggu;

                        //LoadAllAptbrggudetailByAptbrgguidAsync(dataRow.aptbrgguid);

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
                CustomMessageBox.MessageError(ex.InnerException.Message, "editrepositoryItemButtonEdit_ButtonClick()", this.Name, this);

            }

        }

        protected override void ListbaranggudangdetailGV_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                int isbrggudetailinstockopdetail = Convert.ToInt32(this.listbaranggudangdetailGV.GetRowCellValue(e.RowHandle, "isbrggudetailinstockopdetail"));
                if (e.Column.FieldName == "isbrggudetailinstockopdetail")
                {
                    if (isbrggudetailinstockopdetail != 1)
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
