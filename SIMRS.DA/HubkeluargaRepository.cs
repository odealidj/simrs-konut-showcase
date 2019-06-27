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
    public class HubkeluargaRepository : IHubkeluargaRepository
    {
        private string sErrthrowClassName = "HubkeluargaRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public HubkeluargaRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public HubkeluargaRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(hubkeluarga obj)
        {
            throw new NotImplementedException();
        }

        public hubkeluarga Get(hubkeluarga obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<hubkeluarga> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<hubkeluarga>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT h.hubkeluargaid,h.hubkeluarganm FROM hubkeluarga AS h  WHERE h.hubkeluargasts = '1'";

            #endregion

            IEnumerable<hubkeluarga> list;

            try
            {
                list = await _context.db.QueryAsync<hubkeluarga>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<hubkeluarga>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(hubkeluarga, string)> GetAsync(hubkeluarga obj)
        {
            throw new NotImplementedException();
        }

        public int Save(hubkeluarga obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(hubkeluarga obj)
        {
            throw new NotImplementedException();
        }
    }
}
