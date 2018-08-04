using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptbarangmasukRepository : IBaseRepository<aptbarangmasuk>
    {
        Task<(IEnumerable<v_aptpembelian>, string)> GetAll_v_aptpembelianByYearAndMonthAsync(short year, short month);

        Task<(IEnumerable<v_aptpembelian>, string)> GetAll_v_aptpembelianByYearAndMonthAsync(string year, string month);
        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByYearAndMonth(short year, short month);
        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByYearAndMonth(string year, string month);

        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByYearAndMonth(string value);

        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByKeterangan(string value);
        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelian();
        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelian(string tahun, string bulan, string search);
        (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelian_notin__aptbrggudetail();

        Task<(IEnumerable<v_aptbarangmasuk_pbf_notin_aptbrggudetail>, string)> GetAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail();
        

        new(int ,string) Save(aptbarangmasuk obj);

        new string Delete(aptbarangmasuk obj);
    }
}
