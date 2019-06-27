namespace SIMRS.DESKTOP.Template.frm
{
    partial class FRptPenngunjung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gc1 = new DevExpress.XtraGrid.GridControl();
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pelayananMedikLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tahunDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.aktifpelayanancheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bulanDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.hariDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelayananMedikLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahunDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahunDateEdit.Properties)).BeginInit();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aktifpelayanancheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hariDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hariDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkEdit3);
            this.panel1.Controls.Add(this.checkEdit2);
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.hariDateEdit);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.bulanDateEdit);
            this.panel1.Controls.Add(this.aktifpelayanancheckEdit);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.gc1);
            this.panel1.Controls.Add(this.pelayananMedikLookUpEdit);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.tahunDateEdit);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 564);
            this.panel1.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(654, 531);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Pelayanan Medik";
            // 
            // gc1
            // 
            this.gc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc1.Location = new System.Drawing.Point(24, 152);
            this.gc1.MainView = this.gv1;
            this.gc1.Name = "gc1";
            this.gc1.Size = new System.Drawing.Size(705, 373);
            this.gc1.TabIndex = 8;
            this.gc1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1});
            // 
            // gv1
            // 
            this.gv1.GridControl = this.gc1;
            this.gv1.Name = "gv1";
            this.gv1.OptionsView.RowAutoHeight = true;
            this.gv1.OptionsView.ShowGroupPanel = false;
            // 
            // pelayananMedikLookUpEdit
            // 
            this.pelayananMedikLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pelayananMedikLookUpEdit.Location = new System.Drawing.Point(145, 48);
            this.pelayananMedikLookUpEdit.Name = "pelayananMedikLookUpEdit";
            this.pelayananMedikLookUpEdit.Properties.AutoSearchColumnIndex = 1;
            this.pelayananMedikLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pelayananMedikLookUpEdit.Size = new System.Drawing.Size(231, 20);
            this.pelayananMedikLookUpEdit.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "TAHUN";
            // 
            // tahunDateEdit
            // 
            this.tahunDateEdit.EditValue = null;
            this.tahunDateEdit.Location = new System.Drawing.Point(145, 74);
            this.tahunDateEdit.Name = "tahunDateEdit";
            this.tahunDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tahunDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tahunDateEdit.Size = new System.Drawing.Size(100, 20);
            this.tahunDateEdit.TabIndex = 3;
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
            // aktifpelayanancheckEdit
            // 
            this.aktifpelayanancheckEdit.Location = new System.Drawing.Point(382, 47);
            this.aktifpelayanancheckEdit.Name = "aktifpelayanancheckEdit";
            this.aktifpelayanancheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.aktifpelayanancheckEdit.Properties.Appearance.Options.UseFont = true;
            this.aktifpelayanancheckEdit.Properties.Caption = "Aktif";
            this.aktifpelayanancheckEdit.Size = new System.Drawing.Size(107, 21);
            this.aktifpelayanancheckEdit.TabIndex = 106;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 108;
            this.metroLabel2.Text = "BULAN";
            // 
            // bulanDateEdit
            // 
            this.bulanDateEdit.EditValue = null;
            this.bulanDateEdit.Location = new System.Drawing.Point(145, 100);
            this.bulanDateEdit.Name = "bulanDateEdit";
            this.bulanDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bulanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bulanDateEdit.Size = new System.Drawing.Size(100, 20);
            this.bulanDateEdit.TabIndex = 107;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 110;
            this.metroLabel4.Text = "HARI";
            // 
            // hariDateEdit
            // 
            this.hariDateEdit.EditValue = null;
            this.hariDateEdit.Location = new System.Drawing.Point(145, 126);
            this.hariDateEdit.Name = "hariDateEdit";
            this.hariDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hariDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hariDateEdit.Size = new System.Drawing.Size(100, 20);
            this.hariDateEdit.TabIndex = 109;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(251, 74);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Aktif";
            this.checkEdit1.Size = new System.Drawing.Size(107, 21);
            this.checkEdit1.TabIndex = 111;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(251, 101);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Caption = "Aktif";
            this.checkEdit2.Size = new System.Drawing.Size(107, 21);
            this.checkEdit2.TabIndex = 112;
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(251, 124);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.checkEdit3.Properties.Appearance.Options.UseFont = true;
            this.checkEdit3.Properties.Caption = "Aktif";
            this.checkEdit3.Size = new System.Drawing.Size(107, 21);
            this.checkEdit3.TabIndex = 113;
            // 
            // FRptPenngunjung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRptPenngunjung";
            this.Text = "FRptPenngunjung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelayananMedikLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahunDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahunDateEdit.Properties)).EndInit();
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aktifpelayanancheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hariDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hariDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        protected DevExpress.XtraGrid.GridControl gc1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gv1;
        protected DevExpress.XtraEditors.LookUpEdit pelayananMedikLookUpEdit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        protected DevExpress.XtraEditors.DateEdit tahunDateEdit;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        protected DevExpress.XtraEditors.DateEdit hariDateEdit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        protected DevExpress.XtraEditors.DateEdit bulanDateEdit;
        protected DevExpress.XtraEditors.CheckEdit aktifpelayanancheckEdit;
        protected DevExpress.XtraEditors.CheckEdit checkEdit3;
        protected DevExpress.XtraEditors.CheckEdit checkEdit2;
        protected DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}