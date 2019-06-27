using DevExpress.XtraEditors;
using SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi;
using SIMRS.DESKTOP.Template.frm.Farmasi.Pembelian;
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

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian
{
    public class FListBarangMasuk2 : TFListPembelian2
    {
        private v_aptpembelian V_Aptpembelian;
        private int indexSelectedBarangMasuk = -1;

        private IDictionary<int, string> Parampembelian;
        private int pstartpage = -1;
        private string ptahun = string.Empty;
        private string pbulan = string.Empty;
        private string pSearchText = string.Empty;
        private int pIndexselected = -1;
        private bool isAllowChangedEvent = false;


        #region private method control

        //protected async void LoadAptdef1brgAsync()
        //{
        //    try
        //    {
        //        using (var service = new Aptdef1brgServices())
        //        {
        //            var result = await service.SelectAllAptdef1brgAsync();
        //            if (result.Item2 != null)
        //            {
        //                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //            else
        //            {
        //                filtercbo.Properties.DataSource = result.Item1;
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void LoadAptstsbrgmasukdetails(string value)
        {
            try
            {
                using (var service = new AptstsbgrmasukdetailServices())
                {   
                    var result = Task.Run(() => service.SelectAllAsync(value));
                    if (result.Result.Item2 != null)
                    {
                        CustomMessageBox.MessageWarning(result.Result.Item2, "Message", this);
                        return;
                    }
                    else
                    {
                        this.statusLookUpEdit.Properties.DataSource = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, this);
            }
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
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        vaptpembelianGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Load_v_aptpembelian()
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelian();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        vaptpembelianGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_v_aptpembelian(string tahun, string bulan, string search)
        {
            try
            {
                using (var service = new ListbarangmasukServices())
                {
                    var result = service.SelectAll_v_aptpembelian(tahun, bulan, search);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        vaptpembelianGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.Message, "Load_v_aptpembelian", this.Name, this);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nDeleteAptbarangmasuk()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }



        private void defaultControl()
        {

            //SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref filtercbo,
            //  new string[] { "aptdef1kode", "aptdef1singkatan" },
            //  new string[] { "KODE", "JENIS" },
            //  new bool[] { false, true },
            //  "aptdef1singkatan", "aptdef1kode", "Pilih ...");


            //this.aktifPeriodeCheck.Checked = true;
            //this.periodedateEdit.Enabled = false;

            //this.aktifFilterJenisObatCheck.Checked = true;

            this.vaptpembelianGC.Visible = true;
            this.gc2.Visible = false;
            this.gcDistribusi.Visible = false;

            
            this.periodeDateEdit.Enabled = true;

            this.kriteriaCbo.Properties.Items.Clear();
            this.kriteriaCbo.Properties.Items.AddRange(new string[] { "Periode", "PBF", "Faktur", "Status Barang" });
            this.kriteriaCbo.SelectedIndex = 0;

            this.periodeDateEdit.Visible = true;
            this.cariDataMTxt1.Visible = false;
            this.statusLookUpEdit.Visible = false;

            defaultsetinglookupedit();

            this.colistock.MinWidth = 5;
            this.colistock.Width = 5;
            this.colistock.MaxWidth = 5;


        }

        private void defaultsetinglookupedit()
        {
            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref this.statusLookUpEdit,
               new string[] { "aptstsbrgmasukdetailid", "aptstsbrgmasukdetailnm" },
               new string[] { "Kode", "Status" },
               new bool[] { false, true },
               "aptstsbrgmasukdetailnm", "aptstsbrgmasukdetailid", String.Empty);

            
        }

        #endregion private method control

        public FListBarangMasuk2(ref Panel pnlContent) : base(ref pnlContent)
        {
            this.Text = "List Pembelian";

            this.vaptpembelianGC.Visible = true;
            
            defaultControl();
            //LoadAptdef1brgAsync();

            

        }

        

        public FListBarangMasuk2(ref Panel pnlContent, int indexSelectedBarangMasuk) : base(ref pnlContent)
        {
            this.Text = "List Pembelian";

            this.vaptpembelianGC.Visible = true;

            defaultControl();
            //LoadAptdef1brgAsync();

            
            this.indexSelectedBarangMasuk = indexSelectedBarangMasuk;
        }

        //contructor from listpembeliandetail, edit listpembelian
        public FListBarangMasuk2(ref Panel pnlContent, IDictionary<int, string> Parampembelian) : base(ref pnlContent)
        {
            try
            {
                this.Text = "List Pembelian";

                this.vaptpembelianGC.Visible = true;

                defaultControl();
                //LoadAptdef1brgAsync();


                this.Parampembelian = Parampembelian;
                if (this.Parampembelian != null)
                {
                    this.pstartpage = int.Parse(Parampembelian[1]); // page start
                    this.ptahun = Parampembelian[2].ToString();
                    this.pbulan = Parampembelian[3].ToString();
                    this.pSearchText = Parampembelian[4].ToString(); 
                    this.pIndexselected= int.Parse(Parampembelian[5]);

                    if ((!string.IsNullOrEmpty( this.ptahun)) && (!string.IsNullOrEmpty(this.pbulan)))
                    {
                        
                        this.periodeDateEdit.EditValue = DateTime.Parse(string.Format("{0}/{1}", this.pbulan, this.ptahun));

                    }
                    if (!string.IsNullOrEmpty(this.pSearchText))
                    {
                        this.cariDataMTxt1.Text = this.pSearchText;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void FListPembelian2_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAptstsbrgmasukdetails(string.Empty);
                ////Load_v_aptpembelianByYearAndMonth(DateTime.Now.Year.ToString());
                //periodedateEdit.EditValue = DateTime.Now.Date;
                if (this.Parampembelian != null)
                {
                    Load_v_aptpembelian(this.ptahun, this.pbulan, this.pSearchText);
                    
                }
                else
                {
                    Load_v_aptpembelian();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FListPembelian2_Shown(object sender, EventArgs e)
        {
            try
            {
                //vaptpembelianGC.Focus();
                //vaptpembelianGV.ClearSelection();
                //if (this.indexSelectedBarangMasuk == -1) this.indexSelectedBarangMasuk = 0;
                //vaptpembelianGV.SelectRow(this.indexSelectedBarangMasuk);
                //vaptpembelianGV.FocusedRowHandle = this.indexSelectedBarangMasuk;

                if (this.Parampembelian!=null)
                {
                    
                    if (this.pIndexselected != -1) this.indexSelectedBarangMasuk = this.pIndexselected;
                }

                

                this.vaptpembelianGV.ClearSelection();
                this.vaptpembelianGV.FocusedRowHandle = this.indexSelectedBarangMasuk;
                this.vaptpembelianGV.SelectRow(this.indexSelectedBarangMasuk);
                this.vaptpembelianGV.Focus();
                this.vaptpembelianGC.Focus();

                this.pstartpage = -1;
                this.ptahun = string.Empty;
                this.pbulan = string.Empty;
                this.pSearchText= string.Empty;
                this.pIndexselected = -1;

                isAllowChangedEvent = true;

                this.colistock.MinWidth = 5;
                this.colistock.Width = 5;
                this.colistock.MaxWidth = 5;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFListPembelian_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        this.statusLookUpEdit.Visible = false;
                        this.periodeDateEdit.Focus();
                        break;
                    case 1: //PBF
                        this.periodeDateEdit.Visible = false;
                        this.cariDataMTxt1.Visible = true;
                        this.statusLookUpEdit.Visible = false;
                        this.cariDataMTxt1.Focus();
                        break;
                    case 2: //faktur
                        this.periodeDateEdit.Visible = false;
                        this.cariDataMTxt1.Visible = true;
                        this.statusLookUpEdit.Visible = false;
                        this.cariDataMTxt1.Focus();
                        break;
                    case 3: //satus barang faktur
                        this.periodeDateEdit.Visible = false;
                        this.cariDataMTxt1.Visible = false;
                        this.statusLookUpEdit.Visible = true;
                        this.statusLookUpEdit.Focus();
                        break;
                }
            }
        }

        protected override void cariDataMTxt1_TextChanged(object sender, EventArgs e)
        {
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
        }

        protected override void DetailrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

                var dict = new Dictionary<int, string>();
                dict.Add(1, this.pageNo.ToString()); //startpage
                dict.Add(2, (periodeDateEdit.EditValue != null) ? DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Year.ToString() : string.Empty); //tahun
                dict.Add(3, (periodeDateEdit.EditValue != null) ? DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Month.ToString("0#") : string.Empty); //tahun/bulan
                dict.Add(4, this.cariDataMTxt1.Text); // search
                dict.Add(5, this.vaptpembelianGV.FocusedRowHandle.ToString()); // index row

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

                FEDetailPembelian myForm = new FEDetailPembelian(ref this.pnlContent, ref aptbarangmasuk, dict);

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

                var dict = new Dictionary<int, string>();
                dict.Add(1, this.pageNo.ToString()); //startpage
                dict.Add(2, (periodeDateEdit.EditValue != null) ? DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Year.ToString() : string.Empty); //tahun
                dict.Add(3, (periodeDateEdit.EditValue != null) ? DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Month.ToString("0#") : string.Empty); //tahun/bulan
                dict.Add(4, this.cariDataMTxt1.Text); // search
                dict.Add(5, this.vaptpembelianGV.FocusedRowHandle.ToString()); // index row

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

                   FEDetailPembelian myForm = new FEDetailPembelian(ref this.pnlContent, ref aptbarangmasuk, dict);

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

        protected override void vaptpembelianGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.V_Aptpembelian = vaptpembelianGV.GetFocusedRow() as v_aptpembelian;
                if (this.V_Aptpembelian != null)
                {
                    
                    this.indexSelectedBarangMasuk = e.FocusedRowHandle;
                }
                else
                {
                 
                    this.indexSelectedBarangMasuk = -1;
                }

            }
            catch (Exception ex)
            {
                this.indexSelectedBarangMasuk = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nGV1_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void VaptpembelianGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                int stsbrgmasukid = Convert.ToInt32(this.vaptpembelianGV.GetRowCellValue(e.RowHandle, "stsbrgmasukid"));

                if (stsbrgmasukid != 1)
                {
                    e.Appearance.BackColor = Helper.CustomColor.IsBarangPending();
                }
                //else
                //{
                //    e.Appearance.BackColor = Color.LightGreen;
                //}

                //Override any other formatting
                e.HighPriority = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "VaptpembelianGV_RowStyle()", this.Name, this);
            }
        }

        protected override void VaptpembelianGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                int isstock = Convert.ToInt32(this.vaptpembelianGV.GetRowCellValue(e.RowHandle, "isstock"));
                if (e.Column.FieldName == "isstock")
                {
                    if (isstock != 1)
                    {


                        e.Appearance.BackColor = Helper.CustomColor.IsBarangNotInGudang();
                        e.Appearance.ForeColor = Helper.CustomColor.IsBarangNotInGudang();
                        e.Column.ToolTip = "Belum masuk gudang";

                    }
                    else
                    {
                        //e.Appearance.BackColor = Helper.CustomColor.IsBarangInGudang();
                        //e.Appearance.ForeColor = Helper.CustomColor.IsBarangInGudang();
                        e.Column.ToolTip = "Sudah masuk gudang";
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "VaptpembelianGV_CustomDrawCell()", this.Name, this);
            }
        }

        /*
        protected override void VaptpembelianGV_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int stock = Convert.ToInt32(this.vaptpembelianGV.GetRowCellValue(e.RowHandle, "isstock"));
            if (stock == 0)
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
        */

        protected override void vaptpembelianGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (vaptpembelianGV.DataRowCount == 1)
                {
                    this.vaptpembelianGV.FocusedRowHandle = 0;
                    this.V_Aptpembelian = vaptpembelianGV.GetRow(0) as v_aptpembelian;
                    
                    this.indexSelectedBarangMasuk = 0;
                }
            }
            catch (Exception ex)
            {
                this.indexSelectedBarangMasuk = -1;
                CustomMessageBox.MessageError(ex.InnerException.Message, "vaptpembelianGV_RowCellClick()", this.Name, this);
            }
        }

        
        protected override void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FDetailBarangMasuk myForm = new FDetailBarangMasuk(ref this.pnlContent, this.V_Aptpembelian);
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
        }

        protected override void bAdd_Click(object sender, EventArgs e)
        {

            try
            {

               
               Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

               this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListGudangBarangMasuk2 myForm = new FListGudangBarangMasuk2(ref this.pnlContent);

                FAddPembelian myForm = new FAddPembelian(ref this.pnlContent);

               myForm.TopLevel = false;
               myForm.AutoScroll = true;
               //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
               this.pnlContent.Controls.Add(myForm);
               myForm.Dock = DockStyle.Fill;
               myForm.Show();
               
                /*

                using (FAddPembelian f = new FAddPembelian())
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
                        //LoadAllPembayaran(Helper.Mytoken.accessToken, this.Temuandetail.temuandetailid);
                        Load_v_aptpembelian();

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();


                }
                */

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbAdd_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bEdit_Click(object sender, EventArgs e)
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


                var dict = new Dictionary<int, string>();
                dict.Add(1, this.pageNo.ToString()); //startpage
                dict.Add(2, (periodeDateEdit.EditValue != null) ? DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Year.ToString() : string.Empty  ); //tahun
                dict.Add(3, (periodeDateEdit.EditValue != null) ? DateTime.Parse(this.periodeDateEdit.EditValue.ToString()).Month.ToString("0#") : string.Empty); //tahun/bulan
                dict.Add(4, this.cariDataMTxt1.Text); // search
                dict.Add(5, this.vaptpembelianGV.FocusedRowHandle.ToString()); // index row

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

                FEditPembelian myForm = new FEditPembelian(ref this.pnlContent, ref aptbarangmasuk, dict);

                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

                /*

                using (FEditPembelian f = new FEditPembelian
                    (
                        new aptbarangmasuk
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
                        }
                    ))

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
                        //LoadAllPembayaran(Helper.Mytoken.accessToken, this.Temuandetail.temuandetailid);
                        Load_v_aptpembelian();
                        this.vaptpembelianGV.FocusedRowHandle = 0;
                        this.vaptpembelianGC.Focus();


                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();


                }

                */


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbEdit_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (CustomMessageBox.MessageQuestion(string.Format("Apakah data pembelian dengan PBF:{0}, NoFaktur:{1},Tanggal:{2} akan dihapus?\nJika Yes, maka item pembelian juga akan ikut terhapus.",
                    (this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).aptpbfnm,
                    (this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).nobeli,
                    (this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).tglmasuk.Value.ToString("dd-MM-yyyy")), this) == DialogResult.Yes)

                    //if (MetroFramework.MetroMessageBox.Show(this, string.Format("Apakah data pembelian dengan PBF:{0}, NoFaktur:{1},Tanggal:{2} akan dihapus?\nItem pembelian juga akan ikut dihapus.",
                    //(this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).aptpbfnm,
                    //(this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).nobeli,
                    //(this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).tglmasuk.Value.ToString("dd-MM-yyyy")), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var errResult = DeleteAptbarangmasuk(new aptbarangmasuk { aptbarangmasukid = (this.vaptpembelianGV.GetFocusedRow() as v_aptpembelian).aptbarangmasukid });
                    if (string.IsNullOrEmpty( errResult))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Delete data suksess !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_v_aptpembelian();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, errResult, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbDelete_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bFirst_Click(object sender, EventArgs e)
        {

        }

        protected override void bPrev_Click(object sender, EventArgs e)
        {

        }

        protected override void bNext_Click(object sender, EventArgs e)
        {

        }

        protected override void bLast_Click(object sender, EventArgs e)
        {

        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            
        }

        protected override void PeriodeDateEdit_EditValueChanged(object sender, EventArgs e)
        {
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
        }
    }
}
