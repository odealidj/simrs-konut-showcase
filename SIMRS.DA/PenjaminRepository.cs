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
    public class PenjaminRepository : IPenjaminRepository
    {

        private string sErrthrowClassName = "PenjaminRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PenjaminRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PenjaminRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(penjaminpasien obj)
        {
            throw new NotImplementedException();
        }

        public penjaminpasien Get(penjaminpasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<penjaminpasien> GetAll()
        {
            #region query
            _sql = "SELECT * FROM penjaminpasien AS p";
            #endregion

            IEnumerable<penjaminpasien> list;

            try
            {

                list = _context.db.Query<penjaminpasien>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<(IEnumerable<penjaminpasien>,string)> GetAllAsync()
        {

            #region query
            _sql = "SELECT * FROM penjaminpasien AS p";
            #endregion

            IEnumerable<penjaminpasien> list;

            try
            {
               
                list = await _context.db.QueryAsync<penjaminpasien>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list,sErrResult);
        }

        public Task<IEnumerable<penjaminpasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(penjaminpasien obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(penjaminpasien obj)
        {
            throw new NotImplementedException();
        }

        public Task<(penjaminpasien, string)> GetAsync(penjaminpasien obj)
        {
            throw new NotImplementedException();
        }

        public (penjaminpasien, string) GetPenjaminByNoRM(string NoRM)
        {
            #region query
            _sql = "SELECT p.* FROM registrasi AS r INNER JOIN penjaminpasien AS p \n"
                +"ON p.penjaminpasienid = r.penjaminpasienid \n"
                + "WHERE r.nocm = @nocm AND r.registrasists = '1' AND p.penjaminpasiensts = '1'";
            #endregion

            penjaminpasien list;

            try
            {

                list = _context.db.QueryFirstOrDefault<penjaminpasien>(_sql,new { nocm = NoRM }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetPenjaminByNoRM";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(penjaminpasien, string)> GetPenjaminByNoRMAsync(string NoRM)
        {
            #region query
            _sql = "SELECT top 1 p.* FROM registrasi AS r INNER JOIN penjaminpasien AS p \n"
                    + "ON p.penjaminpasienid = r.penjaminpasienid \n"
                    + "WHERE r.nocm = @nocm AND r.registrasists = '1' \n"
                    + "ORDER BY r.registrasiid DESC";

            #endregion

            penjaminpasien list;

            try
            {

                list = await _context.db.QueryFirstOrDefaultAsync<penjaminpasien>(_sql, new { nocm = NoRM },commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetPenjaminByNoRMAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
