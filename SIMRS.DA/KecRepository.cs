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
    public class KecRepository : IKecRepository
    {
        private string sErrthrowClassName = "KecRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public KecRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public KecRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(kec obj)
        {
            throw new NotImplementedException();
        }

        public kec Get(kec obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<kec> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<kec>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<kec>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<kec>, string)> GetAllKecByKotakabIdAsync(short? kotakabid)
        {
            #region query
            _sql = "SELECT * FROM kec AS k WHERE k.kotakabid = @kotakabid AND k.kecsts = '1'";
            #endregion

            IEnumerable<kec> list;

            try
            {
                list = await _context.db.QueryAsync<kec>(_sql, new { kotakabid = kotakabid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllKecByKotakabIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(kec, string)> GetAsync(kec obj)
        {
            throw new NotImplementedException();
        }

        public int Save(kec obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(kec obj)
        {
            throw new NotImplementedException();
        }
    }
}
