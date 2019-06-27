using SIMRS.DESKTOP.Helper;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Poli
{
    public partial class FRujukantarpoli : MetroFramework.Forms.MetroForm
    {

        public delegate void PassDataRujukanpoli(registrasiruangrawat Registrasiruangrawatid, v_pelayananpasienkarcis v_Pelayananpasienkarcis );
        public PassDataRujukanpoli passDataRujukanpoli;

        protected short registrasiid;
        protected short penjaminid;

        protected stsregistrasi Stsregistrasi;

        #region private methode
        private void defaultsetinglookupeditpanelpoli()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref politujuanlookUpEdit,
                   new string[] { "ruangrawatid", "ruangrawatnm", "pelayananmedikid", "kelasruangrawatid", "kelasid", "kamarid", "tempattidurid" },
                   new string[] { "Kode", "Poliklinik", "pelayananmedikid", "kelasruangrawatid", "kelasid", "kamarid", "tempattidurid" },
                   new bool[] { true, true, false, false, false, false, false },
                   "ruangrawatnm", "ruangrawatid", "Pilih poliklinik");

        }

        private void LoadRuangRawatByPelayananmedikId(short pelayananmedikid)
        {
            try
            {
                using (var service = new RuangrawatServices())
                {
                    var result = service.SelectAllvruangrawat_kelasruangrawatid_kamarid_tempattidurid(pelayananmedikid);
      
                    if (!string.IsNullOrEmpty( result.Item2))
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        politujuanlookUpEdit.Properties.DataSource = result.Item1;
                        
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAnamnesaPasien()\nLoadDokterAsync()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected jenistarif FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId(short ruangrawatid, short penjaminid)
        {
            using (var service = new JenistarifServices())
            {
                var result = service.FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId(ruangrawatid, penjaminid);
                if (result.Item2 != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return result.Item1;
                }
            }
        }



        #endregion private methode
        public FRujukantarpoli()
        {
            InitializeComponent();
        }

        public FRujukantarpoli(string noregistrasi, DateTime tglperiksa, string norm, string namapasien, 
            short asalpoliid, string asalpoli, short registrasiid,  short pelayananmedikid,
            short penjaminid )
        {
            InitializeComponent();
            try
            {
                defaultsetinglookupeditpanelpoli();
                LoadRuangRawatByPelayananmedikId(pelayananmedikid);

                this.Stsregistrasi = new stsregistrasi { stsregistrasiid = 2, stsregistrasinm = "Rujukan" };

                this.registrasiid = registrasiid;
                this.penjaminid = penjaminid;

                this.noregistrasiMTxt.Text = noregistrasi;
                this.tgldaftardateEdit.EditValue = tglperiksa.Date;
                this.normMtxt.Text = norm;
                this.namaMTxt.Text = namapasien;
                this.poliasalMTxt.Text = asalpoli;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n FRujukantarpoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void bUpdate_Click(object sender, EventArgs e)
        {
            if (this.politujuanlookUpEdit.EditValue==null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Poli rujukan tidak boleh kosong!" + "\n FRujukantarpoli()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                politujuanlookUpEdit.Focus();
                return;
            }

            var jenistarif = FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId((politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                             this.penjaminid);

            if (this.passDataRujukanpoli != null)
            {
                passDataRujukanpoli(new registrasiruangrawat
                {
                    registrasiruangrawatid = -1,
                    registrasiid = this.registrasiid,
                    tglmasukruangan = ((DateTime)tgldaftardateEdit.EditValue).Date,
                    jamkeluarruangan = ((DateTime)tgldaftardateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)),  // DateTime.Now,
                    kelasid = (politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kelasid,
                    ruangrawatid = (politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                    kamarid = (politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kamarid,
                    tempattidurid = (politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).tempattidurid,
                    loginappid = (short)-1, //Helper.LoginAppDetail.loginappdetailid,//(short)(-1),
                    stsregistrasiid = this.Stsregistrasi.stsregistrasiid
                },
                new v_pelayananpasienkarcis
                {
                    pelayananpasienid = -1,
                    pelayananpasientgl = ((DateTime)tgldaftardateEdit.EditValue).Date,
                    pelayananpasienjam = ((DateTime)tgldaftardateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)),
                    registrasiruangrawatid = -1,
                    pelayananmedikid = Helper.Pelayananmedik.pelayananmedikid,
                    jenistarifid = jenistarif.jenistarifid,
                    ruangrawatid = (politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                    kelasid = (politujuanlookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kelasid,
                    stspasienbaruid = (short)1, //pasien lama
                    loginappid = (short)-1 //Helper.LoginAppDetail.loginappdetailid
                }
                );

            }
            this.Close();

        }

        protected virtual void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
