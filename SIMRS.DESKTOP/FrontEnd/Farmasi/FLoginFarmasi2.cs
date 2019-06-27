using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.frm.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi
{
    public class FLoginFarmasi2 : TFLoginRuangRawat
    {
        private TFWalpaper frm;

        public FLoginFarmasi2(TFWalpaper frm) :base()
        {
            this.frm = frm;

            Modul.modulkode = "md.far.01";
            Modul.modulname = "Modul Farmasi";

            this.Text = "Login Modul Farmasi";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "far01";
            this.mtxtPassword.Text = "far01";

            LoadPelayananmedikByModulappkode(this.modulappKode);

            LoadRuangRawatByPelayananmedikIdAsync(Helper.Pelayananmedik.pelayananmedikid);
        }

        protected override void mbtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ruangrawatMcb.SelectedItem == null)
                {
                    CustomMessageBox.MessageWarning("Silahkan pilih ruang farmasi", this);
                    ruangrawatMcb.Focus();
                    return;
                }
                if (mtxtUsername.Text == null)
                {
                    CustomMessageBox.MessageWarning("Username tidak boleh kosong", this);
                    mtxtUsername.Focus();
                    return;
                }

                if (mtxtPassword.Text == null)
                {
                    CustomMessageBox.MessageWarning("Password tidak boleh kosong",this);
                    mtxtPassword.Focus();
                    return;
                }

                LoadDataLogindetailAndModulApp(mtxtUsername.Text, mtxtPassword.Text, this.modulappKode);

                if (this.loginappDetail == null)
                {
                    CustomMessageBox.MessageWarning("Login tidak valid", this);
                    mtxtUsername.Focus();
                    return;
                }

                if (this.loginModulapp == null)
                {
                    CustomMessageBox.MessageWarning("Modul tidak valid", "Message", this);
                    mtxtUsername.Focus();
                    return;
                }

                if (this.loginappDetail.loginappdetailid != this.loginModulapp.loginappid)
                {
                    CustomMessageBox.MessageWarning("Login tidak valid", this);
                    mtxtUsername.Focus();
                    return;
                }


                this.Hide();
                this.frm.Hide();
                TFMainMenuFarmasi fmenu = new TFMainMenuFarmasi();
                //fmenu.ShowDialog();
                //this.Close();

                if (fmenu.ShowDialog() == DialogResult.OK)
                {
                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {
                        if (!string.IsNullOrEmpty(thisForm.Name))
                        {
                            if (thisForm.Name != "TFLoginRuangRawat") thisForm.Close();
                        }
                        else
                        {
                            if (thisForm.OwnedForms.Length > 0)
                            {
                                if (thisForm.OwnedForms[0].Name != "TFLoginRuangRawat") thisForm.Close();
                            }
                        }


                    }

                    this.Close();
                }
                else if (fmenu.DialogResult == DialogResult.No)
                {
                    this.mtxtUsername.Text = "far01";
                    this.mtxtPassword.Text = "far01";

                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {
                        if (!string.IsNullOrEmpty(thisForm.Name))
                        {
                            if (thisForm.Name != "TFLoginRuangRawat")
                            {
                                if (thisForm.Name != "TFWalpaper")
                                    thisForm.Close();
                            }
                        }
                        else
                        {
                            if (thisForm.OwnedForms.Length > 0)
                            {
                                if (thisForm.OwnedForms[0].Name != "TFLoginRuangRawat") thisForm.Close();
                            }
                        }


                    }

                    this.frm.Show();
                    this.Show();

                }
                else
                {
                    Application.Exit();
                }



            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message + "\n Login()", this);
            }
        }
    }
}
