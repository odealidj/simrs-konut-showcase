using SIMRS.Model;
using SIMRS.Services.FrontEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class TFLogin2 : Form
    {
        protected string modulappKode { get; set; }
        protected string modulappNm { get; set; }

        //protected loginapp loginApp;
        protected loginappdetail loginappDetail;
        protected loginmodulapp loginModulapp;


        #region private methode
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

        #endregion private methode

        public TFLogin2()
        {
            InitializeComponent();

            this.picLogo.Location = new Point((this.Width - picLogo.Width) / 2,
               this.picLogo.Location.Y);


            this.mtxtUsername.Location = new Point((this.Width - this.mtxtUsername.Width) / 2,
               this.mtxtUsername.Location.Y);

            this.mtxtPassword.Location = new Point((this.Width - this.mtxtPassword.Width) / 2,
              this.mtxtPassword.Location.Y);

            this.mbtnLogin.Left = this.mtxtUsername.Left;
        }

        public TFLogin2(string modulappkode, string modulappnm)
        {
            InitializeComponent();

            this.modulappKode = modulappkode;
            this.modulappNm = modulappnm;

            this.picLogo.Location = new Point((this.Width - picLogo.Width) / 2,
               this.picLogo.Location.Y);


            this.mtxtUsername.Location = new Point((this.Width - this.mtxtUsername.Width) / 2,
               this.mtxtUsername.Location.Y);

            this.mtxtPassword.Location = new Point((this.Width - this.mtxtPassword.Width) / 2,
              this.mtxtPassword.Location.Y);

            this.mbtnLogin.Left = this.mtxtUsername.Left;
        }


        protected virtual void MbtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
