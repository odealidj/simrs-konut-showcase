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
    public class FTindakanPasienLAB : FTindakanPasien
    {
        protected v_tindakanpenunjang v_Tindakanpenunjang;
        //protected v_distinctpasienpenunjang v_Distinctpasienpenunjang;
        protected v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang;

        protected int indexSelectedRow_v_registrasiruangrawat_penunjang = 0;
        protected int indexSelectedFromSender_v_registrasiruangrawat_penunjang = 0;


        ////protected FListRegistrasiLAB fListRegistrasiLAB;

        #region private method control


        private async void LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(short registrasiid, short ruangrawatid,short ruangrawatpenunjangid)
        {

            try
            {
                using (var service = new ListTindakanPasienPenunjangServices())
                {
                    var result = await service.SelectVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(registrasiid, ruangrawatid, ruangrawatpenunjangid);
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

        private void populateVregistrasiruangrawat(ref v_registrasiruangrawat_penunjang value)
        {
            this.noregistrasiMtxt.Text = value.noregistrasi; this.tglregistrasiMtxt.Text = value.tglmasuk.Value.ToString("dd/MM/yyyy");
            this.normMtxt.Text = value.nocm; this.namaMtxt.Text = value.nama;
            this.kelasMtxt.Text = value.kelasuraian; 
            this.ruangrawatMtxt.Text = value.ruangrawatnm;
            this.kelumurMtxt.Text = string.Format("{0} / {1} Thn, {2} Bln, {3} Hari", value.jknm, value.thn, value.bulan, value.hari); this.penjaminMtxt.Text = value.penjaminpasiennm;
        }



        #endregion

        public FTindakanPasienLAB(ref Panel pnlContent,
           ref v_registrasiruangrawat_penunjang v_Registrasiruangrawat_Penunjang, ref int indexSelectedFromSender) : base (ref pnlContent)
        {
            //contructor Add Tindakan LAB

            //Contructor Back From Tarif LAB

            try
            {
                ////this.fListRegistrasiLAB = fListRegistrasiLAB;

                this.Text = "Tindakan Pasien";

                this.v_Registrasiruangrawat_Penunjang = v_Registrasiruangrawat_Penunjang ;
                populateVregistrasiruangrawat(ref this.v_Registrasiruangrawat_Penunjang);

                this.indexSelectedRow_v_registrasiruangrawat_penunjang = indexSelectedFromSender;
                //this.indexSelectedRow_v_registrasiruangrawat_forSender = indexSelectedRow_v_registrasiruangrawat_forSender;

                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\n Constructor FTindakanPasienLAB ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected override void FTindakanPasien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(this.v_Registrasiruangrawat_Penunjang.registrasiid, this.v_Registrasiruangrawat_Penunjang.ruangrawatid.Value, this.v_Registrasiruangrawat_Penunjang.ruangrawatpenunjangid.Value);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\n FTindakanPasien_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void tindakanGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //this.Vpelayananpasien = tindakanGV.GetRow(e.FocusedRowHandle) as v_pelayananpasien;
            try
            {
                this.v_Tindakanpenunjang = tindakanGV.GetRow(e.FocusedRowHandle) as v_tindakanpenunjang;
                if (this.v_Tindakanpenunjang != null)
                {
                    lblTitle.Text = string.Format("Selected: [Tgl.Tindakan: {0}, Tindakan: {1}]", this.v_Tindakanpenunjang.pelayananpasienjam, this.v_Tindakanpenunjang.daftartindakannm);
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+"\n"+this.Name + "\ntindakanGV_FocusedRowChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected override void addMbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                //FTarifPoli2 myForm = new FTarifPoli2(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.indexSelectedRow_v_registrasiruangrawat);

                FTarifLAB2 myForm = new FTarifLAB2(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.indexSelectedRow_v_registrasiruangrawat_penunjang);
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

        protected override void editrepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.v_Tindakanpenunjang != null)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    
                    ////FTarifPoli2 myForm = new FTarifPoli2(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.v_Tindakanpenunjang);
                    FTarifLAB2 myForm = new FTarifLAB2(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, ref this.v_Tindakanpenunjang);
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
                if (this.v_Registrasiruangrawat_Penunjang.stsmasukkeluarruangrawatid == 0)//keluar
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pasien dengan No.RM : " + this.v_Registrasiruangrawat_Penunjang.nocm + ", Nama :" + this.v_Registrasiruangrawat_Penunjang.nama + " telah selesai periksa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (this.v_Tindakanpenunjang != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Apakah tindakan :" + this.v_Tindakanpenunjang.daftartindakannm + "akan dihapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (RemovePelayananPasien(new pelayananpasien { pelayananpasienid = this.v_Tindakanpenunjang.pelayananpasienid }) != -99)
                            LoadVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(this.v_Tindakanpenunjang.registrasiid, this.v_Tindakanpenunjang.ruangrawatid.Value, this.v_Tindakanpenunjang.ruangrawatpenunjangid.Value);
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

            FListRegistrasiLAB myForm = new FListRegistrasiLAB(ref this.pnlContent, ref this.v_Registrasiruangrawat_Penunjang, this.indexSelectedRow_v_registrasiruangrawat_penunjang);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }


    }
}
