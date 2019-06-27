using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class JkRepository : IJkRepository
    {

        private string sErrthrowClassName = "JkRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public JkRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public JkRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(jk obj)
        {
            throw new NotImplementedException();
        }

        public jk Get(jk obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<jk> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<jk>, string)> GetAllAsync()
        {
            #region query
            _sql = "SELECT * FROM jk AS j";
            #endregion

            IEnumerable<jk> list;

            try
            {
                list = await _context.db.QueryAsync<jk>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<jk>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(jk obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(jk obj)
        {
            throw new NotImplementedException();
        }

        public Task<(jk, string)> GetAsync(jk obj)
        {
            throw new NotImplementedException();
        }
    }
}
