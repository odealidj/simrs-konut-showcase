using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Kasir
{
    public class FLoginKasir : TFLogin
    {
        public FLoginKasir() : base()
        {

            Modul.modulkode = "md.ka.01"; Modul.modulname = "Modul Kasir";

            this.Text = "Login Modul Kasir";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "ksr01";
            this.mtxtPassword.Text = "ksr01";
        }

        protected override void mbtnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (mtxtUsername.Text == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username tidak boleh kosong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtUsername.Focus();
                    return;
                }

                if (mtxtPassword.Text == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password tidak boleh kosong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtPassword.Focus();
                    return;
                }

                LoadDataLogindetailAndModulApp(mtxtUsername.Text, mtxtPassword.Text, this.modulappKode);

                if (this.loginappDetail == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Login tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtUsername.Focus();
                    return;
                }

                if (this.loginModulapp == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Modul tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtUsername.Focus();
                    return;
                }

                if (this.loginappDetail.loginappdetailid != this.loginModulapp.loginappid)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Login tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtUsername.Focus();
                    return;
                }

                LoadPelayananmedikByModulappkodeAsync(this.loginModulapp.modulappkode);

                this.Hide();
                FMainMenuKasir fmenu = new FMainMenuKasir();
                fmenu.ShowDialog();
                this.Close();

                //GetDataLoginappAndDetail(mtxtUsername.Text, mtxtPassword.Text);
                //getDataLoginApp(mtxtUsername.Text, mtxtPassword.Text);
                //if (this.loginApp != null)
                //{
                //    //this.loginappDetail = new loginappdetail
                //    //{
                //    //    loginappdetailid = this.loginApp.loginappid
                //    //};
                //    //getDataLoginAppDetail(this.loginappDetail);


                //    //getLoginModulApp(this.loginApp.loginappid, this.modulappKode);

                //    if ((this.loginModulApp!=null) && (this.loginApp!=null) && (this.loginModulApp!=null))
                //    {
                //        this.Hide();
                //        FMainMenuRegistrasiRJ fmenu = new FMainMenuRegistrasiRJ();
                //        fmenu.ShowDialog();
                //        this.Close();
                //    }
                //}
                //else
                //{
                //    MetroFramework.MetroMessageBox.Show(this, "Login tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Login()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
