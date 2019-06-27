using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Tarif
{
    public partial class FAddEditTarif : MetroFramework.Forms.MetroForm
    {



        protected int daftartindakanid;
        protected short kelasid;
        public FAddEditTarif()
        {
            InitializeComponent();
        }

        public FAddEditTarif(int daftartindakanid, short kelasid,
                string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            InitializeComponent();
            try
            {
                this.daftartindakanid = daftartindakanid;
                this.kelasid = kelasid;
                this.namatarifMTxt.Text = namatarif;
                this.hargatarifMTxt.Text =  ((decimal)harga).ToString("#,0");
                this.jasasaranaMTxt.Text = ((decimal)jasasarana).ToString("#,0");  
                this.jasapelayananMTxt.Text = ((decimal)jasapelayanan).ToString("#,0");  
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddEditTarif()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FAddEditTarif(int daftartindakanid, 
                string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            InitializeComponent();
            try
            {
                this.daftartindakanid = daftartindakanid;
                this.namatarifMTxt.Text = namatarif;
                this.hargatarifMTxt.Text = ((decimal)harga).ToString("#,0");
                this.jasasaranaMTxt.Text = ((decimal)jasasarana).ToString("#,0");
                this.jasapelayananMTxt.Text = ((decimal)jasapelayanan).ToString("#,0");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddEditTarif()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FAddEditTarif(int daftartindakanid, short kelasid,string kelasuraian,
                string namatarif, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            InitializeComponent();
            try
            {
                this.daftartindakanid = daftartindakanid;
                this.kelasid = kelasid;
                this.kelasMTxt.Text = kelasuraian;
                this.namatarifMTxt.Text = namatarif;
                this.hargatarifMTxt.Text = ((decimal)harga).ToString("#,0");
                this.jasasaranaMTxt.Text = ((decimal)jasasarana).ToString("#,0");
                this.jasapelayananMTxt.Text = ((decimal)jasapelayanan).ToString("#,0");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFAddEditTarif()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void bUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
