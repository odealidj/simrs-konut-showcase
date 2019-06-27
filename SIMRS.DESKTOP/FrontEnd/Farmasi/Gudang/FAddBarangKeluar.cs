using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FAddBarangKeluar : TFAddEditBarangKeluar
    {
        private bool isAllowChangedEvent = false;

        #region private methode
        private void defaultControl()
        {
            this.TglKeluarDateEdit.EditValue = DateTime.Now.Date;
        }
        #endregion provate methode;
        public FAddBarangKeluar(ref Panel pnlContent) : base (ref pnlContent)
        {
            try
            {
                defaultControl();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FAddBarangKeluar()", this.Name, this);
            }

        }
        protected override void TFAddEditBarangKeluar_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFAddEditBarangKeluar_Load()", this.Name, this);
            }
        }

        protected override void TFAddEditBarangKeluar_Shown(object sender, EventArgs e)
        {
            try
            {
                this.TglKeluarDateEdit.Focus();   
                this.isAllowChangedEvent = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFAddEditBarangKeluar_Shown()", this.Name, this);
            }
        }

        protected override void BAdd_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BAdd_Click()", this.Name, this);
            }
        }

        protected override void BSimpan_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BSimpan_Click()", this.Name, this);
            }
        }

        protected override void BBatal_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BBatal_Click()", this.Name, this);
            }
        }

        protected override void BBack_Click(object sender, EventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarangKeluar myForm = new FListBarangKeluar(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BBack_Click()", this.Name, this);
            }
        }
    }
}
