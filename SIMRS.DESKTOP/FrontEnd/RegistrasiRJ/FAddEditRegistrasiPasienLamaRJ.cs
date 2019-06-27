using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Model.view;
using SIMRS.Services.FrontEnd.Registrasi;
using SIMRS.DESKTOP.Helper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS.Services;
using SIMRS.Services.FrontEnd;
using SIMRS.DESKTOP.Template.Report.Registrasi;
using DevExpress.XtraReports.UI;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FAddEditRegistrasiPasienLamaRJ : TFAddEditRegistrasiPasien
    {
        protected string nocm;
        protected short registrasiid = -1;
        protected alamatpasien Alamatpasien;
        protected suratrujukanpuskesmas Suratrujukanpuskesmas;
        protected identitaspasienbpjs Identitaspasienbpjs;
        protected penjaminpasienbpjs Penjaminpasienbpjs;
        protected penjaminpasiendirisendiri Penjaminpasiendirisendiri;
        protected penjaminpasienkeluarga Penjaminpasienkeluarga;
        protected perujuk Perujuk;
        protected stspasienbaru Stspasienbaru;
        protected identitasdiri Identitasdiri;
        protected identitasdiri Identitasdirikeluarga;

        #region private method
        protected (string, string) AddRegistrasiPasienLama(registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasiendirisendiri _penjaminpasiendirisendiri,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin)
        {
            using (var service = new RegistrasiPasienLamaServices())
            {
                var result = service.InsertPasienLama(_registrasi, _registrasiruangrawat, _penjaminpasiendirisendiri, 
                    _vpelayananpasienkarcis, _statepenjamin);
                if (!string.IsNullOrEmpty(result.Item2))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item2);
                }
                else
                    return (result.Item1, result.Item2);

            }
        }

        protected (string, string) AddRegistrasiPasienLama(registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasienkeluarga _penjaminpasienkeluarga, v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin)
        {
            using (var service = new RegistrasiPasienLamaServices())
            {
                var result = service.InsertPasienLama(_registrasi, _registrasiruangrawat, _penjaminpasienkeluarga,
                    _vpelayananpasienkarcis, _statepenjamin);
                if (!string.IsNullOrEmpty(result.Item2))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item2);
                }
                else
                    return (result.Item1, result.Item2);

            }
        }

        protected (string, string) AddRegistrasiPasienLama(registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            identitaspasienbpjs _identitaspasienbpjs, suratrujukanpuskesmas _suratrujukanpuskesmas, penjaminpasienbpjs _penjaminpasienbpjs,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin)
        {
            using (var service = new RegistrasiPasienLamaServices())
            {
                var result = service.InsertPasienLama(_registrasi, _registrasiruangrawat, _identitaspasienbpjs, _suratrujukanpuskesmas, _penjaminpasienbpjs, 
                    _vpelayananpasienkarcis, _statepenjamin);
                if (!string.IsNullOrEmpty(result.Item2))
                {
                    //MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (string.Empty, result.Item2);
                }
                else
                    return (result.Item1, result.Item2);

            }
        }
        #endregion

        #region private method control

        protected async void FirtOrDefaultIdentitasPasienByNocmAsyncService(string nocm)
        {
            try
            {
                using (var service = new RegistrasiPasienLamaServices())
                {
                    var result = await service.FirtOrDefaultIdentitasPasienByNocmAsync(nocm);

                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var data = result.Item1;
                        if (data != null)
                        {
                            SapaanIPLookUpEdit.EditValue = data.sapaanid;
                            NoRMIP.Text = data.nocm;
                            NamaIP.Text = data.nama;
                            TempatLahirIP.Text = data.tempatlahir;
                            TglLahirIPDateEdit.EditValue = data.tanggallahir;
                            KelaminIPLookUpEdit.EditValue = data.jkid;
                            GolDarahIPLookUpEdit.EditValue = data.goldarahid;
                            NoTelpIP.Text = data.notelp;
                            NoHPIP.Text = data.nohp;
                            StsNikahIPLookUpEdit.EditValue = data.stspernikahanid;
                            PendidikanIPLookUpEdit.EditValue = data.pendidikanid;
                            PekerjaanIPLookUpEdit.EditValue = data.pekerjaanid;
                            AgamaIPLookUpEdit.EditValue = data.agamaid;
                            SukuIPLookUpEdit.EditValue = data.sukuid;
                            
                        }
                        else
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void FirtOrDefaultIdentitasPasienAlamatPasienByNocmAsyncService(string nocm)
        {
            try
            {
                using (var service = new RegistrasiPasienLamaServices())
                {
                    var result = await service.FirtOrDefaultIdentitaspasienAlamatpasienByNocmAsync(nocm);

                    if (result.Item3 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var data = result.Item1;
                        if (data != null)
                        {
                            SapaanIPLookUpEdit.EditValue = data.sapaanid;
                            NoRMIP.Text = data.nocm;
                            NamaIP.Text = data.nama;
                            TempatLahirIP.Text = data.tempatlahir;
                            TglLahirIPDateEdit.EditValue = data.tanggallahir;
                            KelaminIPLookUpEdit.EditValue = data.jkid;
                            GolDarahIPLookUpEdit.EditValue = data.goldarahid;
                            NoTelpIP.Text = data.notelp;
                            NoHPIP.Text = data.nohp;
                            StsNikahIPLookUpEdit.EditValue = data.stspernikahanid;
                            PendidikanIPLookUpEdit.EditValue = data.pendidikanid;
                            PekerjaanIPLookUpEdit.EditValue = data.pekerjaanid;
                            AgamaIPLookUpEdit.EditValue = data.agamaid;
                            SukuIPLookUpEdit.EditValue = data.sukuid;
                            
                        }
                        else
                        {
                            Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;

                        var dataAlamat = result.Item2;
                        if (dataAlamat != null)
                        {
                            Alamatpasien = new alamatpasien
                            {
                                alamatpasienid = dataAlamat.alamatpasienid,
                                nocm = dataAlamat.nocm,
                                alamat = dataAlamat.alamat,
                                kecid = dataAlamat.kecid,
                                keldesaid = dataAlamat.keldesaid,
                                rwid = dataAlamat.rwid,
                                rtid = dataAlamat.rtid,
                                kodepos = dataAlamat.kodepos,
                                kotakabid = dataAlamat.kotakabid
                            };

                            
                            AlamatIP.Text = dataAlamat.alamat;
                            KecIPLookUpEdit.EditValue = dataAlamat.kecid;
                            KelIPLookUpEdit.EditValue = dataAlamat.keldesaid;
                            RTRWIPLookUpEdit.EditValue = (dataAlamat.rtid!=null)? (dataAlamat.rtid+"/"+dataAlamat.rwid):null ;
                        }
                        else
                        {
                            this.Alamatpasien = null;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async void FirtOrDefaultPenjaminByNocmAsyncService(string nocm)
        {
            try
            {
                using (var service = new RegistrasiPasienLamaServices())
                {
                    var result = await service.FirstOrDefaultPenjaminByNoRMAsync(nocm);

                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        penjaminLookUpEdit.EditValue = result.Item1.penjaminpasienid;
                    }
                }
            }

            catch (Exception ex)
            {
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void FirstOrDefaultIdentitaspasienbpjsAsync(identitaspasienbpjs obj)
        {
            try
            {
                using (var service = new RegistrasiPasienLamaServices())
                {
                    var result = await service.FirstOrDefaultIdentitaspasienbpjsAsync(obj);

                    if (result.Item2 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var data = result.Item1;
                        if (data != null)
                        {
                            NoPesertaKartuBPJS.Text = data.nopeserta;
                            NamaPesertaKartuBPJS.Text = data.namapeserta;
                            FaskesKartuBPJS.Text = data.faskes;
                            KelasKartuBPJSLookUpEdit.EditValue = data.kelasbpjsid;
                            JKKartuBPJSLookUpEdit.EditValue = data.jkid;
                            TempatLahirKartuBPJS.Text = data.tempatlahir;
                            TglLahirKartuBPJSDateEdit.EditValue = data.tanggallahir;
                            AlamatKartuBPJSTextBox.Text = data.alamat;
                            KecKartuBPJSlookUpEdit.EditValue = data.kecid;
                            KelKartuBPJSLookUpEdit.EditValue = data.keldesaid;

                        }
                        else
                        {
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstOrDefaultPerujuk(short puskesmasid)
        {
            try
            {
                using (var service = new PerujukServices())
                {
                    var result = service.GetPerujukByPuskesmasId(puskesmasid);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {
                            AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue = data.perujukid;
                            this.Perujuk = new perujuk
                            {
                                perujukid = data.perujukid
                            };
                        }
                        else
                        {
                            this.Perujuk = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstOrDefaultIdentitasdiri(identitasdiri Identitasdiri)
        {
            try
            {
                using (var service = new IdentitasdiriServices())
                {
                    var result = service.FirstOrDefaultIdentitasdiri (Identitasdiri);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {
                            IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue = data.identitasdiriid;
                            IdentitasdiriPenjaminDiriSendiriLookUpEdit.Text = data.identitasdirinm;
                            this.Identitasdiri  = new identitasdiri
                            {
                                identitasdiriid = data.identitasdiriid,
                                identitasdirinm = data.identitasdirinm,
                                identitasdirists = data.identitasdirists
                            };

                            IdentitasdiriPenjaminDiriSendiriLookUpEdit.Refresh();
                        }
                        else
                        {
                            this.Identitasdiri = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        //data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void FirstOrDefaultIdentitasdirikeluarga(identitasdiri Identitasdiri)
        {
            try
            {
                using (var service = new IdentitasdiriServices  ())
                {
                    var result = service.FirstOrDefaultIdentitasdiri (Identitasdiri);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {
                            IdentitasdiriPenjaminKLookUpEdit.EditValue = data.identitasdiriid;
                            this.Identitasdirikeluarga = new identitasdiri
                            {
                                identitasdiriid = data.identitasdiriid,
                                identitasdirinm = data.identitasdirinm,
                                identitasdirists = data.identitasdirists
                            };

                           

                        }
                        else
                        {
                            this.Identitasdirikeluarga = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstOrDefaultSuratRujukanPuskesmas(suratrujukanpuskesmas obj)
        {
            try
            {
                using (var service = new SuratrujukanpuskesmasServices())
                {
                    var result = service.Get(obj);

                    if (result== null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {

                            FirstOrDefaultPerujuk(data.puskesmasid.Value);

                            this.Suratrujukanpuskesmas = new suratrujukanpuskesmas
                            {
                                suratrujukanpuskesmasid = data.suratrujukanpuskesmasid
                            };

                            PuskesmasSrtRujukanBPJSLookUpEdit.EditValue = data.puskesmasid;
                            //var row = PuskesmasSrtRujukanBPJSLookUpEdit.Properties.GetDataSourceValue("puskesmasid", 0);
                            //NoPuskesmasSrtRujukanBPJS.Text = (PuskesmasSrtRujukanBPJSLookUpEdit.Properties.GetDataSourceValue("puskesmasno",)
                            TglRujukanSrtRujukanBPJSDateEdit.EditValue = data.suratrujukanpuskesmastgl;
                            NoRujukanSrtRujukanBPJS.Text = data.suratrujukanpuskesmasno;
                            TujuanSrtRujukanBPJSLookUpEdit.EditValue = data.ruangrawatid;
                            DiagnosaAwalSrtRujukanBPJS.Text = data.icdxsubkategoriid;
                            icdxindoGridControl.Visible = false;
                            icdxengGridControl.Visible = false;
                            icdxindoDataNavigator.Visible = false;
                            DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue = data.icdxpuskesmasid;
                            TelahDibreikanSrtRujukanBPJS.Text = data.suratrujukanpuskesmastelahdiberikan;

                        }
                        else
                        {
                            this.Suratrujukanpuskesmas = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstOrDefaultPenjaminpasienbpjs(penjaminpasienbpjs obj)
        {
            try
            {
                using (var service = new PenjaminpasienbpjsServices())
                {
                    var result = service.Get(obj);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {
                            this.Penjaminpasienbpjs = new penjaminpasienbpjs
                            {
                                penjaminpasienbpjsid = data.penjaminpasienbpjsid,
                                nosep = data.nosep,
                                tglsep = data.tglsep,
                                ruangrawatid =data.ruangrawatid,
                                icdxsubkategoriid = data.icdxsubkategoriid,
                                icdxpuskesmasid = data.icdxpuskesmasid
                            };
                                
                            NosepSEPBPJS.Text = data.nosep;
                            TglSEPBPJSDateEdit.EditValue = data.tglsep;
                            TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue = data.ruangrawatid;
                            DiagnosaAwalSEPBPJSButtonEdit.EditValue = data.icdxsubkategoriid;
                            DiagnosaAltMTxt.Text = data.icdxpuskesmasid.ToString();
                        }
                        else
                        {
                            this.Penjaminpasienbpjs = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstOrDefaultPenjaminpasiendirisendiri(penjaminpasiendirisendiri obj)
        {
            try
            {
                using (var service = new PenjaminpasiendirisendiriServices ())
                {
                    var result = service.FirstOrDefaultPenjaminpasiendirisendiri(obj);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {

                            //if (data.identitasdiriid!=null)
                            //{
                            //    FirstOrDefaultIdentitasdiri(new identitasdiri { identitasdiriid = data.identitasdiriid.Value });
                            //}
                            NoIdentitasPenjaminDiriSendiri.Text = data.nomoridentitas;
                            IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue = data.identitasdiriid;//  .penjaminpasiendirisendiriid;
                            KelaminDiriSendiriLookUpEdit.EditValue = data.jkid;
                            KecDiriSendiriLookUpEdit.EditValue = data.kecid;
                            KelDiriSendiriLookUpEdit.EditValue = data.keldesaid;
                            //RTRWDiriSendiriLookUpEdit.EditValue = data.rtid+data.rw

                        }
                        else
                        {
                            this.Penjaminpasienbpjs = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstOrDefaultPenjaminpasienkeluarga(penjaminpasienkeluarga obj)
        {
            try
            {
                using (var service = new PenjaminpasienkeluargaServices())
                {
                    var result = service.FirstOrDefaultPenjaminpasienkeluarga(obj);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {
                            //if (data.identitasdiriid != null)
                            //{
                            //    FirstOrDefaultIdentitasdirikeluarga (new identitasdiri { identitasdiriid = data.identitasdiriid.Value });
                            //}

                            HubPenjaminKLookUpEdit.EditValue = data.hubkeluargaid;
                            IdentitasdiriPenjaminKLookUpEdit.EditValue = data.penjaminpasienkeluargaid;
                            IdentitasdiriPenjaminKLookUpEdit.EditValue = data.identitasdiriid;
                            NoIdentitasPenjaminK.Text = data.nomoridentitas;
                            NamaPenjaminK.Text = data.nama;
                            AlamatPenjaminK.Text = data.alamat;
                            NoHPPenjaminK.Text = data.nohp;
                            NoTelpPenjaminK.Text = data.notelp;
                            JKPenjaminKlookUpEdit.EditValue = data.jkid;
                            KecPenjaminKLookUpEdit.EditValue = data.kecid;
                            KeldesaPenjaminKLookUpEdit.EditValue = data.keldesaid;
                        }
                        else
                        {
                            this.Penjaminpasienbpjs = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected void AddCollectionPanelPasienLamaRJ()
        {
            this.indexPanel = 0;
            //Add panel to list
            listPanel.Clear();
            listPanel.Add(pnlIdentitasPasien);
            listPanel.Add(pnlPenjamin);
            //listPanel.Add(pnlKartuBPJS);
            //listPanel.Add(pnlSuratRujukanBPJS);
            //listPanel.Add(pnlKeluarga);
            //listPanel.Add(pnlDiriSendiri);
            //listPanel.Add(pnlIdentitasPasien);
            listPanel[indexPanel].BringToFront();
        }

        protected void SelectStspasienbaruByRegistrasiId(short registrasiid)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = service.SelectStspasienbaruByRegistrasiId (registrasiid);

                    if (result == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        var data = result;
                        if (data != null)
                        {
                            this.Stspasienbaru = new stspasienbaru
                            {
                                id = data.id,
                                nm = data.nm
                            };

                                                    }
                        else
                        {
                            this.Stspasienbaru = null;
                            //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                        }
                        data = null;
                    }
                }
            }

            catch (Exception ex)
            {
                //Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlIdentitasPasien);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region constructor
        public FAddEditRegistrasiPasienLamaRJ(ref Panel _pnlContent) : base(ref _pnlContent)
        {
            try
            {
                Helper.Stspasienbaru.id = 1;

                this.Text = "Registrasi Pasien Lama";
               

                //AddCollectionPanelPasienLamaRJ();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);

                this.tglMasukDateEdit.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FAddEditRegistrasiPasienLamaRJ(ref Panel _pnlContent, string nocm) : base(ref _pnlContent)
        {
            try
            {
                Helper.Stspasienbaru.id = 1;

                this.Text = "Registrasi Pasien Lama";
                this.nocm = nocm;

                //AddCollectionPanelPasienLamaRJ();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);

                this.tglMasukDateEdit.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FAddEditRegistrasiPasienLamaRJ(ref Panel _pnlContent, ref v_registrasiruangrawat v_Registrasiruangrawat) : base(ref _pnlContent)
        {
            try
            {
                Helper.Stspasienbaru.id = 1;

                this.Text = "Registrasi Pasien Lama";
                this.v_Registrasiruangrawat = v_Registrasiruangrawat;
                this.nocm = this.v_Registrasiruangrawat.nocm;

                //AddCollectionPanelPasienLamaRJ();
                LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);

                this.tglMasukDateEdit.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion constructor 

        protected override void FAddEditRegistrasiPasien_Load(object sender, EventArgs e)
        {
            try
            {
                this.isSave = false;

                //defaultpanelregistrasi();
                defaultpanelSEPBPJS();
                //defaultsetinglookupeditpanelrujukanBPJS();
                defaultpanelrujukanBPJS();
                //defaultsetinglookupeditpanelkartuBPJS();
                defaultpanelkartuBPJS();
                //defaultsetinglookupeditpaneldirisendiri();
                defaultpaneldirisendiri();
                //defautsetinglookupeditpanelkeluarga();
                defautpanelkeluarga();
                //defaultsetinglookupeditpanelidentitaspasien();
                defaultpanelidentitaspasien();
                //defaultsetinglookupeditpanelpoli();
                defaultpanelpoli();


                FirtOrDefaultIdentitasPasienAlamatPasienByNocmAsyncService(this.nocm);

                

                Helper.CommonFuncControl.ReadOnlyControlInWindowsFormPanel(ref this.pnlIdentitasPasien, true);
                LblStepIdentitasPasien.Text = "Step 1";
                lblStepPenjamin.Text = "Step 2";

                //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

                AddCollectionPanelPasienLamaRJ();
                //penjaminLookUpEdit.EditValue = penjaminLookUpEdit.Properties.GetDataSourceValue("penjaminpasienid", 0);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n Constructor FAddEditRegistrasiPasienLamaRJ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void NamaIP_TextChanged(object sender, EventArgs e)
        {
            NamaDiriSendiri.Text = NamaIP.Text;
        }

        protected override void TempatLahirIP_TextChanged(object sender, EventArgs e)
        {
            TempatLahirDiriSendiri.Text = TempatLahirIP.Text;
        }

        protected override void TglLahirIPDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var date = (TglLahirIPDateEdit.EditValue != null) ? (DateTime)TglLahirIPDateEdit.EditValue : DateTime.Now.Date;
                var result = CommonFunc.HitungUmur((short)(date.Year), (short)date.Month, (short)date.Day);
                ThnIP.Text = result.Item1.ToString(); BlnIP.Text = result.Item2.ToString(); HariIP.Text = result.Item3.ToString();

                TglLahirDiriSendiriDateEdit.EditValue = TglLahirIPDateEdit.EditValue;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nTglLahirIPDateEdit_EditValueChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void KelaminIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            KelaminDiriSendiriLookUpEdit.EditValue = KelaminIPLookUpEdit.EditValue;
        }

        protected override void AlamatIP_TextChanged(object sender, EventArgs e)
        {
            ALamatDiriSendiri.Text = AlamatIP.Text;
        }

        protected override void KecIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (KecIPLookUpEdit.EditValue!=null)
                KecDiriSendiriLookUpEdit.EditValue = KecIPLookUpEdit.EditValue;

                GetDataKeldesaByKecIdAsync(KecIPLookUpEdit.EditValue != null ? (short)(KecIPLookUpEdit.EditValue) : short.Parse(null), KelIPLookUpEdit);
                KelIPLookUpEdit.Focus();

                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void KelIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (KelIPLookUpEdit.EditValue!=null)
                KelDiriSendiriLookUpEdit.EditValue = KelIPLookUpEdit.EditValue;

                GetDataRTRWByKeldesaIdAsync(KelIPLookUpEdit.EditValue != null ? (short)(KelIPLookUpEdit.EditValue) : short.Parse(null), RTRWIPLookUpEdit);
                RTRWIPLookUpEdit.Focus();
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void RTRWIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (RTRWIPLookUpEdit.EditValue!=null)
            RTRWDiriSendiriLookUpEdit.EditValue = RTRWIPLookUpEdit.EditValue;
        }

        protected override void PekerjaanIPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            PekerjaanDiriSendiriLookUpEdit.EditValue = PekerjaanIPLookUpEdit.EditValue;
        }

        protected override void NoTelpIP_TextChanged(object sender, EventArgs e)
        {
            NoTelpDiriSendiri.Text = NoTelpIP.Text;
        }

        protected override void NoHPIP_TextChanged(object sender, EventArgs e)
        {
            NoHPDiriSendiri.Text = NoHPIP.Text;
        }

        protected override void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (listPanel.Count == 2)
                {
                    //if (++indexPanel> 1)
                    //{
                    //    indexPanel = 0;
                    //}
                    FirtOrDefaultPenjaminByNocmAsyncService(this.NoRMIP.Text);
                    listPanel[++indexPanel].BringToFront();
                }
                else
                {
                    if (indexPanel < listPanel.Count - 2)
                    {
                        listPanel[++indexPanel].BringToFront();
                    }
                    else
                    {
                        if ((btnNext.Text == "Next") && (indexPanel == listPanel.Count - 2) && (isSave == false))
                        {
                            if (penjaminLookUpEdit.EditValue == null)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih penjamin" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                btnNext_Click(sender, e);
                                penjaminLookUpEdit.Focus();
                                return;
                            }

                            if (string.IsNullOrEmpty(NamaIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input nama pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                return;
                            }

                            if (string.IsNullOrEmpty(AlamatIP.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan input alamat pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (KelaminIPLookUpEdit.EditValue == null)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih jenis kelamin pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (PoliLookUpEdit.EditValue == null)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih tujuan poliklinik" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if ((TglLahirIPDateEdit.EditValue == null) || (TglLahirIPDateEdit.Text == ""))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Silahkan isi tanggal lahir pasien" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (((DateTime)TglLahirIPDateEdit.EditValue).Date > DateTime.Now.Date)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Tgl.Lahir tidak valid,\n Tgl.lahir yang diinput lebih besar dari tgl hari ini" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var jenistarif = FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId((PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                             (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)(-1));

                            switch (this.statepenjamin)
                            {
                                case Services.StatePenjamin.DiriSendiri:
                                    
                                    if (IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue ==null)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Silahkan isi identitas diri sendiri" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        IdentitasdiriPenjaminDiriSendiriLookUpEdit.Focus();
                                        return;
                                    }
                                    if (string.IsNullOrEmpty( NoIdentitasPenjaminDiriSendiri.Text))
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Silahkan isi nomor identitas diri" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        NoIdentitasPenjaminDiriSendiri.Focus();
                                        return;
                                    }
                                    break;

                                case Services.StatePenjamin.BPJS:
                                    if (string.IsNullOrEmpty(NoPesertaKartuBPJS.Text))
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Nomor Peserta BPJS tidak boleh kosong,\n Silahkan isi nomor peserta BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    if (string.IsNullOrEmpty(NamaPesertaKartuBPJS.Text))
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Nama Peserta BPJS tidak boleh kosong,\n Silahkan isi nama peserta BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    if ((KelasKartuBPJSLookUpEdit.EditValue==null) || (string.IsNullOrEmpty( KelasKartuBPJSLookUpEdit.Text)))
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Kelas Kartu BPJS tidak boleh kosong" + "\nbtnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    ////if ((TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue==null) || (string.IsNullOrEmpty( TujuanSrtRujukanSEPBPJSLookUpEdit.Text)))
                                    ////{
                                    ////    MetroFramework.MetroMessageBox.Show(this, "Tujuan SEP BPJS tidak boleh kosong" + "\nbtnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ////    return;
                                    ////}

                                    ////if (string.IsNullOrEmpty(NosepSEPBPJS.Text))
                                    ////{
                                    ////    MetroFramework.MetroMessageBox.Show(this, "Nomor SEP BPJS tidak boleh kosong,\n Silahkan isi nomor SEP BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ////    return;
                                    ////}

                                    if (TujuanSrtRujukanBPJSLookUpEdit.EditValue == null)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Silahkan input tujuan Surat Rujukan BPJS" + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        TujuanSrtRujukanBPJSLookUpEdit.Focus();
                                        return;
                                    }
                                    ///
                                    break;
                            }

                            if (MetroFramework.MetroMessageBox.Show(this, "Apakah data pasien akan diregistrasikan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                registrasi reg = new registrasi()
                                {
                                    registrasiid = -1,
                                    nocm = NoRMIP.Text,
                                    noregistrasi = "-1",
                                    prosedurmasukid = Prosedurmasuk.ProsedurmasukId,
                                    tglmasuk = ((DateTime)tglMasukDateEdit.EditValue).Date, //  DateTime.Now.Date,
                                    jammasuk = ((DateTime)tglMasukDateEdit.EditValue).Date.Add(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)),  // DateTime.Now,
                                    penjaminpasienid = (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)(-1),
                                    stsmasukkeluarid = 1, //masuk
                                    loginappid = Helper.LoginAppDetail.loginappdetailid,//(short)(-1),
                                    registrasists = true,
                                    stspasienbaruid = Helper.Stspasienbaru.id
                                };

                                Helper.Stsregistrasi.stsregistrasiid = 1;

                                registrasiruangrawat regruangrawat = new registrasiruangrawat
                                {
                                    registrasiruangrawatid = -1,
                                    registrasiid = reg.registrasiid,
                                    tglmasukruangan = reg.tglmasuk,
                                    jammasukruangan = reg.jammasuk,
                                    kelasid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kelasid,
                                    ruangrawatid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).ruangrawatid,
                                    kamarid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).kamarid,
                                    tempattidurid = (PoliLookUpEdit.GetSelectedDataRow() as vruangrawat_kelasruangrawatid_kamarid_tempattidurid).tempattidurid,
                                    loginappid = Helper.LoginAppDetail.loginappdetailid,//(short)(-1),
                                    stsregistrasiid = Helper.Stsregistrasi.stsregistrasiid
                                };

                                v_pelayananpasienkarcis vpelayananpasienkarcis = new v_pelayananpasienkarcis
                                {
                                    pelayananpasienid = -1,
                                    pelayananpasientgl = reg.tglmasuk,
                                    pelayananpasienjam = reg.jammasuk,
                                    registrasiruangrawatid = -1,
                                    pelayananmedikid = Helper.Pelayananmedik.pelayananmedikid,
                                    jenistarifid = jenistarif.jenistarifid,
                                    ruangrawatid = regruangrawat.ruangrawatid,
                                    kelasid = regruangrawat.kelasid,
                                    stspasienbaruid = Helper.Stspasienbaru.id,
                                    loginappid = reg.loginappid
                                };

                                penjaminpasiendirisendiri pdirisendiri = null;
                                penjaminpasienkeluarga pkeluarga = null;
                                identitaspasienbpjs ipasienbpjs = null;
                                penjaminpasienbpjs pjpasienbpjs = null;
                                suratrujukanpuskesmas srtrujukanpuskesmas = null;

                                switch (this.statepenjamin)
                                {
                                    case Services.StatePenjamin.DiriSendiri: //Diri Sendiri

                                        pdirisendiri = new penjaminpasiendirisendiri
                                        {
                                            penjaminpasiendirisendiriid = -1,
                                            tgljaminan = reg.jammasuk,
                                            identitasdiriid = (IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue != null) ? (short)IdentitasdiriPenjaminDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            nomoridentitas = NoIdentitasPenjaminDiriSendiri.Text,
                                            nama = NamaDiriSendiri.Text,
                                            jkid = (KelaminDiriSendiriLookUpEdit.EditValue != null) ? (short)KelaminDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            alamat = ALamatDiriSendiri.Text,
                                            propinsiid = Helper.Propinsi.PropinsiId(),
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecDiriSendiriLookUpEdit.EditValue != null) ? (short)KecDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KelDiriSendiriLookUpEdit.EditValue != null) ? (short)KelDiriSendiriLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWDiriSendiriLookUpEdit.EditValue != null) ? (RTRWDiriSendiriLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWDiriSendiriLookUpEdit.EditValue != null) ? (RTRWDiriSendiriLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            notelp = NoTelpDiriSendiri.Text,
                                            nohp = NoHPDiriSendiri.Text

                                        };


                                        break;
                                    case Services.StatePenjamin.Keluarga: //Keluarga
                                        pkeluarga = new penjaminpasienkeluarga
                                        {
                                            penjaminpasienkeluargaid = reg.registrasiid,
                                            tgljaminan = reg.jammasuk,
                                            penjaminpasienid = (penjaminLookUpEdit.EditValue != null) ? (short)penjaminLookUpEdit.EditValue : (short)-1,
                                            identitasdiriid = (IdentitasdiriPenjaminKLookUpEdit.EditValue != null) ? (short)IdentitasdiriPenjaminKLookUpEdit.EditValue : (short)-1,
                                            nomoridentitas = NoIdentitasPenjaminK.Text,
                                            nama = NamaPenjaminK.Text,
                                            jkid = (JKPenjaminKlookUpEdit.EditValue != null) ? (short)JKPenjaminKlookUpEdit.EditValue : (short)-1,
                                            alamat = AlamatPenjaminK.Text,
                                            propinsiid = Helper.Propinsi.PropinsiId(),
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecPenjaminKLookUpEdit.EditValue != null) ? (short)KecPenjaminKLookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KeldesaPenjaminKLookUpEdit.EditValue != null) ? (short)KeldesaPenjaminKLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWPenjaminKLookUpEdit.EditValue != null) ? (RTRWPenjaminKLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWPenjaminKLookUpEdit.EditValue != null) ? (RTRWPenjaminKLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            notelp = NoTelpPenjaminK.Text,
                                            nohp = NoHPPenjaminK.Text,
                                            hubkeluargaid = (HubPenjaminKLookUpEdit.EditValue != null) ? (short)HubPenjaminKLookUpEdit.EditValue : (short)-1
                                        };

                                        break;
                                    case Services.StatePenjamin.BPJS: //BPJS
                                        ipasienbpjs = new identitaspasienbpjs
                                        {
                                            nocm = NoRMIP.Text,
                                            nopeserta = NoPesertaKartuBPJS.Text,
                                            namapeserta = NamaPesertaKartuBPJS.Text,
                                            faskes = FaskesKartuBPJS.Text,
                                            kelasbpjsid = (KelasKartuBPJSLookUpEdit.EditValue != null) ? (short)KelasKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            jkid = (JKKartuBPJSLookUpEdit.EditValue != null) ? (short)JKKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            tempatlahir = TempatLahirKartuBPJS.Text,
                                            tanggallahir = (TglLahirKartuBPJSDateEdit.EditValue != null) ? ((DateTime)TglLahirKartuBPJSDateEdit.EditValue).Date : DateTime.Parse(null),
                                            alamat = AlamatKartuBPJSTextBox.Text,
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecKartuBPJSlookUpEdit.EditValue != null) ? (short)KecKartuBPJSlookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KelKartuBPJSLookUpEdit.EditValue != null) ? (short)KelKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            identitaspasienbpjssts = true
                                        };

                                        srtrujukanpuskesmas = new suratrujukanpuskesmas
                                        {
                                            suratrujukanpuskesmasid = -1,
                                            suratrujukanpuskesmastgl = TglRujukanSrtRujukanBPJSDateEdit.EditValue != null ? ((DateTime)TglRujukanSrtRujukanBPJSDateEdit.EditValue).Date : DateTime.Parse(null),
                                            suratrujukanpuskesmasno = NoRujukanSrtRujukanBPJS.Text,
                                            puskesmasid = (PuskesmasSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(PuskesmasSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            ruangrawatid = (TujuanSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(TujuanSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            icdxsubkategoriid = DiagnosaAwalSrtRujukanBPJS.Text,
                                            icdxpuskesmasid = (DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            suratrujukanpuskesmastelahdiberikan = TelahDibreikanSrtRujukanBPJS.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            suratrujukanpuskesmassts = true

                                        };

                                        pjpasienbpjs = new penjaminpasienbpjs
                                        {
                                            penjaminpasienbpjsid = -1,
                                            nosep = NosepSEPBPJS.Text,
                                            tglsep = ((DateTime)TglSEPBPJSDateEdit.EditValue).Date,
                                            ruangrawatid = (TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue != null) ? (short)TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue : (short)-1,
                                            icdxsubkategoriid = selectedIcdxsubkategori.icdxsubkategoriid,
                                            icdxpuskesmasid = null,
                                            diagnosaalt = DiagnosaAltMTxt.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            penjaminpasienbpjssts = true

                                        };

                                        break;
                                    default://BPJS
                                        ipasienbpjs = new identitaspasienbpjs
                                        {
                                            nocm = NoRMIP.Text,
                                            nopeserta = NoPesertaKartuBPJS.Text,
                                            namapeserta = NamaPesertaKartuBPJS.Text,
                                            faskes = FaskesKartuBPJS.Text,
                                            kelasbpjsid = (KelasKartuBPJSLookUpEdit.EditValue != null) ? (short)KelasKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            jkid = (JKKartuBPJSLookUpEdit.EditValue != null) ? (short)JKKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            tempatlahir = TempatLahirKartuBPJS.Text,
                                            tanggallahir = (TglLahirKartuBPJSDateEdit.EditValue != null) ? ((DateTime)TglLahirKartuBPJSDateEdit.EditValue).Date : DateTime.Parse(null),
                                            alamat = AlamatKartuBPJSTextBox.Text,
                                            kotakabid = Helper.Kotakab.KotakabId(),
                                            kecid = (KecKartuBPJSlookUpEdit.EditValue != null) ? (short)KecKartuBPJSlookUpEdit.EditValue : (short)-1,
                                            keldesaid = (KelKartuBPJSLookUpEdit.EditValue != null) ? (short)KelKartuBPJSLookUpEdit.EditValue : (short)-1,
                                            rwid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rwid : (short)-1,
                                            rtid = (RTRWKartuBPJSLookUpEdit.EditValue != null) ? (RTRWKartuBPJSLookUpEdit.EditValue as vrtrw).rtid : (short)-1,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            identitaspasienbpjssts = true
                                        };

                                        srtrujukanpuskesmas = new suratrujukanpuskesmas
                                        {
                                            suratrujukanpuskesmasid = -1,
                                            suratrujukanpuskesmastgl = TglRujukanSrtRujukanBPJSDateEdit.EditValue != null ? ((DateTime)TglRujukanSrtRujukanBPJSDateEdit.EditValue).Date : DateTime.Parse(null),
                                            suratrujukanpuskesmasno = NoRujukanSrtRujukanBPJS.Text,
                                            puskesmasid = (PuskesmasSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(PuskesmasSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            ruangrawatid = (TujuanSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(TujuanSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            icdxsubkategoriid = DiagnosaAwalSrtRujukanBPJS.Text,
                                            icdxpuskesmasid = (DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue != null) ? short.Parse(DiagnosaAlternatifSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : (short)-1,
                                            suratrujukanpuskesmastelahdiberikan = TelahDibreikanSrtRujukanBPJS.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            suratrujukanpuskesmassts = true

                                        };

                                        pjpasienbpjs = new penjaminpasienbpjs
                                        {
                                            penjaminpasienbpjsid = -1,
                                            nosep = NosepSEPBPJS.Text,
                                            tglsep = ((DateTime)TglSEPBPJSDateEdit.EditValue).Date,
                                            ruangrawatid = (TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue != null) ? (short)TujuanSrtRujukanSEPBPJSLookUpEdit.EditValue : (short)-1,
                                            icdxsubkategoriid = selectedIcdxsubkategori.icdxsubkategoriid,
                                            icdxpuskesmasid = null,
                                            diagnosaalt = DiagnosaAltMTxt.Text,
                                            created_date = DateTime.Now,
                                            updated_date = null,
                                            penjaminpasienbpjssts = true

                                        };

                                        break;

                                }


                                var result = (string.Empty, string.Empty);

                                switch (this.statepenjamin)
                                {
                                    case Services.StatePenjamin.DiriSendiri: //Diri Sendiri
                                        result = AddRegistrasiPasienLama(reg, regruangrawat, pdirisendiri, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    case Services.StatePenjamin.Keluarga: //Keluarga
                                        result = AddRegistrasiPasienLama(reg, regruangrawat, pkeluarga, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    case Services.StatePenjamin.BPJS:
                                        result = AddRegistrasiPasienLama(reg, regruangrawat, ipasienbpjs, srtrujukanpuskesmas, pjpasienbpjs, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                    default:
                                        result = AddRegistrasiPasienLama(reg, regruangrawat, ipasienbpjs, srtrujukanpuskesmas, pjpasienbpjs, vpelayananpasienkarcis, this.statepenjamin);
                                        break;
                                }

                                

                                if (!string.IsNullOrEmpty(result.Item1) )
                                {
                                    btnNext.Text = "Finish";

                                    isSave = true;
                                    NoRMReg.Text = NoRMIP.Text ;
                                    NoregistrasiReg.Text = result.Item1;
                                    NoRMIP.Text = NoRMReg.Text;
                                    // NamaReg.Text = string.Format("{0}, {1}", SapaanIPLookUpEdit.Text, NamaIP.Text);
                                    //KelaminReg.Text = KelaminIPLookUpEdit.Text;
                                    //TglLahirReg.Text = TglLahirIPDateEdit.Text;
                                    //TglRegReg.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                                    //PoliklinikReg.Text = PoliLookUpEdit.Text;

                                    NoRMReg.ReadOnly = true;
                                    NoregistrasiReg.ReadOnly = true;

                                    EnableControlBasedChosePenjamin(false);

                                    listPanel[++indexPanel].BringToFront();
                                }
                                else
                                {
                                    isSave = false;
                                    MetroFramework.MetroMessageBox.Show(this, result.Item2 + "\n btnNext_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            //btnNext.Text = "Finish";
                            //if (indexPanel < (listPanel.Count - 1))
                            //    listPanel[++indexPanel].BringToFront();

                            if ((btnNext.Text == "Next") && (indexPanel < listPanel.Count - 1) && (isSave == true))
                            {
                                listPanel[++indexPanel].BringToFront();
                                btnNext.Text = "Finish";
                                NoRMReg.ReadOnly = true;
                                NoregistrasiReg.ReadOnly = true;
                            }

                            
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

        protected override void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isSave == true)
                {
                    Helper.CommonFuncControl.CloseAllFormInPanel(ref this.pnlContent);

                    this.pnlContent.Controls.Clear();
                    //fDashboard myForm = new fDashboard();
                    FListRegistrasiRJ myForm = new FListRegistrasiRJ(ref this.pnlContent);
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
                    FListIdentitasPasienRJ myForm = new FListIdentitasPasienRJ(ref this.pnlContent, "List Identitas Pasien");
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
                isSave = false;
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\n  btnBack_Click ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void penjaminLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (penjaminLookUpEdit.EditValue == null) return;
                if (string.IsNullOrEmpty(penjaminLookUpEdit.EditValue.ToString())) return;

                switch (int.Parse(penjaminLookUpEdit.EditValue.ToString()))
                {
                    case 1: //Diri Sendiri
                        
                        this.statepenjamin = StatePenjamin.DiriSendiri;
                        CasePenjaminDiriSendiri();

                        break;
                    case 2: //Keluarga
                        
                        this.statepenjamin = StatePenjamin.Keluarga;
                        CasePenjaminKeluarga();
                        break;
                    case 3: //BPJS
                        
                        this.statepenjamin = StatePenjamin.BPJS;
                        CasePenjaminBPJS();
                        break;
                    default://BPJS
                        
                        this.statepenjamin = StatePenjamin.BPJS;
                        CasePenjaminBPJS();
                        break;

                }

                //if (this.v_Registrasiruangrawat!=null)
                //{
                //    this.PoliLookUpEdit.EditValue = this.v_Registrasiruangrawat.ruangrawatid;
                //    this.tglMasukDateEdit.EditValue = this.v_Registrasiruangrawat.jammasuk;
                //    this.tglMasukDateEdit.ReadOnly = true;
                //}

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\npenjaminLookUpEdit_EditValueChanged()" + this.Name + "\n penjaminLookUpEdit_EditValueChanged ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void CasePenjaminDiriSendiri()
        {
            try
            {
                LoadPanelCasePenjaminDiriSendiri();
                LoadDataPanelCasePenjaminDiriSendiri();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nCasePenjaminDiriSendiri()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void LoadPanelCasePenjaminDiriSendiri()
        {
            indexPanel = 1;

            short i = 1;
            short count = (short)(listPanel.Count - 1);
            for (i = count; i >= 2; i--)
            {
                listPanel.RemoveAt(i);
            }

            //Add panel to list
            listPanel.Add(pnlDiriSendiri);
            listPanel.Add(pnlPoli);
            listPanel.Add(pnlRegistrasi);
            listPanel[indexPanel].BringToFront();
        }

        protected void LoadDataPanelCasePenjaminDiriSendiri()
        {
            try
            {
                lblStepDiriSendiri.Text = "Step 3";
                lblTitleDiriSendiri.Text = "Entri Identitas Diri";
                lblStepPoli.Text = "Step 4";
                lblTitlePoli.Text = "Entri Tujuan Poliklinik";
                lblStepReg.Text = "Step 5";
                lblTitleReg.Text = "Registrasi Pasien";

                TglPenjaminDiriSendiriDateEdit.EditValue = DateTime.Now.Date;

                LoadDataIdentitasdiriPenjaminDiriSendiri();
                LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(Helper.Kotakab.KotakabId());

                if (this.registrasiid != -1)
                {
                    FirstOrDefaultPenjaminpasiendirisendiri(new penjaminpasiendirisendiri { penjaminpasiendirisendiriid = this.registrasiid });

                    

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + this.Name + "\nLoadDataPanelCasePenjaminDiriSendiri()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void CasePenjaminKeluarga()
        {
            try
            {
                LoadPanelCasePenjaminKeluarga();
                LoadDataPanelCasePenjaminKeluarga();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nCasePenjaminKeluarga()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadPanelCasePenjaminKeluarga()
        {
            indexPanel = 1;

            short i = 1;
            short count = (short)(listPanel.Count - 1);
            for (i = count; i >= 2; i--)
            {
                listPanel.RemoveAt(i);
            }

            //Add panel to list
            listPanel.Add(pnlKeluarga);
            listPanel.Add(pnlPoli);
            listPanel.Add(pnlRegistrasi);
            listPanel[indexPanel].BringToFront();
        }
        protected void LoadDataPanelCasePenjaminKeluarga()
        {
            try
            {
                lblStepKeluarga.Text = "Step 3";
                lblTitleKeluarga.Text = "Entri Identitas Keluarga";
                lblStepPoli.Text = "Step 4";
                lblTitlePoli.Text = "Entri Tujuan Poliklinik";
                TglPenjaminKDateEdit.EditValue = DateTime.Now.Date;
                lblStepReg.Text = "Step 5";
                lblTitleReg.Text = "Registrasi Pasien";

                LoadDataHubKeluargaAndIdentitasdiriAndJKAndKecByKotaKabIdKeluargaPasienAsync(Kotakab.KotakabId());
                //LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);
                if (this.registrasiid != -1)
                {
                    FirstOrDefaultPenjaminpasienkeluarga(new penjaminpasienkeluarga { penjaminpasienkeluargaid = this.registrasiid });
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nLoadDataPanelCasePenjaminKeluarga()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void CasePenjaminBPJS()
        {
            try
            {
                LoadPanelCasePenjaminBPJS();
                LoadDataPanelCasePenjaminBPJS();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nCasePenjaminBPJS()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void LoadPanelCasePenjaminBPJS()
        {
            this.indexPanel = 1;

            short i = 1;
            short count = (short)(listPanel.Count - 1);
            for (i = count; i >= 2; i--)
            {
                listPanel.RemoveAt(i);
            }

            //Add panel to list
            //MessageBox.Show(listPanel.Count.ToString());

            listPanel.Add(pnlKartuBPJS);
            listPanel.Add(pnlSuratRujukanBPJS);
            listPanel.Add(pnlSEPBPJS);
            listPanel.Add(pnlPoli);
            listPanel.Add(pnlRegistrasi);
            listPanel[this.indexPanel].BringToFront();
        }
        protected void LoadDataPanelCasePenjaminBPJS()
        {
            try
            {
                lblStepKartuBPJS.Text = "Step 3";
                lblTitleKeluarga.Text = "Entri Data Kartu BPJS";
                lblStepSrtRujukanBPJS.Text = "Step 4";
                lblTitleSrtRujukanBPJS.Text = "Entri Data Surat Rujukan";
                LblStepSEPBPJS.Text = "Step 5";
                LblTitleSEPBPJS.Text = "Entri Data SEP BPJS";
                lblStepPoli.Text = "Step 6";
                lblTitlePoli.Text = "Entri Tujuan Poliklinik";
                lblStepReg.Text = "Step 7";
                lblTitleReg.Text = "Registrasi Pasien";

                //TglLahirKartuBPJSDateEdit.EditValue = DateTime.Now.Date;
                //LoadDataKelasAndJKAndKecByKotaKabIdKartuBPJSAsync(Kotakab.KotakabId());
                //KecKartuBPJSlookUpEdit.EditValue = KecKartuBPJSlookUpEdit.Properties.GetDataSourceValue("kecid", 0);

                //LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);



                #region panel kartuBPJS

                TglLahirKartuBPJSDateEdit.EditValue = DateTime.Now.Date;
                LoadDataKelasAndJKAndKecByKotaKabIdKartuBPJSAsync(Helper.Kotakab.KotakabId());
                KecKartuBPJSlookUpEdit.EditValue = KecKartuBPJSlookUpEdit.Properties.GetDataSourceValue("kecid", 0);

                FirstOrDefaultIdentitaspasienbpjsAsync(new identitaspasienbpjs { nocm = this.nocm });

                #endregion

                #region panel Surat Rujukan BPJS

                TglRujukanSrtRujukanBPJSDateEdit.EditValue = DateTime.Now.Date;
                LoadDataAsalRujukan();
                AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue = AsalRujukanSrtRujukanBPJSLookUpEdit.Properties.GetDataSourceValue("perujukid", 0);
                if (AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue != null)
                LoadMultiPuskesmasByPerujukIdAndRuangRawatRujukanAndVicdxpuskesmasAsync(AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue != null ? short.Parse(AsalRujukanSrtRujukanBPJSLookUpEdit.EditValue.ToString()) : short.Parse(null));

                if (this.registrasiid != -1)
                {
                    //FirstOrDefaultPerujuk()
                    FirstOrDefaultSuratRujukanPuskesmas(new suratrujukanpuskesmas { suratrujukanpuskesmasid = this.registrasiid });
                }

                #region SEP BPJS
                TglLahirSEPBPJS.Text = null;
                LoadRuangrawatrujukanAsync();
                if (this.registrasiid != -1)
                {
                    FirstOrDefaultPenjaminpasienbpjs(new penjaminpasienbpjs { penjaminpasienbpjsid = this.registrasiid });
                }
                
                #endregion
                #endregion


                //LoadDataIdentitasdiriPenjaminDiriSendiriAsync();
                //LoadDataIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiriAsync(Helper.Kotakab.KotakabId());
                //LoadRuangrawatrujukanAsync();
                //LoadDataJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(Helper.Kotakab.KotakabId(), Helper.Pelayananmedik.pelayananmedikid);




            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nLoadDataPanelCasePenjaminBPJS()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EnableControlBasedChosePenjaminPasienLama(bool value)
        {
            try
            {
                Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlPenjamin, value);
                Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlIdentitasPasien, value);
                Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlPoli, value);
                switch (penjaminLookUpEdit.EditValue)
                {

                    case 1://Diri Sendiri

                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlDiriSendiri, value);

                        break;
                    case 2://Keluarga
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlKeluarga, value);

                        break;
                    case 3://BPJS
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlKartuBPJS, value);
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlSuratRujukanBPJS, value);
                        Helper.CommonFuncControl.EnableControlInWindowsFormPanel(ref pnlSEPBPJS, value);

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nEnableControlBasedChosePenjamin()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControlBasedChosePenjaminPasienLama()
        {
            try
            {

                switch (penjaminLookUpEdit.EditValue)
                {

                    case 1://Diri Sendiri

                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlDiriSendiri);

                        break;
                    case 2://Keluarga
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlKeluarga);

                        break;
                    case 3://BPJS
                        
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlSuratRujukanBPJS);
                        Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlSEPBPJS);

                        break;
                    default:
                        break;
                }
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlPenjamin);
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlPoli);
                Helper.CommonFuncControl.ClearControlInWindowsFormPanel(ref pnlRegistrasi);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nClearControlBasedChosePenjamin()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void bClear_Click(object sender, EventArgs e)
        {
            try
            {

                if (isSave == true)
                {
                    EnableControlBasedChosePenjaminPasienLama(true);
                    ClearControlBasedChosePenjaminPasienLama();

                    this.indexPanel = 0;
                    listPanel[indexPanel].BringToFront();
                    isSave = false;
                    btnNext.Text = "Next";
                }
                else
                {
                    ClearControlBasedChosePenjaminPasienLama();
                    this.indexPanel = 0;
                    listPanel[indexPanel].BringToFront();
                    isSave = false;
                    btnNext.Text = "Next";

                    
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nbClear_Click()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        protected override void btnKartuKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                KartuStatusReport1 report = null;

                if (this.v_Registrasiruangrawat == null)
                {
                    if ((string.IsNullOrEmpty(NoRMReg.Text)) || (string.IsNullOrEmpty(NoregistrasiReg.Text)))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pasien belum diregistrasikan!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Loadv_statuspenyakitByNormAsync(NoRMReg.Text);
                            report = new KartuStatusReport1(NoRMReg.Text, NamaIP.Text,
                            string.Format("{0} Thn, {1} Bln, {2} Hari", ThnIP.Text, BlnIP.Text, HariIP.Text),
                            PekerjaanIPLookUpEdit.Text, string.Format("{0}, Kec.{1}, Kel/Desa.{2}", AlamatIP.Text, KecIPLookUpEdit.Text, KelIPLookUpEdit.Text),
                            this.penjaminLookUpEdit.Text,
                            ((this.PoliLookUpEdit != null) ? this.PoliLookUpEdit.Text.ToUpper() : string.Empty),
                            this.v_Statuspenyakits);
                    }
                }
                else
                {
                    Loadv_statuspenyakitByNormAsync(this.v_Registrasiruangrawat.nocm);
                    report = new KartuStatusReport1(this.v_Registrasiruangrawat.nocm, this.v_Registrasiruangrawat.nama ,
                    string.Format("{0} Thn, {1} Bln, {2} Hari", this.ThnIP.Text,this.BlnIP.Text, this.HariIP.Text),
                    this.PekerjaanIPLookUpEdit.Text, string.Format("{0}, Kec.{1}, Kel/Desa.{2}", this.v_Registrasiruangrawat.alamat, this.KecIPLookUpEdit.Text, KelIPLookUpEdit.Text),
                    this.v_Registrasiruangrawat.penjaminpasiennm, this.v_Registrasiruangrawat.ruangrawatnm,
                    this.v_Statuspenyakits);
                }

                


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
    }
}
