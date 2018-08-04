using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface ILoginmodulappRepository:IBaseRepository<loginmodulapp>
    {
        (loginmodulapp,string) getLoginmodulappByLoginappidAndModulappid(short loginappid, string modulappkode);
        Task<(loginappdetail, loginmodulapp, string)> GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkodeAsync(string username, string password, string modulappkode);
        (loginappdetail, loginmodulapp, string) GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode(string username, string password, string modulappkode);
    }
}
