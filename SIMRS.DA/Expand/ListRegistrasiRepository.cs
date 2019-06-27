using SIMRS.DA.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SIMRS.DA.IRepository.IExpand;
using SIMRS.Model.view;

namespace SIMRS.DA.Expand
{
    public class ListRegistrasiRepository : IListRegistrasiRepository
    {
        private string sErrthrowClassName = "ListRegistrasiRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public ListRegistrasiRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public ListRegistrasiRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(v_identitaspasien_for_listregistrasi, string)> GetVidentitaspasien_for_listregistrasiByNoCMAsync(string nocm)
        {
            #region query

            if (!string.IsNullOrEmpty(nocm))
            {
                _sql = "SELECT * FROM v_identitaspasien_for_listregistrasi AS ifl WHERE ifl.nocm = @nocm";
            }

            #endregion

            v_identitaspasien_for_listregistrasi list = null;

            try
            {

                if (!string.IsNullOrEmpty(nocm))
                {
                    list = await _context.db.QueryFirstOrDefaultAsync<v_identitaspasien_for_listregistrasi>(_sql, new { nocm = nocm }, commandType: CommandType.Text);
                }
                
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVidentitaspasien_for_listregistrasiByNoCMAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
