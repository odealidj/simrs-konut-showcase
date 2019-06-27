using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Template.frm.Farmasi;
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
    public class FListBarangMasukGudang : FListBarangGudang
    {

        #region private methode

        private void LoadAllAptbrgguAsync()
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAllAsync());

                    if (!string.IsNullOrEmpty( result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        brgguGC.DataSource = result.Result.Item1.ToList();
                    }
                    
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllAptBarangmasukPbfAptbrggu(short aptbrgguid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptbarangmasuk_pbf_aptbrggu(aptbrgguid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        listbaranggudangGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbrgguid, short aptbarangmasukid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptbarangmasukdetail_aptbrggudetail(aptbrgguid, aptbarangmasukid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        listbaranggudangdetailGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbarangmasukdetailid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptbarangmasukdetail_aptbrggudetail(aptbarangmasukdetailid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        detailhargaGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveUpdateBarangmasukGudangDetail(aptbrggudetail obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.InsertUpdateBarangmasukGUDetail(obj);

                    if (!string.IsNullOrEmpty(errResult))
                    {
                        MetroFramework.MetroMessageBox.Show(this, errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }

            catch (Exception ex)
            {
                errResult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return errResult;
        }

        #endregion  private methode
        public FListBarangMasukGudang(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.Text = "Barang Masuk Gudang";
            LoadAllAptbrgguAsync();
        }

        protected override void brgguBandedGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = brgguBandedGV.GetFocusedRow() as aptbrggu;
                if (data == null) return;
                LoadAllAptBarangmasukPbfAptbrggu(data.aptbrgguid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                  
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


                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nsethargarepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbAdd_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bEdit_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbEdit_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbDelete_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void brgguBandedGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var data = brgguBandedGV.GetFocusedRow() as aptbrggu;
                if (data == null) return;
                LoadAllAptBarangmasukPbfAptbrggu(data.aptbrgguid);
                listbaranggudangdetailGC.DataSource = null;
                detailhargaGC.DataSource = null;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbrgguBandedGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void listbaranggudangGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = listbaranggudangGV.GetFocusedRow() as v_aptbarangmasuk_pbf_aptbrggu;
                if (data == null) return;
                LoadAll_v_aptbarangmasukdetail_aptbrggudetail(data.aptbrgguid,data.aptbarangmasukid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nlistbaranggudangGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void listbaranggudangGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var data = listbaranggudangGV.GetFocusedRow() as v_aptbarangmasuk_pbf_aptbrggu;
                if (data == null) return;
                LoadAll_v_aptbarangmasukdetail_aptbrggudetail(data.aptbrgguid, data.aptbarangmasukid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nlistbaranggudangGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void listbaranggudangdetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = listbaranggudangdetailGV.GetFocusedRow() as v_aptbarangmasukdetail_aptbrggudetail;
                if (data == null) return;
                LoadAll_v_aptbarangmasukdetail_aptbrggudetail(data.aptbarangmasukdetailid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nlistbaranggudangdetailGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void listbaranggudangdetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var data = listbaranggudangdetailGV.GetFocusedRow() as v_aptbarangmasukdetail_aptbrggudetail;
                if (data == null) return;
                LoadAll_v_aptbarangmasukdetail_aptbrggudetail(data.aptbarangmasukdetailid) ;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nlistbaranggudangdetailGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void sethargarepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                //var data = this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian;
                //if (data == null)
                //{
                //    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data pada tabel dengan cara klik data pada tabel yang diinginkan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //this.vaptpembelianGV.FocusedRowHandle = 0;
                //    return;
                //}


                var data = listbaranggudangdetailGV.GetFocusedRow() as v_aptbarangmasukdetail_aptbrggudetail;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data pada tabel dengan cara klik data pada tabel yang diinginkan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.listbaranggudangdetailGV.FocusedRowHandle = 0;
                    return;

                }

                using (FAddHargajual f = new FAddHargajual
                    (
                       data.aptbarangmasukdetailid
                    ))

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


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nsethargarepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void detailhargajualrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = detailhargaGV.GetFocusedRow() as v_aptbarangmasukdetail_aptbrggudetail;
                if (data==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data yang akan diupdate,\ndengan cara klik salah satu baris data pada tabel Detail Harga;", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var result = SaveUpdateBarangmasukGudangDetail(new aptbrggudetail {
                    aptbrggudetailid = data.aptbrggudetailid,
                    hargajual = decimal.Parse(detailhargaGV.GetFocusedRowCellValue("hargajual").ToString()),
                });
                if (string.IsNullOrEmpty(result))
                {

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Update harga tidak sukses !\nresult", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nsethargarepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
