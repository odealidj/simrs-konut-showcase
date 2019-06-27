
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
    public class RegistrasiPasienBaruServices : RegistrasiPasienServices
    {
        public RegistrasiPasienBaruServices()
        {

        }



        public (string, string) InsertPasienBaru(identitaspasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.IdentitaspasienRepository.Save(obj);
                    uow.Commit();
                    return data;
                }
            }
        }

        public (string, string) InsertPasienBaru(identitaspasien _identitaspasien, alamatpasien _alamatpasien)
        {

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty);

                    uow.BeginTransaction();
                    var dataIdentitasPasien = uow.IdentitaspasienRepository.Save(_identitaspasien);
                    if (string.IsNullOrEmpty(dataIdentitasPasien.Item2))
                    {
                        _alamatpasien.nocm = dataIdentitasPasien.Item1;

                        var dataAlamatPasien = uow.AlamatpasienRepository.Save(_alamatpasien);
                        if (string.IsNullOrEmpty(dataAlamatPasien))
                        {
                            result = (dataIdentitasPasien.Item1, string.Empty);
                        }
                        else
                        {
                            result = (dataIdentitasPasien.Item1, dataAlamatPasien);
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, dataIdentitasPasien.Item2);
                        return result;
                    }
                    uow.Commit();

                    return result;
                }
            }
        }


        public (string, string, string) InsertPasienBaru(identitaspasien _identitaspasien, 
            alamatpasien _alamatpasien,
            registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasiendirisendiri _penjaminpasiendirisendiri,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin
            )
        {

            int dataRegistrasiRuangRawat = -1;

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty, string.Empty);

                    uow.BeginTransaction();
                    var  dataIdentitasPasien = uow.IdentitaspasienRepository.Save(_identitaspasien);
                    if (string.IsNullOrEmpty(dataIdentitasPasien.Item2))
                    {
                        _alamatpasien.nocm = dataIdentitasPasien.Item1;

                        var dataAlamatPasien = uow.AlamatpasienRepository.Save(_alamatpasien);
                        if (string.IsNullOrEmpty(dataAlamatPasien))
                        {


                            _registrasi.nocm = dataIdentitasPasien.Item1;
                            var dataRegistrasi = uow.RegistrasiRepository.Save(_registrasi);
                            if (string.IsNullOrEmpty(dataRegistrasi.Item3))
                            {
                                _registrasiruangrawat.registrasiid = dataRegistrasi.Item1;

                                if (_registrasiruangrawat.registrasiruangrawatid == -1)
                                {
                                    dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                                }
                                else
                                {
                                    uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                                    dataRegistrasiRuangRawat = _registrasiruangrawat.registrasiruangrawatid;
                                }

                                if (dataRegistrasiRuangRawat != -99)
                                {
                                    _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                                    var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);

                                    //if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;

                                    if (dataVpelayananpasienkarcis != -99)
                                    {
                                        switch (_statepenjamin)
                                        {
                                            case StatePenjamin.DiriSendiri:
                                                _penjaminpasiendirisendiri.penjaminpasiendirisendiriid = dataRegistrasi.Item1;
                                                var dataPenjaminpasiendirisendiri = uow.PenjaminpasiendirisendiriRepository.Save(_penjaminpasiendirisendiri);
                                                if (dataPenjaminpasiendirisendiri != -99)
                                                {
                                                    result = (dataIdentitasPasien.Item1, dataRegistrasi.Item2, string.Empty);
                                                }
                                                else
                                                {
                                                    result = (string.Empty, string.Empty, "Not finished previous transaction");
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
                                        result = (string.Empty, string.Empty, "Not finished previous transaction");
                                        return result;
                                    }

                                }
                                else
                                {
                                    result = (string.Empty, string.Empty, "Not finished previous transaction");
                                    return result;
                                }
                            }
                            else
                            {
                                result = (string.Empty, string.Empty, dataRegistrasi.Item3);
                                return result;
                            }
                            

                        }
                        else
                        {
                            result = (string.Empty, string.Empty, dataAlamatPasien);
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, string.Empty, dataIdentitasPasien.Item2);
                        return result;
                    }
                    uow.Commit();

                    return result;
                }
            }
        }


        public (string, string, string) InsertPasienBaru(identitaspasien _identitaspasien,
            alamatpasien _alamatpasien,
            registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            penjaminpasienkeluarga _penjaminpasienkeluarga,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin
            )
        {

            int dataRegistrasiRuangRawat = -1;

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty, string.Empty);

                    uow.BeginTransaction();
                    var dataIdentitasPasien = uow.IdentitaspasienRepository.Save(_identitaspasien);
                    if (string.IsNullOrEmpty(dataIdentitasPasien.Item2))
                    {
                        _alamatpasien.nocm = dataIdentitasPasien.Item1;

                        var dataAlamatPasien = uow.AlamatpasienRepository.Save(_alamatpasien);
                        if (string.IsNullOrEmpty(dataAlamatPasien))
                        {
                            _registrasi.nocm = dataIdentitasPasien.Item1;
                            var dataRegistrasi = uow.RegistrasiRepository.Save(_registrasi);
                            if (string.IsNullOrEmpty(dataRegistrasi.Item3))
                            {
                                _registrasiruangrawat.registrasiid = dataRegistrasi.Item1;

                                if (_registrasiruangrawat.registrasiruangrawatid == -1)
                                {
                                    dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                                }
                                else
                                {
                                    uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                                    dataRegistrasiRuangRawat = _registrasiruangrawat.registrasiruangrawatid;
                                }


                                
                                if (dataRegistrasiRuangRawat != -99)
                                {
                                    _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                                    var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);

                                    //if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;

                                    if (dataVpelayananpasienkarcis != -99)
                                    {
                                        switch (_statepenjamin)
                                        {
                                            case StatePenjamin.DiriSendiri:

                                                break;
                                            case StatePenjamin.Keluarga:
                                                _penjaminpasienkeluarga.penjaminpasienkeluargaid = dataRegistrasi.Item1;
                                                var dataPenjaminpasienkeluarga = uow.PenjaminpasienkeluargaRepository.Save(_penjaminpasienkeluarga);
                                                if (dataPenjaminpasienkeluarga != -99)
                                                {
                                                    result = (dataIdentitasPasien.Item1, dataRegistrasi.Item2, string.Empty);
                                                }
                                                else
                                                {
                                                    result = (string.Empty, string.Empty, "Not finished previous transaction");
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
                                        result = (string.Empty, string.Empty, "Not finished previous transaction");
                                        return result;
                                    }

                                }
                                else
                                {
                                    result = (string.Empty, string.Empty, "Not finished previous transaction");
                                    return result;
                                }
                            }
                            else
                            {
                                result = (string.Empty, string.Empty, dataRegistrasi.Item3);
                                return result;
                            }
                        }
                        else
                        {
                            result = (string.Empty, string.Empty, dataAlamatPasien);
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, string.Empty, dataIdentitasPasien.Item2);
                        return result;
                    }
                    uow.Commit();

                    return result;
                }
            }
        }

        public (string, string, string) InsertPasienBaru(identitaspasien _identitaspasien,
            alamatpasien _alamatpasien,
            registrasi _registrasi, registrasiruangrawat _registrasiruangrawat,
            identitaspasienbpjs _identitaspasienbpjs,
            suratrujukanpuskesmas _suratrujukanpuskesmas,
            penjaminpasienbpjs _penjaminpasienbpjs,
            v_pelayananpasienkarcis _vpelayananpasienkarcis,
            StatePenjamin _statepenjamin
            )
        {
            string nocm = string.Empty;
            int dataRegistrasiRuangRawat = -1;
            short registrasiId = -1;
            string noregistrasi = string.Empty;

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    var result = (string.Empty, string.Empty, string.Empty);

                    uow.BeginTransaction();

                    
                    var dataIdentitasPasien = uow.IdentitaspasienRepository.Save(_identitaspasien);

                    if (string.IsNullOrEmpty(dataIdentitasPasien.Item2))
                    {
                        _alamatpasien.nocm = dataIdentitasPasien.Item1;

                        var dataAlamatPasien = uow.AlamatpasienRepository.Save(_alamatpasien);
                        if (string.IsNullOrEmpty(dataAlamatPasien))
                        {
                            _registrasi.nocm = dataIdentitasPasien.Item1;

                           
                            var dataRegistrasi = uow.RegistrasiRepository.Save(_registrasi);

                            //if (_registrasi.registrasiid != -1) registrasiId = _registrasi.registrasiid;

                            if (string.IsNullOrEmpty(dataRegistrasi.Item3))
                            {

                                _registrasiruangrawat.registrasiid = dataRegistrasi.Item1;

                                
                                if (_registrasiruangrawat.registrasiruangrawatid == -1)
                                {
                                    dataRegistrasiRuangRawat = uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                                }
                                else
                                {
                                    uow.RegistrasiruangrawatRepository.Save(_registrasiruangrawat);
                                    dataRegistrasiRuangRawat = _registrasiruangrawat.registrasiruangrawatid;
                                }

                                if (dataRegistrasiRuangRawat != -99)
                                {
                                    _vpelayananpasienkarcis.registrasiruangrawatid = (short)dataRegistrasiRuangRawat;
                                    var dataVpelayananpasienkarcis = uow.PelayananpasienRepository.SaveKarcis(_vpelayananpasienkarcis);
                                    //if (_vpelayananpasienkarcis.ruangrawatid == 1) dataVpelayananpasienkarcis = -98;
                                    if (dataVpelayananpasienkarcis != -99)
                                    {

                                        switch (_statepenjamin)
                                        {
                                            case StatePenjamin.DiriSendiri:
                                                break;
                                            case StatePenjamin.Keluarga:
                                                break;
                                            case StatePenjamin.BPJS:
                                                _identitaspasienbpjs.nocm = dataIdentitasPasien.Item1;
                                                var dataIdentitaspasienBPJS = uow.IdentitaspasienbpjsRepository.Save(_identitaspasienbpjs);
                                                if (dataIdentitaspasienBPJS != -99)
                                                {
                                                    _suratrujukanpuskesmas.suratrujukanpuskesmasid = dataRegistrasi.Item1;
                                                    var resultSuratRujukanPuskesmas = uow.SuratrujukanpuskesmasRepository.Save(_suratrujukanpuskesmas);

                                                    if (resultSuratRujukanPuskesmas != -99)
                                                    {
                                                        if (_penjaminpasienbpjs == null)
                                                        {
                                                            result = (dataIdentitasPasien.Item1, dataRegistrasi.Item2, string.Empty);
                                                        }
                                                        else
                                                        {
                                                            if (registrasiId == -1)
                                                            {
                                                                _penjaminpasienbpjs.penjaminpasienbpjsid = dataRegistrasi.Item1;
                                                            }
                                                            else
                                                            {
                                                                _penjaminpasienbpjs.penjaminpasienbpjsid = registrasiId;
                                                            }

                                                            var datapenjaminpasienbpjs = uow.PenjaminpasienbpjsRepository.Save(_penjaminpasienbpjs);

                                                            if (datapenjaminpasienbpjs != -99)
                                                            {
                                                                result = (dataIdentitasPasien.Item1, dataRegistrasi.Item2, string.Empty);
                                                            }
                                                            else
                                                            {
                                                                result = (string.Empty, string.Empty, "Not finished previous transaction");
                                                                return result;
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        result = (string.Empty, string.Empty, "Not finished previous transaction");
                                                        return result;
                                                    }


                                                }
                                                else
                                                {
                                                    result = (string.Empty, string.Empty, "Not finished previous transaction");
                                                    return result;
                                                }
                                                break;
                                            default:
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        result = (string.Empty, string.Empty, "Not finished previous transaction");
                                        return result;
                                    }

                                }
                                else
                                {
                                    result = (string.Empty, string.Empty, "Not finished previous transaction");
                                    return result;
                                }
                            }
                            else
                            {
                                result = (string.Empty, string.Empty, dataRegistrasi.Item3);
                                return result;
                            }
                        }
                        else
                        {
                            result = (string.Empty, string.Empty, dataAlamatPasien);
                            return result;
                        }
                    }
                    else
                    {
                        result = (string.Empty, string.Empty, dataIdentitasPasien.Item2);
                        return result;
                    }
                    uow.Commit();

                    return result;
                }
            }
        }


    }
}
