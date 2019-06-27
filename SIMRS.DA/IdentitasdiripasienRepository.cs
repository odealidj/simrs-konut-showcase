using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA
{
    public class IdentitasdiripasienRepository : IIdentitasdiripasienRepository
    {
        //private string sErrthrowClassName = "IdentitasdiripasienRepository";
        //private string sErrthrowMethodName = "";
        //private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        //private string _sql;

        public IdentitasdiripasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IdentitasdiripasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(identitasdiripasien obj)
        {
            throw new NotImplementedException();
        }

        public identitasdiripasien Get(identitasdiripasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<identitasdiripasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<identitasdiripasien>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<identitasdiripasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(identitasdiripasien, string)> GetAsync(identitasdiripasien obj)
        {
            throw new NotImplementedException();
        }

        public int Save(identitasdiripasien obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(identitasdiripasien obj)
        {
            throw new NotImplementedException();
        }
    }
}
