using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IIcdxkategoriRepository : IBaseRepository<icdxkategori>
    {
        Task<(IEnumerable<vicdxsubkategori>,string)> GetAllVicdxsubkategoriByPageIndexAndConcateAsync(int pageIndex, int pageSize, string icdxsubkategoriconcate);
        Task<(IEnumerable<vicdxsubkategorieng>,string)> GetAllVicdxsubkategoriEngByPageIndexAndConcateAsync(int pageIndex, int pageSize, string icdxsubkategoriconcate);
        Task<(IEnumerable<vicdxsubkategoriindo>,string)> GetAllVicdxsubkategoriIndoByPageIndexAndConcateAsync(int pageIndex, int pageSize, string icdxsubkategoriconcate);

    }
}
