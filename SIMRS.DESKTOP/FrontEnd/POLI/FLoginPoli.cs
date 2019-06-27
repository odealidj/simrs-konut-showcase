using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Services.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FLoginPoli : TFLoginRuangRawat
    {
        

        public FLoginPoli() : base()
        {

            Modul.modulkode = "md.po.01"; Modul.modulname = "Modul Poliklinik";

            this.Text = "Login Modul Poliklinik";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "polianak01";
            this.mtxtPassword.Text = "polianak01";


            Helper.kelas.kelasid = 98;
            Helper.kelas.kelasnm = "RJ";
            Helper.kelas.kelasuraian = "Rawat Jalan";
           

            LoadPelayananmedikByModulappkode(this.modulappKode );

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
                FMainMenuPoli fmenu = new FMainMenuPoli();
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
