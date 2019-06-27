using DevExpress.XtraEditors;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian;
using SIMRS.DESKTOP.Helper;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Gudang
{
    public class FListPembelianNotInGudang : FListBarangMasuk2
    {
        //private bool isSave = false;

        private List<v_aptpembelian> v_Aptpembelians;

        private Dictionary<int, string> ParamListBarangMasukGudang = null;

        //private int PageNofromtindaklanjut = -1;
        //private string SearchTextfromtindaklanjut = string.Empty;
        //private int Indexselectedfromtindaklanjut = -1;

        #region private method control

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

        private void Load_v_aptpembelianByYearAndMonth(string value)
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelianByYearAndMonth(value);
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


        private void Load_v_aptpembelianByKeterangan(string value)
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelianByKeterangn(value);
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

        private string DeleteAptbarangmasuk(aptbarangmasuk Aptbarangmasuk)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbarangmasukServices())
                {
                    Errresult = service.DeleteBarangmasuk(Aptbarangmasuk);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                CustomMessageBox.MessageError(ex.InnerException.Message, "DeleteAptbarangmasuk()", this.Name,  this);
            }

            return Errresult;
        }

      
        private void defaultControl()
        {
            this.vaptpembelianNotInGudangGC.Visible = true;
            this.vaptpembelianGC.Visible = false;
            this.gc2.Visible = false;
            this.gcDistribusi.Visible = false;
            this.periodeDateEdit.Enabled = false;

            this.bAdd.Text = "Add";
            this.bEdit.Visible = false;
            this.bDelete.Visible = false;

            this.colistock.Visible = false;
            this.colstsbrgmasukid.Visible = false;

            this.bFirst.Visible = false;
            this.bPrev.Visible = false;
            this.bNext.Visible = false;
            this.bLast.Visible = false;
            this.pageTxt.Visible = false;


        }

        #endregion private method control

        public FListPembelianNotInGudang(ref Panel pnlContent, Dictionary<int, string> ParamListBarangMasukGudang) : base(ref pnlContent)
        {
            this.Text = "Barang Masuk Gudang -> List Pembelian";
            this.ParamListBarangMasukGudang = ParamListBarangMasukGudang;

        }

        protected override void FListPembelian2_Load(object sender, EventArgs e)
        {
            try
            {
                ////Load_v_aptpembelianByYearAndMonth(DateTime.Now.Year.ToString());
                //periodedateEdit.EditValue = DateTime.Now.Date;
                Load_v_aptpembelian_notin__aptbrggudetail();
                
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "FListPembelian2_Load()", this.Name, this);
            }
        }

        protected override void FListPembelian2_Shown(object sender, EventArgs e)
        {
            defaultControl();
        }

       
        protected override void detailpembeianrepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {


                var data = this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian;
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

                FEDetailPembelianNotInGudang myForm = new FEDetailPembelianNotInGudang(ref this.pnlContent, ref aptbarangmasuk, this.ParamListBarangMasukGudang);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();





                /*

                var data = this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian;
                if (data==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data pada tabel dengan cara klik data pada tabel yang diinginkan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.vaptpembelianGV.FocusedRowHandle = 0;
                    return;
                }

                var dict = new Dictionary<int, string>();
                dict.Add(1, this.pageNo.ToString());
                dict.Add(2, this.cariDataMTxt.Text);
                dict.Add(3, this.vaptpembelianGV.FocusedRowHandle.ToString());


                try
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FListPembelianDetail myForm = new FListPembelianDetail(ref this.pnlContent,ref data, dict );
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                */


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ndetailpembeianrepository_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CustomMessageBox.MessageWarning("Silahkan pilih data pada tabel dengan cara klik data pada tabel yang diinginkan", this);
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

                FEDetailPembelianNotInGudang myForm = new FEDetailPembelianNotInGudang(ref this.pnlContent, ref aptbarangmasuk, this.ParamListBarangMasukGudang);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();



                /*

                var data = this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian;
                if (data==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih data pada tabel dengan cara klik data pada tabel yang diinginkan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.vaptpembelianGV.FocusedRowHandle = 0;
                    return;
                }

                var dict = new Dictionary<int, string>();
                dict.Add(1, this.pageNo.ToString());
                dict.Add(2, this.cariDataMTxt.Text);
                dict.Add(3, this.vaptpembelianGV.FocusedRowHandle.ToString());


                try
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FListPembelianDetail myForm = new FListPembelianDetail(ref this.pnlContent,ref data, dict );
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                */


            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "DetailnotingudangrepositoryItemButtonEdit_ButtonClick()", this.Name, this);
            }
        }

        protected override void bBack_Click(object sender, EventArgs e)
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {
            bool ischoose = false;

            try
            {

                for (int i = 0; i < this.vaptpembelianNotInGudangGV.DataRowCount; i++)
                {
                    vaptpembelianNotInGudangGV.FocusedRowHandle = i;

                    var ischeck = vaptpembelianNotInGudangGV.GetFocusedRowCellValue("ischeck").ToString();

                    if (!string.IsNullOrEmpty( ischeck))
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
                        tglgu = DateTime.Now.Date,
                        tahun = DateTime.Now.Date.Year.ToString(),
                        bulan = DateTime.Now.Date.Month.ToString("0#"),
                        jamgu = DateTime.Now.Date.Add(new TimeSpan(DateTime.Now.Date.Hour, DateTime.Now.Date.Minute, DateTime.Now.Date.Second)),
                        ket = "-"

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
                        CustomMessageBox.MessageInfo(errResult,this);
                        
                    }

                }

                    /*

                    var data = this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian;
                    if (data == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Silahkan pilih data pembelian pada tabel List Pembelian!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.vaptpembelianGC.Focus();
                        return;
                    }

                    using (FAddBarangMasukGudang f = new FAddBarangMasukGudang(ref data))
                    {
                        //create an overlay form
                        XtraForm overlayForm = new XtraForm();
                        overlayForm.StartPosition = this.StartPosition;// FormStartPosition.CenterScreen; //this.StartPosition;
                        overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                        overlayForm.Opacity = .80d;
                        overlayForm.BackColor = Color.Black;
                        overlayForm.Size = Screen.PrimaryScreen.WorkingArea.Size;// base.Size; //(this as FListRegistrasiRI).Activate.Size; //mainmenu.Size;// this.Size;
                        overlayForm.Location = Screen.PrimaryScreen.WorkingArea.Location; //base.Location;// FMainMenuRI.ActiveForm.Location; //mainmenu.Location;// this.Location;
                                                                                          //overlayForm.Size = this.Size;
                                                                                          //overlayForm.Location =  this.Location;
                        overlayForm.ShowInTaskbar = false;
                        overlayForm.Show();

                        //Show the dialog
                        f.Owner = overlayForm;
                        if (f.ShowDialog() == DialogResult.OK)
                        {

                            this.isSave = true;

                            //Load_v_aptpembelian_notin__aptbrggudetail();



                        }

                        //Get rid of the overlay form
                        overlayForm.Dispose();
                        f.Dispose();



                    }

                    if (this.isSave)
                    {
                        this.isSave = false;

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

                    */
                }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbAdd_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
