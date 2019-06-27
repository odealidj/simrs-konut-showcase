using DevExpress.XtraReports.UI;
using SIMRS.DESKTOP.Template.Report.Registrasi;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FEditIdentitasPasien : FEditRegistrasiPasienRJ
    {
        private int indexSelectedPasien = -1;


        #region private methode

        protected bool UpdateNoRM(string oldNoRM, string newNoRM)
        {
            using (var service = new RegistrasiPasienServices())
            {
               return service.UpdateNoRM(oldNoRM, newNoRM);
                

            }
        }



        protected (string, string) AddRegistrasiPasienBaru(identitaspasien _identitaspasien, alamatpasien _alamatpasien)
        {
            using (var service = new RegistrasiPasienBaruServices())
            {
                var result = service.InsertPasienBaru(_identitaspasien, _alamatpasien);
                if (!string.IsNullOrEmpty(result.Item2))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item2);
                }
                else
                    return (result.Item1, string.Empty);

            }
        }

        #endregion private methode

        #region constructor
        public FEditIdentitasPasien(ref Panel _pnlContent, string nocm, int indexSelectedPasien) : base(ref _pnlContent, nocm)
        {
            try
            {
 
                this.Text = "Edit Pasien";
                this.indexSelectedPasien = indexSelectedPasien;
                this.bClear.Text = "Edit NO.RM";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FEditIdentitasPasien ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion constructor

        protected override void FAddEditRegistrasiPasien_Load(object sender, EventArgs e)
        {
            try
            {
                this.isSave = false;

                
               
                defaultpanelidentitaspasien();
               

                FirtOrDefaultIdentitasPasienAlamatPasienByNocmAsyncService(this.nocm);



                Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref this.pnlIdentitasPasien, false);
                this.NoRMIP.ReadOnly = false;
                LblStepIdentitasPasien.Text = "Step 1";
               
                //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

                AddCollectionPanelPasienLamaRJ();

                //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

                this.btnFirst.Visible = false;
                this.btnPrev.Visible = false;
                this.btnNext.Visible = false;
                this.btnLast.Text = "Save";

                this.listPanel.RemoveRange(1, 1);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nConstructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bClear_Click(object sender, EventArgs e) // edit NORM
        {
            try
            {
                using (FUpdateNoRMRJ f = new FUpdateNoRMRJ(this.nocm))
                {
                    //Show the dialog
                    f.Owner = this;
                    f.passNoRM += new Template.frm.Registrasi.FUpdateNoRM.PassNoRM(passNoRM);
                    f.ShowDialog();
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nDiagnosaAwalButtonEdit_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void passNoRM(object oldNoRM, object newNoRM)
        {
            if ((oldNoRM!=null) && (newNoRM!=null))
            {

                if (this.UpdateNoRM(oldNoRM.ToString(),newNoRM.ToString())==true)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();

                    FListIdentitasPasienRJ myform = new FListIdentitasPasienRJ(ref this.pnlContent, this.indexSelectedPasien);
                    myform.TopLevel = false;
                    myform.AutoScroll = true;
                    myform.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myform);
                    myform.Dock = DockStyle.Fill;
                    myform.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No.RM tidak dapat diupdate!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        protected override void btnKartuKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                KartuStatusReport1 report = null;

                Loadv_statuspenyakitByNormAsync(this.nocm);

                report = new KartuStatusReport1(this.nocm, this.NamaIP.Text,
                    string.Format("{0} Thn, {1} Bln, {2} Hari", this.ThnIP.Text , this.BlnIP.Text, this.HariIP.Text),
                    this.PekerjaanIPLookUpEdit.Text, string.Format("{0}, Kec.{1}, Kel/Desa.{2}", this.AlamatIP.Text , this.KecIPLookUpEdit.Text, KelIPLookUpEdit.Text),
                    string.Empty , string.Empty ,
                    this.v_Statuspenyakits);
                
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }

                report.ShowRibbonPreview();

            }
            catch (Exception ex)
            {
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnKartuKontrol_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();


                FListIdentitasPasienRJ myform = new FListIdentitasPasienRJ(ref this.pnlContent, this.indexSelectedPasien);
                myform.TopLevel = false;
                myform.AutoScroll = true;
                myform.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myform);
                myform.Dock = DockStyle.Fill;
                myform.Show();


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnLast_Click(object sender, EventArgs e)
        {
            try
            {

                        if (isSave == false)
                        {

                            if (string.IsNullOrEmpty(NoRMIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input NO.RM" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                NoRMIP.Focus();
                                return;
                            }

                            if (string.IsNullOrEmpty(NamaIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input nama pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                NamaIP.Focus();
                                return;
                            }

                            if (string.IsNullOrEmpty(AlamatIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input alamat pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                AlamatIP.Focus();
                                return;
                            }

                            if (KelaminIPLookUpEdit.EditValue == null)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis kelamin pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                KelaminIPLookUpEdit.Focus();
                                return;
                            }

                            if ((TglLahirIPDateEdit.EditValue == null) || (TglLahirIPDateEdit.Text == ""))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal lahir pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TglLahirIPDateEdit.Focus();
                                return;
                            }

                            if (((DateTime)TglLahirIPDateEdit.EditValue).Date > DateTime.Now.Date)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Tgl.Lahir tidak valid,\n Tgl.lahir yang diinput lebih besar dari tgl hari ini" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TglLahirIPDateEdit.Focus();
                                return;
                            }

                             

                            if (MetroFramework.MetroMessageBox.Show(this, "Apakah perubahan data identitas pasien ini akan disimpan" +
                                "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                identitaspasien pasien = new identitaspasien()
                                {
                                    nocm = NoRMIP.Text,
                                    sapaanid = (SapaanIPLookUpEdit.EditValue != null) ? (short)SapaanIPLookUpEdit.EditValue : (short)-1,
                                    nama = NamaIP.Text,
                                    tempatlahir = TempatLahirIP.Text,
                                    tanggallahir = (TglLahirIPDateEdit.EditValue != null) ? ((DateTime)TglLahirIPDateEdit.EditValue).Date : DateTime.Parse(null),
                                    thn = short.Parse(ThnIP.Text ?? "0"),
                                    bulan = short.Parse(BlnIP.Text ?? "0"),
                                    hari = short.Parse(HariIP.Text ?? "0"),
                                    jkid = (KelaminIPLookUpEdit.EditValue != null) ? (short)KelaminIPLookUpEdit.EditValue : (short)-1,
                                    stspernikahanid = (StsNikahIPLookUpEdit.EditValue != null) ? (short)StsNikahIPLookUpEdit.EditValue : (short)-1,
                                    pendidikanid = (PendidikanIPLookUpEdit.EditValue != null) ? (short)PendidikanIPLookUpEdit.EditValue : (short)-1,
                                    pekerjaanid = (PekerjaanIPLookUpEdit.EditValue != null) ? (short)PekerjaanIPLookUpEdit.EditValue : (short)-1,
                                    agamaid = (AgamaIPLookUpEdit.EditValue != null) ? (short)AgamaIPLookUpEdit.EditValue : (short)-1,
                                    notelp = NoTelpIP.Text,
                                    nohp = NoHPIP.Text,
                                    goldarahid = (GolDarahIPLookUpEdit.EditValue != null) ? (short)GolDarahIPLookUpEdit.EditValue : (short)-1,
                                    sukuid = (SukuIPLookUpEdit.EditValue != null) ? (short)SukuIPLookUpEdit.EditValue : (short)-1,
                                    negaraid = Helper.Negara.NegaraId(),
                                    identitaspasiensts = true
                                };

                                alamatpasien alamat = new alamatpasien()
                                {
                                    alamatpasienid = this.Alamatpasien.alamatpasienid,
                                    nocm = pasien.nocm,
                                    alamat = AlamatIP.Text,
                                    kotakabid = Helper.Kotakab.KotakabId(),
                                    kecid = (KecIPLookUpEdit.EditValue != null) ? (short)KecIPLookUpEdit.EditValue : (short)-1,
                                    keldesaid = (KelIPLookUpEdit.EditValue != null) ? (short)KelIPLookUpEdit.EditValue : (short)-1,
                                    rwid = (RTRWIPLookUpEdit.EditValue != null) ? (RTRWIPLookUpEdit.GetSelectedDataRow() as vrtrw).rwid : (short)-1,
                                    rtid = (RTRWIPLookUpEdit.EditValue != null) ? (RTRWIPLookUpEdit.GetSelectedDataRow() as vrtrw).rtid : (short)-1,
                                    alamatpasiensts = true
                                };



                                var result = (string.Empty, string.Empty);

                                result = AddRegistrasiPasienBaru(pasien, alamat);

                                if (!string.IsNullOrEmpty(result.Item1))
                                {
                                    isSave = true;

                                    btnNext.Text = "Finish";

                                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                                    this.pnlContent.Controls.Clear();
                                    //fDashboard myForm = new fDashboard();

                                    FListIdentitasPasienRJ myform = new FListIdentitasPasienRJ(ref this.pnlContent, this.indexSelectedPasien);
                                    myform.TopLevel = false;
                                    myform.AutoScroll = true;
                                    myform.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                                    this.pnlContent.Controls.Add(myform);
                                    myform.Dock = DockStyle.Fill;
                                    myform.Show();

                                }
                                else
                                {
                                    isSave = false;
                                    MetroFramework.MetroMessageBox.Show(this, result.Item2 + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                
            }
            catch (Exception ex)
            {
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\n  btnNext_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
