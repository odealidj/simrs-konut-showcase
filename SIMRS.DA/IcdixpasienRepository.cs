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
    public class IcdixpasienRepository : IIcdixpasienRepository
    {

        //private string sErrthrowClassName = "IcdixpasienRepository";
        //private string sErrthrowMethodName = string.Empty;
        //private string sErrResult = null;

        private IDapperContext _context;
        private IDbTransaction _transaction;
        //private string _sql;

        public IcdixpasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IcdixpasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(icdixpasien obj)
        {
            throw new NotImplementedException();
        }

        public icdixpasien Get(icdixpasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<icdixpasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<icdixpasien>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<icdixpasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(icdixpasien, string)> GetAsync(icdixpasien obj)
        {
            throw new NotImplementedException();
        }

        public int Save(icdixpasien obj)
        {
            throw new NotImplementedException();

        }

        public bool Update(icdixpasien obj)
        {
            throw new NotImplementedException();
        }
    }
}
