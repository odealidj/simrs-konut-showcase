using SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FEDetailPembelianNotInGudang : FEDetailPembelian
    {
        private Dictionary<int, string> ParamListBarangMasukGudang;
        public FEDetailPembelianNotInGudang(ref Panel pnlContent, ref aptbarangmasuk Aptbarangmasuk,
            Dictionary<int, string> ParamListBarangMasukGudang) : base(ref pnlContent, ref Aptbarangmasuk, ParamListBarangMasukGudang)
        {
            this.Text = "Barang Masuk Gudang -> List Pembelian -> Detail Item Pembelian";
            this.ParamListBarangMasukGudang = ParamListBarangMasukGudang;
        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListPembelianNotInGudang myForm = new FListPembelianNotInGudang(ref this.pnlContent, this.ParamListBarangMasukGudang);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
