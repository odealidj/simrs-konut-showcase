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
    public partial class FPendapatanByYearAndMonth : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;
        public FPendapatanByYearAndMonth()
        {
            InitializeComponent();
            this.tahunMTxt.Text = DateTime.Now.Year.ToString() ;
        }

        public FPendapatanByYearAndMonth(ref Panel pnlContent)
        {
            InitializeComponent();

            this.pnlContent = pnlContent;
            this.tahunMTxt.Text = DateTime.Now.Year.ToString();
            this.bulanDateEdit.EditValue = DateTime.Now.Date;
            this.pendapatanByYearAndMonthMTC.SelectedIndex = 0;
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
