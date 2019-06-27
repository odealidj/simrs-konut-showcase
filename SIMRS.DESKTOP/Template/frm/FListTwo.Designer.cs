namespace SIMRS.DESKTOP.Template.frm
{
    partial class FListTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListTwo));
            this.listGC = new DevExpress.XtraGrid.GridControl();
            this.listGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.detailGC = new DevExpress.XtraGrid.GridControl();
            this.detailGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kodeMtxt = new MetroFramework.Controls.MetroTextBox();
            this.kodeLBL = new System.Windows.Forms.Label();
            this.caridetailMTxt = new MetroFramework.Controls.MetroTextBox();
            this.cariListMtxt = new MetroFramework.Controls.MetroTextBox();
            this.namaLbl = new System.Windows.Forms.Label();
            this.namaMTxt = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGV)).BeginInit();
            this.SuspendLayout();
            // 
            // listGC
            // 
            this.listGC.Location = new System.Drawing.Point(23, 86);
            this.listGC.MainView = this.listGV;
            this.listGC.Name = "listGC";
            this.listGC.Size = new System.Drawing.Size(232, 341);
            this.listGC.TabIndex = 0;
            this.listGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listGV});
            // 
            // listGV
            // 
            this.listGV.GridControl = this.listGC;
            this.listGV.Name = "listGV";
            this.listGV.OptionsView.ShowGroupPanel = false;
            // 
            // detailGC
            // 
            this.detailGC.Location = new System.Drawing.Point(261, 175);
            this.detailGC.MainView = this.detailGV;
            this.detailGC.Name = "detailGC";
            this.detailGC.Size = new System.Drawing.Size(516, 252);
            this.detailGC.TabIndex = 1;
            this.detailGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailGV});
            // 
            // detailGV
            // 
            this.detailGV.GridControl = this.detailGC;
            this.detailGV.Name = "detailGV";
            this.detailGV.OptionsView.ShowGroupPanel = false;
            // 
            // kodeMtxt
            // 
            // 
            // 
            // 
            this.kodeMtxt.CustomButton.Image = null;
            this.kodeMtxt.CustomButton.Location = new System.Drawing.Point(425, 1);
            this.kodeMtxt.CustomButton.Name = "";
            this.kodeMtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kodeMtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kodeMtxt.CustomButton.TabIndex = 1;
            this.kodeMtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kodeMtxt.CustomButton.UseSelectable = true;
            this.kodeMtxt.CustomButton.Visible = false;
            this.kodeMtxt.Lines = new string[0];
            this.kodeMtxt.Location = new System.Drawing.Point(330, 86);
            this.kodeMtxt.MaxLength = 32767;
            this.kodeMtxt.Name = "kodeMtxt";
            this.kodeMtxt.PasswordChar = '\0';
            this.kodeMtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kodeMtxt.SelectedText = "";
            this.kodeMtxt.SelectionLength = 0;
            this.kodeMtxt.SelectionStart = 0;
            this.kodeMtxt.ShortcutsEnabled = true;
            this.kodeMtxt.Size = new System.Drawing.Size(447, 23);
            this.kodeMtxt.TabIndex = 2;
            this.kodeMtxt.UseSelectable = true;
            this.kodeMtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodeMtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kodeLBL
            // 
            this.kodeLBL.AutoSize = true;
            this.kodeLBL.Location = new System.Drawing.Point(271, 89);
            this.kodeLBL.Name = "kodeLBL";
            this.kodeLBL.Size = new System.Drawing.Size(37, 13);
            this.kodeLBL.TabIndex = 3;
            this.kodeLBL.Text = "KODE";
            // 
            // caridetailMTxt
            // 
            this.caridetailMTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.caridetailMTxt.CustomButton.Image = null;
            this.caridetailMTxt.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.caridetailMTxt.CustomButton.Name = "";
            this.caridetailMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.caridetailMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.caridetailMTxt.CustomButton.TabIndex = 1;
            this.caridetailMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.caridetailMTxt.CustomButton.UseSelectable = true;
            this.caridetailMTxt.CustomButton.Visible = false;
            this.caridetailMTxt.DisplayIcon = true;
            this.caridetailMTxt.Icon = ((System.Drawing.Image)(resources.GetObject("caridetailMTxt.Icon")));
            this.caridetailMTxt.IconRight = true;
            this.caridetailMTxt.Lines = new string[0];
            this.caridetailMTxt.Location = new System.Drawing.Point(261, 149);
            this.caridetailMTxt.Margin = new System.Windows.Forms.Padding(0);
            this.caridetailMTxt.MaxLength = 32767;
            this.caridetailMTxt.Name = "caridetailMTxt";
            this.caridetailMTxt.PasswordChar = '\0';
            this.caridetailMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.caridetailMTxt.SelectedText = "";
            this.caridetailMTxt.SelectionLength = 0;
            this.caridetailMTxt.SelectionStart = 0;
            this.caridetailMTxt.ShortcutsEnabled = true;
            this.caridetailMTxt.ShowClearButton = true;
            this.caridetailMTxt.Size = new System.Drawing.Size(516, 23);
            this.caridetailMTxt.TabIndex = 31;
            this.caridetailMTxt.UseSelectable = true;
            this.caridetailMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.caridetailMTxt.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cariListMtxt
            // 
            this.cariListMtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cariListMtxt.CustomButton.Image = null;
            this.cariListMtxt.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.cariListMtxt.CustomButton.Name = "";
            this.cariListMtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cariListMtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cariListMtxt.CustomButton.TabIndex = 1;
            this.cariListMtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cariListMtxt.CustomButton.UseSelectable = true;
            this.cariListMtxt.CustomButton.Visible = false;
            this.cariListMtxt.DisplayIcon = true;
            this.cariListMtxt.Icon = ((System.Drawing.Image)(resources.GetObject("cariListMtxt.Icon")));
            this.cariListMtxt.IconRight = true;
            this.cariListMtxt.Lines = new string[0];
            this.cariListMtxt.Location = new System.Drawing.Point(23, 60);
            this.cariListMtxt.Margin = new System.Windows.Forms.Padding(0);
            this.cariListMtxt.MaxLength = 32767;
            this.cariListMtxt.Name = "cariListMtxt";
            this.cariListMtxt.PasswordChar = '\0';
            this.cariListMtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cariListMtxt.SelectedText = "";
            this.cariListMtxt.SelectionLength = 0;
            this.cariListMtxt.SelectionStart = 0;
            this.cariListMtxt.ShortcutsEnabled = true;
            this.cariListMtxt.ShowClearButton = true;
            this.cariListMtxt.Size = new System.Drawing.Size(232, 23);
            this.cariListMtxt.TabIndex = 32;
            this.cariListMtxt.UseSelectable = true;
            this.cariListMtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cariListMtxt.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // namaLbl
            // 
            this.namaLbl.AutoSize = true;
            this.namaLbl.Location = new System.Drawing.Point(271, 120);
            this.namaLbl.Name = "namaLbl";
            this.namaLbl.Size = new System.Drawing.Size(38, 13);
            this.namaLbl.TabIndex = 33;
            this.namaLbl.Text = "NAMA";
            // 
            // namaMTxt
            // 
            // 
            // 
            // 
            this.namaMTxt.CustomButton.Image = null;
            this.namaMTxt.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.namaMTxt.CustomButton.Name = "";
            this.namaMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namaMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namaMTxt.CustomButton.TabIndex = 1;
            this.namaMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namaMTxt.CustomButton.UseSelectable = true;
            this.namaMTxt.CustomButton.Visible = false;
            this.namaMTxt.Lines = new string[0];
            this.namaMTxt.Location = new System.Drawing.Point(330, 115);
            this.namaMTxt.MaxLength = 32767;
            this.namaMTxt.Name = "namaMTxt";
            this.namaMTxt.PasswordChar = '\0';
            this.namaMTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namaMTxt.SelectedText = "";
            this.namaMTxt.SelectionLength = 0;
            this.namaMTxt.SelectionStart = 0;
            this.namaMTxt.ShortcutsEnabled = true;
            this.namaMTxt.Size = new System.Drawing.Size(448, 23);
            this.namaMTxt.TabIndex = 34;
            this.namaMTxt.UseSelectable = true;
            this.namaMTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namaMTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FListTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.namaMTxt);
            this.Controls.Add(this.namaLbl);
            this.Controls.Add(this.cariListMtxt);
            this.Controls.Add(this.caridetailMTxt);
            this.Controls.Add(this.kodeLBL);
            this.Controls.Add(this.kodeMtxt);
            this.Controls.Add(this.detailGC);
            this.Controls.Add(this.listGC);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FListTwo";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FListTwo";
            ((System.ComponentModel.ISupportInitialize)(this.listGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected MetroFramework.Controls.MetroTextBox caridetailMTxt;
        protected MetroFramework.Controls.MetroTextBox cariListMtxt;
        protected MetroFramework.Controls.MetroTextBox kodeMtxt;
        protected MetroFramework.Controls.MetroTextBox namaMTxt;
        protected System.Windows.Forms.Label namaLbl;
        protected System.Windows.Forms.Label kodeLBL;
        protected DevExpress.XtraGrid.GridControl listGC;
        protected DevExpress.XtraGrid.Views.Grid.GridView listGV;
        protected DevExpress.XtraGrid.GridControl detailGC;
        protected DevExpress.XtraGrid.Views.Grid.GridView detailGV;
    }
}