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
    public class DokterRepository : IDokterRepository
    {
        private string sErrthrowClassName = "DokterRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public DokterRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public DokterRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(dokter obj)
        {
            throw new NotImplementedException();
        }

        public dokter Get(dokter obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dokter> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<dokter>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT * FROM dokter AS d WHERE d.doktersts = '1'";

            #endregion

            IEnumerable<dokter> list = null;

            try
            {

                list = await _context.db.QueryAsync<dokter>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<dokter>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(dokter, string)> GetAsync(dokter obj)
        {
            throw new NotImplementedException();
        }

        public int Save(dokter obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(dokter obj)
        {
            throw new NotImplementedException();
        }
    }
}
