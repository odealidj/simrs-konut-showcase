namespace SIMRS.DESKTOP.Template.frm
{
    partial class TFLoginRuangRawat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFLoginRuangRawat));
            this.ruangrawatMcb = new MetroFramework.Controls.MetroComboBox();
            this.mbtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ruangrawatMcb
            // 
            this.ruangrawatMcb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ruangrawatMcb.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.ruangrawatMcb.FormattingEnabled = true;
            this.ruangrawatMcb.ItemHeight = 19;
            this.ruangrawatMcb.Location = new System.Drawing.Point(39, 134);
            this.ruangrawatMcb.Name = "ruangrawatMcb";
            this.ruangrawatMcb.Size = new System.Drawing.Size(193, 25);
            this.ruangrawatMcb.Style = MetroFramework.MetroColorStyle.Blue;
            this.ruangrawatMcb.TabIndex = 1;
            this.ruangrawatMcb.UseSelectable = true;
            this.ruangrawatMcb.UseStyleColors = true;
            this.ruangrawatMcb.SelectedIndexChanged += new System.EventHandler(this.ruangrawatMcb_SelectedIndexChanged);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mbtnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.mbtnLogin.Appearance.Options.UseBackColor = true;
            this.mbtnLogin.Appearance.Options.UseForeColor = true;
            this.mbtnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.mbtnLogin.Location = new System.Drawing.Point(39, 256);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(73, 29);
            this.mbtnLogin.TabIndex = 30;
            this.mbtnLogin.Text = "Login";
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 32);
            this.panel1.TabIndex = 32;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(246, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 32);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(49, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.AllowFocused = false;
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect;
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogo.Size = new System.Drawing.Size(183, 125);
            this.picLogo.TabIndex = 24;
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.DisplayIcon = true;
            this.mtxtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("mtxtPassword.Icon")));
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(39, 215);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.PromptText = "Input password";
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.ShowClearButton = true;
            this.mtxtPassword.Size = new System.Drawing.Size(193, 25);
            this.mtxtPassword.TabIndex = 3;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.UseStyleColors = true;
            this.mtxtPassword.WaterMark = "Input password";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUsername
            // 
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.DisplayIcon = true;
            this.mtxtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("mtxtUsername.Icon")));
            this.mtxtUsername.Lines = new string[0];
            this.mtxtUsername.Location = new System.Drawing.Point(39, 174);
            this.mtxtUsername.MaxLength = 32767;
            this.mtxtUsername.Name = "mtxtUsername";
            this.mtxtUsername.PasswordChar = '\0';
            this.mtxtUsername.PromptText = "Input username";
            this.mtxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsername.SelectedText = "";
            this.mtxtUsername.SelectionLength = 0;
            this.mtxtUsername.SelectionStart = 0;
            this.mtxtUsername.ShortcutsEnabled = true;
            this.mtxtUsername.ShowClearButton = true;
            this.mtxtUsername.Size = new System.Drawing.Size(193, 25);
            this.mtxtUsername.TabIndex = 2;
            this.mtxtUsername.UseSelectable = true;
            this.mtxtUsername.UseStyleColors = true;
            this.mtxtUsername.WaterMark = "Input username";
            this.mtxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TFLoginRuangRawat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(272, 309);
            this.ControlBox = false;
            this.Controls.Add(this.ruangrawatMcb);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.mtxtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TFLoginRuangRawat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLoginRuangRawat";
            this.Load += new System.EventHandler(this.FLoginRuangRawat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected MetroFramework.Controls.MetroTextBox mtxtPassword;
        protected MetroFramework.Controls.MetroTextBox mtxtUsername;
        protected MetroFramework.Controls.MetroComboBox ruangrawatMcb;
        protected DevExpress.XtraEditors.PictureEdit picLogo;
        protected DevExpress.XtraEditors.SimpleButton mbtnLogin;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnClose;
    }
}