using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptbarangsatuanRepository : IBaseRepository<aptbarangsatuan>
    {
        Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> GetAllByAptbarangidAsync(short aptbarangid);
        Task<(IEnumerable<aptbarangsatuan>, string)> GetAllByIdAsync(short aptbarangsatuanid);

        Task<(IEnumerable<v_aptbarangsatuan>, string)> GetAll_v_aptbarangsatuanAsync();

        Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> GetAll_v_aptbarangsatuan_pbfByPbfAsync(short pbfid);



        new(int, string) Save(aptbarangsatuan obj);

        new string Delete(aptbarangsatuan obj);
    }
}
