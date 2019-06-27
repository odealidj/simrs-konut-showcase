namespace SIMRS.DESKTOP.Template.frm
{
    partial class FPengobatanPasien
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPengobatanPasien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc1 = new DevExpress.XtraGrid.GridControl();
            this.vpengobatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpengobatanid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistrasiruangrawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltglperiksa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluraian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldokternm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperawatnm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleterepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colpengobatannm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colukuran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsatuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaturanpakai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldokterid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddPengobatan = new MetroFramework.Controls.MetroButton();
            this.aturanlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.satuanlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ukuranlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pengobatannmlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.perawatLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dokterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.kelasMTxt = new MetroFramework.Controls.MetroTextBox();
            this.ruangrawatMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tglperiksadateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpengobatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleterepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aturanlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukuranlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengobatannmlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglperiksadateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglperiksadateEdit.Properties)).BeginInit();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gc1);
            this.panel1.Controls.Add(this.btnAddPengobatan);
            this.panel1.Controls.Add(this.aturanlookUpEdit);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.satuanlookUpEdit);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.ukuranlookUpEdit);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.pengobatannmlookUpEdit);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.perawatLookUpEdit);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.dokterLookUpEdit);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.kelasMTxt);
            this.panel1.Controls.Add(this.ruangrawatMTxt);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.tglperiksadateEdit);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 514);
            this.panel1.TabIndex = 6;
            // 
            // gc1
            // 
            this.gc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc1.DataSource = this.vpengobatanBindingSource;
            this.gc1.Location = new System.Drawing.Point(54, 329);
            this.gc1.MainView = this.gv1;
            this.gc1.Name = "gc1";
            this.gc1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deleterepositoryItemButtonEdit});
            this.gc1.Size = new System.Drawing.Size(628, 168);
            this.gc1.TabIndex = 10;
            this.gc1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1});
            // 
            // vpengobatanBindingSource
            // 
            this.vpengobatanBindingSource.DataSource = typeof(SIMRS.Model.view.v_pengobatan);
            // 
            // gv1
            // 
            this.gv1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpengobatanid,
            this.colregistrasiruangrawatid,
            this.coltglperiksa,
            this.coluraian,
            this.coldokternm,
            this.colperawatnm,
            this.colDelete,
            this.colpengobatannm,
            this.colukuran,
            this.colsatuan,
            this.colaturanpakai,
            this.colperawatid,
            this.coldokterid});
            this.gv1.GridControl = this.gc1;
            this.gv1.Name = "gv1";
            this.gv1.OptionsView.RowAutoHeight = true;
            this.gv1.OptionsView.ShowGroupPanel = false;
            this.gv1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv1_RowClick);
            this.gv1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv1_RowCellClick);
            this.gv1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv1_FocusedRowChanged);
            // 
            // colpengobatanid
            // 
            this.colpengobatanid.FieldName = "pengobatanid";
            this.colpengobatanid.Name = "colpengobatanid";
            // 
            // colregistrasiruangrawatid
            // 
            this.colregistrasiruangrawatid.FieldName = "registrasiruangrawatid";
            this.colregistrasiruangrawatid.Name = "colregistrasiruangrawatid";
            // 
            // coltglperiksa
            // 
            this.coltglperiksa.Caption = "TGL.PERIKSA";
            this.coltglperiksa.FieldName = "tglperiksa";
            this.coltglperiksa.MaxWidth = 80;
            this.coltglperiksa.MinWidth = 80;
            this.coltglperiksa.Name = "coltglperiksa";
            this.coltglperiksa.OptionsColumn.AllowEdit = false;
            this.coltglperiksa.OptionsColumn.FixedWidth = true;
            this.coltglperiksa.Visible = true;
            this.coltglperiksa.VisibleIndex = 0;
            this.coltglperiksa.Width = 80;
            // 
            // coluraian
            // 
            this.coluraian.Caption = "URAIAN";
            this.coluraian.FieldName = "uraian";
            this.coluraian.Name = "coluraian";
            this.coluraian.OptionsColumn.AllowEdit = false;
            this.coluraian.Visible = true;
            this.coluraian.VisibleIndex = 1;
            this.coluraian.Width = 125;
            // 
            // coldokternm
            // 
            this.coldokternm.Caption = "DOKTER";
            this.coldokternm.FieldName = "dokternm";
            this.coldokternm.MaxWidth = 175;
            this.coldokternm.MinWidth = 175;
            this.coldokternm.Name = "coldokternm";
            this.coldokternm.OptionsColumn.AllowEdit = false;
            this.coldokternm.Visible = true;
            this.coldokternm.VisibleIndex = 2;
            this.coldokternm.Width = 175;
            // 
            // colperawatnm
            // 
            this.colperawatnm.Caption = "PERAWAT";
            this.colperawatnm.FieldName = "perawatnm";
            this.colperawatnm.MaxWidth = 175;
            this.colperawatnm.MinWidth = 175;
            this.colperawatnm.Name = "colperawatnm";
            this.colperawatnm.OptionsColumn.AllowEdit = false;
            this.colperawatnm.Visible = true;
            this.colperawatnm.VisibleIndex = 3;
            this.colperawatnm.Width = 175;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "gridColumn1";
            this.colDelete.ColumnEdit = this.deleterepositoryItemButtonEdit;
            this.colDelete.MaxWidth = 55;
            this.colDelete.MinWidth = 55;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.FixedWidth = true;
            this.colDelete.OptionsColumn.ShowCaption = false;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 4;
            this.colDelete.Width = 55;
            // 
            // deleterepositoryItemButtonEdit
            // 
            this.deleterepositoryItemButtonEdit.AutoHeight = false;
            this.deleterepositoryItemButtonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = global::SIMRS.DESKTOP.Properties.Resources.icons8_delete_16;
            this.deleterepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.deleterepositoryItemButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.deleterepositoryItemButtonEdit.Name = "deleterepositoryItemButtonEdit";
            this.deleterepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.deleterepositoryItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.deleterepositoryItemButtonEdit_ButtonClick);
            // 
            // colpengobatannm
            // 
            this.colpengobatannm.FieldName = "pengobatannm";
            this.colpengobatannm.Name = "colpengobatannm";
            // 
            // colukuran
            // 
            this.colukuran.FieldName = "ukuran";
            this.colukuran.Name = "colukuran";
            // 
            // colsatuan
            // 
            this.colsatuan.FieldName = "satuan";
            this.colsatuan.Name = "colsatuan";
            // 
            // colaturanpakai
            // 
            this.colaturanpakai.FieldName = "aturanpakai";
            this.colaturanpakai.Name = "colaturanpakai";
            this.colaturanpakai.Width = 111;
            // 
            // colperawatid
            // 
            this.colperawatid.FieldName = "perawatid";
            this.colperawatid.Name = "colperawatid";
            // 
            // coldokterid
            // 
            this.coldokterid.FieldName = "dokterid";
            this.coldokterid.Name = "coldokterid";
            // 
            // btnAddPengobatan
            // 
            this.btnAddPengobatan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPengobatan.Location = new System.Drawing.Point(606, 289);
            this.btnAddPengobatan.Name = "btnAddPengobatan";
            this.btnAddPengobatan.Size = new System.Drawing.Size(75, 23);
            this.btnAddPengobatan.TabIndex = 9;
            this.btnAddPengobatan.Text = "Add";
            this.btnAddPengobatan.UseSelectable = true;
            this.btnAddPengobatan.Click += new System.EventHandler(this.btnAddPengobatan_Click);
            // 
            // aturanlookUpEdit
            // 
            this.aturanlookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aturanlookUpEdit.Location = new System.Drawing.Point(145, 263);
            this.aturanlookUpEdit.Name = "aturanlookUpEdit";
            this.aturanlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aturanlookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.aturanlookUpEdit.TabIndex = 8;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(54, 264);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 47;
            this.metroLabel9.Text = "Aturan Pakai";
            // 
            // satuanlookUpEdit
            // 
            this.satuanlookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.satuanlookUpEdit.Location = new System.Drawing.Point(145, 237);
            this.satuanlookUpEdit.Name = "satuanlookUpEdit";
            this.satuanlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.satuanlookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.satuanlookUpEdit.TabIndex = 7;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(54, 238);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Satuan";
            // 
            // ukuranlookUpEdit
            // 
            this.ukuranlookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ukuranlookUpEdit.Location = new System.Drawing.Point(145, 211);
            this.ukuranlookUpEdit.Name = "ukuranlookUpEdit";
            this.ukuranlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ukuranlookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.ukuranlookUpEdit.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(54, 212);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 43;
            this.metroLabel7.Text = "Ukuran";
            // 
            // pengobatannmlookUpEdit
            // 
            this.pengobatannmlookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pengobatannmlookUpEdit.Location = new System.Drawing.Point(145, 185);
            this.pengobatannmlookUpEdit.Name = "pengobatannmlookUpEdit";
            this.pengobatannmlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pengobatannmlookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.pengobatannmlookUpEdit.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Uraian";
            // 
            // perawatLookUpEdit
            // 
            this.perawatLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perawatLookUpEdit.Location = new System.Drawing.Point(145, 159);
            this.perawatLookUpEdit.Name = "perawatLookUpEdit";
            this.perawatLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.perawatLookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.perawatLookUpEdit.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(54, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Perawat";
            // 
            // dokterLookUpEdit
            // 
            this.dokterLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dokterLookUpEdit.Location = new System.Drawing.Point(145, 133);
            this.dokterLookUpEdit.Name = "dokterLookUpEdit";
            this.dokterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dokterLookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.dokterLookUpEdit.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 134);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Dokter";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(54, 78);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Kelas";
            // 
            // kelasMTxt
            // 
            this.kelasMTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.kelasMTxt.CustomButton.Image = null;
            this.kelasMTxt.CustomButton.Location = new System.Drawing.Point(514, 1);
            this.kelasMTxt.CustomButton.Name = "";
            this.kelasMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kelasMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kelasMTxt.CustomButton.TabIndex = 1;
            this.kelasMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kelasMTxt.CustomButton.UseSelectable = true;
            this.kelasMTxt.CustomButton.Visible = false;
            this.kelasMTxt.Lines = new string[0];
            this.kelasMTxt.Location = new System.Drawing.Point(145, 78);
            this.kelasMTxt.MaxLength = 32767;
            this.kelasMTxt.Name = "kelasMTxt";
            this.kelasMTxt.PasswordChar = '\0';
            this.kelasMTxt.ReadOnly = true;
            this.kelasMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kelasMTxt.SelectedText = "";
            this.kelasMTxt.SelectionLength = 0;
            this.kelasMTxt.SelectionStart = 0;
            this.kelasMTxt.ShortcutsEnabled = true;
            this.kelasMTxt.Size = new System.Drawing.Size(536, 23);
            this.kelasMTxt.TabIndex = 1;
            this.kelasMTxt.UseSelectable = true;
            this.kelasMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kelasMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ruangrawatMTxt
            // 
            this.ruangrawatMTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ruangrawatMTxt.CustomButton.Image = null;
            this.ruangrawatMTxt.CustomButton.Location = new System.Drawing.Point(514, 1);
            this.ruangrawatMTxt.CustomButton.Name = "";
            this.ruangrawatMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ruangrawatMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ruangrawatMTxt.CustomButton.TabIndex = 1;
            this.ruangrawatMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ruangrawatMTxt.CustomButton.UseSelectable = true;
            this.ruangrawatMTxt.CustomButton.Visible = false;
            this.ruangrawatMTxt.Lines = new string[0];
            this.ruangrawatMTxt.Location = new System.Drawing.Point(145, 49);
            this.ruangrawatMTxt.MaxLength = 32767;
            this.ruangrawatMTxt.Name = "ruangrawatMTxt";
            this.ruangrawatMTxt.PasswordChar = '\0';
            this.ruangrawatMTxt.ReadOnly = true;
            this.ruangrawatMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ruangrawatMTxt.SelectedText = "";
            this.ruangrawatMTxt.SelectionLength = 0;
            this.ruangrawatMTxt.SelectionStart = 0;
            this.ruangrawatMTxt.ShortcutsEnabled = true;
            this.ruangrawatMTxt.Size = new System.Drawing.Size(536, 23);
            this.ruangrawatMTxt.TabIndex = 0;
            this.ruangrawatMTxt.UseSelectable = true;
            this.ruangrawatMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ruangrawatMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(54, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Ruang Rawat";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Tgl. Periksa";
            // 
            // tglperiksadateEdit
            // 
            this.tglperiksadateEdit.EditValue = null;
            this.tglperiksadateEdit.Location = new System.Drawing.Point(145, 107);
            this.tglperiksadateEdit.Name = "tglperiksadateEdit";
            this.tglperiksadateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglperiksadateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglperiksadateEdit.Size = new System.Drawing.Size(100, 20);
            this.tglperiksadateEdit.TabIndex = 2;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(752, 31);
            this.pHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseCustomBackColor = true;
            this.lblTitle.UseCustomForeColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = 32;
            this.btnBack.Location = new System.Drawing.Point(739, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 28;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FPengobatanPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPengobatanPasien";
            this.Text = "Pengobatan Pasien";
            this.Shown += new System.EventHandler(this.FPengobatanPasien_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpengobatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleterepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aturanlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukuranlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengobatannmlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglperiksadateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglperiksadateEdit.Properties)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected DevExpress.XtraEditors.LookUpEdit perawatLookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        protected DevExpress.XtraEditors.LookUpEdit dokterLookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        protected MetroFramework.Controls.MetroTextBox kelasMTxt;
        protected MetroFramework.Controls.MetroTextBox ruangrawatMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        protected DevExpress.XtraEditors.DateEdit tglperiksadateEdit;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLabel lblTitle;
        protected DevExpress.XtraEditors.LookUpEdit aturanlookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        protected DevExpress.XtraEditors.LookUpEdit satuanlookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        protected DevExpress.XtraEditors.LookUpEdit ukuranlookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        protected DevExpress.XtraEditors.LookUpEdit pengobatannmlookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        protected DevExpress.XtraGrid.GridControl gc1;
        private System.Windows.Forms.BindingSource vpengobatanBindingSource;
        protected DevExpress.XtraGrid.Views.Grid.GridView gv1;
        public MetroFramework.Controls.MetroButton btnAddPengobatan;
        protected DevExpress.XtraGrid.Columns.GridColumn colpengobatanid;
        protected DevExpress.XtraGrid.Columns.GridColumn colregistrasiruangrawatid;
        protected DevExpress.XtraGrid.Columns.GridColumn coltglperiksa;
        protected DevExpress.XtraGrid.Columns.GridColumn coluraian;
        protected DevExpress.XtraGrid.Columns.GridColumn coldokternm;
        protected DevExpress.XtraGrid.Columns.GridColumn colperawatnm;
        protected DevExpress.XtraGrid.Columns.GridColumn colDelete;
        protected DevExpress.XtraGrid.Columns.GridColumn colpengobatannm;
        protected DevExpress.XtraGrid.Columns.GridColumn colukuran;
        protected DevExpress.XtraGrid.Columns.GridColumn colsatuan;
        protected DevExpress.XtraGrid.Columns.GridColumn colaturanpakai;
        protected DevExpress.XtraGrid.Columns.GridColumn colperawatid;
        protected DevExpress.XtraGrid.Columns.GridColumn coldokterid;
        protected MetroFramework.Controls.MetroLink btnBack;
        protected DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleterepositoryItemButtonEdit;
    }
}