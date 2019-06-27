namespace SIMRS.DESKTOP.Template.frm.Farmasi.Obat
{
    partial class TFAddEditObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFAddEditObat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.bBatal = new DevExpress.XtraEditors.SimpleButton();
            this.jenisLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.namabarangTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.ppnpersenTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.biayaMateraiTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.biayakirimTxt = new MetroFramework.Controls.MetroTextBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.bBack = new MetroFramework.Controls.MetroLink();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jenisLookUpEdit.Properties)).BeginInit();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bSimpan);
            this.panel1.Controls.Add(this.bBatal);
            this.panel1.Controls.Add(this.jenisLookUpEdit);
            this.panel1.Controls.Add(this.metroLabel15);
            this.panel1.Controls.Add(this.namabarangTxt);
            this.panel1.Controls.Add(this.metroLabel14);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.ppnpersenTxt);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.biayaMateraiTxt);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.biayakirimTxt);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 209);
            this.panel1.TabIndex = 3;
            // 
            // bSimpan
            // 
            this.bSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSimpan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bSimpan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bSimpan.ImageOptions.Image")));
            this.bSimpan.Location = new System.Drawing.Point(305, 159);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(75, 26);
            this.bSimpan.TabIndex = 3;
            this.bSimpan.Text = "Save";
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // bBatal
            // 
            this.bBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBatal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bBatal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBatal.ImageOptions.Image")));
            this.bBatal.Location = new System.Drawing.Point(386, 159);
            this.bBatal.Name = "bBatal";
            this.bBatal.Size = new System.Drawing.Size(75, 26);
            this.bBatal.TabIndex = 4;
            this.bBatal.Text = "Cancel";
            this.bBatal.Click += new System.EventHandler(this.bBatal_Click);
            // 
            // jenisLookUpEdit
            // 
            this.jenisLookUpEdit.Location = new System.Drawing.Point(149, 53);
            this.jenisLookUpEdit.Name = "jenisLookUpEdit";
            this.jenisLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.jenisLookUpEdit.Size = new System.Drawing.Size(312, 20);
            this.jenisLookUpEdit.TabIndex = 1;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(40, 88);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(91, 19);
            this.metroLabel15.TabIndex = 93;
            this.metroLabel15.Text = "Nama Barang";
            this.metroLabel15.UseCustomBackColor = true;
            // 
            // namabarangTxt
            // 
            // 
            // 
            // 
            this.namabarangTxt.CustomButton.Image = null;
            this.namabarangTxt.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.namabarangTxt.CustomButton.Name = "";
            this.namabarangTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namabarangTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namabarangTxt.CustomButton.TabIndex = 1;
            this.namabarangTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namabarangTxt.CustomButton.UseSelectable = true;
            this.namabarangTxt.CustomButton.Visible = false;
            this.namabarangTxt.Lines = new string[0];
            this.namabarangTxt.Location = new System.Drawing.Point(149, 88);
            this.namabarangTxt.MaxLength = 32767;
            this.namabarangTxt.Name = "namabarangTxt";
            this.namabarangTxt.PasswordChar = '\0';
            this.namabarangTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namabarangTxt.SelectedText = "";
            this.namabarangTxt.SelectionLength = 0;
            this.namabarangTxt.SelectionStart = 0;
            this.namabarangTxt.ShortcutsEnabled = true;
            this.namabarangTxt.Size = new System.Drawing.Size(312, 23);
            this.namabarangTxt.TabIndex = 2;
            this.namabarangTxt.UseSelectable = true;
            this.namabarangTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namabarangTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(40, 54);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 19);
            this.metroLabel14.TabIndex = 87;
            this.metroLabel14.Text = "Jenis Barang";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(906, 53);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(20, 19);
            this.metroLabel12.TabIndex = 82;
            this.metroLabel12.Text = "%";
            // 
            // ppnpersenTxt
            // 
            // 
            // 
            // 
            this.ppnpersenTxt.CustomButton.Image = null;
            this.ppnpersenTxt.CustomButton.Location = new System.Drawing.Point(3, 1);
            this.ppnpersenTxt.CustomButton.Name = "";
            this.ppnpersenTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ppnpersenTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ppnpersenTxt.CustomButton.TabIndex = 1;
            this.ppnpersenTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ppnpersenTxt.CustomButton.UseSelectable = true;
            this.ppnpersenTxt.CustomButton.Visible = false;
            this.ppnpersenTxt.Enabled = false;
            this.ppnpersenTxt.Lines = new string[] {
        "10"};
            this.ppnpersenTxt.Location = new System.Drawing.Point(882, 49);
            this.ppnpersenTxt.MaxLength = 32767;
            this.ppnpersenTxt.Name = "ppnpersenTxt";
            this.ppnpersenTxt.PasswordChar = '\0';
            this.ppnpersenTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ppnpersenTxt.SelectedText = "";
            this.ppnpersenTxt.SelectionLength = 0;
            this.ppnpersenTxt.SelectionStart = 0;
            this.ppnpersenTxt.ShortcutsEnabled = true;
            this.ppnpersenTxt.Size = new System.Drawing.Size(25, 23);
            this.ppnpersenTxt.TabIndex = 81;
            this.ppnpersenTxt.Text = "10";
            this.ppnpersenTxt.UseSelectable = true;
            this.ppnpersenTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ppnpersenTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(841, 53);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 80;
            this.metroLabel7.Text = "PPN";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(462, 542);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 73;
            this.metroLabel10.Text = "Biaya Materai";
            this.metroLabel10.Visible = false;
            // 
            // biayaMateraiTxt
            // 
            // 
            // 
            // 
            this.biayaMateraiTxt.CustomButton.Image = null;
            this.biayaMateraiTxt.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.biayaMateraiTxt.CustomButton.Name = "";
            this.biayaMateraiTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.biayaMateraiTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.biayaMateraiTxt.CustomButton.TabIndex = 1;
            this.biayaMateraiTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.biayaMateraiTxt.CustomButton.UseSelectable = true;
            this.biayaMateraiTxt.CustomButton.Visible = false;
            this.biayaMateraiTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.biayaMateraiTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.biayaMateraiTxt.ForeColor = System.Drawing.Color.Black;
            this.biayaMateraiTxt.Lines = new string[0];
            this.biayaMateraiTxt.Location = new System.Drawing.Point(557, 542);
            this.biayaMateraiTxt.MaxLength = 32767;
            this.biayaMateraiTxt.Name = "biayaMateraiTxt";
            this.biayaMateraiTxt.PasswordChar = '\0';
            this.biayaMateraiTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.biayaMateraiTxt.SelectedText = "";
            this.biayaMateraiTxt.SelectionLength = 0;
            this.biayaMateraiTxt.SelectionStart = 0;
            this.biayaMateraiTxt.ShortcutsEnabled = true;
            this.biayaMateraiTxt.Size = new System.Drawing.Size(125, 23);
            this.biayaMateraiTxt.TabIndex = 9;
            this.biayaMateraiTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.biayaMateraiTxt.UseCustomForeColor = true;
            this.biayaMateraiTxt.UseSelectable = true;
            this.biayaMateraiTxt.Visible = false;
            this.biayaMateraiTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.biayaMateraiTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(230, 542);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = "Biaya Kirim";
            this.metroLabel9.Visible = false;
            // 
            // biayakirimTxt
            // 
            // 
            // 
            // 
            this.biayakirimTxt.CustomButton.Image = null;
            this.biayakirimTxt.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.biayakirimTxt.CustomButton.Name = "";
            this.biayakirimTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.biayakirimTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.biayakirimTxt.CustomButton.TabIndex = 1;
            this.biayakirimTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.biayakirimTxt.CustomButton.UseSelectable = true;
            this.biayakirimTxt.CustomButton.Visible = false;
            this.biayakirimTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.biayakirimTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.biayakirimTxt.ForeColor = System.Drawing.Color.Black;
            this.biayakirimTxt.Lines = new string[0];
            this.biayakirimTxt.Location = new System.Drawing.Point(325, 542);
            this.biayakirimTxt.MaxLength = 32767;
            this.biayakirimTxt.Name = "biayakirimTxt";
            this.biayakirimTxt.PasswordChar = '\0';
            this.biayakirimTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.biayakirimTxt.SelectedText = "";
            this.biayakirimTxt.SelectionLength = 0;
            this.biayakirimTxt.SelectionStart = 0;
            this.biayakirimTxt.ShortcutsEnabled = true;
            this.biayakirimTxt.Size = new System.Drawing.Size(125, 23);
            this.biayakirimTxt.TabIndex = 8;
            this.biayakirimTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.biayakirimTxt.UseCustomForeColor = true;
            this.biayakirimTxt.UseSelectable = true;
            this.biayakirimTxt.Visible = false;
            this.biayakirimTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.biayakirimTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(515, 31);
            this.pHeader.TabIndex = 4;
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.ImageSize = 32;
            this.bBack.Location = new System.Drawing.Point(505, 17);
            this.bBack.Margin = new System.Windows.Forms.Padding(0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(31, 31);
            this.bBack.TabIndex = 5;
            this.bBack.UseCustomBackColor = true;
            this.bBack.UseSelectable = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(193)))));
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(443, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseCustomBackColor = true;
            this.lblTitle.UseCustomForeColor = true;
            // 
            // TFAddEditObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 289);
            this.ControlBox = false;
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TFAddEditObat";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FAddEditObat";
            this.Load += new System.EventHandler(this.FAddEditObat_Load);
            this.Shown += new System.EventHandler(this.FAddEditObat_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jenisLookUpEdit.Properties)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        protected MetroFramework.Controls.MetroTextBox namabarangTxt;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        protected MetroFramework.Controls.MetroTextBox ppnpersenTxt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        protected MetroFramework.Controls.MetroTextBox biayaMateraiTxt;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        protected MetroFramework.Controls.MetroTextBox biayakirimTxt;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLink bBack;
        protected MetroFramework.Controls.MetroLabel lblTitle;
        protected DevExpress.XtraEditors.LookUpEdit jenisLookUpEdit;
        protected DevExpress.XtraEditors.SimpleButton bSimpan;
        protected DevExpress.XtraEditors.SimpleButton bBatal;
    }
}