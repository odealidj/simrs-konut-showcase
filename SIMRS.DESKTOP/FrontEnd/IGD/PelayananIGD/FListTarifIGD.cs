using SIMRS.DESKTOP.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.IGD.PelayananIGD
{
    public class FListTarifIGD : FListTarifPoli
    {
        public FListTarifIGD()
        {
            try
            {
                this.Text = "Tarif Pelayanan IGD";
                this.tarifGC.Visible = true;

                ////Loadv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.kelas.kelasid, Helper.Ruangrawat.ruangrawatid, string.Empty);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListTarifPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void edittarifrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FAddEditTarifIGD f = new FAddEditTarifIGD(this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakanid,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.kelasid,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakannm,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.biaya.Value,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasasarana.Value,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasapelayanan.Value))
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passDataTarif += new FAddEditTarifPoli.PassDataTarif(passDataTarif);
                    f.ShowDialog();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passDataTarif(int daftartindakanid, short kelasid,
        decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            if (UpdateTarif(daftartindakanid, kelasid, harga, jasasarana, jasapelayanan) == false)
            {

                MetroFramework.MetroMessageBox.Show(this, "Perubahan tarif tidak valid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Loadv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.kelas.kelasid, Helper.Ruangrawat.ruangrawatid, cariMtxt.Text);
            }
        }
    }
}
