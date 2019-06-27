namespace SIMRS.DESKTOP.Template.frm
{
    partial class FAnamnesaPasien
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAnamnesaPasien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.kelasMTxt = new MetroFramework.Controls.MetroTextBox();
            this.ruangrawatMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gc1 = new DevExpress.XtraGrid.GridControl();
            this.vanamnesapasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colanamnesapasienid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistrasiruangrawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltglperiksa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkeluhanutama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.keluhanrepositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.coldokternm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperawatnm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldokterid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleterepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAddAnamnesa = new MetroFramework.Controls.MetroButton();
            this.perawatLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dokterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.keluhanTambahanMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tglperiksadateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanamnesapasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keluhanrepositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleterepositoryItemButtonEdit)).BeginInit();
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
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.kelasMTxt);
            this.panel1.Controls.Add(this.ruangrawatMTxt);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.gc1);
            this.panel1.Controls.Add(this.btnAddAnamnesa);
            this.panel1.Controls.Add(this.perawatLookUpEdit);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.dokterLookUpEdit);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.keluhanTambahanMTxt);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.tglperiksadateEdit);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Location = new System.Drawing.Point(20, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 564);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(54, 100);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 23;
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
            this.kelasMTxt.Location = new System.Drawing.Point(145, 100);
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
            this.kelasMTxt.TabIndex = 2;
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
            this.ruangrawatMTxt.Location = new System.Drawing.Point(145, 71);
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
            this.ruangrawatMTxt.TabIndex = 1;
            this.ruangrawatMTxt.UseSelectable = true;
            this.ruangrawatMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ruangrawatMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(54, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Ruang Rawat";
            // 
            // gc1
            // 
            this.gc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc1.DataSource = this.vanamnesapasienBindingSource;
            this.gc1.Location = new System.Drawing.Point(53, 331);
            this.gc1.MainView = this.gv1;
            this.gc1.Name = "gc1";
            this.gc1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deleterepositoryItemButtonEdit,
            this.keluhanrepositoryItemMemoEdit});
            this.gc1.Size = new System.Drawing.Size(628, 198);
            this.gc1.TabIndex = 8;
            this.gc1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1});
            // 
            // vanamnesapasienBindingSource
            // 
            this.vanamnesapasienBindingSource.DataSource = typeof(SIMRS.Model.view.v_anamnesapasien);
            // 
            // gv1
            // 
            this.gv1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colanamnesapasienid,
            this.colregistrasiruangrawatid,
            this.coltglperiksa,
            this.colkeluhanutama,
            this.coldokternm,
            this.colperawatnm,
            this.colperawatid,
            this.coldokterid,
            this.colDelete});
            this.gv1.GridControl = this.gc1;
            this.gv1.Name = "gv1";
            this.gv1.OptionsView.RowAutoHeight = true;
            this.gv1.OptionsView.ShowGroupPanel = false;
            this.gv1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv1_RowClick);
            this.gv1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv1_RowCellClick);
            this.gv1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv1_FocusedRowChanged);
            // 
            // colanamnesapasienid
            // 
            this.colanamnesapasienid.FieldName = "anamnesapasienid";
            this.colanamnesapasienid.Name = "colanamnesapasienid";
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
            this.coltglperiksa.MaxWidth = 75;
            this.coltglperiksa.Name = "coltglperiksa";
            this.coltglperiksa.OptionsColumn.AllowEdit = false;
            this.coltglperiksa.Visible = true;
            this.coltglperiksa.VisibleIndex = 0;
            this.coltglperiksa.Width = 58;
            // 
            // colkeluhanutama
            // 
            this.colkeluhanutama.Caption = "KELUHAN";
            this.colkeluhanutama.ColumnEdit = this.keluhanrepositoryItemMemoEdit;
            this.colkeluhanutama.FieldName = "keluhanutama";
            this.colkeluhanutama.Name = "colkeluhanutama";
            this.colkeluhanutama.OptionsColumn.AllowEdit = false;
            this.colkeluhanutama.Visible = true;
            this.colkeluhanutama.VisibleIndex = 1;
            this.colkeluhanutama.Width = 145;
            // 
            // keluhanrepositoryItemMemoEdit
            // 
            this.keluhanrepositoryItemMemoEdit.Name = "keluhanrepositoryItemMemoEdit";
            // 
            // coldokternm
            // 
            this.coldokternm.Caption = "DOKTER";
            this.coldokternm.FieldName = "dokternm";
            this.coldokternm.MaxWidth = 180;
            this.coldokternm.MinWidth = 180;
            this.coldokternm.Name = "coldokternm";
            this.coldokternm.OptionsColumn.AllowEdit = false;
            this.coldokternm.Visible = true;
            this.coldokternm.VisibleIndex = 2;
            this.coldokternm.Width = 180;
            // 
            // colperawatnm
            // 
            this.colperawatnm.Caption = "PERAWAT";
            this.colperawatnm.FieldName = "perawatnm";
            this.colperawatnm.MaxWidth = 180;
            this.colperawatnm.MinWidth = 180;
            this.colperawatnm.Name = "colperawatnm";
            this.colperawatnm.OptionsColumn.AllowEdit = false;
            this.colperawatnm.Visible = true;
            this.colperawatnm.VisibleIndex = 3;
            this.colperawatnm.Width = 180;
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
            // colDelete
            // 
            this.colDelete.Caption = "gridColumn1";
            this.colDelete.ColumnEdit = this.deleterepositoryItemButtonEdit;
            this.colDelete.MaxWidth = 70;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.FixedWidth = true;
            this.colDelete.OptionsColumn.ShowCaption = false;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 4;
            this.colDelete.Width = 70;
            // 
            // deleterepositoryItemButtonEdit
            // 
            this.deleterepositoryItemButtonEdit.AutoHeight = false;
            this.deleterepositoryItemButtonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.Image = global::SIMRS.DESKTOP.Properties.Resources.icons8_delete_16;
            this.deleterepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.deleterepositoryItemButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.deleterepositoryItemButtonEdit.Name = "deleterepositoryItemButtonEdit";
            this.deleterepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.deleterepositoryItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.deleterepositoryItemButtonEdit_ButtonClick);
            // 
            // btnAddAnamnesa
            // 
            this.btnAddAnamnesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnamnesa.Location = new System.Drawing.Point(606, 292);
            this.btnAddAnamnesa.Name = "btnAddAnamnesa";
            this.btnAddAnamnesa.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnamnesa.TabIndex = 7;
            this.btnAddAnamnesa.Text = "Add";
            this.btnAddAnamnesa.UseSelectable = true;
            this.btnAddAnamnesa.Click += new System.EventHandler(this.btnAddAnamnesa_Click);
            // 
            // perawatLookUpEdit
            // 
            this.perawatLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perawatLookUpEdit.Location = new System.Drawing.Point(145, 255);
            this.perawatLookUpEdit.Name = "perawatLookUpEdit";
            this.perawatLookUpEdit.Properties.AutoSearchColumnIndex = 1;
            this.perawatLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.perawatLookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.perawatLookUpEdit.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(54, 256);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Perawat";
            // 
            // dokterLookUpEdit
            // 
            this.dokterLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dokterLookUpEdit.Location = new System.Drawing.Point(145, 229);
            this.dokterLookUpEdit.Name = "dokterLookUpEdit";
            this.dokterLookUpEdit.Properties.AutoSearchColumnIndex = 1;
            this.dokterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dokterLookUpEdit.Size = new System.Drawing.Size(536, 20);
            this.dokterLookUpEdit.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 230);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Dokter";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Keluhan";
            // 
            // keluhanTambahanMTxt
            // 
            this.keluhanTambahanMTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.keluhanTambahanMTxt.CustomButton.Image = null;
            this.keluhanTambahanMTxt.CustomButton.Location = new System.Drawing.Point(470, 2);
            this.keluhanTambahanMTxt.CustomButton.Name = "";
            this.keluhanTambahanMTxt.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.keluhanTambahanMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keluhanTambahanMTxt.CustomButton.TabIndex = 1;
            this.keluhanTambahanMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keluhanTambahanMTxt.CustomButton.UseSelectable = true;
            this.keluhanTambahanMTxt.CustomButton.Visible = false;
            this.keluhanTambahanMTxt.Lines = new string[0];
            this.keluhanTambahanMTxt.Location = new System.Drawing.Point(145, 155);
            this.keluhanTambahanMTxt.MaxLength = 32767;
            this.keluhanTambahanMTxt.Multiline = true;
            this.keluhanTambahanMTxt.Name = "keluhanTambahanMTxt";
            this.keluhanTambahanMTxt.PasswordChar = '\0';
            this.keluhanTambahanMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keluhanTambahanMTxt.SelectedText = "";
            this.keluhanTambahanMTxt.SelectionLength = 0;
            this.keluhanTambahanMTxt.SelectionStart = 0;
            this.keluhanTambahanMTxt.ShortcutsEnabled = true;
            this.keluhanTambahanMTxt.Size = new System.Drawing.Size(536, 68);
            this.keluhanTambahanMTxt.TabIndex = 4;
            this.keluhanTambahanMTxt.UseSelectable = true;
            this.keluhanTambahanMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keluhanTambahanMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Tgl. Periksa";
            // 
            // tglperiksadateEdit
            // 
            this.tglperiksadateEdit.EditValue = null;
            this.tglperiksadateEdit.Location = new System.Drawing.Point(145, 129);
            this.tglperiksadateEdit.Name = "tglperiksadateEdit";
            this.tglperiksadateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglperiksadateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglperiksadateEdit.Size = new System.Drawing.Size(100, 20);
            this.tglperiksadateEdit.TabIndex = 3;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(755, 31);
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
            this.lblTitle.Size = new System.Drawing.Size(497, 26);
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
            this.btnBack.Location = new System.Drawing.Point(739, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FAnamnesaPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAnamnesaPasien";
            this.Text = "Anamnesa Pasien";
            this.Shown += new System.EventHandler(this.FAnamnesaPasien_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanamnesapasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keluhanrepositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleterepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglperiksadateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglperiksadateEdit.Properties)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected DevExpress.XtraGrid.GridControl gc1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gv1;
        public MetroFramework.Controls.MetroButton btnAddAnamnesa;
        protected DevExpress.XtraEditors.LookUpEdit perawatLookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        protected DevExpress.XtraEditors.LookUpEdit dokterLookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        protected MetroFramework.Controls.MetroTextBox keluhanTambahanMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        protected MetroFramework.Controls.MetroTextBox kelasMTxt;
        protected MetroFramework.Controls.MetroTextBox ruangrawatMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        protected MetroFramework.Controls.MetroLink btnBack;
        protected DevExpress.XtraEditors.DateEdit tglperiksadateEdit;
        private System.Windows.Forms.BindingSource vanamnesapasienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colanamnesapasienid;
        private DevExpress.XtraGrid.Columns.GridColumn colregistrasiruangrawatid;
        private DevExpress.XtraGrid.Columns.GridColumn coltglperiksa;
        private DevExpress.XtraGrid.Columns.GridColumn colkeluhanutama;
        private DevExpress.XtraGrid.Columns.GridColumn coldokternm;
        private DevExpress.XtraGrid.Columns.GridColumn colperawatnm;
        private DevExpress.XtraGrid.Columns.GridColumn colperawatid;
        private DevExpress.XtraGrid.Columns.GridColumn coldokterid;
        protected DevExpress.XtraGrid.Columns.GridColumn colDelete;
        protected DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleterepositoryItemButtonEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit keluhanrepositoryItemMemoEdit;
    }
}