using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Registrasi;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FMainMenuRegistrasiRJ : FMainMenuRegistrasi
    {
        public FMainMenuRegistrasiRJ():base()
        {
            Helper.Prosedurmasuk.ProsedurmasukId = "01";
            Helper.Prosedurmasuk.ProsedurmasukNm = "Rawat Jalan";
            Helper.Prosedurmasuk.Prosedurmasuksts = true;

            this.btnSubMenuLaporan1.Text = "     Buku Register";
        }

        protected override void BtnLogout_Click(object sender, EventArgs e)
        {
            bool isLogout = false;
            try
            {

                using (FDialogLogoutRegistrasiRJ f = new FDialogLogoutRegistrasiRJ("Apakah akan Log Out"))
                {

                    f.StartPosition = FormStartPosition.Manual;
                    //f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (f.Width+this.btnLogout.Left)  ,
                    //    this.pnlHeader.Height);

                    f.Location = new Point(this.btnLogout.Left - f.Width,
                        this.pnlHeader.Height);


                    //create an overlay form
                    XtraForm overlayForm = new XtraForm();
                    overlayForm.StartPosition = this.StartPosition; // FormStartPosition.CenterScreen; //this.StartPosition;
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
                        isLogout = true;

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();

                    if (isLogout)
                    {

                        this.DialogResult = DialogResult.No;



                    }


                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message, this);
            }


        }

        protected override void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListIdentitasPasienRJ myForm = new FListIdentitasPasienRJ(ref this.pnlContent, "List Identitas Pasien");
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);
            
            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiRJ myForm = new FListRegistrasiRJ(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnDasboard_Click(object sender, EventArgs e)
        {

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeRegistrasiRJ myForm = new FHomeRegistrasiRJ();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnSubMenuLaporan1_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FLapBukuRegister myForm = new FLapBukuRegister(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }





    }
}
