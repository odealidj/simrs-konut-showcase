using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Helper;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.POLI;
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
    public partial class FDiagnosaPasien : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected icdxsubkategori selectedIcdxsubkategori;


        #region private methode control
        public void defaultControl()
        {
            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref doktericdxLookUpEdit,
               new string[] { "dokterid", "dokternm" },
               new string[] { "Kode", "DOKTER" },
               new bool[] { false, true },
               "dokternm", "dokterid", "Pilih dokter ...");

            SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref jenisdiagnosaLookUpEdit,
               new string[] { "jenisdiagnosaid", "jenisdiagnosanm" },
               new string[] { "Kode", "JENIS DIAGNOSA" },
               new bool[] { false, true },
               "jenisdiagnosanm", "jenisdiagnosaid", "Pilih jenis diagnosa ...");
        }

        private async void LoadDokterAsyn()
        {
            try
            {
                using (var service = new ListDiagosaPasienPoliServices())
                {
                    var result = await service.SelectDokterAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        doktericdxLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadJenisDIagnosaAsync()
        {
            try
            {
                using (var service = new ListDiagosaPasienPoliServices())
                {
                    var result = await service.SelectJenisdiagnosaAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        jenisdiagnosaLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public FDiagnosaPasien()
        {
            InitializeComponent();
        }

        public FDiagnosaPasien(ref Panel _pnlContent)
        {
            InitializeComponent();
            this.pnlContent = _pnlContent;
            this.tglicdxDateEdit.EditValue = DateTime.Now.Date;
            this.icdxMTC.SelectedIndex = 0;

            defaultControl();
            LoadDokterAsyn();
            LoadJenisDIagnosaAsync();
        }

        

        protected virtual void FDiagnosaPasien_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FDiagnosaPasien_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void icdxButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FListICDXPOLI f = new FListICDXPOLI())
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passData += new FListICDXPOLI.PassData(passData);
                    f.ShowDialog();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nDiagnosaAwalButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void passData(object kode, object name)
        {
            if (kode != null)
            {
                if (!string.IsNullOrEmpty(kode.ToString()))
                {
                    selectedIcdxsubkategori = new icdxsubkategori()
                    {
                        icdxsubkategoriid = kode.ToString()
                    };
                    icdxButtonEdit.Text = kode + " - " + name;
                }
                else
                {
                    icdxButtonEdit.Text = string.Empty;
                }
            }
            else
            {
                icdxButtonEdit.Text = string.Empty;
            }
        }

        protected virtual void bAddIcdX_Click(object sender, EventArgs e)
        {

        }

        protected virtual void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        protected virtual void icdxGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
