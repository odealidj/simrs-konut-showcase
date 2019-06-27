using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.SIE.Pendapatan
{
    public partial class FPendapatanByYearRange : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;
        public FPendapatanByYearRange()
        {
            InitializeComponent();
        }

        public FPendapatanByYearRange(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            this.tahunawalMTxt.Text = DateTime.Now.Year.ToString();
            this.tahunakhirMTxt.Text = (DateTime.Now.Year + 1).ToString();
            this.pendapatanByYearRangeMTC.SelectedIndex = 0;
        }

        private void rsGV_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;



            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Appearance.Font = new Font("Arial", 24);



            e.Graphics.DrawString("Data belum dimasukkan !!!", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }

        private void pelayananmedisGV_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;



            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Appearance.Font = new Font("Arial", 24);



            e.Graphics.DrawString("Data belum dimasukkan !!!", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }

        private void detailpelayananmedisGV_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;



            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Appearance.Font = new Font("Arial", 24);



            e.Graphics.DrawString("Data belum dimasukkan !!!", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }
    }
}
