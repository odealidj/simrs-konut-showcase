using DevExpress.XtraReports.UI;
using SIMRS.DESKTOP.FrontEnd.Kasir;
using SIMRS.DESKTOP.Template.Report.Kasir;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Kasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm.Kasir
{
    public partial class FBayar : MetroFramework.Forms.MetroForm
    {
        private IList<v_pelunasan> v_Pelunasans = null;

        protected Panel pnlContent;
        protected v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat;
        protected IList<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats;
        protected IList<v_pelayananpasien_rincian_not_alamat> v_Pelayananpasien_Rincian_Not_Alamats;
        protected IList<pelayananpasienpelunasan> Listpelayananpasienpelunasan;
        protected int indexSelectedRowFromSender;

        #region private methode 

        public string AddStrukPelunasan(strukpelayanan _strukpelayanan, IList<pelayananpasienpelunasan> _listpelayananpasienpelunasan,
            IList<short> listtempattidurid,
            short registrasiid, short stsmasukkeluarid, DateTime tglkeluar, DateTime jamkeluar)
        {
            try
            {
                using (var service = new KasirServices())
                {
                    var result = service.InsertPelunasan (_strukpelayanan, _listpelayananpasienpelunasan, listtempattidurid,registrasiid,stsmasukkeluarid, tglkeluar,jamkeluar);
                    if ((string.IsNullOrEmpty( result.Item1 )) && (string.IsNullOrEmpty(result.Item2)))
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item1+"\n" + result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return string.Empty;
                    }
                    else
                    {
                        
                        return result.Item1 + "\n" + result.Item2;

                    }
                }
            }

            catch (Exception ex)
            {
                
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ex.Message;
            }
        }

        #endregion

        public FBayar()
        {
            InitializeComponent();
        }

        public FBayar(ref Panel pnlContent,
            ref v_pelayananpasien_distinct_from_not_alamat v_Pelayananpasien_Distinct_From_Not_Alamat,
            List<v_pelayananpasien_distinct_from_not_alamat> v_Pelayananpasien_Distinct_From_Not_Alamats,
            List<v_pelayananpasien_rincian_not_alamat> v_Pelayananpasien_Rincian_Not_Alamats,
            int indexSelectedRowFromSender)
        {
            InitializeComponent();

            this.Text = "Pelunasan";
            this.pnlContent = pnlContent;
            this.v_Pelayananpasien_Distinct_From_Not_Alamat = v_Pelayananpasien_Distinct_From_Not_Alamat;
            this.v_Pelayananpasien_Distinct_From_Not_Alamats = v_Pelayananpasien_Distinct_From_Not_Alamats;
            this.v_Pelayananpasien_Rincian_Not_Alamats = v_Pelayananpasien_Rincian_Not_Alamats;
            this.indexSelectedRowFromSender = indexSelectedRowFromSender;

            lblSelect.Text = string.Format("Noregistrasi: {0}, NoRM: {1}, Nama Pasien:{2}, Kelamin:{3}, Penjamin:{4}", this.v_Pelayananpasien_Distinct_From_Not_Alamat.noregistrasi,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.nama,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.jknm,
                this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasiennm);


            decimal grandtotal = this.v_Pelayananpasien_Rincian_Not_Alamats.Sum(x => x.totalbiaya).Value;
            totalBiayaLbl.Text = grandtotal.ToString("#,##");

            if ((this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasienid==1) ||
                    (this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasienid == 2))
            {
                jmlBayarLbl.Text = totalBiayaLbl.Text;
            }
            else
            {
                jmlBayarLbl.Text = "0";
            }

            this.BayartextEdit.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (BayartextEdit.Enabled == false) return;

                if (string.IsNullOrEmpty(BayartextEdit.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pelunasan tidak valid\n Isian bayar tidak boleh kosong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BayartextEdit.Focus();
                    return;
                }

                decimal jmlbayar = decimal.Parse(  jmlBayarLbl.Text.Replace(".", ""));
                decimal bayar = decimal.Parse( BayartextEdit.Text.Replace(".", ""));

                if (bayar<jmlbayar)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pelunasan tidak valid\n Pembayaran yang diinputkan harus lebih besar dari jmulah bayar", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BayartextEdit.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Apakah tagihan pasien berikut akan dilakukan pelunasan ?,\nSilahkan periksa kembali.","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                

                strukpelayanan struk = new strukpelayanan
                {
                    strukpelayananid = -1,
                    strukpelayanannostruk = this.v_Pelayananpasien_Distinct_From_Not_Alamat.noregistrasi + "-" + this.v_Pelayananpasien_Distinct_From_Not_Alamat.nocm.Replace("-",""),
                    strukpelayanantgl = DateTime.Now.Date,
                    strukpelayananjam = DateTime.Now,
                    strukpelayanannokw = string.Empty,
                    grandtotalbiaya = decimal.Parse(totalBiayaLbl.Text),
                    grandtotalbayar = decimal.Parse(jmlBayarLbl.Text),
                    grandtotalpiutang = decimal.Parse(totalBiayaLbl.Text) - decimal.Parse(jmlBayarLbl.Text),
                    grandtotalbebas = 0,
                    loginappid = (Helper.loginapp.loginappid==0)?(short)-1: (short)Helper.loginapp.loginappid
                };

                //p.Add("@pelayananpasienpelunasanid", pelayanan.pelayananpasienpelunasanid);
                //p.Add("@strukpelayananid", strukpelayananid);
                //p.Add("@totalbayar", pelayanan.totalbayar);
                //p.Add("@totalpiutang", pelayanan.totalpiutang);
                //p.Add("@totalbebas", pelayanan.totalbebas);
                //p.Add("@loginappid", (pelayanan.loginappid == -1) ? null : pelayanan.loginappid);

                pelayananpasienpelunasan plunas = null;
                this.Listpelayananpasienpelunasan = new List<pelayananpasienpelunasan>();
                decimal pbayar, ppiutang,pbebas = 0;
                foreach (var item in this.v_Pelayananpasien_Rincian_Not_Alamats)
                {
                    if ((this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasienid==1) || (this.v_Pelayananpasien_Distinct_From_Not_Alamat.penjaminpasienid == 2))
                    {
                        pbayar = (item.totalbiaya==null)? 0: item.totalbiaya.Value;
                        ppiutang = 0;
                        
                    }
                    else
                    {
                        pbayar = 0;
                        ppiutang = (item.totalbiaya == null) ? 0 : item.totalbiaya.Value;
                    }

                    plunas = new pelayananpasienpelunasan
                    {
                        pelayananpasienpelunasanid = item.pelayananpasienid,
                        strukpelayananid = -1,
                        totalbayar = pbayar,
                        totalpiutang = ppiutang,
                        totalbebas = pbebas
                    };

                    Listpelayananpasienpelunasan.Add(plunas);
                };


                List<short> listtempattidurid = this.v_Pelayananpasien_Rincian_Not_Alamats.Select(x => x.tempattidurid.Value).Distinct().ToList();




                var resultAddLunas = AddStrukPelunasan(struk, Listpelayananpasienpelunasan, listtempattidurid, 
                    this.v_Pelayananpasien_Distinct_From_Not_Alamat.registrasiid,0,DateTime.Now.Date, DateTime.Now);
                
                if (string.IsNullOrEmpty(resultAddLunas))
                {
                    //view Laporan
                    BayartextEdit.Enabled = false;
                }
                else
                {
                    BayartextEdit.Enabled = true;
                    MetroFramework.MetroMessageBox.Show(this, resultAddLunas + "\n" + this.Name + "\nbtnOK_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnOK_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BayartextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FBayar_Shown(object sender, EventArgs e)
        {
            BayartextEdit.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {

                if (BayartextEdit.Enabled == false)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    TFListRegistrasi myForm = new TFListRegistrasi(ref this.pnlContent);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
                else
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FRincianTindakanKasirBL myForm = new FRincianTindakanKasirBL(ref this.pnlContent,
                        ref this.v_Pelayananpasien_Distinct_From_Not_Alamat,
                        this.v_Pelayananpasien_Distinct_From_Not_Alamats.ToList(),
                        this.v_Pelayananpasien_Rincian_Not_Alamats.ToList(),
                        this.indexSelectedRowFromSender);
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    //myForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnNext_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BayartextEdit_EnabledChanged(object sender, EventArgs e)
        {
            if (BayartextEdit.Enabled==false)
            {
                btnCancel.Text = "Exit";
            }
            else
            {
                btnCancel.Text = "Cancel";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.v_Pelunasans == null) return;
                RincianTransaksiPasienRpt report = new RincianTransaksiPasienRpt(this.v_Pelunasans);
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }

                report.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nbtnPrint_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
