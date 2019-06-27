using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Satuan
{
    public class FListSatuan : TFListOne
    {
        protected aptsatuan Aptsatuan;

        #region private method control
        protected async void LoadAptsatuanAsync(string filtered)
        {
            try
            {
                using (var service = new AptsatuanServices())
                {
                    var result = await service.SelectAllAptsatuanAsync(filtered);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        satuanGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string RemoveAptSatuan(aptsatuan obj)
        {
            string errResult = string.Empty;
            try
            {
                
                using (var service = new AptsatuanServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.DeleteAptsatuan(obj);

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

        #endregion private method control
        public FListSatuan(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.lblHeader.Text = "List Satuan";
            this.satuanGC.Visible = true;
        }

        protected override void FListOne_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAptsatuanAsync(string.Empty);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void FListOne_Shown(object sender, EventArgs e)
        {

        }

        protected override void editsatuanrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var data = satuanGV.GetFocusedRow() as aptsatuan;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data satuan yang akan diedit pada tabel !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    satuanGC.Focus();
                    return;
                }

                using (FEditSatuan f = new FEditSatuan(data)
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
                        LoadAptsatuanAsync(cariMtxt.Text);

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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\neditsatuanrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void deletesatuanrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = satuanGV.GetFocusedRow() as aptsatuan;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data satuan yang akan dihapus pada tabel !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    satuanGC.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah data satuan " + data.aptsatuankode + " berikut, akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var errResult = this.RemoveAptSatuan(new aptsatuan { aptsatuankode = data.aptsatuankode });
                    if (string.IsNullOrEmpty(errResult))
                    {
                        LoadAptsatuanAsync(cariMtxt.Text);
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "Menghapus data barang tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndeletesatuanrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void satuanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {

            try
            {


                using (FAddSatuan f = new FAddSatuan())

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
                        LoadAptsatuanAsync(string.Empty);

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


    }
}
