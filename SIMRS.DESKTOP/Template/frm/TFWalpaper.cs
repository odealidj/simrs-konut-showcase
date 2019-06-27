using SIMRS.DESKTOP.FrontEnd.Farmasi;
using SIMRS.DESKTOP.FrontEnd.RegistrasiRJ;
using SIMRS.DESKTOP.FrontEnd.SIE;
using SIMRS.DESKTOP.Template.frm.SIE;
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
    public partial class TFWalpaper : Form
    {
        public TFWalpaper()
        {
            InitializeComponent();

            //modul farmasi
            //this.BackgroundImage = Properties.Resources.far3;

            //modul sie
            this.BackgroundImage = Properties.Resources.sie01;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            

        }

        private void TFWalpaper_Shown(object sender, EventArgs e)
        {
            //modul registrasi rawat jalan
            //FLoginRegistrasiRJ f = new FLoginRegistrasiRJ(this);

            //modul farmasi
            //FLoginFarmasi2 f = new FLoginFarmasi2(this);

            //Modul SIE
            FLoginSIE f = new FLoginSIE(this);

            if (f.ShowDialog() != DialogResult.OK)
            {
                f.Close();
                this.Close();
            }
            


            
               
            
            //FMainMenuSIE f = new FMainMenuSIE()

            

        }
    }
}
