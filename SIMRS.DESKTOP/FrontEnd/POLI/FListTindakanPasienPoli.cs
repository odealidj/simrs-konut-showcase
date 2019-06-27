
using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.POLI;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FListTindakanPasienPoli : FTindakanPasien
    {

        protected v_registrasiruangrawat Vregistrasiruangrawat;
        protected v_tindakanpoli selectedTindakanPoli;

        //private v_pelayananpasien Vpelayananpasien;

        protected int indexSelectedRow_v_registrasiruangrawat = -1;

        protected int indexSelectedRow_v_registrasiruangrawat_forSender = -1;

        #region private method control
        private async void LoadVpelayananpasienByRegistrasiIdAsync(short registrasiid)
        {
            try
            {
                using (var service = new ListTindakanPasienPoliServices())
                {
                    var result = await service.SelectVpelayananpasienByRegistrasiIdAsync(registrasiid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tindakanGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid,short ruangrawatid)
        {
            
            try
            {
                using (var service = new ListTindakanPasienPoliServices())
                {
                    var result = await service.SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        tindakanGC.DataSource = result.Item1;
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void populateVregistrasiruangrawat(ref v_registrasiruangrawat value)
        {
            this.noregistrasiMtxt.Text = value.noregistrasi; this.tglregistrasiMtxt.Text = value.tglmasuk.Value.ToString("dd/MM/yyyy");
            this.normMtxt.Text = value.nocm; this.namaMtxt.Text = value.nama;
            this.kelasMtxt.Text = value.kelasuraian; this.ruangrawatMtxt.Text = value.ruangrawatnm;
            this.kelumurMtxt.Text = string.Format("{0} / {1} Thn, {2} Bln, {3} Hari", value.jknm, value.thn, value.bulan, value.hari); this.penjaminMtxt.Text = value.penjaminpasiennm;
        }

        #endregion


        public FListTindakanPasienPoli(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            try
            {
                this.Text = "Tindakan Pasien";

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FListTindakanPasienPoli(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, ref int indexSelectedRow_v_registrasiruangrawat) : base(ref _pnlContent)
        {
            try
            {
                this.Text = "Tindakan Pasien";

                this.Vregistrasiruangrawat = _vregistrasiruangrawat;
                populateVregistrasiruangrawat(ref this.Vregistrasiruangrawat);

                ////if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid==0) //keluar
                ////{
                ////    this.addMbtn.Enabled = false;
                ////}
                ////else//masuk
                ////{
                ////    this.addMbtn.Enabled = true;
                ////}


                ////LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, this.Vregistrasiruangrawat.ruangrawatid.Value);
                this.indexSelectedRow_v_registrasiruangrawat = indexSelectedRow_v_registrasiruangrawat;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FListTindakanPasienPoli(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat) : base(ref _pnlContent)
        {
            try
            {
                this.Text = "Tindakan Pasien";

                this.Vregistrasiruangrawat = _vregistrasiruangrawat;
                populateVregistrasiruangrawat(ref this.Vregistrasiruangrawat);

                ////if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid == 0) //keluar
                ////{
                ////    this.addMbtn.Enabled = false;
                ////}
                ////else//masuk
                ////{
                ////    this.addMbtn.Enabled = true;
                ////}


                ////LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, this.Vregistrasiruangrawat.ruangrawatid.Value);
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public FListTindakanPasienPoli(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, 
            int indexSelectedRow_v_registrasiruangrawat_forSender) : base(ref _pnlContent)
        {
            try
            {
                this.Text = "Tindakan Pasien";

                this.Vregistrasiruangrawat = _vregistrasiruangrawat;
                populateVregistrasiruangrawat(ref this.Vregistrasiruangrawat);

                if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid == 0) //keluar
                {
                    this.addMbtn.Enabled = false;
                }
                else//masuk
                {
                    this.addMbtn.Enabled = true;
                }

                ////LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, this.Vregistrasiruangrawat.ruangrawatid.Value);
                this.indexSelectedRow_v_registrasiruangrawat_forSender = indexSelectedRow_v_registrasiruangrawat_forSender;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void FTindakanPasien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, this.Vregistrasiruangrawat.ruangrawatid.Value);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\n FTindakanPasien_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //this.Vpelayananpasien = tindakanGV.GetRow(e.FocusedRowHandle) as v_pelayananpasien;
            try
            {
                this.selectedTindakanPoli = tindakanGV.GetRow(e.FocusedRowHandle) as v_tindakanpoli;
                if (this.selectedTindakanPoli != null)
                {
                    lblTitle.Text = string.Format("Selected: [Tgl.Tindakan: {0}, Tindakan: {1}]", this.selectedTindakanPoli.pelayananpasienjam, this.selectedTindakanPoli.daftartindakannm);
                }
            }
            
             catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\ntindakanGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void addMbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //using (FListAddTindakanPoli f = new FListAddTindakanPoli())
                //{
                //    //create an overlay form
                //    XtraForm overlayForm = new XtraForm();
                //    overlayForm.StartPosition = this.StartPosition;// FormStartPosition.CenterScreen;
                //    overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //    overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                //    overlayForm.Opacity = .80d;
                //    overlayForm.BackColor = Color.Black;
                //    overlayForm.Size = FMainMenu.ActiveForm.Size; //mainmenu.Size;// this.Size;
                //    overlayForm.Location = FMainMenu.ActiveForm.Location; //mainmenu.Location;// this.Location;
                //    //overlayForm.Size = this.Size;
                //    //overlayForm.Location =  this.Location;
                //    overlayForm.ShowInTaskbar = false;
                //    overlayForm.Show();

                //    //Show the dialog
                //    f.Owner = overlayForm;
                //    f.ShowDialog();
                //    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                //    //tahunLookUpEdit.ItemIndex = 0;

                //    //Get rid of the overlay form
                //    overlayForm.Dispose();
                //    f.Dispose();
                //}

                //using (FTarifPoli f = new FTarifPoli(this.Vregistrasiruangrawat.penjaminpasienid.Value,this.Vregistrasiruangrawat.kelasid.Value,
                //    this.Vregistrasiruangrawat.ruangrawatid.Value))
                //{

                //    //Show the dialog
                //    f.Owner = this;
                //    f.ShowDialog();
                //    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                //    //tahunLookUpEdit.ItemIndex = 0;

                //    //Get rid of the overlay form
                //    //overlayForm.Dispose();
                //    f.Dispose();
                //}

                //uc.DelegateMethodSK += new ucAddEditSK.LoadDataSKHandler(DelegateMethodSK);

                //using (FTarifPoli2 f = new FTarifPoli2(ref this.Vregistrasiruangrawat))
                //{

                //    //Show the dialog
                //    f.Owner = this;
                //    f.DelegateMethodPelayananpasien += new FAddTarifPasien2.LoadPelayananpasienHandler(DelegateMethodPelayananpasien);
                //    f.ShowDialog();
                //    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                //    //tahunLookUpEdit.ItemIndex = 0;

                //    //Get rid of the overlay form
                //    //overlayForm.Dispose();
                //    f.Dispose();
                //}

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FTarifPoli2 myForm = new FTarifPoli2(ref this.pnlContent, ref this.Vregistrasiruangrawat,ref this.indexSelectedRow_v_registrasiruangrawat);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\naddMbtn_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //private void DelegateMethodPelayananpasien()
        //{
        //    try
        //    {
        //        //LoadVpelayananpasienByRegistrasiIdAsync(this.Vregistrasiruangrawat.registrasiid);
        //        LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, this.Vregistrasiruangrawat.ruangrawatid.Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        protected override void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.selectedTindakanPoli != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FTarifPoli2 myForm = new FTarifPoli2(ref this.pnlContent, ref this.Vregistrasiruangrawat, ref this.selectedTindakanPoli);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\neditrepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid == 0)//keluar
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pasien dengan No.RM : " + this.Vregistrasiruangrawat.nocm + ", Nama :" + this.Vregistrasiruangrawat.nama + " telah selesai periksa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (this.selectedTindakanPoli != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah tindakan :" + this.selectedTindakanPoli.daftartindakannm + "akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (RemovePelayananPasien(new pelayananpasien { pelayananpasienid = this.selectedTindakanPoli.pelayananpasienid }) != -99)
                        LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, this.Vregistrasiruangrawat.ruangrawatid.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndeleterepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            

            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent,ref this.Vregistrasiruangrawat, this.indexSelectedRow_v_registrasiruangrawat);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }


    }
}
