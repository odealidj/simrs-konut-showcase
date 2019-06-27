using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FListDiagnosaPasienPoli : FDiagnosaPasien
    {
        protected v_registrasiruangrawat Vregistrasiruangrawat;

        protected v_icdxpasienpoli Vicdxpasienpoli;

        protected int indexSelectedRow;

        #region private methode
        public int AddIcdxpasien(icdxpasien obj)
        {
            using (var service = new FListDiagnosaPasienService())
            {
                var result = service.InsertIcdxpasien(obj) ;
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Add diagnosa tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        public int RemoveIcdxpasien(icdxpasien obj)
        {
            using (var service = new FListDiagnosaPasienService())
            {
                var result = service.DeleteIcdxpasien(obj);
                if (result == -99)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Remove diagnosa tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -99;
                }
                else
                {
                    return result;
                }
            }
        }

        private async void LoadVicdxpasienpoliAsync(short registrasiruangrawatid)
        {
            try
            {
                using (var service = new ListDiagosaPasienPoliServices())
                {
                    var result = await service.SelectVicdxpasienpoliAsync(registrasiruangrawatid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        icdxGC.DataSource = result.Item1;
                    }
                    
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion



        private void populateVregistrasiruangrawat(ref v_registrasiruangrawat value)
        {

            this.noregistrasiMtxt.Text = value.noregistrasi; this.tglregistrasiMtxt.Text = value.tglmasuk.Value.ToString("dd/MM/yyyy");
            this.normMtxt.Text = value.nocm; this.namaMtxt.Text = value.nama;
            this.kelasMtxt.Text = value.kelasuraian; this.ruangrawatMtxt.Text = value.ruangrawatnm;
            this.kelumurMtxt.Text = string.Format("{0} / {1} Thn, {2} Bln, {3} Hari", value.jknm, value.thn, value.bulan, value.hari); this.penjaminMtxt.Text = value.penjaminpasiennm;
            //this.lblTitle.Text = string.Format("NO.REGISTRASI: {0}, NO.RM: {1}, NAMA PASIEN: {2}", value.noregistrasi, value.nocm, value.nama);
            this.lblTitle.Text = string.Format("{0}", value.nama.ToUpper());
        }

        public FListDiagnosaPasienPoli(ref Panel _pnlContent, ref v_registrasiruangrawat _vregistrasiruangrawat, ref int indexRow) :base(ref _pnlContent)
        {
            try
            {
                this.Text = "Diagnosa Pasien";

                this.Vregistrasiruangrawat = _vregistrasiruangrawat;



                populateVregistrasiruangrawat(ref this.Vregistrasiruangrawat);

                ////if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid == 0) //keluar
                ////{
                ////    this.bAddIcdX.Enabled = false;
                ////    //this.icdixGV.Columns["colDel"].OptionsColumn.AllowEdit = false;

                ////}
                ////else//masuk
                ////{
                ////    this.bAddIcdX.Enabled = true;
                ////    //this.icdixGV.Columns["colDel"].OptionsColumn.AllowEdit = true;
                ////}
                LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiruangrawatid);

                this.indexSelectedRow = indexRow;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nConstructor FListTindakanPasienPoli ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bAddIcdX_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIcdxsubkategori==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih diagnosa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (jenisdiagnosaLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis diagnosa ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (doktericdxLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                icdxpasien icdx = new icdxpasien()
                {
                    icdxpasienid = -1,
                    icdxsubkategoriid = selectedIcdxsubkategori.icdxsubkategoriid,
                    registrasiruangrawatid= this.Vregistrasiruangrawat.registrasiruangrawatid,
                    icdxpasientgl = ((DateTime)tglicdxDateEdit.EditValue).Date,
                    jenisdiagnosaid = (jenisdiagnosaLookUpEdit.EditValue != null) ? (short)jenisdiagnosaLookUpEdit.EditValue : (short)-1,
                    dokterid = (doktericdxLookUpEdit.EditValue != null) ? (short)doktericdxLookUpEdit.EditValue : (short)-1,
                    loginappid = -1, //Helper.LoginAppDetail.loginappdetailid,
                    created_date = DateTime.Now,
                    updated_date = null,
                    icdxpasiensts = true
                };

                AddIcdxpasien(icdx);
                LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiruangrawatid);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbAddIcdX_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void FDiagnosaPasien_Shown(object sender, EventArgs e)
        {
            try
            {
                if (icdxGC.DataSource != null)
                {
                    icdxGV.Columns[0].Visible = false;
                    icdxGV.Columns[1].Visible = false;
                    icdxGV.Columns[5].Visible = false;

                    icdxGV.Columns[2].Caption = "KODE";
                    icdxGV.Columns[3].Caption = "Diagnosa [Eng]";
                    icdxGV.Columns[4].Caption = "Diagnosa [INA]";
                    icdxGV.Columns[6].Caption = "JENIS";

                    icdxGV.Columns[2].OptionsColumn.AllowEdit = false;
                    icdxGV.Columns[3].OptionsColumn.AllowEdit = false;
                    icdxGV.Columns[4].OptionsColumn.AllowEdit = false;
                    icdxGV.Columns[6].OptionsColumn.AllowEdit = false;

                    icdxGV.Columns[2].OptionsColumn.FixedWidth = true;
                    icdxGV.Columns[2].Width = 75;

                    icdxGV.Columns[6].OptionsColumn.FixedWidth = true;
                    icdxGV.Columns[6].Width = 90;

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n FDiagnosaPasien_Shown ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                ////if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid==0)//keluar
                ////{
                ////    MetroFramework.MetroMessageBox.Show(this, "Pasien dengan No.RM : " + this.Vregistrasiruangrawat.nocm + ", Nama :" + this.Vregistrasiruangrawat.nama + " telah selesai periksa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ////    return;

                ////}

                if (this.Vicdxpasienpoli != null)
                {
                    
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah dignosa dengan kode : " + this.Vicdxpasienpoli.icdxsubkategoriid + " akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (RemoveIcdxpasien(new icdxpasien { icdxpasienid = this.Vicdxpasienpoli.icdxpasienid }) != -99)
                        {
                            LoadVicdxpasienpoliAsync(this.Vregistrasiruangrawat.registrasiruangrawatid);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndeleterepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void icdxGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.Vicdxpasienpoli = icdxGV.GetRow(e.FocusedRowHandle) as v_icdxpasienpoli;
                if(this.Vicdxpasienpoli !=null)
                {
                    this.lblTitle.Text = this.Vicdxpasienpoli.icdxsubkategoriid + " - " + this.Vicdxpasienpoli.icdxsubkategorinmeng;
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nicdxGV_FocusedRowChanged ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            ListRegistrasiPoli myForm = new ListRegistrasiPoli(ref this.pnlContent, ref this.Vregistrasiruangrawat, this.indexSelectedRow);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();



            

        }


    }
}
