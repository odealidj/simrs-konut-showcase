using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Farmasi
{
    public class AptbarangsatuanServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptbarangsatuanServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }
        #endregion constructor

        #region disposable
        public void Dispose()
        {
            if (uow != null)
            {
                try
                {
                }
                finally
                {
                    uow.Dispose();
                }
            }
            if (context != null)
            {
                try
                {
                }
                finally
                {
                    context.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }

        #endregion disposable


        public async Task<(IEnumerable<aptbarangsatuan>, string)> SelectAllByIdAsync(short aptbarangsatuanid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.AptbarangsatuanRepository.GetAllByIdAsync(aptbarangsatuanid);
                }
            }

        }
        public async Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> SelectAllByAptarangidAsync(short aptbarangid )
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.AptbarangsatuanRepository.GetAllByAptbarangidAsync(aptbarangid);
                }
            }
        }

        public async Task<(IEnumerable<aptbarangsatuantrigger>, string)> SelectAllAptbarangsatuantriggerAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.AptbarangsatuantriggerRepository.GetAllAsync();
                }
            }
        }

        public (IEnumerable<aptbarangsatuantrigger>, string) SelectAllAptbarangsatuantrigger()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return uow.AptbarangsatuantriggerRepository.GetAll();
                }
            }
        }

        public async Task<(IEnumerable<aptbarangsatuantrigger>, string)> SelectAllAptbarangsatuantriggerByAptbarangsatuanidAsync(short aptbarangsatuanid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.AptbarangsatuantriggerRepository.GetAllByAptbarangsatuanidAsync(aptbarangsatuanid);
                }
            }
        }

        public (IEnumerable<aptbarangsatuantrigger>, string) SelectAllAptbarangsatuantriggerByAptbarangsatuanid(short aptbarangsatuanid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return uow.AptbarangsatuantriggerRepository.GetAllByAptbarangsatuanid(aptbarangsatuanid);
                }
            }
        }

        public async Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> GetAll_v_aptbarangsatuan_pbfByPbfAsync(short pbfid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.AptbarangsatuanRepository.GetAll_v_aptbarangsatuan_pbfByPbfAsync(pbfid);
                }
            }
        }

    

        public string InsertUpdateAptbarangsatuan(aptbarangsatuan objaptbarangsatuan, 
            aptbarangsatuantrigger objaptbarangsatuankecil, aptbarangsatuantrigger objaptbarangsatuanbesar)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var objsatuan = uow.AptbarangsatuanRepository.Save(objaptbarangsatuan);
                    if (!string.IsNullOrEmpty(objsatuan.Item2))
                        return objsatuan.Item2;

                    if (objaptbarangsatuan.aptbarangsatuanid == -1)
                    {
                        objaptbarangsatuankecil.aptbarangsatuanid = short.Parse(objsatuan.Item1.ToString());
                        objaptbarangsatuanbesar.aptbarangsatuanid = short.Parse(objsatuan.Item1.ToString());
                    }
                    else
                    {
                        var deleteAptbarangsatuantrigger =  uow.AptbarangsatuantriggerRepository.DeleteByAptbarangsatuanId(objaptbarangsatuan.aptbarangsatuanid);
                        if (!string.IsNullOrEmpty(deleteAptbarangsatuantrigger))
                            return deleteAptbarangsatuantrigger;
                    }

                    var objkecil = uow.AptbarangsatuantriggerRepository.Save(objaptbarangsatuankecil);
                    if (!string.IsNullOrEmpty(objkecil.Item2))
                        return objkecil.Item2;

                    var objbesar = uow.AptbarangsatuantriggerRepository.Save(objaptbarangsatuanbesar);
                    if (!string.IsNullOrEmpty(objbesar.Item2))
                        return objbesar.Item2;

                    uow.Commit();
                    return objsatuan.Item2;
                }
            }
        }

        public string DeleteAptbarangsatuan(aptbarangsatuan obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbarangsatuanRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data))
                        return data;
                    uow.Commit();
                    return data;
                }
            }
        }

    }
}
