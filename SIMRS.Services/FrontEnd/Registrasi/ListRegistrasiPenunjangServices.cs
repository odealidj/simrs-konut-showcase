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
    public class ListRegistrasiPenunjangServices : ListRegistrasiServices
    {
        public ListRegistrasiPenunjangServices()
        {

        }

        public async Task<(IEnumerable<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>, string)> SelectVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short stsmasukkeluarid, string value)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetAllVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(pageIndex, pageSize, stsmasukkeluarid, value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<(IEnumerable<v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang>, string)> SelectVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(short registrasiid,short pelayananmedikpenunjangid)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetAllVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(registrasiid,pelayananmedikpenunjangid);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string InsertRegistrasiPenunjang(registrasipenunjang obj)
        {
            string errString = null;
            try
            {
                
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        uow.BeginTransaction();
                        var data = uow.RegistrasipenunjangRepository.Save(obj);
                        uow.Commit();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                errString = ex.Message;
            }
            return errString;
        }

        public string DeleteRegistrasiPenunjang(registrasipenunjang obj)
        {
            string errString = null;
            try
            {

                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        uow.BeginTransaction();
                        var data = uow.RegistrasipenunjangRepository.Delete(obj);
                        if (data == false)
                        {
                            errString = "Delete data regisrasi penunjang tidak valid";
                            return errString;
                        }
                        uow.Commit();

                    }
                }
            }
            catch (Exception ex)
            {
                errString = ex.Message;
            }
            return errString;


           

        }

        public async Task<(IEnumerable<v_distinctpasienpenunjang>, string)> SelectVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsmasukkeluarid, string value)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(pageIndex, pageSize, pelayananmedikid, stsmasukkeluarid, value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<(IEnumerable<v_distinctpasienpenunjang>, string)> SelectVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsmasukkeluarid, DateTime tglmasuk)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(pageIndex, pageSize, pelayananmedikid, stsmasukkeluarid, tglmasuk);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<(IEnumerable<v_registrasiruangrawat_penunjang>, string)> SelectVregistrasiruangrawatpenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikid)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetAllVregistrasiruangrawatpenunjangByRegistrasiIdAsync(registrasiid, pelayananmedikid);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang>, string)> SelectVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikpenunjangid)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetAllVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(registrasiid, pelayananmedikpenunjangid);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang>, string)> SelectDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(int pageIndex, int pageSize, short pelayananmedikpenunjangid, short stsmasukkeluarid, string value)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.RegistrasipenunjangRepository.GetDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync (pageIndex,pageSize,pelayananmedikpenunjangid,stsmasukkeluarid,value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
