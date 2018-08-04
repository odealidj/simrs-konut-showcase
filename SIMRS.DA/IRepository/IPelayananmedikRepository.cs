using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPelayananmedikRepository : IBaseRepository<pelayananmedik>
    {
        (IEnumerable<pelayananmedik>,string) GetAllByModulappkode(string modulappkode);
        Task<(pelayananmedik, string)> GetAllPelayananmedikByModulappkodeAsync(string modulappkode);
        (pelayananmedik, string) GetAllPelayananmedikByModulappkode(string modulappkode);
        
    }
}
