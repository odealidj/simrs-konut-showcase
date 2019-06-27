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
    public partial class FListDetailPasienRM : MetroFramework.Forms.MetroForm
    {
        private Panel pnlContent;

        private v_identitaspasien_jk_alamatpasien v_Identitaspasien_Jk_Alamatpasien;


        public FListDetailPasienRM(ref Panel pnlContent,ref v_identitaspasien_jk_alamatpasien v_Identitaspasien_Jk_Alamatpasien)
        {
            InitializeComponent();
            this.pnlContent = pnlContent;
            this.v_Identitaspasien_Jk_Alamatpasien = v_Identitaspasien_Jk_Alamatpasien;

            this.lblTitle.Text = string.Format("NoRM: {0}, Nama: {1}",
                this.v_Identitaspasien_Jk_Alamatpasien.nocm,
                this.v_Identitaspasien_Jk_Alamatpasien.nama);
            this.mtc1.SelectedIndex = 0;
        }
    }
}
