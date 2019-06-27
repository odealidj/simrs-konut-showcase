using SIMRS.DESKTOP.Template.frm;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FListRegistrasiRJ : TFListRegistrasi
    {

        //private Panel pnlContent;
        private int indexSelectedRowSender = -1;

        public FListRegistrasiRJ(ref Panel _pnlContent) :base(ref _pnlContent)
        {
            //this.pnlContent = panel;
            colkelasnm.Visible = false;
            colkamarnm.Visible = false;
            colruangrawatnm.Caption = "POLI";
            colkelasuraian.Visible = false;

            this.colstsmasukkeluarnm.OptionsColumn.AllowEdit = false;
            this.colstsmasukkekuarruangrawatid.Visible = false;

            this.btnAnamnesis.Visible = false;
            this.btnPeriksaFisik.Visible = false;
            this.btnPengobatan.Visible = false;

            this.colEdit.OptionsColumn.AllowEdit = true;
        }

        public FListRegistrasiRJ(ref Panel _pnlContent, int indexSelectedRowSender) : base(ref _pnlContent)
        {
            try
            {//this.pnlContent = panel;
                colkelasnm.Visible = false;
                colkamarnm.Visible = false;
                colkelasuraian.Visible = false;
                colruangrawatnm.Caption = "POLI";

                this.colstsmasukkeluarnm.OptionsColumn.AllowEdit = false;
                this.colstsmasukkekuarruangrawatid.Visible = false;

                this.btnAnamnesis.Visible = false;
                this.btnPeriksaFisik.Visible = false;
                this.btnPengobatan.Visible = false;

                this.indexSelectedRowSender = indexSelectedRowSender;

                this.colEdit.OptionsColumn.AllowEdit = true;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListRegistrasiRJ()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListRegistrasi_Shown(object sender, EventArgs e)
        {
            try
            {
                this.RegistrasiGC.Focus();
                this.RegistrasiGV.ClearSelection();
                this.RegistrasiGV.Focus();
                this.RegistrasiGV.FocusedRowHandle = this.indexSelectedRowSender;
                this.RegistrasiGV.SelectRow(this.indexSelectedRowSender);
                this.RegistrasiGV.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListRegistrasi_Shown()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FAddEditRegistrasiPasienBaruRJ myForm = new FAddEditRegistrasiPasienBaruRJ(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {

            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FAddEditRegistrasiPasienLamaRJ myForm = new FAddEditRegistrasiPasienLamaRJ(ref this.pnlContent, ref this.vregistrasiruangrawat);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAddRegistrasiPasienLama_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void controlrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat.nocm != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    FListRiwayatPenyakitPasienRJ myForm = new FListRiwayatPenyakitPasienRJ(ref this.pnlContent, ref this.vregistrasiruangrawat, ref this.indexRow, this);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncontrolrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    FEditRegistrasiPasienRJ myForm = new FEditRegistrasiPasienRJ(ref this.pnlContent, ref this.vregistrasiruangrawat, this.indexRow);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncontrolrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
