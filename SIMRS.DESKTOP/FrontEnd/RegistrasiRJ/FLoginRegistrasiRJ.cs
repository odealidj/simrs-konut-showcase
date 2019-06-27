using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Services.FrontEnd;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    
    public class FLoginRegistrasiRJ : TFLogin
    {
        protected TFWalpaper frm;
        //private string mdappid = "md002.1";
        //private string mdappnm = "Modul Registrasi Rawat Jalan";

        //private loginmodulapp loginModulApp;
        //private string errresult;

        public FLoginRegistrasiRJ() : base()
        {

            
            Modul.modulkode = "md002.1"; Modul.modulname = "Modul Registrasi Rawat Jalan";

            this.Text = "Login Modul Registrasi Rawat Jalan";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "regrj01";
            this.mtxtPassword.Text = "regrj01";
        }

        public FLoginRegistrasiRJ(TFWalpaper frm) : base()
        {

            this.frm = frm;
            Modul.modulkode = "md002.1"; Modul.modulname = "Modul Registrasi Rawat Jalan";

            this.Text = "Login Modul Registrasi Rawat Jalan";
            this.modulappKode = Modul.modulkode;
            this.modulappNm = Modul.modulname;

            this.mtxtUsername.Text = "regrj01";
            this.mtxtPassword.Text = "regrj01";
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

                //this.Hide();
                //FMainMenuRegistrasiRJ fmenu = new FMainMenuRegistrasiRJ();
                //fmenu.ShowDialog();
                //this.Close();

                this.Hide();
                this.frm.Hide();
                FMainMenuRegistrasiRJ fmenu = new FMainMenuRegistrasiRJ();
                //fmenu.ShowDialog();
                //this.Close();

                if (fmenu.ShowDialog() == DialogResult.OK)
                {
                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {
                        if (!string.IsNullOrEmpty(thisForm.Name))
                        {
                            if (thisForm.Name != "TFLogin") thisForm.Close();
                        }
                        else
                        {
                            if (thisForm.OwnedForms.Length > 0)
                            {
                                if (thisForm.OwnedForms[0].Name != "TFLogin") thisForm.Close();
                            }
                        }


                    }

                    this.Close();
                }
                else if (fmenu.DialogResult == DialogResult.No)
                {
                    this.mtxtUsername.Text = "dir";
                    this.mtxtPassword.Text = "dir";

                    this.mtxtUsername.Text = "regrj01";
                    this.mtxtPassword.Text = "regrj01";

                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {
                        if (!string.IsNullOrEmpty(thisForm.Name))
                        {
                            if (thisForm.Name != "TFLogin")
                            {
                                if (thisForm.Name != "TFWalpaper")
                                    thisForm.Close();
                            }
                        }
                        else
                        {
                            if (thisForm.OwnedForms.Length > 0)
                            {
                                if (thisForm.OwnedForms[0].Name != "TFLogin") thisForm.Close();
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
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n Login()","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            // 
            // mtxtUsername
            // 
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.Lines = new string[0];
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // FLoginRegistrasiRJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(436, 298);
            this.Name = "FLoginRegistrasiRJ";
            this.Text = "A";
            this.ResumeLayout(false);

        }
    }
}
