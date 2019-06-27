using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi.Gudang
{
    public partial class TFAddEditBarangGudang : Form
    {

        protected Panel pnlContent;
        public TFAddEditBarangGudang()
        {
            InitializeComponent();
        }
        public TFAddEditBarangGudang(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void TFAddEditBarangGudang_Load(object sender, EventArgs e)
        {

        }

        protected virtual void TFAddEditBarangGudang_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void VaptpembelianNotInGudangGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

        }

        protected virtual void DetailnotingudangrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void BBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BSimpan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BBatal_Click(object sender, EventArgs e)
        {

        }

        protected virtual void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void CariDataMTxt1_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void PeriodeDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
