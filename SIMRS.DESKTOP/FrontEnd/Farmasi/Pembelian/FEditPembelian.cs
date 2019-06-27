using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SIMRS.DESKTOP.Helper;
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
    public class FEditPembelian : FAddPembelian
    {
        protected Dictionary<int, string> Parampembelian = null;

        IList<v_aptpembeliandetail> v_Aptpembeliandetails = null;
        //IList<v_aptpembeliandetail> v_AptpembeliandetailOrys = null;

        #region private methode


        protected void LoadAptbarangsatuantriggerAsync()
        {
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    var result = Task.Run(() => service.SelectAllAptbarangsatuantriggerAsync());
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        this.satuanrepositoryItemLookUpEdit.DataSource = null;

                        this.satuanrepositoryItemLookUpEdit.BeginUpdate();
                        this.satuanrepositoryItemLookUpEdit.Columns.Clear();


                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptbarangsatuantriggerid", Caption = "aptbarangsatuantriggerid", Visible = false });
                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "aptsatuankode", Caption = "SATUAN", Visible = true });
                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "qty", Caption = "QTY", Visible = true });
                        this.satuanrepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo { FieldName = "stskb", Caption = "stskb", Visible = false });

                        this.satuanrepositoryItemLookUpEdit.EndUpdate();

                        this.satuanrepositoryItemLookUpEdit.DataSource = null;
                        this.satuanrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

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

        protected void LoadAptbarangsatuantrigger()
        {
            try
            {
                using (var service = new AptbarangsatuanServices())
                {
                    var result = service.SelectAllAptbarangsatuantrigger();
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        this.satuanrepositoryItemLookUpEdit.DataSource = null;

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

        protected void LoadAptbarangmasukdetail(short aptbarangmasukid)
        {
            try
            {
                using (var service = new AptbarangmasukdetailServices())
                {
                    var result = Task.Run(() => service.SelectAll_v_aptpembeliandetailByAptbarangmasukIdAsync(aptbarangmasukid));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.v_Aptpembeliandetails = result.Result.Item1.ToList();
                        

                        this.itembarangGC.DataSource = this.v_Aptpembeliandetails;
                        //this.v_Aptpembeliandetails = (IList<v_aptpembeliandetail>)this.itembarangGC.DataSource;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DeleteAptbarangmasukdetail(aptbarangmasukdetail Aptbarangmasukdetail)
        {
            string Errresult = string.Empty;

            try
            {
                using (var service = new AptbarangmasukServices())
                {
                    Errresult = service.DeleteBarangmasukDetail(Aptbarangmasukdetail); 
                }

            }
            catch (Exception ex)
            {
                Errresult = ex.Message;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nDeleteAptbarangmasukdetail()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Errresult;
        }

        #endregion private methode

        public FEditPembelian(ref Panel pnlContent) : base(ref pnlContent)
        {

        }
        public FEditPembelian(ref Panel pnlContent, ref aptbarangmasuk Aptbarangmasuk, Dictionary<int, string> Parampembelian) : base(ref pnlContent)
        {
            try
            {
                this.lblHeader.Text = "List Pembelian->Edit Pembelian";
                this.Aptbarangmasuk = Aptbarangmasuk;
                this.Parampembelian = Parampembelian;

                this.dppTxt.ReadOnly = true;
                this.jmlTagihanTxt.ReadOnly = true;

                
                //this.colaptbarangnm.OptionsColumn.AllowEdit = false;
                 //this.colaptbarangnm.ColumnEdit = null;
                 //this.colaptbarangnm.FieldName = "aptbarangsatuanid";
                
                this.bAddRow.Visible = true;
                //this.colsatuan.FieldName = "aptbarangsatuantriggerid";

                //LoadAptbarangsatuantrigger();

                

                if (Aptbarangmasuk != null)
                {
                    this.tglbeliDateEdit.EditValue = this.Aptbarangmasuk.tglmasuk;
                    this.pbfLookUpEdit.EditValue = this.Aptbarangmasuk.aptpbfid;
                    this.nofakturTxt.Text = this.Aptbarangmasuk.nobeli;
                    //this.potpersenTxt.Text = this.Aptbarangmasuk.potonganpersen.Value.ToString("#,#");
                    //this.potnominalTxt.Text = this.Aptbarangmasuk.potongannominal.Value.ToString("#,#");
                    this.dppTxt.Text = this.Aptbarangmasuk.dpp.Value.ToString("#,#");
                    this.ppnTxt.Text = this.Aptbarangmasuk.ppn.Value.ToString("#,#");
                    this.biayakirimTxt.Text = this.Aptbarangmasuk.biayakirim.Value.ToString("#,#");
                    this.biayaMateraiTxt.Text = this.Aptbarangmasuk.materai.Value.ToString("#,#");
                    this.jmlTagihanTxt.Text = this.Aptbarangmasuk.total.Value.ToString("#,#");




                    if (string.IsNullOrEmpty(this.dppTxt.Text)) this.dppTxt.Text = "0";
                    if (string.IsNullOrEmpty(this.ppnTxt.Text)) this.ppnTxt.Text = "0";
                    if (string.IsNullOrEmpty(this.biayakirimTxt.Text)) this.biayakirimTxt.Text = "0";
                    if (string.IsNullOrEmpty(this.biayaMateraiTxt.Text)) this.biayaMateraiTxt.Text = "0";
                    if (string.IsNullOrEmpty(this.jmlTagihanTxt.Text)) this.jmlTagihanTxt.Text = "0";


                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFEditPembelian(aptbarangmasuk Aptbarangmasuk)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        protected override void pbfLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.pbfLookUpEdit.EditValue != null)
                {
                    
                    Loadv_barangsatuanBypbfAsync(short.Parse(this.pbfLookUpEdit.EditValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\npbfLookUpEdit_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bAddRow_Click(object sender, EventArgs e)
        {
            //this.itembarangGV.AddNewRow();
            try
            {

                this.v_Aptpembeliandetails.Add(new v_aptpembeliandetail { aptbarangmasukdetailid = -1 });
                this.itembarangGC.DataSource = null;
                this.itembarangGC.DataSource = this.v_Aptpembeliandetails;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbAddRow_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void itembarangGV_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                /*

                if (e.Column != this.colaptbarangnm)
                {
                    return;
                }

                string str = (string)itembarangGV.GetRowCellValue(e.RowHandle, this.colaptbarangnm);
                //e.RepositoryItem = this.barangrepositoryItemLookUpEdit;  //str == "Row 0" ? row0Repository : row1Repository;
                itembarangGV.SetRowCellValue(e.RowHandle, e.Column, str);
                itembarangGV.SetRowCellValue(e.RowHandle, this.colaptbarangsatuanid, e.RepositoryItem);
                */
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nitembarangGV_CustomRowCellEditForEditing()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void itembarangGV_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column != this.colaptbarangnm)
            {
                return;
            }
            string str = (string)itembarangGV.GetRowCellValue(e.ListSourceRowIndex, this.colaptbarangnm);
            e.DisplayText = str;

        }

        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            

            //var data  = this.itembarangGV.Columns[9].SummaryText.Split('=');
            try
            {

                if (itembarangGV.FocusedRowHandle < 0) return;

                if (MetroFramework.MetroMessageBox.Show(this, string.Format("Apakah item ini {0} - {1}", (itembarangGV.GetFocusedRow() as v_aptpembeliandetail).aptbarangnm,
                    (itembarangGV.GetFocusedRow() as v_aptpembeliandetail).tglkadaluarsa.Value.ToString("dd-MM-yyyy")), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    var errResult =  DeleteAptbarangmasukdetail(new aptbarangmasukdetail { aptbarangmasukdetailid = (itembarangGV.GetFocusedRow() as v_aptpembeliandetail).aptbarangmasukdetailid });
                    if (string.IsNullOrEmpty(errResult))
                    {

                        itembarangGV.DeleteRow(itembarangGV.FocusedRowHandle);


                            var data = this.itembarangGV.Columns["jmlharga"].SummaryText;
                            if (data != null)
                            {
                                var jumlah = decimal.Parse(data.ToString());
                                
                                this.dppTxt.Text = (jumlah).ToString("#,#,00");

                                var ppn = ((!string.IsNullOrEmpty(this.ppnTxt.Text)) ? decimal.Parse(this.ppnTxt.Text) : (decimal)0);
                                var biayaKirim = (!string.IsNullOrEmpty(this.biayakirimTxt.Text)) ? decimal.Parse(this.biayakirimTxt.Text) : (decimal)0;
                                var biayaMaterai = (!string.IsNullOrEmpty(this.biayaMateraiTxt.Text)) ? decimal.Parse(this.biayaMateraiTxt.Text) : (decimal)0;

                                this.jmlTagihanTxt.Text = (decimal.Parse(this.dppTxt.Text) + ppn+  biayaKirim + biayaMaterai).ToString("#,#.00");

                            }
                            else
                            {
                                this.dppTxt.Text = "0";

                            }
                        
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, errResult + "\n" + this.Name + "\ndeleterepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name+ "\ndeleterepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //this.colaptbarangnm.OptionsColumn.AllowEdit = true;
                //this.colaptbarangnm.ColumnEdit = this.barangrepositoryItemLookUpEdit;
                //this.itembarangGC.Refresh();

            }
            catch (Exception ex)
            {
                this.colaptbarangnm.OptionsColumn.AllowEdit = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\neditrepositoryItemButtonEdit_ButtonClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected override void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tglbeliDateEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal pembelian!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tglbeliDateEdit.Focus();
                    return;
                }
                if (this.pbfLookUpEdit.EditValue == null)
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
                    if (aptsatuangrid==string.Empty)
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

                    var parseqty = int.Parse (itembarangGV.GetFocusedRowCellDisplayText(this.colqty));
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
                    //if (itembarangGV.GetRowCellValue(i, "FieldName") == value)
                    //    do something
                };


                this.Aptbarangmasukdetails = new List<aptbarangmasukdetail>();

                for (int i = 0; i < itembarangGV.DataRowCount; i++)
                {

                    //this.v_Apttemppembelian = new v_apttemppembelian()
                    //{
                    //    aptbarangid = -1, kodebarangpbf,isisatuankecil,satuankecilkode,jmlsatuanbesar,satuanbesarkode,tglkadaluarsa,hargapersatuanbesar
                    //};
                    itembarangGV.FocusedRowHandle = i;
                    ////this.Aptbarangmasukdetail = new aptbarangmasukdetail
                    ////{
                    ////    aptbarangmasukdetailid = short.Parse(itembarangGV.GetFocusedRowCellValue("aptbarangmasukdetailid").ToString()),
                    ////    kodebarangpbf = itembarangGV.GetFocusedRowCellValue("kodebarangpbf").ToString(),
                    ////    tglkadaluarsa = ((DateTime)itembarangGV.GetFocusedRowCellValue("tglkadaluarsa")).Date,
                    ////    jmlharga = decimal.Parse(itembarangGV.GetFocusedRowCellValue("jmlharga").ToString()),

                    ////};


                    this.Aptbarangmasukdetail = new aptbarangmasukdetail
                    {
                        aptbarangmasukdetailid = short.Parse(itembarangGV.GetFocusedRowCellValue("aptbarangmasukdetailid").ToString()),
                        aptbarangmasukid = short.Parse(itembarangGV.GetFocusedRowCellValue("aptbarangmasukid").ToString()),
                        aptbarangsatuanid = short.Parse(itembarangGV.GetFocusedRowCellValue("aptbarangsatuanid").ToString()),
                        kodebarangpbf = (itembarangGV.GetFocusedRowCellValue("kodebarangpbf") != null) ? itembarangGV.GetFocusedRowCellValue("kodebarangpbf").ToString() : string.Empty,
                        tglkadaluarsa = (((DateTime)itembarangGV.GetFocusedRowCellValue("tglkadaluarsa")) != null)? ((DateTime)itembarangGV.GetFocusedRowCellValue("tglkadaluarsa")).Date : DateTime.Now.Date.AddMonths(3),
                        nobatch = (itembarangGV.GetFocusedRowCellValue("nobatch") != null)? itembarangGV.GetFocusedRowCellValue("nobatch").ToString() : string.Empty,
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
                        aptstsbrgmasukdetailid = short.Parse(itembarangGV.GetFocusedRowCellValue("aptstsbrgmasukdetailid").ToString())

                    };

                    this.Aptbarangmasukdetails.Add(this.Aptbarangmasukdetail);

                    //if (itembarangGV.GetRowCellValue(i, "FieldName") == value)
                    //    do something
                };

                if (this.dppTxt.Text == string.Empty)
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


                //var DPP = (this.Aptbarangmasukdetails.Sum<aptbarangmasukdetail>(p => p.hargapersatuanbesar).Value) - decimal.Parse(potnominalTxt.Text);

                //dppTxt.Text = DPP.ToString("#,#");

                var biayatambahan = decimal.Parse(this.ppnTxt.Text) + decimal.Parse(this.biayakirimTxt.Text) + decimal.Parse(this.biayaMateraiTxt.Text);

                jmlTagihanTxt.Text = (decimal.Parse( this.dppTxt.Text)  + biayatambahan).ToString("#,#");

                this.Aptbarangmasuk = new aptbarangmasuk
                {
                    aptbarangmasukid = this.Aptbarangmasuk.aptbarangmasukid,
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

                var result = SaveAptbarangmasuk(this.Aptbarangmasuk, this.Aptbarangmasukdetails);
                if (string.IsNullOrEmpty(result))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pembelian sukses disimpan !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.DialogResult = DialogResult.OK;

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
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, result, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.DialogResult = DialogResult.Cancel;
                }






            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbSimpan_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBatal_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListBarangMasuk2 myForm = new FListBarangMasuk2(ref this.pnlContent, this.Parampembelian);
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

        protected override void itembarangGV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            try
            {
                //object hargasatuan = null; object jmlsatuan = null;
                

                if ((e.Column.Name =="colaptbarangsatuanid") || (e.Column.Name == "colaptbarangsatuanid2"))
                {
                    var aptbarangsatuanid = itembarangGV.GetRowCellValue(e.RowHandle, e.Column);
                    if (aptbarangsatuanid != null)
                    {
                        //LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short.Parse( aptbarangsatuanid.ToString()));
                        

                        var defenisiSatuan = this.barangrepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(e.Value);
                        if (e.Column.Name != "colaptbarangsatuanid2")
                        {
                            itembarangGV.SetRowCellValue(e.RowHandle, this.colaptbarangsatuanid2, aptbarangsatuanid);
                        }
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
                                if (satuanbesarkode.Trim().ToLower() == (aptsatuankode as aptsatuan).aptsatuankode.Trim().ToLower())
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
                                return;
                            }
                        }
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "Erro Satuan obat !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var potnominal = ((potpersen * hargasatuan)) / (decimal)100;

                    var jmlharga = qty * (hargasatuan - potnominal);
                    itembarangGV.SetRowCellValue(e.RowHandle, "jmlharga", jmlharga);
                    //}
                }


                if (e.Column.FieldName == "hargasatuan")
                {
                    var qty = (itembarangGV.GetRowCellValue(e.RowHandle, "qty") != null) ?
                           decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "qty").ToString()) : (decimal)0;
                    var hargasatuan = (itembarangGV.GetRowCellValue(e.RowHandle, e.Column) != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, e.Column).ToString()) : (decimal)0;
                    var potpersen = (itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen") != null) ?
                            decimal.Parse(itembarangGV.GetRowCellValue(e.RowHandle, "potonganpersen").ToString()) : (decimal)0;
                    var potnominal = (potpersen * hargasatuan) / (decimal)100;

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

                    var potnominal = (potpersen * hargasatuan) / (decimal)100;
                    var jmlharga = qty * (hargasatuan - potnominal);
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

                        if (jumlah == 0) jumlah = (e.Value != null) ? decimal.Parse(e.Value.ToString()) : 0;

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

                if (e.Column.FieldName == "jmlharga")
                {
                    decimal total = 0;
                    this.itembarangGV.RefreshData();

                    if (itembarangGV.DataRowCount == 0)
                    {
                        var jmlharga = (itembarangGV.GetRowCellValue(e.RowHandle, "jmlharga") != null) ? itembarangGV.GetRowCellValue(e.RowHandle, "jmlharga").ToString() : string.Empty;
                        total = decimal.Parse(jmlharga);
                        this.dppTxt.Text = (total != 0) ? (total).ToString("#,#.00") : "0";
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
                CustomMessageBox.MessageError(ex.InnerException.Message, "itembarangGV_CellValueChanged()", this.Name, this);
            }

               
        }

        protected override void itembarangGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                ////var data = this.itembarangGV.GetFocusedRow() as v_aptpembeliandetail;
                //var data = this.itembarangGV.GetFocusedRowCellValue(this.colaptbarangsatuanid);
                //if (data != null)
                //{
                //    LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short.Parse(data.ToString()));

                   
                    
                //    var d = this.itembarangGV.GetRowCellValue(e.FocusedRowHandle, this.colsatuan);
                //}
                //itembarangGV.FocusedRowHandle = -1;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nitembarangGV_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bBack_Click(object sender, EventArgs e)
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbBack_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //protected override void itembarangGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        //if (e. .Column == this.colsatuan)
        //        //{

        //            var data = this.itembarangGV.GetFocusedRowCellValue(this.colaptbarangsatuanid);
        //            if (data != null)
        //            {
        //                LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short.Parse(data.ToString()));
        //            }
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nitembarangGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //protected override void itembarangGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    try
        //    {
        //        //if (e.Column == this.colsatuan)
        //        //{

        //           var data = this.itembarangGV.GetFocusedRowCellValue(this.colaptbarangsatuanid);
        //            if (data != null)
        //            {
        //                LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short.Parse(data.ToString()));
        //            }
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nitembarangGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //protected override void itembarangGV_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        //{
        //    try
        //    {
        //        //if (e.FocusedColumn.Name == this.colsatuan.Name)
        //        //{
        //        //    var data = this.itembarangGV.GetFocusedRowCellValue(this.colaptbarangsatuanid);
        //        //    if (data != null)
        //        //    {
        //        //        LoadAptbarangsatuantriggerByAptbarangsatuanidAsync(short.Parse(data.ToString()));
        //        //    }
        //        //}

        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nitembarangGV_RowCellClick()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}





    }
}
