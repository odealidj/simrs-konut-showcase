using DevExpress.XtraGrid;
using SIMRS.DESKTOP.Template.frm.Kasir;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Kasir;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.Kasir
{
    public  class FRincianTindakanKasirBL : FRincianTindakanKasir
    {
        protected v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat;

        protected IList<v_pelayananpasien_rincian_not_alamat> v_Pelayananpasien_Rincian_Not_Alamats = null;
        protected IList<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats = null;


        #region private method control

        private async void LoadAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(int registrasiid)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = await service.SelectAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(registrasiid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gc.DataSource = result.Item1;
                        gv.ClearSelection();
                        gv.FocusedRowHandle = 0;
                        gv.SelectRow(0);
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(int registrasiid)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = service.SelectAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(registrasiid);
                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.v_Pelayananpasien_Rincian_Not_Alamats= null;
                        return;
                    }
                    else
                    {
                        this.v_Pelayananpasien_Rincian_Not_Alamats = result.Item1.ToList();
                        
                    }
                }
            }

            catch (Exception ex)
            {
                this.v_Pelayananpasien_Rincian_Not_Alamats = null;
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion private method control

        #region constructor
        public FRincianTindakanKasirBL() : base ()
        {

        }

        public FRincianTindakanKasirBL(ref Panel pnlContent, 
            ref v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat) : base(ref pnlContent)
        {
            this.Text = "Rincian Tindakan";
            this.v_Pelayananpasien_Distinct_From_Not_Alamat = v_Pelayananpasien_Distinct_From_Not_Alamat;
            lblSelect.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama Pasien:{2}, Kelamin:{3}, Penjamin:{4}", this.v_Pelayananpasien_Distinct_From_Not_Alamat.noregistrasi,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nama,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasiennm);

            
        }

        public FRincianTindakanKasirBL(ref Panel pnlContent,
            ref v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat,
            List<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats,
            int indexSelectedRowFromSender) : base(ref pnlContent)
        {

            //constructor

            this.Text = "Rincian Tindakan";
            this.v_Pelayananpasien_Distinct_From_Not_Alamat = v_Pelayananpasien_Distinct_From_Not_Alamat;
            lblSelect.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama Pasien:{2}, Kelamin:{3}, Penjamin:{4}", this.v_Pelayananpasien_Distinct_From_Not_Alamat.noregistrasi,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nama,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasiennm);

            this.v_Pelayananpasien_Distinct_From_Not_Alamats = v_Pelayananpasien_Distinct_From_Not_Alamats;
            this.v_Pelayananpasien_Rincian_Not_Alamats = null;
            this.indexSelectedRowFromSender = indexSelectedRowFromSender;

            ststransaksi.Text = "Belum pelunasan";
            ststransaksi.ForeColor = Color.Red;

            totalBiayaLbl.ForeColor = Color.Red;
            bayarLbl.ForeColor = Color.Red;
        }

        public FRincianTindakanKasirBL(ref Panel pnlContent,
            ref v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat,
            List<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats,
            List<v_pelayananpasien_rincian_not_alamat> v_Pelayananpasien_Rincian_Not_Alamats,
            int indexSelectedRowFromSender) : base(ref pnlContent)
        {
            //contructor back from bayar
            this.Text = "Rincian Tindakan";
            this.v_Pelayananpasien_Distinct_From_Not_Alamat = v_Pelayananpasien_Distinct_From_Not_Alamat;
            lblSelect.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama Pasien:{2}, Kelamin:{3}, Penjamin:{4}", this.v_Pelayananpasien_Distinct_From_Not_Alamat.noregistrasi,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nama,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasiennm);

            this.v_Pelayananpasien_Distinct_From_Not_Alamats = v_Pelayananpasien_Distinct_From_Not_Alamats;
            this.v_Pelayananpasien_Rincian_Not_Alamats = v_Pelayananpasien_Rincian_Not_Alamats;
            this.indexSelectedRowFromSender = indexSelectedRowFromSender;

            ststransaksi.Text = "Belum pelunasan";
            ststransaksi.ForeColor = Color.Red;

            totalBiayaLbl.ForeColor = Color.Red;
            bayarLbl.ForeColor = Color.Red;
        }

        #endregion constructor

        protected override void FRincianTindakanKasir_Shown(object sender, EventArgs e)
        {
            try
            {
                //LoadAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(this.v_Pelayananpasien_Distinct_From_Not_Alamat.registrasiid);
                if (this.v_Pelayananpasien_Rincian_Not_Alamats == null)
                {
                    LoadAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(this.v_Pelayananpasien_Distinct_From_Not_Alamat.registrasiid);
                }
                if (this.v_Pelayananpasien_Distinct_From_Not_Alamat != null)
                {
                    if (System.IO.File.Exists(Helper.CommonFunc.basePathImageIdentitasPasien() + this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm + ".png"))
                    {
                        PicPictureEdit.Image = Image.FromFile(Helper.CommonFunc.basePathImageIdentitasPasien() + this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm + ".png");
                    }
                    else
                    {
                        if (this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm.Trim().ToUpper() == "L")
                        {

                            if (System.IO.File.Exists(Helper.CommonFunc.basePathImageIdentitasPasien() + "facl.png"))
                            {
                                PicPictureEdit.Image = Image.FromFile(Helper.CommonFunc.basePathImageIdentitasPasien() + "facl.png");
                            }
                            else
                            {
                                PicPictureEdit.Image = null;
                            }
                        }
                        else
                        {
                            if (System.IO.File.Exists(Helper.CommonFunc.basePathImageIdentitasPasien() + "facp.png"))
                            {
                                PicPictureEdit.Image = Image.FromFile(Helper.CommonFunc.basePathImageIdentitasPasien() + "facp.png");
                            }
                            else
                            {
                                PicPictureEdit.Image = null;
                            }
                        }

                    }
   
                }

                gc.DataSource = this.v_Pelayananpasien_Rincian_Not_Alamats;
                gv.ClearSelection();
                gv.FocusedRowHandle = 0;
                gv.SelectRow(0);

                TimeSpan timespan = DateTime.Now.Date.Subtract(this.v_Pelayananpasien_Distinct_From_Not_Alamat.tglmasuk.Value);
                lamaHariTxt.Text  = string.Format("{0} Hari",  ((int)timespan.TotalDays).ToString());

                ////GridGroupSummaryItem item = new GridGroupSummaryItem();
                ////item.FieldName = "totalbiaya";
                ////item.ShowInGroupColumnFooter = gv.Columns["totalbiaya"];
                ////item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                ////totalBiayaLbl.Text = item.SummaryValue.ToString();
                ////item.DisplayFormat = "{0:#,##}";
                ////gv.GroupSummary.Add(item);
                ///

                List<string> distinct = this.v_Pelayananpasien_Rincian_Not_Alamats.Select(x => x.pelayananmediknm).Distinct().ToList();

                var jenisrawat = string.Empty;
                foreach (var item in distinct)
                {
                    if (jenisrawat.Length==0)
                    {
                        jenisrawat = item.ToString();
                    }
                    else
                    {
                        jenisrawat = jenisrawat +", "+ item.ToString();
                    }
                }
                jenisRawatTxt.Text = jenisrawat;

                List<string> kelasdistinct = this.v_Pelayananpasien_Rincian_Not_Alamats.Select(x => x.kelasuraian).Distinct().ToList();
                var kelasperawatan = string.Empty;
                foreach (var item in kelasdistinct)
                {
                    if (kelasperawatan.Length == 0)
                    {
                        kelasperawatan = item.ToString();
                    }
                    else
                    {
                        kelasperawatan = kelasperawatan + ", " + item.ToString();
                    }
                }
                kelasRawatTxt.Text = kelasperawatan;

                decimal grandtotal = this.v_Pelayananpasien_Rincian_Not_Alamats.Sum(x => x.totalbiaya).Value;
                totalBiayaLbl.Text = grandtotal.ToString("#,##");

                ////decimal value = 0;
                ////for (int i = 0; i < gv.DataRowCount; i++)
                ////{
                ////    value = value + (decimal)gv.GetRowCellValue(i, "totalbiaya");
                    
                ////}
                ////totalBiayaLbl.Text = value.ToString("#,##");



            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nFRincianTindakanKasir_Shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

            this.pnlContent.Controls.Clear();
            //fDashboard myForm = new fDashboard();
            FListRegistrasi myForm = new FListRegistrasi(ref this.pnlContent,this.v_Pelayananpasien_Distinct_From_Not_Alamats.ToList()
                ,this.indexSelectedRowFromSender);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.pnlContent.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               

                Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                this.pnlContent.Controls.Clear();
                //fDashboard myForm = new fDashboard();
                FBayar myForm = new FBayar(ref this.pnlContent,
                    ref this.v_Pelayananpasien_Distinct_From_Not_Alamat,
                    this.v_Pelayananpasien_Distinct_From_Not_Alamats.ToList(),
                    this.v_Pelayananpasien_Rincian_Not_Alamats.ToList(),
                    indexSelectedRowFromSender);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                this.pnlContent.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnAdd_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
