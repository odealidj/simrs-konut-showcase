using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.DESKTOP.Template.frm.SIE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.SIE
{
    public class FLoginSIE : TFLogin2
    {
        private TFWalpaper frm;

        public FLoginSIE(TFWalpaper frm) : base()
        {
            this.frm = frm;

            Modul.modulkode = "md.sie.01";
            Modul.modulname = "Modul Sistem Informasi Eksekutif";

            this.Text = "Login Modul SIE";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "dir";
            this.mtxtPassword.Text = "dir";

            
            
        }

        protected override void MbtnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (mtxtUsername.Text == null)
                {
                    CustomMessageBox.MessageWarning("Username tidak boleh kosong", "Message", this);
                    mtxtUsername.Focus();
                    return;
                }

                if (mtxtPassword.Text == null)
                {
                    CustomMessageBox.MessageWarning("Password tidak boleh kosong", this);
                    
                    mtxtPassword.Focus();
                    return;
                }

                LoadDataLogindetailAndModulApp(mtxtUsername.Text, mtxtPassword.Text, this.modulappKode);

                if (this.loginappDetail == null)
                {
                    CustomMessageBox.MessageError("Login tidak valid", this);
                    mtxtUsername.Focus();
                    return;
                }

                if (this.loginModulapp == null)
                {
                    CustomMessageBox.MessageError("Modul tidak valid", this);
                    mtxtUsername.Focus();
                    return;
                }

                if (this.loginappDetail.loginappdetailid != this.loginModulapp.loginappid)
                {
                    CustomMessageBox.MessageError("Login tidak valid", this);
                    mtxtUsername.Focus();
                    return;
                }

                LoadPelayananmedikByModulappkodeAsync(this.loginModulapp.modulappkode);

                this.Hide();
                this.frm.Hide();
                FMainMenuSIE fmenu = new FMainMenuSIE();
                //fmenu.ShowDialog();
                //this.Close();

                if (fmenu.ShowDialog() == DialogResult.OK)
                {
                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {
                        if (!string.IsNullOrEmpty(thisForm.Name))
                        {
                            if (thisForm.Name != "TFLogin2") thisForm.Close();
                        }
                        else
                        {
                            if (thisForm.OwnedForms.Length > 0)
                            {
                                if (thisForm.OwnedForms[0].Name != "TFLogin2") thisForm.Close();
                            }
                        }


                    }

                    this.Close();
                }
                else if (fmenu.DialogResult == DialogResult.No)
                {
                    this.mtxtUsername.Text = "dir";
                    this.mtxtPassword.Text = "dir";

                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {
                        if (!string.IsNullOrEmpty(thisForm.Name))
                        {
                            if (thisForm.Name != "TFLogin2")
                            {
                                if (thisForm.Name != "TFWalpaper")
                                    thisForm.Close();
                            }
                        }
                        else
                        {
                            if (thisForm.OwnedForms.Length > 0)
                            {
                                if (thisForm.OwnedForms[0].Name != "TFLogin2") thisForm.Close();
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
                CustomMessageBox.MessageError(ex.InnerException.Message, "Login()", this.Name, this);
                
            }

        }

    }
}
