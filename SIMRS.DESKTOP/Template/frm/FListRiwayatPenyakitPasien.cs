using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
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
    public partial class FListRiwayatPenyakitPasien : MetroFramework.Forms.MetroForm
    {
        protected Panel pnlContent;

        protected v_registrasiruangrawat v_Registrasiruangrawat;

        protected v_statuspenyakit v_Statuspenyakit;
        protected IList<v_statuspenyakit> v_Statuspenyakits;

        #region private method control

        private void Loadv_statuspenyakitByNormAsync(string norm)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = service.SelectAllv_statuspenyakitByNormAsync(norm);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        gc0.DataSource = result.Item1.ToList();
                        this.v_Statuspenyakits = gc0.DataSource as IList<v_statuspenyakit>;
                    }

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public FListRiwayatPenyakitPasien()
        {
            InitializeComponent();
        }

        public FListRiwayatPenyakitPasien(ref Panel pnlContent)
        {
            InitializeComponent();
            try
            {
                
                this.pnlContent = pnlContent;
                
                //this.defaultControl();
                //this.LoadDokterAsync();
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFListKartuKontrol()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FListRiwayatPenyakitPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Loadv_statuspenyakitByNormAsync(this.v_Registrasiruangrawat.nocm);
                if (gc0.DataSource != null)
                {
                    //if ((gc0.DataSource as IList<v_statuspenyakit>).Count > 0)
                    //{
                    //    this.v_Statuspenyakits = gc0.DataSource as IList<v_statuspenyakit>;
                    //}
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFListRiwayatPenyakitPasien_Shown()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
