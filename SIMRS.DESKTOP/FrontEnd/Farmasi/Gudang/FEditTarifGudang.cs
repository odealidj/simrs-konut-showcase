using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FEditTarifGudang : TFEditTarifGudang
    {
        private v_aptbrggudetail v_Aptbrggudetail;

        protected string UpdateTarifGudang(aptbrggudetail Aptbrggudetail)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbrgguServices())
                {
                    Errresult = service.UpdateTarif(Aptbrggudetail);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nSaveAptbarangmasuk()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }

        public FEditTarifGudang(ref v_aptbrggudetail v_Aptbrggudetail) : base()
        {
            try
            {
                this.Text = "Barang Masuk Gudang -> Edit Harga";
                this.v_Aptbrggudetail = v_Aptbrggudetail;
                if (this.v_Aptbrggudetail !=null)
                {
                    this.namabarangTxt.Text = this.v_Aptbrggudetail.aptbarangnm;
                    this.tglExpireDateEdit.EditValue = (this.v_Aptbrggudetail.tglkadaluarsa!=null)? this.v_Aptbrggudetail.tglkadaluarsa.Value.Date: this.v_Aptbrggudetail.tglkadaluarsa;
                    this.defenisiTxt.Text = this.v_Aptbrggudetail.defenisisatuan;
                    this.jmlbarangTxt.Text = this.v_Aptbrggudetail.jmlbrg.ToString();
                    this.hargamodalTxt.Text = (this.v_Aptbrggudetail.hargaskecil!=null)? this.v_Aptbrggudetail.hargaskecil.Value.ToString("#,#.00") : "0";
                    this.hargappnTxt.Text = (this.v_Aptbrggudetail.hargapph!=null)? this.v_Aptbrggudetail.hargapph.Value.ToString("#,#.00") : "0";
                    this.hargatigalimaTxt.Text = (this.v_Aptbrggudetail.harga35!=null)? this.v_Aptbrggudetail.harga35.Value.ToString("#,#.00") : "0";
                    this.hargatoeslagTxt.Text = (this.v_Aptbrggudetail.hargatoeslag!=null)? this.v_Aptbrggudetail.hargatoeslag.Value.ToString("#,#.00") : "0";
                    this.hargajualTxt.Text = (this.v_Aptbrggudetail.hargajual!=null)? this.v_Aptbrggudetail.hargajual.Value.ToString("#,#.00"): "0";

                    this.hargatigalimaTxt.Enabled = true;
                    this.hargatoeslagTxt.Enabled = true;
                    this.hargajualTxt.Enabled = true;

                    this.hargatigalimaTxt.ReadOnly = false;
                    this.hargatoeslagTxt.ReadOnly = false;
                    this.hargajualTxt.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(this.hargatigalimaTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Harga +35% tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.hargatigalimaTxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.hargatoeslagTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Harga Toeslag tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.hargatoeslagTxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.hargajualTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Harga Jual tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.hargajualTxt.Focus();
                    return;
                }

                aptbrggudetail Aptbrggudetail = new aptbrggudetail
                {
                    aptbrggudetailid = this.v_Aptbrggudetail.aptbrggudetailid,
                    harga35 = decimal.Parse( this.hargatigalimaTxt.Text),
                    hargatoeslag = decimal.Parse(this.hargatoeslagTxt.Text),
                    hargajual = decimal.Parse(this.hargajualTxt.Text)
                };

                var errResult = UpdateTarifGudang(Aptbrggudetail);

                if (string.IsNullOrEmpty(errResult))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Update Tidak Valid"+"\n"+ errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBatal_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
