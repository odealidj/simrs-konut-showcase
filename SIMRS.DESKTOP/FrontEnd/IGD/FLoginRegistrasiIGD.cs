using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;

using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD
{
    public class FLoginRegistrasiIGD : FLoginRegistrasiRJ
    {
        public FLoginRegistrasiIGD()
        {

            Modul.modulkode = "md003.1"; Modul.modulname = "Modul Registrasi Rawat Darurat";

            this.Text = "Login Modul Registrasi Rawat Darurat";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "regrd01";
            this.mtxtPassword.Text = "regrd01";
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
                FMainMenuRegistrasiRD fmenu = new FMainMenuRegistrasiRD();
                fmenu.ShowDialog();
                this.Close();

                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Login()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        protected override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
