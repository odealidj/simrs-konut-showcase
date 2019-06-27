using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.Helper
{
    public static class SettingDefaultLookUpEdit
    {
        public static void DefultSettingLookUpEdit(ref LookUpEdit lookupedit, string[] FieldNames,
                string[] Captions,
                bool[] Visibles,
                string displaymember, string valuemember, string nullvalueprompt)

        {
            

            lookupedit.Properties.DataSource = null;
            lookupedit.Properties.BeginUpdate();
            lookupedit.Properties.Columns.Clear();

            short i = 0;
            foreach (var FieldName in FieldNames)
            {
                lookupedit.Properties.Columns.Add(new LookUpColumnInfo { FieldName = FieldName, Caption = Captions[i], Visible = Visibles[i] });
                i++;
            }
            lookupedit.Properties.EndUpdate();

            lookupedit.Properties.SearchMode = SearchMode.AutoFilter;
            lookupedit.Properties.PopupFilterMode = PopupFilterMode.Contains;
            lookupedit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lookupedit.Properties.NullValuePrompt = nullvalueprompt;
            lookupedit.Properties.ShowFooter = false;

            lookupedit.Properties.DisplayMember = displaymember;
            lookupedit.Properties.ValueMember = valuemember;
            lookupedit.Properties.TextEditStyle = TextEditStyles.Standard;
            lookupedit.EditValue = null;
        }
    }
}
