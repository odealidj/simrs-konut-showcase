namespace SIMRS.DESKTOP.Template.frm.SIE.Pendapatan
{
    partial class FPendapatanByYearRange
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
            this.pendapatanByYearRangeMTC = new MetroFramework.Controls.MetroTabControl();
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
            this.tahunawalMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tahunakhirMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pendapatanByYearRangeMTC.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // pendapatanByYearRangeMTC
            // 
            this.pendapatanByYearRangeMTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendapatanByYearRangeMTC.Controls.Add(this.rumahsakitMtp);
            this.pendapatanByYearRangeMTC.Controls.Add(this.pelayananmedisMTP);
            this.pendapatanByYearRangeMTC.Controls.Add(this.detailPelayananMedisMTP);
            this.pendapatanByYearRangeMTC.Location = new System.Drawing.Point(23, 103);
            this.pendapatanByYearRangeMTC.Name = "pendapatanByYearRangeMTC";
            this.pendapatanByYearRangeMTC.SelectedIndex = 2;
            this.pendapatanByYearRangeMTC.Size = new System.Drawing.Size(754, 390);
            this.pendapatanByYearRangeMTC.TabIndex = 4;
            this.pendapatanByYearRangeMTC.UseSelectable = true;
            // 
            // rumahsakitMtp
            // 
            this.rumahsakitMtp.Controls.Add(this.rsGC);
            this.rumahsakitMtp.HorizontalScrollbarBarColor = true;
            this.rumahsakitMtp.HorizontalScrollbarHighlightOnWheel = false;
            this.rumahsakitMtp.HorizontalScrollbarSize = 10;
            this.rumahsakitMtp.Location = new System.Drawing.Point(4, 38);
            this.rumahsakitMtp.Name = "rumahsakitMtp";
            this.rumahsakitMtp.Size = new System.Drawing.Size(746, 348);
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
            this.rsGC.Size = new System.Drawing.Size(730, 342);
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
            this.pelayananmedisMTP.Size = new System.Drawing.Size(746, 348);
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
            this.detailPelayananMedisMTP.Size = new System.Drawing.Size(746, 348);
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
            // tahunawalMTxt
            // 
            // 
            // 
            // 
            this.tahunawalMTxt.CustomButton.Image = null;
            this.tahunawalMTxt.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.tahunawalMTxt.CustomButton.Name = "";
            this.tahunawalMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tahunawalMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tahunawalMTxt.CustomButton.TabIndex = 1;
            this.tahunawalMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tahunawalMTxt.CustomButton.UseSelectable = true;
            this.tahunawalMTxt.CustomButton.Visible = false;
            this.tahunawalMTxt.Lines = new string[0];
            this.tahunawalMTxt.Location = new System.Drawing.Point(139, 74);
            this.tahunawalMTxt.MaxLength = 32767;
            this.tahunawalMTxt.Name = "tahunawalMTxt";
            this.tahunawalMTxt.PasswordChar = '\0';
            this.tahunawalMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tahunawalMTxt.SelectedText = "";
            this.tahunawalMTxt.SelectionLength = 0;
            this.tahunawalMTxt.SelectionStart = 0;
            this.tahunawalMTxt.ShortcutsEnabled = true;
            this.tahunawalMTxt.Size = new System.Drawing.Size(55, 23);
            this.tahunawalMTxt.TabIndex = 6;
            this.tahunawalMTxt.UseSelectable = true;
            this.tahunawalMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tahunawalMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Input Tahun Awal";
            // 
            // tahunakhirMTxt
            // 
            // 
            // 
            // 
            this.tahunakhirMTxt.CustomButton.Image = null;
            this.tahunakhirMTxt.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.tahunakhirMTxt.CustomButton.Name = "";
            this.tahunakhirMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tahunakhirMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tahunakhirMTxt.CustomButton.TabIndex = 1;
            this.tahunakhirMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tahunakhirMTxt.CustomButton.UseSelectable = true;
            this.tahunakhirMTxt.CustomButton.Visible = false;
            this.tahunakhirMTxt.Lines = new string[0];
            this.tahunakhirMTxt.Location = new System.Drawing.Point(346, 73);
            this.tahunakhirMTxt.MaxLength = 32767;
            this.tahunakhirMTxt.Name = "tahunakhirMTxt";
            this.tahunakhirMTxt.PasswordChar = '\0';
            this.tahunakhirMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tahunakhirMTxt.SelectedText = "";
            this.tahunakhirMTxt.SelectionLength = 0;
            this.tahunakhirMTxt.SelectionStart = 0;
            this.tahunakhirMTxt.ShortcutsEnabled = true;
            this.tahunakhirMTxt.Size = new System.Drawing.Size(55, 23);
            this.tahunakhirMTxt.TabIndex = 9;
            this.tahunakhirMTxt.UseSelectable = true;
            this.tahunakhirMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tahunakhirMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(233, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Input Tahun Akhir";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(200, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "s/d";
            // 
            // FPendapatanByYearRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tahunakhirMTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pendapatanByYearRangeMTC);
            this.Controls.Add(this.tahunawalMTxt);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPendapatanByYearRange";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Pendapatan berdasarkan range tahun";
            this.pendapatanByYearRangeMTC.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroTabControl pendapatanByYearRangeMTC;
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
        private MetroFramework.Controls.MetroTextBox tahunawalMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tahunakhirMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}