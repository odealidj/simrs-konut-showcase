namespace SIMRS.DESKTOP.Template.frm.Farmasi
{
    partial class FFilterPembelian
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
            this.aktifFilterJenisObatCheck = new MetroFramework.Controls.MetroCheckBox();
            this.filtercbo = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.aktifPeriodeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.periodedateEdit = new DevExpress.XtraEditors.DateEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodedateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodedateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.metroCheckBox1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.aktifPeriodeCheck);
            this.panel1.Controls.Add(this.periodedateEdit);
            this.panel1.Controls.Add(this.aktifFilterJenisObatCheck);
            this.panel1.Controls.Add(this.filtercbo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 211);
            this.panel1.TabIndex = 51;
            // 
            // aktifFilterJenisObatCheck
            // 
            this.aktifFilterJenisObatCheck.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.aktifFilterJenisObatCheck.Location = new System.Drawing.Point(44, 32);
            this.aktifFilterJenisObatCheck.Name = "aktifFilterJenisObatCheck";
            this.aktifFilterJenisObatCheck.Size = new System.Drawing.Size(18, 25);
            this.aktifFilterJenisObatCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.aktifFilterJenisObatCheck.TabIndex = 41;
            this.aktifFilterJenisObatCheck.UseSelectable = true;
            // 
            // filtercbo
            // 
            this.filtercbo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.filtercbo.FormattingEnabled = true;
            this.filtercbo.ItemHeight = 19;
            this.filtercbo.Location = new System.Drawing.Point(97, 32);
            this.filtercbo.Name = "filtercbo";
            this.filtercbo.Size = new System.Drawing.Size(96, 25);
            this.filtercbo.Style = MetroFramework.MetroColorStyle.Green;
            this.filtercbo.TabIndex = 40;
            this.filtercbo.UseCustomForeColor = true;
            this.filtercbo.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 19;
            this.metroComboBox1.Location = new System.Drawing.Point(269, 138);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(96, 25);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox1.TabIndex = 55;
            this.metroComboBox1.UseCustomForeColor = true;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.Location = new System.Drawing.Point(38, 138);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(18, 25);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroCheckBox1.TabIndex = 54;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(91, 137);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit1.Properties.DisplayFormat.FormatString = "y";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.EditFormat.FormatString = "y";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.Mask.EditMask = "y";
            this.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Properties.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Size = new System.Drawing.Size(172, 26);
            this.dateEdit1.TabIndex = 53;
            // 
            // aktifPeriodeCheck
            // 
            this.aktifPeriodeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aktifPeriodeCheck.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.aktifPeriodeCheck.Location = new System.Drawing.Point(38, 87);
            this.aktifPeriodeCheck.Name = "aktifPeriodeCheck";
            this.aktifPeriodeCheck.Size = new System.Drawing.Size(18, 25);
            this.aktifPeriodeCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.aktifPeriodeCheck.TabIndex = 52;
            this.aktifPeriodeCheck.UseSelectable = true;
            // 
            // periodedateEdit
            // 
            this.periodedateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodedateEdit.EditValue = null;
            this.periodedateEdit.Location = new System.Drawing.Point(91, 86);
            this.periodedateEdit.Name = "periodedateEdit";
            this.periodedateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.periodedateEdit.Properties.Appearance.Options.UseFont = true;
            this.periodedateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodedateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodedateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.periodedateEdit.Properties.DisplayFormat.FormatString = "y";
            this.periodedateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.periodedateEdit.Properties.EditFormat.FormatString = "y";
            this.periodedateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.periodedateEdit.Properties.Mask.EditMask = "y";
            this.periodedateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.periodedateEdit.Properties.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.periodedateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.periodedateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.periodedateEdit.Size = new System.Drawing.Size(172, 26);
            this.periodedateEdit.TabIndex = 51;
            // 
            // FFilterPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 291);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFilterPembelian";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "FFilterPembelian";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodedateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodedateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected MetroFramework.Controls.MetroComboBox metroComboBox1;
        protected MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        protected DevExpress.XtraEditors.DateEdit dateEdit1;
        protected MetroFramework.Controls.MetroCheckBox aktifPeriodeCheck;
        protected DevExpress.XtraEditors.DateEdit periodedateEdit;
        protected MetroFramework.Controls.MetroCheckBox aktifFilterJenisObatCheck;
        protected MetroFramework.Controls.MetroComboBox filtercbo;
    }
}