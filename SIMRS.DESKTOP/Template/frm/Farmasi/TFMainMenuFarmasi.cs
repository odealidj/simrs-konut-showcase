using DevExpress.XtraEditors;
using SIMRS.DESKTOP.FrontEnd.Farmasi;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Depo;
using SIMRS.DESKTOP.FrontEnd.Farmasi.FObatSatuan;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Obat;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Pbf;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Satuan;
using SIMRS.DESKTOP.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi
{
    public class TFMainMenuFarmasi : TFMainMenu
    {
        #region private
        protected System.Windows.Forms.Panel pnlSlideMenu;
        protected System.Windows.Forms.Panel pnlMenuPembelian;
        protected System.Windows.Forms.Button btnSubMenuViewSuku;
        protected System.Windows.Forms.Button btnSubMenuViewGolDarah;
        protected System.Windows.Forms.Button btnSubMenuViewRT;
        protected System.Windows.Forms.Button btnSubMenuViewRW;
        protected System.Windows.Forms.Button btnSubMenuViewStockKontrol;
        protected System.Windows.Forms.Button btnSubMenuDistribusiDepo;
        protected System.Windows.Forms.Button btnSubMenuDistribusiGudang;
        protected System.Windows.Forms.Button btnSubMenuPembelianMasuk;
        protected System.Windows.Forms.Button btnMenuPembelian;
        protected System.Windows.Forms.Panel pnlMenuBerkas;
        protected System.Windows.Forms.Button btnSubMenuBerkasTransaksi;
        protected uc.ucIndikatorKlikMenu btnSubMenuRegistrasiListPasienIndikator;
        protected uc.ucIndikatorKlikMenu btnSubMenuRegistrasiListRegistrasiIndikator;
        protected System.Windows.Forms.Button btnSubMenuBerkasResep;
        protected System.Windows.Forms.Panel pnlBtnMenuRegistrasi;
        protected uc.ucIndikatorKlikMenu btnMenuRegistrasiIndikator;
        protected System.Windows.Forms.Button btnMenuBerkas;
        protected System.Windows.Forms.Button btnMenuRegistrasiIcon;
        protected uc.ucIndikatorKlikMenu ucIndikatorKlikMenu1;
        protected System.Windows.Forms.Panel pnlMenuMaster;
        protected System.Windows.Forms.Button btnSubMenuMasterDefObatSatuan;
        protected System.Windows.Forms.Button btnSubMenuMasterPBF;
        protected System.Windows.Forms.Button btnSubMenuMasterSatuan;
        protected System.Windows.Forms.Button btnSubMenuMasterDepo;
        protected System.Windows.Forms.Button btnSubMenuMasterObat;
        protected System.Windows.Forms.Button btnMenuMaster;
        protected System.Windows.Forms.Panel pnlMenuLaporan;
        protected System.Windows.Forms.Button btnSubMenuLaporan5;
        protected System.Windows.Forms.Button btnSubMenuLaporan4;
        protected System.Windows.Forms.Button btnSubMenuLaporan3;
        protected System.Windows.Forms.Button btnSubMenuLaporan2;
        protected System.Windows.Forms.Button btnSubMenuLaporanPendapatan;
        protected System.Windows.Forms.Button btnMenuLaporan;
        protected Panel pnlMenuDepo;
        protected Button button11;
        protected Button button12;
        protected Button button13;
        protected Button button14;
        protected Button button15;
        protected Button btnSubMenuDepoStockkontrol;
        protected Button btnSubMenuDepoKeluar;
        protected Button btnSubMenuDepoMasuk;
        protected Button btnMenuDepo;
        protected Panel pnlMenuGudang;
        protected Button button2;
        protected Button button3;
        protected Button button4;
        protected Button button5;
        protected Button button6;
        protected Button btnSubMenuGudangStockkontrol;
        protected Button btnSubMenuGudangKeluar;
        protected Button btnSubMenuGudangMasuk;
        protected Button btnMenuGudang;
        protected System.Windows.Forms.Button btnMenuHome;

        #endregion

        #region private methode control

        protected void defaultSetIconSubMenu()
        {
            btnMenuRegistrasiIcon.Image = Properties.Resources.back;

            ////btnSubMenuRegistrasiListRegistrasi.Image = Properties.Resources.circled;
            ////btnSubMenuRegistrasiListPasien.Image = Properties.Resources.circled;
            //////btnMenuView.Image = Properties.Resources.back;

            ////btnSubMenuLaporan1.Image = Properties.Resources.circled;
            ////btnSubMenuRegistrasiListPasien.Image = Properties.Resources.circled;
            ////btnSubMenuRegistrasiListRegistrasi.Image = Properties.Resources.circled;
            ////btnSubMenuViewGolDarah.Image = Properties.Resources.circled;
            ////btnSubMenuViewKecamatan.Image = Properties.Resources.circled;
            ////btnSubMenuViewKelurahan.Image = Properties.Resources.circled;
            ////btnSubMenuViewPenjamin.Image = Properties.Resources.circled;
            ////btnSubMenuViewPoliklinik.Image = Properties.Resources.circled;
            ////btnSubMenuViewRT.Image = Properties.Resources.circled;
            ////btnSubMenuViewRW.Image = Properties.Resources.circled;
            ////btnSubMenuViewSuku.Image = Properties.Resources.circled;


        }

        protected void PanelSlideMouseHover()
        {
            if (HiddenSlidePanel)
            {

                defaultControlShowPanelSlide();
                HiddenSlidePanel = true;
                pnlSlide.Width = defaultWidthPanelSlide;
                pnlLeftHeader.Width = pnlSlide.Width;
                //pnlSlideMenu.Width = pnlSlide.Width;
                //pnlSlide.BackColor = Color.Transparent;
                //pnlPicUser.BackColor = pnlSlide.BackColor;
                //pnlSlideMenu.BackColor = pnlSlide.BackColor;
            }
        }

        protected void PanelSlideMouseLeave()
        {
            if (HiddenSlidePanel)
            {
                defaultControlHiddenPanelSlide();

                pnlSlide.Width = defaultWidthPanelSlideHide;
                pnlLeftHeader.Width = pnlSlide.Width;
                //pnlSlideMenu.Width = pnlSlide.Width;
                //pnlSlide.BackColor = defaultBackGroundColorPanelSide;
                //pnlPicUser.BackColor = pnlSlide.BackColor;
                //pnlSlideMenu.BackColor = pnlSlide.BackColor;
            }
        }

        #endregion

        public TFMainMenuFarmasi():base()
        {
            InitializeComponent();

            this.mlblTitleHeader.Text = string.Format("{0} - [{1}]", this.mlblTitleHeader.Text, Helper.Ruangrawat.ruangrawatnm);

            defaultSetIconSubMenu();

            btnMenuHome_Click(null, null);


            switch (Helper.Ruangrawat.ruangrawatid)
            {
                case 57:
                    this.pnlMenuBerkas.Visible = false;
                    this.pnlMenuDepo.Visible = false;
                    this.pnlMenuGudang.Visible = true;
                    this.pnlMenuPembelian.Visible = true;
                    this.pnlMenuMaster.Visible = true;
                    this.pnlMenuLaporan.Visible = true;
                    break;
                default:
                    this.pnlMenuBerkas.Visible = true;
                    this.pnlMenuDepo.Visible = true;
                    this.pnlMenuGudang.Visible = false;
                    this.pnlMenuPembelian.Visible = false;
                    this.pnlMenuMaster.Visible = false;
                    this.pnlMenuLaporan.Visible = false;
                    break;

            }

            this.lblUserName.Text = "Selamat Data, User";
            this.lblUserName.Visible = true;

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFMainMenuFarmasi));
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.pnlMenuLaporan = new System.Windows.Forms.Panel();
            this.btnSubMenuLaporan5 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan4 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan3 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan2 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporanPendapatan = new System.Windows.Forms.Button();
            this.btnMenuLaporan = new System.Windows.Forms.Button();
            this.pnlMenuMaster = new System.Windows.Forms.Panel();
            this.btnSubMenuMasterDefObatSatuan = new System.Windows.Forms.Button();
            this.btnSubMenuMasterPBF = new System.Windows.Forms.Button();
            this.btnSubMenuMasterSatuan = new System.Windows.Forms.Button();
            this.btnSubMenuMasterDepo = new System.Windows.Forms.Button();
            this.btnSubMenuMasterObat = new System.Windows.Forms.Button();
            this.btnMenuMaster = new System.Windows.Forms.Button();
            this.pnlMenuDepo = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnSubMenuDepoStockkontrol = new System.Windows.Forms.Button();
            this.btnSubMenuDepoKeluar = new System.Windows.Forms.Button();
            this.btnSubMenuDepoMasuk = new System.Windows.Forms.Button();
            this.btnMenuDepo = new System.Windows.Forms.Button();
            this.pnlMenuGudang = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSubMenuGudangStockkontrol = new System.Windows.Forms.Button();
            this.btnSubMenuGudangKeluar = new System.Windows.Forms.Button();
            this.btnSubMenuGudangMasuk = new System.Windows.Forms.Button();
            this.btnMenuGudang = new System.Windows.Forms.Button();
            this.pnlMenuPembelian = new System.Windows.Forms.Panel();
            this.btnSubMenuViewSuku = new System.Windows.Forms.Button();
            this.btnSubMenuViewGolDarah = new System.Windows.Forms.Button();
            this.btnSubMenuViewRT = new System.Windows.Forms.Button();
            this.btnSubMenuViewRW = new System.Windows.Forms.Button();
            this.btnSubMenuViewStockKontrol = new System.Windows.Forms.Button();
            this.btnSubMenuDistribusiDepo = new System.Windows.Forms.Button();
            this.btnSubMenuDistribusiGudang = new System.Windows.Forms.Button();
            this.btnSubMenuPembelianMasuk = new System.Windows.Forms.Button();
            this.btnMenuPembelian = new System.Windows.Forms.Button();
            this.pnlMenuBerkas = new System.Windows.Forms.Panel();
            this.btnSubMenuBerkasTransaksi = new System.Windows.Forms.Button();
            this.btnSubMenuRegistrasiListPasienIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnSubMenuRegistrasiListRegistrasiIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnSubMenuBerkasResep = new System.Windows.Forms.Button();
            this.pnlBtnMenuRegistrasi = new System.Windows.Forms.Panel();
            this.btnMenuRegistrasiIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnMenuBerkas = new System.Windows.Forms.Button();
            this.btnMenuRegistrasiIcon = new System.Windows.Forms.Button();
            this.ucIndikatorKlikMenu1 = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnMenuHome = new System.Windows.Forms.Button();
            this.pnlPicUser.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserShow.Properties)).BeginInit();
            this.pnlSlideMenu.SuspendLayout();
            this.pnlMenuLaporan.SuspendLayout();
            this.pnlMenuMaster.SuspendLayout();
            this.pnlMenuDepo.SuspendLayout();
            this.pnlMenuGudang.SuspendLayout();
            this.pnlMenuPembelian.SuspendLayout();
            this.pnlMenuBerkas.SuspendLayout();
            this.pnlBtnMenuRegistrasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(800, 33);
            // 
            // pnlSlide
            // 
            this.pnlSlide.Controls.Add(this.pnlSlideMenu);
            this.pnlSlide.Controls.SetChildIndex(this.pnlPicUser, 0);
            this.pnlSlide.Controls.SetChildIndex(this.pnlSlideMenu, 0);
            // 
            // mlblTitleHeader
            // 
            this.mlblTitleHeader.Size = new System.Drawing.Size(0, 33);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(722, 0);
            // 
            // btnResize
            // 
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.Location = new System.Drawing.Point(748, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(774, 0);
            // 
            // pnlRoot
            // 
            this.pnlRoot.Size = new System.Drawing.Size(590, 27);
            // 
            // lbljam
            // 
            this.lbljam.Location = new System.Drawing.Point(525, 0);
            this.lbljam.Text = "10:38:58";
            // 
            // lblTgl
            // 
            this.lblTgl.Location = new System.Drawing.Point(309, 0);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(590, 540);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location = new System.Drawing.Point(696, 0);
            // 
            // picUserHide
            // 
            this.picUserHide.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.picUserHide.Properties.Appearance.Options.UseBackColor = true;
            this.picUserHide.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            // 
            // picUserShow
            // 
            this.picUserShow.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.picUserShow.Properties.Appearance.Options.UseBackColor = true;
            this.picUserShow.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            // 
            // pnlSlideMenu
            // 
            this.pnlSlideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSlideMenu.AutoScroll = true;
            this.pnlSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlSlideMenu.Controls.Add(this.pnlMenuLaporan);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuMaster);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuDepo);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuGudang);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuPembelian);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuBerkas);
            this.pnlSlideMenu.Controls.Add(this.ucIndikatorKlikMenu1);
            this.pnlSlideMenu.Controls.Add(this.btnMenuHome);
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 197);
            this.pnlSlideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(210, 361);
            this.pnlSlideMenu.TabIndex = 6;
            // 
            // pnlMenuLaporan
            // 
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan5);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan4);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan3);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan2);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporanPendapatan);
            this.pnlMenuLaporan.Controls.Add(this.btnMenuLaporan);
            this.pnlMenuLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuLaporan.Location = new System.Drawing.Point(0, 210);
            this.pnlMenuLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuLaporan.Name = "pnlMenuLaporan";
            this.pnlMenuLaporan.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuLaporan.TabIndex = 18;
            // 
            // btnSubMenuLaporan5
            // 
            this.btnSubMenuLaporan5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuLaporan5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuLaporan5.FlatAppearance.BorderSize = 0;
            this.btnSubMenuLaporan5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuLaporan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuLaporan5.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuLaporan5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan5.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenuLaporan5.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuLaporan5.Name = "btnSubMenuLaporan5";
            this.btnSubMenuLaporan5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuLaporan5.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuLaporan5.TabIndex = 18;
            this.btnSubMenuLaporan5.Text = "    Laporan 5";
            this.btnSubMenuLaporan5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan5.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuLaporan4
            // 
            this.btnSubMenuLaporan4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuLaporan4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuLaporan4.FlatAppearance.BorderSize = 0;
            this.btnSubMenuLaporan4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuLaporan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuLaporan4.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuLaporan4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan4.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenuLaporan4.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuLaporan4.Name = "btnSubMenuLaporan4";
            this.btnSubMenuLaporan4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuLaporan4.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuLaporan4.TabIndex = 17;
            this.btnSubMenuLaporan4.Text = "    Laporan 4";
            this.btnSubMenuLaporan4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan4.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuLaporan3
            // 
            this.btnSubMenuLaporan3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuLaporan3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuLaporan3.FlatAppearance.BorderSize = 0;
            this.btnSubMenuLaporan3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuLaporan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuLaporan3.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuLaporan3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan3.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuLaporan3.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuLaporan3.Name = "btnSubMenuLaporan3";
            this.btnSubMenuLaporan3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuLaporan3.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuLaporan3.TabIndex = 16;
            this.btnSubMenuLaporan3.Text = "    Laporan 3";
            this.btnSubMenuLaporan3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan3.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuLaporan2
            // 
            this.btnSubMenuLaporan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuLaporan2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuLaporan2.FlatAppearance.BorderSize = 0;
            this.btnSubMenuLaporan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuLaporan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuLaporan2.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuLaporan2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan2.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuLaporan2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuLaporan2.Name = "btnSubMenuLaporan2";
            this.btnSubMenuLaporan2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuLaporan2.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuLaporan2.TabIndex = 15;
            this.btnSubMenuLaporan2.Text = "    Stock Opname";
            this.btnSubMenuLaporan2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan2.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuLaporanPendapatan
            // 
            this.btnSubMenuLaporanPendapatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuLaporanPendapatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuLaporanPendapatan.FlatAppearance.BorderSize = 0;
            this.btnSubMenuLaporanPendapatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuLaporanPendapatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuLaporanPendapatan.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuLaporanPendapatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporanPendapatan.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuLaporanPendapatan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuLaporanPendapatan.Name = "btnSubMenuLaporanPendapatan";
            this.btnSubMenuLaporanPendapatan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuLaporanPendapatan.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuLaporanPendapatan.TabIndex = 14;
            this.btnSubMenuLaporanPendapatan.Text = "    Pendapatan";
            this.btnSubMenuLaporanPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporanPendapatan.UseVisualStyleBackColor = false;
            // 
            // btnMenuLaporan
            // 
            this.btnMenuLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuLaporan.FlatAppearance.BorderSize = 0;
            this.btnMenuLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLaporan.ForeColor = System.Drawing.Color.White;
            this.btnMenuLaporan.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuLaporan.Image")));
            this.btnMenuLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLaporan.Location = new System.Drawing.Point(0, 0);
            this.btnMenuLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuLaporan.Name = "btnMenuLaporan";
            this.btnMenuLaporan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuLaporan.Size = new System.Drawing.Size(210, 35);
            this.btnMenuLaporan.TabIndex = 13;
            this.btnMenuLaporan.Text = "          Laporan";
            this.btnMenuLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLaporan.UseVisualStyleBackColor = false;
            this.btnMenuLaporan.Click += new System.EventHandler(this.btnMenuLaporan_Click);
            // 
            // pnlMenuMaster
            // 
            this.pnlMenuMaster.Controls.Add(this.btnSubMenuMasterDefObatSatuan);
            this.pnlMenuMaster.Controls.Add(this.btnSubMenuMasterObat);
            this.pnlMenuMaster.Controls.Add(this.btnSubMenuMasterSatuan);
            this.pnlMenuMaster.Controls.Add(this.btnSubMenuMasterPBF);
            this.pnlMenuMaster.Controls.Add(this.btnSubMenuMasterDepo);
            this.pnlMenuMaster.Controls.Add(this.btnMenuMaster);
            this.pnlMenuMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuMaster.Location = new System.Drawing.Point(0, 175);
            this.pnlMenuMaster.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuMaster.Name = "pnlMenuMaster";
            this.pnlMenuMaster.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuMaster.TabIndex = 17;
            // 
            // btnSubMenuMasterDefObatSatuan
            // 
            this.btnSubMenuMasterDefObatSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuMasterDefObatSatuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuMasterDefObatSatuan.FlatAppearance.BorderSize = 0;
            this.btnSubMenuMasterDefObatSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuMasterDefObatSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuMasterDefObatSatuan.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuMasterDefObatSatuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterDefObatSatuan.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenuMasterDefObatSatuan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuMasterDefObatSatuan.Name = "btnSubMenuMasterDefObatSatuan";
            this.btnSubMenuMasterDefObatSatuan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuMasterDefObatSatuan.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuMasterDefObatSatuan.TabIndex = 18;
            this.btnSubMenuMasterDefObatSatuan.Text = "    Def. Obat Satuan";
            this.btnSubMenuMasterDefObatSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterDefObatSatuan.UseVisualStyleBackColor = false;
            this.btnSubMenuMasterDefObatSatuan.Click += new System.EventHandler(this.btnSubMenuMasterDefObatSatuan_Click);
            // 
            // btnSubMenuMasterPBF
            // 
            this.btnSubMenuMasterPBF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuMasterPBF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuMasterPBF.FlatAppearance.BorderSize = 0;
            this.btnSubMenuMasterPBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuMasterPBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuMasterPBF.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuMasterPBF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterPBF.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuMasterPBF.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuMasterPBF.Name = "btnSubMenuMasterPBF";
            this.btnSubMenuMasterPBF.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuMasterPBF.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuMasterPBF.TabIndex = 17;
            this.btnSubMenuMasterPBF.Text = "   PBF";
            this.btnSubMenuMasterPBF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterPBF.UseVisualStyleBackColor = false;
            this.btnSubMenuMasterPBF.Click += new System.EventHandler(this.btnSubMenuMasterPBF_Click);
            // 
            // btnSubMenuMasterSatuan
            // 
            this.btnSubMenuMasterSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuMasterSatuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuMasterSatuan.FlatAppearance.BorderSize = 0;
            this.btnSubMenuMasterSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuMasterSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuMasterSatuan.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuMasterSatuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterSatuan.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuMasterSatuan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuMasterSatuan.Name = "btnSubMenuMasterSatuan";
            this.btnSubMenuMasterSatuan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuMasterSatuan.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuMasterSatuan.TabIndex = 16;
            this.btnSubMenuMasterSatuan.Text = "   Satuan";
            this.btnSubMenuMasterSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterSatuan.UseVisualStyleBackColor = false;
            this.btnSubMenuMasterSatuan.Click += new System.EventHandler(this.btnSubMenuMasterSatuan_Click);
            // 
            // btnSubMenuMasterDepo
            // 
            this.btnSubMenuMasterDepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuMasterDepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuMasterDepo.FlatAppearance.BorderSize = 0;
            this.btnSubMenuMasterDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuMasterDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuMasterDepo.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuMasterDepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterDepo.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuMasterDepo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuMasterDepo.Name = "btnSubMenuMasterDepo";
            this.btnSubMenuMasterDepo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuMasterDepo.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuMasterDepo.TabIndex = 15;
            this.btnSubMenuMasterDepo.Text = "   Depo";
            this.btnSubMenuMasterDepo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterDepo.UseVisualStyleBackColor = false;
            this.btnSubMenuMasterDepo.Click += new System.EventHandler(this.btnSubMenuMasterDepo_Click);
            // 
            // btnSubMenuMasterObat
            // 
            this.btnSubMenuMasterObat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuMasterObat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuMasterObat.FlatAppearance.BorderSize = 0;
            this.btnSubMenuMasterObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuMasterObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuMasterObat.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuMasterObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterObat.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenuMasterObat.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuMasterObat.Name = "btnSubMenuMasterObat";
            this.btnSubMenuMasterObat.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuMasterObat.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuMasterObat.TabIndex = 14;
            this.btnSubMenuMasterObat.Text = "   Obat && BHP";
            this.btnSubMenuMasterObat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMasterObat.UseVisualStyleBackColor = false;
            this.btnSubMenuMasterObat.Click += new System.EventHandler(this.btnSubMenuMasterObat_Click);
            // 
            // btnMenuMaster
            // 
            this.btnMenuMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMaster.FlatAppearance.BorderSize = 0;
            this.btnMenuMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMaster.ForeColor = System.Drawing.Color.White;
            this.btnMenuMaster.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuMaster.Image")));
            this.btnMenuMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMaster.Location = new System.Drawing.Point(0, 0);
            this.btnMenuMaster.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuMaster.Name = "btnMenuMaster";
            this.btnMenuMaster.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuMaster.Size = new System.Drawing.Size(210, 35);
            this.btnMenuMaster.TabIndex = 13;
            this.btnMenuMaster.Text = "          Master";
            this.btnMenuMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMaster.UseVisualStyleBackColor = false;
            this.btnMenuMaster.Click += new System.EventHandler(this.btnMenuMaster_Click);
            // 
            // pnlMenuDepo
            // 
            this.pnlMenuDepo.Controls.Add(this.button11);
            this.pnlMenuDepo.Controls.Add(this.button12);
            this.pnlMenuDepo.Controls.Add(this.button13);
            this.pnlMenuDepo.Controls.Add(this.button14);
            this.pnlMenuDepo.Controls.Add(this.button15);
            this.pnlMenuDepo.Controls.Add(this.btnSubMenuDepoStockkontrol);
            this.pnlMenuDepo.Controls.Add(this.btnSubMenuDepoKeluar);
            this.pnlMenuDepo.Controls.Add(this.btnSubMenuDepoMasuk);
            this.pnlMenuDepo.Controls.Add(this.btnMenuDepo);
            this.pnlMenuDepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuDepo.Location = new System.Drawing.Point(0, 140);
            this.pnlMenuDepo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuDepo.Name = "pnlMenuDepo";
            this.pnlMenuDepo.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuDepo.TabIndex = 16;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 245);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(210, 30);
            this.button11.TabIndex = 21;
            this.button11.Text = "    List Suku";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(0, 215);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(210, 30);
            this.button12.TabIndex = 20;
            this.button12.Text = "    List Gol. Darah";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(0, 185);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(210, 30);
            this.button13.TabIndex = 19;
            this.button13.Text = "    List RT";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(0, 155);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(210, 30);
            this.button14.TabIndex = 18;
            this.button14.Text = "    List RW";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(0, 125);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(210, 30);
            this.button15.TabIndex = 17;
            this.button15.Text = "    Stock Kontrol";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuDepoStockkontrol
            // 
            this.btnSubMenuDepoStockkontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuDepoStockkontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuDepoStockkontrol.FlatAppearance.BorderSize = 0;
            this.btnSubMenuDepoStockkontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuDepoStockkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuDepoStockkontrol.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuDepoStockkontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDepoStockkontrol.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuDepoStockkontrol.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuDepoStockkontrol.Name = "btnSubMenuDepoStockkontrol";
            this.btnSubMenuDepoStockkontrol.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuDepoStockkontrol.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuDepoStockkontrol.TabIndex = 16;
            this.btnSubMenuDepoStockkontrol.Text = "   Stock Kontrol";
            this.btnSubMenuDepoStockkontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDepoStockkontrol.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuDepoKeluar
            // 
            this.btnSubMenuDepoKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuDepoKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuDepoKeluar.FlatAppearance.BorderSize = 0;
            this.btnSubMenuDepoKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuDepoKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuDepoKeluar.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuDepoKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDepoKeluar.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuDepoKeluar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuDepoKeluar.Name = "btnSubMenuDepoKeluar";
            this.btnSubMenuDepoKeluar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuDepoKeluar.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuDepoKeluar.TabIndex = 15;
            this.btnSubMenuDepoKeluar.Text = "   Barang Keluar";
            this.btnSubMenuDepoKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDepoKeluar.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuDepoMasuk
            // 
            this.btnSubMenuDepoMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuDepoMasuk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuDepoMasuk.FlatAppearance.BorderSize = 0;
            this.btnSubMenuDepoMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuDepoMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuDepoMasuk.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuDepoMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDepoMasuk.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuDepoMasuk.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuDepoMasuk.Name = "btnSubMenuDepoMasuk";
            this.btnSubMenuDepoMasuk.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuDepoMasuk.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuDepoMasuk.TabIndex = 14;
            this.btnSubMenuDepoMasuk.Text = "   Barang Masuk";
            this.btnSubMenuDepoMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDepoMasuk.UseVisualStyleBackColor = false;
            // 
            // btnMenuDepo
            // 
            this.btnMenuDepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuDepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuDepo.FlatAppearance.BorderSize = 0;
            this.btnMenuDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDepo.ForeColor = System.Drawing.Color.White;
            this.btnMenuDepo.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuDepo.Image")));
            this.btnMenuDepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDepo.Location = new System.Drawing.Point(0, 0);
            this.btnMenuDepo.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDepo.Name = "btnMenuDepo";
            this.btnMenuDepo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuDepo.Size = new System.Drawing.Size(210, 35);
            this.btnMenuDepo.TabIndex = 13;
            this.btnMenuDepo.Text = "          Depo";
            this.btnMenuDepo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDepo.UseVisualStyleBackColor = false;
            this.btnMenuDepo.Click += new System.EventHandler(this.btnMenuDepo_Click);
            // 
            // pnlMenuGudang
            // 
            this.pnlMenuGudang.Controls.Add(this.button2);
            this.pnlMenuGudang.Controls.Add(this.button3);
            this.pnlMenuGudang.Controls.Add(this.button4);
            this.pnlMenuGudang.Controls.Add(this.button5);
            this.pnlMenuGudang.Controls.Add(this.button6);
            this.pnlMenuGudang.Controls.Add(this.btnSubMenuGudangStockkontrol);
            this.pnlMenuGudang.Controls.Add(this.btnSubMenuGudangKeluar);
            this.pnlMenuGudang.Controls.Add(this.btnSubMenuGudangMasuk);
            this.pnlMenuGudang.Controls.Add(this.btnMenuGudang);
            this.pnlMenuGudang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuGudang.Location = new System.Drawing.Point(0, 105);
            this.pnlMenuGudang.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuGudang.Name = "pnlMenuGudang";
            this.pnlMenuGudang.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuGudang.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 245);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(210, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "    List Suku";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 215);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(210, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "    List Gol. Darah";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 185);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(210, 30);
            this.button4.TabIndex = 19;
            this.button4.Text = "    List RT";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 155);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(210, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "    List RW";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 125);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(210, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "    Stock Kontrol";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuGudangStockkontrol
            // 
            this.btnSubMenuGudangStockkontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuGudangStockkontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuGudangStockkontrol.FlatAppearance.BorderSize = 0;
            this.btnSubMenuGudangStockkontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuGudangStockkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuGudangStockkontrol.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuGudangStockkontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuGudangStockkontrol.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuGudangStockkontrol.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuGudangStockkontrol.Name = "btnSubMenuGudangStockkontrol";
            this.btnSubMenuGudangStockkontrol.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuGudangStockkontrol.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuGudangStockkontrol.TabIndex = 16;
            this.btnSubMenuGudangStockkontrol.Text = "   Stock Kontrol";
            this.btnSubMenuGudangStockkontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuGudangStockkontrol.UseVisualStyleBackColor = false;
            this.btnSubMenuGudangStockkontrol.Click += new System.EventHandler(this.btnSubMenuGudangStockkontrol_Click);
            // 
            // btnSubMenuGudangKeluar
            // 
            this.btnSubMenuGudangKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuGudangKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuGudangKeluar.FlatAppearance.BorderSize = 0;
            this.btnSubMenuGudangKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuGudangKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuGudangKeluar.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuGudangKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuGudangKeluar.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuGudangKeluar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuGudangKeluar.Name = "btnSubMenuGudangKeluar";
            this.btnSubMenuGudangKeluar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuGudangKeluar.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuGudangKeluar.TabIndex = 15;
            this.btnSubMenuGudangKeluar.Text = "   Barang Keluar";
            this.btnSubMenuGudangKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuGudangKeluar.UseVisualStyleBackColor = false;
            this.btnSubMenuGudangKeluar.Click += new System.EventHandler(this.btnSubMenuGudangKeluar_Click);
            // 
            // btnSubMenuGudangMasuk
            // 
            this.btnSubMenuGudangMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuGudangMasuk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuGudangMasuk.FlatAppearance.BorderSize = 0;
            this.btnSubMenuGudangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuGudangMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuGudangMasuk.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuGudangMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuGudangMasuk.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuGudangMasuk.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuGudangMasuk.Name = "btnSubMenuGudangMasuk";
            this.btnSubMenuGudangMasuk.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuGudangMasuk.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuGudangMasuk.TabIndex = 14;
            this.btnSubMenuGudangMasuk.Text = "   Barang Masuk";
            this.btnSubMenuGudangMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuGudangMasuk.UseVisualStyleBackColor = false;
            this.btnSubMenuGudangMasuk.Click += new System.EventHandler(this.btnSubMenuGudangMasuk_Click);
            // 
            // btnMenuGudang
            // 
            this.btnMenuGudang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuGudang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuGudang.FlatAppearance.BorderSize = 0;
            this.btnMenuGudang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGudang.ForeColor = System.Drawing.Color.White;
            this.btnMenuGudang.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuGudang.Image")));
            this.btnMenuGudang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuGudang.Location = new System.Drawing.Point(0, 0);
            this.btnMenuGudang.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuGudang.Name = "btnMenuGudang";
            this.btnMenuGudang.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuGudang.Size = new System.Drawing.Size(210, 35);
            this.btnMenuGudang.TabIndex = 13;
            this.btnMenuGudang.Text = "          Gudang";
            this.btnMenuGudang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuGudang.UseVisualStyleBackColor = false;
            this.btnMenuGudang.Click += new System.EventHandler(this.btnMenuGudang_Click);
            // 
            // pnlMenuPembelian
            // 
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuViewSuku);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuViewGolDarah);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuViewRT);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuViewRW);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuViewStockKontrol);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuDistribusiDepo);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuDistribusiGudang);
            this.pnlMenuPembelian.Controls.Add(this.btnSubMenuPembelianMasuk);
            this.pnlMenuPembelian.Controls.Add(this.btnMenuPembelian);
            this.pnlMenuPembelian.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuPembelian.Location = new System.Drawing.Point(0, 70);
            this.pnlMenuPembelian.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuPembelian.Name = "pnlMenuPembelian";
            this.pnlMenuPembelian.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuPembelian.TabIndex = 14;
            // 
            // btnSubMenuViewSuku
            // 
            this.btnSubMenuViewSuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewSuku.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewSuku.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewSuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewSuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewSuku.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewSuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewSuku.Location = new System.Drawing.Point(0, 245);
            this.btnSubMenuViewSuku.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewSuku.Name = "btnSubMenuViewSuku";
            this.btnSubMenuViewSuku.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewSuku.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewSuku.TabIndex = 21;
            this.btnSubMenuViewSuku.Text = "    List Suku";
            this.btnSubMenuViewSuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewSuku.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuViewGolDarah
            // 
            this.btnSubMenuViewGolDarah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewGolDarah.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewGolDarah.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewGolDarah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewGolDarah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewGolDarah.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewGolDarah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewGolDarah.Location = new System.Drawing.Point(0, 215);
            this.btnSubMenuViewGolDarah.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewGolDarah.Name = "btnSubMenuViewGolDarah";
            this.btnSubMenuViewGolDarah.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewGolDarah.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewGolDarah.TabIndex = 20;
            this.btnSubMenuViewGolDarah.Text = "    List Gol. Darah";
            this.btnSubMenuViewGolDarah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewGolDarah.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuViewRT
            // 
            this.btnSubMenuViewRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewRT.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewRT.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewRT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewRT.Location = new System.Drawing.Point(0, 185);
            this.btnSubMenuViewRT.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewRT.Name = "btnSubMenuViewRT";
            this.btnSubMenuViewRT.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewRT.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewRT.TabIndex = 19;
            this.btnSubMenuViewRT.Text = "    List RT";
            this.btnSubMenuViewRT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewRT.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuViewRW
            // 
            this.btnSubMenuViewRW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewRW.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewRW.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewRW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewRW.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewRW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewRW.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenuViewRW.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewRW.Name = "btnSubMenuViewRW";
            this.btnSubMenuViewRW.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewRW.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewRW.TabIndex = 18;
            this.btnSubMenuViewRW.Text = "    List RW";
            this.btnSubMenuViewRW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewRW.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuViewStockKontrol
            // 
            this.btnSubMenuViewStockKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewStockKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewStockKontrol.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewStockKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewStockKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewStockKontrol.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewStockKontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewStockKontrol.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenuViewStockKontrol.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewStockKontrol.Name = "btnSubMenuViewStockKontrol";
            this.btnSubMenuViewStockKontrol.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewStockKontrol.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewStockKontrol.TabIndex = 17;
            this.btnSubMenuViewStockKontrol.Text = "    Stock Kontrol";
            this.btnSubMenuViewStockKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewStockKontrol.UseVisualStyleBackColor = false;
            this.btnSubMenuViewStockKontrol.Click += new System.EventHandler(this.btnSubMenuViewStockKontrol_Click);
            // 
            // btnSubMenuDistribusiDepo
            // 
            this.btnSubMenuDistribusiDepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuDistribusiDepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuDistribusiDepo.FlatAppearance.BorderSize = 0;
            this.btnSubMenuDistribusiDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuDistribusiDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuDistribusiDepo.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuDistribusiDepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDistribusiDepo.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuDistribusiDepo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuDistribusiDepo.Name = "btnSubMenuDistribusiDepo";
            this.btnSubMenuDistribusiDepo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuDistribusiDepo.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuDistribusiDepo.TabIndex = 16;
            this.btnSubMenuDistribusiDepo.Text = "   Depo";
            this.btnSubMenuDistribusiDepo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDistribusiDepo.UseVisualStyleBackColor = false;
            this.btnSubMenuDistribusiDepo.Click += new System.EventHandler(this.btnSubMenuDistribusiDepo_Click);
            // 
            // btnSubMenuDistribusiGudang
            // 
            this.btnSubMenuDistribusiGudang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuDistribusiGudang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuDistribusiGudang.FlatAppearance.BorderSize = 0;
            this.btnSubMenuDistribusiGudang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuDistribusiGudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuDistribusiGudang.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuDistribusiGudang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDistribusiGudang.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuDistribusiGudang.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuDistribusiGudang.Name = "btnSubMenuDistribusiGudang";
            this.btnSubMenuDistribusiGudang.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuDistribusiGudang.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuDistribusiGudang.TabIndex = 15;
            this.btnSubMenuDistribusiGudang.Text = "   Gudang";
            this.btnSubMenuDistribusiGudang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuDistribusiGudang.UseVisualStyleBackColor = false;
            this.btnSubMenuDistribusiGudang.Click += new System.EventHandler(this.btnSubMenuDistribusiGudang_Click);
            // 
            // btnSubMenuPembelianMasuk
            // 
            this.btnSubMenuPembelianMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuPembelianMasuk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuPembelianMasuk.FlatAppearance.BorderSize = 0;
            this.btnSubMenuPembelianMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuPembelianMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuPembelianMasuk.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuPembelianMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuPembelianMasuk.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuPembelianMasuk.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuPembelianMasuk.Name = "btnSubMenuPembelianMasuk";
            this.btnSubMenuPembelianMasuk.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuPembelianMasuk.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuPembelianMasuk.TabIndex = 14;
            this.btnSubMenuPembelianMasuk.Text = "   Barang Masuk";
            this.btnSubMenuPembelianMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuPembelianMasuk.UseVisualStyleBackColor = false;
            this.btnSubMenuPembelianMasuk.Click += new System.EventHandler(this.btnSubMenuPembelianMasuk_Click);
            // 
            // btnMenuPembelian
            // 
            this.btnMenuPembelian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuPembelian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPembelian.FlatAppearance.BorderSize = 0;
            this.btnMenuPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPembelian.ForeColor = System.Drawing.Color.White;
            this.btnMenuPembelian.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPembelian.Image")));
            this.btnMenuPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPembelian.Location = new System.Drawing.Point(0, 0);
            this.btnMenuPembelian.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPembelian.Name = "btnMenuPembelian";
            this.btnMenuPembelian.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuPembelian.Size = new System.Drawing.Size(210, 35);
            this.btnMenuPembelian.TabIndex = 13;
            this.btnMenuPembelian.Text = "          Pembelian";
            this.btnMenuPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPembelian.UseVisualStyleBackColor = false;
            this.btnMenuPembelian.Click += new System.EventHandler(this.btnMenuPembelian_Click);
            // 
            // pnlMenuBerkas
            // 
            this.pnlMenuBerkas.Controls.Add(this.btnSubMenuBerkasTransaksi);
            this.pnlMenuBerkas.Controls.Add(this.btnSubMenuRegistrasiListPasienIndikator);
            this.pnlMenuBerkas.Controls.Add(this.btnSubMenuRegistrasiListRegistrasiIndikator);
            this.pnlMenuBerkas.Controls.Add(this.btnSubMenuBerkasResep);
            this.pnlMenuBerkas.Controls.Add(this.pnlBtnMenuRegistrasi);
            this.pnlMenuBerkas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBerkas.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuBerkas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuBerkas.Name = "pnlMenuBerkas";
            this.pnlMenuBerkas.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuBerkas.TabIndex = 13;
            // 
            // btnSubMenuBerkasTransaksi
            // 
            this.btnSubMenuBerkasTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuBerkasTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuBerkasTransaksi.FlatAppearance.BorderSize = 0;
            this.btnSubMenuBerkasTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuBerkasTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuBerkasTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuBerkasTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuBerkasTransaksi.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuBerkasTransaksi.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuBerkasTransaksi.Name = "btnSubMenuBerkasTransaksi";
            this.btnSubMenuBerkasTransaksi.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuBerkasTransaksi.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuBerkasTransaksi.TabIndex = 15;
            this.btnSubMenuBerkasTransaksi.Text = "    Transaksi";
            this.btnSubMenuBerkasTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuBerkasTransaksi.UseVisualStyleBackColor = false;
            this.btnSubMenuBerkasTransaksi.Click += new System.EventHandler(this.btnSubMenuBerkasTransaksi_Click);
            // 
            // btnSubMenuRegistrasiListPasienIndikator
            // 
            this.btnSubMenuRegistrasiListPasienIndikator.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuRegistrasiListPasienIndikator.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuRegistrasiListPasienIndikator.Name = "btnSubMenuRegistrasiListPasienIndikator";
            this.btnSubMenuRegistrasiListPasienIndikator.Size = new System.Drawing.Size(5, 30);
            this.btnSubMenuRegistrasiListPasienIndikator.TabIndex = 19;
            // 
            // btnSubMenuRegistrasiListRegistrasiIndikator
            // 
            this.btnSubMenuRegistrasiListRegistrasiIndikator.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuRegistrasiListRegistrasiIndikator.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuRegistrasiListRegistrasiIndikator.Name = "btnSubMenuRegistrasiListRegistrasiIndikator";
            this.btnSubMenuRegistrasiListRegistrasiIndikator.Size = new System.Drawing.Size(5, 30);
            this.btnSubMenuRegistrasiListRegistrasiIndikator.TabIndex = 18;
            // 
            // btnSubMenuBerkasResep
            // 
            this.btnSubMenuBerkasResep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuBerkasResep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuBerkasResep.FlatAppearance.BorderSize = 0;
            this.btnSubMenuBerkasResep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuBerkasResep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuBerkasResep.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuBerkasResep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuBerkasResep.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuBerkasResep.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuBerkasResep.Name = "btnSubMenuBerkasResep";
            this.btnSubMenuBerkasResep.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuBerkasResep.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuBerkasResep.TabIndex = 14;
            this.btnSubMenuBerkasResep.Text = "    Resep";
            this.btnSubMenuBerkasResep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuBerkasResep.UseVisualStyleBackColor = false;
            this.btnSubMenuBerkasResep.Click += new System.EventHandler(this.btnSubMenuBerkasResep_Click);
            // 
            // pnlBtnMenuRegistrasi
            // 
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuRegistrasiIndikator);
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuBerkas);
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuRegistrasiIcon);
            this.pnlBtnMenuRegistrasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBtnMenuRegistrasi.Location = new System.Drawing.Point(0, 0);
            this.pnlBtnMenuRegistrasi.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBtnMenuRegistrasi.Name = "pnlBtnMenuRegistrasi";
            this.pnlBtnMenuRegistrasi.Size = new System.Drawing.Size(210, 35);
            this.pnlBtnMenuRegistrasi.TabIndex = 16;
            // 
            // btnMenuRegistrasiIndikator
            // 
            this.btnMenuRegistrasiIndikator.Location = new System.Drawing.Point(0, 0);
            this.btnMenuRegistrasiIndikator.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuRegistrasiIndikator.Name = "btnMenuRegistrasiIndikator";
            this.btnMenuRegistrasiIndikator.Size = new System.Drawing.Size(5, 35);
            this.btnMenuRegistrasiIndikator.TabIndex = 17;
            // 
            // btnMenuBerkas
            // 
            this.btnMenuBerkas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuBerkas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuBerkas.FlatAppearance.BorderSize = 0;
            this.btnMenuBerkas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBerkas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBerkas.ForeColor = System.Drawing.Color.White;
            this.btnMenuBerkas.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBerkas.Image")));
            this.btnMenuBerkas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBerkas.Location = new System.Drawing.Point(0, 0);
            this.btnMenuBerkas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuBerkas.Name = "btnMenuBerkas";
            this.btnMenuBerkas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuBerkas.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBerkas.TabIndex = 16;
            this.btnMenuBerkas.Text = "          Berkas";
            this.btnMenuBerkas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBerkas.UseVisualStyleBackColor = false;
            this.btnMenuBerkas.Click += new System.EventHandler(this.btnMenuBerkas_Click);
            // 
            // btnMenuRegistrasiIcon
            // 
            this.btnMenuRegistrasiIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuRegistrasiIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenuRegistrasiIcon.FlatAppearance.BorderSize = 0;
            this.btnMenuRegistrasiIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistrasiIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistrasiIcon.ForeColor = System.Drawing.Color.White;
            this.btnMenuRegistrasiIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRegistrasiIcon.Location = new System.Drawing.Point(186, 0);
            this.btnMenuRegistrasiIcon.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuRegistrasiIcon.Name = "btnMenuRegistrasiIcon";
            this.btnMenuRegistrasiIcon.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnMenuRegistrasiIcon.Size = new System.Drawing.Size(24, 35);
            this.btnMenuRegistrasiIcon.TabIndex = 15;
            this.btnMenuRegistrasiIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuRegistrasiIcon.UseVisualStyleBackColor = false;
            this.btnMenuRegistrasiIcon.Visible = false;
            // 
            // ucIndikatorKlikMenu1
            // 
            this.ucIndikatorKlikMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucIndikatorKlikMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.ucIndikatorKlikMenu1.Name = "ucIndikatorKlikMenu1";
            this.ucIndikatorKlikMenu1.Size = new System.Drawing.Size(5, 35);
            this.ucIndikatorKlikMenu1.TabIndex = 5;
            // 
            // btnMenuHome
            // 
            this.btnMenuHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuHome.FlatAppearance.BorderSize = 0;
            this.btnMenuHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHome.ForeColor = System.Drawing.Color.White;
            this.btnMenuHome.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuHome.Image")));
            this.btnMenuHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHome.Location = new System.Drawing.Point(0, 0);
            this.btnMenuHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuHome.Name = "btnMenuHome";
            this.btnMenuHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuHome.Size = new System.Drawing.Size(210, 35);
            this.btnMenuHome.TabIndex = 12;
            this.btnMenuHome.Text = "          Home";
            this.btnMenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHome.UseVisualStyleBackColor = false;
            this.btnMenuHome.Click += new System.EventHandler(this.btnMenuHome_Click);
            // 
            // TFMainMenuFarmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TFMainMenuFarmasi";
            this.pnlPicUser.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            this.pnlRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserShow.Properties)).EndInit();
            this.pnlSlideMenu.ResumeLayout(false);
            this.pnlMenuLaporan.ResumeLayout(false);
            this.pnlMenuMaster.ResumeLayout(false);
            this.pnlMenuDepo.ResumeLayout(false);
            this.pnlMenuGudang.ResumeLayout(false);
            this.pnlMenuPembelian.ResumeLayout(false);
            this.pnlMenuBerkas.ResumeLayout(false);
            this.pnlBtnMenuRegistrasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        protected virtual void btnMenuHome_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FHomeFarmasi myForm = new FHomeFarmasi();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void btnMenuBerkas_Click(object sender, EventArgs e)
        {
            if (pnlMenuBerkas.Height == btnMenuBerkas.Height)
            {
                pnlMenuBerkas.Height = (btnMenuBerkas.Height * 3) - 10;

                btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuBerkas.Height = btnMenuBerkas.Height;
                btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnMenuMaster_Click(object sender, EventArgs e)
        {
            if (pnlMenuMaster.Height == btnMenuMaster.Height)
            {
                pnlMenuMaster.Height = (btnMenuMaster.Height * 6) - 25;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuMaster.Height = btnMenuMaster.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnMenuLaporan_Click(object sender, EventArgs e)
        {
            if (pnlMenuLaporan.Height == btnMenuLaporan.Height)
            {
                pnlMenuLaporan.Height = (btnMenuLaporan.Height * 3) - 10;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuLaporan.Height = btnMenuLaporan.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnSubMenuBerkasResep_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuBerkasTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuDistribusiDepo_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuDistribusiGudang_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuMasterDepo_Click(object sender, EventArgs e)// master depo
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListDepo myForm = new FListDepo(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubMenuMasterObat_Click(object sender, EventArgs e)//master obat
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarang myForm = new FListBarang(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubMenuMasterSatuan_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListSatuan myForm = new FListSatuan(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubMenuMasterPBF_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListPBF myForm = new FListPBF(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubMenuDistribusiPembelian_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuViewStockKontrol_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuPembelianMasuk_Click(object sender, EventArgs e)
        {

            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuPembelian_Click(object sender, EventArgs e)
        {
            if (pnlMenuPembelian.Height == btnMenuPembelian.Height)
            {
                pnlMenuPembelian.Height = (btnMenuPembelian.Height * 2) - 5;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuPembelian.Height = btnMenuPembelian.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnMenuGudang_Click(object sender, EventArgs e)
        {
            if (pnlMenuGudang.Height == btnMenuGudang.Height)
            {
                pnlMenuGudang.Height = (btnMenuGudang.Height * 4) - 15;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuGudang.Height = btnMenuGudang.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnMenuDepo_Click(object sender, EventArgs e)
        {
            if (pnlMenuDepo.Height == btnMenuDepo.Height)
            {
                pnlMenuDepo.Height = (btnMenuDepo.Height * 3) - 10;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuDepo.Height = btnMenuDepo.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnSubMenuGudangMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                FListBarangMasukGudang2 myForm = new FListBarangMasukGudang2(ref this.pnlContent);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubMenuGudangKeluar_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarangKeluar myForm = new FListBarangKeluar(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubMenuGudangStockkontrol_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                FListStockOP myForm = new FListStockOP(ref this.pnlContent);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "btnSubMenuGudangStockkontrol_Click()",this.Name,this);
            }
        }

        private void btnSubMenuMasterDefObatSatuan_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListObatSatuan myForm = new FListObatSatuan(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void BtnLogout_Click(object sender, EventArgs e)
        {
            bool isLogout = false;
            try
            {

                using (FDialogLogoutFarmasi f = new FDialogLogoutFarmasi("Apakah akan Log Out"))
                {

                    f.StartPosition = FormStartPosition.Manual;
                    //f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (f.Width+this.btnLogout.Left)  ,
                    //    this.pnlHeader.Height);

                    f.Location = new Point(this.btnLogout.Left - f.Width,
                        this.pnlHeader.Height);


                    //create an overlay form
                    XtraForm overlayForm = new XtraForm();
                    overlayForm.StartPosition = this.StartPosition; // FormStartPosition.CenterScreen; //this.StartPosition;
                    overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                    overlayForm.Opacity = .80d;
                    overlayForm.BackColor = Color.Black;
                    overlayForm.Size = Screen.PrimaryScreen.WorkingArea.Size;// base.Size; //(this as FListRegistrasiRI).Activate.Size; //mainmenu.Size;// this.Size;
                    overlayForm.Location = Screen.PrimaryScreen.WorkingArea.Location; //base.Location;// FMainMenuRI.ActiveForm.Location; //mainmenu.Location;// this.Location;
                                                                                      //overlayForm.Size = this.Size;
                                                                                      //overlayForm.Location =  this.Location;

                    overlayForm.ShowInTaskbar = false;
                    overlayForm.Show();

                    //Show the dialog
                    f.Owner = overlayForm;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        isLogout = true;

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();

                    if (isLogout)
                    {

                        this.DialogResult = DialogResult.No;



                    }


                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message, this);
            }


        }

    }
}
