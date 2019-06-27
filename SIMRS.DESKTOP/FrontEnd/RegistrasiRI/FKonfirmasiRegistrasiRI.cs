using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRI
{
    public class FKonfirmasiRegistrasiRI : FKonfirmasiRegistrasi
    {
        private v_registrasiruangrawatrjrd vregistrasiruangrawatrjrd;
        private v_listtempattidurrawatinap listtempattidurrawatinap;

        #region private method
        
        protected int AddRegistrasiRuangRawat(registrasiruangrawat _registrasiruangrawat, tempattidur _tt)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    return service.InsertRegistrasiRuangRawatRI(_registrasiruangrawat,_tt);

                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    
    
        #endregion

        public FKonfirmasiRegistrasiRI(ref Panel _pnlContent, ref v_listtempattidurrawatinap listtempattidurrawatinap, ref v_registrasiruangrawatrjrd vregistrasiruangrawatrjrd,
                string alamat, string kec, string keldesa, string rtrw) : base(ref _pnlContent)
        {
            
            InitializeComponent();

            try
            {

                this.listtempattidurrawatinap = listtempattidurrawatinap;

                this.vregistrasiruangrawatrjrd = vregistrasiruangrawatrjrd;

                NoRM.Text = this.vregistrasiruangrawatrjrd.nocm;
                Nama.Text = this.vregistrasiruangrawatrjrd.nama;
                TglLahirDateEdit.EditValue = this.vregistrasiruangrawatrjrd.tanggallahir.Value;
                Thn.Text = this.vregistrasiruangrawatrjrd.thn != null ? this.vregistrasiruangrawatrjrd.thn.Value.ToString() : "0";
                Bln.Text = this.vregistrasiruangrawatrjrd.bulan != null ? this.vregistrasiruangrawatrjrd.bulan.Value.ToString() : "0";
                Hari.Text = this.vregistrasiruangrawatrjrd.hari != null ? this.vregistrasiruangrawatrjrd.hari.Value.ToString() : "0";
                kelaminMTxt.Text = this.vregistrasiruangrawatrjrd.jknm;

                ProsedurMasukMTxt.Text = this.vregistrasiruangrawatrjrd.prosedurmasuknm;
                PenjaminMTxt.Text = this.vregistrasiruangrawatrjrd.penjaminpasiennm;
                AsalPoliMTxt.Text = this.vregistrasiruangrawatrjrd.ruangrawatnm;


                KelasMTxt.Text = this.listtempattidurrawatinap.kelasnm;
                RuangRawatMTxt.Text = this.listtempattidurrawatinap.ruangrawatnm;
                KamarMTxt.Text = this.listtempattidurrawatinap.kamarnm;
                TempatTidurMTxt.Text = this.listtempattidurrawatinap.tempattidurnm;
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NoRM
            // 
            // 
            // 
            // 
            this.NoRM.CustomButton.Image = null;
            this.NoRM.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.NoRM.CustomButton.Name = "";
            this.NoRM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoRM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoRM.CustomButton.TabIndex = 1;
            this.NoRM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoRM.CustomButton.UseSelectable = true;
            this.NoRM.CustomButton.Visible = false;
            this.NoRM.Lines = new string[0];
            // 
            // Hari
            // 
            // 
            // 
            // 
            this.Hari.CustomButton.Image = null;
            this.Hari.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.Hari.CustomButton.Name = "";
            this.Hari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Hari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Hari.CustomButton.TabIndex = 1;
            this.Hari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Hari.CustomButton.UseSelectable = true;
            this.Hari.CustomButton.Visible = false;
            this.Hari.Lines = new string[] {
        "0"};
            // 
            // Bln
            // 
            // 
            // 
            // 
            this.Bln.CustomButton.Image = null;
            this.Bln.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.Bln.CustomButton.Name = "";
            this.Bln.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bln.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bln.CustomButton.TabIndex = 1;
            this.Bln.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bln.CustomButton.UseSelectable = true;
            this.Bln.CustomButton.Visible = false;
            this.Bln.Lines = new string[] {
        "0"};
            // 
            // Thn
            // 
            // 
            // 
            // 
            this.Thn.CustomButton.Image = null;
            this.Thn.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.Thn.CustomButton.Name = "";
            this.Thn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Thn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Thn.CustomButton.TabIndex = 1;
            this.Thn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Thn.CustomButton.UseSelectable = true;
            this.Thn.CustomButton.Visible = false;
            this.Thn.Lines = new string[] {
        "0"};
            // 

            // Nama
            // 
            // 
            // 
            // 
            this.Nama.CustomButton.Image = null;
            this.Nama.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.Nama.CustomButton.Name = "";
            this.Nama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nama.CustomButton.TabIndex = 1;
            this.Nama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nama.CustomButton.UseSelectable = true;
            this.Nama.CustomButton.Visible = false;
            this.Nama.Lines = new string[0];
            // 
            // TglLahirDateEdit
            // 
            this.TglLahirDateEdit.EditValue = null;
            this.TglLahirDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TglLahirDateEdit.Properties.Appearance.Options.UseFont = true;
            // 
            // kelaminMTxt
            // 
            // 
            // 
            // 
            this.kelaminMTxt.CustomButton.Image = null;
            this.kelaminMTxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.kelaminMTxt.CustomButton.Name = "";
            this.kelaminMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kelaminMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kelaminMTxt.CustomButton.TabIndex = 1;
            this.kelaminMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kelaminMTxt.CustomButton.UseSelectable = true;
            this.kelaminMTxt.CustomButton.Visible = false;
            this.kelaminMTxt.Lines = new string[0];
            // 

            // 
            // ProsedurMasukMTxt
            // 
            // 
            // 
            // 
            this.ProsedurMasukMTxt.CustomButton.Image = null;
            this.ProsedurMasukMTxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.ProsedurMasukMTxt.CustomButton.Name = "";
            this.ProsedurMasukMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProsedurMasukMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProsedurMasukMTxt.CustomButton.TabIndex = 1;
            this.ProsedurMasukMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProsedurMasukMTxt.CustomButton.UseSelectable = true;
            this.ProsedurMasukMTxt.CustomButton.Visible = false;
            this.ProsedurMasukMTxt.Lines = new string[0];
            // 
            // PenjaminMTxt
            // 
            // 
            // 
            // 
            this.PenjaminMTxt.CustomButton.Image = null;
            this.PenjaminMTxt.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.PenjaminMTxt.CustomButton.Name = "";
            this.PenjaminMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PenjaminMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PenjaminMTxt.CustomButton.TabIndex = 1;
            this.PenjaminMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PenjaminMTxt.CustomButton.UseSelectable = true;
            this.PenjaminMTxt.CustomButton.Visible = false;
            this.PenjaminMTxt.Lines = new string[0];
            // 
            // KelasMTxt
            // 
            // 
            // 
            // 
            this.KelasMTxt.CustomButton.Image = null;
            this.KelasMTxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.KelasMTxt.CustomButton.Name = "";
            this.KelasMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KelasMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KelasMTxt.CustomButton.TabIndex = 1;
            this.KelasMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KelasMTxt.CustomButton.UseSelectable = true;
            this.KelasMTxt.CustomButton.Visible = false;
            this.KelasMTxt.Lines = new string[0];
            // 
            // RuangRawatMTxt
            // 
            // 
            // 
            // 
            this.RuangRawatMTxt.CustomButton.Image = null;
            this.RuangRawatMTxt.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.RuangRawatMTxt.CustomButton.Name = "";
            this.RuangRawatMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RuangRawatMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RuangRawatMTxt.CustomButton.TabIndex = 1;
            this.RuangRawatMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RuangRawatMTxt.CustomButton.UseSelectable = true;
            this.RuangRawatMTxt.CustomButton.Visible = false;
            this.RuangRawatMTxt.Lines = new string[0];
            // 
            // KamarMTxt
            // 
            // 
            // 
            // 
            this.KamarMTxt.CustomButton.Image = null;
            this.KamarMTxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.KamarMTxt.CustomButton.Name = "";
            this.KamarMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KamarMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KamarMTxt.CustomButton.TabIndex = 1;
            this.KamarMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KamarMTxt.CustomButton.UseSelectable = true;
            this.KamarMTxt.CustomButton.Visible = false;
            this.KamarMTxt.Lines = new string[0];
            // 
            // TempatTidurMTxt
            // 
            // 
            // 
            // 
            this.TempatTidurMTxt.CustomButton.Image = null;
            this.TempatTidurMTxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.TempatTidurMTxt.CustomButton.Name = "";
            this.TempatTidurMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TempatTidurMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TempatTidurMTxt.CustomButton.TabIndex = 1;
            this.TempatTidurMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TempatTidurMTxt.CustomButton.UseSelectable = true;
            this.TempatTidurMTxt.CustomButton.Visible = false;
            this.TempatTidurMTxt.Lines = new string[0];
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.AsalPoliMTxt.CustomButton.Image = null;
            this.AsalPoliMTxt.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.AsalPoliMTxt.CustomButton.Name = "";
            this.AsalPoliMTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AsalPoliMTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AsalPoliMTxt.CustomButton.TabIndex = 1;
            this.AsalPoliMTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AsalPoliMTxt.CustomButton.UseSelectable = true;
            this.AsalPoliMTxt.CustomButton.Visible = false;
            this.AsalPoliMTxt.Lines = new string[0];
            // 
            // FInfopasienRegistrasiRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FInfopasienRegistrasiRI";
            this.Load += new System.EventHandler(this.FInfopasienRegistrasiRI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TglLahirDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void FInfopasienRegistrasiRI_Load(object sender, EventArgs e)
        {

        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                registrasiruangrawat regruangrawat = new registrasiruangrawat
                {
                    registrasiruangrawatid = -1,
                    registrasiid = this.vregistrasiruangrawatrjrd.registrasiid,
                    tglmasukruangan = (TglRegistrasiDateEdit.EditValue != null) ? (DateTime)TglRegistrasiDateEdit.EditValue : DateTime.Parse(null),
                    kelasid = this.listtempattidurrawatinap.kelasid,
                    ruangrawatid = this.listtempattidurrawatinap.ruangrawatid,
                    kamarid = this.listtempattidurrawatinap.kamarid,
                    tempattidurid = this.listtempattidurrawatinap.tempattidurid,
                    loginappid = (short)(-1),
                    stsregistrasiid = Helper.Stsregistrasi.stsregistrasiid

                };

                tempattidur tt = new tempattidur
                {
                    tempattidurid = this.listtempattidurrawatinap.tempattidurid,
                    tempattidurisi = 1
                };

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah data registrasi Rawat Inap berikut akan diregistrasikan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    var result = AddRegistrasiRuangRawat(regruangrawat,tt);
                    if (result != -99)
                    {
                        
                        Helper.CommonFuncControl.CloseAllFormInPanel(ref pnlContent);

                        pnlContent.Controls.Clear();
                        //fDashboard myForm = new fDashboard();
                        FListRegistrasiRI myForm = new FListRegistrasiRI(ref this.pnlContent);
                        myForm.TopLevel = false;
                        myForm.AutoScroll = true;
                        //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                        pnlContent.Controls.Add(myForm);
                        myForm.Dock = DockStyle.Fill;
                        myForm.Show();

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Proses registrasi gagal dilakukan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FListAsalRegistrasi myForm = new FListAsalRegistrasi(ref this.pnlContent, ref listtempattidurrawatinap);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nrepositoryItemButtonRegister_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
