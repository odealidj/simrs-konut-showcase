using SIMRS.DA;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Registrasi
{
    public class RegistrasiPasienLamaServices : RegistrasiPasienServices
    {
        public RegistrasiPasienLamaServices()
        {

        }

        public async Task<(identitaspasien, string)> FirtOrDefaultIdentitasPasienByNocmAsync(string nocm)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IdentitaspasienRepository.GetIdentitasPasienByNocmAsync(nocm);
                }
            }
        }

        public async Task<(identitaspasien,alamatpasien, string)> FirtOrDefaultIdentitaspasienAlamatpasienByNocmAsync(string nocm)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiPasienLamaRepository.GetIdentitaspasienAlamatpasienByNocmAsyn(nocm);
                }
            }
        }

        public string InsertRujukanPoli(registrasiruangrawat _registrasiruangrawat,
            v_pelayananpasienkarcis _vpelayananpasienkarcis)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = string.Empty;

                    uow.BeginTransaction();


                        var dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                        if (dataRegistrasiRuangRawat != -99)
                        {
                            _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                            var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);

                            if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;

                            if (dataVpelayananpasienkarcis != -99)
                            {
                                //result = (dataRegistrasi.Item2, string.Empty);

                                
                            }
                            else
                            {
                                result = ("Not finished previous transaction");
                                return result;
                            }

                        }
                        else
                        {
                            result = ("Not finished previous transaction");
                            return result;
                        }


                    uow.Commit();

                    return result;
                }
            }
        }

        public (string, string) InsertPasienLama(registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasiendirisendiri _penjaminpasiendirisendiri,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty);

                    uow.BeginTransaction();

                    var dataRegistrasi = uow.RegistrasiRepository.Save(_registrasi);
                    if (string.IsNullOrEmpty(dataRegistrasi.Item3))
                    {
                        _registrasiruangrawat.registrasiid = dataRegistrasi.Item1;
                        var dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                        if (dataRegistrasiRuangRawat != -99)
                        {
                            _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                            var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);

                            if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;

                            if (dataVpelayananpasienkarcis != -99)
                            {
                                //result = (dataRegistrasi.Item2, string.Empty);

                                switch (_statepenjamin)
                                {
                                    case StatePenjamin.DiriSendiri:
                                        _penjaminpasiendirisendiri.penjaminpasiendirisendiriid = dataRegistrasi.Item1;
                                        var dataPenjaminpasiendirisendiri = uow.PenjaminpasiendirisendiriRepository.Save(_penjaminpasiendirisendiri);
                                        if (dataPenjaminpasiendirisendiri != -99)
                                        {

                                            result = (dataRegistrasi.Item2, string.Empty);
                                        }
                                        else
                                        {
                                            result = (string.Empty, "Not finished previous transaction");
                                            return result;
                                        }
                                        break;
                                    case StatePenjamin.Keluarga:
                                        break;
                                    case StatePenjamin.BPJS:
                                        break;
                                    default:
                                        break;

                                }
                            }
                            else
                            {
                                result = (string.Empty, "Not finished previous transaction");
                                return result;
                            }
                            
                        }
                        else
                        {
                            result = (string.Empty, "Not finished previous transaction");
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, dataRegistrasi.Item3);
                        return result;
                    }
                        
                    uow.Commit();

                    return result;
                }
            }
        }

        public (string, string) InsertPasienLama(registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasienkeluarga _penjaminpasienkeluarga,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty);

                    uow.BeginTransaction();

                    var dataRegistrasi = uow.RegistrasiRepository.Save(_registrasi);
                    if (string.IsNullOrEmpty(dataRegistrasi.Item3))
                    {
                        _registrasiruangrawat.registrasiid = dataRegistrasi.Item1;
                        var dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                        if (dataRegistrasiRuangRawat != -99)
                        {
                            _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                            var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);

                            if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;

                            if (dataVpelayananpasienkarcis != -99)
                            {
                                //result = (dataRegistrasi.Item2, string.Empty);
                                switch (_statepenjamin)
                                {
                                    case StatePenjamin.DiriSendiri:

                                        break;
                                    case StatePenjamin.Keluarga:
                                        _penjaminpasienkeluarga.penjaminpasienkeluargaid = dataRegistrasi.Item1;
                                        var dataPenjaminpasienkeluarga = uow.PenjaminpasienkeluargaRepository.Save(_penjaminpasienkeluarga);
                                        if (dataPenjaminpasienkeluarga != -99)
                                        {

                                            result = (dataRegistrasi.Item2, string.Empty);
                                        }
                                        else
                                        {
                                            result = (string.Empty, "Not finished previous transaction");
                                            return result;
                                        }
                                        break;
                                    case StatePenjamin.BPJS:
                                        break;
                                    default:
                                        break;

                                }
                            }
                            else
                            {
                                result = (string.Empty, "Not finished previous transaction");
                                return result;
                            }


                        }
                        else
                        {
                            result = (string.Empty, "Not finished previous transaction");
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, dataRegistrasi.Item3);
                        return result;
                    }

                    uow.Commit();

                    return result;
                }
            }
        }

        public (string, string) InsertPasienLama(registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            identitaspasienbpjs _identitaspasienbpjs, suratrujukanpuskesmas _suratrujukanpuskesmas, penjaminpasienbpjs _penjaminpasienbpjs,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty);

                    uow.BeginTransaction();

                    var dataRegistrasi = uow.RegistrasiRepository.Save(_registrasi);
                    if (string.IsNullOrEmpty(dataRegistrasi.Item3))
                    {
                        _registrasiruangrawat.registrasiid = dataRegistrasi.Item1;
                        var dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                        if (dataRegistrasiRuangRawat != -99)
                        {
                            _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                            var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);

                            if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;

                            if (dataVpelayananpasienkarcis != -99)
                            {
                               result = (dataRegistrasi.Item2, string.Empty);

                                switch (_statepenjamin)
                                {
                                    case StatePenjamin.DiriSendiri:

                                        break;
                                    case StatePenjamin.Keluarga:
                                        break;
                                    case StatePenjamin.BPJS:
                                       // _penjaminpasienbpjs.penjaminpasienbpjsid = _registrasi.nocm;
                                        var dataIdentitaspasienBPJS = uow.IdentitaspasienbpjsRepository.Save(_identitaspasienbpjs);
                                        if (dataIdentitaspasienBPJS != -99)
                                        {

                                            _suratrujukanpuskesmas.suratrujukanpuskesmasid = dataRegistrasi.Item1;
                                            var resultSuratRujukanPuskesmas = uow.SuratrujukanpuskesmasRepository.Save(_suratrujukanpuskesmas);

                                            if (resultSuratRujukanPuskesmas != -99)
                                            {

                                                if (_penjaminpasienbpjs == null)
                                                {
                                                    result = (dataRegistrasi.Item2, string.Empty);
                                                }
                                                else
                                                {
                                                    _penjaminpasienbpjs.penjaminpasienbpjsid = dataRegistrasi.Item1;
                                                    var datapenjaminpasienbpjs = uow.PenjaminpasienbpjsRepository.Save(_penjaminpasienbpjs);

                                                    if (datapenjaminpasienbpjs != -99)
                                                    {

                                                        result = (dataRegistrasi.Item2, string.Empty);
                                                    }
                                                    else
                                                    {
                                                        result = (string.Empty, "Not finished previous transaction");
                                                        return result;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                result = (string.Empty, "Not finished previous transaction");
                                                return result;
                                            }

                                            
                                        }
                                        else
                                        {
                                            result = (string.Empty, "Not finished previous transaction");
                                            return result;
                                        }
                                        break;
                                    default:
                                        break;

                                }
                            }
                            else
                            {
                                result = (string.Empty, "Not finished previous transaction");
                                return result;
                            }

                        }
                        else
                        {
                            result = (string.Empty, "Not finished previous transaction");
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, dataRegistrasi.Item3);
                        return result;
                    }

                    uow.Commit();

                    return result;
                }
            }
        }

        public async Task<(penjaminpasien, string)> FirstOrDefaultPenjaminByNoRMAsync(string NoRM)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PenjaminRepository.GetPenjaminByNoRMAsync(NoRM);
                }
            }
        }

        public Task<(penjaminpasien, string)> FirstOrDefaultPenjaminByNoRM(string NoRM)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PenjaminRepository.GetPenjaminByNoRMAsync(NoRM);
                }
            }
        }
    }
}
