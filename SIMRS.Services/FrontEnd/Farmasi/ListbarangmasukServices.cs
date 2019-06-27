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
    public class ListbarangmasukServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public ListbarangmasukServices()
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

        public async Task<(IEnumerable<v_aptpembelian>, string)> SelectAll_v_aptpembelianByYearAndMonthAsync(short year, short month)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbarangmasukRepository.GetAll_v_aptpembelianByYearAndMonthAsync(year, month);
                }
            }
        }

        public (IEnumerable<v_aptpembelian>, string) SelectAll_v_aptpembelianByYearAndMonth(short year, short month)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptbarangmasukRepository.GetAll_v_aptpembelianByYearAndMonth(year, month);
                }
            }
        }

        public (IEnumerable<v_aptpembelian>, string) SelectAll_v_aptpembelianByYearAndMonth(string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptbarangmasukRepository.GetAll_v_aptpembelianByYearAndMonth(value);
                }
            }
        }

        public (IEnumerable<v_aptpembelian>, string) SelectAll_v_aptpembelianByKeterangn(string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptbarangmasukRepository.GetAll_v_aptpembelianByKeterangan(value);
                }
            }
        }

        public (IEnumerable<v_aptpembelian>, string) SelectAll_v_aptpembelian()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptbarangmasukRepository.GetAll_v_aptpembelian();
                }
            }
        }

        public (IEnumerable<v_aptpembelian>, string) SelectAll_v_aptpembelian(string tahun, string bulan, string search = "")
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptbarangmasukRepository.GetAll_v_aptpembelian(tahun,bulan,search);
                }
            }
        }

        public (IEnumerable<v_aptpembelian>, string) SelectAll_v_aptpembelian_notin__aptbrggudetail()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptbarangmasukRepository.GetAll_v_aptpembelian_notin__aptbrggudetail();
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

        public (IEnumerable<v_aptpembeliandetail>, string) SelectAll_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid,string filter)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    if (string.IsNullOrEmpty(filter))
                        return uow.AptbarangmasukdetailRepository.GetAll_v_aptpembeliandetailByAptbarangmasukId(aptbarangmasukid);
                    else
                        return uow.AptbarangmasukdetailRepository.GetAll_v_aptpembeliandetailByAptbarangmasukId(aptbarangmasukid,filter);
                }
            }
        }


        



    }
}
