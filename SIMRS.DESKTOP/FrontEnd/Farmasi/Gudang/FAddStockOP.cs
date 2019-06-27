using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FAddStockOP : TFAddEditStockOP
    {
        protected List<v_aptbrggudetail_notin_stock> v_Aptbrggudetail_Notin_Stocks = null;

        #region private method

        protected string SaveAptStockOP(aptstockop Aptstockop, List<v_aptbrggudetail_notin_stock> v_Aptbrggudetail_Notin_Stocks)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptStockOPServices())
                {
                    Errresult = service.InsertStockOP(Aptstockop, v_Aptbrggudetail_Notin_Stocks);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                CustomMessageBox.MessageError(ex.InnerException.Message, "SaveAptbarangGudang()", this.Name, this);
            }

            return Errresult;
        }
        private void Load_v_aptpembelian_notin__aptbrggudetail()
        {
            try
            {
                using (var service = new AptStockOPServices())
                {
                    var result = Task.Run(() => service.SelectAll_v_aptbrggudetail_notin_stock());
                    if (result.Result.Item2 != null)
                    {
                        CustomMessageBox.MessageWarning(result.Result.Item2, this);
                        return;
                    }
                    else
                    {
                        vaptbrggudetailNotInStockGC.DataSource = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, this);
            }
        }

        private void defaultControl()
        {
            this.lblHeader.Text = "List Stock -> Add New Stock";
            this.periodeDateEdit.EditValue = DateTime.Now.Date;
            this.TglStockOPDateEdit.EditValue = DateTime.Now.Date;
        }

        #endregion private method
        public FAddStockOP(ref Panel pnlContent) : base (ref pnlContent)
        {
            try
            {
                defaultControl();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FAddStockOP()", this.Name, this);

            }
        }

        protected override void TFAddEditStockOP_Load(object sender, EventArgs e)
        {
            try
            {
                
                Load_v_aptpembelian_notin__aptbrggudetail();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FAddStockOP_Load()", this.Name, this);

            }
        }

        protected override void TFAddEditStockOP_Shown(object sender, EventArgs e)
        {
            try
            {
                this.TglStockOPDateEdit.Focus();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FAddStockOP_Shown()", this.Name, this);

            }

        }

        protected override void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void BSimpan_Click(object sender, EventArgs e)
        {
            bool ischoose = false;
            bool islanjut = true;

            if (this.TglStockOPDateEdit.EditValue == null)
            {
                CustomMessageBox.MessageWarning("Tanggal Stock tidak boleh kosong!", this.Name, this);
                this.TglStockOPDateEdit.Focus();
                return;
            }

            try
            {
                //cek yang sudah di centang
                for (int i = 0; i < this.vaptbrggudetailNotInStockGV.DataRowCount; i++)
                {
                    this.vaptbrggudetailNotInStockGV.FocusedRowHandle = i;

                    var ischeck = this.vaptbrggudetailNotInStockGV.GetFocusedRowCellValue("isstock").ToString();

                    if (!string.IsNullOrEmpty(ischeck))
                    {
                        if (ischeck.Trim().ToLower() == "true")
                        {
                            ischoose = true;
                            break;
                        }
                    }
                };

                if (!ischoose)
                {
                    CustomMessageBox.MessageWarning("Silahkan centang data barang yang dimaksudkan!", this);
                    this.vaptbrggudetailNotInStockGC.Focus();
                    return;
                }

                //cek yang belum di centang
                for (int i = 0; i < this.vaptbrggudetailNotInStockGV.DataRowCount; i++)
                {
                    this.vaptbrggudetailNotInStockGV.FocusedRowHandle = i;

                    var ischeck = this.vaptbrggudetailNotInStockGV.GetFocusedRowCellValue("isstock").ToString();

                    if (!string.IsNullOrEmpty(ischeck))
                    {
                        if (ischeck.Trim().ToLower() == "false")
                        {
                            ischoose = false;
                            break;
                        }
                    }
                };

                if (!ischoose)
                {
                    if (CustomMessageBox.MessageQuestion("Beberapa data barang yang belum dicentang\nApakah proses untuk membuat defenisi stock baru akan dilanjutkan\n[Yes] untuk melanjutkan\n[No ] untuk membatalkan",
                        "Konfirnmasi Stock Barang", this) != DialogResult.Yes)
                    {
                        islanjut = false;
                    }
                    
                }
                else
                {
                    if (CustomMessageBox.MessageQuestion("Apakah proses membuat stock baru akan dilanjutkan\nSilahkan dicek kembali\n[Yes] untuk melanjutkan\n[NO ] untuk membatalkan ",
                    "Konfirnmasi Stock Barang", this) != DialogResult.Yes)
                    {
                        islanjut = false;
                    }

                }

                

                if (islanjut)
                {

                    aptstockop Aptstockop = new aptstockop
                    {
                        aptstockopid = -1,
                        aptdepoid = 57,
                        aptstockopnm = this.ketStockOPTxt.Text,
                        tglstockop = DateTime.Parse( this.TglStockOPDateEdit.EditValue.ToString()).Date,
                        tahun = DateTime.Parse(this.TglStockOPDateEdit.EditValue.ToString()).Date.Year.ToString(),
                        bulan = DateTime.Parse(this.TglStockOPDateEdit.EditValue.ToString()).Date.Month.ToString("0#"),
                        hari =  DateTime.Parse(this.TglStockOPDateEdit.EditValue.ToString()).Date.Day.ToString("0#"),
                        jamstockop = DateTime.Parse(this.TglStockOPDateEdit.EditValue.ToString()).Date.Add(new TimeSpan(DateTime.Now.Date.Hour, DateTime.Now.Date.Minute, DateTime.Now.Date.Second))
                        
                    };

                    this.v_Aptbrggudetail_Notin_Stocks = new List<v_aptbrggudetail_notin_stock>();

                    for (int i = 0; i < this.vaptbrggudetailNotInStockGV.DataRowCount; i++)
                    {
                        this.vaptbrggudetailNotInStockGV.FocusedRowHandle = i;

                        var ischeck = this.vaptbrggudetailNotInStockGV.GetFocusedRowCellValue("isstock").ToString();

                        if (!string.IsNullOrEmpty(ischeck))
                        {
                            if (ischeck.Trim().ToLower() == "true")
                            {
                                var stock = new v_aptbrggudetail_notin_stock
                                {
                                    aptbrggudetailid = short.Parse( this.vaptbrggudetailNotInStockGV.GetFocusedRowCellValue("aptbrggudetailid").ToString()),
                                    jmlbrg = short.Parse(this.vaptbrggudetailNotInStockGV.GetFocusedRowCellValue("jmlbrg").ToString()),
                                };
                                this.v_Aptbrggudetail_Notin_Stocks.Add(stock);

                            }
                        }
                    };

                    var errResult = SaveAptStockOP(Aptstockop, this.v_Aptbrggudetail_Notin_Stocks);
                    if (string.IsNullOrEmpty(errResult))
                    {
                        CustomMessageBox.MessageInfo("Add Stock sukses disimpan !", this);

                        //this.DialogResult = DialogResult.OK;
                        Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                        this.pnlContent.Controls.Clear();
                        //fDashboard myForm = new fDashboard();
                        //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                        FListStockOP myForm = new FListStockOP(ref this.pnlContent);

                        myForm.TopLevel = false;
                        myForm.AutoScroll = true;
                        //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                        this.pnlContent.Controls.Add(myForm);
                        myForm.Dock = DockStyle.Fill;
                        myForm.Show();
                    }
                    else
                    {
                        CustomMessageBox.MessageInfo(errResult, this);

                    }
                    

                }


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Simpan_Click()", this.Name, this);
                
            }
        }

        protected override void BBatal_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListStockOP myForm = new FListStockOP(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Batal_Click()", this.Name, this);

            }
        }

        protected override void BBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListStockOP myForm = new FListStockOP(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "Back_Click()", this.Name, this);

            }
        }
    }
}
