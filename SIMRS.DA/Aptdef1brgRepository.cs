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
    public class Aptdef1brgRepository : IAptdef1brgRepository
    {
        private string sErrthrowClassName = "Aptdef1brgRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public Aptdef1brgRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public Aptdef1brgRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptdef1brg obj)
        {
            throw new NotImplementedException();
        }

        public aptdef1brg Get(aptdef1brg obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptdef1brg> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptdef1brg>, string)> GetAllAsync()
        {
            #region query
           
                _sql = "SELECT * FROM aptdef1brg AS a;";

           
            #endregion

            IEnumerable<aptdef1brg> list;

            try
            {
               
                    list = await _context.db.QueryAsync<aptdef1brg>(_sql, commandType: CommandType.Text);
               
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<aptdef1brg>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptdef1brg, string)> GetAsync(aptdef1brg obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptdef1brg obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptdef1brg obj)
        {
            throw new NotImplementedException();
        }
    }
}
