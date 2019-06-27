using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi.Gudang;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS.Model;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FAddBarangGudang2 : TFAddEditBarangGudang
    {

        private bool isAllowChangedEvent = false;

        private List<v_aptpembelian> v_Aptpembelians;

        #region private methode

        protected string SaveAptbarangGudang(aptbrggu Aptbrggu, List<v_aptpembelian> v_Aptpembelians)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbrgguServices())
                {
                    Errresult = service.InsertBarangmasukGU(Aptbrggu, v_Aptpembelians);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nSaveAptbarangGudang()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }
        private void Load_v_aptpembelian_notin__aptbrggudetail()
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelian_notin__aptbrggudetail();
                    if (result.Item2 != null)
                    {
                        CustomMessageBox.MessageWarning(result.Item2, this);
                        return;
                    }
                    else
                    {
                        vaptpembelianNotInGudangGC.DataSource = result.Item1;
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
            this.kriteriaCbo.Properties.Items.Clear();
            this.kriteriaCbo.Properties.Items.AddRange(new string[] { "Periode", "PBF", "Faktur" });
            this.kriteriaCbo.SelectedIndex = 0;

            this.TglMasukGuDateEdit.EditValue = DateTime.Now.Date;
        }

        #endregion
        public FAddBarangGudang2(ref Panel pnlContent) : base (ref pnlContent)
        {
            this.lblHeader.Text = "Barang Masuk Gudang -> Add";
            defaultControl();
            //this.pnlContent = pnlContent;
        }

        protected override void TFAddEditBarangGudang_Load(object sender, EventArgs e)
        {
            try
            {
                Load_v_aptpembelian_notin__aptbrggudetail();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFAddEditBarangGudang_Load()", this.Name, this);
            }
        }

        protected override void TFAddEditBarangGudang_Shown(object sender, EventArgs e)
        {
            try
            {
                this.TglMasukGuDateEdit.Focus();
                isAllowChangedEvent = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "TFAddEditBarangGudang_Shown()", this.Name, this);
            }
        }

        protected override void VaptpembelianNotInGudangGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                int stsbrgmasukid = Convert.ToInt32(this.vaptpembelianNotInGudangGV.GetRowCellValue(e.RowHandle, "stsbrgmasukid"));

                if (stsbrgmasukid != 1)
                {
                    e.Appearance.BackColor = Helper.CustomColor.IsBarangPending();
                }

                //Override any other formatting
                e.HighPriority = true;

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "VaptpembelianNotInGudangGV_RowStyle()", this.Name, this);
            }
        }

        protected override void DetailnotingudangrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var data = this.vaptpembelianNotInGudangGV.GetFocusedRow() as v_aptpembelian;
                if (data == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data pada tabel dengan cara klik data pada tabel yang diinginkan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.vaptpembelianGV.FocusedRowHandle = 0;
                    return;
                }

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                var aptbarangmasuk = new aptbarangmasuk
                {
                    aptbarangmasukid = data.aptbarangmasukid,
                    tglmasuk = data.tglmasuk,
                    aptpbfid = data.aptpbfid,
                    nobeli = data.nobeli,
                    dpp = (data.dpp != null) ? data.dpp.Value : 0,
                    ppn = (data.ppn != null) ? data.ppn : 0,
                    biayakirim = (data.biayakirim != null) ? data.biayakirim.Value : 0,
                    materai = (data.materai != null) ? data.materai.Value : 0,
                    total = (data.total != null) ? data.total.Value : 0
                };

                FEDetailPembelianNotInGudang myForm = new FEDetailPembelianNotInGudang(ref this.pnlContent, ref aptbarangmasuk,null);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "DetailnotingudangrepositoryItemButtonEdit_ButtonClick()", this.Name, this);
            }
        }

        protected override void BBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                FListBarangMasukGudang2 myForm = new FListBarangMasukGudang2(ref this.pnlContent);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BBack_Click()", this.Name, this);
            }
        }

        protected override void BSimpan_Click(object sender, EventArgs e)
        {
            bool ischoose = false;

            if (this.TglMasukGuDateEdit.EditValue == null)
            {
                CustomMessageBox.MessageWarning("Tanggal tidak boleh kosong!", this.Name, this);
                this.TglMasukGuDateEdit.Focus();
                return;
            }

            try
            {

                for (int i = 0; i < this.vaptpembelianNotInGudangGV.DataRowCount; i++)
                {
                    vaptpembelianNotInGudangGV.FocusedRowHandle = i;

                    var ischeck = vaptpembelianNotInGudangGV.GetFocusedRowCellValue("ischeck").ToString();

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
                    CustomMessageBox.MessageWarning("Silahkan centang data pembelian yang dimaksudkan!", this);
                    this.vaptpembelianNotInGudangGC.Focus();
                    return;
                }


                if (CustomMessageBox.MessageQuestion("Apakah data pembelian yang dicentang, akan disimpan ke data gudang\nSilahkan dicek kembali\n[Yes] untuk melanjutkan\n[NO ] untuk membatalkan ",
                    "Konfirnmasi Pemasukan Data Ke Gudang", this) == DialogResult.Yes)
                {

                    aptbrggu Aptbrggu = new aptbrggu
                    {
                        aptbrgguid = -1,
                        aptgudangid = 57,
                        tglgu = DateTime.Parse(this.TglMasukGuDateEdit.EditValue.ToString()).Date,
                        tahun = DateTime.Parse(this.TglMasukGuDateEdit.EditValue.ToString()).Date.Year.ToString(),
                        bulan = DateTime.Parse(this.TglMasukGuDateEdit.EditValue.ToString()).Date.Month.ToString("0#"),
                        jamgu = DateTime.Parse(this.TglMasukGuDateEdit.EditValue.ToString()).Date.Add(new TimeSpan(DateTime.Now.Date.Hour, DateTime.Now.Date.Minute, DateTime.Now.Date.Second)),
                        ket = this.ketGuTxt.Text

                    };

                    this.v_Aptpembelians = new List<v_aptpembelian>();

                    for (int i = 0; i < this.vaptpembelianNotInGudangGV.DataRowCount; i++)
                    {
                        vaptpembelianNotInGudangGV.FocusedRowHandle = i;
                        var ischeck = vaptpembelianNotInGudangGV.GetFocusedRowCellValue("ischeck").ToString();
                        if (ischeck.Trim().ToLower() == "true")
                        {
                            var v = new v_aptpembelian
                            {
                                aptbarangmasukid = short.Parse(vaptpembelianNotInGudangGV.GetFocusedRowCellValue("aptbarangmasukid").ToString())
                            };
                            this.v_Aptpembelians.Add(v);
                        }
                    }

                    var errResult = SaveAptbarangGudang(Aptbrggu, this.v_Aptpembelians);
                    if (string.IsNullOrEmpty(errResult))
                    {
                        CustomMessageBox.MessageInfo("Add barang ke gudang sukses disimpan !", this);

                        //this.DialogResult = DialogResult.OK;
                        Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                        this.pnlContent.Controls.Clear();
                        //fDashboard myForm = new fDashboard();
                        //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                        FListBarangMasukGudang2 myForm = new FListBarangMasukGudang2(ref this.pnlContent);

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
                //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                FListBarangMasukGudang2 myForm = new FListBarangMasukGudang2(ref this.pnlContent);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "BBatal_Click()", this.Name, this);
            }
        }

        protected override void KriteriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAllowChangedEvent)
            {
                switch (kriteriaCbo.SelectedIndex)
                {
                    case 0: //periode
                        this.periodeDateEdit.Visible = true;
                        this.cariDataMTxt1.Visible = false;
                        this.periodeDateEdit.Focus();
                        break;
                    case 1: //PBF
                        this.periodeDateEdit.Visible = false;
                        this.cariDataMTxt1.Visible = true;
                        this.cariDataMTxt1.Focus();
                        break;
                    case 2: //faktur
                        this.periodeDateEdit.Visible = false;
                        this.cariDataMTxt1.Visible = true;
                        this.cariDataMTxt1.Focus();
                        break;
                    
                }
            }
        }

        protected override void CariDataMTxt1_EditValueChanged(object sender, EventArgs e)
        {
            /*
            try
            {

                //Load_v_aptpembelian(DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Year.ToString(),
                //  DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Month.ToString("0#"), this.cariDataMTxt1.Text);

                Load_v_aptpembelian(string.Empty, string.Empty, this.cariDataMTxt1.Text);

            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "cariDataMTxt1_TextChanged()", this.Name, this);
            }
            */
        }

        protected override void PeriodeDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                if (isAllowChangedEvent == false) return;

                if (periodeDateEdit.EditValue != null)
                {
                    Load_v_aptpembelian(DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Year.ToString(),
                      DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Month.ToString("0#"), string.Empty);
                }
                else
                {
                    Load_v_aptpembelian();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "PeriodeDateEdit_EditValueChanged", this.Name, this);
            }
            */
        }
    }
}
