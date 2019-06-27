namespace SIMRS.DESKTOP.Template.frm
{
    partial class FResumeAnamnesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FResumeAnamnesa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ruangrawatMTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gc1 = new DevExpress.XtraGrid.GridControl();
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ruangrawatMTxt);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.gc1);
            this.panel1.Controls.Add(this.pHeader);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 564);
            this.panel1.TabIndex = 4;
            // 
            // ruangrawatMTxt
            // 
            // 
            // 
            // 
            this.ruangrawatMTxt.CustomButton.Image = null;
            this.ruangrawatMTxt.CustomButton.Location = new System.Drawing.Point(537, 1);
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
            this.ruangrawatMTxt.Size = new System.Drawing.Size(559, 23);
            this.ruangrawatMTxt.TabIndex = 21;
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
            this.gc1.Location = new System.Drawing.Point(54, 116);
            this.gc1.MainView = this.gv1;
            this.gc1.Name = "gc1";
            this.gc1.Size = new System.Drawing.Size(650, 417);
            this.gc1.TabIndex = 15;
            this.gc1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1});
            // 
            // gv1
            // 
            this.gv1.GridControl = this.gc1;
            this.gv1.Name = "gv1";
            this.gv1.OptionsView.ShowGroupPanel = false;
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
            this.btnBack.Location = new System.Drawing.Point(743, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseSelectable = true;
            // 
            // FResumeAnamnesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FResumeAnamnesa";
            this.Text = "FResumeAnamnesa";
            this.Load += new System.EventHandler(this.FResumeAnamnesa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected MetroFramework.Controls.MetroTextBox ruangrawatMTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        protected DevExpress.XtraGrid.GridControl gc1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gv1;
        protected System.Windows.Forms.Panel pHeader;
        protected MetroFramework.Controls.MetroLabel lblTitle;
        protected MetroFramework.Controls.MetroLink btnBack;
    }
}