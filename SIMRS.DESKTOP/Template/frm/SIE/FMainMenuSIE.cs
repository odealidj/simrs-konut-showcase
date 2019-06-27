using DevExpress.XtraEditors;
using SIMRS.DESKTOP.FrontEnd.SIE;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.SIE.Pendapatan;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.SIE
{
    public class FMainMenuSIE : TFMainMenu
    {
        protected System.Windows.Forms.Panel pnlSlideMenu;
        protected System.Windows.Forms.Panel pnlMenuIndikator;
        protected System.Windows.Forms.Button btnSubMenuIndikator5;
        protected System.Windows.Forms.Button btnSubMenuIndikator4;
        protected System.Windows.Forms.Button btnSubMenuIndikator3;
        protected System.Windows.Forms.Button btnSubMenuIndikator2;
        protected System.Windows.Forms.Button btnSubMenuIndikator1;
        protected System.Windows.Forms.Button btnMenuIndikator;
        protected System.Windows.Forms.Panel pnlMenuKunjungan;
        protected System.Windows.Forms.Button btnSubMenuViewSuku;
        protected System.Windows.Forms.Button btnSubMenuViewGolDarah;
        protected System.Windows.Forms.Button btnSubMenuKunjungan6;
        protected System.Windows.Forms.Button btnSubMenuKunjungan5;
        protected System.Windows.Forms.Button btnSubMenuKunjungan4;
        protected System.Windows.Forms.Button btnSubMenuKunjungan3;
        protected System.Windows.Forms.Button btnSubMenuKunjungan2;
        protected System.Windows.Forms.Button btnSubMenuKunjungan1;
        protected System.Windows.Forms.Button btnMenuKunjungan;
        protected System.Windows.Forms.Panel pnlMenuPendapatan;
        protected System.Windows.Forms.Button btnSubMenubtnMenuPendapatan2;
        protected uc.ucIndikatorKlikMenu btnSubMenuRegistrasiListPasienIndikator;
        protected uc.ucIndikatorKlikMenu btnSubMenuRegistrasiListRegistrasiIndikator;
        protected System.Windows.Forms.Button btnSubMenubtnMenuPendapatan1;
        protected System.Windows.Forms.Panel pnlBtnMenuRegistrasi;
        protected uc.ucIndikatorKlikMenu btnMenuRegistrasiIndikator;
        protected System.Windows.Forms.Button btnMenuPendapatan;
        protected uc.ucIndikatorKlikMenu ucIndikatorKlikMenu1;
        protected System.Windows.Forms.Button btnSubMenubtnMenuPendapatan6;
        protected System.Windows.Forms.Button btnSubMenubtnMenuPendapatan5;
        protected System.Windows.Forms.Button btnSubMenubtnMenuPendapatan4;
        protected System.Windows.Forms.Button btnSubMenubtnMenuPendapatan3;
        protected System.Windows.Forms.Button btnMenuDashboard;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenuSIE));
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.pnlMenuIndikator = new System.Windows.Forms.Panel();
            this.btnSubMenuIndikator5 = new System.Windows.Forms.Button();
            this.btnSubMenuIndikator4 = new System.Windows.Forms.Button();
            this.btnSubMenuIndikator3 = new System.Windows.Forms.Button();
            this.btnSubMenuIndikator2 = new System.Windows.Forms.Button();
            this.btnSubMenuIndikator1 = new System.Windows.Forms.Button();
            this.btnMenuIndikator = new System.Windows.Forms.Button();
            this.pnlMenuKunjungan = new System.Windows.Forms.Panel();
            this.btnSubMenuViewSuku = new System.Windows.Forms.Button();
            this.btnSubMenuViewGolDarah = new System.Windows.Forms.Button();
            this.btnSubMenuKunjungan6 = new System.Windows.Forms.Button();
            this.btnSubMenuKunjungan5 = new System.Windows.Forms.Button();
            this.btnSubMenuKunjungan4 = new System.Windows.Forms.Button();
            this.btnSubMenuKunjungan3 = new System.Windows.Forms.Button();
            this.btnSubMenuKunjungan2 = new System.Windows.Forms.Button();
            this.btnSubMenuKunjungan1 = new System.Windows.Forms.Button();
            this.btnMenuKunjungan = new System.Windows.Forms.Button();
            this.pnlMenuPendapatan = new System.Windows.Forms.Panel();
            this.btnSubMenubtnMenuPendapatan6 = new System.Windows.Forms.Button();
            this.btnSubMenubtnMenuPendapatan5 = new System.Windows.Forms.Button();
            this.btnSubMenubtnMenuPendapatan4 = new System.Windows.Forms.Button();
            this.btnSubMenubtnMenuPendapatan3 = new System.Windows.Forms.Button();
            this.btnSubMenubtnMenuPendapatan2 = new System.Windows.Forms.Button();
            this.btnSubMenuRegistrasiListPasienIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnSubMenuRegistrasiListRegistrasiIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnSubMenubtnMenuPendapatan1 = new System.Windows.Forms.Button();
            this.pnlBtnMenuRegistrasi = new System.Windows.Forms.Panel();
            this.btnMenuRegistrasiIndikator = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnMenuPendapatan = new System.Windows.Forms.Button();
            this.ucIndikatorKlikMenu1 = new SIMRS.DESKTOP.Template.uc.ucIndikatorKlikMenu();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.pnlPicUser.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserShow.Properties)).BeginInit();
            this.pnlSlideMenu.SuspendLayout();
            this.pnlMenuIndikator.SuspendLayout();
            this.pnlMenuKunjungan.SuspendLayout();
            this.pnlMenuPendapatan.SuspendLayout();
            this.pnlBtnMenuRegistrasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlide
            // 
            this.pnlSlide.Controls.Add(this.pnlSlideMenu);
            this.pnlSlide.Controls.SetChildIndex(this.pnlPicUser, 0);
            this.pnlSlide.Controls.SetChildIndex(this.pnlSlideMenu, 0);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            // 
            // btnResize
            // 
            this.btnResize.FlatAppearance.BorderSize = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // lbljam
            // 
            this.lbljam.Text = "02:16:11";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
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
            this.pnlSlideMenu.Controls.Add(this.pnlMenuIndikator);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuKunjungan);
            this.pnlSlideMenu.Controls.Add(this.pnlMenuPendapatan);
            this.pnlSlideMenu.Controls.Add(this.ucIndikatorKlikMenu1);
            this.pnlSlideMenu.Controls.Add(this.btnMenuDashboard);
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 197);
            this.pnlSlideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(210, 370);
            this.pnlSlideMenu.TabIndex = 6;
            // 
            // pnlMenuIndikator
            // 
            this.pnlMenuIndikator.Controls.Add(this.btnSubMenuIndikator5);
            this.pnlMenuIndikator.Controls.Add(this.btnSubMenuIndikator4);
            this.pnlMenuIndikator.Controls.Add(this.btnSubMenuIndikator3);
            this.pnlMenuIndikator.Controls.Add(this.btnSubMenuIndikator2);
            this.pnlMenuIndikator.Controls.Add(this.btnSubMenuIndikator1);
            this.pnlMenuIndikator.Controls.Add(this.btnMenuIndikator);
            this.pnlMenuIndikator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuIndikator.Location = new System.Drawing.Point(0, 105);
            this.pnlMenuIndikator.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuIndikator.Name = "pnlMenuIndikator";
            this.pnlMenuIndikator.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuIndikator.TabIndex = 15;
            // 
            // btnSubMenuIndikator5
            // 
            this.btnSubMenuIndikator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuIndikator5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuIndikator5.FlatAppearance.BorderSize = 0;
            this.btnSubMenuIndikator5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuIndikator5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuIndikator5.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuIndikator5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator5.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenuIndikator5.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuIndikator5.Name = "btnSubMenuIndikator5";
            this.btnSubMenuIndikator5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuIndikator5.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuIndikator5.TabIndex = 18;
            this.btnSubMenuIndikator5.Text = "    Laporan 5";
            this.btnSubMenuIndikator5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator5.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuIndikator4
            // 
            this.btnSubMenuIndikator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuIndikator4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuIndikator4.FlatAppearance.BorderSize = 0;
            this.btnSubMenuIndikator4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuIndikator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuIndikator4.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuIndikator4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator4.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenuIndikator4.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuIndikator4.Name = "btnSubMenuIndikator4";
            this.btnSubMenuIndikator4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuIndikator4.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuIndikator4.TabIndex = 17;
            this.btnSubMenuIndikator4.Text = "    Laporan 4";
            this.btnSubMenuIndikator4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator4.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuIndikator3
            // 
            this.btnSubMenuIndikator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuIndikator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuIndikator3.FlatAppearance.BorderSize = 0;
            this.btnSubMenuIndikator3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuIndikator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuIndikator3.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuIndikator3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator3.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuIndikator3.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuIndikator3.Name = "btnSubMenuIndikator3";
            this.btnSubMenuIndikator3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuIndikator3.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuIndikator3.TabIndex = 16;
            this.btnSubMenuIndikator3.Text = "    Laporan 3";
            this.btnSubMenuIndikator3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator3.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuIndikator2
            // 
            this.btnSubMenuIndikator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuIndikator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuIndikator2.FlatAppearance.BorderSize = 0;
            this.btnSubMenuIndikator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuIndikator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuIndikator2.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuIndikator2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator2.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuIndikator2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuIndikator2.Name = "btnSubMenuIndikator2";
            this.btnSubMenuIndikator2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuIndikator2.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuIndikator2.TabIndex = 15;
            this.btnSubMenuIndikator2.Text = "    Laporan 2";
            this.btnSubMenuIndikator2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator2.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuIndikator1
            // 
            this.btnSubMenuIndikator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuIndikator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuIndikator1.FlatAppearance.BorderSize = 0;
            this.btnSubMenuIndikator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuIndikator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuIndikator1.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuIndikator1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator1.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuIndikator1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuIndikator1.Name = "btnSubMenuIndikator1";
            this.btnSubMenuIndikator1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuIndikator1.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuIndikator1.TabIndex = 14;
            this.btnSubMenuIndikator1.Text = "    Laporan 1";
            this.btnSubMenuIndikator1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuIndikator1.UseVisualStyleBackColor = false;
            // 
            // btnMenuIndikator
            // 
            this.btnMenuIndikator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuIndikator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuIndikator.FlatAppearance.BorderSize = 0;
            this.btnMenuIndikator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuIndikator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuIndikator.ForeColor = System.Drawing.Color.White;
            this.btnMenuIndikator.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuIndikator.Image")));
            this.btnMenuIndikator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuIndikator.Location = new System.Drawing.Point(0, 0);
            this.btnMenuIndikator.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuIndikator.Name = "btnMenuIndikator";
            this.btnMenuIndikator.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuIndikator.Size = new System.Drawing.Size(210, 35);
            this.btnMenuIndikator.TabIndex = 13;
            this.btnMenuIndikator.Text = "          Indikator";
            this.btnMenuIndikator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuIndikator.UseVisualStyleBackColor = false;
            this.btnMenuIndikator.Click += new System.EventHandler(this.btnMenuIndikator_Click);
            // 
            // pnlMenuKunjungan
            // 
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuViewSuku);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuViewGolDarah);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuKunjungan6);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuKunjungan5);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuKunjungan4);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuKunjungan3);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuKunjungan2);
            this.pnlMenuKunjungan.Controls.Add(this.btnSubMenuKunjungan1);
            this.pnlMenuKunjungan.Controls.Add(this.btnMenuKunjungan);
            this.pnlMenuKunjungan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuKunjungan.Location = new System.Drawing.Point(0, 70);
            this.pnlMenuKunjungan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuKunjungan.Name = "pnlMenuKunjungan";
            this.pnlMenuKunjungan.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuKunjungan.TabIndex = 14;
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
            // btnSubMenuKunjungan6
            // 
            this.btnSubMenuKunjungan6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuKunjungan6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuKunjungan6.FlatAppearance.BorderSize = 0;
            this.btnSubMenuKunjungan6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuKunjungan6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuKunjungan6.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuKunjungan6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan6.Location = new System.Drawing.Point(0, 185);
            this.btnSubMenuKunjungan6.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuKunjungan6.Name = "btnSubMenuKunjungan6";
            this.btnSubMenuKunjungan6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuKunjungan6.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuKunjungan6.TabIndex = 19;
            this.btnSubMenuKunjungan6.Text = "   Kunjungan6";
            this.btnSubMenuKunjungan6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan6.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuKunjungan5
            // 
            this.btnSubMenuKunjungan5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuKunjungan5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuKunjungan5.FlatAppearance.BorderSize = 0;
            this.btnSubMenuKunjungan5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuKunjungan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuKunjungan5.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuKunjungan5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan5.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenuKunjungan5.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuKunjungan5.Name = "btnSubMenuKunjungan5";
            this.btnSubMenuKunjungan5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuKunjungan5.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuKunjungan5.TabIndex = 18;
            this.btnSubMenuKunjungan5.Text = "   Kunjungan5";
            this.btnSubMenuKunjungan5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan5.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuKunjungan4
            // 
            this.btnSubMenuKunjungan4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuKunjungan4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuKunjungan4.FlatAppearance.BorderSize = 0;
            this.btnSubMenuKunjungan4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuKunjungan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuKunjungan4.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuKunjungan4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan4.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenuKunjungan4.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuKunjungan4.Name = "btnSubMenuKunjungan4";
            this.btnSubMenuKunjungan4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuKunjungan4.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuKunjungan4.TabIndex = 17;
            this.btnSubMenuKunjungan4.Text = "   Kunjungan4";
            this.btnSubMenuKunjungan4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan4.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuKunjungan3
            // 
            this.btnSubMenuKunjungan3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuKunjungan3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuKunjungan3.FlatAppearance.BorderSize = 0;
            this.btnSubMenuKunjungan3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuKunjungan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuKunjungan3.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuKunjungan3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan3.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenuKunjungan3.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuKunjungan3.Name = "btnSubMenuKunjungan3";
            this.btnSubMenuKunjungan3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuKunjungan3.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuKunjungan3.TabIndex = 16;
            this.btnSubMenuKunjungan3.Text = "   Kunjungan3";
            this.btnSubMenuKunjungan3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan3.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuKunjungan2
            // 
            this.btnSubMenuKunjungan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuKunjungan2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuKunjungan2.FlatAppearance.BorderSize = 0;
            this.btnSubMenuKunjungan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuKunjungan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuKunjungan2.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuKunjungan2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan2.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenuKunjungan2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuKunjungan2.Name = "btnSubMenuKunjungan2";
            this.btnSubMenuKunjungan2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuKunjungan2.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuKunjungan2.TabIndex = 15;
            this.btnSubMenuKunjungan2.Text = "    Kunjungan2";
            this.btnSubMenuKunjungan2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan2.UseVisualStyleBackColor = false;
            // 
            // btnSubMenuKunjungan1
            // 
            this.btnSubMenuKunjungan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenuKunjungan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuKunjungan1.FlatAppearance.BorderSize = 0;
            this.btnSubMenuKunjungan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuKunjungan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuKunjungan1.ForeColor = System.Drawing.Color.White;
            this.btnSubMenuKunjungan1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan1.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenuKunjungan1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenuKunjungan1.Name = "btnSubMenuKunjungan1";
            this.btnSubMenuKunjungan1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenuKunjungan1.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenuKunjungan1.TabIndex = 14;
            this.btnSubMenuKunjungan1.Text = "   Kunjungan1";
            this.btnSubMenuKunjungan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuKunjungan1.UseVisualStyleBackColor = false;
            // 
            // btnMenuKunjungan
            // 
            this.btnMenuKunjungan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuKunjungan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuKunjungan.FlatAppearance.BorderSize = 0;
            this.btnMenuKunjungan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuKunjungan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuKunjungan.ForeColor = System.Drawing.Color.White;
            this.btnMenuKunjungan.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuKunjungan.Image")));
            this.btnMenuKunjungan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuKunjungan.Location = new System.Drawing.Point(0, 0);
            this.btnMenuKunjungan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuKunjungan.Name = "btnMenuKunjungan";
            this.btnMenuKunjungan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuKunjungan.Size = new System.Drawing.Size(210, 35);
            this.btnMenuKunjungan.TabIndex = 13;
            this.btnMenuKunjungan.Text = "          Kunjungan";
            this.btnMenuKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuKunjungan.UseVisualStyleBackColor = false;
            this.btnMenuKunjungan.Click += new System.EventHandler(this.btnMenuKunjungan_Click);
            // 
            // pnlMenuPendapatan
            // 
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenubtnMenuPendapatan6);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenubtnMenuPendapatan5);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenubtnMenuPendapatan4);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenubtnMenuPendapatan3);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenubtnMenuPendapatan2);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenuRegistrasiListPasienIndikator);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenuRegistrasiListRegistrasiIndikator);
            this.pnlMenuPendapatan.Controls.Add(this.btnSubMenubtnMenuPendapatan1);
            this.pnlMenuPendapatan.Controls.Add(this.pnlBtnMenuRegistrasi);
            this.pnlMenuPendapatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuPendapatan.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuPendapatan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuPendapatan.Name = "pnlMenuPendapatan";
            this.pnlMenuPendapatan.Size = new System.Drawing.Size(210, 35);
            this.pnlMenuPendapatan.TabIndex = 13;
            // 
            // btnSubMenubtnMenuPendapatan6
            // 
            this.btnSubMenubtnMenuPendapatan6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenubtnMenuPendapatan6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenubtnMenuPendapatan6.FlatAppearance.BorderSize = 0;
            this.btnSubMenubtnMenuPendapatan6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenubtnMenuPendapatan6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenubtnMenuPendapatan6.ForeColor = System.Drawing.Color.White;
            this.btnSubMenubtnMenuPendapatan6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan6.Location = new System.Drawing.Point(0, 185);
            this.btnSubMenubtnMenuPendapatan6.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenubtnMenuPendapatan6.Name = "btnSubMenubtnMenuPendapatan6";
            this.btnSubMenubtnMenuPendapatan6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenubtnMenuPendapatan6.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenubtnMenuPendapatan6.TabIndex = 23;
            this.btnSubMenubtnMenuPendapatan6.Text = "    Pendapatan6";
            this.btnSubMenubtnMenuPendapatan6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan6.UseVisualStyleBackColor = false;
            // 
            // btnSubMenubtnMenuPendapatan5
            // 
            this.btnSubMenubtnMenuPendapatan5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenubtnMenuPendapatan5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenubtnMenuPendapatan5.FlatAppearance.BorderSize = 0;
            this.btnSubMenubtnMenuPendapatan5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenubtnMenuPendapatan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenubtnMenuPendapatan5.ForeColor = System.Drawing.Color.White;
            this.btnSubMenubtnMenuPendapatan5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan5.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenubtnMenuPendapatan5.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenubtnMenuPendapatan5.Name = "btnSubMenubtnMenuPendapatan5";
            this.btnSubMenubtnMenuPendapatan5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenubtnMenuPendapatan5.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenubtnMenuPendapatan5.TabIndex = 22;
            this.btnSubMenubtnMenuPendapatan5.Text = "    Pendapatan5";
            this.btnSubMenubtnMenuPendapatan5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan5.UseVisualStyleBackColor = false;
            // 
            // btnSubMenubtnMenuPendapatan4
            // 
            this.btnSubMenubtnMenuPendapatan4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenubtnMenuPendapatan4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenubtnMenuPendapatan4.FlatAppearance.BorderSize = 0;
            this.btnSubMenubtnMenuPendapatan4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenubtnMenuPendapatan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenubtnMenuPendapatan4.ForeColor = System.Drawing.Color.White;
            this.btnSubMenubtnMenuPendapatan4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan4.Location = new System.Drawing.Point(0, 125);
            this.btnSubMenubtnMenuPendapatan4.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenubtnMenuPendapatan4.Name = "btnSubMenubtnMenuPendapatan4";
            this.btnSubMenubtnMenuPendapatan4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenubtnMenuPendapatan4.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenubtnMenuPendapatan4.TabIndex = 21;
            this.btnSubMenubtnMenuPendapatan4.Text = "    Pendapatan4";
            this.btnSubMenubtnMenuPendapatan4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan4.UseVisualStyleBackColor = false;
            this.btnSubMenubtnMenuPendapatan4.Click += new System.EventHandler(this.btnSubMenubtnMenuPendapatan4_Click);
            // 
            // btnSubMenubtnMenuPendapatan3
            // 
            this.btnSubMenubtnMenuPendapatan3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenubtnMenuPendapatan3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenubtnMenuPendapatan3.FlatAppearance.BorderSize = 0;
            this.btnSubMenubtnMenuPendapatan3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenubtnMenuPendapatan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenubtnMenuPendapatan3.ForeColor = System.Drawing.Color.White;
            this.btnSubMenubtnMenuPendapatan3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan3.Location = new System.Drawing.Point(0, 95);
            this.btnSubMenubtnMenuPendapatan3.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenubtnMenuPendapatan3.Name = "btnSubMenubtnMenuPendapatan3";
            this.btnSubMenubtnMenuPendapatan3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenubtnMenuPendapatan3.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenubtnMenuPendapatan3.TabIndex = 20;
            this.btnSubMenubtnMenuPendapatan3.Text = "    Pendapatan3";
            this.btnSubMenubtnMenuPendapatan3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan3.UseVisualStyleBackColor = false;
            this.btnSubMenubtnMenuPendapatan3.Click += new System.EventHandler(this.btnSubMenubtnMenuPendapatan3_Click);
            // 
            // btnSubMenubtnMenuPendapatan2
            // 
            this.btnSubMenubtnMenuPendapatan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenubtnMenuPendapatan2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenubtnMenuPendapatan2.FlatAppearance.BorderSize = 0;
            this.btnSubMenubtnMenuPendapatan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenubtnMenuPendapatan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenubtnMenuPendapatan2.ForeColor = System.Drawing.Color.White;
            this.btnSubMenubtnMenuPendapatan2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan2.Location = new System.Drawing.Point(0, 65);
            this.btnSubMenubtnMenuPendapatan2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenubtnMenuPendapatan2.Name = "btnSubMenubtnMenuPendapatan2";
            this.btnSubMenubtnMenuPendapatan2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenubtnMenuPendapatan2.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenubtnMenuPendapatan2.TabIndex = 15;
            this.btnSubMenubtnMenuPendapatan2.Text = "    Pendapatan2";
            this.btnSubMenubtnMenuPendapatan2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan2.UseVisualStyleBackColor = false;
            this.btnSubMenubtnMenuPendapatan2.Click += new System.EventHandler(this.btnSubMenubtnMenuPendapatan2_Click);
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
            // btnSubMenubtnMenuPendapatan1
            // 
            this.btnSubMenubtnMenuPendapatan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnSubMenubtnMenuPendapatan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenubtnMenuPendapatan1.FlatAppearance.BorderSize = 0;
            this.btnSubMenubtnMenuPendapatan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenubtnMenuPendapatan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenubtnMenuPendapatan1.ForeColor = System.Drawing.Color.White;
            this.btnSubMenubtnMenuPendapatan1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan1.Location = new System.Drawing.Point(0, 35);
            this.btnSubMenubtnMenuPendapatan1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenubtnMenuPendapatan1.Name = "btnSubMenubtnMenuPendapatan1";
            this.btnSubMenubtnMenuPendapatan1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSubMenubtnMenuPendapatan1.Size = new System.Drawing.Size(210, 30);
            this.btnSubMenubtnMenuPendapatan1.TabIndex = 14;
            this.btnSubMenubtnMenuPendapatan1.Text = "    Pendapatan1";
            this.btnSubMenubtnMenuPendapatan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenubtnMenuPendapatan1.UseVisualStyleBackColor = false;
            this.btnSubMenubtnMenuPendapatan1.Click += new System.EventHandler(this.btnSubMenubtnMenuPendapatan1_Click);
            // 
            // pnlBtnMenuRegistrasi
            // 
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuRegistrasiIndikator);
            this.pnlBtnMenuRegistrasi.Controls.Add(this.btnMenuPendapatan);
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
            // btnMenuPendapatan
            // 
            this.btnMenuPendapatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuPendapatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuPendapatan.FlatAppearance.BorderSize = 0;
            this.btnMenuPendapatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPendapatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPendapatan.ForeColor = System.Drawing.Color.White;
            this.btnMenuPendapatan.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPendapatan.Image")));
            this.btnMenuPendapatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPendapatan.Location = new System.Drawing.Point(0, 0);
            this.btnMenuPendapatan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPendapatan.Name = "btnMenuPendapatan";
            this.btnMenuPendapatan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuPendapatan.Size = new System.Drawing.Size(210, 35);
            this.btnMenuPendapatan.TabIndex = 16;
            this.btnMenuPendapatan.Text = "          Pendapatan";
            this.btnMenuPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPendapatan.UseVisualStyleBackColor = false;
            this.btnMenuPendapatan.Click += new System.EventHandler(this.btnMenuPendapatan_Click);
            // 
            // ucIndikatorKlikMenu1
            // 
            this.ucIndikatorKlikMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucIndikatorKlikMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.ucIndikatorKlikMenu1.Name = "ucIndikatorKlikMenu1";
            this.ucIndikatorKlikMenu1.Size = new System.Drawing.Size(5, 35);
            this.ucIndikatorKlikMenu1.TabIndex = 5;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnMenuDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuDashboard.FlatAppearance.BorderSize = 0;
            this.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnMenuDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuDashboard.Image")));
            this.btnMenuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuDashboard.Size = new System.Drawing.Size(210, 35);
            this.btnMenuDashboard.TabIndex = 12;
            this.btnMenuDashboard.Text = "          Dashboard";
            this.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDashboard.UseVisualStyleBackColor = false;
            this.btnMenuDashboard.Click += new System.EventHandler(this.btnMenuDashboard_Click);
            // 
            // FMainMenuSIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1366, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FMainMenuSIE";
            this.pnlPicUser.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            this.pnlRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserShow.Properties)).EndInit();
            this.pnlSlideMenu.ResumeLayout(false);
            this.pnlMenuIndikator.ResumeLayout(false);
            this.pnlMenuKunjungan.ResumeLayout(false);
            this.pnlMenuPendapatan.ResumeLayout(false);
            this.pnlBtnMenuRegistrasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public FMainMenuSIE()
        {
            InitializeComponent();

            this.mlblTitleHeader.Text = string.Format("{0}", "Modul Sitem Informasi Eksekutif");

            //this.btnMenuDashboard.Text = "          Dashboard";

            this.btnSubMenubtnMenuPendapatan1.Text = "    By Pelayanan Medik";
            this.btnSubMenubtnMenuPendapatan2.Text = "    By Ruang Pelayanan";
            this.btnSubMenubtnMenuPendapatan3.Text = "    By Year Range";
            this.btnSubMenubtnMenuPendapatan4.Text = "    By Year And Month Range";
            //this.btnSubMenubtnMenuPendapatan1.Text = "    By Year And Date Range";
            //this.btnSubMenubtnMenuPendapatan1.Text = "       Pasien Poli";
            //this.btnSubMenubtnMenuPendapatan2.Text = "       Registrasi Pasien";

            //this.btnMenuKunjungan.Text = "          Kunjungan";
            //this.btnSubMenuKunjungan1.Text = "       Tarif";
            //this.btnSubMenuKunjungan2.Text = "       Dokter";
            //this.btnSubMenuKunjungan3.Text = "       Perawat";
            ////this.btnSubMenuViewPoliklinik.Text = "       Tarif";
            ////this.btnSubMenuViewPoliklinik.Text = "       Tarif";

            //this.btnSubMenuIndikator1.Text = "       Register";
            //this.btnSubMenuIndikator2.Text = "       Pendapatan";
            //this.btnSubMenuIndikator3.Text = "       Jasa Medis";

            btnMenuDashboard_Click(null, null);

        }

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            TFDashboardSIE myForm = new TFDashboardSIE();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void btnMenuPendapatan_Click(object sender, EventArgs e)
        {
            if (pnlMenuPendapatan.Height == btnMenuPendapatan.Height)
            {
                pnlMenuPendapatan.Height = (btnMenuPendapatan.Height * 5) - 20;

                //btnMenuRegistrasiIcon.Image = Properties.Resources.down;
                //btnF1.Image = Properties.Resources.down;
                //pnlMenuGroupf2.Top = (pnlMenuGroupf2.Top + pnlMenuGroupf1.Height) - btnf1.Height;
                //pnlMenuGroupf3.Visible = false;
                //pnlMenuGroupf4.Visible = false;
                //pnlMenuGroupLaporan.Visible = false;
            }
            else
            {
                pnlMenuPendapatan.Height = btnMenuPendapatan.Height;
                //btnMenuRegistrasiIcon.Image = Properties.Resources.back;
                //pnlMenuGroupF1.Height = btnF1.Height;
                //btnF1.Image = Properties.Resources.up;
            }
        }

        private void btnSubMenubtnMenuPendapatan1_Click(object sender, EventArgs e)// ByYear
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            TFPendapatanByPelayananMedik myForm = new TFPendapatanByPelayananMedik(ref this.pnlContent);
            //FPendapatanByYear myForm = new FPendapatanByYear(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void btnSubMenubtnMenuPendapatan2_Click(object sender, EventArgs e)// ByYear And Maonth
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            TFPendapatanByRuangPelayanan myForm = new TFPendapatanByRuangPelayanan(ref this.pnlContent);
            //FPendapatanByYearAndMonth myForm = new FPendapatanByYearAndMonth(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void btnSubMenubtnMenuPendapatan3_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FPendapatanByYearRange myForm = new FPendapatanByYearRange(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void btnSubMenubtnMenuPendapatan4_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FPendapatanByYearAndMonthRange myForm = new FPendapatanByYearAndMonthRange(ref this.pnlContent);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void btnMenuKunjungan_Click(object sender, EventArgs e)
        {
            try
            {
                MetroFramework.MetroMessageBox.Show(this, "Sedang Proses sinkronisasi\nThe driver could not establish a secure connection to SQL Server by using Secure Sockets Layer (SSL) encryption. Error: SQL Server returned an incomplete response. The connection has been closed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuIndikator_Click(object sender, EventArgs e)
        {
            try
            {
                MetroFramework.MetroMessageBox.Show(this, "Sedang Proses sinkronisasi\nThe driver could not establish a secure connection to SQL Server by using Secure Sockets Layer (SSL) encryption. Error: SQL Server returned an incomplete response. The connection has been closed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                using (FDialogLogoutSIE f = new FDialogLogoutSIE("Apakah akan Log Out"))
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
