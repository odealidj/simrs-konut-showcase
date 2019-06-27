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

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class FListBed : MetroFramework.Forms.MetroForm
    {
        protected v_listtempattidurrawatinap listtempattidurrawatinap;

        protected Panel pnlContent;

        public FListBed()
        {
            InitializeComponent();
        }

        public FListBed(ref Panel _pnlContent) 
        {
            InitializeComponent();
            this.pnlContent = _pnlContent;
        }

        protected virtual void jmltempattidurTileView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void repositoryItemButtonRegister_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void repositoryItemButtonRegister_Click(object sender, EventArgs e)
        {

        }

        private void listtempattidurGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            listtempattidurrawatinap = listtempattidurGV.GetRow(e.FocusedRowHandle) as v_listtempattidurrawatinap;
        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
