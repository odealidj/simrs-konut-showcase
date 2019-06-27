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
    public class KotakabRepository : IKotakabRepository
    {
        private string sErrthrowClassName = "KotakabRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public KotakabRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public KotakabRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(kotakab obj)
        {
            throw new NotImplementedException();
        }

        public kotakab Get(kotakab obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<kotakab> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<kotakab>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<kotakab>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(kotakab, string)> GetAsync(kotakab obj)
        {
            throw new NotImplementedException();
        }

        public int Save(kotakab obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(kotakab obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<kotakab>, string)> GetAllKotakabByPropinsiIdAsync(short? propinsiid)
        {
            #region query
            _sql = "SELECT * FROM kotakab AS k WHERE k.propinsiid = @propinsiid AND k.kotakabsts = '1'";
            #endregion

            IEnumerable<kotakab> list;

            try
            {
                list = await _context.db.QueryAsync<kotakab>(_sql, new { propinsiid = propinsiid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllKotakabByPropinsiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
