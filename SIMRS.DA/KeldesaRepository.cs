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
    public class KeldesaRepository : IKeldesaRepository
    {
        private string sErrthrowClassName = "KeldesaRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public KeldesaRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public KeldesaRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(keldesa obj)
        {
            throw new NotImplementedException();
        }

        public keldesa Get(keldesa obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<keldesa> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<keldesa>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<keldesa>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<keldesa>, string)> GetAllKeldesaByKecIdAsync(short? kecid)
        {
            #region query
            _sql = "SELECT * FROM keldesa AS k WHERE k.kecid = @kecid AND k.keldesasts = '1'";
            #endregion

            IEnumerable<keldesa> list;

            try
            {
                list = await _context.db.QueryAsync<keldesa>(_sql, new { kecid = kecid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllKeldesaByKecIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);

        }

        public Task<(keldesa, string)> GetAsync(keldesa obj)
        {
            throw new NotImplementedException();
        }

        public int Save(keldesa obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(keldesa obj)
        {
            throw new NotImplementedException();
        }
    }
}
