using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Kasir
{
    public class FRincianTindakanKasirL : FRincianTindakanKasirBL
    {
        public FRincianTindakanKasirL(ref Panel pnlContent,
            ref v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat,
            List<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats,
            int indexSelectedRowFromSender) : base(ref pnlContent, ref v_Pelayananpasien_Distinct_From_Not_Alamat, 
                v_Pelayananpasien_Distinct_From_Not_Alamats, indexSelectedRowFromSender)
        {

            //constructor

            this.btnAdd.Text = "Laporan";
            ststransaksi.Text = "Sudah pelunasan";
            ststransaksi.ForeColor = Color.Teal;

            totalBiayaLbl.ForeColor = Color.Teal;
            bayarLbl.ForeColor = Color.Teal;

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListPelunasan myForm = new FListPelunasan(ref this.pnlContent, this.v_Pelayananpasien_Distinct_From_Not_Alamats.ToList(),
                this.indexSelectedRowFromSender);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                //Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                //this.pnlContent.Controls.Clear();
                ////fDashboard myForm = new fDashboard();
                //FBayar myForm = new FBayar(ref this.pnlContent,
                //    ref this.v_Pelayananpasien_Distinct_From_Not_Alamat,
                //    this.v_Pelayananpasien_Distinct_From_Not_Alamats.ToList(),
                //    this.v_Pelayananpasien_Rincian_Not_Alamats.ToList(),
                //    indexSelectedRowFromSender);
                //myForm.TopLevel = false;
                //myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                //this.pnlContent.Controls.Add(myForm);
                //myForm.Dock = DockStyle.Fill;
                //myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAdd_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
