using SIMRS.Model;
using SIMRS.Services.FrontEnd.POLI;
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
    public partial class TFLoginRuangRawat : Form
    {

        protected string modulappKode { get; set; }
        protected string modulappNm { get; set; }

        protected loginappdetail loginappDetail;
        protected loginmodulapp loginModulapp;

        #region private method control

        protected async void LoadRuangRawatByPelayananmedikIdAsync(short pelayananmedikid)
        {
            try
            {
                using (var service = new LoginPoliServices())
                {
                    var result = await service.SelectRuangRawatByPelayananmedikIdAsync(pelayananmedikid);

                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        ruangrawatMcb.DataSource = result.Item1;
                        ruangrawatMcb.DisplayMember = "ruangrawatnm";
                        ruangrawatMcb.ValueMember = "ruangrawatid";
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region private method

        protected void LoadPelayananmedikByModulappkode(string modulappkode)
        {
            try
            {
                using (var service = new LoginPoliServices())
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

        protected void LoadDataLogindetailAndModulApp(string username, string password, string modulappkode)
        {

            try
            {
                using (var service = new LoginPoliServices())
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
                        this.loginModulapp = result.Item2;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        #endregion

        public TFLoginRuangRawat()
        {
            InitializeComponent();
            this.picLogo.Location = new Point((this.Width - picLogo.Width) / 2,
               this.picLogo.Location.Y);

            this.ruangrawatMcb.Location = new Point((this.Width - this.ruangrawatMcb.Width) / 2,
               this.ruangrawatMcb.Location.Y);

            this.mtxtUsername.Location = new Point((this.Width - this.mtxtUsername.Width) / 2,
               this.mtxtUsername.Location.Y);

            this.mtxtPassword.Location = new Point((this.Width - this.mtxtPassword.Width) / 2,
              this.mtxtPassword.Location.Y);

            this.mbtnLogin.Left = this.mtxtUsername.Left;
        }

        private void FLoginRuangRawat_Load(object sender, EventArgs e)
        {

        }

        protected virtual void mbtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void ruangrawatMcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ruangrawatMcb.SelectedIndex != -1)
                {
                    Helper.Ruangrawat.ruangrawatid = (ruangrawatMcb.SelectedItem as ruangrawat).ruangrawatid;
                    Helper.Ruangrawat.ruangrawatnm = (ruangrawatMcb.SelectedItem as ruangrawat).ruangrawatnm;
                    Helper.Ruangrawat.pelayananmedikid = (ruangrawatMcb.SelectedItem as ruangrawat).pelayananmedikid;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Login()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
