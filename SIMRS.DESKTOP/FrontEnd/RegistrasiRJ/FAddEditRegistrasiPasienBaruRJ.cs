using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.Registrasi;

using SIMRS.DESKTOP.Helper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SIMRS.DESKTOP.Template.Report.Registrasi;
using DevExpress.XtraReports.UI;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FAddEditRegistrasiPasienBaruRJ : TFAddEditRegistrasiPasien
    {


        private void AddCollectionPanelPasienBaruRJ()
        {
            //Add panel to list
            listPanel.Clear();
            listPanel.Add(pnlPenjamin);
            //listPanel.Add(pnlKartuBPJS);
            //listPanel.Add(pnlSuratRujukanBPJS);
            //listPanel.Add(pnlKeluarga);
            //listPanel.Add(pnlDiriSendiri);
            //listPanel.Add(pnlIdentitasPasien);
            listPanel[indexPanel].BringToFront();
        }

        public FAddEditRegistrasiPasienBaruRJ(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            this.Text = "Registrasi Pasien Baru";
            Helper.Stspasienbaru.id = 0;

            this.tglMasukDateEdit.EditValue = DateTime.Now;
        }

        protected override void FAddEditRegistrasiPasien_Load(object sender, EventArgs e)
        {
            

            AddCollectionPanelPasienBaruRJ();


            //defaultpanelregistrasi();
            defaultpanelSEPBPJS();
            //defaultsetinglookupeditpanelrujukanBPJS();
            defaultpanelrujukanBPJS();
            //defaultsetinglookupeditpanelkartuBPJS();
            defaultpanelkartuBPJS();
            //defaultsetinglookupeditpaneldirisendiri();
            defaultpaneldirisendiri();
            //defautsetinglookupeditpanelkeluarga();
            defautpanelkeluarga();
            //defaultsetinglookupeditpanelidentitaspasien();
            defaultpanelidentitaspasien();
            //defaultsetinglookupeditpanelpoli();
            defaultpanelpoli();

            #region panel kartuBPJS

            TglLahirKartuBPJSDateEdit.EditValue = DateTime.Now.Date;
            LoadDataKelasAndJKAndKecByKotaKabIdKartuBPJSAsync(Helper.Kotakab.KotakabId());

            KecKartuBPJSlookUpEdit.EditValue = KecKartuBPJSlookUpEdit.Properties.GetDataSourceValue("kecid", 0);
            #endregion

            #region panel Surat Rujukan BPJS

            TglRujukanSrtRujukanBPJSDateEdit.EditValue = DateTime.Now.Date;
            LoadDataAsalRujukan();
            AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue = AsalRujukanSrtRujukanBPJSLookUpEdit.Properties.GetDataSourceValue("perujukid", 0);
            if (AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue != null)
                LoadMultiPuskesmasByPerujukIdAndRuangRawatRujukanAndVicdxpuskesmasAsync(AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue != null ? short.Parse(AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : short.Parse(null));
            #endregion

            #region SEP BPJS
            TglLahirSEPBPJS.Text = null;
            #endregion

        }

        protected override void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                //Bring next panel to front
                if (indexPanel < listPanel.Count - 2)
                {
                    listPanel[++indexPanel].BringToFront();
                }
                else
                {
                    if ((btnNext.Text == "Next") && (indexPanel == listPanel.Count - 2) && (isSave == false))
                    {
                        if (penjaminLookUpEdit.EditValue == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih penjamin" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnNext_Click(sender, e);
                            penjaminLookUpEdit.Focus();
                            return;
                        }

                        if (string.IsNullOrEmpty( NamaIP.Text))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Silahkan input nama pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                            return;
                        }

                        if (string.IsNullOrEmpty(AlamatIP.Text))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Silahkan input alamat pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (KelaminIPLookUpEdit.EditValue==null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis kelamin pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (PoliLookUpEdit.EditValue == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tujuan poliklinik" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if ((TglLahirIPDateEdit.EditValue==null) || (TglLahirIPDateEdit.Text == "")){
                            MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal lahir pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (((DateTime)TglLahirIPDateEdit.EditValue).Date > DateTime.Now.Date )
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Tgl.Lahir tidak valid,\n Tgl.lahir yang diinput lebih besar dari tgl hari ini" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var jenistarif = FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId((PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                             (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)(-1));

                        if (jenistarif == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Jenis tarif tidak valid \n btnNext_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        switch (this.statepenjamin)
                        {
                            case Services.StatePenjamin.DiriSendiri:

                                if (IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue == null)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi identitas diri sendiri" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    IdentitasdiriPenjaminDiriSendiriLookUpEdit.Focus();
                                    return;
                                }
                                if (string.IsNullOrEmpty(NoIdentitasPenjaminDiriSendiri.Text))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi nomor identitas diri" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    NoIdentitasPenjaminDiriSendiri.Focus();
                                    return;
                                }
                                break;

                            case Services.StatePenjamin.BPJS:
                                if (string.IsNullOrEmpty( NoPesertaKartuBPJS.Text))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Nomor Peserta BPJS tidak boleh kosong,\n Silahkan isi nomor peserta BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if (string.IsNullOrEmpty(NamaPesertaKartuBPJS.Text))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Nama Peserta BPJS tidak boleh kosong,\n Silahkan isi nama peserta BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }



                                if ((KelasKartuBPJSLookUpEdit.EditValue == null) || (string.IsNullOrEmpty(KelasKartuBPJSLookUpEdit.Text)))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Kelas Kartu BPJS tidak boleh kosong" + "\nbtnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if ((TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue == null) || (string.IsNullOrEmpty(TujuanSrtRujukanSEPBPJSLookUpEdit.Text)))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Tujuan SEP BPJS tidak boleh kosong" + "\nbtnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if ((TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue == null) || (string.IsNullOrEmpty(TujuanSrtRujukanSEPBPJSLookUpEdit.Text)))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Tujuan SEP BPJS tidak boleh kosong" + "\nbtnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if (string.IsNullOrEmpty(NosepSEPBPJS.Text))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Nomor SEP BPJS tidak boleh kosong,\n Silahkan isi nomor SEP BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                if (TujuanSrtRujukanBPJSLookUpEdit.EditValue == null)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Silahkan input tujuan surat rujukan BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    TujuanSrtRujukanBPJSLookUpEdit.Focus();
                                    return;
                                }
                                break;
                                
                        }


                        if (MetroFramework.MetroMessageBox.Show(this, "Apakah data pasien akan diregistrasikan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {

                                btnNext.Text = "Finish";

                                identitaspasien pasien = new identitaspasien()
                                {
                                    nocm = "1",
                                    sapaanid = (SapaanIPLookUpEdit.EditValue != null) ? (short)SapaanIPLookUpEdit.EditValue : (short)-1,
                                    nama = NamaIP.Text,
                                    tempatlahir = TempatLahirIP.Text,
                                    tanggallahir = (TglLahirIPDateEdit.EditValue!=null)?((DateTime)TglLahirIPDateEdit.EditValue).Date: DateTime.Parse(null),
                                    thn = short.Parse(ThnIP.Text ?? "0"),
                                    bulan = short.Parse(BlnIP.Text ?? "0"),
                                    hari = short.Parse(HariIP.Text ?? "0"),
                                    jkid = (KelaminIPLookUpEdit.EditValue != null) ? (short)KelaminIPLookUpEdit.EditValue : (short)-1,
                                    stspernikahanid = (StsNikahIPLookUpEdit.EditValue != null) ? (short)StsNikahIPLookUpEdit.EditValue : (short)-1,
                                    pendidikanid = (PendidikanIPLookUpEdit.EditValue != null) ? (short)PendidikanIPLookUpEdit.EditValue : (short)-1,
                                    pekerjaanid = (PekerjaanIPLookUpEdit.EditValue != null) ? (short)PekerjaanIPLookUpEdit.EditValue : (short)-1,
                                    agamaid = (AgamaIPLookUpEdit.EditValue != null) ? (short)AgamaIPLookUpEdit.EditValue : (short)-1,
                                    notelp = NoTelpIP.Text,
                                    nohp = NoHPIP.Text,
                                    goldarahid = (GolDarahIPLookUpEdit.EditValue != null) ? (short)GolDarahIPLookUpEdit.EditValue : (short)-1,
                                    sukuid = (SukuIPLookUpEdit.EditValue != null) ? (short)SukuIPLookUpEdit.EditValue : (short)-1,
                                    negaraid = Negara.NegaraId(),
                                    identitaspasiensts = true
                                };

                                alamatpasien alamat = new alamatpasien()
                                {
                                    alamatpasienid = -1,
                                    nocm = pasien.nocm,
                                    alamat = AlamatIP.Text,
                                    kotakabid = Helper.Kotakab.KotakabId(),
                                    kecid = (KecIPLookUpEdit.EditValue != null) ? (short)KecIPLookUpEdit.EditValue : (short)-1,
                                    keldesaid = (KelIPLookUpEdit.EditValue != null) ? (short)KelIPLookUpEdit.EditValue : (short)-1,
                                    rwid = (RTRWIPLookUpEdit.EditValue != null) ? (RTRWIPLookUpEdit.GetSelectedDataRow() as vrtrw).rwid : (short)-1,
                                    rtid = (RTRWIPLookUpEdit.EditValue != null) ? (RTRWIPLookUpEdit.GetSelectedDataRow() as vrtrw).rtid : (short)-1,
                                    alamatpasiensts = true
                                };

                                registrasi reg = new registrasi()
                                {
                                    registrasiid = -1,
                                    nocm = pasien.nocm,
                                    noregistrasi = "1",
                                    prosedurmasukid = Prosedurmasuk.ProsedurmasukId,
                                    tglmasuk = ((DateTime)this.tglMasukDateEdit.EditValue).Date, // DateTime.Now.Date,
                                    jammasuk = ((DateTime)tglMasukDateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)),  // DateTime.Now,
                                    penjaminpasienid = (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)(-1),
                                    stsmasukkeluarid = 1, //masuk
                                    loginappid = Helper.LoginAppDetail.loginappdetailid,
                                    registrasists = true,
                                    stspasienbaruid = Helper.Stspasienbaru.id
                            };

                                Helper.Stsregistrasi.stsregistrasiid = 1;

                                registrasiruangrawat regruangrawat = new registrasiruangrawat
                                {
                                    registrasiruangrawatid = -1,
                                    registrasiid = reg.registrasiid,
                                    tglmasukruangan = reg.tglmasuk,
                                    jammasukruangan = reg.jammasuk,
                                    kelasid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kelasid,
                                    ruangrawatid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                                    kamarid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kamarid,
                                    tempattidurid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).tempattidurid,
                                    loginappid = Helper.LoginAppDetail.loginappdetailid, //(short)(-1),
                                    stsregistrasiid = Helper.Stsregistrasi.stsregistrasiid

                                };

                                v_pelayananpasienkarcis vpelayananpasienkarcis = new v_pelayananpasienkarcis
                                {
                                    pelayananpasienid = -1,
                                    pelayananpasientgl = reg.tglmasuk,
                                    pelayananpasienjam = reg.jammasuk,
                                    registrasiruangrawatid = -1,
                                    pelayananmedikid = Helper.Pelayananmedik.pelayananmedikid,
                                    jenistarifid = jenistarif.jenistarifid,
                                    ruangrawatid = regruangrawat.ruangrawatid,
                                    kelasid = regruangrawat.kelasid,
                                    stspasienbaruid = Helper.Stspasienbaru.id,
                                    loginappid = reg.loginappid
                                };

                                penjaminpasiendirisendiri pdirisendiri = null;
                                penjaminpasienkeluarga pkeluarga = null;
                                identitaspasienbpjs ipasienbpjs = null;
                                penjaminpasienbpjs pjpasienbpjs = null;
                                suratrujukanpuskesmas srtrujukanpuskesmas = null;

                                switch (this.statepenjamin)
                                {
                                    case Services.StatePenjamin.DiriSendiri: //Diri Sendiri

                                        pdirisendiri = new penjaminpasiendirisendiri
                                        {
                                            penjaminpasiendirisendiriid = reg.registrasiid,
                                            tgljaminan = reg.jammasuk,
                                            
                                            identitasdiriid = (IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue != null) ? (short)IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            nomoridentitas = NoIdentitasPenjaminDiriSendiri.Text,
                                            nama = NamaDiriSendiri.Text,
                                            jkid = (KelaminDiriSendiriLookUpEdit.EditValue != null) ? (short)KelaminDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            alamat = ALamatDiriSendiri.Text,
                                            propinsiid = Helper.Propinsi.PropinsiId(),
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecDiriSendiriLookUpEdit.EditValue != null) ? (short)KecDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KelDiriSendiriLookUpEdit.EditValue != null) ? (short)KelDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWDiriSendiriLookUpEdit.EditValue != null) ? (RTRWDiriSendiriLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWDiriSendiriLookUpEdit.EditValue != null) ? (RTRWDiriSendiriLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            notelp = NoTelpDiriSendiri.Text,
                                            nohp = NoHPDiriSendiri.Text
                                        };


                                        break;
                                    case Services.StatePenjamin.Keluarga: //Keluarga

                                        pkeluarga = new penjaminpasienkeluarga
                                        {
                                            penjaminpasienkeluargaid = reg.registrasiid,
                                            tgljaminan = reg.jammasuk,
                                            penjaminpasienid = (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)-1,
                                            identitasdiriid = (IdentitasdiriPenjaminKLookUpEdit.EditValue != null) ? (short)IdentitasdiriPenjaminKLookUpEdit.EditValue : (short)-1,
                                            nomoridentitas = NoIdentitasPenjaminK.Text,
                                            nama = NamaPenjaminK.Text,
                                            jkid = (JKPenjaminKlookUpEdit.EditValue != null) ? (short)JKPenjaminKlookUpEdit.EditValue : (short)-1,
                                            alamat = AlamatPenjaminK.Text,
                                            propinsiid = Helper.Propinsi.PropinsiId(),
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecPenjaminKLookUpEdit.EditValue != null) ? (short)KecPenjaminKLookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KeldesaPenjaminKLookUpEdit.EditValue != null) ? (short)KeldesaPenjaminKLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWPenjaminKLookUpEdit.EditValue != null) ? (RTRWPenjaminKLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWPenjaminKLookUpEdit.EditValue != null) ? (RTRWPenjaminKLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            notelp = NoTelpPenjaminK.Text,
                                            nohp = NoHPPenjaminK.Text,
                                            hubkeluargaid = (HubPenjaminKLookUpEdit.EditValue != null) ? (short)HubPenjaminKLookUpEdit.EditValue : (short)-1
                                        };

                                        break;
                                    case Services.StatePenjamin.BPJS: //BPJS

                                        ipasienbpjs = new identitaspasienbpjs
                                        {
                                            nocm = pasien.nocm,
                                            nopeserta = NoPesertaKartuBPJS.Text,
                                            namapeserta = NamaPesertaKartuBPJS.Text,
                                            faskes = FaskesKartuBPJS.Text,
                                            kelasbpjsid = (KelasKartuBPJSLookUpEdit.EditValue != null) ? (short)KelasKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            jkid = (JKKartuBPJSLookUpEdit.EditValue != null) ? (short)JKKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            tempatlahir = TempatLahirKartuBPJS.Text,
                                            tanggallahir = (TglLahirKartuBPJSDateEdit.EditValue != null)? ((DateTime)TglLahirKartuBPJSDateEdit.EditValue).Date :  DateTime.Parse(null) ,
                                            alamat = AlamatKartuBPJSTextBox.Text,
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecKartuBPJSlookUpEdit.EditValue != null) ? (short)KecKartuBPJSlookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KelKartuBPJSLookUpEdit.EditValue != null) ? (short)KelKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            identitaspasienbpjssts = true
                                        };

                                        srtrujukanpuskesmas = new suratrujukanpuskesmas
                                        {
                                            suratrujukanpuskesmasid = -1,
                                            suratrujukanpuskesmastgl = TglRujukanSrtRujukanBPJSDateEdit.EditValue!=null?((DateTime)TglRujukanSrtRujukanBPJSDateEdit.EditValue).Date:DateTime.Parse(null),
                                            suratrujukanpuskesmasno = NoRujukanSrtRujukanBPJS.Text,
                                            puskesmasid = (PuskesmasSrtRujukanBPJSLookUpEdit.EditValue!=null)? short.Parse( PuskesmasSrtRujukanBPJSLookUpEdit.EditValue.ToString()):(short)-1,
                                            ruangrawatid = (TujuanSrtRujukanBPJSLookUpEdit.EditValue !=null)? short.Parse( TujuanSrtRujukanBPJSLookUpEdit.EditValue.ToString()):(short)-1,
                                            icdxsubkategoriid = DiagnosaAwalSrtRujukanBPJS.Text,
                                            icdxpuskesmasid = (DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue!=null)? short.Parse( DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue.ToString()): (short)-1,
                                            suratrujukanpuskesmastelahdiberikan = TelahDibreikanSrtRujukanBPJS.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            suratrujukanpuskesmassts = true

                                        };

                                        pjpasienbpjs = new penjaminpasienbpjs
                                        {
                                            penjaminpasienbpjsid = -1,
                                            nosep = NosepSEPBPJS.Text,
                                            tglsep = ((DateTime)TglSEPBPJSDateEdit.EditValue).Date,
                                            ruangrawatid = (TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue != null) ? (short)TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue : (short)-1,
                                            icdxsubkategoriid = selectedIcdxsubkategori.icdxsubkategoriid,
                                            icdxpuskesmasid = null,
                                            diagnosaalt = DiagnosaAltMTxt.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            penjaminpasienbpjssts = true

                                        };

                                        break;
                                    default://BPJS
                                        ipasienbpjs = new identitaspasienbpjs
                                        {
                                            nocm = pasien.nocm,
                                            nopeserta = NoPesertaKartuBPJS.Text,
                                            namapeserta = NamaPesertaKartuBPJS.Text,
                                            faskes = FaskesKartuBPJS.Text,
                                            kelasbpjsid = (KelasKartuBPJSLookUpEdit.EditValue != null) ? (short)KelasKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            jkid = (JKKartuBPJSLookUpEdit.EditValue != null) ? (short)JKKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            tempatlahir = TempatLahirKartuBPJS.Text,
                                            tanggallahir = (TglLahirKartuBPJSDateEdit.EditValue != null) ? ((DateTime)TglLahirKartuBPJSDateEdit.EditValue).Date : DateTime.Parse(null),
                                            alamat = AlamatKartuBPJSTextBox.Text,
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecKartuBPJSlookUpEdit.EditValue != null) ? (short)KecKartuBPJSlookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KelKartuBPJSLookUpEdit.EditValue != null) ? (short)KelKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            identitaspasienbpjssts = true
                                        };

                                        srtrujukanpuskesmas = new suratrujukanpuskesmas
                                        {
                                            suratrujukanpuskesmasid = -1,
                                            suratrujukanpuskesmastgl = TglRujukanSrtRujukanBPJSDateEdit.EditValue != null ? ((DateTime)TglRujukanSrtRujukanBPJSDateEdit.EditValue).Date : DateTime.Parse(null),
                                            suratrujukanpuskesmasno = NoRujukanSrtRujukanBPJS.Text,
                                            puskesmasid = (PuskesmasSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(PuskesmasSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            ruangrawatid = (TujuanSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(TujuanSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            icdxsubkategoriid = DiagnosaAwalSrtRujukanBPJS.Text,
                                            icdxpuskesmasid = (DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            suratrujukanpuskesmastelahdiberikan = TelahDibreikanSrtRujukanBPJS.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            suratrujukanpuskesmassts = true

                                        };


                                        pjpasienbpjs = new penjaminpasienbpjs
                                        {
                                            penjaminpasienbpjsid = -1,
                                            nosep = NosepSEPBPJS.Text,
                                            tglsep = ((DateTime)TglSEPBPJSDateEdit.EditValue).Date,
                                            ruangrawatid = (TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue != null) ? (short)TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue : (short)-1,
                                            icdxsubkategoriid = selectedIcdxsubkategori.icdxsubkategoriid,
                                            icdxpuskesmasid = null,
                                            diagnosaalt = DiagnosaAltMTxt.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            penjaminpasienbpjssts = true

                                        };

                                        break;

                                }

                                var result = (string.Empty,string.Empty);

                                switch (this.statepenjamin)
                                {
                                    case Services.StatePenjamin.DiriSendiri: //Diri Sendiri
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, pdirisendiri, vpelayananpasienkarcis,this.statepenjamin);
                                        break;
                                    case Services.StatePenjamin.Keluarga: //Keluarga
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, pkeluarga, vpelayananpasienkarcis,this.statepenjamin);
                                        break;
                                    case Services.StatePenjamin.BPJS:
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, ipasienbpjs, srtrujukanpuskesmas, pjpasienbpjs,  vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    default:
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, ipasienbpjs, srtrujukanpuskesmas, pjpasienbpjs, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                }

                                


                                if (!string.IsNullOrEmpty(result.Item1) && !string.IsNullOrEmpty(result.Item2))
                                {
                                    btnNext.Text = "Finish";
                                    isSave = true;
                                    NoRMReg.Text = result.Item1;
                                    NoregistrasiReg.Text = result.Item2;
                                    NoRMIP.Text = NoRMReg.Text;
                                    // NamaReg.Text = string.Format("{0}, {1}", SapaanIPLookUpEdit.Text, NamaIP.Text);
                                    //KelaminReg.Text = KelaminIPLookUpEdit.Text;
                                    //TglLahirReg.Text = TglLahirIPDateEdit.Text;
                                    //TglRegReg.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                                    //PoliklinikReg.Text = PoliLookUpEdit.Text;

                                    NoRMReg.ReadOnly = true;
                                    NoregistrasiReg.ReadOnly = true;
                                   

                                    EnableControlBasedChosePenjamin(false);

                                    listPanel[++indexPanel].BringToFront();
                                }
                                else
                                {
                                    isSave = false;
                                    MetroFramework.MetroMessageBox.Show(this, result.Item2 + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            catch (Exception ex)
                            {
                                isSave = false;
                                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        //btnNext.Text = "Finish";
                        //if (indexPanel < (listPanel.Count - 1))
                        //    listPanel[++indexPanel].BringToFront();

                        //isSave = false;
                        
                        if ((btnNext.Text == "Next") && (indexPanel < listPanel.Count - 1) && (isSave == true))
                        {
                            listPanel[++indexPanel].BringToFront();
                            btnNext.Text = "Finish";
                            NoRMReg.ReadOnly = true;
                            NoregistrasiReg.ReadOnly = true;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\n  btnNext_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasiRJ myForm = new FListRegistrasiRJ(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnKartuKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(NoRMReg.Text) ) || (string.IsNullOrEmpty(NoregistrasiReg.Text)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pasien belum diregistrasikan!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Loadv_statuspenyakitByNormAsync(NoRMReg.Text);

                KartuStatusReport1 report = new KartuStatusReport1(NoRMReg.Text , NamaIP.Text ,
                    string.Format("{0} Thn, {1} Bln, {2} Hari", ThnIP.Text , BlnIP.Text, HariIP.Text),
                    PekerjaanIPLookUpEdit.Text , string.Format("{0}, Kec.{1}, Kel/Desa.{2}", AlamatIP.Text,KecIPLookUpEdit.Text,KelIPLookUpEdit.Text) ,
                    this.penjaminLookUpEdit.Text,
                    ((this.PoliLookUpEdit!=null)?  this.PoliLookUpEdit.Text.ToUpper():string.Empty),
                    this.v_Statuspenyakits);
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }

                report.ShowRibbonPreview();

            }
            catch (Exception ex)
            {
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnKartuKontrol_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.panel3.SuspendLayout();
            this.pnlPenjamin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlKartuBPJS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penjaminpasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keldesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelasBindingSource)).BeginInit();
            this.pnlSuratRujukanBPJS.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruangrawatrujukanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perujukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuskesmasSrtRujukanBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vicdxsubkategoriengBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecKartuBPJSlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelKartuBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjaminLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirKartuBPJSDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirKartuBPJSDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelasKartuBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKKartuBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWKartuBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsalRujukanSrtRujukanBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglRujukanSrtRujukanBPJSDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglRujukanSrtRujukanBPJSDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TujuanSrtRujukanBPJSLookUpEdit.Properties)).BeginInit();
            this.pnlKeluarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HubPenjaminKLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKPenjaminKlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWPenjaminKLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeldesaPenjaminKLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecPenjaminKLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdentitasdiriPenjaminKLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminKDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminKDateEdit.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlIdentitasPasien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KelaminIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirIPDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirIPDateEdit.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SapaanIPLookUpEdit.Properties)).BeginInit();
            this.pnlDiriSendiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdentitasdiriPenjaminDiriSendiriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminDiriSendiriDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminDiriSendiriDateEdit.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SukuIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GolDarahIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgamaIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PekerjaanIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PendidikanIPLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StsNikahIPLookUpEdit.Properties)).BeginInit();
            this.pnlPoli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoliLookUpEdit.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            this.pnlSEPBPJS.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TglSEPBPJSDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglSEPBPJSDateEdit.Properties)).BeginInit();
            this.pnlRegistrasi.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDiriSendiriDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDiriSendiriDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelaminDiriSendiriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWDiriSendiriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelDiriSendiriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecDiriSendiriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PekerjaanDiriSendiriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PekerjaanPenjaminKlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosaAwalSEPBPJSButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TujuanSrtRujukanSEPBPJSLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglMasukDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglMasukDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            // 
            // NoPesertaKartuBPJS
            // 
            // 
            // 
            // 
            this.NoPesertaKartuBPJS.CustomButton.Image = null;
            this.NoPesertaKartuBPJS.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.NoPesertaKartuBPJS.CustomButton.Name = "";
            this.NoPesertaKartuBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoPesertaKartuBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoPesertaKartuBPJS.CustomButton.TabIndex = 1;
            this.NoPesertaKartuBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoPesertaKartuBPJS.CustomButton.UseSelectable = true;
            this.NoPesertaKartuBPJS.CustomButton.Visible = false;
            this.NoPesertaKartuBPJS.Lines = new string[0];
            // 
            // NamaPesertaKartuBPJS
            // 
            // 
            // 
            // 
            this.NamaPesertaKartuBPJS.CustomButton.Image = null;
            this.NamaPesertaKartuBPJS.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.NamaPesertaKartuBPJS.CustomButton.Name = "";
            this.NamaPesertaKartuBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaPesertaKartuBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaPesertaKartuBPJS.CustomButton.TabIndex = 1;
            this.NamaPesertaKartuBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaPesertaKartuBPJS.CustomButton.UseSelectable = true;
            this.NamaPesertaKartuBPJS.CustomButton.Visible = false;
            this.NamaPesertaKartuBPJS.Lines = new string[0];
            // 
            // TempatLahirKartuBPJS
            // 
            // 
            // 
            // 
            this.TempatLahirKartuBPJS.CustomButton.Image = null;
            this.TempatLahirKartuBPJS.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.TempatLahirKartuBPJS.CustomButton.Name = "";
            this.TempatLahirKartuBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TempatLahirKartuBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TempatLahirKartuBPJS.CustomButton.TabIndex = 1;
            this.TempatLahirKartuBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TempatLahirKartuBPJS.CustomButton.UseSelectable = true;
            this.TempatLahirKartuBPJS.CustomButton.Visible = false;
            this.TempatLahirKartuBPJS.Lines = new string[0];
            // 
            // AlamatKartuBPJSTextBox
            // 
            // 
            // 
            // 
            this.AlamatKartuBPJSTextBox.CustomButton.Image = null;
            this.AlamatKartuBPJSTextBox.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.AlamatKartuBPJSTextBox.CustomButton.Name = "";
            this.AlamatKartuBPJSTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AlamatKartuBPJSTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlamatKartuBPJSTextBox.CustomButton.TabIndex = 1;
            this.AlamatKartuBPJSTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AlamatKartuBPJSTextBox.CustomButton.UseSelectable = true;
            this.AlamatKartuBPJSTextBox.CustomButton.Visible = false;
            this.AlamatKartuBPJSTextBox.Lines = new string[0];
            // 
            // FaskesKartuBPJS
            // 
            // 
            // 
            // 
            this.FaskesKartuBPJS.CustomButton.Image = null;
            this.FaskesKartuBPJS.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.FaskesKartuBPJS.CustomButton.Name = "";
            this.FaskesKartuBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FaskesKartuBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FaskesKartuBPJS.CustomButton.TabIndex = 1;
            this.FaskesKartuBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FaskesKartuBPJS.CustomButton.UseSelectable = true;
            this.FaskesKartuBPJS.CustomButton.Visible = false;
            this.FaskesKartuBPJS.Lines = new string[0];
            // 
            // TelahDibreikanSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Image = null;
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Name = "";
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.TelahDibreikanSrtRujukanBPJS.CustomButton.Visible = false;
            this.TelahDibreikanSrtRujukanBPJS.Lines = new string[0];
            // 
            // NoRujukanSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.NoRujukanSrtRujukanBPJS.CustomButton.Image = null;
            this.NoRujukanSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoRujukanSrtRujukanBPJS.CustomButton.Name = "";
            this.NoRujukanSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoRujukanSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoRujukanSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.NoRujukanSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoRujukanSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.NoRujukanSrtRujukanBPJS.CustomButton.Visible = false;
            this.NoRujukanSrtRujukanBPJS.Lines = new string[0];
            // 
            // FaskesNoSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.FaskesNoSrtRujukanBPJS.CustomButton.Image = null;
            this.FaskesNoSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.FaskesNoSrtRujukanBPJS.CustomButton.Name = "";
            this.FaskesNoSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FaskesNoSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FaskesNoSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.FaskesNoSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FaskesNoSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.FaskesNoSrtRujukanBPJS.CustomButton.Visible = false;
            this.FaskesNoSrtRujukanBPJS.Lines = new string[0];
            // 
            // NmPuskesmasSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Image = null;
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Name = "";
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.NmPuskesmasSrtRujukanBPJS.CustomButton.Visible = false;
            this.NmPuskesmasSrtRujukanBPJS.Lines = new string[0];
            // 
            // NoPuskesmasSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Image = null;
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Name = "";
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.NoPuskesmasSrtRujukanBPJS.CustomButton.Visible = false;
            this.NoPuskesmasSrtRujukanBPJS.Lines = new string[0];
            // 
            // PuskesmasSrtRujukanBPJSLookUpEdit
            // 
            // 
            // DiagnosaAlternatifSrtRujukanBPJSLookUpEdit
            // 
            // 
            // KecKartuBPJSlookUpEdit
            // 
            // 
            // KelKartuBPJSLookUpEdit
            // 
            // 
            // penjaminLookUpEdit
            // 
            // 
            // TglLahirKartuBPJSDateEdit
            // 
            this.TglLahirKartuBPJSDateEdit.EditValue = null;
            // 
            // KelasKartuBPJSLookUpEdit
            // 
            // 
            // JKKartuBPJSLookUpEdit
            // 
            // 
            // RTRWKartuBPJSLookUpEdit
            // 
            // 
            // AsalRujukanSrtRujukanBPJSLookUpEdit
            // 
            // 
            // TglRujukanSrtRujukanBPJSDateEdit
            // 
            this.TglRujukanSrtRujukanBPJSDateEdit.EditValue = null;
            // 
            // TujuanSrtRujukanBPJSLookUpEdit
            // 
            // 
            // DiagnosaAwalSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Image = null;
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Name = "";
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.DiagnosaAwalSrtRujukanBPJS.CustomButton.Visible = false;
            this.DiagnosaAwalSrtRujukanBPJS.Lines = new string[0];
            // 
            // icdxindoDataNavigator
            // 
            this.icdxindoDataNavigator.Buttons.Append.Visible = false;
            this.icdxindoDataNavigator.Buttons.CancelEdit.Visible = false;
            this.icdxindoDataNavigator.Buttons.EndEdit.Visible = false;
            this.icdxindoDataNavigator.Buttons.First.Visible = false;
            this.icdxindoDataNavigator.Buttons.Last.Visible = false;
            this.icdxindoDataNavigator.Buttons.NextPage.Visible = false;
            this.icdxindoDataNavigator.Buttons.PrevPage.Visible = false;
            this.icdxindoDataNavigator.Buttons.Remove.Visible = false;
            // 
            // NamaDiagnosaAwalSrtRujukanBPJS
            // 
            // 
            // 
            // 
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Image = null;
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Name = "";
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.TabIndex = 1;
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.UseSelectable = true;
            this.NamaDiagnosaAwalSrtRujukanBPJS.CustomButton.Visible = false;
            this.NamaDiagnosaAwalSrtRujukanBPJS.Lines = new string[0];
            // 
            // HubPenjaminKLookUpEdit
            // 
            // 
            // NoHPPenjaminK
            // 
            // 
            // 
            // 
            this.NoHPPenjaminK.CustomButton.Image = null;
            this.NoHPPenjaminK.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoHPPenjaminK.CustomButton.Name = "";
            this.NoHPPenjaminK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoHPPenjaminK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoHPPenjaminK.CustomButton.TabIndex = 1;
            this.NoHPPenjaminK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoHPPenjaminK.CustomButton.UseSelectable = true;
            this.NoHPPenjaminK.CustomButton.Visible = false;
            this.NoHPPenjaminK.Lines = new string[0];
            // 
            // JKPenjaminKlookUpEdit
            // 
            // 
            // RTRWPenjaminKLookUpEdit
            // 
            // 
            // KeldesaPenjaminKLookUpEdit
            // 
            // 
            // KecPenjaminKLookUpEdit
            // 
            // 
            // AlamatPenjaminK
            // 
            // 
            // 
            // 
            this.AlamatPenjaminK.CustomButton.Image = null;
            this.AlamatPenjaminK.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.AlamatPenjaminK.CustomButton.Name = "";
            this.AlamatPenjaminK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AlamatPenjaminK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlamatPenjaminK.CustomButton.TabIndex = 1;
            this.AlamatPenjaminK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AlamatPenjaminK.CustomButton.UseSelectable = true;
            this.AlamatPenjaminK.CustomButton.Visible = false;
            this.AlamatPenjaminK.Lines = new string[0];
            // 
            // NamaPenjaminK
            // 
            // 
            // 
            // 
            this.NamaPenjaminK.CustomButton.Image = null;
            this.NamaPenjaminK.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NamaPenjaminK.CustomButton.Name = "";
            this.NamaPenjaminK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaPenjaminK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaPenjaminK.CustomButton.TabIndex = 1;
            this.NamaPenjaminK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaPenjaminK.CustomButton.UseSelectable = true;
            this.NamaPenjaminK.CustomButton.Visible = false;
            this.NamaPenjaminK.Lines = new string[0];
            // 
            // IdentitasdiriPenjaminKLookUpEdit
            // 
            // 
            // NoTelpPenjaminK
            // 
            // 
            // 
            // 
            this.NoTelpPenjaminK.CustomButton.Image = null;
            this.NoTelpPenjaminK.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoTelpPenjaminK.CustomButton.Name = "";
            this.NoTelpPenjaminK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoTelpPenjaminK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoTelpPenjaminK.CustomButton.TabIndex = 1;
            this.NoTelpPenjaminK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoTelpPenjaminK.CustomButton.UseSelectable = true;
            this.NoTelpPenjaminK.CustomButton.Visible = false;
            this.NoTelpPenjaminK.Lines = new string[0];
            // 
            // TglPenjaminKDateEdit
            // 
            this.TglPenjaminKDateEdit.EditValue = null;
            // 
            // NoIdentitasPenjaminK
            // 
            // 
            // 
            // 
            this.NoIdentitasPenjaminK.CustomButton.Image = null;
            this.NoIdentitasPenjaminK.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoIdentitasPenjaminK.CustomButton.Name = "";
            this.NoIdentitasPenjaminK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoIdentitasPenjaminK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoIdentitasPenjaminK.CustomButton.TabIndex = 1;
            this.NoIdentitasPenjaminK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoIdentitasPenjaminK.CustomButton.UseSelectable = true;
            this.NoIdentitasPenjaminK.CustomButton.Visible = false;
            this.NoIdentitasPenjaminK.Lines = new string[0];
            // 
            // AlamatIP
            // 
            // 
            // 
            // 
            this.AlamatIP.CustomButton.Image = null;
            this.AlamatIP.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.AlamatIP.CustomButton.Name = "";
            this.AlamatIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AlamatIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlamatIP.CustomButton.TabIndex = 1;
            this.AlamatIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AlamatIP.CustomButton.UseSelectable = true;
            this.AlamatIP.CustomButton.Visible = false;
            this.AlamatIP.Lines = new string[0];
            // 
            // KelaminIPLookUpEdit
            // 
            this.KelaminIPLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.KelaminIPLookUpEdit.Properties.Appearance.Options.UseBackColor = true;
            // 
            // KelIPLookUpEdit
            // 
            // 
            // RTRWIPLookUpEdit
            // 
            // 
            // KecIPLookUpEdit
            // 
            // 
            // NamaIP
            // 
            // 
            // 
            // 
            this.NamaIP.CustomButton.Image = null;
            this.NamaIP.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NamaIP.CustomButton.Name = "";
            this.NamaIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaIP.CustomButton.TabIndex = 1;
            this.NamaIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaIP.CustomButton.UseSelectable = true;
            this.NamaIP.CustomButton.Visible = false;
            this.NamaIP.Lines = new string[0];
            // 
            // NoTelpIP
            // 
            // 
            // 
            // 
            this.NoTelpIP.CustomButton.Image = null;
            this.NoTelpIP.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoTelpIP.CustomButton.Name = "";
            this.NoTelpIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoTelpIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoTelpIP.CustomButton.TabIndex = 1;
            this.NoTelpIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoTelpIP.CustomButton.UseSelectable = true;
            this.NoTelpIP.CustomButton.Visible = false;
            this.NoTelpIP.Lines = new string[0];
            // 
            // TglLahirIPDateEdit
            // 
            this.TglLahirIPDateEdit.EditValue = null;
            this.TglLahirIPDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TglLahirIPDateEdit.Properties.Appearance.Options.UseFont = true;
            // 
            // SapaanIPLookUpEdit
            // 
            // 
            // IdentitasdiriPenjaminDiriSendiriLookUpEdit
            // 
            // 
            // TglPenjaminDiriSendiriDateEdit
            // 
            this.TglPenjaminDiriSendiriDateEdit.EditValue = null;
            // 
            // NoIdentitasPenjaminDiriSendiri
            // 
            // 
            // 
            // 
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Image = null;
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Name = "";
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.TabIndex = 1;
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.UseSelectable = true;
            this.NoIdentitasPenjaminDiriSendiri.CustomButton.Visible = false;
            this.NoIdentitasPenjaminDiriSendiri.Lines = new string[0];
            // 
            // TempatLahirIP
            // 
            // 
            // 
            // 
            this.TempatLahirIP.CustomButton.Image = null;
            this.TempatLahirIP.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.TempatLahirIP.CustomButton.Name = "";
            this.TempatLahirIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TempatLahirIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TempatLahirIP.CustomButton.TabIndex = 1;
            this.TempatLahirIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TempatLahirIP.CustomButton.UseSelectable = true;
            this.TempatLahirIP.CustomButton.Visible = false;
            this.TempatLahirIP.Lines = new string[0];
            // 
            // SukuIPLookUpEdit
            // 
            // 
            // GolDarahIPLookUpEdit
            // 
            // 
            // AgamaIPLookUpEdit
            // 
            // 
            // PekerjaanIPLookUpEdit
            // 
            // 
            // PendidikanIPLookUpEdit
            // 
            // 
            // StsNikahIPLookUpEdit
            // 
            // 
            // NoHPIP
            // 
            // 
            // 
            // 
            this.NoHPIP.CustomButton.Image = null;
            this.NoHPIP.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoHPIP.CustomButton.Name = "";
            this.NoHPIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoHPIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoHPIP.CustomButton.TabIndex = 1;
            this.NoHPIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoHPIP.CustomButton.UseSelectable = true;
            this.NoHPIP.CustomButton.Visible = false;
            this.NoHPIP.Lines = new string[0];
            // 
            // HariIP
            // 
            // 
            // 
            // 
            this.HariIP.CustomButton.Image = null;
            this.HariIP.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.HariIP.CustomButton.Name = "";
            this.HariIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.HariIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HariIP.CustomButton.TabIndex = 1;
            this.HariIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HariIP.CustomButton.UseSelectable = true;
            this.HariIP.CustomButton.Visible = false;
            this.HariIP.Lines = new string[] {
        "0"};
            // 
            // BlnIP
            // 
            // 
            // 
            // 
            this.BlnIP.CustomButton.Image = null;
            this.BlnIP.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.BlnIP.CustomButton.Name = "";
            this.BlnIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BlnIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BlnIP.CustomButton.TabIndex = 1;
            this.BlnIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BlnIP.CustomButton.UseSelectable = true;
            this.BlnIP.CustomButton.Visible = false;
            this.BlnIP.Lines = new string[] {
        "0"};
            // 
            // ThnIP
            // 
            // 
            // 
            // 
            this.ThnIP.CustomButton.Image = null;
            this.ThnIP.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.ThnIP.CustomButton.Name = "";
            this.ThnIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ThnIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ThnIP.CustomButton.TabIndex = 1;
            this.ThnIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ThnIP.CustomButton.UseSelectable = true;
            this.ThnIP.CustomButton.Visible = false;
            this.ThnIP.Lines = new string[] {
        "0"};
            // 
            // PoliLookUpEdit
            // 
            // 
            // KodePoli
            // 
            // 
            // 
            // 
            this.KodePoli.CustomButton.Image = null;
            this.KodePoli.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.KodePoli.CustomButton.Name = "";
            this.KodePoli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KodePoli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KodePoli.CustomButton.TabIndex = 1;
            this.KodePoli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KodePoli.CustomButton.UseSelectable = true;
            this.KodePoli.CustomButton.Visible = false;
            this.KodePoli.Lines = new string[0];
            // 
            // NamaPoli
            // 
            // 
            // 
            // 
            this.NamaPoli.CustomButton.Image = null;
            this.NamaPoli.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NamaPoli.CustomButton.Name = "";
            this.NamaPoli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaPoli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaPoli.CustomButton.TabIndex = 1;
            this.NamaPoli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaPoli.CustomButton.UseSelectable = true;
            this.NamaPoli.CustomButton.Visible = false;
            this.NamaPoli.Lines = new string[0];
            // 
            // AsalFaskesSEPBPJS
            // 
            // 
            // 
            // 
            this.AsalFaskesSEPBPJS.CustomButton.Image = null;
            this.AsalFaskesSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.AsalFaskesSEPBPJS.CustomButton.Name = "";
            this.AsalFaskesSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AsalFaskesSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AsalFaskesSEPBPJS.CustomButton.TabIndex = 1;
            this.AsalFaskesSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AsalFaskesSEPBPJS.CustomButton.UseSelectable = true;
            this.AsalFaskesSEPBPJS.CustomButton.Visible = false;
            this.AsalFaskesSEPBPJS.Lines = new string[0];
            // 
            // PesertaSEPBPJS
            // 
            // 
            // 
            // 
            this.PesertaSEPBPJS.CustomButton.Image = null;
            this.PesertaSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.PesertaSEPBPJS.CustomButton.Name = "";
            this.PesertaSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PesertaSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PesertaSEPBPJS.CustomButton.TabIndex = 1;
            this.PesertaSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PesertaSEPBPJS.CustomButton.UseSelectable = true;
            this.PesertaSEPBPJS.CustomButton.Visible = false;
            this.PesertaSEPBPJS.Lines = new string[0];
            // 
            // KelaminSEPBPJS
            // 
            // 
            // 
            // 
            this.KelaminSEPBPJS.CustomButton.Image = null;
            this.KelaminSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.KelaminSEPBPJS.CustomButton.Name = "";
            this.KelaminSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KelaminSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KelaminSEPBPJS.CustomButton.TabIndex = 1;
            this.KelaminSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KelaminSEPBPJS.CustomButton.UseSelectable = true;
            this.KelaminSEPBPJS.CustomButton.Visible = false;
            this.KelaminSEPBPJS.Lines = new string[0];
            // 
            // NamaPesertaSEPBPJS
            // 
            // 
            // 
            // 
            this.NamaPesertaSEPBPJS.CustomButton.Image = null;
            this.NamaPesertaSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NamaPesertaSEPBPJS.CustomButton.Name = "";
            this.NamaPesertaSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaPesertaSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaPesertaSEPBPJS.CustomButton.TabIndex = 1;
            this.NamaPesertaSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaPesertaSEPBPJS.CustomButton.UseSelectable = true;
            this.NamaPesertaSEPBPJS.CustomButton.Visible = false;
            this.NamaPesertaSEPBPJS.Lines = new string[0];
            // 
            // NoCMSEPBPJS
            // 
            // 
            // 
            // 
            this.NoCMSEPBPJS.CustomButton.Image = null;
            this.NoCMSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoCMSEPBPJS.CustomButton.Name = "";
            this.NoCMSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoCMSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoCMSEPBPJS.CustomButton.TabIndex = 1;
            this.NoCMSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoCMSEPBPJS.CustomButton.UseSelectable = true;
            this.NoCMSEPBPJS.CustomButton.Visible = false;
            this.NoCMSEPBPJS.Lines = new string[0];
            // 
            // NoKartuBPJSSEPBPJS
            // 
            // 
            // 
            // 
            this.NoKartuBPJSSEPBPJS.CustomButton.Image = null;
            this.NoKartuBPJSSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoKartuBPJSSEPBPJS.CustomButton.Name = "";
            this.NoKartuBPJSSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoKartuBPJSSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoKartuBPJSSEPBPJS.CustomButton.TabIndex = 1;
            this.NoKartuBPJSSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoKartuBPJSSEPBPJS.CustomButton.UseSelectable = true;
            this.NoKartuBPJSSEPBPJS.CustomButton.Visible = false;
            this.NoKartuBPJSSEPBPJS.Lines = new string[0];
            // 
            // KelasRawatSEPBPJS
            // 
            // 
            // 
            // 
            this.KelasRawatSEPBPJS.CustomButton.Image = null;
            this.KelasRawatSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.KelasRawatSEPBPJS.CustomButton.Name = "";
            this.KelasRawatSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KelasRawatSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KelasRawatSEPBPJS.CustomButton.TabIndex = 1;
            this.KelasRawatSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KelasRawatSEPBPJS.CustomButton.UseSelectable = true;
            this.KelasRawatSEPBPJS.CustomButton.Visible = false;
            this.KelasRawatSEPBPJS.Lines = new string[0];
            // 
            // JenisRawatSEPBPJS
            // 
            // 
            // 
            // 
            this.JenisRawatSEPBPJS.CustomButton.Image = null;
            this.JenisRawatSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.JenisRawatSEPBPJS.CustomButton.Name = "";
            this.JenisRawatSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.JenisRawatSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.JenisRawatSEPBPJS.CustomButton.TabIndex = 1;
            this.JenisRawatSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.JenisRawatSEPBPJS.CustomButton.UseSelectable = true;
            this.JenisRawatSEPBPJS.CustomButton.Visible = false;
            this.JenisRawatSEPBPJS.Lines = new string[0];
            // 
            // COBSEPBPJS
            // 
            // 
            // 
            // 
            this.COBSEPBPJS.CustomButton.Image = null;
            this.COBSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.COBSEPBPJS.CustomButton.Name = "";
            this.COBSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.COBSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.COBSEPBPJS.CustomButton.TabIndex = 1;
            this.COBSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.COBSEPBPJS.CustomButton.UseSelectable = true;
            this.COBSEPBPJS.CustomButton.Visible = false;
            this.COBSEPBPJS.Lines = new string[0];
            // 
            // TglLahirSEPBPJS
            // 
            // 
            // 
            // 
            this.TglLahirSEPBPJS.CustomButton.Image = null;
            this.TglLahirSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.TglLahirSEPBPJS.CustomButton.Name = "";
            this.TglLahirSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TglLahirSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TglLahirSEPBPJS.CustomButton.TabIndex = 1;
            this.TglLahirSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TglLahirSEPBPJS.CustomButton.UseSelectable = true;
            this.TglLahirSEPBPJS.CustomButton.Visible = false;
            this.TglLahirSEPBPJS.Lines = new string[0];
            // 
            // NosepSEPBPJS
            // 
            // 
            // 
            // 
            this.NosepSEPBPJS.CustomButton.Image = null;
            this.NosepSEPBPJS.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NosepSEPBPJS.CustomButton.Name = "";
            this.NosepSEPBPJS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NosepSEPBPJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NosepSEPBPJS.CustomButton.TabIndex = 1;
            this.NosepSEPBPJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NosepSEPBPJS.CustomButton.UseSelectable = true;
            this.NosepSEPBPJS.CustomButton.Visible = false;
            this.NosepSEPBPJS.Lines = new string[0];
            // 
            // TglSEPBPJSDateEdit
            // 
            this.TglSEPBPJSDateEdit.EditValue = null;
            // 
            // NoRMReg
            // 
            // 
            // 
            // 
            this.NoRMReg.CustomButton.Image = null;
            this.NoRMReg.CustomButton.Location = new System.Drawing.Point(459, 2);
            this.NoRMReg.CustomButton.Name = "";
            this.NoRMReg.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.NoRMReg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoRMReg.CustomButton.TabIndex = 1;
            this.NoRMReg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoRMReg.CustomButton.UseSelectable = true;
            this.NoRMReg.CustomButton.Visible = false;
            this.NoRMReg.Lines = new string[0];
            // 
            // NoregistrasiReg
            // 
            // 
            // 
            // 
            this.NoregistrasiReg.CustomButton.Image = null;
            this.NoregistrasiReg.CustomButton.Location = new System.Drawing.Point(459, 2);
            this.NoregistrasiReg.CustomButton.Name = "";
            this.NoregistrasiReg.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.NoregistrasiReg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoregistrasiReg.CustomButton.TabIndex = 1;
            this.NoregistrasiReg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoregistrasiReg.CustomButton.UseSelectable = true;
            this.NoregistrasiReg.CustomButton.Visible = false;
            this.NoregistrasiReg.Lines = new string[0];
            // 
            // TglLahirDiriSendiriDateEdit
            // 
            this.TglLahirDiriSendiriDateEdit.EditValue = null;
            // 
            // KelaminDiriSendiriLookUpEdit
            // 
            // 
            // RTRWDiriSendiriLookUpEdit
            // 
            // 
            // KelDiriSendiriLookUpEdit
            // 
            // 
            // KecDiriSendiriLookUpEdit
            // 
            // 
            // TempatLahirDiriSendiri
            // 
            // 
            // 
            // 
            this.TempatLahirDiriSendiri.CustomButton.Image = null;
            this.TempatLahirDiriSendiri.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.TempatLahirDiriSendiri.CustomButton.Name = "";
            this.TempatLahirDiriSendiri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TempatLahirDiriSendiri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TempatLahirDiriSendiri.CustomButton.TabIndex = 1;
            this.TempatLahirDiriSendiri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TempatLahirDiriSendiri.CustomButton.UseSelectable = true;
            this.TempatLahirDiriSendiri.CustomButton.Visible = false;
            this.TempatLahirDiriSendiri.Lines = new string[0];
            // 
            // NamaDiriSendiri
            // 
            // 
            // 
            // 
            this.NamaDiriSendiri.CustomButton.Image = null;
            this.NamaDiriSendiri.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NamaDiriSendiri.CustomButton.Name = "";
            this.NamaDiriSendiri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NamaDiriSendiri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NamaDiriSendiri.CustomButton.TabIndex = 1;
            this.NamaDiriSendiri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NamaDiriSendiri.CustomButton.UseSelectable = true;
            this.NamaDiriSendiri.CustomButton.Visible = false;
            this.NamaDiriSendiri.Lines = new string[0];
            // 
            // NoTelpDiriSendiri
            // 
            // 
            // 
            // 
            this.NoTelpDiriSendiri.CustomButton.Image = null;
            this.NoTelpDiriSendiri.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoTelpDiriSendiri.CustomButton.Name = "";
            this.NoTelpDiriSendiri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoTelpDiriSendiri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoTelpDiriSendiri.CustomButton.TabIndex = 1;
            this.NoTelpDiriSendiri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoTelpDiriSendiri.CustomButton.UseSelectable = true;
            this.NoTelpDiriSendiri.CustomButton.Visible = false;
            this.NoTelpDiriSendiri.Lines = new string[0];
            // 
            // PekerjaanDiriSendiriLookUpEdit
            // 
            // 
            // ALamatDiriSendiri
            // 
            // 
            // 
            // 
            this.ALamatDiriSendiri.CustomButton.Image = null;
            this.ALamatDiriSendiri.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.ALamatDiriSendiri.CustomButton.Name = "";
            this.ALamatDiriSendiri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ALamatDiriSendiri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ALamatDiriSendiri.CustomButton.TabIndex = 1;
            this.ALamatDiriSendiri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ALamatDiriSendiri.CustomButton.UseSelectable = true;
            this.ALamatDiriSendiri.CustomButton.Visible = false;
            this.ALamatDiriSendiri.Lines = new string[0];
            // 
            // PekerjaanPenjaminKlookUpEdit
            // 
            // 
            // NoRMIP
            // 
            // 
            // 
            // 
            this.NoRMIP.CustomButton.Image = null;
            this.NoRMIP.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoRMIP.CustomButton.Name = "";
            this.NoRMIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoRMIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoRMIP.CustomButton.TabIndex = 1;
            this.NoRMIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoRMIP.CustomButton.UseSelectable = true;
            this.NoRMIP.CustomButton.Visible = false;
            this.NoRMIP.Lines = new string[0];
            // 
            // NoHPDiriSendiri
            // 
            // 
            // 
            // 
            this.NoHPDiriSendiri.CustomButton.Image = null;
            this.NoHPDiriSendiri.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.NoHPDiriSendiri.CustomButton.Name = "";
            this.NoHPDiriSendiri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoHPDiriSendiri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoHPDiriSendiri.CustomButton.TabIndex = 1;
            this.NoHPDiriSendiri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoHPDiriSendiri.CustomButton.UseSelectable = true;
            this.NoHPDiriSendiri.CustomButton.Visible = false;
            this.NoHPDiriSendiri.Lines = new string[0];
            // 
            // DiagnosaAltMTxt
            // 
            // 
            // 
            // 
            this.DiagnosaAltMTxt.CustomButton.Image = null;
            this.DiagnosaAltMTxt.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.DiagnosaAltMTxt.CustomButton.Name = "";
            this.DiagnosaAltMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DiagnosaAltMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DiagnosaAltMTxt.CustomButton.TabIndex = 1;
            this.DiagnosaAltMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DiagnosaAltMTxt.CustomButton.UseSelectable = true;
            this.DiagnosaAltMTxt.CustomButton.Visible = false;
            this.DiagnosaAltMTxt.Lines = new string[0];
            // 
            // DiagnosaAwalSEPBPJSButtonEdit
            // 
            // 
            // TujuanSrtRujukanSEPBPJSLookUpEdit
            // 
            // 
            // tglMasukDateEdit
            // 
            this.tglMasukDateEdit.EditValue = null;
            this.tglMasukDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tglMasukDateEdit.Properties.Appearance.Options.UseFont = true;
            // 
            // FAddEditRegistrasiPasienBaruRJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FAddEditRegistrasiPasienBaruRJ";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPenjamin.ResumeLayout(false);
            this.pnlPenjamin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlKartuBPJS.ResumeLayout(false);
            this.pnlKartuBPJS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penjaminpasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keldesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelasBindingSource)).EndInit();
            this.pnlSuratRujukanBPJS.ResumeLayout(false);
            this.pnlSuratRujukanBPJS.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruangrawatrujukanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perujukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puskesmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuskesmasSrtRujukanBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vicdxsubkategoriengBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecKartuBPJSlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelKartuBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjaminLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirKartuBPJSDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirKartuBPJSDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelasKartuBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKKartuBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWKartuBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsalRujukanSrtRujukanBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglRujukanSrtRujukanBPJSDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglRujukanSrtRujukanBPJSDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TujuanSrtRujukanBPJSLookUpEdit.Properties)).EndInit();
            this.pnlKeluarga.ResumeLayout(false);
            this.pnlKeluarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HubPenjaminKLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKPenjaminKlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWPenjaminKLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeldesaPenjaminKLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecPenjaminKLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdentitasdiriPenjaminKLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminKDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminKDateEdit.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlIdentitasPasien.ResumeLayout(false);
            this.pnlIdentitasPasien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KelaminIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirIPDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirIPDateEdit.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SapaanIPLookUpEdit.Properties)).EndInit();
            this.pnlDiriSendiri.ResumeLayout(false);
            this.pnlDiriSendiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdentitasdiriPenjaminDiriSendiriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminDiriSendiriDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglPenjaminDiriSendiriDateEdit.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SukuIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GolDarahIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgamaIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PekerjaanIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PendidikanIPLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StsNikahIPLookUpEdit.Properties)).EndInit();
            this.pnlPoli.ResumeLayout(false);
            this.pnlPoli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoliLookUpEdit.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlSEPBPJS.ResumeLayout(false);
            this.pnlSEPBPJS.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TglSEPBPJSDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglSEPBPJSDateEdit.Properties)).EndInit();
            this.pnlRegistrasi.ResumeLayout(false);
            this.pnlRegistrasi.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDiriSendiriDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDiriSendiriDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelaminDiriSendiriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTRWDiriSendiriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KelDiriSendiriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KecDiriSendiriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PekerjaanDiriSendiriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PekerjaanPenjaminKlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosaAwalSEPBPJSButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TujuanSrtRujukanSEPBPJSLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglMasukDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglMasukDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
