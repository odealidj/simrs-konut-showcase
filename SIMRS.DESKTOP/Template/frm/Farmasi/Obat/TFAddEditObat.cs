using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Farmasi.Obat
{
    public partial class TFAddEditObat : MetroFramework.Forms.MetroForm
    {

        private async void LoadAptdef1brgAsync()
        {
            try
            {
                using (var service = new Aptdef1brgServices())
                {
                    var result = await service.SelectAllAptdef1brgAsync();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.jenisLookUpEdit.Properties.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void defaultsetinglookupedit()
        {
            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref this.jenisLookUpEdit,
               new string[] { "aptdef1kode", "aptdef1singkatan", "aptdef1nm" },
               new string[] { "ID","Kode", "Nama" },
               new bool[] { false, true,true },
               "aptdef1singkatan", "aptdef1kode", "Pilih jenis barang ...");


        }
        public TFAddEditObat()
        {
            InitializeComponent();
            try
            {
                defaultsetinglookupedit();
                LoadAptdef1brgAsync();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void FAddEditObat_Load(object sender, EventArgs e)
        {

        }

        protected virtual void FAddEditObat_Shown(object sender, EventArgs e)
        {

        }

        protected virtual void bSimpan_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bBatal_Click(object sender, EventArgs e)
        {

        }

        protected virtual void bBack_Click(object sender, EventArgs e)
        {

        }


    }
}
