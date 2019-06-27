using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.Registrasi;

using SIMRS.DESKTOP.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class TFAddEditRegistrasiPasien : MetroFramework.Forms.MetroForm
    {

        protected List<Panel> listPanel = new List<Panel>();

        protected int indexPanel;

        protected IEnumerable<icdxsubkategori> listIcdxsubkategori;
        protected IList<v_statuspenyakit> v_Statuspenyakits = null;
        protected v_registrasiruangrawat v_Registrasiruangrawat;

        protected bool showicdxsubkategorigridcontrol = false;

        protected int pageIndex = 1;
        protected int pageSize = 2;

        private const int maxPageSize = 100;
        public int? PageNumber { get; set; }

        private int totalPage = 0;
        private int _pageSize = 50;
        protected int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < maxPageSize) ? value : maxPageSize;
            }
        }


        protected int rowindexIcdxsubkategori = 0;


        protected short shortkelasruangrawatid, shortkelasid, shortkamarid, shorttempattidurid;

        protected bool isSave = false;

        protected Panel pnlContent;

        protected StatePenjamin statepenjamin;

        protected icdxsubkategori selectedIcdxsubkategori;

        public TFAddEditRegistrasiPasien()
        {
            InitializeComponent();

            
            DefaultControl();
            defaultpanelregistrasi();
            defaultsetinglookupeditpanelrujukanBPJS();
            defaultsetinglookupeditpanelkartuBPJS();
            defaultsetinglookupeditpanelidentitaspasien();
            defaultsetinglookupeditpaneldirisendiri();
            defautsetinglookupeditpanelkeluarga();
            defaultsetinglookupeditpanelpoli();

            #region panel penjamin
            LoadDataPenjamin();
            //LoadDataPenjaminAsync();
            //penjaminLookUpEdit.ItemIndex = 0;
            //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

            #endregion

            #region stsregistrasi
            Helper.Stsregistrasi.stsregistrasiid = 1;
            Helper.Stsregistrasi.stsregistrasinm = "Daftar";
            Helper.Stsregistrasi.stsregistrasists = true;
            #endregion
        }

        public TFAddEditRegistrasiPasien(ref Panel _pnlContent)
        {
            InitializeComponent();

            this.pnlContent = _pnlContent;

            DefaultControl();
            defaultpanelregistrasi();
            defaultsetinglookupeditpanelrujukanBPJS();
            defaultsetinglookupeditpanelkartuBPJS();
            defaultsetinglookupeditpanelidentitaspasien();
            defaultsetinglookupeditpaneldirisendiri();
            defautsetinglookupeditpanelkeluarga();
            defaultsetinglookupeditpanelpoli();

            #region panel penjamin
            LoadDataPenjamin();
            //LoadDataPenjaminAsync();
            //penjaminLookUpEdit.ItemIndex = 0;
            //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

            #endregion

            #region stsregistrasi
            Helper.Stsregistrasi.stsregistrasiid = 1;
            Helper.Stsregistrasi.stsregistrasinm = "Daftar";
            Helper.Stsregistrasi.stsregistrasists = true;
            #endregion

        }

        #region private control method



        protected void DefaultControl()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref penjaminLookUpEdit,
               new string[] { "penjaminpasienid", "penjaminpasiennm" },
               new string[] { "Kode", "Jenis Penjamin" },
               new bool[] { false, true },
               "penjaminpasiennm", "penjaminpasienid", "Pilih jenis penjamin");

            Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref pnlRegistrasi, false);

        }


        #region default Registrasi
        private void defaultpanelregistrasi()
        {
            CommonFuncControl.ClearControlInWindowsFormPanel(ref this.pnlRegistrasi);
        }
        #endregion

        #region default SEP BPJS
        protected void defaultpanelSEPBPJS()
        {
            CommonFuncControl.ClearControlInWindowsFormPanel(ref this.pnlSEPBPJS);

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref TujuanSrtRujukanSEPBPJSLookUpEdit,
               new string[] { "ruangrawatid", "ruangrawatnm" },
               new string[] { "kode", "Ruang Perawatan" },
               new bool[] { false, true },
               "ruangrawatnm", "ruangrawatid", "Pilih tujuan rujukan");
        }
        #endregion

        #region default surat rujukan BPJS
        private void defaultsetinglookupeditpanelrujukanBPJS()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref AsalRujukanSrtRujukanBPJSLookUpEdit,
               new string[] { "perujukid", "perujuknm" },
               new string[] { "Kode", "Nama" },
               new bool[] { true, true },
               "perujuknm", "perujukid", "Pilih sumber rujukan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref PuskesmasSrtRujukanBPJSLookUpEdit,
                new string[] { "puskesmasid", "puskesmasnm", "puskesmasno", "faskesno" },
                new string[] { "kode", "Nama Puskesmas", "No. Puskesmas", "No. Faskes" },
                new bool[] { false, true, true, true },
                "puskesmasnm", "puskesmasid", "Pilih puskesmas");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref TujuanSrtRujukanBPJSLookUpEdit,
                new string[] { "ruangrawatid", "ruangrawatnm" },
                new string[] { "kode", "Ruang Perawatan" },
                new bool[] { false, true },
                "ruangrawatnm", "ruangrawatid", "Pilih tujuan rujukan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref DiagnosaAlternatifSrtRujukanBPJSLookUpEdit,
                new string[] { "icdxpuskesmaskodenama", "icdxpuskesmasid", "icdxpuskesmaskode", "icdxpuskesmasnama" },
                new string[] { "Kodenama", "Id", "Kode", "Nama" },
                new bool[] { false, false, true, true },
                "icdxpuskesmasnama", "icdxpuskesmasid", "Pilih diagnosa puskesmas");
        }
        protected void defaultpanelrujukanBPJS()
        {

            CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlSuratRujukanBPJS);
            var arrLookupEdit = new DevExpress.XtraEditors.LookUpEdit[] { PuskesmasSrtRujukanBPJSLookUpEdit };
            CommonFuncControl.ClearDataSourceLookUpEdit(ref arrLookupEdit);
            arrLookupEdit = null;

            ////AsalRujukanSrtRujukanBPJSLookUpEdit.Properties.DataSource = null;
            ////PuskesmasSrtRujukanBPJSLookUpEdit.Properties.DataSource = null;
            ////TujuanSrtRujukanBPJSLookUpEdit.Properties.DataSource = null;
            ////DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.Properties.DataSource = null;

            ////NoPuskesmasSrtRujukanBPJS.Text = string.Empty;
            ////NmPuskesmasSrtRujukanBPJS.Text = string.Empty;
            ////FaskesNoSrtRujukanBPJS.Text = string.Empty;
            ////TglRujukanSrtRujukanBPJSDateEdit.EditValue = DateTime.Now.Date;
            ////NoRujukanSrtRujukanBPJS.Text = string.Empty; 
            ////DiagnosaAwalSrtRujukanBPJS.Text = string.Empty; 
            ////NamaDiagnosaAwalSrtRujukanBPJS.Text = string.Empty;
            ////TelahDibreikanSrtRujukanBPJS.Text = string.Empty;

            checkINA.Checked = true;
            checkTdkAktif.Checked = false;
            icdxindoGridControl.Visible = false;
            icdxengGridControl.Visible = false;
            icdxindoDataNavigator.Visible = false;
        }
        #endregion

        #region default panel kartu BPJS
        private void defaultsetinglookupeditpanelkartuBPJS()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref JKKartuBPJSLookUpEdit,
               new string[] { "jkid", "jknm" },
               new string[] { "Kode", "Kelamin" },
               new bool[] { false, true },
               "jknm", "jkid", "Pilih jenis kelamin");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KelasKartuBPJSLookUpEdit,
               new string[] { "kelasid", "kelasuraian" },
               new string[] { "Kode", "Kelas" },
               new bool[] { false, true },
               "kelasuraian", "kelasid", "Pilih kelas");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KecKartuBPJSlookUpEdit,
               new string[] { "kecid", "kecnm" },
               new string[] { "Kode", "Kecamatan" },
               new bool[] { false, true },
               "kecnm", "kecid", "Pilih kecamatan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KelKartuBPJSLookUpEdit,
               new string[] { "keldesaid", "keldesanm" },
               new string[] { "Kode", "Kelurahan/Desa" },
               new bool[] { false, true },
               "keldesanm", "keldesaid", "Pilih kelurahan / desa");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref RTRWKartuBPJSLookUpEdit,
               new string[] { "rwid", "rtid", "rtrw" },
               new string[] { "Kode RW", "Kode TR", "RT/RW" },
               new bool[] { false, false, true },
               "rtrw", "rtid", "Pilih RT / RW");
        }
        protected void defaultpanelkartuBPJS()
        {
            CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlKartuBPJS);
            var arrLookUpEdit = new LookUpEdit[] { KelKartuBPJSLookUpEdit, RTRWKartuBPJSLookUpEdit };
            CommonFuncControl.ClearDataSourceLookUpEdit(ref arrLookUpEdit);
            arrLookUpEdit = null;
        }
        #endregion

        #region default panel identitaspasien

        private void defaultsetinglookupeditpanelidentitaspasien()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref SapaanIPLookUpEdit,
             new string[] { "sapaanid", "sapaannm" },
             new string[] { "Kode", "Sapaan" },
             new bool[] { false, true },
             "sapaannm", "sapaanid", "Pilih sapaan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref GolDarahIPLookUpEdit,
             new string[] { "goldarahid", "goldarahnm" },
             new string[] { "Kode", "Gol.Darah" },
             new bool[] { false, true },
             "goldarahnm", "goldarahid", "Pilih gol. darah");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref StsNikahIPLookUpEdit,
             new string[] { "stspernikahanid", "stspernikahannm" },
             new string[] { "Kode", "Sts. Nikah" },
             new bool[] { false, true },
             "stspernikahannm", "stspernikahanid", "Pilih sts. pernikahan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref PendidikanIPLookUpEdit,
             new string[] { "pendidikanid", "pendidikannm" },
             new string[] { "Kode", "Pendidikan" },
             new bool[] { false, true },
             "pendidikannm", "pendidikanid", "Pilih pendidikan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref PekerjaanIPLookUpEdit,
             new string[] { "pekerjaanid", "pekerjaannm" },
             new string[] { "Kode", "Pekerjaan" },
             new bool[] { false, true },
             "pekerjaannm", "pekerjaanid", "Pilih pekerjaan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref AgamaIPLookUpEdit,
             new string[] { "agamaid", "agamanm" },
             new string[] { "Kode", "Agama" },
             new bool[] { false, true },
             "agamanm", "agamaid", "Pilih agama");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref SukuIPLookUpEdit,
                 new string[] { "sukuid", "sukunm" },
                 new string[] { "Kode", "Suku" },
                 new bool[] { false, true },
                 "sukunm", "sukuid", "Pilih suku");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KecIPLookUpEdit,
              new string[] { "kecid", "kecnm" },
              new string[] { "Kode", "Kecamatan" },
              new bool[] { false, true },
              "kecnm", "kecid", "Pilih kecamatan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KelIPLookUpEdit,
               new string[] { "keldesaid", "keldesanm" },
               new string[] { "Kode", "Kelurahan/Desa" },
               new bool[] { false, true },
               "keldesanm", "keldesaid", "Pilih kelurahan / desa");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref RTRWIPLookUpEdit,
               new string[] { "rwid", "rtid", "rtrw" },
               new string[] { "Kode RW", "Kode RT", "RT/RW" },
               new bool[] { false, false, true },
               "rtrw", "rtid", "Pilih RT / RW");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KelaminIPLookUpEdit,
               new string[] { "jkid", "jknm" },
               new string[] { "Kode", "Kelamin" },
               new bool[] { false, true },
               "jknm", "jkid", "Pilih jenis kelamin");
        }

        protected void defaultpanelidentitaspasien()
        {
            CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
            if (TglLahirIPDateEdit.EditValue != null)
            {
                var date = CommonFunc.HitungUmur((short)((DateTime)TglLahirIPDateEdit.EditValue).Year,
                    (short)((DateTime)TglLahirIPDateEdit.EditValue).Month,
                    (short)((DateTime)TglLahirIPDateEdit.EditValue).Day);
                ThnIP.Text = date.Item1.ToString(); BlnIP.Text = date.Item2.ToString(); HariIP.Text = date.Item3.ToString();
            }
            var arrLookUpEdit = new LookUpEdit[] { KelaminIPLookUpEdit, RTRWIPLookUpEdit};
            CommonFuncControl.ClearDataSourceLookUpEdit(ref arrLookUpEdit);
            arrLookUpEdit = null;

        }

        #endregion

        #region default panel dirisendiri

        private void defaultsetinglookupeditpaneldirisendiri()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref IdentitasdiriPenjaminDiriSendiriLookUpEdit,
              new string[] { "identitasdiriid", "identitasdirinm" },
              new string[] { "Kode", "Identitas Diri" },
              new bool[] { false, true },
              "identitasdirinm", "identitasdiriid", "Pilih identitas diri");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KecDiriSendiriLookUpEdit,
               new string[] { "kecid", "kecnm" },
               new string[] { "Kode", "Kecamatan" },
               new bool[] { false, true },
               "kecnm", "kecid", "Pilih kecamatan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KelDiriSendiriLookUpEdit,
               new string[] { "keldesaid", "keldesanm" },
               new string[] { "Kode", "Kelurahan/Desa" },
               new bool[] { false, true }, 
               "keldesanm", "keldesaid", "Pilih kelurahan / desa");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref RTRWDiriSendiriLookUpEdit,
               new string[] { "rwid", "rtid", "rtrw" },
               new string[] { "Kode RW", "Kode TR", "RT/RW" },
               new bool[] { false, false, true },
               "rtrw", "rtid", "Pilih RT / RW");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KelaminDiriSendiriLookUpEdit,
               new string[] { "jkid", "jknm" },
               new string[] { "Kode", "Kelamin" },
               new bool[] { false, true },
               "jknm", "jkid", "Pilih jenis kelamin");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref PekerjaanDiriSendiriLookUpEdit,
              new string[] { "pekerjaanid", "pekerjaannm" },
              new string[] { "Kode", "Pekerjaan" },
              new bool[] { false, true },
              "pekerjaannm", "pekerjaanid", "Pilih pekerjaan");
        }

        protected void defaultpaneldirisendiri()
        {
            CommonFuncControl.ClearControlInWindowsFormPanel(ref this.pnlDiriSendiri);
            TglPenjaminDiriSendiriDateEdit.EditValue = DateTime.Now.Date;
            TglLahirDiriSendiriDateEdit.EditValue = DateTime.Now.Date;
        }

        #endregion

        #region default panel keluarga

        private void defautsetinglookupeditpanelkeluarga()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref HubPenjaminKLookUpEdit,
               new string[] { "hubkeluargaid", "hubkeluarganm" },
               new string[] { "Kode", "Hubungan Keluarga" },
               new bool[] { false, true },
               "hubkeluarganm", "hubkeluargaid", "Pilih status hubungan keluarga");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref IdentitasdiriPenjaminKLookUpEdit,
              new string[] { "identitasdiriid", "identitasdirinm" },
              new string[] { "Kode", "Identitas Diri" },
              new bool[] { false, true },
              "identitasdirinm", "identitasdiriid", "Pilih identitas diri");


            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KecPenjaminKLookUpEdit,
               new string[] { "kecid", "kecnm" },
               new string[] { "Kode", "Kecamatan" },
               new bool[] { false, true },
               "kecnm", "kecid", "Pilih kecamatan");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref KeldesaPenjaminKLookUpEdit,
               new string[] { "keldesaid", "keldesanm" },
               new string[] { "Kode", "Kelurahan/Desa" },
               new bool[] { false, true },
               "keldesanm", "keldesaid", "Pilih kelurahan / desa");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref RTRWPenjaminKLookUpEdit,
               new string[] { "rwid", "rtid", "rtrw" },
               new string[] { "Kode RW", "Kode TR", "RT/RW" },
               new bool[] { false, false, true },
               "rtrw", "rtid", "Pilih RT / RW");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref JKPenjaminKlookUpEdit,
               new string[] { "jkid", "jknm" },
               new string[] { "Kode", "Kelamin" },
               new bool[] { false, true },
               "jknm", "jkid", "Pilih jenis kelamin");

        }
        protected void defautpanelkeluarga()
        {
            HubPenjaminKLookUpEdit.EditValue = null;
            IdentitasdiriPenjaminKLookUpEdit.EditValue = null;
            KecPenjaminKLookUpEdit.EditValue = null;
            KeldesaPenjaminKLookUpEdit.EditValue = null;
            RTRWPenjaminKLookUpEdit.EditValue = null;
            JKPenjaminKlookUpEdit.EditValue = null;
            TglPenjaminKDateEdit.EditValue = DateTime.Now.Date;
            NoIdentitasPenjaminK.Text = string.Empty;
            NamaPenjaminK.Text = string.Empty;
            AlamatPenjaminK.Text = string.Empty;
            NoTelpPenjaminK.Text = string.Empty;
            NoHPPenjaminK.Text = string.Empty;
            
        }
        #endregion

        #region defaut panel poli

        private void defaultsetinglookupeditpanelpoli()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref PoliLookUpEdit,
                   new string[] { "ruangrawatid", "ruangrawatnm", "pelayananmedikid", "kelasruangrawatid", "kelasid", "kamarid", "tempattidurid" },
                   new string[] { "Kode", "Poliklinik", "pelayananmedikid", "kelasruangrawatid", "kelasid", "kamarid", "tempattidurid" },
                   new bool[] { true, true, false, false, false, false, false },
                   "ruangrawatnm", "ruangrawatid", "Pilih poliklinik");

        }
        protected void defaultpanelpoli()
        {
            PoliLookUpEdit.EditValue = null;
            KodePoli.Text = string.Empty;
            NamaPoli.Text = string.Empty;
        }

        #endregion

        protected void EnableControlBasedChosePenjamin(bool value)
        {
            try
            {
                Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlPenjamin, value);
                Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlIdentitasPasien, value);
                Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlPoli, value);
                switch (penjaminLookUpEdit.EditValue)
                {

                    case 1://Diri Sendiri

                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlDiriSendiri, value);

                        break;
                    case 2://Keluarga
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlKeluarga, value);

                        break;
                    case 3://BPJS
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlKartuBPJS, value);
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlSuratRujukanBPJS, value);
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlSEPBPJS, value);

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nEnableControlBasedChosePenjamin()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControlBasedChosePenjamin()
        {
            try
            {
                
                switch (penjaminLookUpEdit.EditValue)
                {

                    case 1://Diri Sendiri

                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDiriSendiri);

                        break;
                    case 2://Keluarga
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlKeluarga);

                        break;
                    case 3://BPJS
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlKartuBPJS);
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlSuratRujukanBPJS);
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlSEPBPJS);

                        break;
                    default:
                        break;
                }
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlPenjamin);
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlPoli);
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlRegistrasi);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nClearControlBasedChosePenjamin()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion

        #region private method


        protected void Loadv_statuspenyakitByNormAsync(string norm)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = service.SelectAllv_statuspenyakitByNormAsync(norm);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.v_Statuspenyakits = result.Item1.ToList();
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected jenistarif FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId(short ruangrawatid, short penjaminid)
        {
            using (var service = new RegistrasiPasienBaruServices())
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

        protected (string, bool) AddPasienBaru(identitaspasien pasien)
        {
            using (var service = new RegistrasiPasienBaruServices())
            {
                var result = service.InsertPasienBaru(pasien);
                if (result.Item2 != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, false);
                }
                else
                {
                    return (result.Item1, true);
                }

            }
        }

        protected (short,string, bool) AddRegistrasiBaru(registrasi _registrasi)
        {
            using (var service = new RegistrasiPasienServices())
            {
                var result = service.InsertRegistrasi(_registrasi);
                if (result.Item3 != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ((short)-1, string.Empty, false);
                }
                else
                    return (result.Item1, result.Item2, true);

            }
        }

        protected int AddRegistrasiRuangrawat(registrasiruangrawat _registrasiruangrawat)
        {
            using (var service = new RegistrasiPasienServices())
            {
                var result = service.InsertRegistrasiRuangRawat(_registrasiruangrawat);
                if (result != 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Penyimpanan registrasi ruangrawat gagal ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                    return 0;

            }
        }

        protected (string,string) AddRegistrasiPasienBaru(identitaspasien _identitaspasien, 
            alamatpasien _alamatpasien,
            registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasiendirisendiri _penjaminpasiendirisendiri, 
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statePenjamin
            )
        {
            using (var service = new RegistrasiPasienBaruServices())
            {
                var result = service.InsertPasienBaru(_identitaspasien, _alamatpasien, _registrasi, _registrasiruangrawat,
                        _penjaminpasiendirisendiri, _vpelayananpasienkarcis, _statePenjamin);
                if (!string.IsNullOrEmpty(result.Item3))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item3);
                }
                else
                    return (result.Item1, result.Item2);

            }
        }

        protected (string, string) AddRegistrasiPasienBaru(identitaspasien _identitaspasien,
            alamatpasien _alamatpasien,
            registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasienkeluarga _penjaminpasienkeluarga,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statePenjamin
            )
        {
            using (var service = new RegistrasiPasienBaruServices())
            {
                var result = service.InsertPasienBaru(_identitaspasien, _alamatpasien, _registrasi, _registrasiruangrawat,
                        _penjaminpasienkeluarga, _vpelayananpasienkarcis, _statePenjamin);
                if (!string.IsNullOrEmpty(result.Item3))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item3);
                }
                else
                    return (result.Item1, result.Item2);

            }
        }

        protected (string, string) AddRegistrasiPasienBaru(identitaspasien _identitaspasien,
            alamatpasien _alamatpasien,
            registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            identitaspasienbpjs _identitaspasienbpjs,
            suratrujukanpuskesmas _suratrujukanpuskesmas,
            penjaminpasienbpjs _penjaminpasienbpjs,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statePenjamin
            )
        {
            using (var service = new RegistrasiPasienBaruServices())
            {
                var result = service.InsertPasienBaru(_identitaspasien, _alamatpasien, _registrasi, _registrasiruangrawat,
                        _identitaspasienbpjs, _suratrujukanpuskesmas,  _penjaminpasienbpjs, _vpelayananpasienkarcis, _statePenjamin);
                if (!string.IsNullOrEmpty(result.Item3))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item3);
                }
                else
                    return (result.Item1, result.Item2);

            }
        }

        ////protected async void LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiriAsync(short? kotakabid)
        ////{
        ////    using (var service = new RegistrasiPasienServices())
        ////    {
        ////        var result = await service.SelectIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(kotakabid);
        ////        if (result.Item5!=null)
        ////        {
        ////            MetroFramework.MetroMessageBox.Show(this, result.Item5, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////            return;
        ////        }
        ////        else
        ////        {
        ////            IdentitasdiriPenjaminDiriSendiriLookUpEdit.Properties.DataSource = result.Item1;
        ////            KelaminDiriSendiriLookUpEdit.Properties.DataSource = result.Item2;
        ////            KecDiriSendiriLookUpEdit.Properties.DataSource = result.Item3;
        ////            PekerjaanDiriSendiriLookUpEdit.Properties.DataSource = result.Item4;

        ////        }
        ////    }
        ////}

        protected void LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(short? kotakabid)
        {
            using (var service = new RegistrasiPasienServices())
            {
                var result = service.SelectIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(kotakabid);
                if (result.Item5 != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, result.Item5, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    IdentitasdiriPenjaminDiriSendiriLookUpEdit.Properties.DataSource = result.Item1;
                    KelaminDiriSendiriLookUpEdit.Properties.DataSource = result.Item2;
                    KecDiriSendiriLookUpEdit.Properties.DataSource = result.Item3;
                    PekerjaanDiriSendiriLookUpEdit.Properties.DataSource = result.Item4;

                }
            }
        }


        private async void LoadDataPenjaminAsync()
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectAllPenjaminAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        penjaminLookUpEdit.Properties.DataSource = result.Item1;
                    }
                    result = (null,"");
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataPenjamin()
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    penjaminLookUpEdit.Properties.DataSource = service.SelectAllPenjamin();
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(short? kotakabid, short? pelayananmedikid)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(kotakabid, pelayananmedikid);
                    if (result.Item11 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item11, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        KelaminIPLookUpEdit.Properties.DataSource = result.Item1;
                        GolDarahIPLookUpEdit.Properties.DataSource = result.Item2;
                        KecIPLookUpEdit.Properties.DataSource = result.Item3;
                        StsNikahIPLookUpEdit.Properties.DataSource = result.Item4;
                        PendidikanIPLookUpEdit.Properties.DataSource = result.Item5;
                        PekerjaanIPLookUpEdit.Properties.DataSource = result.Item6;
                        AgamaIPLookUpEdit.Properties.DataSource = result.Item7;
                        SukuIPLookUpEdit.Properties.DataSource = result.Item8;
                        SapaanIPLookUpEdit.Properties.DataSource = result.Item9;
                        PoliLookUpEdit.Properties.DataSource = result.Item10;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected async void GetDataKeldesaByKecIdAsync(short? kecid, LookUpEdit destLookUpEdit)
        {
            try
            {
                using (var service = new RegistrasiPasienBaruServices())
                {
                    var result = await service.SelectKeldesaByKecIdAsync(kecid.Value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        destLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void GetDataRTRWByKeldesaIdAsync(short? keldesaid, LookUpEdit destLookUpEdit)
        {
            try
            {
                using (var service = new RegistrasiPasienBaruServices())
                {

                    var result = await service.SelectRTRWByKeldesaidAsync(keldesaid.Value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        destLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region kartu BPJS

        protected async void LoadDataKelasAndJKAndKecByKotaKabIdKartuBPJSAsync(short? kotakabid)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectKelasBPJSAndJKAndKecKartuBPJSAsync(kotakabid);
                    if (result.Item4 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item4, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        KelasKartuBPJSLookUpEdit.Properties.DataSource = result.Item1;
                        JKKartuBPJSLookUpEdit.Properties.DataSource = result.Item2;
                        KecKartuBPJSlookUpEdit.Properties.DataSource = result.Item3;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


       #endregion

        #region Surat Rujukan BPJS

        protected void LoadDataAsalRujukan()
        {
            try
            {
                using (var service = new RegistrasiPasienBaruServices())
                {
                    AsalRujukanSrtRujukanBPJSLookUpEdit.Properties.DataSource = service.SelectPerujuk();
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void LoadDataPuskesmasByPerujukIdAsync(short? perujukid)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {

                    var result = await service.SelectPuskesmasByPerujukIdAsync(perujukid.Value);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        PuskesmasSrtRujukanBPJSLookUpEdit.Properties.DataSource = result.Item1;

                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadRuangrawatrujukanAsync()
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {

                    var result = service.SelectRuangrawatrujukan();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //TujuanSrtRujukanBPJSLookUpEdit.Properties.DataSource = result.Item1;
                        TujuanSrtRujukanSEPBPJSLookUpEdit.Properties.DataSource = result.Item1;

                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////protected async void LoadDataICDXEngByICDXNameAsync(string icdxname)
        ////{
        ////    try
        ////    {
        ////        using (var service = new RegistrasiPasienServices())
        ////        {

        ////            var result = await service.SelectIcdxsubkategoriEngByIcdxnameAsync(icdxname);
        ////            if (result.Item2 != null)
        ////            {
        ////                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////                return;
        ////            }
        ////            else
        ////            {
        ////                icdxengGridControl.DataSource = result.Item1;

        ////                //DiagnosaAwalSEPBPJSLookUpEdit.Properties.DataSource = result.Item1;

        ////            }
        ////        }
        ////    }

        ////    catch (Exception ex)
        ////    {
        ////        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}

        ////protected async void LoadDataICDXIndoByICDXNameAsync(string icdxname)
        ////{
        ////    try
        ////    {
        ////        using (var service = new RegistrasiPasienServices())
        ////        {
        ////            var result = await service.SelectIcdxsubkategoriIndoByIcdxnameAsync(icdxname);
        ////            if (result.Item2 != null)
        ////            {
        ////                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////                return;
        ////            }
        ////            else
        ////            {
        ////                icdxindoGridControl.DataSource = result.Item1;
        ////                icdxindoDataNavigator.DataSource = icdxindoGridControl.DataSource;

        ////                //DiagnosaAwalSEPBPJSLookUpEdit.Properties.DataSource = result.Item1;
        ////            }
        ////        }
        ////    }

        ////    catch (Exception ex)
        ////    {
        ////        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}

        ////protected async void LoadDataICDXIndoByIndexPageAndICDXNameAsync(int pageindex, int pagesize, string icdxname)
        ////{
        ////    try
        ////    {

        ////        using (var service = new RegistrasiPasienServices())
        ////        {
        ////            var result = await service.SelectIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(pageindex, pagesize, icdxname);
        ////            if (result.Item2 != null)
        ////            {
        ////                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////                return;
        ////            }
        ////            else
        ////            {
        ////                icdxindoGridControl.DataSource = result.Item1;
        ////                icdxindoDataNavigator.DataSource = icdxindoGridControl.DataSource;
        ////            }
        ////        }
        ////    }

        ////    catch (Exception ex)
        ////    {
        ////        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}

        ////protected void LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(int pageindex, int pagesize, string icdxname)
        ////{
        ////    try
        ////    {
        ////        using (var service = new RegistrasiPasienServices())
        ////        {
        ////            var result = service.SelectMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(pageindex, pagesize, icdxname);
        ////            if (result.Item3 != null)
        ////            {
        ////                MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////                return;
        ////            }
        ////            else
        ////            {
        ////                icdxindoGridControl.DataSource = result.Item1;
        ////                icdxindoDataNavigator.DataSource = icdxindoGridControl.DataSource;
        ////                this.totalPage = (int)Math.Ceiling(result.Item2 / (double)PageSize);
        ////                //MessageBox.Show(this.totalPage.ToString());
        ////            }
        ////        }
        ////    }

        ////    catch (Exception ex)
        ////    {
        ////        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}

        protected async void LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageindex, int pagesize, string icdxname)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(pageindex, pagesize, icdxname);
                    if (result.Item3 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        icdxindoGridControl.DataSource = result.Item1;
                        icdxindoGridControl.BringToFront();
                        icdxindoDataNavigator.DataSource = icdxindoGridControl.DataSource;
                        icdxindoDataNavigator.BringToFront();
                        this.totalPage = (int)Math.Ceiling(result.Item2 / (double)PageSize);
                        //MessageBox.Show(this.totalPage.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected async void LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageindex, int pagesize, string icdxname)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(pageindex, pagesize, icdxname);
                    if (result.Item3 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        icdxengGridControl.DataSource = result.Item1;
                        icdxengGridControl.BringToFront();
                        icdxindoDataNavigator.DataSource = icdxengGridControl.DataSource;
                        icdxindoDataNavigator.BringToFront();
                        this.totalPage = (int)Math.Ceiling(result.Item2 / (double)PageSize);
                        //MessageBox.Show(this.totalPage.ToString());
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected async void LoadMultiPuskesmasByPerujukIdAndRuangRawatRujukanAndVicdxpuskesmasAsync(short? puskesmasperujukid)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectPuskesmasByPerujukIdAndGetAllRuangRawatRujukanAndVicdxpuskesmasAsync(puskesmasperujukid);
                    if (result.Item4 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item4, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        PuskesmasSrtRujukanBPJSLookUpEdit.Properties.DataSource = result.Item1;
                        TujuanSrtRujukanBPJSLookUpEdit.Properties.DataSource = result.Item2;
                        //TujuanSrtRujukanSEPBPJSLookUpEdit.Properties.DataSource = result.Item2;
                        DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.Properties.DataSource = result.Item3;
                        DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.BringToFront();
                        //MessageBox.Show(this.totalPage.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected async Task< pelayananmedik> LoadDataPelayananmedikByRujukanruangrawatId(short rujukanruangrawatId)
        {

            pelayananmedik p = null;
            
                try
                {
                    using (var service = new RegistrasiPasienBaruServices())
                    {

                        var result = await service.SelectPelayananmedikByRuangrawatrujukanIdAsync(rujukanruangrawatId);
                        if (result.Item2 != null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            p = null;
                        }
                        else
                        {
                            p = result.Item1;
                        }
                    }
                }

                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            return p;
        }

        #endregion

        #region Penjamin Keluarga Pasien

        protected async void LoadDataHubKeluargaAndIdentitasdiriAndJKAndKecByKotaKabIdKeluargaPasienAsync(short? kotakabid)
            {
                try
                {
                    using (var service = new RegistrasiPasienServices())
                    {
                        var result = await service.SelectHubkeluargaAndIdentitasdiriAndJKAndKecByKotakabIdKeluargaPasienAsync(kotakabid);
                        if (result.Item5 != null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, result.Item5, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            HubPenjaminKLookUpEdit.Properties.DataSource = result.Item1;
                            IdentitasdiriPenjaminKLookUpEdit.Properties.DataSource = result.Item2;
                            JKPenjaminKlookUpEdit.Properties.DataSource = result.Item3;
                            KecPenjaminKLookUpEdit.Properties.DataSource = result.Item4;
                        }
                    }
                }

                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        #endregion

        #region penjamin diri sendiri

        protected void LoadDataIdentitasdiriPenjaminDiriSendiri()
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {

                    var result = service.SelectIdentitasdiri();
                    if (result == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data identitas diri tidak ditemukan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        IdentitasdiriPenjaminDiriSendiriLookUpEdit.Properties.DataSource = result as IEnumerable<identitasdiri> ;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion


        protected virtual void FAddEditRegistrasiPasien_Load(object sender, EventArgs e)
        {



        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                //Bring back panel to front
                if (indexPanel > 0)
                {
                    if (--indexPanel < 0)
                    {
                        indexPanel = 0;
                    }
                    else
                    {
                        ++indexPanel;
                    }
                    listPanel[--indexPanel].BringToFront();
                }
                if (btnNext.Text == "Finish") btnNext.Text = "Next";
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnPrev_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            indexPanel = 0;
            if (btnNext.Text == "Finish") btnNext.Text = "Next";
            listPanel[indexPanel].BringToFront();
        }

        protected virtual void btnLast_Click(object sender, EventArgs e)
        {
            indexPanel = listPanel.Count - 1;
            listPanel[indexPanel].BringToFront();
        }

        private void checkINA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkINA.Checked == true)
            {
                checkINA.Text = "INA";
                //icdxindoGridControl.Visible = true;
                //icdxengGridControl.Visible = false;
            }
            else
            {
                checkINA.Text = "ENG";
                //icdxindoGridControl.Visible = false;
                //icdxengGridControl.Visible = true;
            }

        }

        private void checkTdkAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTdkAktif.Checked == true)
            {
                DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.Enabled = true;
                DiagnosaAwalSrtRujukanBPJS.Enabled = false;
                checkINA.Enabled = false;
            }
            else
            {

                DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.Enabled = false;
                DiagnosaAwalSrtRujukanBPJS.Enabled = true;
                checkINA.Enabled = true;
            }

        }

        private void lookUpEditPuskesmas_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                var data = PuskesmasSrtRujukanBPJSLookUpEdit.GetSelectedDataRow() as puskesmas;
                if (data != null)
                {
                    NmPuskesmasSrtRujukanBPJS.Text = data.puskesmasnm;
                    NoPuskesmasSrtRujukanBPJS.Text = data.puskesmasno;
                    FaskesNoSrtRujukanBPJS.Text = data.faskesno;

                    AsalFaskesSEPBPJS.Text = NmPuskesmasSrtRujukanBPJS.Text;

                    TglRujukanSrtRujukanBPJSDateEdit.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nlookUpEditPuskesmas_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void KecKartuBPJSlookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (KecKartuBPJSlookUpEdit.EditValue != null)
                {

                    KecIPLookUpEdit.EditValue = KecKartuBPJSlookUpEdit.EditValue;

                    GetDataKeldesaByKecIdAsync(KecKartuBPJSlookUpEdit.EditValue != null ? short.Parse(KecKartuBPJSlookUpEdit.EditValue.ToString()) : short.Parse(null), KelKartuBPJSLookUpEdit);


                    KelKartuBPJSLookUpEdit.Focus();
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void KelKartuBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (KelKartuBPJSLookUpEdit == null) return;
            
            try
            {
                KelIPLookUpEdit.EditValue = KelKartuBPJSLookUpEdit.EditValue;

                GetDataRTRWByKeldesaIdAsync(KelKartuBPJSLookUpEdit.EditValue != null ? short.Parse(KelKartuBPJSLookUpEdit.EditValue.ToString()) : short.Parse(null), RTRWKartuBPJSLookUpEdit);
                RTRWKartuBPJSLookUpEdit.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AsalRujukanSrtRujukanBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue != null)
            {
                LoadDataPuskesmasByPerujukIdAsync((short)AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue);
                lblNamaPerujuk.Text = AsalRujukanSrtRujukanBPJSLookUpEdit.Text;
            }
            else
            {
                lblNamaPerujuk.Text = "Puskesmas";
            }
            PuskesmasSrtRujukanBPJSLookUpEdit.Focus();
        }

        private void DiagnosaAwalSrtRujukanBPJS_Click(object sender, EventArgs e)
        {
            if (!showicdxsubkategorigridcontrol)
            {
                showicdxsubkategorigridcontrol = true;
                DiagnosaAwalSrtRujukanBPJS_TextChanged(null, null);
                //VisibleIcdxSubkategoriGridControl();
            }
            else
            {
                showicdxsubkategorigridcontrol = false;
                icdxindoGridControl.Visible = false;
                icdxengGridControl.Visible = false;
                icdxindoGridControl.DataSource = null;
                icdxengGridControl.DataSource = null;
                icdxindoDataNavigator.Visible = false;
                icdxindoDataNavigator.DataSource = null;
            }
        }

        private void VisibleIcdxSubkategoriGridControl()
        {
            if (!showicdxsubkategorigridcontrol)
            {
                showicdxsubkategorigridcontrol = true;
                
                switch (checkINA.Checked)
                {
                    case true:
                        icdxindoGridControl.Visible = true;
                        icdxengGridControl.Visible = false;
                        break;
                    case false:
                        icdxindoGridControl.Visible = false;
                        icdxengGridControl.Visible = true;
                        break;
                    default:
                        icdxindoGridControl.Visible = true;
                        icdxengGridControl.Visible = false;
                        break;
                }
                icdxindoDataNavigator.Visible = true;

            }
            else
            {
                showicdxsubkategorigridcontrol = false;
                icdxindoGridControl.Visible = false;
                icdxengGridControl.Visible = false;
                icdxindoDataNavigator.Visible = false;
            }
            

           
        }

        private void DiagnosaAwalSrtRujukanBPJS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                this.pageIndex = 1;
                NamaDiagnosaAwalSrtRujukanBPJS.Text = "";
                //if (String.IsNullOrEmpty(DiagnosaAwalSrtRujukanBPJS.Text))
                //{
                //    icdxindoGridControl.Visible = false;
                //    icdxengGridControl.Visible = false;
                //    icdxengGridControl.DataSource = null;
                //    icdxindoGridControl.DataSource = null;
                //}
                //else
                //{
                switch (checkINA.Checked)
                {
                    case true:
                        //LoadDataICDXIndoByIndexPageAndICDXNameAsync(this.pageIndex,this.pageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        //LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        icdxindoGridControl.Visible = true;
                        icdxengGridControl.Visible = false;
                        break;
                    case false:
                        //LoadDataICDXEngByICDXNameAsync(DiagnosaAwalSrtRujukanBPJS.Text);
                        LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        icdxindoGridControl.Visible = false;
                        icdxengGridControl.Visible = true;

                        break;
                    default:
                        //LoadDataICDXIndoByIndexPageAndICDXNameAsync(this.pageIndex, this.pageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        //LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                        icdxindoGridControl.Visible = true;
                        icdxengGridControl.Visible = false;
                        break;
                }

                icdxindoDataNavigator.Visible = true;

                DiagnosaAwalSEPBPJSButtonEdit.EditValue = DiagnosaAwalSrtRujukanBPJS.Text;
                this.selectedIcdxsubkategori = new icdxsubkategori
                {
                    icdxsubkategoriid = DiagnosaAwalSrtRujukanBPJS.Text
                };
            //}
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nDiagnosaAwalSrtRujukanBPJS_TextChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void icdxindoDataNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            try
            { 
                if (e.Button.ButtonType==NavigatorButtonType.Custom)
                {

                    switch (int.Parse(e.Button.Tag.ToString()))
                    {
                        case 0:
                            this.pageIndex = 1;
                            break;
                        case 1:
                            this.pageIndex--;
                            if (this.pageIndex < 1) this.pageIndex = 1;
                            break;
                        case 6:
                            this.pageIndex++;
                            if (this.pageIndex > this.totalPage) this.pageIndex = this.totalPage;
                            break;
                        case 7:
                            this.pageIndex = this.totalPage;
                            break;
                    }
                    //LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);

                    switch (checkINA.Checked)
                    {
                        case true:
                           LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                       
                            break;
                        case false:
                            LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                            break;
                        default:
                            LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);
                            break;
                    }

                        

                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nicdxindoDataNavigator_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiagnosaAwalSrtRujukanBPJS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                switch (checkINA.Checked)
                {
                    case true:

                        if (icdxindoGridControl.Visible==true)
                        icdxindoGridControl.Focus();                        
                        break;
                    case false:
                        if (icdxengGridControl.Visible == true)
                            icdxengGridControl.Focus();
                        break;
                    default:
                        if (icdxindoGridControl.Visible == true)
                            icdxindoGridControl.Focus();
                        break;
                }
            }
        }

        private void icdxindoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.rowindexIcdxsubkategori = e.FocusedRowHandle;
        }

        protected string icdxsubkategoriidsrtrujukanbpjs;
        private void icdxindoGridControl_DoubleClick(object sender, EventArgs e)
        {
            //DiagnosaAwalSrtRujukanBPJS.Text = icdxindoGridView.sele
            var icdx = icdxindoGridView.GetRow(this.rowindexIcdxsubkategori) as icdxsubkategori;
            if (icdx != null)
            {
                icdxsubkategoriidsrtrujukanbpjs = icdx.icdxsubkategoriid;
                DiagnosaAwalSrtRujukanBPJS.Text = string.Format("{0}", icdx.icdxsubkategoriid);
                NamaDiagnosaAwalSrtRujukanBPJS.Text = string.Format("{0}", icdx.icdxsubkategorinmindo);
            }
            icdxindoGridControl.Visible = false;
            icdxindoDataNavigator.Visible = false;
        }

        private void icdxindoGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                icdxindoGridControl_DoubleClick(null, null);
            }
        }

        private void icdxengGridControl_DoubleClick(object sender, EventArgs e)
        {
            var icdx = icdxengGridView.GetRow(this.rowindexIcdxsubkategori) as icdxsubkategori;
            if (icdx != null)
            {
                icdxsubkategoriidsrtrujukanbpjs = icdx.icdxsubkategoriid;
                DiagnosaAwalSrtRujukanBPJS.Text = string.Format("{0}", icdx.icdxsubkategoriid);
                NamaDiagnosaAwalSrtRujukanBPJS.Text = string.Format("{0}", icdx.icdxsubkategorinmeng);
            }
            icdxengGridControl.Visible = false;
            icdxindoDataNavigator.Visible = false;
        }

        private void icdxengGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.rowindexIcdxsubkategori = e.FocusedRowHandle;
        }

        private void icdxengGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                icdxengGridControl_DoubleClick(null, null);
            }
        }

        private void KecPenjaminKLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var value = KecPenjaminKLookUpEdit.EditValue;
                if (value != null)
                {
                    KecIPLookUpEdit.EditValue = value;

                    GetDataKeldesaByKecIdAsync(value != null ? short.Parse(value.ToString()) : short.Parse(null), KeldesaPenjaminKLookUpEdit);
                }
                //KeldesaPenjaminKLookUpEdit.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void KeldesaPenjaminKLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var value = KeldesaPenjaminKLookUpEdit.EditValue;
                if (value != null)
                {
                    KelIPLookUpEdit.EditValue = value;
                    GetDataRTRWByKeldesaIdAsync(value != null ? short.Parse(value.ToString()) : short.Parse(null), RTRWPenjaminKLookUpEdit);
                }
                //RTRWPenjaminKLookUpEdit.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected virtual void penjaminLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (penjaminLookUpEdit.EditValue == null) return;
                if (string.IsNullOrEmpty(penjaminLookUpEdit.EditValue.ToString())) return;

                switch (int.Parse(penjaminLookUpEdit.EditValue.ToString()))
                {
                    case 1: //Diri Sendiri
                        
                        CasePenjaminDiriSendiri();
                        this.statepenjamin = StatePenjamin.DiriSendiri;
                        break;
                    case 2: //Keluarga
                        
                        CasePenjaminKeluarga();
                        this.statepenjamin = StatePenjamin.Keluarga;
                        break;
                    case 3: //BPJS
                        
                        CasePenjaminBPJS();
                        this.statepenjamin = StatePenjamin.BPJS;
                        break;
                    default://BPJS
                        
                        CasePenjaminBPJS();
                        this.statepenjamin = StatePenjamin.BPJS;
                        break;

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\n penjaminLookUpEdit_EditValueChanged ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CasePenjaminDiriSendiri()
        {
            try
            {
                LoadPanelCasePenjaminDiriSendiri();
                LoadDataPanelCasePenjaminDiriSendiri();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nCasePenjaminDiriSendiri()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadPanelCasePenjaminDiriSendiri()
        {
            indexPanel = 0;

            short i = 1;
            short count = (short)(listPanel.Count - 1);
            for (i = count; i >= 1; i--)
            {
                listPanel.RemoveAt(i);
            }

            //Add panel to list
            listPanel.Add(pnlDiriSendiri);
            listPanel.Add(pnlIdentitasPasien);
            listPanel.Add(pnlPoli);
            listPanel.Add(pnlRegistrasi);
            listPanel[indexPanel].BringToFront();
        }

        private void LoadDataPanelCasePenjaminDiriSendiri()
        {
            try
            {
                lblStepDiriSendiri.Text = "Step 2";
                lblTitleDiriSendiri.Text = "Entri Identitas Diri";
                LblStepIdentitasPasien.Text = "Step 3";
                lblTitleIdentitasPasien.Text = "Entri Identitas Pasien";
                lblStepPoli.Text = "Step 4";
                lblTitlePoli.Text = "Entri Poliklinik tujuan";
                lblStepReg.Text = "Step 5";
                lblTitleReg.Text = "Registrasi Pasien";

                TglPenjaminDiriSendiriDateEdit.EditValue = DateTime.Now.Date;
                LoadDataIdentitasdiriPenjaminDiriSendiri();
                LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(Helper.Kotakab.KotakabId());
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(),Helper.Pelayananmedik.pelayananmedikid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nLoadDataPanelCasePenjaminDiriSendiri()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CasePenjaminKeluarga()
        {
            try
            {
                LoadPanelCasePenjaminKeluarga();
                LoadDataPanelCasePenjaminKeluarga();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nCasePenjaminKeluarga()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPanelCasePenjaminKeluarga()
        {
            indexPanel = 0;

            short i = 1;
            short count = (short)(listPanel.Count - 1);
            for (i = count; i >= 1; i--)
            {
                listPanel.RemoveAt(i);
            }

            //Add panel to list
            listPanel.Add(pnlDiriSendiri);
            listPanel.Add(pnlKeluarga);
            listPanel.Add(pnlIdentitasPasien);
            listPanel.Add(pnlPoli);
            listPanel.Add(pnlRegistrasi);
            listPanel[indexPanel].BringToFront();
        }
        private void LoadDataPanelCasePenjaminKeluarga()
        {
            try
            {
                lblStepDiriSendiri.Text = "Step 2";
                lblTitleDiriSendiri.Text = "Entri Identitas Diri";
                lblStepKeluarga.Text = "Step 3";
                lblTitleKeluarga.Text = "Entri Identitas Keluarga";
                LblStepIdentitasPasien.Text = "Step 4";
                lblTitleIdentitasPasien.Text = "Entri Identitas Pasien";
                lblStepPoli.Text = "Step 5";
                lblTitlePoli.Text = "Entri Poliklinik tujuan";
                TglPenjaminKDateEdit.EditValue = DateTime.Now.Date;
                lblStepReg.Text = "Step 6";
                lblTitleReg.Text = "Registrasi Pasien";

                LoadDataIdentitasdiriPenjaminDiriSendiri();
                LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(Helper.Kotakab.KotakabId());
                LoadDataHubKeluargaAndIdentitasdiriAndJKAndKecByKotaKabIdKeluargaPasienAsync(Kotakab.KotakabId());
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(),Helper.Pelayananmedik.pelayananmedikid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nLoadDataPanelCasePenjaminDiriSendiri()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CasePenjaminBPJS()
        {
            try
            {
                LoadPanelCasePenjaminBPJS();
                LoadDataPanelCasePenjaminBPJS();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nCasePenjaminBPJS()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPanelCasePenjaminBPJS()
        {
            indexPanel = 0;

            short i = 1;
            short count = (short)(listPanel.Count - 1);
            for (i = count; i >= 1; i--)
            {
                listPanel.RemoveAt(i);
            }

            //Add panel to list
            listPanel.Add(pnlDiriSendiri);
            listPanel.Add(pnlKartuBPJS);
            listPanel.Add(pnlSuratRujukanBPJS);
            listPanel.Add(pnlSEPBPJS);
            listPanel.Add(pnlIdentitasPasien);
            listPanel.Add(pnlPoli);
            listPanel.Add(pnlRegistrasi);
            listPanel[indexPanel].BringToFront();
        }
        private void LoadDataPanelCasePenjaminBPJS()
        {
            try
            {
                lblStepDiriSendiri.Text = "Step 2";
                lblTitleDiriSendiri.Text = "Entri Identitas Diri";
                lblStepKartuBPJS.Text = "Step 3";
                lblTitleKeluarga.Text = "Entri Data Kartu BPJS";
                lblStepSrtRujukanBPJS.Text = "Step 4";
                lblTitleSrtRujukanBPJS.Text = "Entri Data Surat Rujukan";
                LblStepSEPBPJS.Text = "Step 5";
                LblTitleSEPBPJS.Text = "Entri Data SEP BPJS";
                LblStepIdentitasPasien.Text = "Step 6";
                lblTitleIdentitasPasien.Text = "Entri Data Identitas Pasien";
                lblStepPoli.Text = "Step 7";
                lblTitlePoli.Text = "Entri Poliklinik tujuan";
                lblStepReg.Text = "Step 8";
                lblTitleReg.Text = "Registrasi Pasien";

                //TglLahirKartuBPJSDateEdit.EditValue = DateTime.Now.Date;
                //LoadDataKelasAndJKAndKecByKotaKabIdKartuBPJSAsync(Kotakab.KotakabId());
                //KecKartuBPJSlookUpEdit.EditValue = KecKartuBPJSlookUpEdit.Properties.GetDataSourceValue("kecid", 0);
                LoadDataIdentitasdiriPenjaminDiriSendiri();
                LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(Helper.Kotakab.KotakabId());
                LoadRuangrawatrujukanAsync();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(),Helper.Pelayananmedik.pelayananmedikid);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nLoadDataPanelCasePenjaminDiriSendiri()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void TglLahirIPDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var date = (TglLahirIPDateEdit.EditValue != null) ? (DateTime)TglLahirIPDateEdit.EditValue : DateTime.Now.Date;
                var result = CommonFunc.HitungUmur((short)(date.Year), (short)date.Month, (short)date.Day);
                ThnIP.Text = result.Item1.ToString(); BlnIP.Text = result.Item2.ToString(); HariIP.Text = result.Item3.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nTglLahirIPDateEdit_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TglRujukanSrtRujukanBPJSDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            TglSEPBPJSDateEdit.EditValue = TglRujukanSrtRujukanBPJSDateEdit.EditValue;
        }

        private void TujuanSrtRujukanBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //TujuanSEPBPJS.Text = TujuanSrtRujukanBPJSLookUpEdit.Text;
                if (TujuanSrtRujukanBPJSLookUpEdit.EditValue != null)
                {
                    //JenisRawatSEPBPJS.Text = ((pelayananmedik)(LoadDataPelayananmedikByRujukanruangrawatId((short)TujuanSrtRujukanBPJSLookUpEdit.EditValue))).pelayananmediknm;
                    TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue = TujuanSrtRujukanBPJSLookUpEdit.EditValue;
                    //var data = await LoadDataPelayananmedikByRujukanruangrawatId((short)TujuanSrtRujukanBPJSLookUpEdit.EditValue);
                    //JenisRawatSEPBPJS.Text = (data != null ? data.pelayananmediknm : "");
                    //data = null;
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nLTujuanSrtRujukanBPJSLookUpEdit_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NamaDiagnosaAwalSrtRujukanBPJS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NoPesertaKartuBPJS_TextChanged(object sender, EventArgs e)
        {
            NoKartuBPJSSEPBPJS.Text = NoPesertaKartuBPJS.Text;
        }

        private void NamaPesertaKartuBPJS_TextChanged(object sender, EventArgs e)
        {
            NamaPesertaSEPBPJS.Text = NamaPesertaKartuBPJS.Text;
            NamaIP.Text = NamaPesertaKartuBPJS.Text;
        }

        private void TglLahirKartuBPJSDateEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {

        }

        private void JKKartuBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            KelaminSEPBPJS.Text = JKKartuBPJSLookUpEdit.Text;
            KelaminIPLookUpEdit.EditValue = JKKartuBPJSLookUpEdit.EditValue;
        }

        private void KelasKartuBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            KelasRawatSEPBPJS.Text = KelasKartuBPJSLookUpEdit.Text;
        }

        private void TempatLahirKartuBPJS_TextChanged(object sender, EventArgs e)
        {
            TempatLahirIP.Text = TempatLahirKartuBPJS.Text;
        }

        private void AlamatKartuBPJSTextBox_TextChanged(object sender, EventArgs e)
        {
            AlamatIP.Text = AlamatKartuBPJSTextBox.Text;
        }

        private void RTRWKartuBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            RTRWIPLookUpEdit.EditValue = RTRWKartuBPJSLookUpEdit.EditValue;
        }

        private void TglLahirKartuBPJSDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if ((DateTime)TglLahirKartuBPJSDateEdit.EditValue > DateTime.Now.Date)
            {
                MetroFramework.MetroMessageBox.Show(this, "Tgl lahir tidak valid, karena tgl yang dipilih > tgl sekarang", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TglLahirKartuBPJSDateEdit.EditValue = DateTime.Now.Date;
                return;
            }

            try
            {
                TglLahirSEPBPJS.Text = (TglLahirKartuBPJSDateEdit.EditValue != null) ? string.Format("{0:dd/MM/yyyy}", TglLahirKartuBPJSDateEdit.EditValue) : "";
                TglLahirIPDateEdit.EditValue = TglLahirKartuBPJSDateEdit.EditValue;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nTglLahirKartuBPJSDateEdit_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RTRWPenjaminKLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            RTRWIPLookUpEdit.EditValue = RTRWPenjaminKLookUpEdit.EditValue;
        }

        protected virtual void bClear_Click(object sender, EventArgs e)
        {
            try
            {

                if (isSave == true)
                {
                    EnableControlBasedChosePenjamin(true);
                    ClearControlBasedChosePenjamin();

                    this.indexPanel = 0;
                    listPanel[indexPanel].BringToFront();
                    isSave = false;
                    btnNext.Text = "Next";
                }
                else
                {
                    ClearControlBasedChosePenjamin();
                    this.indexPanel = 0;
                    listPanel[indexPanel].BringToFront();
                    isSave = false;
                    btnNext.Text = "Next";

                    
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbClear_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        protected virtual void NamaDiriSendiri_TextChanged(object sender, EventArgs e)
        {
            NamaIP.Text = NamaDiriSendiri.Text;
            NamaPesertaKartuBPJS.Text = NamaDiriSendiri.Text;
            NamaPesertaSEPBPJS.Text = NamaDiriSendiri.Text;
        }

        protected virtual void TempatLahirDiriSendiri_TextChanged(object sender, EventArgs e)
        {
            TempatLahirIP.Text = TempatLahirDiriSendiri.Text;
            TempatLahirKartuBPJS.Text = TempatLahirDiriSendiri.Text;
            
        }

        protected virtual void TglLahirDiriSendiriDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            TglLahirIPDateEdit.EditValue = (sender as DateEdit).EditValue;
            TglLahirKartuBPJSDateEdit.EditValue = (sender as DateEdit).EditValue;
        }

        protected virtual void KelaminDiriSendiriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            KelaminIPLookUpEdit.EditValue = KelaminDiriSendiriLookUpEdit.EditValue;
            JKKartuBPJSLookUpEdit.EditValue = KelaminDiriSendiriLookUpEdit.EditValue;
        }

        protected virtual void ALamatDiriSendiri_TextChanged(object sender, EventArgs e)
        {
            AlamatIP.Text = ALamatDiriSendiri.Text;
            AlamatKartuBPJSTextBox.Text = ALamatDiriSendiri.Text;
        }

        protected virtual void KecDiriSendiriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                var value = KecDiriSendiriLookUpEdit.EditValue;
                if (value != null)
                {

                    KecDiriSendiriLookUpEdit.SelectionStart = KecDiriSendiriLookUpEdit.Text.Length + 1;
                    KecDiriSendiriLookUpEdit.Focus();


                }


                //
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nKecDiriSendiriLookUpEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        protected virtual void KelDiriSendiriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            

        }

        protected virtual void RTRWDiriSendiriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (RTRWDiriSendiriLookUpEdit.EditValue != null)
                {
                    RTRWIPLookUpEdit.EditValue = RTRWDiriSendiriLookUpEdit.EditValue;
                    RTRWKartuBPJSLookUpEdit.EditValue = RTRWDiriSendiriLookUpEdit.EditValue;
                    PekerjaanDiriSendiriLookUpEdit.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nRTRWDiriSendiriLookUpEdit_EditValueChanged\n" + this.Name+ "\nRTRWDiriSendiriLookUpEdit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        protected virtual void PekerjaanDiriSendiriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (PekerjaanDiriSendiriLookUpEdit.EditValue != null)
                {
                    PekerjaanIPLookUpEdit.EditValue = PekerjaanDiriSendiriLookUpEdit.EditValue;
                    
                    NoTelpDiriSendiri.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nPekerjaanDiriSendiriLookUpEdit_EditValueChanged\n" + this.Name + "\nPekerjaanDiriSendiriLookUpEdit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected virtual void NoTelpDiriSendiri_TextChanged(object sender, EventArgs e)
        {
            NoTelpIP.Text =  NoTelpDiriSendiri.Text;
        }

        protected virtual void NoHPDiriSendiri_TextChanged(object sender, EventArgs e)
        {
            NoHPIP.Text = NoHPDiriSendiri.Text;
        }

        protected virtual void NamaIP_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(NamaIP.Text))
            //{
            //    NamaIP.BackColor = Color.YellowGreen;
            //}
        }

        protected virtual void TempatLahirIP_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void KelaminIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if ((KelaminIPLookUpEdit.EditValue==null) || (string.IsNullOrEmpty(KelaminIPLookUpEdit.Text)))
            //{
            //    AlamatIP.BackColor = Color.OrangeRed;
            //}
            //else
            //{
            //    AlamatIP.BackColor = Color.YellowGreen;
            //}
        }

        protected virtual void AlamatIP_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(AlamatIP.Text))
            //{
            //    AlamatIP.BackColor = Color.OrangeRed;
            //}
            //else
            //{
            //    AlamatIP.BackColor = Color.YellowGreen;
            //}
        }

        protected virtual void RTRWIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void PekerjaanIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        protected virtual void NoTelpIP_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void NoHPIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoHPDiriSendiri_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyCode == Keys.Enter) || (e.KeyCode==Keys.Tab)) btnNext.Focus();
        }

        private void penjaminLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (penjaminLookUpEdit.EditValue != null)
            {
                if ((e.KeyCode == Keys.Enter) || (e.KeyCode==Keys.Tab)) btnNext.Focus();
            }
        }

        private void NoHPDiriSendiri_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void SukuIPLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void RTRWKartuBPJSLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void NoHPPenjaminK_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void NamaPoli_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void NoregistrasiReg_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void KelasRawatSEPBPJS_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void TelahDibreikanSrtRujukanBPJS_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void NoHPDiriSendiri_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) btnNext.Focus();
        }

        private void NoTelpDiriSendiri_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) NoHPDiriSendiri.Focus();
        }

        private void AlamatPenjaminK_TextChanged(object sender, EventArgs e)
        {
            AlamatIP.Text = AlamatPenjaminK.Text;
        }

        private void NoTelpPenjaminK_TextChanged(object sender, EventArgs e)
        {
            NoTelpIP.Text = NoTelpPenjaminK.Text;
        }

        private void HubPenjaminKLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void IdentitasdiriPenjaminKLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void DiagnosaAwalButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (FListICDXRJ f = new FListICDXRJ())
                {

                    //Show the dialog
                    f.Owner = this;
                    f.passData += new FListICDXRJ.PassData(passData);

                    //f.DelegateMethodLoadHandler += new FListICDXRJ.LoadHandler(DelegateMethodLoadHandler);
                    f.ShowDialog();
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    //overlayForm.Dispose();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nDiagnosaAwalButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void passData(object kode, object name)
        {
            if (kode != null)
            {
                if (!string.IsNullOrEmpty(kode.ToString()))
                {
                    selectedIcdxsubkategori = new icdxsubkategori()
                    {
                        icdxsubkategoriid = kode.ToString()
                    };
                    DiagnosaAwalSEPBPJSButtonEdit.Text = kode + " - " + name;
                }
                else
                {
                    DiagnosaAwalSEPBPJSButtonEdit.Text = string.Empty;
                }
            }
            else
            {
                DiagnosaAwalSEPBPJSButtonEdit.Text = string.Empty;
            }
        }

        private async void TujuanSrtRujukanSEPBPJSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue != null)
            {
                //JenisRawatSEPBPJS.Text = ((pelayananmedik)(LoadDataPelayananmedikByRujukanruangrawatId((short)TujuanSrtRujukanBPJSLookUpEdit.EditValue))).pelayananmediknm;
                var data = await LoadDataPelayananmedikByRujukanruangrawatId((short)TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue);
                JenisRawatSEPBPJS.Text = (data != null ? data.pelayananmediknm : "");
                data = null;

                PoliLookUpEdit.EditValue = TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue;
            }
        }

        protected virtual void KecDiriSendiriLookUpEdit_Leave(object sender, EventArgs e)
        {
            try
            {
                var value = KecDiriSendiriLookUpEdit.EditValue;
                if (value != null)
                {

                    KecIPLookUpEdit.EditValue = value;
                    KecKartuBPJSlookUpEdit.EditValue = value;
                    //GetDataKeldesaByKecIdAsync(KecDiriSendiriLookUpEdit.EditValue != null ? (short)(KecDiriSendiriLookUpEdit.EditValue) : short.Parse(null), KelDiriSendiriLookUpEdit);
                    GetDataKeldesaByKecIdAsync(value != null ? (short)(value) : short.Parse(null), KelDiriSendiriLookUpEdit);
                    //value = null;
                    //KelDiriSendiriLookUpEdit.Focus();
                }


                //
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nKecDiriSendiriLookUpEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void KecDiriSendiriLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        protected virtual void KelDiriSendiriLookUpEdit_Leave(object sender, EventArgs e)
        {
            try
            {
                var value = KelDiriSendiriLookUpEdit.EditValue;
                if (value != null)
                {
                    KelIPLookUpEdit.EditValue = value;
                    KelKartuBPJSLookUpEdit.EditValue = value;

                    GetDataRTRWByKeldesaIdAsync(value != null ? (short)(value) : short.Parse(null), RTRWDiriSendiriLookUpEdit);
                    //value = null;
                    //RTRWDiriSendiriLookUpEdit.Focus();
                }

                //
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nKelDiriSendiriLookUpEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void KelDiriSendiriLookUpEdit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        //    if (e.KeyCode == Keys.Tab)
        //    {
        //        RTRWDiriSendiriLookUpEdit.Focus();
        //    }
        }

        private void NoRMIP_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoRMIP.Text))
            {
                if (string.IsNullOrEmpty(NoCMSEPBPJS.Text))
                {
                    NoCMSEPBPJS.Text = NoRMIP.Text;
                }
            }
        }

        protected virtual void btnKartuKontrol_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnKartuPasien_Click(object sender, EventArgs e)
        {

        }

        protected virtual void KecIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var value = KecIPLookUpEdit.EditValue;
                if (value != null)
                {
                    GetDataKeldesaByKecIdAsync(KecIPLookUpEdit.EditValue != null ? (short)(KecIPLookUpEdit.EditValue) : short.Parse(null), KelIPLookUpEdit);
                    //KelIPLookUpEdit.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nKecIPLookUpEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected virtual void KelIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var value = KelIPLookUpEdit.EditValue;
                if (value != null)
                {
                    GetDataRTRWByKeldesaIdAsync(value != null ? (short)(value) : short.Parse(null), RTRWIPLookUpEdit);
                    //RTRWIPLookUpEdit.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\nKelIPLookUpEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void PoliLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var data = PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid;
                if (data != null)
                {
                    KodePoli.Text = data.ruangrawatid.ToString(); NamaPoli.Text = data.ruangrawatnm;
                    shortkelasruangrawatid = data.kelasruangrawatid; shortkelasid = data.kelasid.Value;
                    shortkamarid = data.kamarid; shorttempattidurid = data.tempattidurid;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\nPoliLookUpEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
