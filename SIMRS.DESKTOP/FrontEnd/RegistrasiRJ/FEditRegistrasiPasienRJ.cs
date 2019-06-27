using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FEditRegistrasiPasienRJ : FAddEditRegistrasiPasienLamaRJ
    {

        private int indexSelectedRegistrasiRJ = -1;


        #region constructor

        public FEditRegistrasiPasienRJ(ref Panel _pnlContent, string nocm) : base(ref _pnlContent, nocm)
        {
            try
            {
                Helper.Stspasienbaru.id = -1;

                this.Text = "Edit Registrasi Pasien";
                
                this.nocm = nocm;
                //AddCollectionPanelPasienLamaRJ();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FEditRegistrasiPasienRJ(ref Panel _pnlContent, string nocm, short registrasiid) : base(ref _pnlContent, nocm)
        {
            try
            {
                Helper.Stspasienbaru.id = -1;

                this.Text = "Edit Registrasi Pasien";
                this.registrasiid = registrasiid;
                this.nocm = nocm;
                //AddCollectionPanelPasienLamaRJ();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);

                SelectStspasienbaruByRegistrasiId(this.registrasiid);
                if (this.Stspasienbaru != null)
                {
                    Helper.Stspasienbaru.id = this.Stspasienbaru.id;
                    Helper.Stspasienbaru.nm = this.Stspasienbaru.nm;
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FEditRegistrasiPasienRJ(ref Panel _pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat, int indexSelectedRegistrasiRJ) : base(ref _pnlContent)
        {
            try
            {
                Helper.Stspasienbaru.id = -1;

                this.Text = "Edit Registrasi Pasien";
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.nocm = this.v_Registrasiruangrawat.nocm;
                this.registrasiid = this.v_Registrasiruangrawat.registrasiid;
                this.indexSelectedRegistrasiRJ = indexSelectedRegistrasiRJ;

                //AddCollectionPanelPasienLamaRJ();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);

                SelectStspasienbaruByRegistrasiId(this.registrasiid);
                if (this.Stspasienbaru != null)
                {
                    Helper.Stspasienbaru.id = this.Stspasienbaru.id;
                    Helper.Stspasienbaru.nm = this.Stspasienbaru.nm;
                }

                ///this.PoliLookUpEdit.EditValue = this.v_Registrasiruangrawat.ruangrawatid;
                //this.tglMasukDateEdit.EditValue = DateTime.Now;


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion constructor

        protected override void FAddEditRegistrasiPasien_Load(object sender, EventArgs e)
        {
            try
            {
                this.isSave = false;

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


                FirtOrDefaultIdentitasPasienAlamatPasienByNocmAsyncService(this.v_Registrasiruangrawat.nocm);



                Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref this.pnlIdentitasPasien, false);
                LblStepIdentitasPasien.Text = "Step 1";
                lblStepPenjamin.Text = "Step 2";

                //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

                AddCollectionPanelPasienLamaRJ();
                //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

                NoRMIP.ReadOnly = true;
                NoRMReg.ReadOnly = true;
                NoregistrasiReg.ReadOnly = true;


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void btnNext_Click(object sender, EventArgs e)
        {
            try
            {


                if (listPanel.Count == 2)
                {
                    //if (++indexPanel> 1)
                    //{
                    //    indexPanel = 0;
                    //}
                    FirtOrDefaultPenjaminByNocmAsyncService(this.NoRMIP.Text);
                    listPanel[++indexPanel].BringToFront();
                }
                else
                {
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

                            if (string.IsNullOrEmpty(NamaIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input nama pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                return;
                            }

                            if (string.IsNullOrEmpty(AlamatIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input alamat pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (KelaminIPLookUpEdit.EditValue == null)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis kelamin pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (PoliLookUpEdit.EditValue == null)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tujuan poliklinik" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if ((TglLahirIPDateEdit.EditValue == null) || (TglLahirIPDateEdit.Text == ""))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal lahir pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (((DateTime)TglLahirIPDateEdit.EditValue).Date > DateTime.Now.Date)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Tgl.Lahir tidak valid,\n Tgl.lahir yang diinput lebih besar dari tgl hari ini" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var jenistarif = FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId((PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                             (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)(-1));

                            switch (this.statepenjamin)
                            {
                                case Services.StatePenjamin.BPJS:
                                    if (string.IsNullOrEmpty(NoPesertaKartuBPJS.Text))
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


                                    if (Helper.Pelayananmedik.pelayananmedikid != 1)
                                    {
                                        if ((TujuanSrtRujukanBPJSLookUpEdit.EditValue == null) || (string.IsNullOrEmpty(TujuanSrtRujukanSEPBPJSLookUpEdit.Text)))
                                        {
                                            MetroFramework.MetroMessageBox.Show(this, "Tujuan Ruang Rawat Surat Rujukan tidak boleh kosong" + "\nbtnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            TujuanSrtRujukanBPJSLookUpEdit.Focus();
                                            return;
                                        }
                                    }

                                    if (string.IsNullOrEmpty(NosepSEPBPJS.Text))
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Nomor SEP BPJS tidak boleh kosong,\n Silahkan isi nomor SEP BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    if (TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue == null)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Silahkan tujuan SEP BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    ///
                                    break;
                            }

                            if (MetroFramework.MetroMessageBox.Show(this, "Apakah perubahan data registrasi pasien ini akan disimpan" +
                                "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                identitaspasien pasien = new identitaspasien()
                                {
                                    nocm = this.v_Registrasiruangrawat.nocm,
                                    sapaanid = (SapaanIPLookUpEdit.EditValue != null) ? (short)SapaanIPLookUpEdit.EditValue : (short)-1,
                                    nama = NamaIP.Text,
                                    tempatlahir = TempatLahirIP.Text,
                                    tanggallahir = (TglLahirIPDateEdit.EditValue != null) ? ((DateTime)TglLahirIPDateEdit.EditValue).Date : DateTime.Parse(null),
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
                                    negaraid = Helper.Negara.NegaraId(),
                                    identitaspasiensts = true
                                };

                                alamatpasien alamat = new alamatpasien()
                                {
                                    alamatpasienid = this.Alamatpasien.alamatpasienid,
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
                                    registrasiid = this.v_Registrasiruangrawat.registrasiid,
                                    nocm = NoRMIP.Text,
                                    noregistrasi = this.v_Registrasiruangrawat.noregistrasi,
                                    prosedurmasukid = Helper.Prosedurmasuk.ProsedurmasukId,
                                    tglmasuk = ((DateTime)tglMasukDateEdit.EditValue).Date,
                                    jammasuk = ((DateTime)tglMasukDateEdit.EditValue),
                                    penjaminpasienid = (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)(-1),
                                    stsmasukkeluarid = 1, //masuk
                                    loginappid = Helper.LoginAppDetail.loginappdetailid,//(short)(-1),
                                    registrasists = true,
                                    stspasienbaruid = Helper.Stspasienbaru.id
                                };

                                Helper.Stsregistrasi.stsregistrasiid = 1;

                                registrasiruangrawat regruangrawat = new registrasiruangrawat
                                {
                                    registrasiruangrawatid = this.v_Registrasiruangrawat.registrasiruangrawatid,
                                    registrasiid = reg.registrasiid,
                                    tglmasukruangan = reg.jammasuk,
                                    kelasid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kelasid,
                                    ruangrawatid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                                    kamarid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kamarid,
                                    tempattidurid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).tempattidurid,
                                    loginappid = Helper.LoginAppDetail.loginappdetailid,//(short)(-1),
                                    stsregistrasiid = Helper.Stsregistrasi.stsregistrasiid,
                                    registrasiruangrawatsts = true
                                };

                                v_pelayananpasienkarcis vpelayananpasienkarcis = new v_pelayananpasienkarcis
                                {
                                    pelayananpasienid = -1,
                                    pelayananpasientgl = reg.tglmasuk,
                                    pelayananpasienjam = reg.jammasuk,
                                    registrasiruangrawatid = (this.v_Registrasiruangrawat != null) ? this.v_Registrasiruangrawat.registrasiruangrawatid : (short)-1,
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
                                            nocm = NoRMIP.Text,
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
                                            suratrujukanpuskesmasid = (this.Suratrujukanpuskesmas != null) ? this.Suratrujukanpuskesmas.suratrujukanpuskesmasid : (short)-1,
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
                                            penjaminpasienbpjsid = (this.Penjaminpasienbpjs != null) ? this.Penjaminpasienbpjs.penjaminpasienbpjsid : (short)-1,
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
                                            nocm = NoRMIP.Text,
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
                                            suratrujukanpuskesmasid = (this.Suratrujukanpuskesmas != null) ? this.Suratrujukanpuskesmas.suratrujukanpuskesmasid : (short)-1,
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
                                            penjaminpasienbpjsid = (this.Penjaminpasienbpjs != null) ? this.Penjaminpasienbpjs.penjaminpasienbpjsid : (short)-1,
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


                                var result = (string.Empty, string.Empty);

                                switch (this.statepenjamin)
                                {
                                    case Services.StatePenjamin.DiriSendiri: //Diri Sendiri
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, pdirisendiri, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    case Services.StatePenjamin.Keluarga: //Keluarga
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, pkeluarga, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    case Services.StatePenjamin.BPJS:
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, ipasienbpjs, srtrujukanpuskesmas, pjpasienbpjs, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    default:
                                        result = AddRegistrasiPasienBaru(pasien, alamat, reg, regruangrawat, ipasienbpjs, srtrujukanpuskesmas, pjpasienbpjs, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                }


                                if (!string.IsNullOrEmpty(result.Item1))
                                {
                                    btnNext.Text = "Finish";

                                    isSave = true;

                                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                                    this.pnlContent.Controls.Clear();
                                    //fDashboard myForm = new fDashboard();
                                    FListRegistrasiRJ myForm = new FListRegistrasiRJ(ref this.pnlContent, this.indexSelectedRegistrasiRJ);
                                    myForm.TopLevel = false;
                                    myForm.AutoScroll = true;
                                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                                    this.pnlContent.Controls.Add(myForm);
                                    myForm.Dock = DockStyle.Fill;
                                    myForm.Show();



                                    //NoRMReg.Text = NoRMIP.Text;
                                    //NoregistrasiReg.Text = result.Item1;
                                    //NoRMIP.Text = NoRMReg.Text;
                                    //// NamaReg.Text = string.Format("{0}, {1}", SapaanIPLookUpEdit.Text, NamaIP.Text);
                                    ////KelaminReg.Text = KelaminIPLookUpEdit.Text;
                                    ////TglLahirReg.Text = TglLahirIPDateEdit.Text;
                                    ////TglRegReg.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                                    ////PoliklinikReg.Text = PoliLookUpEdit.Text;

                                    //NoRMReg.ReadOnly = true;
                                    //NoregistrasiReg.ReadOnly = true;

                                    //EnableControlBasedChosePenjamin(false);

                                    //listPanel[++indexPanel].BringToFront();
                                }
                                else
                                {
                                    isSave = false;
                                    MetroFramework.MetroMessageBox.Show(this, result.Item2 + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            //btnNext.Text = "Finish";
                            //if (indexPanel < (listPanel.Count - 1))
                            //    listPanel[++indexPanel].BringToFront();

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
            }
            catch (Exception ex)
            {
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\n  btnNext_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListRegistrasiRJ myForm = new FListRegistrasiRJ(ref this.pnlContent, this.indexSelectedRegistrasiRJ);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void penjaminLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (penjaminLookUpEdit.EditValue == null) return;
                if (string.IsNullOrEmpty(penjaminLookUpEdit.EditValue.ToString())) return;

                switch (int.Parse(penjaminLookUpEdit.EditValue.ToString()))
                {
                    case 1: //Diri Sendiri

                        this.statepenjamin = StatePenjamin.DiriSendiri;
                        CasePenjaminDiriSendiri();

                        break;
                    case 2: //Keluarga

                        this.statepenjamin = StatePenjamin.Keluarga;
                        CasePenjaminKeluarga();
                        break;
                    case 3: //BPJS

                        this.statepenjamin = StatePenjamin.BPJS;
                        CasePenjaminBPJS();
                        break;
                    default://BPJS

                        this.statepenjamin = StatePenjamin.BPJS;
                        CasePenjaminBPJS();
                        break;

                }

                if (this.v_Registrasiruangrawat != null)
                {
                    this.PoliLookUpEdit.EditValue = this.v_Registrasiruangrawat.ruangrawatid;
                    this.tglMasukDateEdit.EditValue = this.v_Registrasiruangrawat.jammasuk;
                    this.tglMasukDateEdit.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npenjaminLookUpEdit_EditValueChanged()" + this.Name + "\n penjaminLookUpEdit_EditValueChanged ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
