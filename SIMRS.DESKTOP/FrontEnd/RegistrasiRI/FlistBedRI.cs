using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRI
{
    public class FlistBedRI : FListBed
    {
        public FlistBedRI(ref Panel _pnlContent): base(ref _pnlContent)
        {
            this.Text = "List Tempat Tidur";
            LoadDataVjmltempattidurbasekelasrawatinapAsync();
        }


        #region private method control

        protected async void LoadDataVjmltempattidurbasekelasrawatinapAsync()
        {
            try
            {
                using (var service = new ListRegistrasiRIServices())
                {
                    var result = await service.SelectVjmltempattidurbasekelasrawatinapAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        jmltempattidurGC.DataSource = result.Item1;
                    }

                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadDataVlisttempattidurrawatinapByKelasidAsync(short kelasid)
        {
            try
            {
                using (var service = new ListRegistrasiRIServices())
                {
                    var result = await service.SelectVlisttempattidurrawatinapByKelasidAsync(kelasid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        listtempattidurGC.DataSource = result.Item1;
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        protected override void jmltempattidurTileView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = jmltempattidurTileView.GetRow(e.FocusedRowHandle) as v_jmltempattidurbasekelasrawatinap;
                if (data != null)
                {
                    
                    LoadDataVlisttempattidurrawatinapByKelasidAsync(data.kelasid);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void repositoryItemButtonRegister_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //v_listtempattidurrawatinap

            //var data = listtempattidurGV.GetRow(e.Button.)

            try
            {

                if (listtempattidurrawatinap == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tempat tidur", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listtempattidurGC.Focus();
                    return;
                }

                if (listtempattidurrawatinap.tempattidurket.ToLower() == "isi")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tempat tidur yang lain,\nTempat tidur ini sedang digunakan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listtempattidurGC.Focus();
                    return;
                }


                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListAsalRegistrasi myForm = new FListAsalRegistrasi(ref this.pnlContent, ref listtempattidurrawatinap);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nrepositoryItemButtonRegister_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

            pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiRI myForm = new FListRegistrasiRI(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }
    }
}
