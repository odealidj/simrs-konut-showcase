using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FListBarangKeluar : TFListBarangKeluar
    {
        private bool isAllowChangedEvent = false;

        #region private methode

        
        private void LoadAllAptdistribusiAsync()
        {
            try
            {
                using (var service = new AptdistribusiServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAllv_aptdistribusi());

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllAptdistribusiAsync", this.Name, this);

                    }
                    else
                    {
                        this.listbarangkeluarGC.DataSource = result.Result.Item1.ToList();
                       
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllAptdistribusiAsync", this.Name, this);
            }
        }

        private void LoadAllAptdistribusiAsync(string tahun, string bulan)
        {
            try
            {
                using (var service = new AptdistribusiServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAllv_aptdistribusi(tahun, bulan));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllAptdistribusiAsync", this.Name, this);

                    }
                    else
                    {
                        this.listbarangkeluarGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllAptbrgguAsync", this.Name, this);
            }
        }

        private void LoadAllAptdistribusiAsync(string depo)
        {
            try
            {
                using (var service = new AptdistribusiServices())
                {
                    //Task.Run(() => RestClient.RestLaporan.GetLhpBySatkerAsync(token, code, satkerid, CancellationToken.None));


                    var result = Task.Run(() => service.SelectAllv_aptdistribusi(depo));

                    if (!string.IsNullOrEmpty(result.Result.Item2))
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, "LoadAllAptdistribusiAsync", this.Name, this);

                    }
                    else
                    {
                        this.listbarangkeluarGC.DataSource = result.Result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "LoadAllAptbrgguAsync", this.Name, this);
            }
        }

        /*
        private string DeleteBarangGU(aptbrggu Aptbrggu)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbrgguServices())
                {
                    Errresult = service.DeleteBarangGU(Aptbrggu);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                CustomMessageBox.MessageError(ex.InnerException.Message, "DeleteBarangGU()", this.Name, this);

            }

            return Errresult;
        }
        */

        private void defaultControl()
        {
            lblHeader.Text = "List Barang Keluar";

            this.kriteriaCbo.Properties.Items.Clear();
            this.kriteriaCbo.Properties.Items.AddRange(new string[] { "Periode", "Depo" });
            this.kriteriaCbo.SelectedIndex = 0;
        }


        #endregion  private methode
        public FListBarangKeluar(ref Panel pnlContent):base(ref pnlContent)
        {
            try
            {
                defaultControl();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FListBarangKeluar()", this.Name, this);

            }
        }

        protected override void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void TFListBarangKeluar_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllAptdistribusiAsync();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFListBarangKeluar_Load()", this.Name, this);

            }
        }

        protected override void TFListBarangKeluar_Shown(object sender, EventArgs e)
        {
            try
            {
                isAllowChangedEvent = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFListBarangKeluar_Shown()", this.Name, this);

            }
        }

        protected override void BAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FAddBarangKeluar myForm = new FAddBarangKeluar(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BAdd_Click()", this.Name, this);

            }
        }

        protected override void BEdit_Click(object sender, EventArgs e)
        {

        }

        protected override void BDelete_Click(object sender, EventArgs e)
        {

        }

        protected override void BFirst_Click(object sender, EventArgs e)
        {

        }

        protected override void BPrev_Click(object sender, EventArgs e)
        {

        }

        protected override void BNext_Click(object sender, EventArgs e)
        {

        }

        protected override void BLast_Click(object sender, EventArgs e)
        {

        }

        protected override void DetailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
