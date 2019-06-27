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
    public class PerujukRepository : IPerujukRepository
    {
        private string sErrthrowClassName = "PerujukRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PerujukRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PerujukRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(perujuk obj)
        {
            throw new NotImplementedException();
        }

        public perujuk Get(perujuk obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<perujuk> GetAll()
        {
            #region query
            _sql = "SELECT * FROM perujuk AS p WHERE p.perujuksts = '1'";
            #endregion

            IEnumerable<perujuk> list;

            try
            {
                list = _context.db.Query<perujuk>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<(IEnumerable<perujuk>, string)> GetAllAsync()
        {
            #region query
            _sql = "SELECT * FROM perujuk AS p WHERE p.perujuksts = '1'";
            #endregion

            IEnumerable<perujuk> list;

            try
            {
                list = await _context.db.QueryAsync<perujuk>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);

        }

        public Task<IEnumerable<perujuk>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(perujuk obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(perujuk obj)
        {
            throw new NotImplementedException();
        }

        public Task<(perujuk, string)> GetAsync(perujuk obj)
        {
            throw new NotImplementedException();
        }

        public perujuk GetPerujukByPuskesmasId(short puskesmasid)
        {
            #region query
            _sql = "SELECT p2.* FROM puskesmas AS p INNER JOIN perujuk AS p2 ON p2.perujukid = p.perujukid \n"
                + "WHERE p.puskesmasid = @puskesmasid";
            #endregion

            perujuk list;

            try
            {
                list = _context.db.QueryFirstOrDefault<perujuk>(_sql, new { puskesmasid= puskesmasid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }
    }
}
