using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SIMRS.DA
{
    public class AgamaRepository : IAgamaRepository
    {
        private string sErrthrowClassName = "AgamaRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AgamaRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AgamaRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(agama obj)
        {
            throw new NotImplementedException();
        }

        public agama Get(agama obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<agama> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<agama>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT * FROM agama AS a WHERE a.agamasts = '1'";

            #endregion

            IEnumerable<agama> list;

            try
            {
                list = await _context.db.QueryAsync<agama>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<agama>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(agama, string)> GetAsync(agama obj)
        {
            throw new NotImplementedException();
        }

        public int Save(agama obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(agama obj)
        {
            throw new NotImplementedException();
        }
    }
}
