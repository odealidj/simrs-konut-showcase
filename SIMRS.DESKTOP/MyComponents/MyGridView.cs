using DevExpress.Utils.Serializing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.MyComponents
{
    public partial class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid)
        {
            // put your initialization code here
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        protected override string ViewName { get { return "MyGridView"; } }
    }


    public class MyGridColumnCollection : GridColumnCollection
    {
        public MyGridColumnCollection(ColumnView view) : base(view) { }

        protected override GridColumn CreateColumn()
        {
            return new MyGridColumn();
        }
    }

    public class MyGridColumn : GridColumn
    {
        private int minWidth = 5;

        [DXCategory(CategoryName.Appearance),
            DefaultValue(5), XtraSerializableProperty(), XtraSerializablePropertyId(LayoutIdLayout)]
        public override int MinWidth
        {
            get
            {
                return minWidth;
            }
            set
            {
                if (value < 1) value = 1;
                if (value > 1000) value = 1000;
                if (value == MinWidth) return;
                minWidth = value;
                OnChanged();
            }
        }
    }
}
