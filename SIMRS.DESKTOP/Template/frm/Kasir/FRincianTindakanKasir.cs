using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Kasir
{
    public partial class FRincianTindakanKasir : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected int indexSelectedRow = 0;

        protected int indexSelectedRowFromSender = -1;

        #region property paging

        private const int _maxPageSize = 100;
        private int _pageSize = 50;

        protected int PageIndex { get; set; }

        protected int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < _maxPageSize) ? value : _maxPageSize;
            }
        }

        #endregion property paging
        public FRincianTindakanKasir()
        {
            InitializeComponent();

            this.PageIndex = 1;
        }

        public FRincianTindakanKasir(ref Panel pnlContent)
        {
            InitializeComponent();

            this.pnlContent = pnlContent;

            this.PageIndex = 1;
        }

        protected virtual void FRincianTindakanKasir_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
