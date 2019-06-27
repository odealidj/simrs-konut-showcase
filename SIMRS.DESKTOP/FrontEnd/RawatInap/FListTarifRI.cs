using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FListTarifRI : TFListOne
    {

        private v_tarif_withaout_jenistarif_penjaminid v_Tarif_Withaout_Jenistarif_Penjaminid;

        #region protected control method
        private void LoadAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan)
        {
            try
            {
                using (var service = new TarifServices())
                {
                    var result = service.SelectAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(ruangrawatid, tindakan);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tarifriGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected bool UpdateTarif(int daftartindakanid, short kelasid, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            var result = false;
            try
            {
                using (var service = new TarifServices())
                {
                    result = service.Update(daftartindakanid, kelasid, harga, jasasarana, jasapelayanan);

                }
            }

            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        #endregion protected control method

        public FListTarifRI()
        {
            try
            {
                this.Text = "Tarif Rawat Inap";
                this.tarifriGC.Visible = true;
                LoadAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.Ruangrawat.ruangrawatid, string.Empty);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListTarifPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListOne_Load(object sender, EventArgs e)
        {

        }

        protected override void FListOne_Shown(object sender, EventArgs e)
        {

        }

        protected override void cariMtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.Ruangrawat.ruangrawatid, cariMtxt.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncariMtxt_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tarifriGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.indexSelectedRow = e.FocusedRowHandle;
                this.v_Tarif_Withaout_Jenistarif_Penjaminid = tarifriGV.GetRow(e.FocusedRowHandle) as v_tarif_withaout_jenistarif_penjaminid;
                if (this.v_Tarif_Withaout_Jenistarif_Penjaminid != null)
                {
                    /*lblSelect.Text = string.Format("Selected => Tarif: {0}, Harga: {1}, JS: {2}, JP: {3}",
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakannm,
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.biaya.Value.ToString("#,0"),
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasasarana.Value.ToString("#,0"),
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasapelayanan.Value.ToString("#,0"));*/

                }
                //data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tarifriGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.indexSelectedRow = e.RowHandle;
                this.v_Tarif_Withaout_Jenistarif_Penjaminid = tarifriGV.GetRow(e.RowHandle) as v_tarif_withaout_jenistarif_penjaminid;
                if (this.v_Tarif_Withaout_Jenistarif_Penjaminid != null)
                {
                    /*lblSelect.Text = string.Format("Selected => Tarif: {0}, Harga: {1}, JS: {2}, JP: {3}",
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakannm,
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.biaya.Value.ToString("#,0"),
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasasarana.Value.ToString("#,0"),
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasapelayanan.Value.ToString("#,0"));*/

                }
                //data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tarifriGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.indexSelectedRow = e.RowHandle;
                this.v_Tarif_Withaout_Jenistarif_Penjaminid = tarifriGV.GetRow(e.RowHandle) as v_tarif_withaout_jenistarif_penjaminid;
                if (this.v_Tarif_Withaout_Jenistarif_Penjaminid != null)
                {
                    /*lblSelect.Text = string.Format("Selected => Tarif: {0}, Harga: {1}, JS: {2}, JP: {3}",
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakannm,
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.biaya.Value.ToString("#,0"),
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasasarana.Value.ToString("#,0"),
                        this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasapelayanan.Value.ToString("#,0"));*/

                }
                //data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void edittarifrirepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FAddEditTarifRI f = new FAddEditTarifRI(this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakanid,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.kelasid,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.kelasuraian,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.daftartindakannm,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.biaya.Value,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasasarana.Value,
                    this.v_Tarif_Withaout_Jenistarif_Penjaminid.jasapelayanan.Value))
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passDataTarif += new FAddEditTarifRI.PassDataTarif(passDataTarif);
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
                LoadAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(Helper.Ruangrawat.ruangrawatid, cariMtxt.Text);
            }
        }

        protected override void deletetarifrirepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
