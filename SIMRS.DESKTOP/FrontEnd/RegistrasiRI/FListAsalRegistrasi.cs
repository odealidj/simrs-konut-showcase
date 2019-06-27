using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRI
{
    public class FListAsalRegistrasi : FListRegistrasiRJ
    {

        //SelectVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync

        private v_listtempattidurrawatinap listtempattidurrawatinap;

        public FListAsalRegistrasi(ref Panel _pnlContent) :base(ref _pnlContent)
        {
            try
            {
                this.Text = "List Registrasi - [Rawat Jalan / Rawat Darurat]";
                this.btnAddRegistrasiPasienBaru.Visible = true;
                this.btnAddRegistrasiPasienBaru.Text = "Next";
                this.btnAddRegistrasiPasienLama.Visible = false;
                this.colEdit.Visible = true;
                this.colDelete.Visible = false;
                this.coltglmasuk.GroupIndex = 0;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListAsalRegistrasi(ref Panel _pnlContent)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FListAsalRegistrasi(ref Panel _pnlContent, ref v_listtempattidurrawatinap listtempattidurrawatinap) : base(ref _pnlContent)
        {
            try
            {
                this.Text = "List Registrasi - [Rawat Jalan / Rawat Darurat]";
                this.btnAddRegistrasiPasienBaru.Visible = true;
                this.btnAddRegistrasiPasienBaru.Text = "Next";
                this.btnAddRegistrasiPasienLama.Visible = false;
                this.colEdit.Visible = true;
                this.colDelete.Visible = false;
                this.coltglmasuk.GroupIndex = 0;
                this.listtempattidurrawatinap = listtempattidurrawatinap;
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListAsalRegistrasi(ref Panel _pnlContent, ref v_listtempattidurrawatinap listtempattidurrawatinap) ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region private method control
        private async void LoadVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short? stsregistrasiid, string value)
        {
            try
            {
                using (var service = new ListRegistrasiServices())
                {
                    var result = await service.SelectVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync  (pageIndex, pageSize, stsregistrasiid.Value, value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        RegistrasiGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+this.Name+ "\nLoadVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        protected override void FListRegistrasi_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                this.PageIndex = 1;
                LoadVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize,
                    Helper.Stsregistrasi.stsregistrasiid, string.Empty);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+this.Name+ "\nFListRegistrasi_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void RegistrasiGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = RegistrasiGV.GetRow(e.FocusedRowHandle);
                if (data != null)
                {
                    SingleOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync((data as v_registrasiruangrawatrjrd).nocm, (data as v_registrasiruangrawatrjrd).jknm);
                }
                data = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + this.Name + "\nRegistrasiGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CaridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.PageIndex = 1;
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDetailIdentitasPasien);

                LoadVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(this.PageIndex, this.PageSize,
                    Helper.Stsregistrasi.stsregistrasiid, CaridataMTxt.Text);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnAddRegistrasiPasienBaru_Click(object sender, EventArgs e)
        {
            try
            {
                var data = RegistrasiGV.GetRow(RegistrasiGV.GetSelectedRows()[0]) as v_registrasiruangrawatrjrd;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data pada tabel berikut", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RegistrasiGV.Focus();
                    return;
                }
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FKonfirmasiRegistrasiRI myForm = new FKonfirmasiRegistrasiRI(ref this.pnlContent, ref listtempattidurrawatinap, ref data,
                    AlamatMTxt.Text, KecMTxt.Text, KelMTxt.Text, RTRWMTxt.Text);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FlistBedRI myForm = new FlistBedRI(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }
    }
}
