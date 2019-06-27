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
    public class IdentitasdiriRepository : IIdentitasdiriRepository
    {
        private string sErrthrowClassName = "IdentitasdiriRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IdentitasdiriRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IdentitasdiriRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(identitasdiri obj)
        {
            throw new NotImplementedException();
        }

        public identitasdiri Get(identitasdiri obj)
        {
            #region query
            _sql = "SELECT * FROM identitasdiri AS i WHERE i.identitasdiriid = @identitasdiriid";
            #endregion

            identitasdiri list;

            try
            {
                list = _context.db.QueryFirstOrDefault<identitasdiri>(_sql, new { identitasdiriid = obj.identitasdiriid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Get";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public IEnumerable<identitasdiri> GetAll()
        {
            #region query

            _sql = "SELECT i.identitasdiriid, i.identitasdirinm FROM identitasdiri AS i WHERE i.identitasdirists = '1'";

            #endregion

            IEnumerable<identitasdiri> list;

            try
            {
                list = _context.db.Query<identitasdiri>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;

        }

        public async Task<(IEnumerable<identitasdiri>, string)> GetAllAsync()
        {
            #region query
           
                _sql = "SELECT i.identitasdiriid, i.identitasdirinm FROM identitasdiri AS i WHERE i.identitasdirists = '1'";

            #endregion

            IEnumerable<identitasdiri> list;

            try
            {
                    list = await _context.db.QueryAsync<identitasdiri>(_sql, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<identitasdiri>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(identitasdiri, string)> GetAsync(identitasdiri obj)
        {
            throw new NotImplementedException();
        }

        public int Save(identitasdiri obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(identitasdiri obj)
        {
            throw new NotImplementedException();
        }
    }
}
