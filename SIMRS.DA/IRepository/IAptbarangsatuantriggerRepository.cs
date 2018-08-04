using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptbarangsatuantriggerRepository :IBaseRepository<aptbarangsatuantrigger>
    {

        Task<(IEnumerable<aptbarangsatuantrigger>, string)> GetAllByAptbarangsatuanidAsync(short Aptbarangsatuanid);
        (IEnumerable<aptbarangsatuantrigger>, string) GetAllByAptbarangsatuanid(short Aptbarangsatuanid);

        new (IEnumerable<aptbarangsatuantrigger>, string) GetAll();

        new(int, string) Save(aptbarangsatuantrigger obj);

        new string Delete(aptbarangsatuantrigger obj);

        string DeleteByAptbarangsatuanId(short aptbarangsatuanId);
    }
}
