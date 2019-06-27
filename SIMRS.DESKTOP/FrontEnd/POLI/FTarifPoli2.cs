using SIMRS.DESKTOP.FrontEnd.LAB;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd;
using SIMRS.Services.FrontEnd.Penunjang;
using SIMRS.Services.FrontEnd.POLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.POLI
{
    public class FTarifPoli2 : FAddTarifPasien2
    {
        
        protected int indexSelectedRowFromSender = -1;
        protected int selectedTindakanPoli = -1;
        protected int selectedTindakanLab = -1;

        #region private method control
        

        //private async void LoadVjenistarifpenjaminByPenjaminIdAsync(short penjaminid)
        //{
        //    try
        //    {
        //        using (var service = new ListTindakanPasienPoliServices())
        //        {
        //            var result = await service.SelectVjenistarifpenjaminByPenjaminIdAsync (penjaminid);
        //            if (result.Item2 != null)
        //            {
        //                MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //            else
        //            {
        //                jenistarifLookUpEdit.Properties.DataSource = result.Item1;
        //                //jenistarifCboEdit.DataBindings.Add( tarifGC.DataSource = result.Item1;
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private async void LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid,DateTime tgltindakan)
        {

            try
            {
                using (var service = new ListTindakanPasienPoliServices())
                {
                    var result = await service.SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid,tgltindakan);
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

        private async void LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(short registrasiid, short ruangrawatid, short ruangrawatpenunjangid, DateTime tgltindakan)
        {

            try
            {
                using (var service = new ListTindakanPasienPenunjangServices())
                {
                    var result = await service.SelectVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(registrasiid, ruangrawatid,ruangrawatpenunjangid,tgltindakan);
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

        public FTarifPoli2(ref Panel pnlContent):base()
        {
            
        }

        public FTarifPoli2(ref Panel pnlContent, ref short penjaminid, ref short kelasid, ref short ruangrawatid) : 
            base(ref pnlContent, ref penjaminid, ref kelasid, ref ruangrawatid)
        {
            try
            {
                this.Text = "Add Tindakan";



                jenistarifLookUpEdit.Visible = true;
                //tindakanMtxt.Enabled = true;
                totalMtxt.Enabled = true;
                //tindakanMtxt.ReadOnly = true;
                totalMtxt.ReadOnly = true;

                tgltindakanDateEdit.ReadOnly = true;

                //MessageBox.Show(jenistarifLookUpEdit.EditValue.ToString());
                //MessageBox.Show(this.penjaminid.ToString());

                //jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FTarifPoli2(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat, ref int indexSelectedRowFromSender) : base(ref pnlContent, ref Vregistrasiruangrawat)
        {
            try
            {
                


                this.indexSelectedRowFromSender = indexSelectedRowFromSender;


                this.Text = "Add Tindakan";

                this.lblTitle.Text = "Tarif " + this.Vregistrasiruangrawat.ruangrawatnm;

                this.lblTitle.Text = string.Format("NoRegistrasi: {0}, NoCM: {1}, Nama: {2}, Ruang Perawatan: {3}",
                this.Vregistrasiruangrawat.noregistrasi + "-" + this.Vregistrasiruangrawat.registrasiruangrawatid,
                this.Vregistrasiruangrawat.nocm,
                this.Vregistrasiruangrawat.nama,
                this.Vregistrasiruangrawat.ruangrawatnm);

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
                LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, (short)this.Vregistrasiruangrawat.ruangrawatid,
                    (DateTime)this.tgltindakanDateEdit.EditValue);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FTarifPoli2(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat) : base(ref pnlContent, ref Vregistrasiruangrawat)
        {
            try
            {
                this.Text = "Add Tindakan";

                this.lblTitle.Text = "Tarif " + this.Vregistrasiruangrawat.ruangrawatnm;

                this.lblTitle.Text = string.Format("NoRegistrasi: {0}, NoCM: {1}, Nama: {2}, Ruang Perawatan: {3}",
                this.Vregistrasiruangrawat.noregistrasi + "-" + this.Vregistrasiruangrawat.registrasiruangrawatid,
                this.Vregistrasiruangrawat.nocm,
                this.Vregistrasiruangrawat.nama,
                this.Vregistrasiruangrawat.ruangrawatnm);

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
                LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, (short)this.Vregistrasiruangrawat.ruangrawatid,
                    (DateTime)this.tgltindakanDateEdit.EditValue);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public FTarifPoli2(ref Panel pnlContent, ref v_registrasiruangrawat Vregistrasiruangrawat,ref v_tindakanpoli v_Tindakanpoli) : base(ref pnlContent, ref Vregistrasiruangrawat)
        {
            try
            {
                this.Text = "Add / Edit Tindakan";

                this.lblTitle.Text = "Tarif " + this.Vregistrasiruangrawat.ruangrawatnm;

                this.lblTitle.Text = string.Format("NoRegistrasi: {0}, NoCM: {1}, Nama: {2}, Ruang Perawatan: {3}",
                this.Vregistrasiruangrawat.noregistrasi + "-" + this.Vregistrasiruangrawat.registrasiruangrawatid,
                this.Vregistrasiruangrawat.nocm,
                this.Vregistrasiruangrawat.nama,
                this.Vregistrasiruangrawat.ruangrawatnm);

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

                this.v_Tindakanpoli = v_Tindakanpoli;
                this.tgltindakanDateEdit.EditValue = this.v_Tindakanpoli.pelayananpasienjam.Value;

                LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, (short)this.Vregistrasiruangrawat.ruangrawatid,
                    (DateTime)this.tgltindakanDateEdit.EditValue);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFTarifPoli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FTarifPoli2(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref int indexSelectedRowFromSender) : base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang)
        {
            try
            {

                //Constructor Add Tarif LAB

                this.indexSelectedRowFromSender = indexSelectedRowFromSender;


                this.Text = "Add Tindakan";

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

        public FTarifPoli2(ref Panel pnlContent, ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref v_tindakanpenunjang v_Tindakanpenunjang) : base(ref pnlContent, ref v_Registrasiruangrawat_Penunjang)
        {
            try
            {
                //Contructor Edit TarifLAB

                this.Text = "Add / Edit Tindakan";

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


        protected override void FAddTarifPasien2_Load(object sender, EventArgs e)
        {
            try
            {

                LoadVjenistarifpenjaminByPenjaminId(this.penjaminid);

                jenistarifLookUpEdit.EditValue = jenistarifLookUpEdit.Properties.GetDataSourceValue("jenistarifid", 0);
                //LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()), string.Empty);
                jenistarifLookUpEdit.Visible = false;



            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ncaridataMTxt_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void FAddTarifPasien2_Shown(object sender, EventArgs e)
        {
            

        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Vregistrasiruangrawat != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    //FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.vregistrasiruangrawat);
                    FListTindakanPasienPoli myForm = new FListTindakanPasienPoli(ref this.pnlContent, ref this.Vregistrasiruangrawat, ref this.indexSelectedRowFromSender);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
                else
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
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\nbtnBack_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tindakabbuttonEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (jenistarifLookUpEdit.EditValue != null)
                {
                    tarifGC.Visible = true;
                    if (string.IsNullOrEmpty(tindakabbuttonEdit.Text))
                    {
                        LoadTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()));
                    }
                    else
                    {
                        LoadVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()), (tindakabbuttonEdit.EditValue != null) ? tindakabbuttonEdit.EditValue.ToString() : string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakabbuttonEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void tindakabbuttonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Enter))
                {
                    tarifGV.Focus();
                    tarifGV.FocusedRowHandle = 0;
                    tarifGV.SelectRow(0);
                }

                if (e.KeyCode == Keys.Escape)
                {
                    tindakabbuttonEdit.Text = string.Empty;
                    tarifGC.Visible = false;
                    jmlCboEdit.EditValue = 1;
                    totalMtxt.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakabbuttonEdit_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void tarifGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Tarif = tarifGV.GetRow(e.FocusedRowHandle) as v_tarif;
                if (v_Tarif != null)
                {
                    this.indexSelectedRowTarif = e.FocusedRowHandle;
                }
                else
                {
                    this.indexSelectedRowTarif = -1;
                }


            }
            catch (Exception ex)
            {
                this.indexSelectedRowTarif = -1;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tarifGV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.v_Tarif = tarifGV.GetRow(this.indexSelectedRowTarif) as v_tarif;
                    if (this.v_Tarif == null) return;
                    tindakabbuttonEdit.EditValue = this.v_Tarif.daftartindakannm;
                    
                    //jmlCboEdit.SelectionStart = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length + 1 : 1;
                    jmlCboEdit.SelectionLength= (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length  : 0;
                    totalMtxt.Text = (this.v_Tarif.biaya * ((jmlCboEdit.EditValue != null) ? (int)jmlCboEdit.EditValue : 1)).ToString();
                    tarifGC.Visible = false;
                    jmlCboEdit.Focus();
                    tarifGC.Visible = false;
                    //tarifGC.SendToBack();
                }
            }
            catch (Exception ex)
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (this.v_Tarif.biaya).ToString();

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void tarifGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.v_Tarif = tarifGV.GetRow(this.indexSelectedRowTarif) as v_tarif;
                if (this.v_Tarif == null) return;
                    tindakabbuttonEdit.EditValue = this.v_Tarif.daftartindakannm;

                    //jmlCboEdit.SelectionStart = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length + 1 : 1;
                    jmlCboEdit.SelectionLength = (jmlCboEdit.EditValue != null) ? jmlCboEdit.EditValue.ToString().Length : 0;
                    totalMtxt.Text = (this.v_Tarif.biaya * ((jmlCboEdit.EditValue != null) ? (int)jmlCboEdit.EditValue : 1)).ToString();
                    tarifGC.Visible = false;
                    jmlCboEdit.Focus();
                    tarifGC.Visible = false;
                    //tarifGC.SendToBack();
                
            }
            catch (Exception ex)
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (this.v_Tarif.biaya).ToString();

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntarifGV_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.v_Tindakanpoli = tindakanGV.GetRow(e.FocusedRowHandle) as v_tindakanpoli;
                if (v_Tindakanpoli != null)
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
                if (this.Vregistrasiruangrawat != null)
                {

                    if (this.Vregistrasiruangrawat.stsmasukkeluarruangrawatid == 0)//keluar
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pasien dengan No.RM : " + this.Vregistrasiruangrawat.nocm + ", Nama :" + this.Vregistrasiruangrawat.nama + " telah selesai periksa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                    if (this.v_Tindakanpoli != null)
                    {

                        if (RemovePelayananPasien(new pelayananpasien { pelayananpasienid = this.v_Tindakanpoli.pelayananpasienid }) != -99)
                            LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, (short)this.Vregistrasiruangrawat.ruangrawatid,
                            ((DateTime)this.tgltindakanDateEdit.EditValue).Date);

                    }
                }
                else
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

        protected override void tindakabbuttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tindakabbuttonEdit.Text))
                {
                    tarifGC.Visible = true;
                    LoadTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(this.penjaminid, this.kelasid, this.ruangrawatid, short.Parse(jenistarifLookUpEdit.EditValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ntindakabbuttonEdit_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void jmlCboEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.v_Tarif!=null)
                totalMtxt.Text = (v_Tarif.biaya * ((jmlCboEdit.EditValue != null) ? ((jmlCboEdit.EditValue.ToString()!=string.Empty)?(int)jmlCboEdit.EditValue:1) : 1)).ToString();
            }
            catch (Exception ex)
            {
                if (this.v_Tarif != null)
                    totalMtxt.Text = (this.v_Tarif.biaya).ToString();

                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\njmlCboEdit_EditValueChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void jmlCboEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Down)) bSave.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\njmlCboEdit_KeyDown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                pelayananpasien p = null;

                if (this.Vregistrasiruangrawat != null)
                {
                    p = new pelayananpasien
                    {
                        pelayananpasienid = -1,
                        pelayananpasientgl = ((DateTime)this.tgltindakanDateEdit.EditValue).Date,
                        pelayananpasienjam = ((DateTime)this.tgltindakanDateEdit.EditValue).Date.Add(DateTime.Now.TimeOfDay),
                        registrasiruangrawatid = this.Vregistrasiruangrawat.registrasiruangrawatid,
                        registrasipenunjangid = (short)-1,
                        dokterid = short.Parse(dokterLookUpEdit.EditValue.ToString()),
                        perawatid = (perawatLookUpEdit.EditValue != null) ? short.Parse(perawatLookUpEdit.EditValue.ToString()) : (short)-1,
                        jenistarifid = jenistarifLookUpEdit.EditValue.ToString(),
                        tarifid = this.v_Tarif.tarifid,
                        biaya = this.v_Tarif.biaya,
                        jml = short.Parse(jmlCboEdit.EditValue.ToString()),
                        totalbiaya = decimal.Parse(totalMtxt.Text),
                        loginappid = null

                    };
                }
                else
                {
                   p = new pelayananpasien
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
                }

                if (AddPelayananPasien(p) != -99)
                {



                    if (this.Vregistrasiruangrawat != null)
                    {
                        
                        LoadVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(this.Vregistrasiruangrawat.registrasiid, (short)this.Vregistrasiruangrawat.ruangrawatid,
                            ((DateTime)this.tgltindakanDateEdit.EditValue).Date);
                    }
                    else
                    {
                        LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(this.v_Registrasiruangrawat_Penunjang.registrasiid,
                            this.v_Registrasiruangrawat_Penunjang.ruangrawatid.Value,
                            this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value,
                            ((DateTime)this.tgltindakanDateEdit.EditValue).Date);


                    }

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
