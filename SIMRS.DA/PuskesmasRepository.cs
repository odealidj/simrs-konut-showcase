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
    public class PuskesmasRepository : IPuskesmasRepository
    {
        private string sErrthrowClassName = "PuskesmasRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PuskesmasRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PuskesmasRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(puskesmas obj)
        {
            throw new NotImplementedException();
        }

        public puskesmas Get(puskesmas obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<puskesmas> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<puskesmas>, string)> GetAllAsync()
        {
            #region query
            _sql = "SELECT * FROM puskesmas AS p WHERE p.puskesmassts = '1'";
            #endregion

            IEnumerable<puskesmas> list;

            try
            {
                list = await _context.db.QueryAsync<puskesmas>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<puskesmas>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(puskesmas obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(puskesmas obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<puskesmas> GetAllPuskesmasByPerujukId(short perujukid)
        {
            #region query
            _sql = "SELECT * FROM puskesmas AS p WHERE p.perujukid = @perujukid AND  p.puskesmassts = '1';";
            #endregion

            IEnumerable<puskesmas> list;

            try
            {
                list = _context.db.Query<puskesmas>(_sql, new { perujukid = perujukid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPuskesmasByPerujukId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<(IEnumerable<puskesmas>, string)> GetAllPuskesmasByPerujukIdAsync(short perujukid)
        {
            #region query
            _sql = "SELECT * FROM puskesmas AS p WHERE p.perujukid = @perujukid AND  p.puskesmassts = '1';";
            #endregion

            IEnumerable<puskesmas> list;

            try
            {
                list = await _context.db.QueryAsync<puskesmas>(_sql, new { perujukid = perujukid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPuskesmasByPerujukIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(puskesmas, string)> GetAsync(puskesmas obj)
        {
            #region query
            _sql = "SELECT * FROM puskesmas AS p WHERE p.puskesmasid = @puskesmasid;";
            #endregion

            puskesmas list;

            try
            {
                list = await _context.db.QueryFirstOrDefaultAsync<puskesmas>(_sql, new { puskesmasid = obj.puskesmasid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
