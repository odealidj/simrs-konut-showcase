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
    public class RwRepository : IRwRepository
    {
        private string sErrthrowClassName = "RwRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RwRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RwRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(rw obj)
        {
            throw new NotImplementedException();
        }

        public rw Get(rw obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<rw> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<rw>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<rw>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<rw>, string)> GetAllRwByKeldesaIdAsync(short? keldesaid)
        {
            #region query
            _sql = "SELECT * FROM rw AS r WHERE r.keldesaid = @keldesaid AND r.rwsts = '1'";
            #endregion

            IEnumerable<rw> list;

            try
            {
                list = await _context.db.QueryAsync<rw>(_sql, new { keldesaid = keldesaid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllRwByKeldesaIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(rw, string)> GetAsync(rw obj)
        {
            throw new NotImplementedException();
        }

        public int Save(rw obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(rw obj)
        {
            throw new NotImplementedException();
        }
    }
}
