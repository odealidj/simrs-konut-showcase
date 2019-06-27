using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RAD
{
    public class FListRegistrasiRAD : FListRegistrasiLAB
    {
        public FListRegistrasiRAD(ref Panel _pnlContent):base(ref _pnlContent)
        {
            this.Text = "List Pasien Radiologi";

        }

        public FListRegistrasiRAD(ref Panel _pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, int indexSelectedRegistrasi) : base(ref _pnlContent)
        {

            //Contructor Back From Tindakan RAD

            ////Helper.Stsregistrasi.stsregistrasiid = 1;


            this.Text = "List Pasien Radiologi";
            ////this.coltglregistrasipenunjang.Visible = true;
            ////btnAdd.Text = "Tambah Pasien";

            ////this.bTindakan.Visible = false;

            ////this.registerRepositoryItemButtonEdit.Buttons[0].Caption = "Tindakan";


            ////try
            ////{
            ////    Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

            ////    this.PageIndex = 1;
            ////    ////LoadVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
            ////    ////    Helper.Pelayananmedik.pelayananmedikid, Helper.Stsregistrasi.stsregistrasiid, string.Empty);

            ////    this.v_Registrasiruangrawat_Penunjang = v_Registrasiruangrawat_Penunjang;
            ////    //this.indexRow = indexRow;
            ////    this.indexSelectedDetailRegistrasiFromSender = indexSelectedRegistrasi;
            ////    tglregistrasiDateEdit.EditValue = this.v_Registrasiruangrawat_Penunjang.tglmasuk.Value.Date;

            ////    registrasiGV.ClearSelection();
            ////    registrasiGV.FocusedRowHandle = this.indexSelectedDetailRegistrasiFromSender;
            ////    registrasiGV.SelectRow(this.indexSelectedDetailRegistrasiFromSender);

            ////    registrasidetailGV.ClearSelection();
            ////    registrasidetailGV.FocusedRowHandle = 0;
            ////    registrasidetailGV.SelectRow(0);

            ////}
            ////catch (Exception ex)
            ////{
            ////    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}


        }

        protected override void registerRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if ((this.v_Distinctpasienpenunjang == null) || (this.v_Registrasiruangrawat_Penunjang == null)) return;


                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();

                FTindakanPasienRAD myForm = new FTindakanPasienRAD(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref indexSelectedRegistrasi);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nregisterRepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListCariPasienRAD myForm = new FListCariPasienRAD(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }


        //protected override void bTindakan_Click(object sender, EventArgs e)
        //{
        //    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

        //    this.pnlContent.Controls.Clear();
        //    //fDashboard myForm = new fDashboard();
        //    FTindakanPasienRAD myForm = new FTindakanPasienRAD();
        //    myForm.TopLevel = false;
        //    myForm.AutoScroll = true;
        //    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
        //    this.pnlContent.Controls.Add(myForm);
        //    myForm.Dock = DockStyle.Fill;
        //    myForm.Show();
        //}


    }
}
