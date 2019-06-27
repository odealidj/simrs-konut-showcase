using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.LAB
{
    public class FKonfirmasiRegistrasiPenunjangLAB : FKonfirmasiRegistrasiPenunjang
    {
        protected v_registrasiruangrawat_notin_registrasipenunjang v_Registrasiruangrawat_Notin_Registrasipenunjang;

        #region private method
        protected string AddRegistrasiPenunjang(registrasipenunjang _registrasipenunjang)
        {
            using (var service = new ListRegistrasiPenunjangServices())
            {
                var result = service.InsertRegistrasiPenunjang(_registrasipenunjang);
                if (!string.IsNullOrEmpty(result))
                {
                    MetroFramework.MetroMessageBox.Show(this, result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return result;

            }
        }

        #endregion

        public FKonfirmasiRegistrasiPenunjangLAB(ref Panel pnlContent,
            ref v_registrasiruangrawat_notin_registrasipenunjang v_Registrasiruangrawat_Notin_Registrasipenunjang) : base(ref pnlContent)
        {
            this.v_Registrasiruangrawat_Notin_Registrasipenunjang = v_Registrasiruangrawat_Notin_Registrasipenunjang;

            this.NoRM.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.nocm;
            this.Nama.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.nama;
            this.Thn.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.thn.ToString();
            this.Bln.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.bulan.ToString();
            this.Hari.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.hari.ToString();
            this.TglLahirDateEdit.EditValue = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.tanggallahir;
            this.kelaminMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.jknm;

            this.TglRegistrasiDateEdit.EditValue = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.tglmasuk;
            this.noregistrasiMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.noregistrasi;
            this.PenjaminMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.penjaminpasiennm;
            this.KelasMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.kelasuraian;
            this.RuangRawatMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.ruangrawatnm;
            this.KamarMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.kamarnm;
            this.TempatTidurMTxt.Text = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.tempattidurnm;
            this.tglperiksadateEdit.Text = DateTime.Now.ToString("dd-MM-yyyy");



        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                //v_distinctcaripasienpenunjang_not_in_registrasipenunjang dataPasien = (registrasiGV.GetRow(registrasiGV.GetSelectedRows()[0]) as v_distinctcaripasienpenunjang_not_in_registrasipenunjang);
                ////v_distinctcaripasienpenunjang_not_in_registrasipenunjang dataPasien = registrasiGV.GetRow(this.indexSelectedRegistrasi) as v_distinctcaripasienpenunjang_not_in_registrasipenunjang;
                //v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang dataRuangRawat =  (registrasidetailGV.GetRow(registrasidetailGV.GetSelectedRows()[0]) as v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang);
                ////v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang dataRuangRawat = registrasidetailGV.GetRow(this.indexSelectedDetailRegistrasi) as v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang;

                if (MetroFramework.MetroMessageBox.Show(this, string.Format("{0} No.RM: {1}, Nama: {2}, Ruang Perawatan: {3}, Kelas: {4} akan diregistrasikan?", "Apakah data pasien",
                    this.NoRM.Text,this.Nama.Text,this.RuangRawatMTxt.Text,this.KelasMTxt.Text), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    registrasipenunjang penunjang = new registrasipenunjang
                    {
                        registrasipenunjangid = -1,
                        tglregistrasi = DateTime.Now,
                        registrasiruangrawatid = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.registrasiruangrawatid,
                        ruangrawatid = Helper.Ruangrawat.ruangrawatid, // dataRuangRawat.ruangrawatid,
                        kelasid = this.v_Registrasiruangrawat_Notin_Registrasipenunjang.kelasid,
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
                        FListRegistrasiLAB myForm = new FListRegistrasiLAB(ref this.pnlContent);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListCariPasienLAB myForm = new FListCariPasienLAB(ref this.pnlContent);
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
