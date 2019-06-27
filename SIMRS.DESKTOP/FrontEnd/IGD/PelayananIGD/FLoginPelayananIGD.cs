using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD.PelayananIGD
{
    public class FLoginPelayananIGD : TFLoginRuangRawat
    {
        public FLoginPelayananIGD() : base()
        {

            Modul.modulkode = "md.pigd.01"; Modul.modulname = "Modul Pelayanan IGD";

            this.Text = "Login Modul Pelayanan IGD";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "pigd01";
            this.mtxtPassword.Text = "pigd01";

            Helper.kelas.kelasid = 99;
            Helper.kelas.kelasnm = "RD";
            Helper.kelas.kelasuraian = "Rawat Darurat";

            LoadPelayananmedikByModulappkode(this.modulappKode);

            LoadRuangRawatByPelayananmedikIdAsync(Helper.Pelayananmedik.pelayananmedikid);

        }

        protected override void mbtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ruangrawatMcb.SelectedItem == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih poliklinik", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ruangrawatMcb.Focus();
                    return;
                }
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

                this.Hide();
                FMainMenuPelayananIGD fmenu = new FMainMenuPelayananIGD();
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
