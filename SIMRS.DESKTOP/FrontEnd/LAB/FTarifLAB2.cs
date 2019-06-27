using SIMRS.DESKTOP.FrontEnd.POLI;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.Penunjang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.LAB
{
    public class FTarifLAB2 : FAddTarifPasien2
    {

        protected int indexSelectedRowFromSender = -1;


        protected int selectedTindakanLab = -1;



        #region private method control
        
        protected async void LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(short registrasiid, short ruangrawatid, short ruangrawatpenunjangid, DateTime tgltindakan)
        {

            try
            {
                using (var service = new ListTindakanPasienPenunjangServices())
                {
                    var result = await service.SelectVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(registrasiid, ruangrawatid, ruangrawatpenunjangid, tgltindakan);
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



        ////private void populateVregistrasiruangrawat(ref v_registrasiruangrawat value)
        ////{
        ////    this.noregistrasiMtxt.Text = value.noregistrasi; this.tglregistrasiMtxt.Text = value.tglmasuk.Value.ToString("dd/MM/yyyy");
        ////    this.normMtxt.Text = value.nocm; this.namaMtxt.Text = value.nama;
        ////    this.kelasMtxt.Text = value.kelasuraian; this.ruangrawatMtxt.Text = value.ruangrawatnm;
        ////    this.kelumurMtxt.Text = string.Format("{0} / {1} Thn, {2} Bln, {3} Hari", value.jknm, value.thn, value.bulan, value.hari); this.penjaminMtxt.Text = value.penjaminpasiennm;
        ////}




        #endregion

        public FTarifLAB2()
        {

        }


        public FTarifLAB2(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref int indexSelectedRowFromSender) : base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang)
        {
            try
            {

                //Constructor Add Tarif LAB

                this.indexSelectedRowFromSender = indexSelectedRowFromSender;


                this.Text = "Add Tindakan LAB";

                this.lblTitle.Text = "Tarif " + this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangnm;

                this.lblTitle.Text = string.Format("NoRegistrasi: {0}, NoCM: {1}, Nama: {2}, Ruang Perawatan: {3}",
                this.v_Registrasiruangrawat_Penunjang.noregistrasi + "-" + this.v_Registrasiruangrawat_Penunjang.registrasiruangrawatid,
                this.v_Registrasiruangrawat_Penunjang.nocm,
                this.v_Registrasiruangrawat_Penunjang.nama,
                this.v_Registrasiruangrawat_Penunjang.ruangrawatnm);

                jenistarifLookUpEdit.Visible = true;
                //tindakanMtxt.Enabled = true;
                totalMtxt.Enabled = true;
                //tindakanMtxt.ReadOnly = true;
                totalMtxt.ReadOnly = true;

                tgltindakanDateEdit.ReadOnly = true;

                //MessageBox.Show(jenistarifLookUpEdit.EditValue.ToString());
                //MessageBox.Show(this.penjaminid.ToString());

                //jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);

                tarifGC.Left = tindakabbuttonEdit.Left;
                tarifGC.Top = tindakabbuttonEdit.Top + tindakabbuttonEdit.Height;
                tarifGC.Visible = true;
                tarifGC.BringToFront();
                tarifGC.Visible = false;
                //..LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.v_Registrasiruangrawat_Penunjang.registrasiid, (short)this.v_Registrasiruangrawat_Penunjang.ruangrawatid,
                ////    (DateTime)this.tgltindakanDateEdit.EditValue);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FTarifLAB2(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref v_tindakanpenunjang v_Tindakanpenunjang) : base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang)
        {
            try
            {
                //Contructor Edit TarifLAB

                this.Text = "Add / Edit Tindakan LAB";

                this.lblTitle.Text = "Tarif " + this.v_Registrasiruangrawat_Penunjang.ruangrawatnm;

                this.lblTitle.Text = string.Format("NoRegistrasi: {0}, NoCM: {1}, Nama: {2}, Ruang Perawatan: {3}",
                this.v_Registrasiruangrawat_Penunjang.noregistrasi + "-" + this.v_Registrasiruangrawat_Penunjang.registrasiruangrawatid,
                this.v_Registrasiruangrawat_Penunjang.nocm,
                this.v_Registrasiruangrawat_Penunjang.nama,
                this.v_Registrasiruangrawat_Penunjang.ruangrawatnm);

                jenistarifLookUpEdit.Visible = true;
                //tindakanMtxt.Enabled = true;
                totalMtxt.Enabled = true;
                //tindakanMtxt.ReadOnly = true;
                totalMtxt.ReadOnly = true;

                tgltindakanDateEdit.ReadOnly = true;

                //MessageBox.Show(jenistarifLookUpEdit.EditValue.ToString());
                //MessageBox.Show(this.penjaminid.ToString());

                //jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);

                tarifGC.Left = tindakabbuttonEdit.Left;
                tarifGC.Top = tindakabbuttonEdit.Top + tindakabbuttonEdit.Height;
                tarifGC.Visible = true;
                tarifGC.BringToFront();
                tarifGC.Visible = false;

                this.v_Tindakanpenunjang = v_Tindakanpenunjang;
                this.tgltindakanDateEdit.EditValue = this.v_Tindakanpenunjang.pelayananpasienjam.Value;

                LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(this.v_Registrasiruangrawat_Penunjang.registrasiid,
                    this.v_Registrasiruangrawat_Penunjang.ruangrawatid.Value,
                    this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value,
                    ((DateTime)this.tgltindakanDateEdit.EditValue).Date);



            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
               
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat);
                FTindakanPasienLAB myForm = new FTindakanPasienLAB(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.indexSelectedRowFromSender);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

               
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Tindakanpenunjang = tindakanGV.GetRow(e.FocusedRowHandle) as v_tindakanpenunjang;
                if (v_Tindakanpenunjang != null)
                {
                    this.indexSelectedRowTindakan = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedRowTindakan = -1;
                }


            }
            catch (Exception ex)
            {
                this.indexSelectedRowTindakan = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakanGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void deleterepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Tindakanpenunjang != null)
                {
                    if (this.v_Registrasiruangrawat_Penunjang.stsmasukkeluarruangrawatid == 0)//keluar
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pasien dengan No.RM : " + this.v_Registrasiruangrawat_Penunjang.nocm + ", Nama :" + this.v_Registrasiruangrawat_Penunjang.nama + " telah selesai periksa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                    if (this.v_Tindakanpenunjang != null)
                    {
                        if (RemovePelayananPasien(new pelayananpasien { pelayananpasienid = this.v_Tindakanpenunjang.pelayananpasienid }) != -99)

                            LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(this.v_Registrasiruangrawat_Penunjang.registrasiid,
                                this.v_Registrasiruangrawat_Penunjang.ruangrawatid.Value,
                                this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value,
                                ((DateTime)this.tgltindakanDateEdit.EditValue).Date);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndeleterepositoryItemButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void bSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (jmlCboEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jumlah tindakan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dokterLookUpEdit.EditValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih dokter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pelayananpasien p = new pelayananpasien
                {
                    pelayananpasienid = -1,
                    pelayananpasientgl = ((DateTime)this.tgltindakanDateEdit.EditValue).Date,
                    pelayananpasienjam = ((DateTime)this.tgltindakanDateEdit.EditValue).Date.Add(DateTime.Now.TimeOfDay),
                    registrasiruangrawatid = this.v_Registrasiruangrawat_Penunjang.registrasiruangrawatid,
                    registrasipenunjangid = (this.v_Registrasiruangrawat_Penunjang != null) ? this.v_Registrasiruangrawat_Penunjang.registrasipenunjangid : (short)-1,
                    dokterid = short.Parse(dokterLookUpEdit.EditValue.ToString()),
                    perawatid = (perawatLookUpEdit.EditValue != null) ? short.Parse(perawatLookUpEdit.EditValue.ToString()) : (short)-1,
                    jenistarifid = jenistarifLookUpEdit.EditValue.ToString(),
                    tarifid = this.v_Tarif.tarifid,
                    biaya = this.v_Tarif.biaya,
                    jml = short.Parse(jmlCboEdit.EditValue.ToString()),
                    totalbiaya = decimal.Parse(totalMtxt.Text),
                    loginappid = null

                };
                

                if (AddPelayananPasien(p) != -99)
                {

                    LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(this.v_Registrasiruangrawat_Penunjang.registrasiid,
                            this.v_Registrasiruangrawat_Penunjang.ruangrawatid.Value,
                            this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value,
                            ((DateTime)this.tgltindakanDateEdit.EditValue).Date);


                    ////if (DelegateMethodPelayananpasien != null)
                    ////    DelegateMethodPelayananpasien();
                    //this.Dispose(true);
                    tindakabbuttonEdit.EditValue = null;
                    //tindakabbuttonEdit.Text = string.Empty;
                    this.v_Tarif = null;
                    tindakabbuttonEdit.Focus();
                    tindakabbuttonEdit.SelectionLength = (tindakabbuttonEdit.EditValue != null) ? tindakabbuttonEdit.EditValue.ToString().Length : 0;


                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Save tarif tidak valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbSave_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
