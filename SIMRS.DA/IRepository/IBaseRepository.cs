using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IBaseRepository<T>
                where T : class
    {
        int Save(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        T Get(T obj);
        Task<(T,string)> GetAsync(T obj);
        IEnumerable<T> GetAll();
        Task<(IEnumerable<T>,string)> GetAllAsync();
        Task<IEnumerable<T>> GetAllByPageIndex(int pageIndex, int pageSize);
    }
}
