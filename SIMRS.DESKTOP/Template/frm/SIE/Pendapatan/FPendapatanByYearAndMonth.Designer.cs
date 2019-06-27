namespace SIMRS.DESKTOP.Template.frm.SIE.Pendapatan
{
    partial class FPendapatanByYearAndMonth
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
            this.pendapatanByYearAndMonthMTC = new MetroFramework.Controls.MetroTabControl();
            this.rumahsakitMtp = new MetroFramework.Controls.MetroTabPage();
            this.rsGC = new DevExpress.XtraGrid.GridControl();
            this.rsGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pelayananmedisMTP = new MetroFramework.Controls.MetroTabPage();
            this.pelayananmedisGC = new DevExpress.XtraGrid.GridControl();
            this.pelayananmedisGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.detailPelayananMedisMTP = new MetroFramework.Controls.MetroTabPage();
            this.detailpelayananmedisGC = new DevExpress.XtraGrid.GridControl();
            this.detailpelayananmedisGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tahunMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bulanDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pendapatanByYearAndMonthMTC.SuspendLayout();
            this.rumahsakitMtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsGV)).BeginInit();
            this.pelayananmedisMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pelayananmedisGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelayananmedisGV)).BeginInit();
            this.detailPelayananMedisMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailpelayananmedisGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailpelayananmedisGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pendapatanByYearAndMonthMTC
            // 
            this.pendapatanByYearAndMonthMTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendapatanByYearAndMonthMTC.Controls.Add(this.rumahsakitMtp);
            this.pendapatanByYearAndMonthMTC.Controls.Add(this.pelayananmedisMTP);
            this.pendapatanByYearAndMonthMTC.Controls.Add(this.detailPelayananMedisMTP);
            this.pendapatanByYearAndMonthMTC.Location = new System.Drawing.Point(27, 99);
            this.pendapatanByYearAndMonthMTC.Name = "pendapatanByYearAndMonthMTC";
            this.pendapatanByYearAndMonthMTC.SelectedIndex = 2;
            this.pendapatanByYearAndMonthMTC.Size = new System.Drawing.Size(754, 394);
            this.pendapatanByYearAndMonthMTC.TabIndex = 4;
            this.pendapatanByYearAndMonthMTC.UseSelectable = true;
            // 
            // rumahsakitMtp
            // 
            this.rumahsakitMtp.Controls.Add(this.rsGC);
            this.rumahsakitMtp.HorizontalScrollbarBarColor = true;
            this.rumahsakitMtp.HorizontalScrollbarHighlightOnWheel = false;
            this.rumahsakitMtp.HorizontalScrollbarSize = 10;
            this.rumahsakitMtp.Location = new System.Drawing.Point(4, 38);
            this.rumahsakitMtp.Name = "rumahsakitMtp";
            this.rumahsakitMtp.Size = new System.Drawing.Size(746, 352);
            this.rumahsakitMtp.TabIndex = 0;
            this.rumahsakitMtp.Text = "Rumah Sakit";
            this.rumahsakitMtp.VerticalScrollbarBarColor = true;
            this.rumahsakitMtp.VerticalScrollbarHighlightOnWheel = false;
            this.rumahsakitMtp.VerticalScrollbarSize = 10;
            // 
            // rsGC
            // 
            this.rsGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rsGC.Location = new System.Drawing.Point(13, 3);
            this.rsGC.MainView = this.rsGV;
            this.rsGC.Name = "rsGC";
            this.rsGC.Size = new System.Drawing.Size(730, 349);
            this.rsGC.TabIndex = 2;
            this.rsGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rsGV});
            // 
            // rsGV
            // 
            this.rsGV.GridControl = this.rsGC;
            this.rsGV.Name = "rsGV";
            this.rsGV.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.rsGV_CustomDrawEmptyForeground);
            // 
            // pelayananmedisMTP
            // 
            this.pelayananmedisMTP.Controls.Add(this.pelayananmedisGC);
            this.pelayananmedisMTP.HorizontalScrollbarBarColor = true;
            this.pelayananmedisMTP.HorizontalScrollbarHighlightOnWheel = false;
            this.pelayananmedisMTP.HorizontalScrollbarSize = 10;
            this.pelayananmedisMTP.Location = new System.Drawing.Point(4, 38);
            this.pelayananmedisMTP.Name = "pelayananmedisMTP";
            this.pelayananmedisMTP.Size = new System.Drawing.Size(746, 352);
            this.pelayananmedisMTP.TabIndex = 1;
            this.pelayananmedisMTP.Text = "PelayananMedis";
            this.pelayananmedisMTP.VerticalScrollbarBarColor = true;
            this.pelayananmedisMTP.VerticalScrollbarHighlightOnWheel = false;
            this.pelayananmedisMTP.VerticalScrollbarSize = 10;
            // 
            // pelayananmedisGC
            // 
            this.pelayananmedisGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pelayananmedisGC.Location = new System.Drawing.Point(12, 3);
            this.pelayananmedisGC.MainView = this.pelayananmedisGV;
            this.pelayananmedisGC.Name = "pelayananmedisGC";
            this.pelayananmedisGC.Size = new System.Drawing.Size(731, 349);
            this.pelayananmedisGC.TabIndex = 3;
            this.pelayananmedisGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pelayananmedisGV});
            // 
            // pelayananmedisGV
            // 
            this.pelayananmedisGV.GridControl = this.pelayananmedisGC;
            this.pelayananmedisGV.Name = "pelayananmedisGV";
            this.pelayananmedisGV.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.pelayananmedisGV_CustomDrawEmptyForeground);
            // 
            // detailPelayananMedisMTP
            // 
            this.detailPelayananMedisMTP.Controls.Add(this.detailpelayananmedisGC);
            this.detailPelayananMedisMTP.Controls.Add(this.metroLabel3);
            this.detailPelayananMedisMTP.Controls.Add(this.searchLookUpEdit1);
            this.detailPelayananMedisMTP.HorizontalScrollbarBarColor = true;
            this.detailPelayananMedisMTP.HorizontalScrollbarHighlightOnWheel = false;
            this.detailPelayananMedisMTP.HorizontalScrollbarSize = 10;
            this.detailPelayananMedisMTP.Location = new System.Drawing.Point(4, 38);
            this.detailPelayananMedisMTP.Name = "detailPelayananMedisMTP";
            this.detailPelayananMedisMTP.Size = new System.Drawing.Size(746, 352);
            this.detailPelayananMedisMTP.TabIndex = 2;
            this.detailPelayananMedisMTP.Text = "Detail Pelayanan Medis";
            this.detailPelayananMedisMTP.VerticalScrollbarBarColor = true;
            this.detailPelayananMedisMTP.VerticalScrollbarHighlightOnWheel = false;
            this.detailPelayananMedisMTP.VerticalScrollbarSize = 10;
            // 
            // detailpelayananmedisGC
            // 
            this.detailpelayananmedisGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailpelayananmedisGC.Location = new System.Drawing.Point(14, 42);
            this.detailpelayananmedisGC.MainView = this.detailpelayananmedisGV;
            this.detailpelayananmedisGC.Name = "detailpelayananmedisGC";
            this.detailpelayananmedisGC.Size = new System.Drawing.Size(729, 307);
            this.detailpelayananmedisGC.TabIndex = 4;
            this.detailpelayananmedisGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailpelayananmedisGV});
            // 
            // detailpelayananmedisGV
            // 
            this.detailpelayananmedisGV.GridControl = this.detailpelayananmedisGC;
            this.detailpelayananmedisGV.Name = "detailpelayananmedisGV";
            this.detailpelayananmedisGV.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.detailpelayananmedisGV_CustomDrawEmptyForeground);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 20);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Kriteria";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLookUpEdit1.Location = new System.Drawing.Point(70, 19);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(673, 20);
            this.searchLookUpEdit1.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(186, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "contoh: 2019";
            // 
            // tahunMTxt
            // 
            // 
            // 
            // 
            this.tahunMTxt.CustomButton.Image = null;
            this.tahunMTxt.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.tahunMTxt.CustomButton.Name = "";
            this.tahunMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tahunMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tahunMTxt.CustomButton.TabIndex = 1;
            this.tahunMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tahunMTxt.CustomButton.UseSelectable = true;
            this.tahunMTxt.CustomButton.Visible = false;
            this.tahunMTxt.Lines = new string[0];
            this.tahunMTxt.Location = new System.Drawing.Point(125, 76);
            this.tahunMTxt.MaxLength = 32767;
            this.tahunMTxt.Name = "tahunMTxt";
            this.tahunMTxt.PasswordChar = '\0';
            this.tahunMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tahunMTxt.SelectedText = "";
            this.tahunMTxt.SelectionLength = 0;
            this.tahunMTxt.SelectionStart = 0;
            this.tahunMTxt.ShortcutsEnabled = true;
            this.tahunMTxt.Size = new System.Drawing.Size(55, 23);
            this.tahunMTxt.TabIndex = 6;
            this.tahunMTxt.UseSelectable = true;
            this.tahunMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tahunMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Input Tahun";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(626, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Bulan:";
            // 
            // bulanDateEdit
            // 
            this.bulanDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bulanDateEdit.EditValue = null;
            this.bulanDateEdit.Location = new System.Drawing.Point(676, 73);
            this.bulanDateEdit.Name = "bulanDateEdit";
            this.bulanDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bulanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bulanDateEdit.Size = new System.Drawing.Size(98, 20);
            this.bulanDateEdit.TabIndex = 104;
            // 
            // FPendapatanByYearAndMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.ControlBox = false;
            this.Controls.Add(this.bulanDateEdit);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pendapatanByYearAndMonthMTC);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tahunMTxt);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPendapatanByYearAndMonth";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Pendapatan berdasarkan tahun dan bulan";
            this.pendapatanByYearAndMonthMTC.ResumeLayout(false);
            this.rumahsakitMtp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rsGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsGV)).EndInit();
            this.pelayananmedisMTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pelayananmedisGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelayananmedisGV)).EndInit();
            this.detailPelayananMedisMTP.ResumeLayout(false);
            this.detailPelayananMedisMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailpelayananmedisGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailpelayananmedisGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroTabControl pendapatanByYearAndMonthMTC;
        private MetroFramework.Controls.MetroTabPage rumahsakitMtp;
        private DevExpress.XtraGrid.GridControl rsGC;
        private DevExpress.XtraGrid.Views.Grid.GridView rsGV;
        private MetroFramework.Controls.MetroTabPage pelayananmedisMTP;
        private DevExpress.XtraGrid.GridControl pelayananmedisGC;
        private DevExpress.XtraGrid.Views.Grid.GridView pelayananmedisGV;
        protected MetroFramework.Controls.MetroTabPage detailPelayananMedisMTP;
        private DevExpress.XtraGrid.GridControl detailpelayananmedisGC;
        private DevExpress.XtraGrid.Views.Grid.GridView detailpelayananmedisGV;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MetroFramework.Controls.MetroTextBox tahunMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        protected DevExpress.XtraEditors.DateEdit bulanDateEdit;
    }
}