using SIMRS.DESKTOP.Template.frm.Kasir;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Kasir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Kasir
{
    public class FListRegistrasi : FListRegistrasiKasir
    {
        protected int indexSelectedRowFormSender = -1;

        protected IList<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats = null;

        #region private method control

        private async void LoadAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync(int pageIndex, int pageSize, DateTime tglmasuk)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = await service.SelectAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync (pageIndex, pageSize,tglmasuk );
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc1.DataSource = null;
                        gc.DataSource = result.Item1;
                        gv.ClearSelection();
                        gv.FocusedRowHandle = 0;
                        gv.SelectRow(0);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion private method control
        public FListRegistrasi (ref Panel pnlContent) : base(ref pnlContent)
        {
            this.Text = "List Registrasi Pasien";

            Helper.Stsmasukkeluar.stsmasukkeluarid = 1;
            Helper.Stsmasukkeluar.stsmasukkeluarnm = "Masuk";
            tglmasukMLbl.Text = "Tgl.Masuk:";

            this.indexSelectedRowFormSender = -1;

        }

        public FListRegistrasi(ref Panel pnlContent,
            List<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats,
            int indexSelectedRowFormSender) : base(ref pnlContent)
        {

            //contructor back
            this.Text = "List Registrasi Pasien";

            Helper.Stsmasukkeluar.stsmasukkeluarid = 1;
            Helper.Stsmasukkeluar.stsmasukkeluarnm = "Masuk";
            tglmasukMLbl.Text = "Tgl.Masuk:";
            this.v_Pelayananpasien_Distinct_From_Not_Alamats = v_Pelayananpasien_Distinct_From_Not_Alamats;
            this.indexSelectedRowFormSender = indexSelectedRowFormSender;

        }


        protected override void FListRegistrasiKasir_Shown(object sender, EventArgs e)
        {
            try
            {
                
                if (this.indexSelectedRowFormSender !=-1)
                {
                    gc1.DataSource = null;
                    gc.DataSource = this.v_Pelayananpasien_Distinct_From_Not_Alamats;
                    gv.ClearSelection();
                    gv.FocusedRowHandle = this.indexSelectedRowFormSender;
                    gv.SelectRow(this.indexSelectedRowFormSender);
                }
                else
                {
                    Load50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(this.PageIndex, this.PageSize, Helper.Stsmasukkeluar.stsmasukkeluarid);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nFListRegistrasiKasir_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void caridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(caridataMTxt.Text))
                {
                    Load50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(this.PageIndex, this.PageSize, Helper.Stsmasukkeluar.stsmasukkeluarid);
                }
                else
                {
                    LoadAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(this.PageIndex, this.PageSize, Helper.Stsmasukkeluar.stsmasukkeluarid, caridataMTxt.Text);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ncaridataMTxt_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tanggaldateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (tanggaldateEdit.EditValue == null)
                {
                    Load50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(this.PageIndex, this.PageSize, Helper.Stsmasukkeluar.stsmasukkeluarid);
                }
                else
                {
                    LoadAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync(this.PageIndex, this.PageSize, ((DateTime)tanggaldateEdit.EditValue).Date );
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntanggaldateEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_Pelayananpasien_Distinct_From_Not_Alamats = (List<v_pelayananpasien_distinct_from_not_alamat>)gc.DataSource;

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FRincianTindakanKasirBL myForm = new FRincianTindakanKasirBL(ref this.pnlContent, ref this.v_Pelayananpasien_Distinct_From_Not_Alamat,
                    this.v_Pelayananpasien_Distinct_From_Not_Alamats.ToList()
                    ,this.indexSelectedRow);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnNext_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
