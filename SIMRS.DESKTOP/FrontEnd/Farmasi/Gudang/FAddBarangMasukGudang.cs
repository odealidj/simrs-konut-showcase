using SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian;
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
    public class FAddBarangMasukGudang : TFAddBarangMasukGudang
    {
        //private Panel pnlContent;
        private v_aptpembelian v_Aptpembelian;



        #region private methode
        protected string SaveAptbarangGudang(aptbrggu Aptbrggu, short aptbarangmasukid)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbrgguServices())
                {
                    Errresult = service.InsertBarangmasukGU(Aptbrggu, aptbarangmasukid);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nSaveAptbarangGudang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }

        #endregion private methode
        public FAddBarangMasukGudang(ref v_aptpembelian v_Aptpembelian)
        {
            try
            {
                this.Text = "Konfirmasi Barang Masuk Gudang";
               this.v_Aptpembelian = v_Aptpembelian;
                this.TglMasukGuDateEdit.EditValue = DateTime.Now;
                if (this.v_Aptpembelian != null)
                {
                    this.tglbeliDateEdit.EditValue = this.v_Aptpembelian.tglmasuk;
                    this.nofakturTxt.Text = this.v_Aptpembelian.nobeli;
                    this.pbfTxt.Text = this.v_Aptpembelian.aptpbfnm;
                    this.dppTxt.Text = this.v_Aptpembelian.dpp.Value.ToString("#,0.##");
                    this.ppnTxt.Text = this.v_Aptpembelian.ppn.Value.ToString("#,0.##");
                    this.totalTxt.Text = this.v_Aptpembelian.total.Value.ToString("#,0.##");

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFAddBarangMasukGudang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void TFAddBarangMasukGudang_Load(object sender, EventArgs e)
        {
            this.TglMasukGuDateEdit.Focus();
        }

        protected override void TFAddBarangMasukGudang_Shown(object sender, EventArgs e)
        {
            this.TglMasukGuDateEdit.Focus();
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.TglMasukGuDateEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal masuk barang", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TglMasukGuDateEdit.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.ketGuTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi keterangan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ketGuTxt.Focus();
                    return;
                }

                aptbrggu Aptbrggu = new aptbrggu
                {
                    aptbrgguid = -1,
                    aptgudangid = 57,
                    tglgu = ((DateTime)this.TglMasukGuDateEdit.EditValue).Date,
                    tahun = ((DateTime)this.TglMasukGuDateEdit.EditValue).Date.Year.ToString(),
                    bulan = ((DateTime)this.TglMasukGuDateEdit.EditValue).Date.Month.ToString("0#"),
                    jamgu = ((DateTime)this.TglMasukGuDateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Date.Hour, DateTime.Now.Date.Minute, DateTime.Now.Date.Second)),
                    ket = this.ketGuTxt.Text

                };

                var errResult = SaveAptbarangGudang(Aptbrggu, this.v_Aptpembelian.aptbarangmasukid);
                if (string.IsNullOrEmpty(errResult))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add barang ke gudang sukses disimpan !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.DialogResult = DialogResult.OK;

                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, errResult, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }

                

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbSimpan_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
