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
    public partial class FListFour : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;


        public FListFour()
        {
            InitializeComponent();
        }

        public FListFour(ref Panel _pnlContent)
        {
            InitializeComponent();
            this.pnlContent = _pnlContent;
        }
    }
}
