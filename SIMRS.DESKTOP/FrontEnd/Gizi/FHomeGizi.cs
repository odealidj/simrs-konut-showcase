using SIMRS.DESKTOP.Template.frm;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.FrontEnd.Gizi
{
    public class FHomeGizi : TFHome
    {
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;

        public FHomeGizi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.SuspendLayout();
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(522, 627);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(69, 13);
            this.hyperlinkLabelControl2.TabIndex = 63;
            this.hyperlinkLabelControl2.Text = "List Pasien Gizi";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(450, 627);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(66, 13);
            this.hyperlinkLabelControl1.TabIndex = 62;
            this.hyperlinkLabelControl1.Text = "List Registrasi";
            // 
            // FHomeGizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Name = "FHomeGizi";
            this.Controls.SetChildIndex(this.hyperlinkLabelControl1, 0);
            this.Controls.SetChildIndex(this.hyperlinkLabelControl2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
