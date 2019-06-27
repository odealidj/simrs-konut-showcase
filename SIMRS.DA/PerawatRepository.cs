using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class PerawatRepository : IPerawatRepository
    {
        private string sErrthrowClassName = "PerawatRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PerawatRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PerawatRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(perawat obj)
        {
            throw new NotImplementedException();
        }

        public perawat Get(perawat obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<perawat> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<perawat>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT * FROM perawat AS p WHERE p.perawatsts = '1'";

            #endregion

            IEnumerable<perawat> list = null;

            try
            {

                list = await _context.db.QueryAsync<perawat>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<perawat>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_perawat>, string)> GetAllVperawatAsync()
        {
            #region query

            _sql = "SELECT * FROM v_perawat";

            #endregion

            IEnumerable<v_perawat> list = null;

            try
            {

                list = await _context.db.QueryAsync<v_perawat>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVperawatAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(perawat, string)> GetAsync(perawat obj)
        {
            throw new NotImplementedException();
        }

        public int Save(perawat obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(perawat obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_perawat>, string)> GetAllVperawatAsync(short ruangrawatid)
        {
            #region query

            _sql = "SELECT * FROM v_perawat Where ruangrawatid = @ruangrawatid";

            #endregion

            IEnumerable<v_perawat> list = null;

            try
            {

                list = await _context.db.QueryAsync<v_perawat>(_sql, new { ruangrawatid = ruangrawatid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVperawatAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
