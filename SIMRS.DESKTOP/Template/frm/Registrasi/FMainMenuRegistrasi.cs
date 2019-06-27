
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Registrasi
{
    public class FMainMenuRegistrasi : TFMainMenu
    {
        #region private

        protected Template.uc.ucIndikatorKlikMenu ucIndikatorKlikMenu1;
        protected Button btnMenuHome;
        protected Panel pnlMenuRegistrasi;
        protected Button btnSubMenuRegistrasiListRegistrasi;
        protected Button btnSubMenuRegistrasiListPasien;
        protected Panel pnlMenuView;
        protected Button btnSubMenuViewSuku;
        protected Button btnSubMenuViewGolDarah;
        protected Button btnSubMenuViewRT;
        protected Button btnSubMenuViewRW;
        protected Button btnSubMenuViewKelurahan;
        protected Button btnSubMenuViewKecamatan;
        protected Button btnSubMenuViewPenjamin;
        protected Button btnSubMenuViewPoliklinik;
        protected Button btnMenuView;
        protected Panel pnlMenuLaporan;
        protected Button btnSubMenuLaporan1;
        protected Button btnMenuLaporan;
        protected Panel pnlBtnMenuRegistrasi;
        protected Button btnMenuRegistrasi;
        protected Button btnMenuRegistrasiIcon;
        protected Template.uc.ucIndikatorKlikMenu btnMenuRegistrasiIndikator;
        protected Template.uc.ucIndikatorKlikMenu btnSubMenuRegistrasiListRegistrasiIndikator;
        protected Template.uc.ucIndikatorKlikMenu btnSubMenuRegistrasiListPasienIndikator;
        protected Button btnSubMenuLaporan5;
        protected Button btnSubMenuLaporan4;
        protected Button btnSubMenuLaporan3;
        protected Button btnSubMenuLaporan2;
        protected System.Windows.Forms.Panel pnlSlideMenu;

        #endregion


        #region private methode

        protected void defaultSetIconSubMenu()
        {
            btnMenuRegistrasiIcon.Image = Properties.Resources.back;

            btnSubMenuRegistrasiListRegistrasi.Image = Properties.Resources.circled;
            btnSubMenuRegistrasiListPasien.Image = Properties.Resources.circled;
            //btnMenuView.Image = Properties.Resources.back;

            btnSubMenuLaporan1.Image = Properties.Resources.circled;
            btnSubMenuRegistrasiListPasien.Image = Properties.Resources.circled;
            btnSubMenuRegistrasiListRegistrasi.Image = Properties.Resources.circled;
            btnSubMenuViewGolDarah.Image = Properties.Resources.circled;
            btnSubMenuViewKecamatan.Image = Properties.Resources.circled;
            btnSubMenuViewKelurahan.Image = Properties.Resources.circled;
            btnSubMenuViewPenjamin.Image = Properties.Resources.circled;
            btnSubMenuViewPoliklinik.Image = Properties.Resources.circled;
            btnSubMenuViewRT.Image = Properties.Resources.circled;
            btnSubMenuViewRW.Image = Properties.Resources.circled;
            btnSubMenuViewSuku.Image = Properties.Resources.circled;


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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenuRegistrasi));
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.pnlMenuLaporan = new System.Windows.Forms.Panel();
            this.btnSubMenuLaporan5 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan4 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan3 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan2 = new System.Windows.Forms.Button();
            this.btnSubMenuLaporan1 = new System.Windows.Forms.Button();
            this.btnMenuLaporan = new System.Windows.Forms.Button();
            this.pnlMenuView = new System.Windows.Forms.Panel();
            this.btnSubMenuViewSuku = new System.Windows.Forms.Button();
            this.btnSubMenuViewGolDarah = new System.Windows.Forms.Button();
            this.btnSubMenuViewRT = new System.Windows.Forms.Button();
            this.btnSubMenuViewRW = new System.Windows.Forms.Button();
            this.btnSubMenuViewKelurahan = new System.Windows.Forms.Button();
            this.btnSubMenuViewKecamatan = new System.Windows.Forms.Button();
            this.btnSubMenuViewPenjamin = new System.Windows.Forms.Button();
            this.btnSubMenuViewPoliklinik = new System.Windows.Forms.Button();
            this.btnMenuView = new System.Windows.Forms.Button();
            this.pnlMenuRegistrasi = new System.Windows.Forms.Panel();
            this.btnSubMenuRegistrasiListRegistrasi = new System.Windows.Forms.Button();
            this.btnSubMenuRegistrasiListPasienIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnSubMenuRegistrasiListRegistrasiIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnSubMenuRegistrasiListPasien = new System.Windows.Forms.Button();
            this.pnlBtnMenuRegistrasi = new System.Windows.Forms.Panel();
            this.btnMenuRegistrasiIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnMenuRegistrasi = new System.Windows.Forms.Button();
            this.btnMenuRegistrasiIcon = new System.Windows.Forms.Button();
            this.ucIndikatorKlikMenu1 = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnMenuHome = new System.Windows.Forms.Button();
            this.pnlPicUser.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            this.pnlRoot.SuspendLayout();
            this.pnlSlideMenu.SuspendLayout();
            this.pnlMenuLaporan.SuspendLayout();
            this.pnlMenuView.SuspendLayout();
            this.pnlMenuRegistrasi.SuspendLayout();
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
            this.mlblTitleHeader.Size = new System.Drawing.Size(478, 33);
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
            this.lbljam.Text = "14:32:32";
            // 
            // lblTgl
            // 
            this.lblTgl.Location = new System.Drawing.Point(309, 0);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(590, 540);
            // 
            // pnlSlideMenu
            // 
            this.pnlSlideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSlideMenu.AutoScroll = true;
            this.pnlSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlSlideMenu.Controls.Add(this.pnlMenuLaporan);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuView);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuRegistrasi);
            this.pnlSlideMenu.Controls.Add(this.ucIndikatorKlikMenu1);
            this.pnlSlideMenu.Controls.Add(this.btnMenuHome);
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 195);
            this.pnlSlideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(210, 372);
            this.pnlSlideMenu.TabIndex = 5;
            // 
            // pnlMenuLaporan
            // 
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan5);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan4);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan3);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan2);
            this.pnlMenuLaporan.Controls.Add(this.btnSubMenuLaporan1);
            this.pnlMenuLaporan.Controls.Add(this.btnMenuLaporan);
            this.pnlMenuLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuLaporan.Location = new System.Drawing.Point(0, 105);
            this.pnlMenuLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuLaporan.Name = "pnlMenuLaporan";
            this.pnlMenuLaporan.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuLaporan.TabIndex = 15;
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
            this.btnSubMenuLaporan5.Click += new System.EventHandler(this.btnSubMenuLaporan5_Click);
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
            this.btnSubMenuLaporan4.Click += new System.EventHandler(this.btnSubMenuLaporan4_Click);
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
            this.btnSubMenuLaporan3.Click += new System.EventHandler(this.btnSubMenuLaporan3_Click);
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
            this.btnSubMenuLaporan2.Text = "    Laporan 2";
            this.btnSubMenuLaporan2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan2.UseVisualStyleBackColor = false;
            this.btnSubMenuLaporan2.Click += new System.EventHandler(this.btnSubMenuLaporan2_Click);
            // 
            // btnSubMenuLaporan1
            // 
            this.btnSubMenuLaporan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuLaporan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuLaporan1.FlatAppearance.BorderSize = 0;
            this.btnSubMenuLaporan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuLaporan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuLaporan1.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuLaporan1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan1.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuLaporan1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuLaporan1.Name = "btnSubMenuLaporan1";
            this.btnSubMenuLaporan1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuLaporan1.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuLaporan1.TabIndex = 14;
            this.btnSubMenuLaporan1.Text = "    Laporan 1";
            this.btnSubMenuLaporan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuLaporan1.UseVisualStyleBackColor = false;
            this.btnSubMenuLaporan1.Click += new System.EventHandler(this.btnSubMenuLaporan1_Click);
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
            // pnlMenuView
            // 
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewSuku);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewGolDarah);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewRT);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewRW);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewKelurahan);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewKecamatan);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewPenjamin);
            this.pnlMenuView.Controls.Add(this.btnSubMenuViewPoliklinik);
            this.pnlMenuView.Controls.Add(this.btnMenuView);
            this.pnlMenuView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuView.Location = new System.Drawing.Point(0, 70);
            this.pnlMenuView.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuView.Name = "pnlMenuView";
            this.pnlMenuView.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuView.TabIndex = 14;
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
            this.btnSubMenuViewRW.Click += new System.EventHandler(this.btnSubMenuViewRW_Click);
            // 
            // btnSubMenuViewKelurahan
            // 
            this.btnSubMenuViewKelurahan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewKelurahan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewKelurahan.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewKelurahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewKelurahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewKelurahan.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewKelurahan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewKelurahan.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenuViewKelurahan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewKelurahan.Name = "btnSubMenuViewKelurahan";
            this.btnSubMenuViewKelurahan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewKelurahan.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewKelurahan.TabIndex = 17;
            this.btnSubMenuViewKelurahan.Text = "    List Kelurahan";
            this.btnSubMenuViewKelurahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewKelurahan.UseVisualStyleBackColor = false;
            this.btnSubMenuViewKelurahan.Click += new System.EventHandler(this.btnSubMenuViewKelurahan_Click);
            // 
            // btnSubMenuViewKecamatan
            // 
            this.btnSubMenuViewKecamatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewKecamatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewKecamatan.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewKecamatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewKecamatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewKecamatan.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewKecamatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewKecamatan.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuViewKecamatan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewKecamatan.Name = "btnSubMenuViewKecamatan";
            this.btnSubMenuViewKecamatan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewKecamatan.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewKecamatan.TabIndex = 16;
            this.btnSubMenuViewKecamatan.Text = "    List Kecamatan";
            this.btnSubMenuViewKecamatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewKecamatan.UseVisualStyleBackColor = false;
            this.btnSubMenuViewKecamatan.Click += new System.EventHandler(this.btnSubMenuViewKecamatan_Click);
            // 
            // btnSubMenuViewPenjamin
            // 
            this.btnSubMenuViewPenjamin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewPenjamin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewPenjamin.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewPenjamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewPenjamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewPenjamin.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewPenjamin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewPenjamin.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuViewPenjamin.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewPenjamin.Name = "btnSubMenuViewPenjamin";
            this.btnSubMenuViewPenjamin.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewPenjamin.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewPenjamin.TabIndex = 15;
            this.btnSubMenuViewPenjamin.Text = "    List Penjamin";
            this.btnSubMenuViewPenjamin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewPenjamin.UseVisualStyleBackColor = false;
            this.btnSubMenuViewPenjamin.Click += new System.EventHandler(this.btnSubMenuViewPenjamin_Click);
            // 
            // btnSubMenuViewPoliklinik
            // 
            this.btnSubMenuViewPoliklinik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuViewPoliklinik.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuViewPoliklinik.FlatAppearance.BorderSize = 0;
            this.btnSubMenuViewPoliklinik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuViewPoliklinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuViewPoliklinik.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuViewPoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewPoliklinik.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuViewPoliklinik.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuViewPoliklinik.Name = "btnSubMenuViewPoliklinik";
            this.btnSubMenuViewPoliklinik.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuViewPoliklinik.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuViewPoliklinik.TabIndex = 14;
            this.btnSubMenuViewPoliklinik.Text = "   List Poliklinik";
            this.btnSubMenuViewPoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuViewPoliklinik.UseVisualStyleBackColor = false;
            this.btnSubMenuViewPoliklinik.Click += new System.EventHandler(this.btnSubMenuViewPoliklinik_Click);
            // 
            // btnMenuView
            // 
            this.btnMenuView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuView.FlatAppearance.BorderSize = 0;
            this.btnMenuView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuView.ForeColor = System.Drawing.Color.White;
            this.btnMenuView.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuView.Image")));
            this.btnMenuView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuView.Location = new System.Drawing.Point(0, 0);
            this.btnMenuView.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuView.Name = "btnMenuView";
            this.btnMenuView.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuView.Size = new System.Drawing.Size(210, 35);
            this.btnMenuView.TabIndex = 13;
            this.btnMenuView.Text = "          View";
            this.btnMenuView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuView.UseVisualStyleBackColor = false;
            this.btnMenuView.Click += new System.EventHandler(this.btnMenuView_Click);
            // 
            // pnlMenuRegistrasi
            // 
            this.pnlMenuRegistrasi.Controls.Add(this.btnSubMenuRegistrasiListRegistrasi);
            this.pnlMenuRegistrasi.Controls.Add(this.btnSubMenuRegistrasiListPasienIndikator);
            this.pnlMenuRegistrasi.Controls.Add(this.btnSubMenuRegistrasiListRegistrasiIndikator);
            this.pnlMenuRegistrasi.Controls.Add(this.btnSubMenuRegistrasiListPasien);
            this.pnlMenuRegistrasi.Controls.Add(this.pnlBtnMenuRegistrasi);
            this.pnlMenuRegistrasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuRegistrasi.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuRegistrasi.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuRegistrasi.Name = "pnlMenuRegistrasi";
            this.pnlMenuRegistrasi.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuRegistrasi.TabIndex = 13;
            // 
            // btnSubMenuRegistrasiListRegistrasi
            // 
            this.btnSubMenuRegistrasiListRegistrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuRegistrasiListRegistrasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuRegistrasiListRegistrasi.FlatAppearance.BorderSize = 0;
            this.btnSubMenuRegistrasiListRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuRegistrasiListRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuRegistrasiListRegistrasi.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuRegistrasiListRegistrasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuRegistrasiListRegistrasi.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuRegistrasiListRegistrasi.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuRegistrasiListRegistrasi.Name = "btnSubMenuRegistrasiListRegistrasi";
            this.btnSubMenuRegistrasiListRegistrasi.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuRegistrasiListRegistrasi.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuRegistrasiListRegistrasi.TabIndex = 15;
            this.btnSubMenuRegistrasiListRegistrasi.Text = "    List Registrasi";
            this.btnSubMenuRegistrasiListRegistrasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuRegistrasiListRegistrasi.UseVisualStyleBackColor = false;
            this.btnSubMenuRegistrasiListRegistrasi.Click += new System.EventHandler(this.btnSubMenuRegistrasiListRegistrasi_Click);
            this.btnSubMenuRegistrasiListRegistrasi.MouseLeave += new System.EventHandler(this.btnSubMenuRegistrasiListRegistrasi_MouseLeave);
            this.btnSubMenuRegistrasiListRegistrasi.MouseHover += new System.EventHandler(this.btnSubMenuRegistrasiListRegistrasi_MouseHover);
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
            // btnSubMenuRegistrasiListPasien
            // 
            this.btnSubMenuRegistrasiListPasien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuRegistrasiListPasien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuRegistrasiListPasien.FlatAppearance.BorderSize = 0;
            this.btnSubMenuRegistrasiListPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuRegistrasiListPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuRegistrasiListPasien.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuRegistrasiListPasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuRegistrasiListPasien.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuRegistrasiListPasien.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuRegistrasiListPasien.Name = "btnSubMenuRegistrasiListPasien";
            this.btnSubMenuRegistrasiListPasien.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuRegistrasiListPasien.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuRegistrasiListPasien.TabIndex = 14;
            this.btnSubMenuRegistrasiListPasien.Text = "    List Pasien";
            this.btnSubMenuRegistrasiListPasien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuRegistrasiListPasien.UseVisualStyleBackColor = false;
            this.btnSubMenuRegistrasiListPasien.Click += new System.EventHandler(this.btnSubMenuRegistrasiListPasien_Click);
            this.btnSubMenuRegistrasiListPasien.MouseLeave += new System.EventHandler(this.btnSubMenuRegistrasiListPasien_MouseLeave);
            this.btnSubMenuRegistrasiListPasien.MouseHover += new System.EventHandler(this.btnSubMenuRegistrasiListPasien_MouseHover);
            // 
            // pnlBtnMenuRegistrasi
            // 
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuRegistrasiIndikator);
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuRegistrasi);
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
            // btnMenuRegistrasi
            // 
            this.btnMenuRegistrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuRegistrasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuRegistrasi.FlatAppearance.BorderSize = 0;
            this.btnMenuRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistrasi.ForeColor = System.Drawing.Color.White;
            this.btnMenuRegistrasi.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuRegistrasi.Image")));
            this.btnMenuRegistrasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRegistrasi.Location = new System.Drawing.Point(0, 0);
            this.btnMenuRegistrasi.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuRegistrasi.Name = "btnMenuRegistrasi";
            this.btnMenuRegistrasi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuRegistrasi.Size = new System.Drawing.Size(186, 35);
            this.btnMenuRegistrasi.TabIndex = 16;
            this.btnMenuRegistrasi.Text = "          Registrasi";
            this.btnMenuRegistrasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRegistrasi.UseVisualStyleBackColor = false;
            this.btnMenuRegistrasi.Click += new System.EventHandler(this.btnMenuRegistrasi_Click);
            this.btnMenuRegistrasi.MouseLeave += new System.EventHandler(this.btnMenuRegistrasi_MouseLeave);
            this.btnMenuRegistrasi.MouseHover += new System.EventHandler(this.btnMenuRegistrasi_MouseHover);
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
            this.btnMenuRegistrasiIcon.Click += new System.EventHandler(this.btnMenuRegistrasiIcon_Click);
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
            this.btnMenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
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
            this.btnMenuHome.Click += new System.EventHandler(this.btnDasboard_Click);
            this.btnMenuHome.MouseLeave += new System.EventHandler(this.btnDasboard_MouseLeave);
            this.btnMenuHome.MouseHover += new System.EventHandler(this.btnDasboard_MouseHover);
            // 
            // FMainMenuRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FMainMenuRegistrasi";
            this.pnlPicUser.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            this.pnlRoot.ResumeLayout(false);
            this.pnlSlideMenu.ResumeLayout(false);
            this.pnlMenuLaporan.ResumeLayout(false);
            this.pnlMenuView.ResumeLayout(false);
            this.pnlMenuRegistrasi.ResumeLayout(false);
            this.pnlBtnMenuRegistrasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public FMainMenuRegistrasi(): base()
        {
            InitializeComponent();
            ucIndikatorKlikMenu1.Visible = false;
            ucIndikatorKlikMenu1.Location = btnMenuHome.Location;

            btnMenuRegistrasiIndikator.Visible = false;

            btnSubMenuRegistrasiListRegistrasiIndikator.Visible = false;
            btnSubMenuRegistrasiListPasienIndikator.Visible = false;
            //btnMenuView.Image = Properties.Resources.back;


            defaultSetIconSubMenu();
            btnDasboard_Click(null, null);

            //this.mlblTitleHeader.Text = Helper.Modul.modulname;

        }


        private void btnDasboard_MouseHover(object sender, EventArgs e)
        {
            ucIndikatorKlikMenu1.Location = btnMenuHome.Location;
            ucIndikatorKlikMenu1.Visible = true;
            PanelSlideMouseHover();
        }

        private void btnDasboard_MouseLeave(object sender, EventArgs e)
        {
            ucIndikatorKlikMenu1.Location = btnMenuHome.Location;
            ucIndikatorKlikMenu1.Visible = false;
            PanelSlideMouseLeave();

        }

        protected virtual void btnDasboard_Click(object sender, EventArgs e)
        {


        }

        protected virtual void btnMenuRegistrasi_Click(object sender, EventArgs e)
        {
            if (pnlMenuRegistrasi.Height == btnMenuRegistrasi.Height)
            {
                pnlMenuRegistrasi.Height = (btnMenuRegistrasi.Height * 3) - 10;
                
                btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuRegistrasi.Height = btnMenuRegistrasi.Height;
                btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnMenuRegistrasiIcon_Click(object sender, EventArgs e)
        {
            btnMenuRegistrasi_Click(sender, e);
        }

        private void btnMenuRegistrasi_MouseHover(object sender, EventArgs e)
        {
            btnMenuRegistrasiIndikator.Location = btnMenuRegistrasi.Location;
            btnMenuRegistrasiIndikator.Visible = true;
            PanelSlideMouseHover();
        }

        private void btnMenuRegistrasi_MouseLeave(object sender, EventArgs e)
        {
            btnMenuRegistrasiIndikator.Location = btnMenuRegistrasi.Location;
            btnMenuRegistrasiIndikator.Visible = false;
            PanelSlideMouseLeave();
        }

        private void btnSubMenuRegistrasiListRegistrasi_MouseHover(object sender, EventArgs e)
        {
            btnSubMenuRegistrasiListRegistrasiIndikator.Location = btnSubMenuRegistrasiListRegistrasi.Location;
            btnSubMenuRegistrasiListRegistrasiIndikator.Visible = true;
            PanelSlideMouseHover();
        }

        private void btnSubMenuRegistrasiListRegistrasi_MouseLeave(object sender, EventArgs e)
        {
            btnSubMenuRegistrasiListRegistrasiIndikator.Location = btnSubMenuRegistrasiListRegistrasi.Location;
            btnSubMenuRegistrasiListRegistrasiIndikator.Visible = false;
            PanelSlideMouseLeave();
        }

        private void btnSubMenuRegistrasiListPasien_MouseHover(object sender, EventArgs e)
        {
            btnSubMenuRegistrasiListPasienIndikator.Location = btnSubMenuRegistrasiListPasien.Location;
            btnSubMenuRegistrasiListPasienIndikator.Visible = true;
            PanelSlideMouseHover();
        }

        private void btnSubMenuRegistrasiListPasien_MouseLeave(object sender, EventArgs e)
        {
            btnSubMenuRegistrasiListPasienIndikator.Location = btnSubMenuRegistrasiListPasien.Location;
            btnSubMenuRegistrasiListPasienIndikator.Visible = false;
            PanelSlideMouseLeave();
        }

        protected virtual void btnMenuView_Click(object sender, EventArgs e)
        {
            if (pnlMenuView.Height == btnMenuView.Height)
            {
                pnlMenuView.Height = (btnMenuView.Height * 5) - 20;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuView.Height = btnMenuView.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        protected virtual void btnMenuLaporan_Click(object sender, EventArgs e)
        {
            if (pnlMenuLaporan.Height == btnMenuLaporan.Height)
            {
                pnlMenuLaporan.Height = (btnMenuLaporan.Height * 2) - 5;

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

        protected virtual void btnSubMenuRegistrasiListPasien_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuRegistrasiListRegistrasi_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuViewPoliklinik_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuViewPenjamin_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuViewKecamatan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuViewKelurahan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuViewRW_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuLaporan1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuLaporan2_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuLaporan3_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuLaporan4_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSubMenuLaporan5_Click(object sender, EventArgs e)
        {

        }
    }
}
