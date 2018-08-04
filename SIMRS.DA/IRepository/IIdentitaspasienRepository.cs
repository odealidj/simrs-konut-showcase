using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IIdentitaspasienRepository : IBaseRepository<identitaspasien>
    {
        new (string, string) Save(identitaspasien obj);

        Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>,string)> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAsync(int pageIndex, int pageSize);
        Task<IEnumerable<v_identitaspasien_jk_alamatpasien>> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndNoCmAsync(int pageIndex, int pageSize,string nocm);
        Task<IEnumerable<v_identitaspasien_jk_alamatpasien>> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndNamaAsync(int pageIndex, int pageSize, string nama);
        Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>,string)> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync(int pageIndex, int pageSize, string value);
        Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>, string)> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(int pageIndex, int pageSize, string value);

        Task<(v_identitaspasien_for_listidentitaspasien, string)> GetVidentitaspasien_for_listidentitaspasienByNoCMAsync(string nocm);
        Task<(identitaspasien, string)> GetIdentitasPasienByNocmAsync(string nocm);

        bool UpdateNoRM(string oldNoRM, string newNoRM);
        bool IsNoRMIsExists(string norm);
    }
}
