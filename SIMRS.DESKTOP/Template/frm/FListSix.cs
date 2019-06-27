using DevExpress.XtraEditors;
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
    public partial class FListSix : MetroFramework.Forms.MetroForm
    {
        public delegate void PassData(object kode, object name);
        public PassData passData;

        public delegate void LoadHandler();
        public LoadHandler DelegateMethodLoadHandler;

        public FListSix()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
        }

        protected virtual void FListSix_Load(object sender, EventArgs e)
        {

        }

        protected virtual void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        protected virtual void FListSix_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        protected virtual void caridataMTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void dataNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            
        }

        protected virtual void dataNavigator2_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {

        }

        protected virtual void bOK_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bCancel_Click(object sender, EventArgs e)
        {

        }

        protected virtual void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        protected virtual void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
    }
}
