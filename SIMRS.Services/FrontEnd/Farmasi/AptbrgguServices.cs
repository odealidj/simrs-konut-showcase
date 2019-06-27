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
    public class AptbrgguServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptbrgguServices()
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

        public async Task<(IEnumerable<aptbrggu>, string)> SelectAllAsync(string tahun = "", string bulan = "")
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    if ((!string.IsNullOrEmpty(tahun)) && (!string.IsNullOrEmpty(bulan)))
                        return await uow.AptbrgguRepository.GetAllAsync(tahun, bulan);
                    else
                        return await uow.AptbrgguRepository.GetAllAsync();

                    
                }
            }
        }

        public async Task<(IEnumerable<v_aptbarangmasuk_pbf_aptbrggu>, string)> SelectAll_v_aptbarangmasuk_pbf_aptbrggu(short aptbrgguid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrgguRepository.GetAll_v_aptbarangmasuk_pbf_aptbrggu(aptbrgguid);


                }
            }
        }

        public async Task<(IEnumerable<v_aptbarangmasukdetail_aptbrggudetail>, string)> SelectAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbrgguid, short aptbarangmasukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrgguRepository.GetAll_v_aptbarangmasukdetail_aptbrggudetail(aptbrgguid,aptbarangmasukid);


                }
            }
        }

        public async Task<(IEnumerable<v_aptbarangmasukdetail_aptbrggudetail>, string)> SelectAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbarangmasukdetailid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrgguRepository.GetAll_v_aptbarangmasukdetail_aptbrggudetail(aptbarangmasukdetailid);


                }
            }
        }

        public async Task<(v_aptgenerateharga, string)> SelectAll_v_aptgenerateharga(short aptbarangmasukdetailid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrgguRepository.GetAll_v_aptgenerateharga(aptbarangmasukdetailid);


                }
            }
        }

        public async Task<(IEnumerable<v_aptbarangmasuk_pbf_notin_aptbrggudetail>, string)> SelectAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbarangmasukRepository.GetAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail();

                }
            }
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> SelectAllv_aptbrggudetailByAptbrgguidAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrggudetailRepository.GetAllv_aptbrggudetailByAptbrgguidAsync();
                }
            }
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> SelectAllv_aptbrggudetailByAptbrgguidAsync(string tahun, string bulan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrggudetailRepository.GetAllv_aptbrggudetailByAptbrgguidAsync(tahun,bulan);
                }
            }
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> SelectAllv_aptbrggudetailByAptbrgguidAsync(string namabarang)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbrggudetailRepository.GetAllv_aptbrggudetailByAptbrgguidAsync(namabarang);
                }
            }
        }

        public async Task<(IEnumerable<v_aptpembeliandetail>, string)> SelectAll_v_aptpembeliandetailByAptbarangmasukIdAsync(short aptbarangmasukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbarangmasukdetailRepository.GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync(aptbarangmasukid);
                }
            }
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> SelectAllv_aptbrggudetailByAptbrgguidAsync(short aptbrgguid, string namabarang="")
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    if (string.IsNullOrEmpty(namabarang))
                        return await uow.AptbrggudetailRepository.GetAllv_aptbrggudetailByAptbrgguidAsync(aptbrgguid);
                    else
                        return await uow.AptbrggudetailRepository.GetAllv_aptbrggudetailByAptbrgguidAsync(aptbrgguid, namabarang);
                }
            }
        }


        /*
        
        public string InsertBarangmasukGU(aptbrggu obj,short aptbarangmasukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbrgguRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    var data2 = uow.AptbrgguRepository.SaveAptbrggudetail(-1, short.Parse(data.Item1.ToString()), aptbarangmasukid);
                    if (!string.IsNullOrEmpty(data2))
                        return data2;

                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        */
        public string InsertBarangmasukGU(aptbrggu obj, short aptbarangmasukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbrgguRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    var data2 = uow.AptbrggudetailRepository.Save(-1, short.Parse(data.Item1.ToString()), aptbarangmasukid);
                    if (!string.IsNullOrEmpty(data2.Item2))
                        return data2.Item2;

                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string InsertBarangmasukGU(aptbrggu obj, List<v_aptpembelian> v_Aptpembelians)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbrgguRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;

                    foreach (v_aptpembelian item in v_Aptpembelians)
                    {
                        var data2 = uow.AptbrggudetailRepository.Save(-1, short.Parse(data.Item1.ToString()), item.aptbarangmasukid);
                        if (!string.IsNullOrEmpty(data2.Item2))
                            return data2.Item2;
                    }
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string InsertBarangmasukGU(aptbrggu objAptbrggu, aptbrggudetail objAptbrggudetail, short aptbarangmasukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbrgguRepository.Save(objAptbrggu);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    var data2 = uow.AptbrggudetailRepository.Save(objAptbrggudetail.aptbrggudetailid, short.Parse(data.Item1.ToString()), aptbarangmasukid);
                    if (!string.IsNullOrEmpty(data2.Item2))
                        return data2.Item2;

                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string InsertUpdateBarangmasukGUDetail(aptbrggudetail obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbrggudetailRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string UpdateTarif(aptbrggudetail obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var errStringResult = uow.AptbrggudetailRepository.UpdateTarif(obj);
                    if (!string.IsNullOrEmpty(errStringResult))
                        return errStringResult;
                    uow.Commit();
                    return errStringResult;
                }
            }
        }

        public string DeleteBarangGU(aptbrggu obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbrgguRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data))
                        return data;
                    uow.Commit();
                    return data;
                }
            }
        }
    }
}
