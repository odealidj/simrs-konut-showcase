namespace SIMRS.DESKTOP.Template.frm
{
    partial class TFMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFMainMenu));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mlblTitleHeader = new MetroFramework.Controls.MetroLabel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLeftHeader = new System.Windows.Forms.Panel();
            this.mlblLeftTitle = new MetroFramework.Controls.MetroLabel();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.pnlPicUser = new System.Windows.Forms.Panel();
            this.picUserShow = new DevExpress.XtraEditors.PictureEdit();
            this.picUserHide = new DevExpress.XtraEditors.PictureEdit();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTgl = new MetroFramework.Controls.MetroLabel();
            this.lbljam = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            this.pnlPicUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserShow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide.Properties)).BeginInit();
            this.pnlRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.mlblTitleHeader);
            this.pnlHeader.Controls.Add(this.btnMenu);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnResize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.pnlLeftHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1366, 33);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1262, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(26, 33);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.BtnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.BtnLogout_MouseHover);
            // 
            // mlblTitleHeader
            // 
            this.mlblTitleHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblTitleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.mlblTitleHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitleHeader.ForeColor = System.Drawing.Color.White;
            this.mlblTitleHeader.Location = new System.Drawing.Point(244, 0);
            this.mlblTitleHeader.Margin = new System.Windows.Forms.Padding(0);
            this.mlblTitleHeader.Name = "mlblTitleHeader";
            this.mlblTitleHeader.Size = new System.Drawing.Size(1018, 33);
            this.mlblTitleHeader.TabIndex = 32;
            this.mlblTitleHeader.Text = "Modul Pendaftaran Rawat Jalan";
            this.mlblTitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlblTitleHeader.UseCustomBackColor = true;
            this.mlblTitleHeader.UseCustomForeColor = true;
            this.mlblTitleHeader.Click += new System.EventHandler(this.MlblTitleHeader_Click);
            this.mlblTitleHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.mlblTitleHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.mlblTitleHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(210, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(34, 33);
            this.btnMenu.TabIndex = 31;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1288, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 33);
            this.btnMinimize.TabIndex = 30;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.BtnMinimize_MouseHover);
            // 
            // btnResize
            // 
            this.btnResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.Image = ((System.Drawing.Image)(resources.GetObject("btnResize.Image")));
            this.btnResize.Location = new System.Drawing.Point(1314, 0);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(26, 33);
            this.btnResize.TabIndex = 29;
            this.btnResize.UseVisualStyleBackColor = false;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            this.btnResize.MouseLeave += new System.EventHandler(this.BtnResize_MouseLeave);
            this.btnResize.MouseHover += new System.EventHandler(this.BtnResize_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1340, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 33);
            this.btnClose.TabIndex = 28;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseHover);
            // 
            // pnlLeftHeader
            // 
            this.pnlLeftHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.pnlLeftHeader.Controls.Add(this.mlblLeftTitle);
            this.pnlLeftHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftHeader.Name = "pnlLeftHeader";
            this.pnlLeftHeader.Size = new System.Drawing.Size(210, 33);
            this.pnlLeftHeader.TabIndex = 2;
            // 
            // mlblLeftTitle
            // 
            this.mlblLeftTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mlblLeftTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlblLeftTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblLeftTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblLeftTitle.ForeColor = System.Drawing.Color.White;
            this.mlblLeftTitle.Location = new System.Drawing.Point(0, 0);
            this.mlblLeftTitle.Margin = new System.Windows.Forms.Padding(0);
            this.mlblLeftTitle.Name = "mlblLeftTitle";
            this.mlblLeftTitle.Size = new System.Drawing.Size(210, 33);
            this.mlblLeftTitle.TabIndex = 12;
            this.mlblLeftTitle.Text = "SIMRS";
            this.mlblLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlblLeftTitle.UseCustomBackColor = true;
            this.mlblLeftTitle.UseCustomForeColor = true;
            this.mlblLeftTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.mlblLeftTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.mlblLeftTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlSlide.Controls.Add(this.pnlPicUser);
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlide.Location = new System.Drawing.Point(0, 33);
            this.pnlSlide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(210, 567);
            this.pnlSlide.TabIndex = 3;
            // 
            // pnlPicUser
            // 
            this.pnlPicUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlPicUser.Controls.Add(this.picUserShow);
            this.pnlPicUser.Controls.Add(this.picUserHide);
            this.pnlPicUser.Controls.Add(this.lblUserName);
            this.pnlPicUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicUser.Location = new System.Drawing.Point(0, 0);
            this.pnlPicUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPicUser.Name = "pnlPicUser";
            this.pnlPicUser.Size = new System.Drawing.Size(210, 197);
            this.pnlPicUser.TabIndex = 3;
            // 
            // picUserShow
            // 
            this.picUserShow.EditValue = ((object)(resources.GetObject("picUserShow.EditValue")));
            this.picUserShow.Location = new System.Drawing.Point(48, 24);
            this.picUserShow.Name = "picUserShow";
            this.picUserShow.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.picUserShow.Properties.Appearance.Options.UseBackColor = true;
            this.picUserShow.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUserShow.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.picUserShow.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picUserShow.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picUserShow.Size = new System.Drawing.Size(122, 124);
            this.picUserShow.TabIndex = 28;
            // 
            // picUserHide
            // 
            this.picUserHide.EditValue = ((object)(resources.GetObject("picUserHide.EditValue")));
            this.picUserHide.Location = new System.Drawing.Point(0, 10);
            this.picUserHide.Name = "picUserHide";
            this.picUserHide.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.picUserHide.Properties.Appearance.Options.UseBackColor = true;
            this.picUserHide.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUserHide.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.picUserHide.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picUserHide.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picUserHide.Size = new System.Drawing.Size(48, 50);
            this.picUserHide.TabIndex = 27;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 169);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(210, 28);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "Selamat Datang, User";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserName.UseCustomBackColor = true;
            this.lblUserName.UseCustomForeColor = true;
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.pnlRoot.Controls.Add(this.metroLabel1);
            this.pnlRoot.Controls.Add(this.lblTgl);
            this.pnlRoot.Controls.Add(this.lbljam);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRoot.Location = new System.Drawing.Point(210, 573);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1156, 27);
            this.pnlRoot.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(301, 27);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Verison 18.10.1 © 2018 Rumah Sakit Konawe Utara";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // lblTgl
            // 
            this.lblTgl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTgl.Location = new System.Drawing.Point(843, 0);
            this.lblTgl.Name = "lblTgl";
            this.lblTgl.Size = new System.Drawing.Size(216, 27);
            this.lblTgl.TabIndex = 1;
            this.lblTgl.Text = "metroLabel1";
            this.lblTgl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTgl.UseCustomBackColor = true;
            // 
            // lbljam
            // 
            this.lbljam.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbljam.Location = new System.Drawing.Point(1059, 0);
            this.lbljam.Name = "lbljam";
            this.lbljam.Size = new System.Drawing.Size(97, 27);
            this.lbljam.TabIndex = 0;
            this.lbljam.Text = "metroLabel1";
            this.lbljam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbljam.UseCustomBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(210, 33);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1156, 540);
            this.pnlContent.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TFMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlRoot);
            this.Controls.Add(this.pnlSlide);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TFMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            this.pnlPicUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserShow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide.Properties)).EndInit();
            this.pnlRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected MetroFramework.Controls.MetroLabel mlblLeftTitle;
        protected System.Windows.Forms.Panel pnlPicUser;
        protected System.Windows.Forms.Panel pnlHeader;
        protected System.Windows.Forms.Panel pnlLeftHeader;
        protected System.Windows.Forms.Panel pnlSlide;
        protected MetroFramework.Controls.MetroLabel lblUserName;
        protected MetroFramework.Controls.MetroLabel mlblTitleHeader;
        protected System.Windows.Forms.Button btnMenu;
        protected System.Windows.Forms.Button btnMinimize;
        protected System.Windows.Forms.Button btnResize;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Panel pnlRoot;
        protected System.Windows.Forms.Timer timer1;
        protected MetroFramework.Controls.MetroLabel lbljam;
        private System.Windows.Forms.Timer timer2;
        protected MetroFramework.Controls.MetroLabel lblTgl;
        protected  System.Windows.Forms.Panel pnlContent;
        protected MetroFramework.Controls.MetroLabel metroLabel1;
        protected System.Windows.Forms.Button btnLogout;
        protected DevExpress.XtraEditors.PictureEdit picUserHide;
        protected DevExpress.XtraEditors.PictureEdit picUserShow;
    }
}