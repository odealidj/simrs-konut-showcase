using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FTarifGizi : FTarifLAB2
    {
        public FTarifGizi()
        {
            this.Text = "Tarif Gizi";
        }

        public FTarifGizi(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref int indexSelectedRowFromSender) : base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang, ref indexSelectedRowFromSender)
        {
            try
            {
                //Constructor Add Tarif RAD
                this.indexSelectedRowFromSender = indexSelectedRowFromSender;
                this.Text = "Add Tindakan Gizi";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifGizi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FTarifGizi(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref v_tindakanpenunjang v_Tindakanpenunjang) : base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang, ref v_Tindakanpenunjang)
        {
            try
            {
                //Contructor Edit TarifLAB
                this.Text = "Add / Edit Tindakan Gizi";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifGizi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat);
                FTindakanPasienGizi myForm = new FTindakanPasienGizi(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.indexSelectedRowFromSender);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
