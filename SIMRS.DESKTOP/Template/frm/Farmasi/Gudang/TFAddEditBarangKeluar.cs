
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
    public partial class TFAddEditBarangKeluar : Form
    {
        protected Panel pnlContent;
        public TFAddEditBarangKeluar()
        {
            InitializeComponent();
        }

        public TFAddEditBarangKeluar(ref Panel pnlContent)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
        }

        protected virtual void TFAddEditBarangKeluar_Load(object sender, EventArgs e)
        {
            
        }

        protected virtual void TFAddEditBarangKeluar_Shown(object sender, EventArgs e)
        {
            
        }

        protected virtual void BAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BSimpan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BBatal_Click(object sender, EventArgs e)
        {
           

        }

        protected virtual void BBack_Click(object sender, EventArgs e)
        {
            

        }

        private void QtyTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&
            //  (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
