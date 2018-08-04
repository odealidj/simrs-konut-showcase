using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand
{
    public interface IListRegistrasiRepository
    {
        Task<(v_identitaspasien_for_listregistrasi, string)> GetVidentitaspasien_for_listregistrasiByNoCMAsync(string nocm);
    }
}
