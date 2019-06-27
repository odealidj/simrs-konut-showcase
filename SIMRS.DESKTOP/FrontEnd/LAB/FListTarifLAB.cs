using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.Services.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.LAB
{
    public class FListTarifLAB : FListTarifPoli
    {

        #region protected control method
        protected void LoadAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan)
        {
            try
            {
                using (var service = new TarifServices())
                {
                    var result = service.SelectAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan (ruangrawatid, tindakan);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tarifGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected bool UpdateTarif(int daftartindakanid, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            var result = false;
            try
            {
                using (var service = new TarifServices())
                {
                    result = service.Update(daftartindakanid, harga, jasasarana, jasapelayanan);

                }
            }

            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        #endregion protected control method
        public FListTarifLAB()
        {
            try
            {
                this.Text = "Tarif Laboratorium";
                this.tarifGC.Visible = true;

                LoadAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.Ruangrawat.ruangrawatid, string.Empty);
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
                using (FAddEditTarifLab f = new FAddEditTarifLab(this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakanid,
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

        protected override void cariMtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.Ruangrawat.ruangrawatid, cariMtxt.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariMtxt_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
