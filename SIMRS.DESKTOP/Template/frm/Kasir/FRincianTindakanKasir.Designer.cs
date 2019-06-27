namespace SIMRS.DESKTOP.Template.frm.Kasir
{
    partial class FRincianTindakanKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRincianTindakanKasir));
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblSelect = new MetroFramework.Controls.MetroLabel();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.vpelayananpasienrinciannotalamatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colregistrasiid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpelayananpasienid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarifid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruangrawatnm2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpelayananpasientgl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldaftartindakannm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldokternm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperawatnm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbiaya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalbiaya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruangrawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruangrawatnm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruangrawatid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpelayananmedikid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpelayananmediknm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkelasid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkelasuraian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.totalBiayaLbl = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lamaHariTxt = new MetroFramework.Controls.MetroTextBox();
            this.jenisRawatTxt = new MetroFramework.Controls.MetroTextBox();
            this.kelasRawatTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PicPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.caridataMTxt = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bayarLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ststransaksi = new MetroFramework.Controls.MetroLabel();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpelayananpasienrinciannotalamatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = 32;
            this.btnBack.Location = new System.Drawing.Point(843, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 38;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.pHeader.Controls.Add(this.lblSelect);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(858, 31);
            this.pHeader.TabIndex = 5;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSelect.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSelect.ForeColor = System.Drawing.Color.White;
            this.lblSelect.Location = new System.Drawing.Point(18, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(821, 26);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelect.UseCustomBackColor = true;
            this.lblSelect.UseCustomForeColor = true;
            // 
            // gc
            // 
            this.gc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc.DataSource = this.vpelayananpasienrinciannotalamatBindingSource;
            this.gc.Location = new System.Drawing.Point(18, 121);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(825, 486);
            this.gc.TabIndex = 33;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv,
            this.gridView1});
            // 
            // vpelayananpasienrinciannotalamatBindingSource
            // 
            this.vpelayananpasienrinciannotalamatBindingSource.DataSource = typeof(SIMRS.Model.view.v_pelayananpasien_rincian_not_alamat);
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colregistrasiid,
            this.colpelayananpasienid,
            this.coltarifid,
            this.colruangrawatnm2,
            this.colpelayananpasientgl,
            this.coldaftartindakannm,
            this.coldokternm,
            this.colperawatnm,
            this.colbiaya,
            this.coljml,
            this.coltotalbiaya,
            this.colruangrawatid,
            this.colruangrawatnm,
            this.colruangrawatid2,
            this.colpelayananmedikid,
            this.colpelayananmediknm,
            this.colkelasid,
            this.colkelasuraian});
            this.gv.GridControl = this.gc;
            this.gv.GroupCount = 1;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AutoExpandAllGroups = true;
            this.gv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colruangrawatnm2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colregistrasiid
            // 
            this.colregistrasiid.FieldName = "registrasiid";
            this.colregistrasiid.Name = "colregistrasiid";
            // 
            // colpelayananpasienid
            // 
            this.colpelayananpasienid.FieldName = "pelayananpasienid";
            this.colpelayananpasienid.Name = "colpelayananpasienid";
            // 
            // coltarifid
            // 
            this.coltarifid.FieldName = "tarifid";
            this.coltarifid.Name = "coltarifid";
            // 
            // colruangrawatnm2
            // 
            this.colruangrawatnm2.Caption = "RUANG RAWAT";
            this.colruangrawatnm2.FieldName = "ruangrawatnm2";
            this.colruangrawatnm2.Name = "colruangrawatnm2";
            this.colruangrawatnm2.Visible = true;
            this.colruangrawatnm2.VisibleIndex = 0;
            // 
            // colpelayananpasientgl
            // 
            this.colpelayananpasientgl.Caption = "TGl.TINDAKAN";
            this.colpelayananpasientgl.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colpelayananpasientgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpelayananpasientgl.FieldName = "pelayananpasientgl";
            this.colpelayananpasientgl.MaxWidth = 75;
            this.colpelayananpasientgl.MinWidth = 75;
            this.colpelayananpasientgl.Name = "colpelayananpasientgl";
            this.colpelayananpasientgl.OptionsColumn.AllowEdit = false;
            this.colpelayananpasientgl.Visible = true;
            this.colpelayananpasientgl.VisibleIndex = 0;
            this.colpelayananpasientgl.Width = 96;
            // 
            // coldaftartindakannm
            // 
            this.coldaftartindakannm.Caption = "TINDAKAN";
            this.coldaftartindakannm.FieldName = "daftartindakannm";
            this.coldaftartindakannm.Name = "coldaftartindakannm";
            this.coldaftartindakannm.Visible = true;
            this.coldaftartindakannm.VisibleIndex = 1;
            this.coldaftartindakannm.Width = 390;
            // 
            // coldokternm
            // 
            this.coldokternm.Caption = "DOKTER";
            this.coldokternm.FieldName = "dokternm";
            this.coldokternm.MaxWidth = 160;
            this.coldokternm.MinWidth = 140;
            this.coldokternm.Name = "coldokternm";
            this.coldokternm.Visible = true;
            this.coldokternm.VisibleIndex = 2;
            this.coldokternm.Width = 140;
            // 
            // colperawatnm
            // 
            this.colperawatnm.Caption = "PERAWAT";
            this.colperawatnm.FieldName = "perawatnm";
            this.colperawatnm.MaxWidth = 160;
            this.colperawatnm.MinWidth = 80;
            this.colperawatnm.Name = "colperawatnm";
            this.colperawatnm.Visible = true;
            this.colperawatnm.VisibleIndex = 3;
            this.colperawatnm.Width = 134;
            // 
            // colbiaya
            // 
            this.colbiaya.Caption = "BIAYA";
            this.colbiaya.DisplayFormat.FormatString = "#,##";
            this.colbiaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colbiaya.FieldName = "biaya";
            this.colbiaya.MaxWidth = 80;
            this.colbiaya.MinWidth = 80;
            this.colbiaya.Name = "colbiaya";
            this.colbiaya.Visible = true;
            this.colbiaya.VisibleIndex = 4;
            this.colbiaya.Width = 80;
            // 
            // coljml
            // 
            this.coljml.Caption = "JML";
            this.coljml.FieldName = "jml";
            this.coljml.MaxWidth = 45;
            this.coljml.MinWidth = 45;
            this.coljml.Name = "coljml";
            this.coljml.Visible = true;
            this.coljml.VisibleIndex = 5;
            this.coljml.Width = 45;
            // 
            // coltotalbiaya
            // 
            this.coltotalbiaya.Caption = "TOTAL BIAYA";
            this.coltotalbiaya.DisplayFormat.FormatString = "#,##";
            this.coltotalbiaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltotalbiaya.FieldName = "totalbiaya";
            this.coltotalbiaya.MaxWidth = 80;
            this.coltotalbiaya.MinWidth = 80;
            this.coltotalbiaya.Name = "coltotalbiaya";
            this.coltotalbiaya.Visible = true;
            this.coltotalbiaya.VisibleIndex = 6;
            this.coltotalbiaya.Width = 80;
            // 
            // colruangrawatid
            // 
            this.colruangrawatid.FieldName = "ruangrawatid";
            this.colruangrawatid.Name = "colruangrawatid";
            // 
            // colruangrawatnm
            // 
            this.colruangrawatnm.FieldName = "ruangrawatnm";
            this.colruangrawatnm.Name = "colruangrawatnm";
            // 
            // colruangrawatid2
            // 
            this.colruangrawatid2.FieldName = "ruangrawatid2";
            this.colruangrawatid2.Name = "colruangrawatid2";
            // 
            // colpelayananmedikid
            // 
            this.colpelayananmedikid.FieldName = "pelayananmedikid";
            this.colpelayananmedikid.Name = "colpelayananmedikid";
            // 
            // colpelayananmediknm
            // 
            this.colpelayananmediknm.FieldName = "pelayananmediknm";
            this.colpelayananmediknm.Name = "colpelayananmediknm";
            // 
            // colkelasid
            // 
            this.colkelasid.FieldName = "kelasid";
            this.colkelasid.Name = "colkelasid";
            // 
            // colkelasuraian
            // 
            this.colkelasuraian.FieldName = "kelasuraian";
            this.colkelasuraian.Name = "colkelasuraian";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc;
            this.gridView1.Name = "gridView1";
            // 
            // totalBiayaLbl
            // 
            this.totalBiayaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalBiayaLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.totalBiayaLbl.Appearance.Options.UseFont = true;
            this.totalBiayaLbl.Appearance.Options.UseTextOptions = true;
            this.totalBiayaLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totalBiayaLbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.totalBiayaLbl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.totalBiayaLbl.Location = new System.Drawing.Point(671, 41);
            this.totalBiayaLbl.Name = "totalBiayaLbl";
            this.totalBiayaLbl.Size = new System.Drawing.Size(159, 33);
            this.totalBiayaLbl.TabIndex = 113;
            this.totalBiayaLbl.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ststransaksi);
            this.panel1.Controls.Add(this.lamaHariTxt);
            this.panel1.Controls.Add(this.jenisRawatTxt);
            this.panel1.Controls.Add(this.kelasRawatTxt);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.PicPictureEdit);
            this.panel1.Controls.Add(this.caridataMTxt);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.bayarLbl);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.totalBiayaLbl);
            this.panel1.Controls.Add(this.gc);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 642);
            this.panel1.TabIndex = 0;
            // 
            // lamaHariTxt
            // 
            // 
            // 
            // 
            this.lamaHariTxt.CustomButton.Image = null;
            this.lamaHariTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.lamaHariTxt.CustomButton.Name = "";
            this.lamaHariTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lamaHariTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lamaHariTxt.CustomButton.TabIndex = 1;
            this.lamaHariTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lamaHariTxt.CustomButton.UseSelectable = true;
            this.lamaHariTxt.CustomButton.Visible = false;
            this.lamaHariTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.lamaHariTxt.Lines = new string[0];
            this.lamaHariTxt.Location = new System.Drawing.Point(222, 89);
            this.lamaHariTxt.MaxLength = 32767;
            this.lamaHariTxt.Name = "lamaHariTxt";
            this.lamaHariTxt.PasswordChar = '\0';
            this.lamaHariTxt.ReadOnly = true;
            this.lamaHariTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lamaHariTxt.SelectedText = "";
            this.lamaHariTxt.SelectionLength = 0;
            this.lamaHariTxt.SelectionStart = 0;
            this.lamaHariTxt.ShortcutsEnabled = true;
            this.lamaHariTxt.Size = new System.Drawing.Size(158, 23);
            this.lamaHariTxt.TabIndex = 134;
            this.lamaHariTxt.UseSelectable = true;
            this.lamaHariTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lamaHariTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // jenisRawatTxt
            // 
            // 
            // 
            // 
            this.jenisRawatTxt.CustomButton.Image = null;
            this.jenisRawatTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.jenisRawatTxt.CustomButton.Name = "";
            this.jenisRawatTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jenisRawatTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jenisRawatTxt.CustomButton.TabIndex = 1;
            this.jenisRawatTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jenisRawatTxt.CustomButton.UseSelectable = true;
            this.jenisRawatTxt.CustomButton.Visible = false;
            this.jenisRawatTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.jenisRawatTxt.Lines = new string[0];
            this.jenisRawatTxt.Location = new System.Drawing.Point(222, 65);
            this.jenisRawatTxt.MaxLength = 32767;
            this.jenisRawatTxt.Name = "jenisRawatTxt";
            this.jenisRawatTxt.PasswordChar = '\0';
            this.jenisRawatTxt.ReadOnly = true;
            this.jenisRawatTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jenisRawatTxt.SelectedText = "";
            this.jenisRawatTxt.SelectionLength = 0;
            this.jenisRawatTxt.SelectionStart = 0;
            this.jenisRawatTxt.ShortcutsEnabled = true;
            this.jenisRawatTxt.Size = new System.Drawing.Size(158, 23);
            this.jenisRawatTxt.TabIndex = 133;
            this.jenisRawatTxt.UseSelectable = true;
            this.jenisRawatTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jenisRawatTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kelasRawatTxt
            // 
            // 
            // 
            // 
            this.kelasRawatTxt.CustomButton.Image = null;
            this.kelasRawatTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.kelasRawatTxt.CustomButton.Name = "";
            this.kelasRawatTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kelasRawatTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kelasRawatTxt.CustomButton.TabIndex = 1;
            this.kelasRawatTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kelasRawatTxt.CustomButton.UseSelectable = true;
            this.kelasRawatTxt.CustomButton.Visible = false;
            this.kelasRawatTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.kelasRawatTxt.Lines = new string[0];
            this.kelasRawatTxt.Location = new System.Drawing.Point(222, 41);
            this.kelasRawatTxt.MaxLength = 32767;
            this.kelasRawatTxt.Name = "kelasRawatTxt";
            this.kelasRawatTxt.PasswordChar = '\0';
            this.kelasRawatTxt.ReadOnly = true;
            this.kelasRawatTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kelasRawatTxt.SelectedText = "";
            this.kelasRawatTxt.SelectionLength = 0;
            this.kelasRawatTxt.SelectionStart = 0;
            this.kelasRawatTxt.ShortcutsEnabled = true;
            this.kelasRawatTxt.Size = new System.Drawing.Size(158, 23);
            this.kelasRawatTxt.TabIndex = 132;
            this.kelasRawatTxt.UseSelectable = true;
            this.kelasRawatTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kelasRawatTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(137, 90);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 131;
            this.metroLabel3.Text = "Lama Rawat";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(137, 65);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 130;
            this.metroLabel2.Text = "Jenis Rawat";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(137, 41);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 129;
            this.metroLabel1.Text = "Kelas Rawat";
            // 
            // PicPictureEdit
            // 
            this.PicPictureEdit.Location = new System.Drawing.Point(18, 35);
            this.PicPictureEdit.Margin = new System.Windows.Forms.Padding(1);
            this.PicPictureEdit.Name = "PicPictureEdit";
            this.PicPictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PicPictureEdit.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.PicPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PicPictureEdit.Size = new System.Drawing.Size(110, 82);
            this.PicPictureEdit.TabIndex = 128;
            // 
            // caridataMTxt
            // 
            this.caridataMTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.caridataMTxt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.caridataMTxt.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.caridataMTxt.CustomButton.Name = "";
            this.caridataMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.caridataMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.caridataMTxt.CustomButton.TabIndex = 1;
            this.caridataMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.caridataMTxt.CustomButton.UseCustomBackColor = true;
            this.caridataMTxt.CustomButton.UseSelectable = true;
            this.caridataMTxt.DisplayIcon = true;
            this.caridataMTxt.Icon = ((System.Drawing.Image)(resources.GetObject("caridataMTxt.Icon")));
            this.caridataMTxt.IconRight = true;
            this.caridataMTxt.Lines = new string[0];
            this.caridataMTxt.Location = new System.Drawing.Point(671, 130);
            this.caridataMTxt.Margin = new System.Windows.Forms.Padding(0);
            this.caridataMTxt.MaxLength = 32767;
            this.caridataMTxt.Name = "caridataMTxt";
            this.caridataMTxt.PasswordChar = '\0';
            this.caridataMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.caridataMTxt.SelectedText = "";
            this.caridataMTxt.SelectionLength = 0;
            this.caridataMTxt.SelectionStart = 0;
            this.caridataMTxt.ShortcutsEnabled = true;
            this.caridataMTxt.ShowButton = true;
            this.caridataMTxt.ShowClearButton = true;
            this.caridataMTxt.Size = new System.Drawing.Size(159, 23);
            this.caridataMTxt.Style = MetroFramework.MetroColorStyle.Teal;
            this.caridataMTxt.TabIndex = 126;
            this.caridataMTxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.caridataMTxt.UseSelectable = true;
            this.caridataMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.caridataMTxt.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(18, 610);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 21);
            this.btnAdd.TabIndex = 123;
            this.btnAdd.Text = "Next";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(568, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 29);
            this.labelControl4.TabIndex = 116;
            this.labelControl4.Text = "BAYAR :";
            // 
            // bayarLbl
            // 
            this.bayarLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bayarLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.bayarLbl.Appearance.Options.UseFont = true;
            this.bayarLbl.Appearance.Options.UseTextOptions = true;
            this.bayarLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bayarLbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bayarLbl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bayarLbl.Location = new System.Drawing.Point(671, 80);
            this.bayarLbl.Name = "bayarLbl";
            this.bayarLbl.Size = new System.Drawing.Size(159, 33);
            this.bayarLbl.TabIndex = 115;
            this.bayarLbl.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(488, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 29);
            this.labelControl1.TabIndex = 114;
            this.labelControl1.Text = "TOTAL BIAYA :";
            // 
            // ststransaksi
            // 
            this.ststransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ststransaksi.AutoSize = true;
            this.ststransaksi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ststransaksi.ForeColor = System.Drawing.Color.Red;
            this.ststransaksi.Location = new System.Drawing.Point(721, 612);
            this.ststransaksi.Margin = new System.Windows.Forms.Padding(0);
            this.ststransaksi.Name = "ststransaksi";
            this.ststransaksi.Size = new System.Drawing.Size(122, 19);
            this.ststransaksi.TabIndex = 135;
            this.ststransaksi.Text = "Belum pelunasan";
            this.ststransaksi.UseCustomForeColor = true;
            // 
            // FRincianTindakanKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 722);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRincianTindakanKasir";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FListRincianTindakan";
            this.Shown += new System.EventHandler(this.FRincianTindakanKasir_Shown);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpelayananpasienrinciannotalamatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected MetroFramework.Controls.MetroLink btnBack;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLabel lblSelect;
        protected DevExpress.XtraGrid.GridControl gc;
        protected DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected MetroFramework.Controls.MetroButton btnAdd;
        protected DevExpress.XtraEditors.LabelControl bayarLbl;
        protected DevExpress.XtraEditors.LabelControl totalBiayaLbl;
        protected MetroFramework.Controls.MetroTextBox caridataMTxt;
        protected MetroFramework.Controls.MetroTextBox lamaHariTxt;
        protected MetroFramework.Controls.MetroTextBox jenisRawatTxt;
        protected MetroFramework.Controls.MetroTextBox kelasRawatTxt;
        protected MetroFramework.Controls.MetroLabel metroLabel3;
        protected MetroFramework.Controls.MetroLabel metroLabel2;
        protected MetroFramework.Controls.MetroLabel metroLabel1;
        protected DevExpress.XtraEditors.PictureEdit PicPictureEdit;
        private System.Windows.Forms.BindingSource vpelayananpasienrinciannotalamatBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colregistrasiid;
        private DevExpress.XtraGrid.Columns.GridColumn colpelayananpasienid;
        private DevExpress.XtraGrid.Columns.GridColumn coltarifid;
        private DevExpress.XtraGrid.Columns.GridColumn colruangrawatnm2;
        private DevExpress.XtraGrid.Columns.GridColumn colpelayananpasientgl;
        private DevExpress.XtraGrid.Columns.GridColumn coldaftartindakannm;
        private DevExpress.XtraGrid.Columns.GridColumn coldokternm;
        private DevExpress.XtraGrid.Columns.GridColumn colperawatnm;
        private DevExpress.XtraGrid.Columns.GridColumn colbiaya;
        private DevExpress.XtraGrid.Columns.GridColumn coljml;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalbiaya;
        private DevExpress.XtraGrid.Columns.GridColumn colruangrawatid;
        private DevExpress.XtraGrid.Columns.GridColumn colruangrawatnm;
        private DevExpress.XtraGrid.Columns.GridColumn colruangrawatid2;
        private DevExpress.XtraGrid.Columns.GridColumn colpelayananmedikid;
        private DevExpress.XtraGrid.Columns.GridColumn colpelayananmediknm;
        private DevExpress.XtraGrid.Columns.GridColumn colkelasid;
        private DevExpress.XtraGrid.Columns.GridColumn colkelasuraian;
        protected MetroFramework.Controls.MetroLabel ststransaksi;
    }
}