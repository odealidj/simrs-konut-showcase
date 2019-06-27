namespace SIMRS.DESKTOP.Template.frm.Farmasi.Gudang
{
    partial class TFAddEditBarangKeluar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFAddEditBarangKeluar));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bBatal = new DevExpress.XtraEditors.SimpleButton();
            this.TglKeluarDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.bBack = new MetroFramework.Controls.MetroLink();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.bSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.depoasalLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.depoTujuanLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.listbarangkeluarGC = new SIMRS.DESKTOP.MyComponents.MyGridControl();
            this.listbarangkeluarGV = new SIMRS.DESKTOP.MyComponents.MyGridView();
            this.colaptdistribusiid1 = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coldepoasalid = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coldepotujuanid = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coltgldistribusi = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coldepotujuannm = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colketdistribusi1 = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colonline1 = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coltahun = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colbulan = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coldepoasalnm = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coldetail = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.detailrepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.obatLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.qtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ketTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TglKeluarDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglKeluarDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoasalLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoTujuanLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbarangkeluarGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbarangkeluarGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailrepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bBatal
            // 
            this.bBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBatal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.bBatal.Appearance.Options.UseBackColor = true;
            this.bBatal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bBatal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBatal.ImageOptions.Image")));
            this.bBatal.Location = new System.Drawing.Point(708, 417);
            this.bBatal.Name = "bBatal";
            this.bBatal.Size = new System.Drawing.Size(75, 27);
            this.bBatal.TabIndex = 9;
            this.bBatal.Text = "Batal";
            this.bBatal.Click += new System.EventHandler(this.BBatal_Click);
            // 
            // TglKeluarDateEdit
            // 
            this.TglKeluarDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TglKeluarDateEdit.EditValue = null;
            this.TglKeluarDateEdit.Location = new System.Drawing.Point(142, 75);
            this.TglKeluarDateEdit.Name = "TglKeluarDateEdit";
            this.TglKeluarDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TglKeluarDateEdit.Properties.Appearance.Options.UseFont = true;
            this.TglKeluarDateEdit.Properties.AutoHeight = false;
            this.TglKeluarDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TglKeluarDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TglKeluarDateEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.TglKeluarDateEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TglKeluarDateEdit.Size = new System.Drawing.Size(641, 22);
            this.TglKeluarDateEdit.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHeader.Controls.Add(this.bBack);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 54);
            this.pnlHeader.TabIndex = 105;
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.ImageSize = 24;
            this.bBack.Location = new System.Drawing.Point(752, 9);
            this.bBack.Margin = new System.Windows.Forms.Padding(0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(31, 38);
            this.bBack.TabIndex = 10;
            this.bBack.UseCustomBackColor = true;
            this.bBack.UseSelectable = true;
            this.bBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(17, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(194, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Barang Keluar -> Add";
            // 
            // bSimpan
            // 
            this.bSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSimpan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.bSimpan.Appearance.Options.UseBackColor = true;
            this.bSimpan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bSimpan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bSimpan.ImageOptions.Image")));
            this.bSimpan.Location = new System.Drawing.Point(627, 417);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(75, 27);
            this.bSimpan.TabIndex = 8;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.Click += new System.EventHandler(this.BSimpan_Click);
            // 
            // depoasalLookUpEdit
            // 
            this.depoasalLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depoasalLookUpEdit.Location = new System.Drawing.Point(142, 101);
            this.depoasalLookUpEdit.Name = "depoasalLookUpEdit";
            this.depoasalLookUpEdit.Properties.AutoHeight = false;
            this.depoasalLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.depoasalLookUpEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.depoasalLookUpEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.depoasalLookUpEdit.Size = new System.Drawing.Size(641, 22);
            this.depoasalLookUpEdit.TabIndex = 2;
            // 
            // depoTujuanLookUpEdit
            // 
            this.depoTujuanLookUpEdit.Location = new System.Drawing.Point(142, 127);
            this.depoTujuanLookUpEdit.Name = "depoTujuanLookUpEdit";
            this.depoTujuanLookUpEdit.Properties.AutoHeight = false;
            this.depoTujuanLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.depoTujuanLookUpEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.depoTujuanLookUpEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.depoTujuanLookUpEdit.Size = new System.Drawing.Size(641, 22);
            this.depoTujuanLookUpEdit.TabIndex = 3;
            // 
            // listbarangkeluarGC
            // 
            this.listbarangkeluarGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbarangkeluarGC.Location = new System.Drawing.Point(17, 287);
            this.listbarangkeluarGC.LookAndFeel.SkinName = "The Bezier";
            this.listbarangkeluarGC.LookAndFeel.UseDefaultLookAndFeel = false;
            this.listbarangkeluarGC.MainView = this.listbarangkeluarGV;
            this.listbarangkeluarGC.Name = "listbarangkeluarGC";
            this.listbarangkeluarGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.detailrepositoryItemButtonEdit});
            this.listbarangkeluarGC.Size = new System.Drawing.Size(766, 124);
            this.listbarangkeluarGC.TabIndex = 113;
            this.listbarangkeluarGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listbarangkeluarGV});
            // 
            // listbarangkeluarGV
            // 
            this.listbarangkeluarGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colaptdistribusiid1,
            this.coldepoasalid,
            this.coldepotujuanid,
            this.coltgldistribusi,
            this.coldepotujuannm,
            this.colketdistribusi1,
            this.colonline1,
            this.coltahun,
            this.colbulan,
            this.coldepoasalnm,
            this.coldetail});
            this.listbarangkeluarGV.GridControl = this.listbarangkeluarGC;
            this.listbarangkeluarGV.Name = "listbarangkeluarGV";
            // 
            // colaptdistribusiid1
            // 
            this.colaptdistribusiid1.FieldName = "aptdistribusiid";
            this.colaptdistribusiid1.Name = "colaptdistribusiid1";
            // 
            // coldepoasalid
            // 
            this.coldepoasalid.FieldName = "depoasalid";
            this.coldepoasalid.Name = "coldepoasalid";
            // 
            // coldepotujuanid
            // 
            this.coldepotujuanid.FieldName = "depotujuanid";
            this.coldepotujuanid.Name = "coldepotujuanid";
            // 
            // coltgldistribusi
            // 
            this.coltgldistribusi.Caption = "TGL.KELUAR";
            this.coltgldistribusi.FieldName = "tgldistribusi";
            this.coltgldistribusi.MaxWidth = 75;
            this.coltgldistribusi.MinWidth = 75;
            this.coltgldistribusi.Name = "coltgldistribusi";
            this.coltgldistribusi.OptionsColumn.AllowEdit = false;
            this.coltgldistribusi.OptionsColumn.AllowIncrementalSearch = false;
            this.coltgldistribusi.OptionsColumn.AllowSize = false;
            this.coltgldistribusi.OptionsColumn.FixedWidth = true;
            this.coltgldistribusi.OptionsFilter.AllowAutoFilter = false;
            this.coltgldistribusi.OptionsFilter.AllowFilter = false;
            this.coltgldistribusi.Visible = true;
            this.coltgldistribusi.VisibleIndex = 0;
            // 
            // coldepotujuannm
            // 
            this.coldepotujuannm.Caption = "DEPO TUJUAN";
            this.coldepotujuannm.FieldName = "depotujuannm";
            this.coldepotujuannm.MinWidth = 165;
            this.coldepotujuannm.Name = "coldepotujuannm";
            this.coldepotujuannm.OptionsColumn.AllowEdit = false;
            this.coldepotujuannm.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coldepotujuannm.OptionsColumn.AllowIncrementalSearch = false;
            this.coldepotujuannm.OptionsColumn.AllowMove = false;
            this.coldepotujuannm.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldepotujuannm.OptionsFilter.AllowAutoFilter = false;
            this.coldepotujuannm.OptionsFilter.AllowFilter = false;
            this.coldepotujuannm.Visible = true;
            this.coldepotujuannm.VisibleIndex = 1;
            this.coldepotujuannm.Width = 165;
            // 
            // colketdistribusi1
            // 
            this.colketdistribusi1.Caption = "KETERANGAN";
            this.colketdistribusi1.FieldName = "ketdistribusi";
            this.colketdistribusi1.MinWidth = 250;
            this.colketdistribusi1.Name = "colketdistribusi1";
            this.colketdistribusi1.OptionsColumn.AllowEdit = false;
            this.colketdistribusi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colketdistribusi1.OptionsColumn.AllowIncrementalSearch = false;
            this.colketdistribusi1.OptionsColumn.AllowMove = false;
            this.colketdistribusi1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colketdistribusi1.OptionsFilter.AllowAutoFilter = false;
            this.colketdistribusi1.OptionsFilter.AllowFilter = false;
            this.colketdistribusi1.Visible = true;
            this.colketdistribusi1.VisibleIndex = 2;
            this.colketdistribusi1.Width = 250;
            // 
            // colonline1
            // 
            this.colonline1.Caption = "ON-LINE";
            this.colonline1.FieldName = "online";
            this.colonline1.MaxWidth = 60;
            this.colonline1.MinWidth = 60;
            this.colonline1.Name = "colonline1";
            this.colonline1.OptionsColumn.AllowEdit = false;
            this.colonline1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colonline1.OptionsColumn.AllowIncrementalSearch = false;
            this.colonline1.OptionsColumn.AllowMove = false;
            this.colonline1.OptionsColumn.AllowSize = false;
            this.colonline1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colonline1.OptionsColumn.FixedWidth = true;
            this.colonline1.OptionsFilter.AllowAutoFilter = false;
            this.colonline1.OptionsFilter.AllowFilter = false;
            this.colonline1.Visible = true;
            this.colonline1.VisibleIndex = 3;
            this.colonline1.Width = 60;
            // 
            // coltahun
            // 
            this.coltahun.FieldName = "tahun";
            this.coltahun.Name = "coltahun";
            // 
            // colbulan
            // 
            this.colbulan.FieldName = "bulan";
            this.colbulan.Name = "colbulan";
            // 
            // coldepoasalnm
            // 
            this.coldepoasalnm.FieldName = "depoasalnm";
            this.coldepoasalnm.Name = "coldepoasalnm";
            // 
            // coldetail
            // 
            this.coldetail.Caption = "detail";
            this.coldetail.ColumnEdit = this.detailrepositoryItemButtonEdit;
            this.coldetail.MaxWidth = 45;
            this.coldetail.MinWidth = 45;
            this.coldetail.Name = "coldetail";
            this.coldetail.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coldetail.OptionsColumn.AllowIncrementalSearch = false;
            this.coldetail.OptionsColumn.AllowMove = false;
            this.coldetail.OptionsColumn.AllowSize = false;
            this.coldetail.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldetail.OptionsColumn.FixedWidth = true;
            this.coldetail.OptionsColumn.ShowCaption = false;
            this.coldetail.OptionsFilter.AllowAutoFilter = false;
            this.coldetail.OptionsFilter.AllowFilter = false;
            this.coldetail.Visible = true;
            this.coldetail.VisibleIndex = 4;
            this.coldetail.Width = 45;
            // 
            // detailrepositoryItemButtonEdit
            // 
            this.detailrepositoryItemButtonEdit.AutoHeight = false;
            this.detailrepositoryItemButtonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.detailrepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Info detail barang keluar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.detailrepositoryItemButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.detailrepositoryItemButtonEdit.LookAndFeel.SkinName = "The Bezier";
            this.detailrepositoryItemButtonEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.detailrepositoryItemButtonEdit.Name = "detailrepositoryItemButtonEdit";
            this.detailrepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // obatLookUpEdit
            // 
            this.obatLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obatLookUpEdit.Location = new System.Drawing.Point(142, 199);
            this.obatLookUpEdit.Name = "obatLookUpEdit";
            this.obatLookUpEdit.Properties.AutoHeight = false;
            this.obatLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.obatLookUpEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.obatLookUpEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.obatLookUpEdit.Size = new System.Drawing.Size(641, 22);
            this.obatLookUpEdit.TabIndex = 5;
            // 
            // qtyTextEdit
            // 
            this.qtyTextEdit.Location = new System.Drawing.Point(142, 233);
            this.qtyTextEdit.Name = "qtyTextEdit";
            this.qtyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.qtyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.qtyTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.qtyTextEdit.Properties.AutoHeight = false;
            this.qtyTextEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.qtyTextEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.qtyTextEdit.Size = new System.Drawing.Size(57, 22);
            this.qtyTextEdit.TabIndex = 6;
            this.qtyTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyTextEdit_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 202);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 118;
            this.labelControl1.Text = "Obat / BHP";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 14);
            this.labelControl2.TabIndex = 119;
            this.labelControl2.Text = "Keterangan";
            // 
            // ketTextEdit
            // 
            this.ketTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ketTextEdit.Location = new System.Drawing.Point(142, 155);
            this.ketTextEdit.Name = "ketTextEdit";
            this.ketTextEdit.Properties.AutoHeight = false;
            this.ketTextEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.ketTextEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ketTextEdit.Size = new System.Drawing.Size(641, 22);
            this.ketTextEdit.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 14);
            this.labelControl3.TabIndex = 121;
            this.labelControl3.Text = "Depo Tujuan";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(48, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 14);
            this.labelControl4.TabIndex = 122;
            this.labelControl4.Text = "Depo Asal";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 14);
            this.labelControl5.TabIndex = 123;
            this.labelControl5.Text = "Tgl. Keluar";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 236);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 124;
            this.labelControl6.Text = "QTY";
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.bAdd.Appearance.Options.UseBackColor = true;
            this.bAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.bAdd.Location = new System.Drawing.Point(735, 259);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(48, 22);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(205, 237);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 126;
            this.labelControl7.Text = "satuan";
            // 
            // TFAddEditBarangKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ketTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.qtyTextEdit);
            this.Controls.Add(this.obatLookUpEdit);
            this.Controls.Add(this.listbarangkeluarGC);
            this.Controls.Add(this.depoTujuanLookUpEdit);
            this.Controls.Add(this.depoasalLookUpEdit);
            this.Controls.Add(this.bBatal);
            this.Controls.Add(this.TglKeluarDateEdit);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.bSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TFAddEditBarangKeluar";
            this.Text = "TFAddEditBarangKeluar";
            this.Load += new System.EventHandler(this.TFAddEditBarangKeluar_Load);
            this.Shown += new System.EventHandler(this.TFAddEditBarangKeluar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TglKeluarDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglKeluarDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoasalLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoTujuanLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbarangkeluarGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbarangkeluarGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailrepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton bBatal;
        protected DevExpress.XtraEditors.DateEdit TglKeluarDateEdit;
        private DevExpress.XtraEditors.PanelControl pnlHeader;
        protected MetroFramework.Controls.MetroLink bBack;
        protected DevExpress.XtraEditors.LabelControl lblHeader;
        protected DevExpress.XtraEditors.SimpleButton bSimpan;
        protected MyComponents.MyGridControl listbarangkeluarGC;
        protected MyComponents.MyGridView listbarangkeluarGV;
        protected MyComponents.MyGridColumn colaptdistribusiid1;
        private MyComponents.MyGridColumn coldepoasalid;
        private MyComponents.MyGridColumn coldepotujuanid;
        protected MyComponents.MyGridColumn coltgldistribusi;
        private MyComponents.MyGridColumn coldepotujuannm;
        private MyComponents.MyGridColumn colketdistribusi1;
        private MyComponents.MyGridColumn colonline1;
        private MyComponents.MyGridColumn coltahun;
        private MyComponents.MyGridColumn colbulan;
        private MyComponents.MyGridColumn coldepoasalnm;
        protected MyComponents.MyGridColumn coldetail;
        protected DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit detailrepositoryItemButtonEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        protected DevExpress.XtraEditors.SimpleButton bAdd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        protected DevExpress.XtraEditors.LookUpEdit depoasalLookUpEdit;
        protected DevExpress.XtraEditors.LookUpEdit depoTujuanLookUpEdit;
        protected DevExpress.XtraEditors.TextEdit ketTextEdit;
        protected DevExpress.XtraEditors.LookUpEdit obatLookUpEdit;
        protected DevExpress.XtraEditors.TextEdit qtyTextEdit;
    }
}