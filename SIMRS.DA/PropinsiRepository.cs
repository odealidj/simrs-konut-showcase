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
    public class PropinsiRepository : IPropinsiRepository
    {

        private string sErrthrowClassName = "PropinsiRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PropinsiRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PropinsiRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(propinsi obj)
        {
            throw new NotImplementedException();
        }

        public propinsi Get(propinsi obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<propinsi> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<propinsi>, string)> GetAllAsync()
        {
            #region query
            _sql = "SELECT * FROM propinsi AS p WHERE p.propinsists = '1'";
            #endregion

            IEnumerable<propinsi> list;

            try
            {
                list = await _context.db.QueryAsync<propinsi>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<propinsi>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(propinsi, string)> GetAsync(propinsi obj)
        {
            throw new NotImplementedException();
        }

        public int Save(propinsi obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(propinsi obj)
        {
            throw new NotImplementedException();
        }
    }
}
