using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using SIMRS.Model.view;

namespace SIMRS.DA
{
    public class IcdxpuskesmasRepository : IIcdxpuskesmasRepository
    {
        private string sErrthrowClassName = "IcdxpuskesmasRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IcdxpuskesmasRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IcdxpuskesmasRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(icdxpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public icdxpuskesmas Get(icdxpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<icdxpuskesmas> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<icdxpuskesmas>, string)> GetAllAsync()
        {
            #region query
                _sql = "SELECT * FROM icdxpuskesmas AS i WHERE i.icdxpuskesmassts = '1'";
            #endregion

            IEnumerable<icdxpuskesmas> list;

            try
            {
                    list = await _context.db.QueryAsync<icdxpuskesmas>(_sql, commandType: CommandType.Text);
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<icdxpuskesmas>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<icdxpuskesmas>, string) GetAllIcdxpuskesmasByname(string icdxname)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<icdxpuskesmas>, string)> GetAllIcdxpuskesmasBynameAsync(string icdxname)
        {
            throw new NotImplementedException();
        }

        public Task<(icdxpuskesmas, string)> GetAsync(icdxpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public int Save(icdxpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(icdxpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<vicdxpuskesmas>, string)> GetAllVicdxpuskesmasAsync()
        {
            #region query
            _sql = "SELECT * FROM vicdxpuskesmas AS v";
            #endregion

            IEnumerable<vicdxpuskesmas> list;

            try
            {
                list = await _context.db.QueryAsync<vicdxpuskesmas>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVicdxpuskesmasAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<vicdxpuskesmas>, string)> GetAllVicdxpuskesmasByKodenamaAsync(string kodenama)
        {
            #region query
            _sql = "SELECT * FROM vicdxpuskesmas AS v WHERE v.icdxpuskesmaskodenama LIKE @icdxpuskesmaskodenama";
            #endregion

            IEnumerable<vicdxpuskesmas> list;

            try
            {
                list = await _context.db.QueryAsync<vicdxpuskesmas>(_sql, new { icdxpuskesmaskodenama = kodenama }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVicdxpuskesmasByKodenamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
