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
    public class KelasRepository : IKelasRepository
    {
        private string sErrthrowClassName = "KelasRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public KelasRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public KelasRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(kelas obj)
        {
            throw new NotImplementedException();
        }

        public kelas Get(kelas obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<kelas> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<kelas>, string)> GetAllAsync()
        {

            #region query
            _sql = "SELECT * FROM kelas AS k WHERE k.kelassts = '1'";
            #endregion

            IEnumerable<kelas> list;

            try
            {
                list = await _context.db.QueryAsync<kelas>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<kelas>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(kelas obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(kelas obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<kelas>, string)> GetAllKelasBPJSAsync()
        {
            #region query
            _sql = "SELECT k.* FROM kelasbpjs kjs INNER JOIN kelas AS k\n " 
                    +"ON k.kelasid = kjs.kelasbpjsid";
            #endregion

            IEnumerable<kelas> list;

            try
            {
                list = await _context.db.QueryAsync<kelas>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllKelasBPJSAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(kelas, string)> GetAsync(kelas obj)
        {
            throw new NotImplementedException();
        }
    }
}
