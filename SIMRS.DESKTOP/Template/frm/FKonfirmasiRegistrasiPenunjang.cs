using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class FKonfirmasiRegistrasiPenunjang : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        public FKonfirmasiRegistrasiPenunjang()
        {
            InitializeComponent();
        }

        public FKonfirmasiRegistrasiPenunjang(ref Panel _pnlContent)
        {
            InitializeComponent();

            this.pnlContent = _pnlContent;

            //elper.CommonFuncControl.ReadOnlyControlInMetroForm(this as MetroFramework.Forms.MetroForm, true);
            this.Text = "Konfirmasi Registrasi";

            tglperiksadateEdit.EditValue = DateTime.Now;
        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
