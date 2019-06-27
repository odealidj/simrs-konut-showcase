using SIMRS.DESKTOP.Template.frm;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FHomeRegistrasiRJ : TFHome
    {
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl3;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl4;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;

        public FHomeRegistrasiRJ()
        {
            //lblHomeModul.Text = "MODUL REGISTRASI RAWAT JALAN";
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl4 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.SuspendLayout();
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(454, 633);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(66, 13);
            this.hyperlinkLabelControl1.TabIndex = 56;
            this.hyperlinkLabelControl1.Text = "List Registrasi";
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(526, 633);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(78, 13);
            this.hyperlinkLabelControl2.TabIndex = 57;
            this.hyperlinkLabelControl2.Text = "Add Pasien Baru";
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(610, 633);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(81, 13);
            this.hyperlinkLabelControl3.TabIndex = 58;
            this.hyperlinkLabelControl3.Text = "Add Pasien Lama";
            // 
            // hyperlinkLabelControl4
            // 
            this.hyperlinkLabelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hyperlinkLabelControl4.Location = new System.Drawing.Point(697, 633);
            this.hyperlinkLabelControl4.Name = "hyperlinkLabelControl4";
            this.hyperlinkLabelControl4.Size = new System.Drawing.Size(50, 13);
            this.hyperlinkLabelControl4.TabIndex = 59;
            this.hyperlinkLabelControl4.Text = "List Pasien";
            // 
            // FHomeRegistrasiRJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.hyperlinkLabelControl4);
            this.Controls.Add(this.hyperlinkLabelControl3);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Name = "FHomeRegistrasiRJ";
            this.Controls.SetChildIndex(this.hyperlinkLabelControl1, 0);
            this.Controls.SetChildIndex(this.hyperlinkLabelControl2, 0);
            this.Controls.SetChildIndex(this.hyperlinkLabelControl3, 0);
            this.Controls.SetChildIndex(this.hyperlinkLabelControl4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
