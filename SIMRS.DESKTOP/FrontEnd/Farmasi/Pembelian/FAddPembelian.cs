using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SIMRS.DESKTOP.Helper;
using SIMRS.DESKTOP.Template.frm.Farmasi;
using SIMRS.DESKTOP.Template.frm.Farmasi.Pembelian;
using SIMRS.Model;
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
    public class FAddPembelian : TFAddEditPembelian
    {

        //protected v_apttemppembelian v_Apttemppembelian  = null;
        protected aptbarangmasuk Aptbarangmasuk = null;
        protected aptbarangmasukdetail Aptbarangmasukdetail  = null;
        protected List<aptbarangmasukdetail> Aptbarangmasukdetails  = null;


        #region private methode


        protected void LoadAptpbfAsync()
        {
            try
            {
                using (var service = new AptpbfServices())
                {
                    var result =  Task.Run( ()=> service.SelectAllAptpbfAsync());
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.pbfLookUpEdit.Properties.DataSource  = result.Result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void LoadAptSatuan(string filtered)
        {
            try
            {
                using (var service = new AptsatuanServices())
                {
                    var result = Task.Run(() => service.SelectAllAptsatuanAsync(filtered));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        
                        this.satuanrepositoryItemLookUpEdit.BeginUpdate();
                        this.satuanrepositoryItemLookUpEdit.Columns.Clear();


                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptsatuankode", Caption = "SATUAN", Visible = true });
                        
                        this.satuanrepositoryItemLookUpEdit.EndUpdate();

                        this.satuanrepositoryItemLookUpEdit.DataSource = null;
                        this.satuanrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

                        this.satuanrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.satuanrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.satuanrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.satuanrepositoryItemLookUpEdit.NullValuePrompt = "Satuan ...";
                        this.satuanrepositoryItemLookUpEdit.ShowFooter = false;

                        this.satuanrepositoryItemLookUpEdit.DisplayMember = "aptsatuankode";
                        this.satuanrepositoryItemLookUpEdit.ValueMember = "aptsatuankode";
                        this.satuanrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.satuanrepositoryItemLookUpEdit.NullText = string.Empty;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadAptBarangAsync()
        {
            try
            {
                using (var service = new Aptbarangservices())
                {
                    var result = Task.Run(() => service.SelectAllAsync());
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.barangrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

                        this.barangrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.barangrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.barangrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.barangrepositoryItemLookUpEdit.NullValuePrompt = "Pilih barang";
                        this.barangrepositoryItemLookUpEdit.ShowFooter = false;

                        this.barangrepositoryItemLookUpEdit.AutoSearchColumnIndex = 0;
                        this.barangrepositoryItemLookUpEdit.DisplayMember = "aptbarangnm";
                        this.barangrepositoryItemLookUpEdit.ValueMember = "aptbarangid";
                        this.barangrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.barangrepositoryItemLookUpEdit.NullText = string.Empty;
                        //lookupedit.EditValue = null;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Loadv_barangsatuanBypbfAsync(short pbfid)
        {
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    var result = Task.Run(() => service.GetAll_v_aptbarangsatuan_pbfByPbfAsync(pbfid));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.barangrepositoryItemLookUpEdit.DataSource = null;

                        this.barangrepositoryItemLookUpEdit.BeginUpdate();
                        this.barangrepositoryItemLookUpEdit.Columns.Clear();


                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptbarangsatuanid", Caption = "ID", Visible = true });
                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptbarangnm", Caption = "NAMA BARANG", Visible = true });
                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "satuankecilkode", Caption = "SATUAN KECIL", Visible = false });
                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "jmlsatuankecil", Caption = "QTY KECIL", Visible = false });
                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "satuanbesarkode", Caption = "SATUAN BESAR", Visible = false });
                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "jmlsatuanbesar", Caption = "QTY BESAR", Visible = false });
                        this.barangrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "defenisisatuan", Caption = "DEFENISI SATUAN", Visible = true });

                        this.barangrepositoryItemLookUpEdit.EndUpdate();

                        this.barangrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

                        this.barangrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.barangrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.barangrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.barangrepositoryItemLookUpEdit.NullValuePrompt = "Pilih barang";
                        this.barangrepositoryItemLookUpEdit.ShowFooter = false;

                        this.barangrepositoryItemLookUpEdit.AutoSearchColumnIndex = 1;
                        this.barangrepositoryItemLookUpEdit.DisplayMember = "aptbarangnm";
                        this.barangrepositoryItemLookUpEdit.ValueMember = "aptbarangsatuanid";
                        this.barangrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.barangrepositoryItemLookUpEdit.NullText = string.Empty;
                        //lookupedit.EditValue = null;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadAptStsBarangAsync()
        {
            try
            {
                using (var service = new AptstsbgrmasukdetailServices())
                {
                    var result = Task.Run(() => service.SelectAllAsync(string.Empty));
                    
                    if (result.Result.Item2 != null)
                    {
                        CustomMessageBox.MessageError(result.Result.Item2, this);
                        return;
                    }
                    else
                    {
                        this.stsbrgrepositoryItemLookUpEdit.DataSource = null;

                        this.stsbrgrepositoryItemLookUpEdit.BeginUpdate();
                        this.stsbrgrepositoryItemLookUpEdit.Columns.Clear();


                        this.stsbrgrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptstsbrgmasukdetailid", Caption = "ID", Visible = true });
                        this.stsbrgrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptstsbrgmasukdetailnm", Caption = "Status", Visible = true });
                        
                        this.stsbrgrepositoryItemLookUpEdit.EndUpdate();

                        this.stsbrgrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

                        this.stsbrgrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.stsbrgrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.stsbrgrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.stsbrgrepositoryItemLookUpEdit.NullValuePrompt = "Pilih sts...";
                        this.stsbrgrepositoryItemLookUpEdit.ShowFooter = false;

                        this.stsbrgrepositoryItemLookUpEdit.AutoSearchColumnIndex = 1;
                        this.stsbrgrepositoryItemLookUpEdit.DisplayMember = "aptstsbrgmasukdetailnm";
                        this.stsbrgrepositoryItemLookUpEdit.ValueMember = "aptstsbrgmasukdetailid";
                        this.stsbrgrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.stsbrgrepositoryItemLookUpEdit.NullText = string.Empty;
                        //lookupedit.EditValue = null;
                    }
                }
            }

            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, this);
                
            }
        }

        protected string SaveAptbarangmasuk(aptbarangmasuk Aptbarangmasuk, List<aptbarangmasukdetail> Aptbarangmasukdetails)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbarangmasukServices())
                {
                    Errresult = service.InsertBarangmasuk(Aptbarangmasuk, Aptbarangmasukdetails);
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\nSaveAptbarangmasuk()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }

        protected void LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short aptbarangsatuanid)
        {
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    //var result = Task.Run(() => service.SelectAllAptbarangsatuantriggerByAptbarangsatuanidAsync(aptbarangsatuanid));\
                    var result = service.SelectAllAptbarangsatuantriggerByAptbarangsatuanid(aptbarangsatuanid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        //this.satuanrepositoryItemLookUpEdit.DataSource = null;

                        this.satuanrepositoryItemLookUpEdit.BeginUpdate();
                        this.satuanrepositoryItemLookUpEdit.Columns.Clear();


                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptbarangsatuantriggerid", Caption = "aptbarangsatuantriggerid", Visible = false });
                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptsatuankode", Caption = "SATUAN", Visible = true });
                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "qty", Caption = "QTY", Visible = true });
                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "stskb", Caption = "stskb", Visible = false });

                        this.satuanrepositoryItemLookUpEdit.EndUpdate();

                        this.satuanrepositoryItemLookUpEdit.DataSource = null;
                        this.satuanrepositoryItemLookUpEdit.DataSource = result.Item1;

                        this.satuanrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.satuanrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.satuanrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.satuanrepositoryItemLookUpEdit.NullValuePrompt = "Satuan ...";
                        this.satuanrepositoryItemLookUpEdit.ShowFooter = false;

                        this.satuanrepositoryItemLookUpEdit.DisplayMember = "aptsatuankode";
                        this.satuanrepositoryItemLookUpEdit.ValueMember = "aptbarangsatuantriggerid";
                        this.satuanrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.satuanrepositoryItemLookUpEdit.NullText = string.Empty;


                        //lookupedit.EditValue = null;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void defaultsetinglookupedit()
        {
            Helper.SettingDefaultLookUpEdit.DefultSettingLookUpEdit(ref this.pbfLookUpEdit,
               new string[] { "aptpbfid", "aptpbfnm" },
               new string[] { "Kode", "P B F" },
               new bool[] { false, true },
               "aptpbfnm", "aptpbfid", "Pilih PBF ...");

            
        }

        #endregion

        public FAddPembelian(ref Panel pnlContent): base(ref pnlContent)
        {
            try
            {
                this.lblHeader.Text = "List Pembelian->Add Pembelian";
                this.tglbeliDateEdit.EditValue = DateTime.Now;

                this.colaptbarangsatuanid2.Visible = false;

                defaultsetinglookupedit();
                LoadAptpbfAsync();
                LoadAptSatuan(string.Empty);
                LoadAptStsBarangAsync();
                //LoadAptBarangAsync();
                //Loadv_barangsatuanBypbfAsync();
                //LoadAptBarangAsync();
                //LoadAptSatuanAsync();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFAddPembelian()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        protected override void FAddEditPembelian_Load(object sender, EventArgs e)
        {

        }

        protected override void FAddEditPembelian_Shown(object sender, EventArgs e)
        {
            //this.itembarangGV.RefreshEditor(true);
        }

        protected override void pbfLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.pbfLookUpEdit.EditValue != null)
                {
                    Loadv_barangsatuanBypbfAsync(short.Parse( this.pbfLookUpEdit.EditValue.ToString()));
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\npbfLookUpEdit_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tglbeliDateEdit.EditValue==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal pembelian!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tglbeliDateEdit.Focus();
                    return;
                }
                if (this.pbfLookUpEdit.EditValue ==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi data PBF!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.pbfLookUpEdit.Focus();
                    return;
                }

                if (this.nofakturTxt.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi Nofaktur!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.nofakturTxt.Focus();
                    return;
                }

                if (itembarangGV.DataRowCount == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data barang belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                for (int i = 0; i < itembarangGV.DataRowCount; i++)
                {


                    itembarangGV.FocusedRowHandle = i;

                    var tglkadaluarsa = (itembarangGV.GetFocusedRowCellDisplayText(this.coltglkadaluarsa));
                    if (tglkadaluarsa == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Tanggal Expire belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var nobatch = (itembarangGV.GetFocusedRowCellDisplayText(this.colnobatch));
                    if (nobatch == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Nobatch belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var aptsatuangrid = (itembarangGV.GetFocusedRowCellDisplayText(this.colsatuan));
                    if (aptsatuangrid == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Satuan barang belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var qty = (itembarangGV.GetFocusedRowCellDisplayText(this.colqty));
                    if (qty == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "QTY belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var parseqty = int.Parse(itembarangGV.GetFocusedRowCellDisplayText(this.colqty));
                    if (parseqty == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "QTY belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var hargasatuan = (itembarangGV.GetFocusedRowCellDisplayText(this.colhargasatuan));
                    if (hargasatuan == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Harga Satuan belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var parsehargasatuan = decimal.Parse(itembarangGV.GetFocusedRowCellDisplayText(this.colhargasatuan));
                    if (parsehargasatuan == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Harga Satuan belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var pot = (itembarangGV.GetFocusedRowCellDisplayText(this.colpot));
                    if (pot == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Potongan belum diisi, \n atau jika potongan tidak ada, silahkan isi potongan dengan nilai 0 !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var total = (itembarangGV.GetFocusedRowCellDisplayText(this.coltotal));
                    if (total == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Harga Total belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var parsetotal = decimal.Parse(itembarangGV.GetFocusedRowCellDisplayText(this.coltotal));
                    if (parsetotal == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Harga Total belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    //var aptbarangsatuantriggerid = (itembarangGV.GetFocusedRowCellDisplayText(this.colaptbarangsatuantriggerid));
                    //if (aptbarangsatuantriggerid == string.Empty)
                    //{
                    //    MetroFramework.MetroMessageBox.Show(this, "Satuan belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    this.itembarangGV.ClearSelection();
                    //    this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                    //    this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                    //    this.itembarangGV.Focus();
                    //    this.itembarangGC.Focus();
                    //    return;
                    //}

                    var aptbarangsatuanid = (itembarangGV.GetFocusedRowCellDisplayText(this.colaptbarangsatuanid));
                    if (aptbarangsatuanid == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Nama Barang belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }


                    var satuan = (itembarangGV.GetFocusedRowCellDisplayText(this.colsatuan));
                    if (satuan == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Satuan belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var aptbarangnm = (itembarangGV.GetFocusedRowCellDisplayText(this.colaptbarangnm));
                    if (aptbarangnm == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Nama Barang belum diisi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }

                    var aptstsbrg = (itembarangGV.GetFocusedRowCellDisplayText(this.colaptstsbgrmasukdetailid));
                    if (aptstsbrg == string.Empty)
                    {
                        CustomMessageBox.MessageWarning("Status Barang belum diisi !", this);
                        this.itembarangGV.ClearSelection();
                        this.itembarangGV.FocusedRowHandle = itembarangGV.FocusedRowHandle;
                        this.itembarangGV.SelectRow(this.itembarangGV.FocusedRowHandle);
                        this.itembarangGV.Focus();
                        this.itembarangGC.Focus();
                        return;
                    }



                };


                
                this.Aptbarangmasukdetails = new List<aptbarangmasukdetail>();

                for (int i = 0; i < itembarangGV.DataRowCount; i++)
                {

                    //this.v_Apttemppembelian = new v_apttemppembelian()
                    //{
                    //    aptbarangid = -1, kodebarangpbf,isisatuankecil,satuankecilkode,jmlsatuanbesar,satuanbesarkode,tglkadaluarsa,hargapersatuanbesar
                    //};
                    itembarangGV.FocusedRowHandle = i;
                    this.Aptbarangmasukdetail = new aptbarangmasukdetail
                    {
                        aptbarangmasukdetailid = -1,
                        aptbarangmasukid = -1,
                        aptbarangsatuanid = short.Parse(itembarangGV.GetFocusedRowCellValue("aptbarangsatuanid").ToString()),
                        kodebarangpbf = (itembarangGV.GetFocusedRowCellValue("kodebarangpbf") != null)? itembarangGV.GetFocusedRowCellValue("kodebarangpbf").ToString() : string.Empty,
                        tglkadaluarsa = (((DateTime)itembarangGV.GetFocusedRowCellValue("tglkadaluarsa")) != null) ?  ((DateTime)itembarangGV.GetFocusedRowCellValue("tglkadaluarsa")).Date : DateTime.Now.Date.AddMonths(3),
                        nobatch = (itembarangGV.GetFocusedRowCellValue("nobatch") !=null) ? itembarangGV.GetFocusedRowCellValue("nobatch").ToString() : string.Empty,
                        aptsatuankode = (itembarangGV.GetFocusedRowCellValue("aptsatuankode").ToString()),
                        qty = short.Parse(itembarangGV.GetFocusedRowCellValue("qty").ToString()),
                        hargasatuan = decimal.Parse(itembarangGV.GetFocusedRowCellValue("hargasatuan").ToString()),
                        potonganpersen = double.Parse(itembarangGV.GetFocusedRowCellValue("potonganpersen").ToString()),
                        hargasatuanpot = decimal.Parse(itembarangGV.GetFocusedRowCellValue("hargasatuan").ToString()) -
                            (
                                (decimal.Parse(itembarangGV.GetFocusedRowCellValue("potonganpersen").ToString()) / (decimal)100)
                                *
                                decimal.Parse(itembarangGV.GetFocusedRowCellValue("hargasatuan").ToString())
                            ),
                        jmlharga = decimal.Parse(itembarangGV.GetFocusedRowCellValue("jmlharga").ToString()),
                        stskb = itembarangGV.GetFocusedRowCellValue("stskb").ToString(),
                        aptstsbrgmasukdetailid = short.Parse( itembarangGV.GetFocusedRowCellValue("aptstsbrgmasukdetailid").ToString()),
                    };
                    this.Aptbarangmasukdetails.Add(this.Aptbarangmasukdetail);

                    //if (itembarangGV.GetRowCellValue(i, "FieldName") == value)
                    //    do something
                };
                 
                if (this.dppTxt.Text==string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "DPP tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.dppTxt.Focus();
                    return;
                }
                if (this.jmlTagihanTxt.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Jumlah tagihan tidak boleh kosong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.jmlTagihanTxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.ppnTxt.Text))
                {
                    this.ppnTxt.Text = "0";
                }
                if (string.IsNullOrEmpty(this.biayakirimTxt.Text))
                {
                    this.biayakirimTxt.Text = "0";
                }
                if (string.IsNullOrEmpty(this.biayaMateraiTxt.Text))
                {
                    this.biayaMateraiTxt.Text = "0";
                }


                //var DPP = (this.Aptbarangmasukdetails.Sum<aptbarangmasukdetail>(p => p.hargapersatuanbesar).Value) -  decimal.Parse( potnominalTxt.Text) ;

                //dppTxt.Text = DPP.ToString("#,#");

                //var biayatambahan = decimal.Parse(this.ppnTxt.Text) + decimal.Parse(this.biayakirimTxt.Text) + decimal.Parse(this.biayaMateraiTxt.Text);

                //jmlTagihanTxt.Text = (decimal.Parse(this.dppTxt.Text) + biayatambahan).ToString("#,#");

                this.Aptbarangmasuk = new aptbarangmasuk
                {
                    aptbarangmasukid = -1,
                    nobeli = this.nofakturTxt.Text,
                    aptpbfid = byte.Parse(this.pbfLookUpEdit.EditValue.ToString()),
                    tglmasuk = ((DateTime)this.tglbeliDateEdit.EditValue).Date,
                    tahun = ((DateTime)this.tglbeliDateEdit.EditValue).Date.Year.ToString(),
                    bulan = ((DateTime)this.tglbeliDateEdit.EditValue).Date.Month.ToString("0#"),
                    jammasuk = ((DateTime)this.tglbeliDateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Date.Hour, DateTime.Now.Date.Minute, DateTime.Now.Date.Second)),
                    dpp = decimal.Parse(this.dppTxt.Text),
                    ppn = decimal.Parse(this.ppnTxt.Text),
                    biayakirim = decimal.Parse(this.biayakirimTxt.Text),
                    materai = decimal.Parse(this.biayaMateraiTxt.Text),
                    total = decimal.Parse(this.jmlTagihanTxt.Text),
                    nppn = short.Parse(this.ppnpersenTxt.Text)
                    
                };

                var result = SaveAptbarangmasuk(this.Aptbarangmasuk,this.Aptbarangmasukdetails);
                if (string.IsNullOrEmpty(result))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pembelian sukses disimpan !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                    

                    //this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, result, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.DialogResult = DialogResult.Cancel;
                }






            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.InnerException.Message +"\n"+this.Name+ "\nbSimpan_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBatal_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbBatal_Clickk()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             itembarangGV.DeleteRow(itembarangGV.FocusedRowHandle);
        }

        protected override void itembarangGV_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //"coltglkadaluarsa"
            //view.SetRowCellValue(e.RowHandle, view.Columns["tglkadaluarsa"], DateTime.Now.Date);
        }

        protected override void itembarangGV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //object hargasatuan = null; object jmlsatuan = null;

                //this.itembarangGV.RefreshData();

                if (e.Column.FieldName == "aptbarangsatuanid")
                {
                    var aptbarangsatuanid = itembarangGV.GetRowCellValue(e.RowHandle, e.Column);
                    if (aptbarangsatuanid != null)
                    {
                        //LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short.Parse( aptbarangsatuanid.ToString()));
                        
                        var defenisiSatuan = this.barangrepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(e.Value);
                        itembarangGV.SetRowCellValue(e.RowHandle, "aptbarangnm", (defenisiSatuan as v_aptbarangsatuan_pbf).aptbarangnm);
                        itembarangGV.SetRowCellValue(e.RowHandle, "defenisisatuan", (defenisiSatuan as v_aptbarangsatuan_pbf).defenisisatuan);
                        itembarangGV.SetRowCellValue(e.RowHandle, "satuanbesarkode", (defenisiSatuan as v_aptbarangsatuan_pbf).satuanbesarkode);
                        itembarangGV.SetRowCellValue(e.RowHandle, "satuankecilkode", (defenisiSatuan as v_aptbarangsatuan_pbf).satuankecilkode);
                        itembarangGV.SetRowCellValue(e.RowHandle, "stskb", string.Empty);
                    }

                }

                if (e.Column.FieldName == "aptsatuankode")
                {
                    var aptsatuankode = this.satuanrepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(e.Value);
                    if (aptsatuankode != null)
                    {
                        if (!string.IsNullOrEmpty(aptsatuankode.ToString()))
                        {
                            var satuanbesarkode = (itembarangGV.GetRowCellValue(e.RowHandle, "satuanbesarkode") != null) ?
                                    itembarangGV.GetRowCellValue(e.RowHandle, "satuanbesarkode").ToString() : string.Empty;
                            var satuankecilkode = (itembarangGV.GetRowCellValue(e.RowHandle, "satuankecilkode") != null) ?
                                    itembarangGV.GetRowCellValue(e.RowHandle, "satuankecilkode").ToString() : string.Empty;

                            var listsatuan = new List<string> { satuanbesarkode.Trim().ToLower(), satuankecilkode.Trim().ToLower() };

                            var isexist = listsatuan.Exists(p => p.Contains((aptsatuankode as aptsatuan).aptsatuankode.Trim().ToLower()));
                            if (isexist == true)
                            {
                                if (satuanbesarkode.Trim().ToLower()== (aptsatuankode as aptsatuan).aptsatuankode.Trim().ToLower())
                                {
                                    itembarangGV.SetRowCellValue(e.RowHandle, "stskb", "B");
                                }    
                                else
                                {
                                    itembarangGV.SetRowCellValue(e.RowHandle, "stskb", "K");
                                }
                            }
                            else
                            {
                                CustomMessageBox.MessageError("Satuan tidak valid,\nSatuan yang diinputkan tidak sesuai dengan defenisi satuan!!!", this);
                                itembarangGV.SetRowCellValue(e.RowHandle, "aptsatuankode", null);
                                //this.satuanrepositoryItemLookUpEdit.NullText = "";
                                return;
                            }
                        }
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "Error Satuan !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //itembarangGV.SetRowCellValue(e.RowHandle, "aptbarangsatuantriggerid", (apttrigger as aptbarangsatuantrigger ).aptbarangsatuantriggerid);
                    //itembarangGV.SetRowCellValue(e.RowHandle, "qty", (apttrigger as aptbarangsatuantrigger).qty);
                }


                if (e.Column.FieldName == "qty")
                {

                    var qty = (itembarangGV.GetRowCellValue(e.RowHandle, "qty") != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "qty").ToString()) : (decimal)0;
                    var hargasatuan = (itembarangGV.GetRowCellValue(e.RowHandle, "hargasatuan") != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "hargasatuan").ToString()) : (decimal)0;
                    var potpersen = (itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen") != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen").ToString()) : (decimal)0;
                    var potnominal =  ((potpersen * hargasatuan)) / (decimal)100;

                    var jmlharga = qty * (hargasatuan - potnominal);
                    itembarangGV.SetRowCellValue(e.RowHandle, "jmlharga", jmlharga);
                    //}
                }
                

                if (e.Column.FieldName == "hargasatuan")
                {
                    var qty = (itembarangGV.GetRowCellValue(e.RowHandle, "qty") != null) ?
                           decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "qty").ToString()) : (decimal)0;
                    var hargasatuan = (itembarangGV.GetRowCellValue(e.RowHandle,e.Column) !=null)?
                            decimal.Parse( itembarangGV.GetRowCellValue(e.RowHandle, e.Column).ToString()): (decimal)0  ;
                    var potpersen = (itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen")!=null)? 
                            decimal.Parse( itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen").ToString()) : (decimal)0  ; 
                    var potnominal = (potpersen * hargasatuan)/(decimal)100;

                    var jmlharga = qty * (hargasatuan - potnominal);
                    itembarangGV.SetRowCellValue(e.RowHandle, "jmlharga", jmlharga);
                    
                }

                if (e.Column.FieldName == "potonganpersen")
                {
                    var qty = (itembarangGV.GetRowCellValue(e.RowHandle, "qty") != null) ?
                           decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "qty").ToString()) : (decimal)0;
                    var hargasatuan = (itembarangGV.GetRowCellValue(e.RowHandle, "hargasatuan") != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "hargasatuan").ToString()) : (decimal)0;
                    var potpersen = (itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen") != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen").ToString()) : (decimal)0;

                    var potnominal = (potpersen * hargasatuan)/(decimal)100;
                    var jmlharga = qty * (hargasatuan - potnominal);
                    var jmlhargatotal = jmlharga + (jmlharga * (decimal.Parse(this.ppnpersenTxt.Text) / (decimal)100));

                    itembarangGV.SetRowCellValue(e.RowHandle, "jmlharga", jmlharga);

                    
                    //}
                }

                
                if (e.Column.FieldName == "jmlharga")
                {
                   
                    /*

                    //if (!string.IsNullOrEmpty(this.potnominalTxt.Text))
                    //{
                    this.itembarangGV.RefreshData();
                    //var data = this.itembarangGV.Columns["jmlharga"].SummaryText.Split('=');

                    var data = this.itembarangGV.Columns["jmlharga"].SummaryText;

                    //var data = e.Value;

                    if (data != null)
                    {


                        //var jumlah = decimal.Parse(data[1].ToString());
                        var jumlah = decimal.Parse(data.ToString());

                        if (jumlah == 0) jumlah = (e.Value != null) ? decimal.Parse( e.Value.ToString()) : 0;

                        this.dppTxt.Text = (jumlah).ToString("#,#.00");

                        //var biayaKirim = (!string.IsNullOrEmpty(this.biayakirimTxt.Text)) ? decimal.Parse(this.biayakirimTxt.Text) : (decimal)0;
                        //var biayaMaterai = (!string.IsNullOrEmpty(this.biayaMateraiTxt.Text)) ? decimal.Parse(this.biayaMateraiTxt.Text) : (decimal)0;

                        var biayaKirim = 0;
                        var biayaMaterai = 0;

                        var ppn = (!string.IsNullOrEmpty(this.ppnTxt.Text)) ? decimal.Parse(this.ppnTxt.Text) : (decimal)0;
                        var dpp = (!string.IsNullOrEmpty(this.dppTxt.Text)) ? decimal.Parse(this.dppTxt.Text) : (decimal)0;

                        this.jmlTagihanTxt.Text = (dpp + ppn + biayaKirim + biayaMaterai).ToString("#,#.00");

                    }
                    else
                    {
                        this.dppTxt.Text = "0";// string.Empty;

                    }
                    //}

                    */

                }

                //hitung total

                if (e.Column.FieldName == "jmlharga")
                {
                    decimal total = 0;
                    this.itembarangGV.RefreshData();

                    if (itembarangGV.DataRowCount == 0)
                    {
                        var jmlharga = (itembarangGV.GetRowCellValue(e.RowHandle,"jmlharga") != null) ? itembarangGV.GetRowCellValue(e.RowHandle, "jmlharga").ToString() : string.Empty;
                        total = decimal.Parse(jmlharga);
                        this.dppTxt.Text = (total != 0) ? (total).ToString("#,#.00") : "0" ;
                        var biayaKirim = 0;
                        var biayaMaterai = 0;

                        var ppn = (!string.IsNullOrEmpty(this.ppnTxt.Text)) ? decimal.Parse(this.ppnTxt.Text) : (decimal)0;
                        var dpp = (!string.IsNullOrEmpty(this.dppTxt.Text)) ? decimal.Parse(this.dppTxt.Text) : (decimal)0;

                        this.jmlTagihanTxt.Text = (dpp + ppn + biayaKirim + biayaMaterai) != 0 ? (dpp + ppn + biayaKirim + biayaMaterai).ToString("#,#.00") : "0";
                    }
                    else
                    {
                        for (int i = 0; i < itembarangGV.DataRowCount; i++)
                        {
                            itembarangGV.FocusedRowHandle = i;

                            var jmlharga = (itembarangGV.GetFocusedRowCellValue("jmlharga") != null) ? itembarangGV.GetFocusedRowCellValue("jmlharga").ToString() : string.Empty;

                            if (!string.IsNullOrEmpty(jmlharga))
                            {

                                total += decimal.Parse(jmlharga);

                                this.dppTxt.Text = (total != 0) ? (total).ToString("#,#.00") : "0";

                                //var biayaKirim = (!string.IsNullOrEmpty(this.biayakirimTxt.Text)) ? decimal.Parse(this.biayakirimTxt.Text) : (decimal)0;
                                //var biayaMaterai = (!string.IsNullOrEmpty(this.biayaMateraiTxt.Text)) ? decimal.Parse(this.biayaMateraiTxt.Text) : (decimal)0;

                                var biayaKirim = 0;
                                var biayaMaterai = 0;

                                var ppn = (!string.IsNullOrEmpty(this.ppnTxt.Text)) ? decimal.Parse(this.ppnTxt.Text) : (decimal)0;
                                var dpp = (!string.IsNullOrEmpty(this.dppTxt.Text)) ? decimal.Parse(this.dppTxt.Text) : (decimal)0;

                                this.jmlTagihanTxt.Text = (dpp + ppn + biayaKirim + biayaMaterai) != 0 ? (dpp + ppn + biayaKirim + biayaMaterai).ToString("#,#.00") : "0";
                            }

                            //if (itembarangGV.GetRowCellValue(i, "FieldName") == value)
                            //    do something
                        };
                    }
                }

            }
            catch (Exception ex)
            {
                //itembarangGV.SetRowCellValue(e.RowHandle, e.Column, string.Empty);
                CustomMessageBox.MessageError(ex.InnerException.Message, "itembarangGV_CellValueChanged()", this.Name, this);
            }
        }

        protected override void ItembarangGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                int stsbrgmasukid = Convert.ToInt32(this.itembarangGV.GetRowCellValue(e.RowHandle, "aptstsbrgmasukdetailid"));

                if (stsbrgmasukid == 0) return;

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
                CustomMessageBox.MessageError(ex.InnerException.Message, "ItembarangGV_RowStyle()", this.Name, this);
            }
        }

        protected override void ItembarangGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                /*
                int isstock = Convert.ToInt32(this.itembarangGV.GetRowCellValue(e.RowHandle, "isstock"));
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
                        e.Appearance.BackColor = Helper.CustomColor.IsBarangInGudang();
                        e.Appearance.ForeColor = Helper.CustomColor.IsBarangInGudang();
                        e.Column.ToolTip = "Sudah masuk gudang";
                    }
                }
                */
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageError(ex.InnerException.Message, "VaptpembelianGV_CustomDrawCell()", this.Name, this);
            }
        }



    }
}
