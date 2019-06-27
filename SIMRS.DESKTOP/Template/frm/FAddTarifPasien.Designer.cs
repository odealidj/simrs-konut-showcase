namespace SIMRS.DESKTOP.Template.frm
{
    partial class FAddTarifPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddTarifPasien));
            this.caridataMTxt = new MetroFramework.Controls.MetroTextBox();
            this.tarifGC = new DevExpress.XtraGrid.GridControl();
            this.v_tarifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldaftartindakanid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldaftartindakannm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbiaya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarifid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruangrawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkelasid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljenistarifid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljenistarifnm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpenjaminpasienid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkelasruangrawatid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dokterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.perawatLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tgltindakanDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bCancel = new MetroFramework.Controls.MetroButton();
            this.bSave = new MetroFramework.Controls.MetroButton();
            this.tindakanMtxt = new MetroFramework.Controls.MetroTextBox();
            this.totalMtxt = new MetroFramework.Controls.MetroTextBox();
            this.jmlCboEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.jenistarifLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.jenistarifLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tarifGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_tarifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgltindakanDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgltindakanDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmlCboEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenistarifLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // caridataMTxt
            // 
            this.caridataMTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.caridataMTxt.CustomButton.Image = null;
            this.caridataMTxt.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.caridataMTxt.CustomButton.Name = "";
            this.caridataMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.caridataMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.caridataMTxt.CustomButton.TabIndex = 1;
            this.caridataMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.caridataMTxt.CustomButton.UseSelectable = true;
            this.caridataMTxt.CustomButton.Visible = false;
            this.caridataMTxt.DisplayIcon = true;
            this.caridataMTxt.Icon = ((System.Drawing.Image)(resources.GetObject("caridataMTxt.Icon")));
            this.caridataMTxt.IconRight = true;
            this.caridataMTxt.Lines = new string[0];
            this.caridataMTxt.Location = new System.Drawing.Point(23, 60);
            this.caridataMTxt.Margin = new System.Windows.Forms.Padding(0);
            this.caridataMTxt.MaxLength = 32767;
            this.caridataMTxt.Name = "caridataMTxt";
            this.caridataMTxt.PasswordChar = '\0';
            this.caridataMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.caridataMTxt.SelectedText = "";
            this.caridataMTxt.SelectionLength = 0;
            this.caridataMTxt.SelectionStart = 0;
            this.caridataMTxt.ShortcutsEnabled = true;
            this.caridataMTxt.ShowClearButton = true;
            this.caridataMTxt.Size = new System.Drawing.Size(527, 23);
            this.caridataMTxt.TabIndex = 1;
            this.caridataMTxt.UseSelectable = true;
            this.caridataMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.caridataMTxt.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caridataMTxt.TextChanged += new System.EventHandler(this.caridataMTxt_TextChanged);
            // 
            // tarifGC
            // 
            this.tarifGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarifGC.DataSource = this.v_tarifBindingSource;
            this.tarifGC.Location = new System.Drawing.Point(23, 86);
            this.tarifGC.MainView = this.tarifGV;
            this.tarifGC.Name = "tarifGC";
            this.tarifGC.Size = new System.Drawing.Size(527, 285);
            this.tarifGC.TabIndex = 2;
            this.tarifGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tarifGV});
            // 
            // tarifGV
            // 
            this.tarifGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldaftartindakanid,
            this.coldaftartindakannm,
            this.colbiaya,
            this.coltarifid,
            this.colruangrawatid,
            this.colkelasid,
            this.coljenistarifid,
            this.coljenistarifnm,
            this.colpenjaminpasienid,
            this.colkelasruangrawatid});
            this.tarifGV.GridControl = this.tarifGC;
            this.tarifGV.Name = "tarifGV";
            this.tarifGV.OptionsView.ShowGroupPanel = false;
            this.tarifGV.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.tarifGV_FocusedRowChanged);
            // 
            // coldaftartindakanid
            // 
            this.coldaftartindakanid.FieldName = "daftartindakanid";
            this.coldaftartindakanid.Name = "coldaftartindakanid";
            // 
            // coldaftartindakannm
            // 
            this.coldaftartindakannm.Caption = "NAMA TINDAKAN";
            this.coldaftartindakannm.FieldName = "daftartindakannm";
            this.coldaftartindakannm.Name = "coldaftartindakannm";
            this.coldaftartindakannm.OptionsColumn.AllowEdit = false;
            this.coldaftartindakannm.Visible = true;
            this.coldaftartindakannm.VisibleIndex = 0;
            this.coldaftartindakannm.Width = 237;
            // 
            // colbiaya
            // 
            this.colbiaya.AppearanceHeader.Options.UseTextOptions = true;
            this.colbiaya.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colbiaya.Caption = "TARIF";
            this.colbiaya.DisplayFormat.FormatString = "#,#";
            this.colbiaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colbiaya.FieldName = "biaya";
            this.colbiaya.MaxWidth = 80;
            this.colbiaya.Name = "colbiaya";
            this.colbiaya.OptionsColumn.AllowEdit = false;
            this.colbiaya.OptionsColumn.FixedWidth = true;
            this.colbiaya.Visible = true;
            this.colbiaya.VisibleIndex = 1;
            this.colbiaya.Width = 80;
            // 
            // coltarifid
            // 
            this.coltarifid.FieldName = "tarifid";
            this.coltarifid.Name = "coltarifid";
            // 
            // colruangrawatid
            // 
            this.colruangrawatid.FieldName = "ruangrawatid";
            this.colruangrawatid.Name = "colruangrawatid";
            // 
            // colkelasid
            // 
            this.colkelasid.FieldName = "kelasid";
            this.colkelasid.Name = "colkelasid";
            // 
            // coljenistarifid
            // 
            this.coljenistarifid.FieldName = "jenistarifid";
            this.coljenistarifid.Name = "coljenistarifid";
            // 
            // coljenistarifnm
            // 
            this.coljenistarifnm.FieldName = "jenistarifnm";
            this.coljenistarifnm.Name = "coljenistarifnm";
            // 
            // colpenjaminpasienid
            // 
            this.colpenjaminpasienid.FieldName = "penjaminpasienid";
            this.colpenjaminpasienid.Name = "colpenjaminpasienid";
            // 
            // colkelasruangrawatid
            // 
            this.colkelasruangrawatid.FieldName = "kelasruangrawatid";
            this.colkelasruangrawatid.Name = "colkelasruangrawatid";
            // 
            // dokterLookUpEdit
            // 
            this.dokterLookUpEdit.Location = new System.Drawing.Point(109, 468);
            this.dokterLookUpEdit.Name = "dokterLookUpEdit";
            this.dokterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dokterLookUpEdit.Properties.NullText = "Pilih Dokter";
            this.dokterLookUpEdit.Size = new System.Drawing.Size(441, 20);
            this.dokterLookUpEdit.TabIndex = 6;
            // 
            // perawatLookUpEdit
            // 
            this.perawatLookUpEdit.Location = new System.Drawing.Point(109, 494);
            this.perawatLookUpEdit.Name = "perawatLookUpEdit";
            this.perawatLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.perawatLookUpEdit.Properties.NullText = "Pilih Perawat";
            this.perawatLookUpEdit.Size = new System.Drawing.Size(441, 20);
            this.perawatLookUpEdit.TabIndex = 7;
            // 
            // tgltindakanDateEdit
            // 
            this.tgltindakanDateEdit.EditValue = null;
            this.tgltindakanDateEdit.Location = new System.Drawing.Point(109, 520);
            this.tgltindakanDateEdit.Name = "tgltindakanDateEdit";
            this.tgltindakanDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tgltindakanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tgltindakanDateEdit.Size = new System.Drawing.Size(125, 20);
            this.tgltindakanDateEdit.TabIndex = 8;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(475, 554);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseSelectable = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(394, 554);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Save";
            this.bSave.UseSelectable = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tindakanMtxt
            // 
            // 
            // 
            // 
            this.tindakanMtxt.CustomButton.Image = null;
            this.tindakanMtxt.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.tindakanMtxt.CustomButton.Name = "";
            this.tindakanMtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tindakanMtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tindakanMtxt.CustomButton.TabIndex = 1;
            this.tindakanMtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tindakanMtxt.CustomButton.UseSelectable = true;
            this.tindakanMtxt.CustomButton.Visible = false;
            this.tindakanMtxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tindakanMtxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tindakanMtxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.tindakanMtxt.Lines = new string[0];
            this.tindakanMtxt.Location = new System.Drawing.Point(109, 384);
            this.tindakanMtxt.MaxLength = 32767;
            this.tindakanMtxt.Name = "tindakanMtxt";
            this.tindakanMtxt.PasswordChar = '\0';
            this.tindakanMtxt.ReadOnly = true;
            this.tindakanMtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tindakanMtxt.SelectedText = "";
            this.tindakanMtxt.SelectionLength = 0;
            this.tindakanMtxt.SelectionStart = 0;
            this.tindakanMtxt.ShortcutsEnabled = true;
            this.tindakanMtxt.Size = new System.Drawing.Size(441, 23);
            this.tindakanMtxt.TabIndex = 3;
            this.tindakanMtxt.UseCustomForeColor = true;
            this.tindakanMtxt.UseSelectable = true;
            this.tindakanMtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tindakanMtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalMtxt
            // 
            // 
            // 
            // 
            this.totalMtxt.CustomButton.Image = null;
            this.totalMtxt.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.totalMtxt.CustomButton.Name = "";
            this.totalMtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalMtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalMtxt.CustomButton.TabIndex = 1;
            this.totalMtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalMtxt.CustomButton.UseSelectable = true;
            this.totalMtxt.CustomButton.Visible = false;
            this.totalMtxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.totalMtxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.totalMtxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.totalMtxt.Lines = new string[0];
            this.totalMtxt.Location = new System.Drawing.Point(109, 439);
            this.totalMtxt.MaxLength = 32767;
            this.totalMtxt.Name = "totalMtxt";
            this.totalMtxt.PasswordChar = '\0';
            this.totalMtxt.ReadOnly = true;
            this.totalMtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalMtxt.SelectedText = "";
            this.totalMtxt.SelectionLength = 0;
            this.totalMtxt.SelectionStart = 0;
            this.totalMtxt.ShortcutsEnabled = true;
            this.totalMtxt.Size = new System.Drawing.Size(125, 23);
            this.totalMtxt.TabIndex = 5;
            this.totalMtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalMtxt.UseCustomForeColor = true;
            this.totalMtxt.UseSelectable = true;
            this.totalMtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalMtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // jmlCboEdit
            // 
            this.jmlCboEdit.Location = new System.Drawing.Point(109, 413);
            this.jmlCboEdit.Name = "jmlCboEdit";
            this.jmlCboEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.jmlCboEdit.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.jmlCboEdit.Properties.Appearance.Options.UseFont = true;
            this.jmlCboEdit.Properties.Appearance.Options.UseForeColor = true;
            this.jmlCboEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.jmlCboEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.jmlCboEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.jmlCboEdit.Properties.NullText = "Jml tindakan";
            this.jmlCboEdit.Properties.NullValuePrompt = "Jml tindakan";
            this.jmlCboEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.jmlCboEdit.Size = new System.Drawing.Size(125, 20);
            this.jmlCboEdit.TabIndex = 4;
            // 
            // jenistarifLookUpEdit
            // 
            this.jenistarifLookUpEdit.Location = new System.Drawing.Point(109, 546);
            this.jenistarifLookUpEdit.Name = "jenistarifLookUpEdit";
            this.jenistarifLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.jenistarifLookUpEdit.Properties.NullText = "";
            this.jenistarifLookUpEdit.Properties.PopupSizeable = false;
            this.jenistarifLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.jenistarifLookUpEdit.Size = new System.Drawing.Size(125, 20);
            this.jenistarifLookUpEdit.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 388);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Tindakan";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 414);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Jumlah";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 443);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Total";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 469);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "Dokter";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 495);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 47;
            this.metroLabel5.Text = "Perawat";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 521);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 48;
            this.metroLabel6.Text = "Tgl.Tindakan";
            // 
            // jenistarifLbl
            // 
            this.jenistarifLbl.AutoSize = true;
            this.jenistarifLbl.Location = new System.Drawing.Point(23, 547);
            this.jenistarifLbl.Name = "jenistarifLbl";
            this.jenistarifLbl.Size = new System.Drawing.Size(64, 19);
            this.jenistarifLbl.TabIndex = 49;
            this.jenistarifLbl.Text = "Jenis Tarif";
            // 
            // FTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 600);
            this.Controls.Add(this.jenistarifLbl);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.jmlCboEdit);
            this.Controls.Add(this.totalMtxt);
            this.Controls.Add(this.tindakanMtxt);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tgltindakanDateEdit);
            this.Controls.Add(this.perawatLookUpEdit);
            this.Controls.Add(this.dokterLookUpEdit);
            this.Controls.Add(this.tarifGC);
            this.Controls.Add(this.caridataMTxt);
            this.Controls.Add(this.jenistarifLookUpEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FTarif";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "FTarif";
            this.Load += new System.EventHandler(this.FTarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarifGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_tarifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgltindakanDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgltindakanDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmlCboEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenistarifLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroTextBox caridataMTxt;
        protected DevExpress.XtraGrid.GridControl tarifGC;
        protected DevExpress.XtraGrid.Views.Grid.GridView tarifGV;
        protected MetroFramework.Controls.MetroTextBox tindakanMtxt;
        protected DevExpress.XtraEditors.ComboBoxEdit jmlCboEdit;
        protected MetroFramework.Controls.MetroTextBox totalMtxt;
        protected DevExpress.XtraEditors.LookUpEdit dokterLookUpEdit;
        protected DevExpress.XtraEditors.DateEdit tgltindakanDateEdit;
        protected MetroFramework.Controls.MetroButton bCancel;
        protected MetroFramework.Controls.MetroButton bSave;
        protected DevExpress.XtraEditors.LookUpEdit jenistarifLookUpEdit;
        protected System.Windows.Forms.BindingSource v_tarifBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldaftartindakanid;
        private DevExpress.XtraGrid.Columns.GridColumn coldaftartindakannm;
        private DevExpress.XtraGrid.Columns.GridColumn colbiaya;
        private DevExpress.XtraGrid.Columns.GridColumn coltarifid;
        private DevExpress.XtraGrid.Columns.GridColumn colruangrawatid;
        private DevExpress.XtraGrid.Columns.GridColumn colkelasid;
        private DevExpress.XtraGrid.Columns.GridColumn coljenistarifid;
        private DevExpress.XtraGrid.Columns.GridColumn coljenistarifnm;
        private DevExpress.XtraGrid.Columns.GridColumn colpenjaminpasienid;
        private DevExpress.XtraGrid.Columns.GridColumn colkelasruangrawatid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        protected MetroFramework.Controls.MetroLabel jenistarifLbl;
        protected DevExpress.XtraEditors.LookUpEdit perawatLookUpEdit;
    }
}