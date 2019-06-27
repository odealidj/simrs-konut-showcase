using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS.Model;
using SIMRS.Services.FrontEnd;

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class TFLogin : Form
    {
        protected string modulappKode { get; set; }
        protected string modulappNm { get; set; }

        //protected loginapp loginApp;
        protected loginappdetail loginappDetail;
        protected loginmodulapp loginModulapp;

        //protected void getDataLoginApp(string username, string password)
        //{
        //    try
        //    {

        //        var result = Services.FrontEnd.RegistrasiRJ.LoginRegistrasiRJService.getLoginappByUsernameAndPassword(username, password);
        //        //var data = await result;
        //        if (result.Item2 != null)
        //        {
        //            MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        else
        //        {
        //            this.loginApp = result.Item1;
        //        }
        //        //v_identitaspasien_jk_alamatpasienBindingSource.DataSource =  ListIdentitasPasienRegistrasiRJServices.GetAllv_identitaspasien_jk_alamatpasienByPageIndex(1, 25);
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        protected void getDataLoginAppDetail(loginappdetail loginappdetail)
        {
            try
            {
                using (var service = new LoginServices())
                {
                    var result = service.Get(loginappdetail);
                    //var data = await result;
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.loginappDetail = result.Item1;
                        Helper.LoginAppDetail.loginappdetailid = result.Item1.loginappdetailid;
                        Helper.LoginAppDetail.loginappdetailnik = result.Item1.loginappdetailnik;
                        Helper.LoginAppDetail.loginappdetailnm = result.Item1.loginappdetailnm;
                        Helper.LoginAppDetail.loginappdetaidepartmen = result.Item1.loginappdetaidepartmen;
                    }
                    //v_identitaspasien_jk_alamatpasienBindingSource.DataSource =  ListIdentitasPasienRegistrasiRJServices.GetAllv_identitaspasien_jk_alamatpasienByPageIndex(1, 25);
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //protected async void GetDataLoginappAndDetail(string username, string password)
        //{
        //    try
        //    {

        //        var result = await Services.FrontEnd.RegistrasiRJ.LoginRegistrasiRJService.GetLoginappAndLogindetailAsync(username, password);
        //        //var data = await result;
        //        if (result.Item3 != null)
        //        {
        //            MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        else
        //        {
        //            this.loginApp = result.Item1;
        //            this.loginappDetail = result.Item2;
        //        }
        //        //v_identitaspasien_jk_alamatpasienBindingSource.DataSource =  ListIdentitasPasienRegistrasiRJServices.GetAllv_identitaspasien_jk_alamatpasienByPageIndex(1, 25);
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        protected void LoadDataLogindetailAndModulApp(string username, string password, string modulappkode)
        {

            try
            {
                using (var service = new LoginServices())
                {
                    var result = service.GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode(username, password, modulappkode);
                    if (result.Item3 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.loginappDetail = result.Item1;
                        Helper.LoginAppDetail.loginappdetailid = result.Item1.loginappdetailid;
                        Helper.LoginAppDetail.loginappdetailnik = result.Item1.loginappdetailnik;
                        Helper.LoginAppDetail.loginappdetailnm = result.Item1.loginappdetailnm;
                        Helper.LoginAppDetail.loginappdetaidepartmen = result.Item1.loginappdetaidepartmen;
                        this.loginModulapp = result.Item2;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected async void LoadPelayananmedikByModulappkodeAsync(string modulappkode)
        {
            try
            {
                using (var service = new LoginServices())
                {
                    var result = await service.GetAllPelayananmedikByModulappkodeAsync(modulappkode);

                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Helper.Pelayananmedik.pelayananmedikid = result.Item1.pelayananmedikid;
                        Helper.Pelayananmedik.pelayananmediknm = result.Item1.pelayananmediknm;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected void LoadPelayananmedikByModulappkode(string modulappkode)
        {
            try
            {
                using (var service = new LoginServices())
                {
                    var result = service.GetAllPelayananmedikByModulappkode(modulappkode);

                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Helper.Pelayananmedik.pelayananmedikid = result.Item1.pelayananmedikid;
                        Helper.Pelayananmedik.pelayananmediknm = result.Item1.pelayananmediknm;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public TFLogin()
        {
            InitializeComponent();

            this.picLogo.Location = new Point((this.Width - picLogo.Width) / 2,
               this.picLogo.Location.Y);

           
            this.mtxtUsername.Location = new Point(((this.Width - this.mtxtUsername.Width) / 2) +20,
               this.mtxtUsername.Location.Y);

            this.mtxtPassword.Location = new Point((this.Width - this.mtxtPassword.Width) / 2,
              this.mtxtPassword.Location.Y);

            this.mbtnLogin.Left = this.mtxtUsername.Left;
        }

       

        public TFLogin(string modulappkode, string modulappnm)
        {
            InitializeComponent();

            this.modulappKode = modulappkode;
            this.modulappNm = modulappnm;

            this.picLogo.Location = new Point((this.Width - picLogo.Width) / 2,
               this.picLogo.Location.Y);

           

        }

        protected virtual void mbtnLogin_Click(object sender, EventArgs e)
        {
            //getDataLoginApp(mtxtUsername.Text, mtxtPassword.Text);
            //if (this.loginApp != null)
            //{
            //    this.loginappDetail = new loginappdetail
            //    {
            //        loginappdetailid = this.loginApp.loginappid
            //    };
            //    getDataLoginAppDetail(this.loginappDetail);
            //}
        }

        protected virtual void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TFLogin_Load(object sender, EventArgs e)
        {
            this.mtxtUsername.Location = new Point((this.Width - this.mtxtUsername.Width) / 2,
              this.mtxtUsername.Location.Y);

            this.mtxtPassword.Location = new Point((this.Width - this.mtxtPassword.Width) / 2,
              this.mtxtPassword.Location.Y);

            this.mbtnLogin.Left = this.mtxtUsername.Left;
            this.Location = new Point(this.Location.X + 100, this.Location.Y + 20);
        }
    }
}
