namespace SIMRS.DESKTOP.Template.frm
{
    partial class TFDialogExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFDialogExit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            this.picUserHide = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.picUserHide);
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bOK);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 122);
            this.panel1.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bCancel.Location = new System.Drawing.Point(272, 85);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(46, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bOK
            // 
            this.bOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bOK.Location = new System.Drawing.Point(220, 85);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(46, 23);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "OK";
            this.bOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // lblText
            // 
            this.lblText.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblText.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblText.Appearance.Options.UseFont = true;
            this.lblText.Appearance.Options.UseForeColor = true;
            this.lblText.Location = new System.Drawing.Point(75, 35);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(243, 23);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Apakah akan keluar dari aplikasi";
            // 
            // picUserHide
            // 
            this.picUserHide.Image = ((System.Drawing.Image)(resources.GetObject("picUserHide.Image")));
            this.picUserHide.Location = new System.Drawing.Point(27, 28);
            this.picUserHide.Margin = new System.Windows.Forms.Padding(0);
            this.picUserHide.Name = "picUserHide";
            this.picUserHide.Size = new System.Drawing.Size(38, 35);
            this.picUserHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserHide.TabIndex = 20;
            this.picUserHide.TabStop = false;
            // 
            // TFDialogExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 122);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TFDialogExit";
            this.Text = "TFDialogExit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserHide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.PictureBox picUserHide;
        protected DevExpress.XtraEditors.SimpleButton bCancel;
        protected DevExpress.XtraEditors.SimpleButton bOK;
        protected DevExpress.XtraEditors.LabelControl lblText;
    }
}