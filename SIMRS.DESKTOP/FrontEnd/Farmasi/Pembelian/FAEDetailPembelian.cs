using SIMRS.Model;
using SIMRS.Services.FrontEnd.Farmasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Farmasi.Pembelian
{
    public class FAEDetailPembelian : FEditPembelian
    {
        //private aptbarangmasuk Aptbarangmasuk;


        #region private methode


        
        /*
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
                        this.barangrepositoryItemLookUpEdit.NullValuePrompt = "Pilih nama barang";
                        this.barangrepositoryItemLookUpEdit.ShowFooter = false;

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


        protected void LoadAptSatuanAsync()
        {
            try
            {
                using (var service = new AptsatuanServices())
                {
                    var result = Task.Run(() => service.SelectAllAptsatuanAsync(string.Empty));
                    if (result.Result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.skecilrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

                        this.skecilrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.skecilrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.skecilrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.skecilrepositoryItemLookUpEdit.NullValuePrompt = "Satuan kecil ...";
                        this.skecilrepositoryItemLookUpEdit.ShowFooter = false;

                        this.skecilrepositoryItemLookUpEdit.DisplayMember = "aptsatuankode";
                        this.skecilrepositoryItemLookUpEdit.ValueMember = "aptsatuankode";
                        this.skecilrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.skecilrepositoryItemLookUpEdit.NullText = string.Empty;



                        this.sbesarrepositoryItemLookUpEdit.DataSource = result.Result.Item1;

                        this.sbesarrepositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                        this.sbesarrepositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                        this.sbesarrepositoryItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                        this.sbesarrepositoryItemLookUpEdit.NullValuePrompt = "Satuan besar ...";
                        this.sbesarrepositoryItemLookUpEdit.ShowFooter = false;

                        this.sbesarrepositoryItemLookUpEdit.DisplayMember = "aptsatuankode";
                        this.sbesarrepositoryItemLookUpEdit.ValueMember = "aptsatuankode";
                        this.sbesarrepositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                        this.sbesarrepositoryItemLookUpEdit.NullText = string.Empty;
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
        */

        private void defaultControl()
        {
            this.colaptbarangid.OptionsColumn.AllowEdit = false;
            this.colaptbarangnm.OptionsColumn.AllowEdit = false;
            //this.colsatuankecilkode.OptionsColumn.AllowEdit = false;
            //this.colsatuanbesarkode.OptionsColumn.AllowEdit = false;
            this.coltglkadaluarsa.OptionsColumn.AllowEdit = false;

            this.coldelete.Visible = false;

            this.colaptbarangnm.FieldName = "aptbarangid";

            this.tglbeliDateEdit.ReadOnly = true;
            this.pbfLookUpEdit.ReadOnly = true;

            this.bSimpan.Enabled = false;
        }
        

        #endregion
        public FAEDetailPembelian(ref Panel pnlContent) : base(ref pnlContent)
        {

        }
        public FAEDetailPembelian(ref Panel pnlContent, aptbarangmasuk Aptbarangmasuk, Dictionary<int, string> Parampembelian) :base(ref pnlContent, ref Aptbarangmasuk, Parampembelian)
        {
            this.Text = "Detail Pembelian";
            ////this.Aptbarangmasuk = Aptbarangmasuk;

            defaultControl();

            ////if (Aptbarangmasuk!=null)
            ////{
            ////    this.tglbeliDateEdit.EditValue = this.Aptbarangmasuk.tglmasuk;
            ////    this.pbfLookUpEdit.EditValue = this.Aptbarangmasuk.aptpbfid;
            ////    this.nofakturTxt.Text = this.Aptbarangmasuk.nobeli;
            ////    this.potpersenTxt.Text = this.Aptbarangmasuk.potonganpersen.Value.ToString("#,#");
            ////    this.potnominalTxt.Text = this.Aptbarangmasuk.potongannominal.Value.ToString("#,#");
            ////    this.dppTxt.Text = this.Aptbarangmasuk.dpp.Value.ToString("#,#");
            ////    this.ppnTxt.Text = this.Aptbarangmasuk.ppn.Value.ToString("#,#");
            ////    this.biayakirimTxt.Text = this.Aptbarangmasuk.biayakirim.Value.ToString("#,#");
            ////    this.biayaMateraiTxt.Text = this.Aptbarangmasuk.materai.Value.ToString("#,#");
            ////    this.jmlTagihanTxt.Text = this.Aptbarangmasuk.total.Value.ToString("#,#");

            ////    LoadAptbarangmasukdetail(this.Aptbarangmasuk.aptbarangmasukid);

            ////}

            
            
        }
    }
}
