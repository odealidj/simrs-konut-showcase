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
    public class FKonfirmasiRegistrasiPenunjangRAD : FKonfirmasiRegistrasiPenunjangLAB
    {
        public FKonfirmasiRegistrasiPenunjangRAD(ref Panel pnlContent,
            ref v_registrasiruangrawat_notin_registrasipenunjang v_Registrasiruangrawat_Notin_Registrasipenunjang) : 
            base(ref pnlContent, ref v_Registrasiruangrawat_Notin_Registrasipenunjang)
        {

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
                    this.NoRM.Text, this.Nama.Text, this.RuangRawatMTxt.Text, this.KelasMTxt.Text), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAdd_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListCariPasienRAD myForm = new FListCariPasienRAD(ref this.pnlContent);
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
