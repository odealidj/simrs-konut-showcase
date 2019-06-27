using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi.Gudang
{
    public partial class FAddBarangGudang : MetroFramework.Forms.MetroForm
    {


        #region private methode

        protected string SaveAptbarangGudang(aptbrggu Aptbrggu, short aptbarangmasukid)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbrgguServices())
                {
                    Errresult = service.InsertBarangmasukGU(Aptbrggu,aptbarangmasukid);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nSaveAptbarangGudang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }

        private void LoadAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail()
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail());

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        listpembelianGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAll_v_aptpembeliandetailByAptbarangmasukIdAsync(short aptbarangmasukid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptpembeliandetailByAptbarangmasukIdAsync(aptbarangmasukid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        listpembeliandetailGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*

        public void LoadAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbrgguid, short aptbarangmasukid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptbarangmasukdetail_aptbrggudetail(aptbrgguid, aptbarangmasukid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        listbaranggudangdetailGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        /*
        public void LoadAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbarangmasukdetailid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptbarangmasukdetail_aptbrggudetail(aptbarangmasukdetailid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        detailhargaGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadAllAptBarangmasukPbfAptbrggu()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         */

        #endregion  private methode


        public FAddBarangGudang()
        {
            InitializeComponent();
            try
            {
                this.Text = "Add Barang - Gudang";
                this.tglmasukguDateEdit.EditValue = DateTime.Now.Date;
                LoadAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFAddBarangGudang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listpembelianGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = listpembelianGV.GetFocusedRow() as v_aptbarangmasuk_pbf_notin_aptbrggudetail;
                if (data !=null)
                {
                    LoadAll_v_aptpembeliandetailByAptbarangmasukIdAsync(data.aptbarangmasukid);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nlistpembelianGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listpembelianGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var data = listpembelianGV.GetFocusedRow() as v_aptbarangmasuk_pbf_notin_aptbrggudetail;
                if (data != null)
                {
                    LoadAll_v_aptpembeliandetailByAptbarangmasukIdAsync(data.aptbarangmasukid);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nlistpembelianGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tglmasukguDateEdit.EditValue==null)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Silahkan isi tanggal masuk barang", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tglmasukguDateEdit.Focus();
                    return;
                }
                if (string.IsNullOrEmpty( this.keteranganTxt.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi keterangan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.keteranganTxt.Focus();
                    return;
                }

                aptbrggu Aptbrggu = new aptbrggu
                {
                    aptbrgguid = -1,
                    aptgudangid = 57,
                    tglgu = ((DateTime)this.tglmasukguDateEdit.EditValue).Date,
                    tahun = ((DateTime)this.tglmasukguDateEdit.EditValue).Date.Year.ToString("yyyy"),
                    bulan = ((DateTime)this.tglmasukguDateEdit.EditValue).Date.Month.ToString("0#"),
                    jamgu = ((DateTime)this.tglmasukguDateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Date.Hour, DateTime.Now.Date.Minute, DateTime.Now.Date.Second)),
                    ket = this.keteranganTxt.Text
                    
                };

                var data = listpembelianGV.GetFocusedRow() as v_aptbarangmasuk_pbf_notin_aptbrggudetail;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Silahkan pilih data pembelian, dengan cara klik pada tabel pembelian!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listpembelianGC.Focus();
                    return;
                }


                var errResult = SaveAptbarangGudang(Aptbrggu,data.aptbarangmasukid);
                if (string.IsNullOrEmpty(errResult))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add barang ke gudang sukses disimpan !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, errResult, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }

               

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbSimpan_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
