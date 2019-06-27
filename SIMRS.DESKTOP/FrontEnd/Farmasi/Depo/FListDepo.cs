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

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Depo
{
    public class FListDepo : TFListOne
    {
        protected aptdepo Aptdepo;

        #region private method control
        protected async void LoadAptdepoAsync(string filtered)
        {
            try
            {
                using (var service = new AptdepoServices())
                {
                    var result = await service.SelectAllAptdepoAsync(filtered);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        depoGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string RemoveAptDepo(aptdepo obj)
        {
            string errResult = string.Empty;
            try
            {
                using (var service = new AptdepoServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    errResult = service.DeleteAptdepo(obj);

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

        public FListDepo(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.lblHeader.Text = "List Depo";
            this.depoGC.Visible = true;
        }

        protected override void FListOne_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAptdepoAsync(string.Empty);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void FListOne_Shown(object sender, EventArgs e)
        {

        }

        protected override void editdeporepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = depoGV.GetFocusedRow() as aptdepo;
                if (data ==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih depo yang akan diedit pada tabel !" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    depoGC.Focus();
                    return;
                }

                

                using (FEditDepo f = new FEditDepo(data))

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
                        LoadAptdepoAsync(string.Empty);

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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\neditdeporepositoryItemButtonEdit_ButtonClick()" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void deletedeporepositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = depoGV.GetFocusedRow() as aptdepo;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih depo yang akan dihapus pada tabel !" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    depoGC.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah data depo : "+ data.aptdeponm+" akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    aptdepo apt = new aptdepo { aptdepoid = data.aptdepoid };

                    var errResult = RemoveAptDepo(apt);
                    if (string.IsNullOrEmpty(errResult))
                        LoadAptdepoAsync(string.Empty);

                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndeletedeporepositoryItemButtonEdit1_ButtonClick()" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void depoGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.Aptdepo = depoGV.GetRow(e.FocusedRowHandle) as aptdepo;
                if (this.Aptdepo != null)
                {
                    //lblSelect.Text = string.Format("Selected => [ Nama Depo: {0}]", this.Aptdepo.aptdeponm);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndepoGV_FocusedRowChanged()" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected override void bAdd_Click(object sender, EventArgs e)
        {
            try
            {


                using (FAddDepo f = new FAddDepo())

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
                        LoadAptdepoAsync(string.Empty);

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
