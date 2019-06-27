

using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRI
{
    public class FListRegistrasiRI : FListRegistrasiRJ
    {
        public FListRegistrasiRI(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "List Registrasi Pasien [Rawat Inap]";

            this.colkelasnm.Visible = true;
            this.colkamarnm.Visible = true;
            this.colruangrawatnm.Caption = "R. RAWAT";
            coltglmasuk.VisibleIndex = 0;
            coljammasuk.VisibleIndex = 0;
            colnoregistrasi.VisibleIndex = 1;
            colnocm.VisibleIndex = 2;
            colnama.VisibleIndex = 3;
            coljknm.VisibleIndex = 4;
            coltanggallahir.VisibleIndex = 5;
            colthn.VisibleIndex = 6;
            colbulan.VisibleIndex = 7;
            colhari.VisibleIndex = 8;
            colruangrawatnm.VisibleIndex = 9;

            this.colkelasnm.VisibleIndex = 10;
            this.colkamarnm.VisibleIndex = 11;
            colpenjaminpasiennm.VisibleIndex = 12;
            RegistrasiGC.Refresh();

            this.btnAddRegistrasiPasienLama.Visible = false;


            
            

            //this.tglregistrasiDateEdit.EditValue = new 

            //RegistrasiGV.SelectRow(1);
            //RegistrasiGV.Focus();
        }

        protected override void FListRegistrasi_Shown(object sender, EventArgs e)
        {
            this.btnAddRegistrasiPasienLama.Visible = false;
        }

        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FlistBedRI myForm = new FlistBedRI(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        
    }
   
}

