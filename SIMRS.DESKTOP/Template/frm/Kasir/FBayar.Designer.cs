namespace SIMRS.DESKTOP.Template.frm.Kasir
{
    partial class FBayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBayar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.kembaliLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BayartextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.jmlBayarLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.totalBiayaLbl = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblSelect = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BayartextEdit.Properties)).BeginInit();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.kembaliLbl);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.BayartextEdit);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.jmlBayarLbl);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.totalBiayaLbl);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 520);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.Location = new System.Drawing.Point(554, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 123;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(161, 324);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(258, 35);
            this.labelControl5.TabIndex = 122;
            this.labelControl5.Text = "PENGEMBALIAN :";
            // 
            // kembaliLbl
            // 
            this.kembaliLbl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kembaliLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.kembaliLbl.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.kembaliLbl.Appearance.Options.UseBackColor = true;
            this.kembaliLbl.Appearance.Options.UseFont = true;
            this.kembaliLbl.Appearance.Options.UseForeColor = true;
            this.kembaliLbl.Appearance.Options.UseTextOptions = true;
            this.kembaliLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.kembaliLbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.kembaliLbl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.kembaliLbl.Location = new System.Drawing.Point(441, 314);
            this.kembaliLbl.Name = "kembaliLbl";
            this.kembaliLbl.Size = new System.Drawing.Size(233, 49);
            this.kembaliLbl.TabIndex = 121;
            this.kembaliLbl.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(91, 259);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(328, 35);
            this.labelControl4.TabIndex = 120;
            this.labelControl4.Text = "INPUT PEMBAYARAN :";
            // 
            // BayartextEdit
            // 
            this.BayartextEdit.EditValue = "0";
            this.BayartextEdit.Location = new System.Drawing.Point(441, 247);
            this.BayartextEdit.Name = "BayartextEdit";
            this.BayartextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.BayartextEdit.Properties.Appearance.Options.UseFont = true;
            this.BayartextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BayartextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BayartextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BayartextEdit.Size = new System.Drawing.Size(233, 54);
            this.BayartextEdit.TabIndex = 119;
            this.BayartextEdit.EnabledChanged += new System.EventHandler(this.BayartextEdit_EnabledChanged);
            this.BayartextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BayartextEdit_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(223, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(196, 35);
            this.labelControl2.TabIndex = 118;
            this.labelControl2.Text = "JML. BAYAR :";
            // 
            // jmlBayarLbl
            // 
            this.jmlBayarLbl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.jmlBayarLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.jmlBayarLbl.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.jmlBayarLbl.Appearance.Options.UseBackColor = true;
            this.jmlBayarLbl.Appearance.Options.UseFont = true;
            this.jmlBayarLbl.Appearance.Options.UseForeColor = true;
            this.jmlBayarLbl.Appearance.Options.UseTextOptions = true;
            this.jmlBayarLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.jmlBayarLbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.jmlBayarLbl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.jmlBayarLbl.Location = new System.Drawing.Point(441, 150);
            this.jmlBayarLbl.Name = "jmlBayarLbl";
            this.jmlBayarLbl.Size = new System.Drawing.Size(233, 49);
            this.jmlBayarLbl.TabIndex = 117;
            this.jmlBayarLbl.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(202, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 35);
            this.labelControl1.TabIndex = 116;
            this.labelControl1.Text = "TOTAL BIAYA :";
            // 
            // totalBiayaLbl
            // 
            this.totalBiayaLbl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.totalBiayaLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.totalBiayaLbl.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.totalBiayaLbl.Appearance.Options.UseBackColor = true;
            this.totalBiayaLbl.Appearance.Options.UseFont = true;
            this.totalBiayaLbl.Appearance.Options.UseForeColor = true;
            this.totalBiayaLbl.Appearance.Options.UseTextOptions = true;
            this.totalBiayaLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totalBiayaLbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.totalBiayaLbl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.totalBiayaLbl.Location = new System.Drawing.Point(441, 84);
            this.totalBiayaLbl.Name = "totalBiayaLbl";
            this.totalBiayaLbl.Size = new System.Drawing.Size(233, 49);
            this.totalBiayaLbl.TabIndex = 115;
            this.totalBiayaLbl.Text = "99.000.000";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOK.Location = new System.Drawing.Point(417, 405);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 50);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "SAVE";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.pHeader.Controls.Add(this.lblSelect);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(758, 31);
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
            this.lblSelect.Size = new System.Drawing.Size(722, 26);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelect.UseCustomBackColor = true;
            this.lblSelect.UseCustomForeColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = 32;
            this.btnBack.Location = new System.Drawing.Point(743, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 38;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPrint.Location = new System.Drawing.Point(91, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 50);
            this.btnPrint.TabIndex = 124;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FBayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBayar";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FBayar";
            this.Shown += new System.EventHandler(this.FBayar_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BayartextEdit.Properties)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLabel lblSelect;
        protected MetroFramework.Controls.MetroButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        protected DevExpress.XtraEditors.LabelControl kembaliLbl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        protected DevExpress.XtraEditors.LabelControl jmlBayarLbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.LabelControl totalBiayaLbl;
        protected DevExpress.XtraEditors.TextEdit BayartextEdit;
        protected MetroFramework.Controls.MetroLink btnBack;
        protected MetroFramework.Controls.MetroButton btnCancel;
        protected MetroFramework.Controls.MetroButton btnPrint;
    }
}