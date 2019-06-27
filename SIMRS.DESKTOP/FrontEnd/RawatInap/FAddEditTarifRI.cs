using SIMRS.DESKTOP.Template.frm.Tarif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FAddEditTarifRI: FAddEditTarif
    {
        public delegate void PassDataTarif(int daftartindakanid, short kelasid,
        decimal harga, decimal jasasarana, decimal jasapelayanan);
        public PassDataTarif passDataTarif;
        public FAddEditTarifRI(int daftartindakanid, short kelasid,string kelasuraian,
                string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
            : base(daftartindakanid, kelasid, kelasuraian, namatarif, harga, jasasarana, jasapelayanan)
        {
            this.Text = "Edit Tarif Rawat Inap";
            this.bUpdate.Text = "Update";
        }

        protected override void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.namatarifMTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nama Tarif tidak boleh kosong!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    namatarifMTxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.hargatarifMTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Harga Tarif tidak boleh kosong!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    namatarifMTxt.Focus();
                    return;
                }

                ////if (string.IsNullOrEmpty(this.jasasaranaMTxt.Text))
                ////{
                ////    MetroFramework.MetroMessageBox.Show(this, "Jasasarana tidak boleh kosong\n[Boleh diisi dengan angka 0]", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ////    jasasaranaMTxt.Focus();
                ////    return;
                ////}

                ////if (string.IsNullOrEmpty(this.jasapelayananMTxt.Text))
                ////{
                ////    MetroFramework.MetroMessageBox.Show(this, "Jasapelayanan tidak boleh kosong\n[Boleh diisi dengan angka 0]", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ////    jasapelayananMTxt.Focus();
                ////    return;
                ////}

                decimal harga = decimal.Parse(this.hargatarifMTxt.Text);
                decimal jasasarana = decimal.Parse("0");
                decimal jasapelayanan = decimal.Parse("0");

                ////if (harga != (jasasarana + jasapelayanan))
                ////{
                ////    MetroFramework.MetroMessageBox.Show(this, "Imputan tidak valid!\n[Harga = JasaSarana + JasaPelayanan]", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ////    hargatarifMTxt.Focus();
                ////    return;
                ////}



                if (this.passDataTarif != null)
                {
                    passDataTarif(this.daftartindakanid, this.kelasid, decimal.Parse(this.hargatarifMTxt.Text),
                        decimal.Parse(this.jasasaranaMTxt.Text), decimal.Parse(this.jasapelayananMTxt.Text));
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbUpdate_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
