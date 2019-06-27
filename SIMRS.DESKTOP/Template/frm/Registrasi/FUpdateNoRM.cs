using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Registrasi
{
    public partial class FUpdateNoRM : MetroFramework.Forms.MetroForm
    {

        public delegate void PassNoRM(object oldNoRM, object newNoRM);
        public PassNoRM passNoRM;


        protected bool IsNoRMIsExists(string norm)
        {
            using (var service = new RegistrasiPasienServices())
            {
                return service.IsNoRMIsExists(norm);


            }
        }

        public FUpdateNoRM()
        {
            InitializeComponent();
            this.Text = "Edit No.RM";
        }

        public FUpdateNoRM(string norm)
        {
            InitializeComponent();
            try
            {
                this.Text = "Edit No.RM";
                this.normlamaMtxt.ReadOnly = true;
                this.normlamaMtxt.Text = norm;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n FUpdateNoRM()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void bUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.normlamaMtxt.Text)) return;
            if (string.IsNullOrEmpty(this.normbaruMtxt.Text)) return;
            if (this.normlamaMtxt.Text.ToUpper()== this.normbaruMtxt.Text.ToUpper())
            {
                MetroFramework.MetroMessageBox.Show(this, "No.RM lama tidak boleh sama dengan No.RM baru!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                normbaruMtxt.Focus();
                return;
            }

            if (IsNoRMIsExists(this.normbaruMtxt.Text)==true)
            {
                MetroFramework.MetroMessageBox.Show(this, "No.RM :"+this.normbaruMtxt.Text+" yang diinputkan sudah terpakai!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                normbaruMtxt.Focus();
                return;
            }

            if(this.passNoRM!=null)
            {
                passNoRM(this.normlamaMtxt.Text, this.normbaruMtxt.Text);

            }
            this.Close();

        }

        protected virtual void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
