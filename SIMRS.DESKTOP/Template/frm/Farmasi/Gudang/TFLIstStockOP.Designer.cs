namespace SIMRS.DESKTOP.Template.frm.Farmasi.Gudang
{
    partial class TFLIstStockOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFLIstStockOP));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.bBack = new MetroFramework.Controls.MetroLink();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.kriteriaCbo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cariDataMTxt1 = new DevExpress.XtraEditors.ButtonEdit();
            this.periodeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bEdit = new DevExpress.XtraEditors.SimpleButton();
            this.bAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pageTxt = new DevExpress.XtraEditors.TextEdit();
            this.bLast = new DevExpress.XtraEditors.SimpleButton();
            this.bNext = new DevExpress.XtraEditors.SimpleButton();
            this.bFirst = new DevExpress.XtraEditors.SimpleButton();
            this.bPrev = new DevExpress.XtraEditors.SimpleButton();
            this.liststockkontrolGC = new SIMRS.DESKTOP.MyComponents.MyGridControl();
            this.vaptstockkontrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liststockkontrolGV = new SIMRS.DESKTOP.MyComponents.MyGridView();
            this.colaptbarangid = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colsts = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colisonline = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colaptbarangnm = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coltahunbulanexpire = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coldefenisisatuan = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.coljmlstock = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colsatuankecil = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colhargaskecil = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colhargapph = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colharga35 = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colhargatoeslag = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.colhargajual = new SIMRS.DESKTOP.MyComponents.MyGridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.defaultXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.detailXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kriteriaCbo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariDataMTxt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liststockkontrolGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaptstockkontrolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liststockkontrolGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.defaultXtraTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHeader.Controls.Add(this.bBack);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 47);
            this.pnlHeader.TabIndex = 89;
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.ImageSize = 24;
            this.bBack.Location = new System.Drawing.Point(750, 4);
            this.bBack.Margin = new System.Windows.Forms.Padding(0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(31, 38);
            this.bBack.TabIndex = 86;
            this.bBack.UseCustomBackColor = true;
            this.bBack.UseSelectable = true;
            this.bBack.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(17, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(154, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "List Stock Barang";
            // 
            // kriteriaCbo
            // 
            this.kriteriaCbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kriteriaCbo.Location = new System.Drawing.Point(677, 58);
            this.kriteriaCbo.Name = "kriteriaCbo";
            this.kriteriaCbo.Properties.AutoHeight = false;
            this.kriteriaCbo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kriteriaCbo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.kriteriaCbo.Properties.LookAndFeel.SkinName = "The Bezier";
            this.kriteriaCbo.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.kriteriaCbo.Properties.NullText = "Kriteria";
            this.kriteriaCbo.Size = new System.Drawing.Size(100, 22);
            this.kriteriaCbo.TabIndex = 92;
            this.kriteriaCbo.SelectedIndexChanged += new System.EventHandler(this.KriteriaCbo_SelectedIndexChanged);
            // 
            // cariDataMTxt1
            // 
            this.cariDataMTxt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cariDataMTxt1.Location = new System.Drawing.Point(576, 58);
            this.cariDataMTxt1.Name = "cariDataMTxt1";
            this.cariDataMTxt1.Properties.AutoHeight = false;
            this.cariDataMTxt1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cariDataMTxt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cariDataMTxt1.Properties.LookAndFeel.SkinName = "The Bezier";
            this.cariDataMTxt1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cariDataMTxt1.Size = new System.Drawing.Size(100, 22);
            this.cariDataMTxt1.TabIndex = 93;
            // 
            // periodeDateEdit
            // 
            this.periodeDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodeDateEdit.EditValue = null;
            this.periodeDateEdit.Location = new System.Drawing.Point(576, 58);
            this.periodeDateEdit.Name = "periodeDateEdit";
            this.periodeDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.periodeDateEdit.Properties.AutoHeight = false;
            this.periodeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodeDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.periodeDateEdit.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.periodeDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.periodeDateEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.periodeDateEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.periodeDateEdit.Properties.Mask.EditMask = "MM/yyyy";
            this.periodeDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.periodeDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.periodeDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.periodeDateEdit.Size = new System.Drawing.Size(100, 22);
            this.periodeDateEdit.TabIndex = 94;
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDelete.Appearance.BackColor = System.Drawing.Color.White;
            this.bDelete.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bDelete.Appearance.Options.UseBackColor = true;
            this.bDelete.Appearance.Options.UseForeColor = true;
            this.bDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.ImageOptions.Image")));
            this.bDelete.Location = new System.Drawing.Point(179, 410);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 26);
            this.bDelete.TabIndex = 97;
            this.bDelete.Text = "Delete";
            this.bDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEdit.Appearance.BackColor = System.Drawing.Color.White;
            this.bEdit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bEdit.Appearance.Options.UseBackColor = true;
            this.bEdit.Appearance.Options.UseForeColor = true;
            this.bEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bEdit.ImageOptions.Image")));
            this.bEdit.Location = new System.Drawing.Point(98, 410);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 26);
            this.bEdit.TabIndex = 96;
            this.bEdit.Text = "Edit";
            this.bEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.Appearance.BackColor = System.Drawing.Color.White;
            this.bAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bAdd.Appearance.Options.UseBackColor = true;
            this.bAdd.Appearance.Options.UseForeColor = true;
            this.bAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bAdd.ImageOptions.Image")));
            this.bAdd.Location = new System.Drawing.Point(17, 410);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 26);
            this.bAdd.TabIndex = 95;
            this.bAdd.Text = "Add";
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // pageTxt
            // 
            this.pageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pageTxt.EditValue = "Page:100";
            this.pageTxt.Location = new System.Drawing.Point(590, 410);
            this.pageTxt.Margin = new System.Windows.Forms.Padding(1);
            this.pageTxt.Name = "pageTxt";
            this.pageTxt.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pageTxt.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.pageTxt.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pageTxt.Properties.Appearance.Options.UseBackColor = true;
            this.pageTxt.Properties.Appearance.Options.UseFont = true;
            this.pageTxt.Properties.Appearance.Options.UseForeColor = true;
            this.pageTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.pageTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pageTxt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pageTxt.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.pageTxt.Properties.AutoHeight = false;
            this.pageTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pageTxt.Properties.ReadOnly = true;
            this.pageTxt.Size = new System.Drawing.Size(61, 26);
            this.pageTxt.TabIndex = 102;
            this.pageTxt.Visible = false;
            // 
            // bLast
            // 
            this.bLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLast.Appearance.BackColor = System.Drawing.Color.White;
            this.bLast.Appearance.Options.UseBackColor = true;
            this.bLast.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bLast.ImageOptions.Image")));
            this.bLast.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.bLast.Location = new System.Drawing.Point(717, 410);
            this.bLast.Name = "bLast";
            this.bLast.Size = new System.Drawing.Size(64, 26);
            this.bLast.TabIndex = 101;
            this.bLast.Text = "LAST";
            this.bLast.Visible = false;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.Appearance.BackColor = System.Drawing.Color.White;
            this.bNext.Appearance.Options.UseBackColor = true;
            this.bNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bNext.ImageOptions.Image")));
            this.bNext.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.bNext.Location = new System.Drawing.Point(652, 410);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(64, 26);
            this.bNext.TabIndex = 100;
            this.bNext.Text = "NEXT";
            this.bNext.Visible = false;
            // 
            // bFirst
            // 
            this.bFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFirst.Appearance.BackColor = System.Drawing.Color.White;
            this.bFirst.Appearance.Options.UseBackColor = true;
            this.bFirst.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bFirst.ImageOptions.Image")));
            this.bFirst.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bFirst.Location = new System.Drawing.Point(460, 410);
            this.bFirst.Name = "bFirst";
            this.bFirst.Size = new System.Drawing.Size(64, 26);
            this.bFirst.TabIndex = 98;
            this.bFirst.Text = "FIRST";
            this.bFirst.Visible = false;
            // 
            // bPrev
            // 
            this.bPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrev.Appearance.BackColor = System.Drawing.Color.White;
            this.bPrev.Appearance.Options.UseBackColor = true;
            this.bPrev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bPrev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bPrev.ImageOptions.Image")));
            this.bPrev.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bPrev.Location = new System.Drawing.Point(525, 410);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(64, 26);
            this.bPrev.TabIndex = 99;
            this.bPrev.Text = "PREV";
            this.bPrev.Visible = false;
            // 
            // liststockkontrolGC
            // 
            this.liststockkontrolGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liststockkontrolGC.DataSource = this.vaptstockkontrolBindingSource;
            this.liststockkontrolGC.Location = new System.Drawing.Point(3, 3);
            this.liststockkontrolGC.LookAndFeel.SkinName = "The Bezier";
            this.liststockkontrolGC.LookAndFeel.UseDefaultLookAndFeel = false;
            this.liststockkontrolGC.MainView = this.liststockkontrolGV;
            this.liststockkontrolGC.Name = "liststockkontrolGC";
            this.liststockkontrolGC.Size = new System.Drawing.Size(756, 311);
            this.liststockkontrolGC.TabIndex = 103;
            this.liststockkontrolGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.liststockkontrolGV});
            // 
            // vaptstockkontrolBindingSource
            // 
            this.vaptstockkontrolBindingSource.DataSource = typeof(SIMRS.Model.view.v_aptstockkontrol);
            // 
            // liststockkontrolGV
            // 
            this.liststockkontrolGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colaptbarangid,
            this.colsts,
            this.colisonline,
            this.colaptbarangnm,
            this.coltahunbulanexpire,
            this.coldefenisisatuan,
            this.coljmlstock,
            this.colsatuankecil,
            this.colhargaskecil,
            this.colhargapph,
            this.colharga35,
            this.colhargatoeslag,
            this.colhargajual});
            this.liststockkontrolGV.GridControl = this.liststockkontrolGC;
            this.liststockkontrolGV.GroupCount = 1;
            this.liststockkontrolGV.Name = "liststockkontrolGV";
            this.liststockkontrolGV.OptionsBehavior.AutoExpandAllGroups = true;
            this.liststockkontrolGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltahunbulanexpire, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.liststockkontrolGV.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.ListstockkontrolGV_CustomDrawCell);
            // 
            // colaptbarangid
            // 
            this.colaptbarangid.FieldName = "aptbarangid";
            this.colaptbarangid.Name = "colaptbarangid";
            // 
            // colsts
            // 
            this.colsts.Caption = "STS";
            this.colsts.FieldName = "stsisonline";
            this.colsts.MaxWidth = 5;
            this.colsts.Name = "colsts";
            this.colsts.OptionsColumn.AllowEdit = false;
            this.colsts.OptionsColumn.AllowFocus = false;
            this.colsts.OptionsColumn.AllowIncrementalSearch = false;
            this.colsts.OptionsColumn.AllowMove = false;
            this.colsts.OptionsColumn.AllowSize = false;
            this.colsts.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsts.OptionsColumn.FixedWidth = true;
            this.colsts.OptionsColumn.ReadOnly = true;
            this.colsts.OptionsColumn.ShowCaption = false;
            this.colsts.OptionsFilter.AllowAutoFilter = false;
            this.colsts.OptionsFilter.AllowFilter = false;
            this.colsts.Visible = true;
            this.colsts.VisibleIndex = 0;
            this.colsts.Width = 5;
            // 
            // colisonline
            // 
            this.colisonline.AppearanceCell.Options.UseTextOptions = true;
            this.colisonline.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisonline.AppearanceHeader.Options.UseTextOptions = true;
            this.colisonline.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisonline.Caption = "ON-LINE";
            this.colisonline.FieldName = "isonline";
            this.colisonline.MaxWidth = 55;
            this.colisonline.MinWidth = 55;
            this.colisonline.Name = "colisonline";
            this.colisonline.OptionsColumn.AllowIncrementalSearch = false;
            this.colisonline.OptionsColumn.AllowMove = false;
            this.colisonline.OptionsColumn.AllowSize = false;
            this.colisonline.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colisonline.OptionsColumn.FixedWidth = true;
            this.colisonline.OptionsFilter.AllowAutoFilter = false;
            this.colisonline.OptionsFilter.AllowFilter = false;
            this.colisonline.Visible = true;
            this.colisonline.VisibleIndex = 1;
            this.colisonline.Width = 55;
            // 
            // colaptbarangnm
            // 
            this.colaptbarangnm.AppearanceHeader.Options.UseTextOptions = true;
            this.colaptbarangnm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaptbarangnm.Caption = "NAMA BARANG";
            this.colaptbarangnm.FieldName = "aptbarangnm";
            this.colaptbarangnm.Name = "colaptbarangnm";
            this.colaptbarangnm.OptionsColumn.AllowEdit = false;
            this.colaptbarangnm.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colaptbarangnm.OptionsFilter.AllowAutoFilter = false;
            this.colaptbarangnm.OptionsFilter.AllowFilter = false;
            this.colaptbarangnm.Visible = true;
            this.colaptbarangnm.VisibleIndex = 2;
            this.colaptbarangnm.Width = 34;
            // 
            // coltahunbulanexpire
            // 
            this.coltahunbulanexpire.AppearanceCell.Options.UseTextOptions = true;
            this.coltahunbulanexpire.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltahunbulanexpire.AppearanceHeader.Options.UseTextOptions = true;
            this.coltahunbulanexpire.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltahunbulanexpire.Caption = "THN-BLN EXP";
            this.coltahunbulanexpire.FieldName = "tahunbulanexpire";
            this.coltahunbulanexpire.MaxWidth = 60;
            this.coltahunbulanexpire.Name = "coltahunbulanexpire";
            this.coltahunbulanexpire.OptionsColumn.AllowEdit = false;
            this.coltahunbulanexpire.OptionsColumn.AllowIncrementalSearch = false;
            this.coltahunbulanexpire.OptionsColumn.AllowMove = false;
            this.coltahunbulanexpire.OptionsColumn.AllowSize = false;
            this.coltahunbulanexpire.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltahunbulanexpire.OptionsColumn.FixedWidth = true;
            this.coltahunbulanexpire.OptionsFilter.AllowAutoFilter = false;
            this.coltahunbulanexpire.OptionsFilter.AllowFilter = false;
            this.coltahunbulanexpire.Visible = true;
            this.coltahunbulanexpire.VisibleIndex = 2;
            this.coltahunbulanexpire.Width = 60;
            // 
            // coldefenisisatuan
            // 
            this.coldefenisisatuan.AppearanceHeader.Options.UseTextOptions = true;
            this.coldefenisisatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldefenisisatuan.Caption = "KEMASAN";
            this.coldefenisisatuan.FieldName = "defenisisatuan";
            this.coldefenisisatuan.MaxWidth = 90;
            this.coldefenisisatuan.MinWidth = 90;
            this.coldefenisisatuan.Name = "coldefenisisatuan";
            this.coldefenisisatuan.OptionsColumn.AllowEdit = false;
            this.coldefenisisatuan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coldefenisisatuan.OptionsColumn.AllowIncrementalSearch = false;
            this.coldefenisisatuan.OptionsColumn.AllowMove = false;
            this.coldefenisisatuan.OptionsColumn.AllowSize = false;
            this.coldefenisisatuan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldefenisisatuan.OptionsColumn.FixedWidth = true;
            this.coldefenisisatuan.OptionsFilter.AllowAutoFilter = false;
            this.coldefenisisatuan.OptionsFilter.AllowFilter = false;
            this.coldefenisisatuan.Visible = true;
            this.coldefenisisatuan.VisibleIndex = 3;
            this.coldefenisisatuan.Width = 90;
            // 
            // coljmlstock
            // 
            this.coljmlstock.AppearanceCell.Options.UseTextOptions = true;
            this.coljmlstock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coljmlstock.AppearanceHeader.Options.UseTextOptions = true;
            this.coljmlstock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coljmlstock.Caption = "STOCK";
            this.coljmlstock.DisplayFormat.FormatString = "#,0";
            this.coljmlstock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coljmlstock.FieldName = "jmlstock";
            this.coljmlstock.MinWidth = 55;
            this.coljmlstock.Name = "coljmlstock";
            this.coljmlstock.OptionsColumn.AllowEdit = false;
            this.coljmlstock.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coljmlstock.OptionsColumn.AllowIncrementalSearch = false;
            this.coljmlstock.OptionsColumn.AllowMove = false;
            this.coljmlstock.OptionsColumn.AllowSize = false;
            this.coljmlstock.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coljmlstock.OptionsColumn.FixedWidth = true;
            this.coljmlstock.OptionsFilter.AllowAutoFilter = false;
            this.coljmlstock.OptionsFilter.AllowFilter = false;
            this.coljmlstock.Visible = true;
            this.coljmlstock.VisibleIndex = 4;
            this.coljmlstock.Width = 55;
            // 
            // colsatuankecil
            // 
            this.colsatuankecil.AppearanceCell.Options.UseTextOptions = true;
            this.colsatuankecil.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsatuankecil.AppearanceHeader.Options.UseTextOptions = true;
            this.colsatuankecil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsatuankecil.Caption = "SATUAN";
            this.colsatuankecil.FieldName = "satuankecil";
            this.colsatuankecil.MaxWidth = 60;
            this.colsatuankecil.MinWidth = 60;
            this.colsatuankecil.Name = "colsatuankecil";
            this.colsatuankecil.OptionsColumn.AllowEdit = false;
            this.colsatuankecil.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colsatuankecil.OptionsColumn.AllowMove = false;
            this.colsatuankecil.OptionsColumn.AllowSize = false;
            this.colsatuankecil.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsatuankecil.OptionsColumn.FixedWidth = true;
            this.colsatuankecil.OptionsFilter.AllowAutoFilter = false;
            this.colsatuankecil.OptionsFilter.AllowFilter = false;
            this.colsatuankecil.Visible = true;
            this.colsatuankecil.VisibleIndex = 5;
            this.colsatuankecil.Width = 60;
            // 
            // colhargaskecil
            // 
            this.colhargaskecil.AppearanceCell.Options.UseTextOptions = true;
            this.colhargaskecil.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargaskecil.AppearanceHeader.Options.UseTextOptions = true;
            this.colhargaskecil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargaskecil.Caption = "HRG.SATUAN";
            this.colhargaskecil.DisplayFormat.FormatString = "#,#.##";
            this.colhargaskecil.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhargaskecil.FieldName = "hargaskecil";
            this.colhargaskecil.MaxWidth = 90;
            this.colhargaskecil.MinWidth = 90;
            this.colhargaskecil.Name = "colhargaskecil";
            this.colhargaskecil.OptionsColumn.AllowEdit = false;
            this.colhargaskecil.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colhargaskecil.OptionsColumn.AllowIncrementalSearch = false;
            this.colhargaskecil.OptionsColumn.AllowMove = false;
            this.colhargaskecil.OptionsColumn.AllowSize = false;
            this.colhargaskecil.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colhargaskecil.OptionsColumn.FixedWidth = true;
            this.colhargaskecil.OptionsFilter.AllowAutoFilter = false;
            this.colhargaskecil.OptionsFilter.AllowFilter = false;
            this.colhargaskecil.Visible = true;
            this.colhargaskecil.VisibleIndex = 6;
            this.colhargaskecil.Width = 90;
            // 
            // colhargapph
            // 
            this.colhargapph.AppearanceCell.Options.UseTextOptions = true;
            this.colhargapph.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargapph.AppearanceHeader.Options.UseTextOptions = true;
            this.colhargapph.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargapph.Caption = "HRG.PPN";
            this.colhargapph.DisplayFormat.FormatString = "#,#.##";
            this.colhargapph.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhargapph.FieldName = "hargapph";
            this.colhargapph.MaxWidth = 90;
            this.colhargapph.MinWidth = 90;
            this.colhargapph.Name = "colhargapph";
            this.colhargapph.OptionsColumn.AllowEdit = false;
            this.colhargapph.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colhargapph.OptionsColumn.AllowIncrementalSearch = false;
            this.colhargapph.OptionsColumn.AllowMove = false;
            this.colhargapph.OptionsColumn.AllowSize = false;
            this.colhargapph.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colhargapph.OptionsColumn.FixedWidth = true;
            this.colhargapph.OptionsFilter.AllowAutoFilter = false;
            this.colhargapph.OptionsFilter.AllowFilter = false;
            this.colhargapph.Visible = true;
            this.colhargapph.VisibleIndex = 7;
            this.colhargapph.Width = 80;
            // 
            // colharga35
            // 
            this.colharga35.AppearanceCell.Options.UseTextOptions = true;
            this.colharga35.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colharga35.AppearanceHeader.Options.UseTextOptions = true;
            this.colharga35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colharga35.Caption = "HRG.+35";
            this.colharga35.DisplayFormat.FormatString = "#,#.##";
            this.colharga35.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colharga35.FieldName = "harga35";
            this.colharga35.MaxWidth = 90;
            this.colharga35.MinWidth = 90;
            this.colharga35.Name = "colharga35";
            this.colharga35.OptionsColumn.AllowEdit = false;
            this.colharga35.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colharga35.OptionsColumn.AllowIncrementalSearch = false;
            this.colharga35.OptionsColumn.AllowMove = false;
            this.colharga35.OptionsColumn.AllowSize = false;
            this.colharga35.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colharga35.OptionsColumn.FixedWidth = true;
            this.colharga35.OptionsFilter.AllowAutoFilter = false;
            this.colharga35.OptionsFilter.AllowFilter = false;
            this.colharga35.Visible = true;
            this.colharga35.VisibleIndex = 8;
            this.colharga35.Width = 90;
            // 
            // colhargatoeslag
            // 
            this.colhargatoeslag.AppearanceCell.Options.UseTextOptions = true;
            this.colhargatoeslag.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargatoeslag.AppearanceHeader.Options.UseTextOptions = true;
            this.colhargatoeslag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargatoeslag.Caption = "HRG.TOESLAG";
            this.colhargatoeslag.DisplayFormat.FormatString = "#,#.##";
            this.colhargatoeslag.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhargatoeslag.FieldName = "hargatoeslag";
            this.colhargatoeslag.MaxWidth = 90;
            this.colhargatoeslag.MinWidth = 90;
            this.colhargatoeslag.Name = "colhargatoeslag";
            this.colhargatoeslag.OptionsColumn.AllowEdit = false;
            this.colhargatoeslag.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colhargatoeslag.OptionsColumn.AllowIncrementalSearch = false;
            this.colhargatoeslag.OptionsColumn.AllowMove = false;
            this.colhargatoeslag.OptionsColumn.AllowSize = false;
            this.colhargatoeslag.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colhargatoeslag.OptionsColumn.FixedWidth = true;
            this.colhargatoeslag.OptionsFilter.AllowAutoFilter = false;
            this.colhargatoeslag.OptionsFilter.AllowFilter = false;
            this.colhargatoeslag.Visible = true;
            this.colhargatoeslag.VisibleIndex = 9;
            this.colhargatoeslag.Width = 80;
            // 
            // colhargajual
            // 
            this.colhargajual.AppearanceCell.Options.UseTextOptions = true;
            this.colhargajual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargajual.AppearanceHeader.Options.UseTextOptions = true;
            this.colhargajual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colhargajual.Caption = "HRG.JUAL";
            this.colhargajual.DisplayFormat.FormatString = "#,#.##";
            this.colhargajual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhargajual.FieldName = "hargajual";
            this.colhargajual.MaxWidth = 90;
            this.colhargajual.MinWidth = 90;
            this.colhargajual.Name = "colhargajual";
            this.colhargajual.OptionsColumn.AllowEdit = false;
            this.colhargajual.OptionsColumn.AllowIncrementalSearch = false;
            this.colhargajual.OptionsColumn.AllowSize = false;
            this.colhargajual.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colhargajual.OptionsColumn.FixedWidth = true;
            this.colhargajual.OptionsFilter.AllowAutoFilter = false;
            this.colhargajual.OptionsFilter.AllowFilter = false;
            this.colhargajual.Visible = true;
            this.colhargajual.VisibleIndex = 10;
            this.colhargajual.Width = 80;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Location = new System.Drawing.Point(17, 58);
            this.xtraTabControl1.LookAndFeel.SkinName = "The Bezier";
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.defaultXtraTabPage;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(764, 346);
            this.xtraTabControl1.TabIndex = 107;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.defaultXtraTabPage,
            this.detailXtraTabPage});
            // 
            // defaultXtraTabPage
            // 
            this.defaultXtraTabPage.Controls.Add(this.liststockkontrolGC);
            this.defaultXtraTabPage.Name = "defaultXtraTabPage";
            this.defaultXtraTabPage.Size = new System.Drawing.Size(762, 317);
            this.defaultXtraTabPage.Text = "Default";
            // 
            // detailXtraTabPage
            // 
            this.detailXtraTabPage.Name = "detailXtraTabPage";
            this.detailXtraTabPage.Size = new System.Drawing.Size(762, 321);
            this.detailXtraTabPage.Text = "Detail";
            // 
            // TFLIstStockOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.kriteriaCbo);
            this.Controls.Add(this.pageTxt);
            this.Controls.Add(this.bLast);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bFirst);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.periodeDateEdit);
            this.Controls.Add(this.cariDataMTxt1);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TFLIstStockOP";
            this.Text = "TFStockOP";
            this.Load += new System.EventHandler(this.TFLIstStockOP_Load);
            this.Shown += new System.EventHandler(this.TFLIstStockOP_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kriteriaCbo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariDataMTxt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liststockkontrolGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaptstockkontrolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liststockkontrolGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.defaultXtraTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlHeader;
        protected MetroFramework.Controls.MetroLink bBack;
        protected DevExpress.XtraEditors.LabelControl lblHeader;
        protected DevExpress.XtraEditors.ComboBoxEdit kriteriaCbo;
        protected DevExpress.XtraEditors.ButtonEdit cariDataMTxt1;
        protected DevExpress.XtraEditors.DateEdit periodeDateEdit;
        protected DevExpress.XtraEditors.SimpleButton bDelete;
        protected DevExpress.XtraEditors.SimpleButton bEdit;
        protected DevExpress.XtraEditors.SimpleButton bAdd;
        protected DevExpress.XtraEditors.TextEdit pageTxt;
        protected DevExpress.XtraEditors.SimpleButton bLast;
        protected DevExpress.XtraEditors.SimpleButton bNext;
        protected DevExpress.XtraEditors.SimpleButton bFirst;
        protected DevExpress.XtraEditors.SimpleButton bPrev;
        private System.Windows.Forms.BindingSource vaptstockkontrolBindingSource;
        private MyComponents.MyGridColumn colaptbarangid;
        private MyComponents.MyGridColumn colisonline;
        private MyComponents.MyGridColumn colaptbarangnm;
        private MyComponents.MyGridColumn coltahunbulanexpire;
        private MyComponents.MyGridColumn coldefenisisatuan;
        private MyComponents.MyGridColumn coljmlstock;
        private MyComponents.MyGridColumn colsatuankecil;
        private MyComponents.MyGridColumn colhargaskecil;
        private MyComponents.MyGridColumn colhargapph;
        private MyComponents.MyGridColumn colharga35;
        private MyComponents.MyGridColumn colhargatoeslag;
        private MyComponents.MyGridColumn colhargajual;
        protected MyComponents.MyGridControl liststockkontrolGC;
        protected MyComponents.MyGridView liststockkontrolGV;
        protected DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        protected DevExpress.XtraTab.XtraTabPage defaultXtraTabPage;
        protected DevExpress.XtraTab.XtraTabPage detailXtraTabPage;
        protected MyComponents.MyGridColumn colsts;
    }
}