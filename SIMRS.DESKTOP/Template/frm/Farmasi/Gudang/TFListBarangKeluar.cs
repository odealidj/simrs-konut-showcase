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
    public partial class TFListBarangKeluar : Form
    {
        protected int sisePage = 25;
        protected int pageNo = 1;

        protected Panel pnlContent;
        public TFListBarangKeluar()
        {
            InitializeComponent();
        }
        public TFListBarangKeluar(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void TFListBarangKeluar_Load(object sender, EventArgs e)
        {

        }

        protected virtual void TFListBarangKeluar_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void BAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BFirst_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BPrev_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BLast_Click(object sender, EventArgs e)
        {

        }

        protected virtual void DetailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
