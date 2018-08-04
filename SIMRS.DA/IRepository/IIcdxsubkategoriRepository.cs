using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IIcdxsubkategoriRepository: IBaseRepository<icdxsubkategori>
    {
        Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname);
        Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname);
        Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname);
        (IEnumerable<icdxsubkategori>, short, string) GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(int pageIndex, int pageSize, string icdxname);
        Task<(IEnumerable<icdxsubkategori>, short, string)> GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname);
        Task<(IEnumerable<icdxsubkategori>, short, string)> GetMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname);
        Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriEngByIcdxnameAsync(string icdxname);
        Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriIndoByIcdxnameAsync(string icdxname);
        (IEnumerable<icdxsubkategori>, string) GetAllIcdxsubkategoriEngByIcdxname(string icdxname);
        (IEnumerable<icdxsubkategori>, string) GetAllIcdxsubkategoriIndoByIcdxname(string icdxname);

    }
}
