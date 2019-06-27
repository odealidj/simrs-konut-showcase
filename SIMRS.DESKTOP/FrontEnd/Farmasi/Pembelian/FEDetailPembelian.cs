using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian
{
    public class FEDetailPembelian : FEditPembelian
    {
        public FEDetailPembelian(ref Panel pnlContent, ref aptbarangmasuk Aptbarangmasuk, Dictionary<int, string> Parampembelian) : base(ref pnlContent, ref Aptbarangmasuk, Parampembelian)
        {
            this.lblHeader.Text = "List Pembelian->Detail Item Pembelian";
            this.bAddRow.Visible = false;

            this.colaptbarangmasukdetailid.Visible = false;
            this.colaptbarangsatuanid.ColumnEdit = null;
            this.colaptbarangsatuanid.OptionsColumn.AllowEdit = false;
            this.colaptbarangnm.OptionsColumn.AllowEdit = false;
            this.coldefenisisatuan.OptionsColumn.AllowEdit = false;
            this.colkodebarangpbf.OptionsColumn.AllowEdit = false;
            this.colnobatch.OptionsColumn.AllowEdit = false;
            this.coltglkadaluarsa.OptionsColumn.AllowEdit = false;
            this.colhargasatuan.OptionsColumn.AllowEdit = false;
            this.colpot.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowEdit = false;

            this.coldelete.Visible = false;
            this.colaptbarangsatuanid.Visible = false;
            this.colaptbarangsatuanid2.Visible = false;

            this.bSimpan.Visible = false;
            this.bBatal.Visible = false;
        }

        protected override void FAddEditPembelian_Load(object sender, EventArgs e)
        {
            //LoadAptbarangmasukdetail(this.Aptbarangmasuk.aptbarangmasukid);
        }

        protected override void FAddEditPembelian_Shown(object sender, EventArgs e)
        {
            try
            {
                //Loadv_barangsatuanBypbfAsync(1);
                this.itembarangGC.Refresh();
                LoadAptbarangmasukdetail(this.Aptbarangmasuk.aptbarangmasukid);
                //this.itembarangGC.Refresh();

                //this.v_Aptpembeliandetails.Add(new v_aptpembeliandetail { aptbarangmasukdetailid = -1 });

                //this.v_Aptpembeliandetails.Add(new v_aptpembeliandetail { aptbarangmasukdetailid = -1 });

                //this.itembarangGC.DataSource = null;
                //this.itembarangGC.DataSource = this.v_Aptpembeliandetails;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFAddEditPembelian_Shown()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
