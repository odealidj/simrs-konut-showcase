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

namespace SIMRS.DESKTOP.FrontEnd.RekamMedis
{
    public partial class FListDetailTransaksiPasien : MetroFramework.Forms.MetroForm
    {
        Panel pnlContent;
        private v_registrasi_rekammedis_from_v_registrasiruangrawat v_Registrasi_Rekammedis_From_V_Registrasiruangrawat;

        public FListDetailTransaksiPasien()
        {
            InitializeComponent();
        }

        public FListDetailTransaksiPasien(ref Panel pnlContent, 
            ref v_registrasi_rekammedis_from_v_registrasiruangrawat v_Registrasi_Rekammedis_From_V_Registrasiruangrawat) 
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat = v_Registrasi_Rekammedis_From_V_Registrasiruangrawat;

            this.lblTitle.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama: {2}, Penjamin: {3}",
                this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.noregistrasi,
                this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nocm,
                this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.nama,
                this.v_Registrasi_Rekammedis_From_V_Registrasiruangrawat.penjaminpasiennm);
            this.mtc1.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FHomeRekamMedis myForm = new FHomeRekamMedis();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
