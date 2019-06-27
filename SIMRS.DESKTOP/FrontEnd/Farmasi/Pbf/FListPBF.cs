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

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pbf
{
    public class FListPBF : TFListOne
    {
        protected aptpbf Aptpbf;

        #region private method control
        protected async void LoadAptpbfAsync()
        {
            try
            {
                using (var service = new AptpbfServices())
                {
                    var result = await service.SelectAllAptpbfAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        pbfGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string RemoveAptPbf(aptpbf obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptpbfServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.DeleteAptpbf(obj);

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

        public FListPBF(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.lblHeader.Text = "List P B F";
            //this.colaptdepoid.Visible = false;
            //this.colaptdepoid.Caption = "PBFID";
            //this.colaptdepoid.FieldName = "aptpbfid";
            //this.colaptdeponm.Visible = true;
            //this.colaptdeponm.Caption = "P B F";
            //this.colaptdeponm.FieldName = "aptpbfnm";
            this.pbfGC.Visible = true;
        }

        protected override void FListOne_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAptpbfAsync();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void FListOne_Shown(object sender, EventArgs e)
        {

        }


        protected override void pbfGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.Aptpbf = pbfGV.GetFocusedRow() as aptpbf;
                if (this.Aptpbf != null)
                {
                    //lblSelect.Text = string.Format("Selected => [ Nama PBF: {0}]", this.Aptpbf.aptpbfnm);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void editpbfrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var data = pbfGV.GetFocusedRow() as aptpbf;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data PBF yang akan diedit pada tabel !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    satuanGC.Focus();
                    return;
                }

                using (FEditPbf f = new FEditPbf(data)
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
                        LoadAptpbfAsync();

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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\neditpbfrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void deletepbfrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = pbfGV.GetFocusedRow() as aptpbf;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data PBF yang akan dihapus pada tabel !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    satuanGC.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah data PBF " + data.aptpbfnm + " berikut, akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var errResult = this.RemoveAptPbf (new aptpbf { aptpbfid = data.aptpbfid });
                    if (string.IsNullOrEmpty(errResult))
                    {
                        LoadAptpbfAsync();
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "Menghapus data barang tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndeletepbfrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {

            try
            {


                using (FAddPbf f = new FAddPbf())

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
                        LoadAptpbfAsync();

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
