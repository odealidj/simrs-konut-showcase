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
    public class JenisdiagnosaRepository : IJenisdiagnosaRepository
    {
        private string sErrthrowClassName = "JenisdiagnosaRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public JenisdiagnosaRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public JenisdiagnosaRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(jenisdiagnosa obj)
        {
            throw new NotImplementedException();
        }

        public jenisdiagnosa Get(jenisdiagnosa obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<jenisdiagnosa> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<jenisdiagnosa>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT * FROM jenisdiagnosa AS j WHERE j.jenisdiagnosasts = '1'";

            #endregion

            IEnumerable<jenisdiagnosa> list = null;

            try
            {

                list = await _context.db.QueryAsync<jenisdiagnosa>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<jenisdiagnosa>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(jenisdiagnosa, string)> GetAsync(jenisdiagnosa obj)
        {
            throw new NotImplementedException();
        }

        public int Save(jenisdiagnosa obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(jenisdiagnosa obj)
        {
            throw new NotImplementedException();
        }
    }
}
