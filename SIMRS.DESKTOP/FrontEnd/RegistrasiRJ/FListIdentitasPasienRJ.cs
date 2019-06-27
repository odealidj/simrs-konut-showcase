using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    
    public class FListIdentitasPasienRJ : FListIdentitasPasien
    {

        private int indexSelectedRowSender = -1;

        #region private method control
        //private void loadDataCboKriteria()
        //{
        //    try
        //    {


        //        //v_identitaspasien_jk_alamatpasienBindingSource.DataSource =  ListIdentitasPasienRegistrasiRJServices.GetAllv_identitaspasien_jk_alamatpasienByPageIndex(1, 25);
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private async void LoadDataPasien(int pageIndex, int pageSize)
        //{
        //    try
        //    {

        //        var result = await ListIdentitasPasienRegistrasiRJServices.GetAllv_identitaspasien_jk_alamatpasienByPageIndex(1, 25);
        //        //var data = await result;
        //        if (result.Item2 != null)
        //        {
        //            MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        else
        //        {
        //            v_identitaspasien_jk_alamatpasienBindingSource.DataSource = result.Item1;
        //        }
        //        //v_identitaspasien_jk_alamatpasienBindingSource.DataSource =  ListIdentitasPasienRegistrasiRJServices.GetAllv_identitaspasien_jk_alamatpasienByPageIndex(1, 25);
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion

        public FListIdentitasPasienRJ()
        {

        }

        public FListIdentitasPasienRJ (ref Panel _pnlContent) : base(ref _pnlContent)
        {
            btnAddRegistrasiPasienLama.Text = "Register";
           
        }

        public FListIdentitasPasienRJ(ref Panel _pnlContent,int indexSelectedRowSender) : base(ref _pnlContent)
        {
            btnAddRegistrasiPasienLama.Text = "Register";
            this.indexSelectedRowSender = indexSelectedRowSender;
            
        }

        public FListIdentitasPasienRJ(ref Panel _pnlContent, string titleform) : base(ref _pnlContent)
        {
            this.Text = titleform;
        }


        protected override void FListIdentitasPasien_Load(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;

                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref identitaspasienPanel);

                ValueDefaultControl();
                LoadVidentitaspasien_jk_alamatpasienByPageIndexAsync(this.PageIndex, this.PageSize);
                identitaspasienGV.ClearSelection();
                identitaspasienGV.FocusedRowHandle = this.indexSelectedRowSender;
                identitaspasienGV.SelectRow(this.indexSelectedRowSender);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        protected override void FListIdentitasPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                identitaspasienGV.ClearSelection();
                identitaspasienGV.FocusedRowHandle = this.indexSelectedRowSender;
                identitaspasienGV.SelectRow(this.indexSelectedRowSender);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        protected override void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {
            try
            {
                if (identitaspasienGV.GetSelectedRows().Count() == 0)
                {
                    //MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih atau klik data pasien yang akan diregistrasikan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var data = identitaspasienGV.GetRow(identitaspasienGV.GetSelectedRows()[0]) as v_identitaspasien_jk_alamatpasien;

                if (data == null)
                {
                    identitaspasienGV.SelectRow(0);
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih atau klik data pasien yang akan diregistrasikan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FAddEditRegistrasiPasienLamaRJ myForm = new FAddEditRegistrasiPasienLamaRJ(ref this.pnlContent, data.nocm);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                try
                {
                    if (this.v_Identitaspasien_Jk_Alamatpasien != null)
                    {

                        Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                        this.pnlContent.Controls.Clear();

                        FEditIdentitasPasien myForm = new FEditIdentitasPasien(ref this.pnlContent, this.v_Identitaspasien_Jk_Alamatpasien.nocm, this.indexSelectedRow);
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
                    MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndetailrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndetailrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void detailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                try
                {
                    if (this.v_Identitaspasien_Jk_Alamatpasien != null)
                    {

                        //nocm, namapasien,umur,pekerjaan,alamat,penjamin

                        v_registrasiruangrawat vregistrasiruangrawat = new v_registrasiruangrawat
                        {
                            nocm = this.v_Identitaspasien_Jk_Alamatpasien.nocm,
                            nama = this.v_Identitaspasien_Jk_Alamatpasien.nama,
                            thn = short.Parse((this.v_Identitaspasien_Jk_Alamatpasien.thn == string.Empty) ? "0" : this.v_Identitaspasien_Jk_Alamatpasien.thn),
                            bulan = short.Parse((this.v_Identitaspasien_Jk_Alamatpasien.bulan == string.Empty) ? "0" : this.v_Identitaspasien_Jk_Alamatpasien.bulan),
                            hari = short.Parse((this.v_Identitaspasien_Jk_Alamatpasien.hari == string.Empty) ? "0" : this.v_Identitaspasien_Jk_Alamatpasien.hari),
                            alamat = string.Format("{0}", this.v_Identitaspasien_Jk_Alamatpasien.alamat),
                            penjaminpasienid = this.v_Identitaspasien_Jk_Alamatpasien.pekerjaanid,

                        };

                        Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                        this.pnlContent.Controls.Clear();

                        FListRiwayatPenyakitPasienRJ myForm = new FListRiwayatPenyakitPasienRJ(ref this.pnlContent, ref vregistrasiruangrawat, ref this.indexSelectedRow, this);
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
                    MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndetailrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndetailrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
