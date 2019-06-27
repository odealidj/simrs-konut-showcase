using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RAD
{
    public class FListCariPasienRAD : FListCariPasienLAB
    {
        public FListCariPasienRAD(ref Panel _pnlContent) : base(ref _pnlContent)
        {

        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataRuangRawatDeatil == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih ruang perawatan pasien yang akan didaftarkan\n" +
                        "dengan cara klik pada tabel ruang perawatan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FKonfirmasiRegistrasiPenunjangRAD myForm = new FKonfirmasiRegistrasiPenunjangRAD(ref this.pnlContent, ref this.dataRuangRawatDeatil);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAdd_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void registerRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //v_distinctcaripasienpenunjang_not_in_registrasipenunjang dataPasien = (registrasiGV.GetRow(registrasiGV.GetSelectedRows()[0]) as v_distinctcaripasienpenunjang_not_in_registrasipenunjang);
                ////v_distinctcaripasienpenunjang_not_in_registrasipenunjang dataPasien = registrasiGV.GetRow(this.indexSelectedRegistrasi) as v_distinctcaripasienpenunjang_not_in_registrasipenunjang;
                //v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang dataRuangRawat =  (registrasidetailGV.GetRow(registrasidetailGV.GetSelectedRows()[0]) as v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang);
                ////v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang dataRuangRawat = registrasidetailGV.GetRow(this.indexSelectedDetailRegistrasi) as v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang;
                if (this.dataDistinctRuangRawat == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan klik tabel untuk memilih data pasien", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.dataRuangRawatDeatil == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan klik tabel untuk memilih data ruang rawat", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, string.Format("{0} No.RM: {1}, Nama: {2}, Ruang Perawatan: {3}, Kelas: {4} akan diregistrasikan?", "Apakah data pasien", this.dataDistinctRuangRawat.nocm, this.dataDistinctRuangRawat.nama, this.dataRuangRawatDeatil.ruangrawatnm, this.dataRuangRawatDeatil.kelasuraian), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    registrasipenunjang penunjang = new registrasipenunjang
                    {
                        registrasipenunjangid = -1,
                        tglregistrasi = DateTime.Now,
                        registrasiruangrawatid = this.dataRuangRawatDeatil.registrasiruangrawatid,
                        ruangrawatid = Helper.Ruangrawat.ruangrawatid, // dataRuangRawat.ruangrawatid,
                        kelasid = this.dataRuangRawatDeatil.kelasid,
                        loginappid = (short)(-1),
                        created_date = DateTime.Now,
                        updated_date = null,
                        registrasipenunjangsts = true

                    };

                    var data = AddRegistrasiPenunjang(penunjang);
                    if (string.IsNullOrEmpty(data))
                    {
                        //registrasiGV.GetDataRow((registrasiGV.)

                        //LoadVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(this.dataDistinctRuangRawat.registrasiid,Helper.Pelayananmedik.pelayananmedikid);
                        //if (registrasidetailGV.RowCount == 0)
                        //{
                        //LoadVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(this.PageIndex, this.PageSize,
                        //    Helper.Stsregistrasi.stsregistrasiid, string.Empty);
                        Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                        this.pnlContent.Controls.Clear();
                        //fDashboard myForm = new fDashboard();
                        FListRegistrasiRAD myForm = new FListRegistrasiRAD(ref this.pnlContent);
                        myForm.TopLevel = false;
                        myForm.AutoScroll = true;
                        myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                        this.pnlContent.Controls.Add(myForm);
                        myForm.Dock = DockStyle.Fill;
                        myForm.Show();
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nregisterRepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiRAD myForm = new FListRegistrasiRAD(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
