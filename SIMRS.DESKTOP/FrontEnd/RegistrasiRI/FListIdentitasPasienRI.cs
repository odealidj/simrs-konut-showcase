using SIMRS.DESKTOP.Template.frm;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.UI.FrontEnd.RegistrasiRI
{
    public class FListIdentitasPasienRI : FListIdentitasPasien
    {
        public FListIdentitasPasienRI(ref Panel _pnlContent ) : base(ref _pnlContent)
        {
            InitializeComponent();
           
        }

        protected override void FListIdentitasPasien_Load(object sender, EventArgs e)
        {

        }

        protected override void btnAddRegistrasiPasienLama_Click(object sender, EventArgs e)
        {

        }
    }
}
