using SIMRS.DESKTOP.Template.frm.Farmasi;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FAddHargajual : FAddEditHargajual
    {

        protected short aptbarangmasukdetailid = -1;

        #region private methode

        private void LoadAllGenerateAsync(short aptbarangmasukdetailid)
        {
            try
            {
                using (var service = new AptbrgguServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));

                    var result = Task.Run(() => service.SelectAll_v_aptgenerateharga(aptbarangmasukdetailid));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //brgguGC.DataSource = result.Result.Item1.ToList();
                        this.tglmasukguDateEdit.EditValue = (result.Result.Item1.tglbeli != null) ? result.Result.Item1.tglbeli.Value.Date : DateTime.Now.Date;
                        this.pbfTxt.Text = result.Result.Item1.aptpbfnm;
                        this.namabarangTxt.Text = result.Result.Item1.aptbarangnm;
                        this.tglexpireDateEdit.EditValue = result.Result.Item1.tglkadaluarsa.Value.Date;
                        this.hargasatuanTxt.Text = result.Result.Item1.hargasatuan.Value.ToString("#,0.##");
                        this.hargappnTxt.Text = result.Result.Item1.hargappn.Value.ToString("#,0.##");
                        this.hargappntigalimaTxt.Text = result.Result.Item1.hargatigalima.Value.ToString("#,0.##");
                        this.hargatoesTxt.Text = result.Result.Item1.hargatoeslag.Value.ToString("#,0.##");
                        this.hargajualTxt.Text = result.Result.Item1.hargajual.Value.ToString("#,0.##");
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion private methode

        public FAddHargajual(short aptbarangmasukdetailid)
        {
            try
            {
                this.Text = "Add Harga Jual";
                this.aptbarangmasukdetailid = aptbarangmasukdetailid;
                LoadAllGenerateAsync(this.aptbarangmasukdetailid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
