using SIMRS.DESKTOP.Template.frm;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis
{
    public class FListRegistrasiByPasien : FListFour
    {
        private MetroFramework.Controls.MetroButton metroButton1;

        public FListRegistrasiByPasien(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "List Registrasi Berdasarkan Pasien";
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CaridataMTxt
            // 
            // 
            // 
            // 
            this.CaridataMTxt.CustomButton.Image = null;
            this.CaridataMTxt.CustomButton.Location = new System.Drawing.Point(723, 1);
            this.CaridataMTxt.CustomButton.Name = "";
            this.CaridataMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CaridataMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CaridataMTxt.CustomButton.TabIndex = 1;
            this.CaridataMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CaridataMTxt.CustomButton.UseSelectable = true;
            this.CaridataMTxt.CustomButton.Visible = false;
            this.CaridataMTxt.Lines = new string[0];
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 538);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 34;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FListRegistrasiByPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FListRegistrasiByPasien";
            this.Controls.SetChildIndex(this.CaridataMTxt, 0);
            this.Controls.SetChildIndex(this.metroButton1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListIcdxByRegistrasi myForm = new FListIcdxByRegistrasi();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
