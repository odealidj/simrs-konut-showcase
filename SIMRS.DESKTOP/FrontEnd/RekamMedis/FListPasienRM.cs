using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis
{
    public class FListPasienRM : FListIdentitasPasien
    {
        private int indexSelectedRowFromSender = -1;

        public FListPasienRM (ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "List Pasien";
            this.btnAddRegistrasiPasienLama.Visible = false;
           
        }

        public FListPasienRM(ref Panel _pnlContent, int indexSelectedRow) : base(ref _pnlContent)
        {
            this.Text = "List Pasien";
            this.btnAddRegistrasiPasienLama.Visible = false;
            this.indexSelectedRow = indexSelectedRow;
            this.indexSelectedRowFromSender = indexSelectedRow;
        }

        protected override void FListIdentitasPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                identitaspasienGV.ClearSelection();
                identitaspasienGV.FocusedRowHandle = this.indexSelectedRowFromSender;
                identitaspasienGV.SelectRow(this.indexSelectedRowFromSender);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void FListIdentitasPasien_Load(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;

                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref identitaspasienPanel);

                ValueDefaultControl();


                //if (identitaspasienGC.DataSource==null)
                LoadVidentitaspasien_jk_alamatpasienByPageIndexAsync(this.PageIndex, this.PageSize);

                this.identitaspasienGC.BeginInit();

                this.identitaspasienGV.BeginInit();
                this.colDetail.VisibleIndex = 10;
                this.identitaspasienGV.ViewCaption = string.Empty;
                this.colEdit.VisibleIndex = 11;
                this.colDelete.VisibleIndex = 12;
                this.colEdit.Visible = false;
                this.colDelete.Visible = false;


                this.identitaspasienGV.EndInit();


                this.identitaspasienGC.MainView = this.identitaspasienGV;
                this.identitaspasienGC.EndInit();

                
                this.identitaspasienGC.Refresh();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void detailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListDetailPasienRM myForm = new FListDetailPasienRM(ref this.pnlContent,
                //    ref this.v_Identitaspasien_Jk_Alamatpasien);

                v_registrasiruangrawat v = new v_registrasiruangrawat
                {
                    nocm = this.v_Identitaspasien_Jk_Alamatpasien.nocm,
                    nama = this.v_Identitaspasien_Jk_Alamatpasien.nama,
                    
                };

                FListRiwayatPenyakitPasienRM myForm = new FListRiwayatPenyakitPasienRM(ref this.pnlContent, 
                    ref v,ref this.indexSelectedRow);


                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndetailrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}
