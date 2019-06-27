using SIMRS.DESKTOP.Helper;
using SIMRS.Services;
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
    public partial class FCaraPulang : MetroFramework.Forms.MetroForm
    {

        #region private methode control

        protected void defaultControl()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref carapulangLookUpEdit,
               new string[] { "carapulangid", "carapulangnm" },
               new string[] { "KODE", "CARA PULANG" },
               new bool[] { false, true },
               "carapulangnm", "carapulangid", "Pilih tujuan rujukan");
        }

        protected async void LoadCarapulangByPelayananmedikIdAsync(short pelayananmedikid)
        {
            try
            {
                using (var service = new CaraPulangServices())
                {
                    var result = await service.SelectAllCarapulangByPelayananmedikIdAsync(pelayananmedikid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        carapulangLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        public FCaraPulang()
        {
            InitializeComponent();

            defaultControl();
        }

        protected virtual void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
