using SIMRS.DESKTOP.Template.frm.Farmasi.Pembelian;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian
{
    public class FListPembelianDetail: TFListPembelianDetail
    {
        protected v_aptpembelian v_Aptpembelian;
        private IDictionary<int, string> Parampembelian;

        #region private method
        private void Load_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid, string search)
        {
            try
            {
                using (var service = new AptbarangmasukdetailServices())
                {
                    var result = service.SelectAll_v_aptpembeliandetailByAptbarangmasukId(aptbarangmasukid, search);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.vaptpembeliandetailGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion private method


        public FListPembelianDetail (ref Panel pnlContent, ref v_aptpembelian v_Aptpembelian,
            IDictionary<int, string> Parampembelian) :base(ref pnlContent)
        {
            try
            {
                this.Text = "Detail Item Pembelian";

                this.v_Aptpembelian = v_Aptpembelian;
                if (this.v_Aptpembelian != null)
                {
                    this.tglbeliDateEdit.EditValue = this.v_Aptpembelian.tglmasuk;
                    this.nofakturTxt.Text = this.v_Aptpembelian.nobeli;
                    this.pbfTxt.Text = this.v_Aptpembelian.aptpbfnm;
                }

                this.Parampembelian = Parampembelian;
                if (this.Parampembelian != null)
                {

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListPembelianDetail()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListPembelianDetail_Load(object sender, EventArgs e)
        {
            try
            {
                Load_v_aptpembeliandetailByAptbarangmasukId(this.v_Aptpembelian.aptbarangmasukid, string.Empty);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListPembelianDetail_Load()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListPembelianDetail_Shown(object sender, EventArgs e)
        {

        }

        protected override void vaptpembeliandetailGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (this.vaptpembeliandetailGV.RowCount == 1)
                {
                    this.vaptpembeliandetailGV.FocusedRowHandle = 0;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nvaptpembeliandetailGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void vaptpembeliandetailGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var data = this.vaptpembeliandetailGV.GetFocusedRow() as v_aptpembeliandetail;
                if (data != null)
                {
                    this.lblSelect.Text = string.Format("Selected: {0}, nobatch: {1}, expire: {2}", data.aptbarangnm, data.nobatch, data.tglkadaluarsa);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nvaptpembeliandetailGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent,this.Parampembelian);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
