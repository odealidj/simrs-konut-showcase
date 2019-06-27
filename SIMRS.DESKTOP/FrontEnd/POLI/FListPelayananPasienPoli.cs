using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FListPelayananPasienPoli : FPelayananPasien
    {
        protected TFListRegistrasi ListRegistrasi;

        protected v_icdxpasienpoli Vicdxpasienpoli;

        #region tindakan

        protected v_tindakanpoli selectedTindakanPoli;

        //private v_pelayananpasien Vpelayananpasien;

        protected int indexSelectedRow_v_registrasiruangrawat = -1;

        protected int indexSelectedRow_v_registrasiruangrawat_forSender = -1;


        private async void LoadVpelayananpasienByRegistrasiIdAsync(short registrasiid)
        {
            try
            {
                using (var service = new PelayananpaseinServices())
                {
                    var result = await service.SelectVpelayananpasienByRegistrasiIdAsync(registrasiid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tindakanGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid)
        {

            try
            {
                using (var service = new PelayananpaseinServices())
                {
                    var result = await service.SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tindakanGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion tindakan

        public FListPelayananPasienPoli(ref Panel pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat, ref int indexRow,
            TFListRegistrasi ListRegistrasi): base(ref pnlContent, ref v_Registrasiruangrawat)
        {
            try
            {
                this.ListRegistrasi = ListRegistrasi;
                //this.Text = "Diagnosa Pasien";

                //this.v_Registrasiruangrawat = _vregistrasiruangrawat;

                this.indexSelectedRow = indexRow;

                //pelayananpasienMTC.TabPages[pelayananpasienMTC.TabPages.Count-1]

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nConstructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void deleteicdxrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                ////if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid==0)//keluar
                ////{
                ////    MetroFramework.MetroMessageBox.Show(this, "Pasien dengan No.RM : " + this.Vregistrasiruangrawat.nocm + ", Nama :" + this.Vregistrasiruangrawat.nama + " telah selesai periksa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ////    return;

                ////}

                if (this.Vicdxpasienpoli != null)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah dignosa dengan kode : " + this.Vicdxpasienpoli.icdxsubkategoriid + " akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (RemoveIcdxpasien(new icdxpasien { icdxpasienid = this.Vicdxpasienpoli.icdxpasienid }) != -99)
                        {
                            LoadVicdxpasienpoliAsync(this.v_Registrasiruangrawat.registrasiruangrawatid);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndeleterepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void icdxGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.Vicdxpasienpoli = icdxGV.GetRow(e.FocusedRowHandle) as v_icdxpasienpoli;
                if (this.Vicdxpasienpoli != null)
                {
                    this.lblTitle.Text = this.Vicdxpasienpoli.icdxsubkategoriid + " - " + this.Vicdxpasienpoli.icdxsubkategorinmeng;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nicdxGV_FocusedRowChanged ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void icdxGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        protected override void icdxGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {

                ////Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                ////this.pnlContent.Controls.Clear();
                //////fDashboard myForm = new fDashboard();
                ////ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent, ref this.Vregistrasiruangrawat, this.indexSelectedRow);
                ////myForm.TopLevel = false;
                ////myForm.AutoScroll = true;
                ////myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                ////this.pnlContent.Controls.Add(myForm);
                ////myForm.Dock = DockStyle.Fill;
                ////myForm.Show();

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent);

                if (this.ListRegistrasi.GetType().Name.ToLower() == "listregistrasipoli")
                {
                    ListRegistrasi = new ListRegistrasiPoli(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexSelectedRow);
                }
                else
                {
                    ListRegistrasi = new FListPasienPoli(ref this.pnlContent, ref this.v_Registrasiruangrawat, this.indexSelectedRow);
                }

                ListRegistrasi.TopLevel = false;
                ListRegistrasi.AutoScroll = true;
                //ListRegistrasi.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(ListRegistrasi);
                ListRegistrasi.Dock = DockStyle.Fill;
                ListRegistrasi.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFPeriksaFisikPoli()\nbtnBack_Click()" + "\nFPeriksaFisikPoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
