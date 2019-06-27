using SIMRS.DESKTOP.FrontEnd.LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FListTarifGizi : FListTarifLAB
    {
        public FListTarifGizi()
        {
            try
            {
                this.Text = "Tarif Gizi";
                this.tarifGC.Visible = true;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListTarifGizi()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void edittarifrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FAddEditTarifGizi f = new FAddEditTarifGizi(this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakanid,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakannm,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.biaya.Value,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasasarana.Value,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasapelayanan.Value))
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passDataTarif += new FAddEditTarifLab.PassDataTarif(passDataTarif);
                    f.ShowDialog();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passDataTarif(int daftartindakanid,
        decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            if (UpdateTarif(daftartindakanid, harga, jasasarana, jasapelayanan) == false)
            {

                MetroFramework.MetroMessageBox.Show(this, "Perubahan tarif tidak valid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.Ruangrawat.ruangrawatid, cariMtxt.Text);
            }
        }
    }
}
