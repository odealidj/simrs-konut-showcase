using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using SIMRS.DESKTOP.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRI
{
    public class FLoginRegistrasiRI : FLoginRegistrasiRJ
    {
        public FLoginRegistrasiRI() : base()
        {
            Modul.modulkode = "md004.1"; Modul.modulname = "Modul Registrasi Rawat Inap";

            this.Text = "Login Modul Registrasi Rawat Inap";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "regri01";
            this.mtxtPassword.Text = "regri01";
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
                FMainMenuRegistrasiRI fmenu = new FMainMenuRegistrasiRI();
                fmenu.ShowDialog();
                this.Close();


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Login()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
